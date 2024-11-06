using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types.MethodTypes
{
    public class RetrievalMethodType
    {
        public TransformType[] Transforms { get; set; }

        public string URI { get; set; }

        public string Type { get; set; }
    }
}
