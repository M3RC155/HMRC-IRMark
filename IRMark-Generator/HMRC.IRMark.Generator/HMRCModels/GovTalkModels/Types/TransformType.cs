using System;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types
{
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class TransformType
    {
        /// <remarks/>
        [XmlAnyElement()]
        [XmlElement("XPath", typeof(string))]
        public object[] Items { get; set; }

        /// <remarks/>
        [XmlText()]
        public string[] Text { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "anyURI")]
        public string Algorithm { get; set; }
    }
}
