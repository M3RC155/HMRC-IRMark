using SmartAssembly.Attributes;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels
{
    /// <remarks/>
    /// minOccurs="1" maxOccurs="1"
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public class GovTalkMessageHeaderMessageDetails
    {
        /// <remarks/>
        /// minOccurs="1" maxOccurs="1"
        [Length(4,32)]
        public string Class { get; set; }

        /// <remarks/>
        /// minOccurs="1" maxOccurs="1"
        public GovTalkMessageHeaderMessageDetailsQualifier Qualifier { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        public GovTalkMessageHeaderMessageDetailsFunction Function { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool FunctionSpecified { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        [Length(0, 32)]
        [RegularExpression("[0-9A-F]{0,32}")]
        public string TransactionID { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        [Length(0, 32)]
        [RegularExpression("[A-F0-9]{0,32}")]
        public string AuditID { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        [Length(0, 32)]
        [RegularExpression("[0-9A-F]{0,32}")]
        public string CorrelationID { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        public GovTalkMessageHeaderMessageDetailsResponseEndPoint ResponseEndPoint { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        public GovTalkMessageHeaderMessageDetailsTransformation Transformation { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool TransformationSpecified { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        [XmlElement(DataType = "integer")]
        public int GatewayTest { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        public DateTime GatewayTimestamp { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool GatewayTimestampSpecified { get; set; }
    }

    /// <remarks/>
    /// minOccurs="0" maxOccurs="1"
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public class GovTalkMessageHeaderMessageDetailsResponseEndPoint
    {
        public GovTalkMessageHeaderMessageDetailsResponseEndPoint()
        {
            Value = 2;
        }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        [XmlAttribute(DataType = "integer")]
        [DefaultValue("2")]
        public string PollInterval
        {
            get
            {
                return Value.ToString();
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public int Value { private get; set; }
    }

    /// <remarks/>
    /// minOccurs="0" maxOccurs="1"
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public enum GovTalkMessageHeaderMessageDetailsFunction
    {
        list,
        read,
        delete,
        add,
        submit,
    }

    /// <remarks/>
    /// minOccurs="0" maxOccurs="1"
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public enum GovTalkMessageHeaderMessageDetailsQualifier
    {
        request,
        acknowledgement,
        response,
        poll,
        error,
    }

    /// <remarks/>
    /// minOccurs="0" maxOccurs="1"
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public enum GovTalkMessageHeaderMessageDetailsTransformation
    {
        XML,
        HTML,
        text,
    }
}
