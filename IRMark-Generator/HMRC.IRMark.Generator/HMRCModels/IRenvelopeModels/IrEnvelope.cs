using System.Xml.Serialization;
using System;
namespace HMRC.IRMark.Generator.IrEnvelope
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    [XmlRoot(Namespace = "http://www.govtalk.gov.uk/taxation/CT/5", IsNullable = false)]
    public class IRenvelope
    {
        /// <remarks/>
        public IRheader IRheader { get; set; }

        /// <remarks/>
        public CompanyTaxReturn CompanyTaxReturn { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class IRheader
    {
        /// <remarks/>
        [XmlElement(DataType = "date")]
        public DateTime PeriodEnd { get; set; }

        /// <remarks/>
        public IRmark IRmark { get; set; }

        /// <remarks/>
        public string Sender { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class IRmark
    {
        /// <remarks/>
        [XmlAttribute()]
        public string Type { get; set; }

        /// <remarks/>
        [XmlText()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CompanyTaxReturn
    {
        /// <remarks/>
        public CompanyInformation CompanyInformation { get; set; }

        /// <remarks/>
        public ReturnInfoSummary ReturnInfoSummary { get; set; }

        /// <remarks/>
        public CompanyTaxCalculation CompanyTaxCalculation { get; set; }

        /// <remarks/>
        public CalculationOfTaxOutstandingOrOverpaid CalculationOfTaxOutstandingOrOverpaid { get; set; }

        /// <remarks/>
        public Declaration Declaration { get; set; }

        /// <remarks/>
        [XmlArrayItem("Attachment", IsNullable = false)]
        public Attachment[] AttachedFiles { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string ReturnType { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CompanyInformation
    {
        /// <remarks/>
        public string CompanyName { get; set; }

        /// <remarks/>
        public string Reference { get; set; }

        /// <remarks/>
        public byte CompanyType { get; set; }

        /// <remarks/>
        public PeriodCovered PeriodCovered { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class PeriodCovered
    {
        /// <remarks/>
        [XmlElement(DataType = "date")]
        public DateTime From { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public DateTime To { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ReturnInfoSummary
    {
        /// <remarks/>
        public object Accounts { get; set; }

        /// <remarks/>
        public Computations Computations { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Computations
    {
        /// <remarks/>
        public string ThisPeriodComputations { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CompanyTaxCalculation
    {
        /// <remarks/>
        public object Income { get; set; }

        /// <remarks/>
        public ChargeableProfits ChargeableProfits { get; set; }

        /// <remarks/>
        public NetCorporationTaxChargeable NetCorporationTaxChargeable { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ChargeableProfits
    {
        /// <remarks/>
        [XmlAttribute()]
        public string Currency { get; set; }

        /// <remarks/>
        [XmlText()]
        public decimal Value { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NetCorporationTaxChargeable
    {
        /// <remarks/>
        [XmlAttribute()]
        public string Currency { get; set; }

        /// <remarks/>
        [XmlText()]
        public decimal Value { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CalculationOfTaxOutstandingOrOverpaid
    {
        /// <remarks/>
        public CalculationOfTaxOutstandingOrOverpaidTaxPayable TaxPayable { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CalculationOfTaxOutstandingOrOverpaidTaxPayable
    {
        /// <remarks/>
        [XmlAttribute()]
        public string Currency { get; set; }

        /// <remarks/>
        [XmlText()]
        public decimal Value { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Declaration
    {
        /// <remarks/>
        public string AcceptDeclaration { get; set; }

        /// <remarks/>
        public string Name { get; set; }

        /// <remarks/>
        public string Status { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Attachment
    {
        /// <remarks/>
        [XmlAttribute()]
        public string Description { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Filename { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Format { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "integer")]
        public string Size { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Type { get; set; }

        /// <remarks/>
        [XmlText()]
        public string Value { get; set; }
    }
}

