using System;
using System.ComponentModel;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels
{
    public class GovTalkMessageHeaderMessageDetails
    {
        public string Class { get; set; }

        public GovTalkMessageHeaderMessageDetailsQualifier Qualifier { get; set; }

        public GovTalkMessageHeaderMessageDetailsFunction Function { get; set; }

        public bool FunctionSpecified { get; set; }

        public string TransactionID { get; set; }

        public string AuditID { get; set; }

        public string CorrelationID { get; set; }

        public GovTalkMessageHeaderMessageDetailsResponseEndPoint ResponseEndPoint { get; set; }

        public GovTalkMessageHeaderMessageDetailsTransformation Transformation { get; set; }

        public bool TransformationSpecified { get; set; }

        public string GatewayTest { get; set; }

        public DateTime GatewayTimestamp { get; set; }

        public bool GatewayTimestampSpecified { get; set; }
    }

    public class GovTalkMessageHeaderMessageDetailsResponseEndPoint
    {
        public GovTalkMessageHeaderMessageDetailsResponseEndPoint()
        {
            PollInterval = "2";
        }

        [DefaultValue("2")]
        public string PollInterval { get; set; }

        public string Value { get; set; }
    }

    public enum GovTalkMessageHeaderMessageDetailsFunction
    {
        list,
        read,
        delete,
        add,
        submit,
    }

    public enum GovTalkMessageHeaderMessageDetailsQualifier
    {
        request,
        acknowledgement,
        response,
        poll,
        error,
    }

    public enum GovTalkMessageHeaderMessageDetailsTransformation
    {
        XML,
        HTML,
        text,
    }
}
