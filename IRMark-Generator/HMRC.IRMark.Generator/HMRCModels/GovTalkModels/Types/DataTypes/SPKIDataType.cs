using System.Xml;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types.DataTypes
{
    public class SPKIDataType
    {
        public byte[][] SPKISexp { get; set; }

        public XmlElement Any { get; set; }
    }
}
