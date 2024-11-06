using System.Xml;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types
{
    public class SignaturePropertiesType
    {
        public SignaturePropertyType[] SignatureProperty { get; set; }

        public string Id { get; set; }
    }

    public class SignaturePropertyType
    {
        public XmlElement[] Items { get; set; }

        public string[] Text { get; set; }

        public string Target { get; set; }

        public string Id { get; set; }
    }
}
