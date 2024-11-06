using System;
using System.Xml;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types
{
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class SignedInfoType
    {
        /// <remarks/>
        public CanonicalizationMethodType CanonicalizationMethod { get; set; }

        /// <remarks/>
        public SignatureMethodType SignatureMethod { get; set; }

        /// <remarks/>
        [XmlElement("Reference")]
        public ReferenceType[] Reference { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class CanonicalizationMethodType
    {
        /// <remarks/>
        [XmlText()]
        [XmlAnyElement()]
        public XmlNode[] Any { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "anyURI")]
        public string Algorithm { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class SignatureMethodType
    {
        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string HMACOutputLength { get; set; }

        /// <remarks/>
        [XmlText()]
        [XmlAnyElement()]
        public XmlNode[] Any { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "anyURI")]
        public string Algorithm { get; set; }
    }
}
