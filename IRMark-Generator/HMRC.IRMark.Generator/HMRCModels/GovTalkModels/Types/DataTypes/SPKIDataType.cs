using System;
using System.Xml;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types.DataTypes
{
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("SPKIData", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class SPKIDataType
    {
        /// <remarks/>
        [XmlElement("SPKISexp", DataType = "base64Binary")]
        public byte[][] SPKISexp { get; set; }

        /// <remarks/>
        [XmlAnyElement()]
        public XmlElement Any { get; set; }
    }
}
