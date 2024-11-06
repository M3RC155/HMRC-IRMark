namespace HMRC.IRMark.Generator.HMRCModels.GovTalkModels.Types.ValueTypes
{
    public class DSAKeyValueType
    {
        public byte[] P { get; set; }

        public byte[] Q { get; set; }

        public byte[] G { get; set; }

        public byte[] Y { get; set; }

        public byte[] J { get; set; }

        public byte[] Seed { get; set; }

        public byte[] PgenCounter { get; set; }
    }
}
