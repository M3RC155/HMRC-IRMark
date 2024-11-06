using System;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types.ValueTypes
{
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("RSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class RSAKeyValueType
    {
        /// <remarks/>
        [XmlElement(DataType = "base64Binary")]
        public byte[] Modulus { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "base64Binary")]
        public byte[] Exponent { get; set; }
    }
}
