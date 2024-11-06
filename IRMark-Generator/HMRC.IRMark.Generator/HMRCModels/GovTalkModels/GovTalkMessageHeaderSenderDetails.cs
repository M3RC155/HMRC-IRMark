namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels
{
    public class GovTalkMessageHeaderSenderDetails
    {
        public GovTalkMessageHeaderSenderDetailsIDAuthentication IDAuthentication { get; set; }

        public byte[] X509Certificate { get; set; }

        public string EmailAddress { get; set; }
    }

    public class GovTalkMessageHeaderSenderDetailsIDAuthentication
    {
        public string SenderID { get; set; }

        public GovTalkMessageHeaderSenderDetailsIDAuthenticationAuthentication[] Authentication { get; set; }
    }

    public class GovTalkMessageHeaderSenderDetailsIDAuthenticationAuthentication
    {
        public GovTalkMessageHeaderSenderDetailsIDAuthenticationAuthenticationMethod Method { get; set; }

        public string Role { get; set; }

        public object Item { get; set; }
    }

    public enum GovTalkMessageHeaderSenderDetailsIDAuthenticationAuthenticationMethod
    {
        clear,
        MD5,
        W3Csigned,
    }
}
