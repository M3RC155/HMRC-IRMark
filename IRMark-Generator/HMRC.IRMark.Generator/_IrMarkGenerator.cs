using HMRC.IRMark.Generator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;

namespace Semansys.Web.Api.Services.Delivery
{
    public class IrMarkGenerator
    {
        private XmlDocument _document { get; set; }
        private byte[] _originalDoc { get; set; }

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

        public IrMarkResult EmbedIrMark()
        {
            XmlDocument xmlDocument = new XmlDocument
            {
                PreserveWhitespace = true
            };
            xmlDocument.Load(new MemoryStream(_originalDoc));
            XmlDocument body = PrepareXMLBody(xmlDocument);
            string irmark = GenerateIrMark(body);
            SetIrMark(irmark);
            using (MemoryStream stream = new MemoryStream())
            {
                _document.Save(stream);
                return new IrMarkResult
                {
                    OriginalXmlDoc = _originalDoc,
                    IrMark = irmark,
                    XmlDoc = stream.ToArray()
                };
            }
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

        private static string GenerateIrMark(XmlDocument xmlDocument)
        {
            XmlDsigC14NTransform c14N = new XmlDsigC14NTransform();
            c14N.LoadInput(xmlDocument);
            var bytes = c14N.GetDigestedOutput(SHA1.Create());
            return Convert.ToBase64String(bytes);
        }

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
}
