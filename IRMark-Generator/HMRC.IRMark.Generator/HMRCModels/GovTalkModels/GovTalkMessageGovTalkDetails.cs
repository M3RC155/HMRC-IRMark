using System.Xml;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels
{
    public class GovTalkMessageGovTalkDetails
    {
        public GovTalkMessageGovTalkDetailsKey[] Keys { get; set; }

        public string[] TargetDetails { get; set; }

        public GovTalkMessageGovTalkDetailsGatewayValidation GatewayValidation { get; set; }

        public GovTalkMessageGovTalkDetailsChannelRouting[] ChannelRouting { get; set; }

        public GovTalkMessageGovTalkDetailsError[] GovTalkErrors { get; set; }

        public GovTalkMessageGovTalkDetailsGatewayAdditions GatewayAdditions { get; set; }
    }

    public class GovTalkMessageGovTalkDetailsKey
    {
        public string Type { get; set; }

        public string Value { get; set; }
    }

    public class GovTalkMessageGovTalkDetailsGatewayAdditions
    {
        public XmlElement Any { get; set; }

        public XmlAttribute[] AnyAttr { get; set; }
    }

    public class GovTalkMessageGovTalkDetailsError
    {
        public string RaisedBy { get; set; }

        public string Number { get; set; }

        public GovTalkMessageGovTalkDetailsErrorType Type { get; set; }

        public string[] Text { get; set; }

        public string[] Location { get; set; }
    }

    public enum GovTalkMessageGovTalkDetailsErrorType
    {
        fatal,
        recoverable,
        business,
        warning,
    }

    public class GovTalkMessageGovTalkDetailsGatewayValidation
    {
        public GovTalkMessageGovTalkDetailsGatewayValidationProcessed Processed { get; set; }

        public GovTalkMessageGovTalkDetailsGatewayValidationResult Result { get; set; }
    }

    public enum GovTalkMessageGovTalkDetailsGatewayValidationProcessed
    {
        no,
        yes,
    }

    public enum GovTalkMessageGovTalkDetailsGatewayValidationResult
    {
        pass,
        fail,
    }
}
