namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types.DataTypes
{
    public class X509DataType
    {
        public object[] Items { get; set; }

        public X509DataTypeChoice[] ItemsElementName { get; set; }
    }

    public enum X509DataTypeChoice
    {
        Item,
        X509CRL,
        X509Certificate,
        X509IssuerSerial,
        X509SKI,
        X509SubjectName,
    }
}
