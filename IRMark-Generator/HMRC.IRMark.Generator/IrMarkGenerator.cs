using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

        //private string transformStr => File.ReadAllText("C:\Users\ivant\source\repos\HMRC-IRMark\IRMark-Generator\Test\stylesheet.xml");
        private byte[] transformBytes => File.ReadAllBytes("C:\\Users\\ivant\\source\\repos\\HMRC-IRMark\\IRMark-Generator\\Test\\stylesheet.xml");

        public IrMarkGenerator(string xml)
        {
            _originalDoc = Encoding.UTF8.GetBytes(xml);
            _document = new XmlDocument
            {
                PreserveWhitespace = true
            };
            _document.LoadXml(xml);
        }

        public IrMarkGenerator(byte[] xml)
        {
            _originalDoc = xml;
            _document = new XmlDocument
            {
                PreserveWhitespace = true
            };
            _document.Load(new MemoryStream(xml));
        }

        public async Task<IrMarkResult> EmbedIrMarkAsync()
        {
            XmlDocument xmlDocument = new XmlDocument
            {
                PreserveWhitespace = true
            };
            xmlDocument.Load(new MemoryStream(_originalDoc));
            XmlDocument body = PrepareXMLBody(xmlDocument);
            string irmark = await GenerateIrMarkAsync(body);
            //var test = GetMarkBytes();
            if (irmark != "MxZc6ztT3R6ebwb0RIJwbEVFNZ8=")//F5iCKO/4idH0YwLKsSIYTZFmAAI=
            {
                Console.WriteLine("irmark");
            }
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
            var bytes = c14N.GetDigestedOutput(SHA1.Create());
            result = Convert.ToBase64String(bytes);//MxZc6ztT3R6ebwb0RIJwbEVFNZ8=

            using (MemoryStream stream = (MemoryStream)c14N.GetOutput())
            {
                SHA1 sha1 = SHA1.Create();
                //var tempdoc = new XmlDocument 
                //{
                //    PreserveWhitespace = true,
                //};
                //tempdoc.Load(stream);
                var te = sha1.ComputeHash(stream.ToArray());
                byte[] hashBytes = await sha1.ComputeHashAsync(stream);
                if (hashBytes.Length == 20)
                {
                    var te2 = Convert.ToBase64String(te);
                    result = Convert.ToBase64String(hashBytes);//2jmj7l5rSw0yVb/vlWAYkK/YBwk=
                }
            }

           return result;
        }

        private void test()
        {
            XmlDocument xmlDocument = new XmlDocument();
        }

        private string GetMarkBytes()
        {

            XmlDocument doc = new XmlDocument();
            //doc.Load(new MemoryStream(Encoding.UTF8.GetBytes(transformStr)));
            doc.Load(new MemoryStream(transformBytes));
            var nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("xsl", "http://www.w3.org/1999/XSL/Transform");
            nsmgr.AddNamespace("dsig", "http://www.w3.org/2000/09/xmldsig#");

            XmlDsigXPathTransform xpathTransform = new XmlDsigXPathTransform();
            var xpathNodes = doc.SelectNodes("//dsig:XPath", nsmgr);
            xpathTransform.LoadInnerXml(xpathNodes);

            XmlDsigC14NTransform c14nTransform = new XmlDsigC14NTransform();
            var c14nNodes = doc.SelectNodes("//dsig:Transform", nsmgr);
            c14nTransform.LoadInnerXml(c14nNodes);

            MemoryStream ms = new MemoryStream(_originalDoc);
            ms.Position = 0;

            byte[] transformedBytes = PerformTransforms(ms, xpathTransform);

            Console.WriteLine("\noutput = \n" + Encoding.UTF8.GetString(transformedBytes));

            using (SHA1 sha = SHA1.Create())
            {
                sha.TransformBlock(transformedBytes, 0, transformedBytes.Length, null, 0);
                sha.TransformFinalBlock([], 0, 0);
                return Convert.ToBase64String(sha.Hash);
            }
        }

        private byte[] PerformTransforms(MemoryStream input, Transform transform)
        {
            transform.LoadInput(input);
            var output = transform.GetXml();
            using (var memoryStream = new MemoryStream())
            {
                var serializer = new DataContractJsonSerializer(output.GetType());
                serializer.WriteObject(memoryStream, output);
                return memoryStream.ToArray();
            }
        }

        //private byte[] PerformTransforms(MemoryStream input, params Transform[] transforms)
        //{
        //    var result = input;
        //    foreach (var transform in transforms)
        //    {
        //        transform.LoadInput(result);
        //        result = transform.GetOutput() as MemoryStream;
        //    }
        //    return result.ToArray();
        //}

        private static XmlDocument PrepareXMLBody(XmlDocument document)
        {
            XmlNode GovTalkMessageNode = null;
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
                    GovTalkMessageNode = node;
                }
            }

            if (GovTalkMessageNode != null)
            {
                var body = GovTalkMessageNode.ChildNodes
                        .Cast<XmlNode>()
                        .FirstOrDefault(x => x.Name == "Body");
                 
                if (body != null)
                {
                    foreach (XmlAttribute attribute in attributes)
                    {
                        ((XmlElement)body).SetAttribute(attribute.Name, attribute.Value);
                    }

                    var IRenvelope = body.ChildNodes
                        .Cast<XmlNode>()
                        .FirstOrDefault(x => x.Name == "IRenvelope");

                    var IRheader = IRenvelope?.ChildNodes
                        .Cast<XmlNode>()
                        .FirstOrDefault(x => x.Name == "IRheader");

                    var IRmark = IRheader?.ChildNodes
                        .Cast<XmlNode>()
                        .FirstOrDefault(x => x.Name == "IRmark");

                    IRheader?.RemoveChild(IRmark);

                    StringWriter sw = new StringWriter();
                    XmlTextWriter xw = new XmlTextWriter(sw);
                    body.WriteTo(xw);
                    var bodyDoc = new XmlDocument
                    {
                        PreserveWhitespace = true
                    };
                    var xml = sw.ToString();
                    bodyDoc.LoadXml(xml);
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
