namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types
{
    public class SignatureType
    {
        public SignedInfoType SignedInfo { get; set; }

        public SignatureValueType SignatureValue { get; set; }

        public KeyInfoType KeyInfo { get; set; }

        public ObjectType[] Object { get; set; }

        public string Id { get; set; }
    }

    public class SignatureValueType
    {
        public string Id { get; set; }

        public byte[] Value { get; set; }
    }

    public class KeyInfoType
    {
        public object[] Items { get; set; }

        public KeyInfoTypeChoice[] ItemsElementName { get; set; }

        public string[] Text { get; set; }

        public string Id { get; set; }
    }

    public enum KeyInfoTypeChoice
    {
        Item,
        KeyName,
        KeyValue,
        MgmtData,
        PGPData,
        RetrievalMethod,
        SPKIData,
        X509Data,
    }
}
