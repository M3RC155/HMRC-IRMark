using System;
using System.Xml;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types
{
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("SignatureProperties", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class SignaturePropertiesType
    {
        /// <remarks/>
        [XmlElement("SignatureProperty")]
        public SignaturePropertyType[] SignatureProperty { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("SignatureProperty", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class SignaturePropertyType
    {
        /// <remarks/>
        [XmlAnyElement()]
        public XmlElement[] Items { get; set; }

        /// <remarks/>
        [XmlText()]
        public string[] Text { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "anyURI")]
        public string Target { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}
