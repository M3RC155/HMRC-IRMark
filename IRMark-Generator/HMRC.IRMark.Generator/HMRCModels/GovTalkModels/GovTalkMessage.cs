using System;
using System.Xml;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels
{
    /// <remarks/>
    /// minOccurs="1" maxOccurs="1"
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    [XmlRoot(Namespace = "http://www.govtalk.gov.uk/CM/envelope", IsNullable = false)]
    public class GovTalkMessage
    {
        /// <remarks/>
        /// minOccurs="1" maxOccurs="1"
        public string EnvelopeVersion { get; set; }

        /// <remarks/>
        /// minOccurs="1" maxOccurs="1"
        public GovTalkMessageHeader Header { get; set; }

        /// <remarks/>
        /// minOccurs="1" maxOccurs="1"
        public GovTalkMessageGovTalkDetails GovTalkDetails { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        /// Is Required for IRmark
        public GovTalkMessageBody Body { get; set; }
    }


    /// <remarks/>
    /// minOccurs="0" maxOccurs="1"
    /// Is Required for IRmark
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public class GovTalkMessageBody
    {
        /// <remarks/>
        /// Required
        [XmlAnyElement()]
        public XmlElement[] Any { get; set; }

        /// <remarks/>
        /// Optional
        [XmlAnyAttribute()]
        public XmlAttribute[] AnyAttr { get; set; }
    }
}
