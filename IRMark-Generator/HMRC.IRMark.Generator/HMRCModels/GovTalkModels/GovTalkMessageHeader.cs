using System;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels
{
    /// <remarks/>
    /// minOccurs="0" maxOccurs="1"
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public class GovTalkMessageHeader
    {
        /// <remarks/>
        /// minOccurs="1" maxOccurs="1"
        public GovTalkMessageHeaderMessageDetails MessageDetails { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        public GovTalkMessageHeaderSenderDetails SenderDetails { get; set; }
    }
}
