using System;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels
{
    /// <remarks/>
    /// minOccurs="0" maxOccurs="unbounded"
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public class GovTalkMessageGovTalkDetailsChannelRouting
    {
        /// <remarks/>
        /// minOccurs="1" maxOccurs="1"
        public GovTalkMessageGovTalkDetailsChannelRoutingChannel Channel { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        [XmlElement("ID")]
        public GovTalkMessageGovTalkDetailsChannelRoutingID[] ID { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        public DateTime Timestamp { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        [XmlIgnore()]
        public bool TimestampSpecified { get; set; }
    }

    /// <remarks/>
    /// minOccurs="1" maxOccurs="1"
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public class GovTalkMessageGovTalkDetailsChannelRoutingChannel
    {
        /// <remarks/>
        /// minOccurs="1" maxOccurs="1"
        [XmlElement("Name", typeof(string))]
        [XmlElement("URI", typeof(string), DataType = "anyURI")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }

        /// <remarks/>
        /// minOccurs="1" maxOccurs="1"
        [XmlIgnore()]
        public ItemChoiceType ItemElementName { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        public string Product { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        public string Version { get; set; }
    }

    /// <remarks/>
    /// minOccurs="0" maxOccurs="1"
    [Serializable()]
    [XmlType(Namespace = "http://www.govtalk.gov.uk/CM/envelope", IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        Name,
        URI,
    }

    /// <remarks/>
    /// minOccurs="0" maxOccurs="1"
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public class GovTalkMessageGovTalkDetailsChannelRoutingID
    {
        /// <remarks/>
        /// required
        [XmlAttribute()]
        public string Type { get; set; }

        /// <remarks/>
        /// required
        [XmlText()]
        public string Value { get; set; }
    }
}
