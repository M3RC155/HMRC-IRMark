using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace HMRC.IRMark.Generator
{
    /// <summary>
    /// IRMark generation guide: https://www.gov.uk/government/publications/hmrc-irmark-for-gateway-protocol-services
    /// </summary>
    public class IrMarkGenerator
    {
        private XmlDocument _document { get; set; }
        private byte[] _originalDoc { get; set; }

        private string transformStr => @"<?xml version='1.0'?>
        <dsig:Transforms xmlns:dsig='http://www.w3.org/2000/09/xmldsig#' xmlns:gt='http://www.govtalk.gov.uk/CM/envelope'>
            <dsig:Transform Algorithm='http://www.w3.org/TR/1999/REC-xpath-19991116'>
                <dsig:XPath>
                    (count(ancestor-or-self::node()|/gt:GovTalkMessage/gt:Body)=count(ancestor-or-self::node()))
                    and
                    (count(ancestor-or-self::node()|/gt:GovTalkMessage/gt:Body/*[name()='IRenvelope']/*[name()='IRheader']/*[name()='IRmark'])!=count(ancestor-or-self::node()))
                </dsig:XPath>
            </dsig:Transform>
            <dsig:Transform Algorithm='http://www.w3.org/TR/2001/REC-xml-c14n-20010315#WithComments'/>
        </dsig:Transforms>";

        //private string transformStr => File.ReadAllText("");
        private byte[] transformBytes => File.ReadAllBytes("");

        public IrMarkGenerator(string xml)
        {
            _originalDoc = Encoding.UTF8.GetBytes(xml);
            _document = new XmlDocument();
            _document.LoadXml(xml);
        }

        public IrMarkGenerator(byte[] xml)
        {
            _originalDoc = xml;
            _document = new XmlDocument();
            _document.Load(new MemoryStream(xml));
        }

        public async Task<IrMarkResult> EmbedIrMarkAsync()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(new MemoryStream(_originalDoc));
            TransformDocument();
            XmlDocument body = PrepareXMLBody(xmlDocument);
            string irmark = await GenerateIrMarkAsync(body);
            SetIrMark(irmark);
            MemoryStream stream = new MemoryStream();
            _document.Save(stream);
            return new IrMarkResult
            {
                OriginalXmlDoc = _originalDoc,
                IrMark = irmark,
                XmlDoc = stream.ToArray()
            };
        }

        private void SetIrMark(string IrMark)
        {
            var govTalkNode = _document.ChildNodes
                .Cast<XmlNode>()
                .FirstOrDefault(x => x.Name == "GovTalkMessage");
            var body = govTalkNode?.ChildNodes
                .Cast<XmlNode>()
                .FirstOrDefault(x => x.Name == "Body");
            var irEnvelope = body?.ChildNodes
                .Cast<XmlNode>()
                .FirstOrDefault(x => x.Name == "IRenvelope");
            var irHeader = irEnvelope?.ChildNodes
                .Cast<XmlNode>()
                .FirstOrDefault(x => x.Name == "IRheader");
            var irMark = irHeader?.ChildNodes
                .Cast<XmlNode>()
                .FirstOrDefault(x => x.Name == "IRmark");
            if (irMark != null)
            {
                irMark.InnerText = IrMark;
            }
            else
            {
                var mark = _document.CreateElement("IRmark");
                mark.InnerText = IrMark;
                irHeader?.AppendChild(mark);
            }
        }

        private static async Task<string> GenerateIrMarkAsync(XmlDocument xmlDocument)
        {
            string result = string.Empty;
            XmlDsigC14NTransform c14N = new XmlDsigC14NTransform();
            c14N.LoadInput(xmlDocument);

            using (MemoryStream stream = (MemoryStream)c14N.GetOutput())
            {
                SHA1 sha1 = SHA1.Create();
                byte[] hashBytes = await sha1.ComputeHashAsync(stream);
                if (hashBytes.Length == 20)
                {
                    result = Convert.ToBase64String(hashBytes);
                }
            }

            return result;
        }

        public string TransformDocument()
        {
            try
            {
                var document = new XPathDocument(new MemoryStream(_originalDoc));
                //var style = new XPathDocument(new MemoryStream(transformBytes));
                //var document = new XmlDocument();
                //document.Load(new MemoryStream(_originalDoc));
                var style = new XmlDocument();
                style.LoadXml(transformStr);

                XmlDsigXPathTransform transform = new XmlDsigXPathTransform();
                transform.LoadInput(document);
                transform.LoadInnerXml(style.SelectNodes("//dsig:XPath"));
                StringWriter writer = new StringWriter();
                //XmlReader xmlReadB = XmlReader.Create(new MemoryStream(_originalDoc));//new XmlTextReader(new StringReader(document.DocumentElement.OuterXml));
                //transform.Transform(document, null, writer);
                var out1 = transform.GetOutput();
                var out2 = transform.GetXml();
                var res = writer.ToString();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private static XmlDocument PrepareXMLBody(XmlDocument document)
        {
            XmlElement GovTalkMessageNode = null;
            List<XmlAttribute> attributes = new List<XmlAttribute>();
            foreach (XmlNode node in document.ChildNodes)
            {
                if (node.Attributes != null)
                {
                    var tempAttributes = node.Attributes.Cast<XmlAttribute>();
                    attributes.AddRange(tempAttributes);
                }
                if (node.Name == "GovTalkMessage")
                {
                    GovTalkMessageNode = node as XmlElement;
                }
            }

            if (GovTalkMessageNode != null)
            {
                XmlElement body = null;

                body = GovTalkMessageNode.ChildNodes
                        .Cast<XmlElement>()
                        .FirstOrDefault(x => x.Name == "Body");

                if (body != null)
                {
                    foreach (XmlAttribute attribute in attributes)
                    {
                        body.SetAttribute(attribute.Name, attribute.Value);
                    }

                    var IRenvelope = body.ChildNodes
                            .Cast<XmlElement>()
                            .FirstOrDefault(x => x.Name == "IRenvelope");

                    var IRheader = IRenvelope?.ChildNodes
                        .Cast<XmlElement>()
                        .FirstOrDefault(x => x.Name == "IRheader");

                    var IRmark = IRheader?.ChildNodes
                        .Cast<XmlElement>()
                        .FirstOrDefault(x => x.Name == "IRmark");

                    IRheader?.RemoveChild(IRmark);

                    StringWriter sw = new StringWriter();
                    XmlTextWriter xw = new XmlTextWriter(sw);
                    body.WriteTo(xw);
                    var bodyDoc = new XmlDocument();
                    var test = sw.ToString();
                    bodyDoc.LoadXml(test);
                    return bodyDoc;
                }
            }
            return new XmlDocument();
        }
    }
    public class IrMarkResult
    {
        public byte[] XmlDoc { get; set; }
        public byte[] OriginalXmlDoc { get; set; }
        public string IrMark { get; set; }
    }
}
