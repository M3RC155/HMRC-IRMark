using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types.DataTypes
{
    public class PGPDataType
    {
        public object[] Items { get; set; }

        public PGPDataTypeChoice[] ItemsElementName { get; set; }
    }

    public enum PGPDataTypeChoice
    {
        Item,
        PGPKeyID,
        PGPKeyPacket,
    }
}
