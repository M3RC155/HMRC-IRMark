using System;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types.ValueTypes
{
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("KeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class KeyValueType
    {
        /// <remarks/>
        [XmlAnyElement()]
        [XmlElement("DSAKeyValue", typeof(DSAKeyValueType))]
        [XmlElement("RSAKeyValue", typeof(RSAKeyValueType))]
        public object Item { get; set; }

        /// <remarks/>
        [XmlText()]
        public string[] Text { get; set; }
    }
}
