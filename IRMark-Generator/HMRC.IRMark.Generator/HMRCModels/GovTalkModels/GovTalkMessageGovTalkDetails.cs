using System;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels
{
    /// <remarks/>
    /// minOccurs="1" maxOccurs="1"
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public class GovTalkMessageGovTalkDetails
    {
        /// <remarks/>
        /// minOccurs="0" maxOccurs="unbounded"
        [XmlArrayItem("Key", IsNullable = false)]
        public GovTalkMessageGovTalkDetailsKey[] Keys { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        [Length(1, 64)]
        [XmlArrayItem("Organisation", IsNullable = false)]
        public string[] TargetDetails { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        public GovTalkMessageGovTalkDetailsGatewayValidation GatewayValidation { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="unbounded"
        [XmlElement("ChannelRouting")]
        public GovTalkMessageGovTalkDetailsChannelRouting[] ChannelRouting { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        [XmlArrayItem("Error", IsNullable = false)]
        public GovTalkMessageGovTalkDetailsError[] GovTalkErrors { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        public GovTalkMessageGovTalkDetailsGatewayAdditions GatewayAdditions { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public class GovTalkMessageGovTalkDetailsKey
    {
        /// <remarks/>
        [XmlAttribute()]
        public string Type { get; set; }

        /// <remarks/>
        [XmlText(DataType = "token")]
        public string Value { get; set; }
    }

    /// <remarks/>
    /// minOccurs="0" maxOccurs="1"
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public class GovTalkMessageGovTalkDetailsGatewayAdditions
    {
        /// <remarks/>
        /// minOccurs="1" maxOccurs="1"
        [XmlAnyElement()]
        public XmlElement Any { get; set; }

        /// <remarks/>
        /// Not Required
        [XmlAnyAttribute()]
        public XmlAttribute[] AnyAttr { get; set; }
    }

    /// <remarks/>
    /// minOccurs="0" maxOccurs="1"
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public class GovTalkMessageGovTalkDetailsError
    {
        /// <remarks/>
        /// minOccurs="1" maxOccurs="1"
        public string RaisedBy { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        [XmlElement(DataType = "integer")]
        public string Number { get; set; }

        /// <remarks/>
        /// minOccurs="1" maxOccurs="1"
        public GovTalkMessageGovTalkDetailsErrorType Type { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="unbounded"
        [XmlElement("Text")]
        public string[] Text { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="unbounded"
        [XmlElement("Location")]
        public string[] Location { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public enum GovTalkMessageGovTalkDetailsErrorType
    {
        fatal,
        recoverable,
        business,
        warning,
    }

    /// <remarks/>
    /// minOccurs="0" maxOccurs="1"
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public class GovTalkMessageGovTalkDetailsGatewayValidation
    {
        /// <remarks/>
        /// minOccurs="1" maxOccurs="1"
        public GovTalkMessageGovTalkDetailsGatewayValidationProcessed Processed { get; set; }

        /// <remarks/>
        /// minOccurs="1" maxOccurs="1"
        public GovTalkMessageGovTalkDetailsGatewayValidationResult Result { get; set; }
    }

    /// <remarks/>
    /// minOccurs="1" maxOccurs="1"
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public enum GovTalkMessageGovTalkDetailsGatewayValidationProcessed
    {
        no,
        yes,
    }

    /// <remarks/>
    /// minOccurs="1" maxOccurs="1"
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public enum GovTalkMessageGovTalkDetailsGatewayValidationResult
    {
        pass,
        fail,
    }
}
