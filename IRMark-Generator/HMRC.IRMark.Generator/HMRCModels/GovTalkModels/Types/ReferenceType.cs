using HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types.MethodTypes;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types
{
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class ReferenceType
    {
        /// <remarks/>
        [XmlArrayItem("Transform", IsNullable = false)]
        public TransformType[] Transforms { get; set; }

        /// <remarks/>
        public DigestMethodType DigestMethod { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "base64Binary")]
        public byte[] DigestValue { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "anyURI")]
        public string URI { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "anyURI")]
        public string Type { get; set; }
    }
}
