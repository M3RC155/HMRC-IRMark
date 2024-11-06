using HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types;
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels
{
    /// <remarks/>
    /// minOccurs="0" maxOccurs="1"
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public class GovTalkMessageHeaderSenderDetails
    {
        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        public GovTalkMessageHeaderSenderDetailsIDAuthentication IDAuthentication { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        [XmlElement(DataType = "base64Binary")]
        public byte[] X509Certificate { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        [Length(3,129)]
        [RegularExpression("[A-Za-z0-9\\.\\-_]{1,64}@[A-Za-z0-9\\.\\-_]{1,64}")]
        public string EmailAddress { get; set; }
    }

    /// <remarks/>
    /// minOccurs="0" maxOccurs="1"
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public class GovTalkMessageHeaderSenderDetailsIDAuthentication
    {
        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        public string SenderID { get; set; }

        /// <remarks/>
        /// minOccurs="1" maxOccurs="unbounded"
        [XmlElement("Authentication")]
        public GovTalkMessageHeaderSenderDetailsIDAuthenticationAuthentication[] Authentication { get; set; }
    }

    /// <remarks/>
    /// minOccurs="1" maxOccurs="unbounded"
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public class GovTalkMessageHeaderSenderDetailsIDAuthenticationAuthentication
    {
        /// <remarks/>
        /// minOccurs="1" maxOccurs="1"
        public GovTalkMessageHeaderSenderDetailsIDAuthenticationAuthenticationMethod Method { get; set; }

        /// <remarks/>
        /// minOccurs="0" maxOccurs="1"
        public string Role { get; set; }

        /// <remarks/>
        /// minOccurs="1" maxOccurs="1"
        [XmlElement("Value", typeof(string))]
        [XmlElement("Signature", typeof(SignatureType), Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public object Item { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/CM/envelope")]
    public enum GovTalkMessageHeaderSenderDetailsIDAuthenticationAuthenticationMethod
    {
        clear,
        MD5,
        W3Csigned,
    }
}
