using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types.DataTypes
{
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot("PGPData", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class PGPDataType
    {
        /// <remarks/>
        [XmlAnyElement()]
        [XmlElement("PGPKeyID", typeof(byte[]), DataType = "base64Binary")]
        [XmlElement("PGPKeyPacket", typeof(byte[]), DataType = "base64Binary")]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items { get; set; }

        /// <remarks/>
        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public PGPDataTypeChoice[] ItemsElementName { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
    public enum PGPDataTypeChoice
    {
        Item,
        PGPKeyID,
        PGPKeyPacket,
    }
}
