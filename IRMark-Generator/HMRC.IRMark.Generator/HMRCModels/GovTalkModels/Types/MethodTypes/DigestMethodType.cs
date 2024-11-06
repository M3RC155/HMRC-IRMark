using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types.MethodTypes
{
    public class DigestMethodType
    {
        public XmlNode[] Any { get; set; }

        public string Algorithm { get; set; }
    }
}
