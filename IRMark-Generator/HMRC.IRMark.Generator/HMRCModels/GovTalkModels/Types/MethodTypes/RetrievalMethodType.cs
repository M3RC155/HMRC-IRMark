using System;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types.MethodTypes
{
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("RetrievalMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class RetrievalMethodType
    {
        [XmlArrayItem("Transform", IsNullable = false)]
        public TransformType[] Transforms { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "anyURI")]
        public string URI { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "anyURI")]
        public string Type { get; set; }
    }
}
