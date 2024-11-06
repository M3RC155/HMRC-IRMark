using System;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types
{
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class TransformsType
    {
        /// <remarks/>
        [XmlElement("Transform")]
        public TransformType[] Transform { get; set; }
    }
}
