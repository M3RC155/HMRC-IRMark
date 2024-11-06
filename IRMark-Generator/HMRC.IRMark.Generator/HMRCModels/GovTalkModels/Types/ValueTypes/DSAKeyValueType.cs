using System;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types.ValueTypes
{
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("DSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class DSAKeyValueType
    {
        /// <remarks/>
        [XmlElement(DataType = "base64Binary")]
        public byte[] P { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "base64Binary")]
        public byte[] Q { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "base64Binary")]
        public byte[] G { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "base64Binary")]
        public byte[] Y { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "base64Binary")]
        public byte[] J { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "base64Binary")]
        public byte[] Seed { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "base64Binary")]
        public byte[] PgenCounter { get; set; }
    }
}
