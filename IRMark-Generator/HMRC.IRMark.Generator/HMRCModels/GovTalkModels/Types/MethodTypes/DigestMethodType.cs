using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types.MethodTypes
{
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class DigestMethodType
    {
        /// <remarks/>
        [XmlText()]
        [XmlAnyElement()]
        public XmlNode[] Any { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "anyURI")]
        public string Algorithm { get; set; }
    }
}
