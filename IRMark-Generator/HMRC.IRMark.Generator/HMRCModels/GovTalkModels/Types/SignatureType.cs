using HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types.DataTypes;
using HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types.MethodTypes;
using HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types.ValueTypes;
using System;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types
{
    public class SignatureType
    {
        public SignedInfoType SignedInfo { get; set; }

        public SignatureValueType SignatureValue { get; set; }

        public KeyInfoType KeyInfo { get; set; }

        public ObjectType[] Object { get; set; }

        public string Id { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("SignatureValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class SignatureValueType
    {
        /// <remarks/>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        /// <remarks/>
        [XmlText(DataType = "base64Binary")]
        public byte[] Value { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class KeyInfoType
    {
        /// <remarks/>
        [XmlAnyElement()]
        [XmlElement("KeyName", typeof(string))]
        [XmlElement("KeyValue", typeof(KeyValueType))]
        [XmlElement("MgmtData", typeof(string))]
        [XmlElement("PGPData", typeof(PGPDataType))]
        [XmlElement("RetrievalMethod", typeof(RetrievalMethodType))]
        [XmlElement("SPKIData", typeof(SPKIDataType))]
        [XmlElement("X509Data", typeof(X509DataType))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items { get; set; }

        /// <remarks/>
        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public KeyInfoTypeChoice[] ItemsElementName { get; set; }

        /// <remarks/>
        [XmlText()]
        public string[] Text { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
    public enum KeyInfoTypeChoice
    {
        Item,
        KeyName,
        KeyValue,
        MgmtData,
        PGPData,
        RetrievalMethod,
        SPKIData,
        X509Data,
    }
}
