using System.Xml;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels
{
    public class GovTalkMessage
    {
        public string EnvelopeVersion { get; set; }

        public GovTalkMessageHeader Header { get; set; }

        public GovTalkMessageGovTalkDetails GovTalkDetails { get; set; }

        public GovTalkMessageBody Body { get; set; }
    }

    public class GovTalkMessageBody
    {
        public XmlElement[] Any { get; set; }

        public XmlAttribute[] AnyAttr { get; set; }
    }
}
