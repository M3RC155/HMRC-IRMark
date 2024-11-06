using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types
{
    public class SignedInfoType
    {
        public CanonicalizationMethodType CanonicalizationMethod { get; set; }

        public SignatureMethodType SignatureMethod { get; set; }

        public ReferenceType[] Reference { get; set; }

        public string Id { get; set; }
    }

    public class CanonicalizationMethodType
    {
        public XmlNode[] Any { get; set; }

        public string Algorithm { get; set; }
    }

    public class SignatureMethodType
    {
        public string HMACOutputLength { get; set; }

        public XmlNode[] Any { get; set; }

        public string Algorithm { get; set; }
    }
}
