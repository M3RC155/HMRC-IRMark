using System;
using System.Xml;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types
{
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("Object", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class ObjectType
    {
        /// <remarks/>
        [XmlText()]
        [XmlAnyElement()]
        public XmlNode[] Any { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string MimeType { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "anyURI")]
        public string Encoding { get; set; }
    }
}
