using System.Xml;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types
{
    public class ObjectType
    {
        public XmlNode[] Any { get; set; }

        public string Id { get; set; }

        public string MimeType { get; set; }

        public string Encoding { get; set; }
    }
}
