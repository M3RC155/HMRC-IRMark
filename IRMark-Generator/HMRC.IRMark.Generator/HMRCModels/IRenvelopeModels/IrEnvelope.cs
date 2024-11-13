using System.Xml.Serialization;
namespace HMRC.IRMark.Generator.IrEnvelope
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class IRheader
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime PeriodEnd { get; set; }

        /// <remarks/>
        public IRmark IRmark { get; set; }

        /// <remarks/>
        public string Sender { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class IRmark
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
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
        [System.Xml.Serialization.XmlArrayItemAttribute("Attachment", IsNullable = false)]
        public Attachment[] AttachedFiles { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReturnType { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class PeriodCovered
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime From { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime To { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ReturnInfoSummary
    {
        /// <remarks/>
        public object Accounts { get; set; }

        /// <remarks/>
        public Computations Computations { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Computations
    {
        /// <remarks/>
        public string ThisPeriodComputations { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ChargeableProfits
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NetCorporationTaxChargeable
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CalculationOfTaxOutstandingOrOverpaid
    {
        /// <remarks/>
        public CalculationOfTaxOutstandingOrOverpaidTaxPayable TaxPayable { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CalculationOfTaxOutstandingOrOverpaidTaxPayable
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Attachment
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Filename { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Format { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string Size { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
    }
}

