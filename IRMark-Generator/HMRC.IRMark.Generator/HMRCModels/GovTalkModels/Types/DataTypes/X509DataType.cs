using System;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types.DataTypes
{
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class X509DataType
    {
        /// <remarks/>
        [XmlAnyElement()]
        [XmlElement("X509CRL", typeof(byte[]), DataType = "base64Binary")]
        [XmlElement("X509Certificate", typeof(byte[]), DataType = "base64Binary")]
        [XmlElement("X509IssuerSerial", typeof(X509IssuerSerialType))]
        [XmlElement("X509SKI", typeof(byte[]), DataType = "base64Binary")]
        [XmlElement("X509SubjectName", typeof(string))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items { get; set; }

        /// <remarks/>
        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public X509DataTypeChoice[] ItemsElementName { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
    public enum X509DataTypeChoice
    {
        Item,
        X509CRL,
        X509Certificate,
        X509IssuerSerial,
        X509SKI,
        X509SubjectName,
    }
}
