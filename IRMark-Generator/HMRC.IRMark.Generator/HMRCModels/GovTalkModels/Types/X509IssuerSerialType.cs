using System;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types
{
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class X509IssuerSerialType
    {
        /// <remarks/>
        public string X509IssuerName { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string X509SerialNumber { get; set; }
    }
}
