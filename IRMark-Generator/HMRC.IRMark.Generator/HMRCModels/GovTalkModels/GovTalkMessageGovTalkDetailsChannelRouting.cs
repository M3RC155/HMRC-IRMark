using System;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels
{
    public class GovTalkMessageGovTalkDetailsChannelRouting
    {
        public GovTalkMessageGovTalkDetailsChannelRoutingChannel Channel { get; set; }

        public GovTalkMessageGovTalkDetailsChannelRoutingID[] ID { get; set; }

        public DateTime Timestamp { get; set; }

        public bool TimestampSpecified { get; set; }
    }

    public class GovTalkMessageGovTalkDetailsChannelRoutingChannel
    {
        public string Item { get; set; }

        public ItemChoiceType ItemElementName { get; set; }

        public string Product { get; set; }

        public string Version { get; set; }
    }

    public enum ItemChoiceType
    {
        Name,
        URI,
    }

    public class GovTalkMessageGovTalkDetailsChannelRoutingID
    {
        public string Type { get; set; }

        public string Value { get; set; }
    }
}
