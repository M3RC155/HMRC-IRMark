using System.Collections.Generic;
using System.Xml.Serialization;
namespace HMRC.IRMark.Generator.IrEnvelope
{
    [XmlRoot(ElementName = "Key", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Key
    {
        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Keys", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Keys
    {
        [XmlElement(ElementName = "Key", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<Key> Key { get; set; }
    }

    [XmlRoot(ElementName = "Name", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Name
    {
        [XmlElement(ElementName = "Ttl", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Ttl { get; set; }
        [XmlElement(ElementName = "Fore", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<string> Fore { get; set; }
        [XmlElement(ElementName = "Sur", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Sur { get; set; }
    }

    [XmlRoot(ElementName = "Email", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Email
    {
        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "Preferred")]
        public string Preferred { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Telephone", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Telephone
    {
        [XmlElement(ElementName = "Number", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Number { get; set; }
        [XmlElement(ElementName = "Extension", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Extension { get; set; }
        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "Mobile")]
        public string Mobile { get; set; }
        [XmlAttribute(AttributeName = "Preferred")]
        public string Preferred { get; set; }
    }

    [XmlRoot(ElementName = "Fax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Fax
    {
        [XmlElement(ElementName = "Number", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Number { get; set; }
        [XmlElement(ElementName = "Extension", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Extension { get; set; }
        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "Mobile")]
        public string Mobile { get; set; }
        [XmlAttribute(AttributeName = "Preferred")]
        public string Preferred { get; set; }
    }

    [XmlRoot(ElementName = "Contact", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Contact
    {
        [XmlElement(ElementName = "Name", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Name Name { get; set; }
        [XmlElement(ElementName = "Email", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<Email> Email { get; set; }
        [XmlElement(ElementName = "Telephone", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<Telephone> Telephone { get; set; }
        [XmlElement(ElementName = "Fax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<Fax> Fax { get; set; }
    }

    [XmlRoot(ElementName = "Principal", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Principal
    {
        [XmlElement(ElementName = "Contact", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Contact Contact { get; set; }
    }

    [XmlRoot(ElementName = "Address", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Address
    {
        [XmlElement(ElementName = "Line", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<string> Line { get; set; }
        [XmlElement(ElementName = "PostCode", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string PostCode { get; set; }
        [XmlElement(ElementName = "Country", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Country { get; set; }
        [XmlElement(ElementName = "AdditionalLine", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string AdditionalLine { get; set; }
    }

    [XmlRoot(ElementName = "Agent", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Agent
    {
        [XmlElement(ElementName = "AgentID", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string AgentID { get; set; }
        [XmlElement(ElementName = "Company", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Company { get; set; }
        [XmlElement(ElementName = "Address", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Address Address { get; set; }
        [XmlElement(ElementName = "Contact", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Contact Contact { get; set; }
    }

    [XmlRoot(ElementName = "Reference", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Reference
    {
        [XmlElement(ElementName = "Namespace", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Namespace { get; set; }
        [XmlElement(ElementName = "SchemaVersion", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string SchemaVersion { get; set; }
        [XmlElement(ElementName = "TopElementName", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string TopElementName { get; set; }
    }

    [XmlRoot(ElementName = "Contains", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Contains
    {
        [XmlElement(ElementName = "Reference", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<Reference> Reference { get; set; }
    }

    [XmlRoot(ElementName = "Manifest", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Manifest
    {
        [XmlElement(ElementName = "Contains", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Contains Contains { get; set; }
    }

    [XmlRoot(ElementName = "IRmark", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class IRmark
    {
        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "IRheader", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class IRheader
    {
        [XmlElement(ElementName = "Keys", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Keys Keys { get; set; }
        [XmlElement(ElementName = "PeriodEnd", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string PeriodEnd { get; set; }
        [XmlElement(ElementName = "Principal", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Principal Principal { get; set; }
        [XmlElement(ElementName = "Agent", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Agent Agent { get; set; }
        [XmlElement(ElementName = "DefaultCurrency", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string DefaultCurrency { get; set; }
        [XmlElement(ElementName = "Manifest", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Manifest Manifest { get; set; }
        [XmlElement(ElementName = "IRmark", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public IRmark IRmark { get; set; }
        [XmlElement(ElementName = "Sender", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Sender { get; set; }
    }

    [XmlRoot(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NorthernIreland
    {
        [XmlElement(ElementName = "NItradingActivity", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string NItradingActivity { get; set; }
        [XmlElement(ElementName = "SME", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string SME { get; set; }
        [XmlElement(ElementName = "NIemployer", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string NIemployer { get; set; }
        [XmlElement(ElementName = "SpecialCircumstances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string SpecialCircumstances { get; set; }
        [XmlElement(ElementName = "Trading", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Trading Trading { get; set; }
        [XmlElement(ElementName = "TotalProfits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalProfits TotalProfits { get; set; }
        [XmlElement(ElementName = "ProfitsBeforeDeductions", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ProfitsBeforeDeductions ProfitsBeforeDeductions { get; set; }
        [XmlElement(ElementName = "DeductionsAndReliefs", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public DeductionsAndReliefs DeductionsAndReliefs { get; set; }
        [XmlElement(ElementName = "TaxReconciliation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TaxReconciliation TaxReconciliation { get; set; }
        [XmlElement(ElementName = "LossesDeficitsAndExcess", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LossesDeficitsAndExcess LossesDeficitsAndExcess { get; set; }
        [XmlElement(ElementName = "Indicators", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Indicators Indicators { get; set; }
    }

    [XmlRoot(ElementName = "PeriodCovered", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class PeriodCovered
    {
        [XmlElement(ElementName = "From", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string From { get; set; }
        [XmlElement(ElementName = "To", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string To { get; set; }
    }

    [XmlRoot(ElementName = "CompanyInformation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CompanyInformation
    {
        [XmlElement(ElementName = "CompanyName", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CompanyName { get; set; }
        [XmlElement(ElementName = "RegistrationNumber", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string RegistrationNumber { get; set; }
        [XmlElement(ElementName = "Reference", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Reference { get; set; }
        [XmlElement(ElementName = "CompanyType", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CompanyType { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "PeriodCovered", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public PeriodCovered PeriodCovered { get; set; }
        [XmlElement(ElementName = "Name", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Territory", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Territory { get; set; }
        [XmlElement(ElementName = "ExemptionDue", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string ExemptionDue { get; set; }
        [XmlElement(ElementName = "Company", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<Company> Company { get; set; }
        [XmlElement(ElementName = "TotalAmountClaimed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalAmountClaimed TotalAmountClaimed { get; set; }
    }

    [XmlRoot(ElementName = "TransferPricing", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TransferPricing
    {
        [XmlElement(ElementName = "Adjustment", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Adjustment { get; set; }
        [XmlElement(ElementName = "SME", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string SME { get; set; }
    }

    [XmlRoot(ElementName = "Accounts", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Accounts
    {
        [XmlElement(ElementName = "ThisPeriodAccounts", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string ThisPeriodAccounts { get; set; }
        [XmlElement(ElementName = "DifferentPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string DifferentPeriod { get; set; }
        [XmlElement(ElementName = "NoAccountsReason", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string NoAccountsReason { get; set; }
    }

    [XmlRoot(ElementName = "Computations", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Computations
    {
        [XmlElement(ElementName = "ThisPeriodComputations", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string ThisPeriodComputations { get; set; }
    }

    [XmlRoot(ElementName = "SupplementaryPages", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class SupplementaryPages
    {
        [XmlElement(ElementName = "CT600A", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CT600A { get; set; }
        [XmlElement(ElementName = "CT600B", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CT600B { get; set; }
        [XmlElement(ElementName = "CT600C", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CT600C { get; set; }
        [XmlElement(ElementName = "CT600D", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CT600D { get; set; }
        [XmlElement(ElementName = "CT600E", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CT600E { get; set; }
        [XmlElement(ElementName = "CT600F", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CT600F { get; set; }
        [XmlElement(ElementName = "CT600G", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CT600G { get; set; }
        [XmlElement(ElementName = "CT600H", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CT600H { get; set; }
        [XmlElement(ElementName = "CT600I", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CT600I { get; set; }
        [XmlElement(ElementName = "CT600J", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CT600J { get; set; }
        [XmlElement(ElementName = "CT600K", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CT600K { get; set; }
        [XmlElement(ElementName = "CT600L", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CT600L { get; set; }
        [XmlElement(ElementName = "CT600M", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CT600M { get; set; }
        [XmlElement(ElementName = "CT600N", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CT600N { get; set; }
    }

    [XmlRoot(ElementName = "ReturnInfoSummary", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ReturnInfoSummary
    {
        [XmlElement(ElementName = "ThisPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string ThisPeriod { get; set; }
        [XmlElement(ElementName = "EarlierPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string EarlierPeriod { get; set; }
        [XmlElement(ElementName = "MultipleReturns", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string MultipleReturns { get; set; }
        [XmlElement(ElementName = "ProvisionalFigures", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string ProvisionalFigures { get; set; }
        [XmlElement(ElementName = "PartOfNonSmallGroup", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string PartOfNonSmallGroup { get; set; }
        [XmlElement(ElementName = "RegisteredAvoidanceScheme", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string RegisteredAvoidanceScheme { get; set; }
        [XmlElement(ElementName = "TransferPricing", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TransferPricing TransferPricing { get; set; }
        [XmlElement(ElementName = "Accounts", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Accounts Accounts { get; set; }
        [XmlElement(ElementName = "Computations", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Computations Computations { get; set; }
        [XmlElement(ElementName = "SupplementaryPages", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public SupplementaryPages SupplementaryPages { get; set; }
    }

    [XmlRoot(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Total
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Turnover", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Turnover
    {
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
        [XmlElement(ElementName = "OtherFinancialConcerns", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string OtherFinancialConcerns { get; set; }
    }

    [XmlRoot(ElementName = "Profits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Profits
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "LossesBroughtForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class LossesBroughtForward
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "NetProfits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NetProfits
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "Trading", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Trading
    {
        [XmlElement(ElementName = "Profits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Profits Profits { get; set; }
        [XmlElement(ElementName = "LossesBroughtForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LossesBroughtForward LossesBroughtForward { get; set; }
        [XmlElement(ElementName = "NetProfits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NetProfits NetProfits { get; set; }
        [XmlElement(ElementName = "LossesBroughtForwardUsed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LossesBroughtForwardUsed LossesBroughtForwardUsed { get; set; }
    }

    [XmlRoot(ElementName = "NonTradingLoanProfitsAndGains", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NonTradingLoanProfitsAndGains
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "NonLoanAnnuitiesAnnualPaymentsDiscounts", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NonLoanAnnuitiesAnnualPaymentsDiscounts
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "NonUKdividends", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NonUKdividends
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DeductedIncome", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class DeductedIncome
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PropertyBusinessIncome", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class PropertyBusinessIncome
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "NonTradingGainsIntangibles", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NonTradingGainsIntangibles
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TonnageTaxProfits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TonnageTaxProfits
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "OtherIncome", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class OtherIncome
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Income", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Income
    {
        [XmlElement(ElementName = "Trading", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Trading Trading { get; set; }
        [XmlElement(ElementName = "NonTradingLoanProfitsAndGains", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NonTradingLoanProfitsAndGains NonTradingLoanProfitsAndGains { get; set; }
        [XmlElement(ElementName = "IncomeStatedNet", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string IncomeStatedNet { get; set; }
        [XmlElement(ElementName = "NonLoanAnnuitiesAnnualPaymentsDiscounts", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NonLoanAnnuitiesAnnualPaymentsDiscounts NonLoanAnnuitiesAnnualPaymentsDiscounts { get; set; }
        [XmlElement(ElementName = "NonUKdividends", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NonUKdividends NonUKdividends { get; set; }
        [XmlElement(ElementName = "DeductedIncome", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public DeductedIncome DeductedIncome { get; set; }
        [XmlElement(ElementName = "PropertyBusinessIncome", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public PropertyBusinessIncome PropertyBusinessIncome { get; set; }
        [XmlElement(ElementName = "NonTradingGainsIntangibles", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NonTradingGainsIntangibles NonTradingGainsIntangibles { get; set; }
        [XmlElement(ElementName = "TonnageTaxProfits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TonnageTaxProfits TonnageTaxProfits { get; set; }
        [XmlElement(ElementName = "OtherIncome", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public OtherIncome OtherIncome { get; set; }
        [XmlElement(ElementName = "TotalTurnover", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalTurnover TotalTurnover { get; set; }
        [XmlElement(ElementName = "InvestmentIncome", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public InvestmentIncome InvestmentIncome { get; set; }
        [XmlElement(ElementName = "UKlandBuildings", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public UKlandBuildings UKlandBuildings { get; set; }
        [XmlElement(ElementName = "GiftAid", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public GiftAid GiftAid { get; set; }
        [XmlElement(ElementName = "OtherCharities", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public OtherCharities OtherCharities { get; set; }
        [XmlElement(ElementName = "GiftsOfShares", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public GiftsOfShares GiftsOfShares { get; set; }
        [XmlElement(ElementName = "GiftOfRealProperty", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public GiftOfRealProperty GiftOfRealProperty { get; set; }
        [XmlElement(ElementName = "OtherSources", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public OtherSources OtherSources { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "GrossGains", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class GrossGains
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AllowableLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AllowableLosses
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "NetChargeableGains", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NetChargeableGains
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ChargeableGains", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ChargeableGains
    {
        [XmlElement(ElementName = "GrossGains", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public GrossGains GrossGains { get; set; }
        [XmlElement(ElementName = "AllowableLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AllowableLosses AllowableLosses { get; set; }
        [XmlElement(ElementName = "NetChargeableGains", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NetChargeableGains NetChargeableGains { get; set; }
    }

    [XmlRoot(ElementName = "NonTradeDeficitsOnLoans", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NonTradeDeficitsOnLoans
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ProfitsBeforeOtherDeductions", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ProfitsBeforeOtherDeductions
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "UnquotedShares", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class UnquotedShares
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ManagementExpenses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ManagementExpenses
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "Arising", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Arising Arising { get; set; }
        [XmlElement(ElementName = "SurrenderMaximum", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public SurrenderMaximum SurrenderMaximum { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "UKpropertyBusinessLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class UKpropertyBusinessLosses
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "Arising", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Arising Arising { get; set; }
        [XmlElement(ElementName = "SurrenderMaximum", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public SurrenderMaximum SurrenderMaximum { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "CapitalAllowances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CapitalAllowances
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "NonTradeDeficits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NonTradeDeficits
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "CarriedForwardNonTradeDeficits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CarriedForwardNonTradeDeficits
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "NonTradingLossIntangibles", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NonTradingLossIntangibles
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "TradingLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TradingLosses
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "TradingLossesCarriedForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TradingLossesCarriedForward
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "NonTradeCapitalAllowances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NonTradeCapitalAllowances
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "DeductionsAndReliefs", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class DeductionsAndReliefs
    {
        [XmlElement(ElementName = "UnquotedShares", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public UnquotedShares UnquotedShares { get; set; }
        [XmlElement(ElementName = "ManagementExpenses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ManagementExpenses ManagementExpenses { get; set; }
        [XmlElement(ElementName = "UKpropertyBusinessLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public UKpropertyBusinessLosses UKpropertyBusinessLosses { get; set; }
        [XmlElement(ElementName = "CapitalAllowances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CapitalAllowances CapitalAllowances { get; set; }
        [XmlElement(ElementName = "NonTradeDeficits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NonTradeDeficits NonTradeDeficits { get; set; }
        [XmlElement(ElementName = "CarriedForwardNonTradeDeficits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CarriedForwardNonTradeDeficits CarriedForwardNonTradeDeficits { get; set; }
        [XmlElement(ElementName = "NonTradingLossIntangibles", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NonTradingLossIntangibles NonTradingLossIntangibles { get; set; }
        [XmlElement(ElementName = "TradingLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TradingLosses TradingLosses { get; set; }
        [XmlElement(ElementName = "TradingLossesCarriedBack", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string TradingLossesCarriedBack { get; set; }
        [XmlElement(ElementName = "TradingLossesCarriedForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TradingLossesCarriedForward TradingLossesCarriedForward { get; set; }
        [XmlElement(ElementName = "NonTradeCapitalAllowances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NonTradeCapitalAllowances NonTradeCapitalAllowances { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
        [XmlElement(ElementName = "LossesUnquotedShares", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LossesUnquotedShares LossesUnquotedShares { get; set; }
        [XmlElement(ElementName = "CapitalAllowancesManagement", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CapitalAllowancesManagement CapitalAllowancesManagement { get; set; }
        [XmlElement(ElementName = "TradingLossesUsed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TradingLossesUsed TradingLossesUsed { get; set; }
        [XmlElement(ElementName = "TradingLossesCarriedForwardUsed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TradingLossesCarriedForwardUsed TradingLossesCarriedForwardUsed { get; set; }
        [XmlElement(ElementName = "TotalOfDeductionsAndReliefs", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalOfDeductionsAndReliefs TotalOfDeductionsAndReliefs { get; set; }
        [XmlElement(ElementName = "ProfitsBeforeDonationsAndGroupRelief", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ProfitsBeforeDonationsAndGroupRelief ProfitsBeforeDonationsAndGroupRelief { get; set; }
        [XmlElement(ElementName = "QualifyingDonations", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public QualifyingDonations QualifyingDonations { get; set; }
        [XmlElement(ElementName = "GroupRelief", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public GroupRelief GroupRelief { get; set; }
        [XmlElement(ElementName = "GroupReliefForCarriedForwardLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public GroupReliefForCarriedForwardLosses GroupReliefForCarriedForwardLosses { get; set; }
        [XmlElement(ElementName = "ChargeableProfits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ChargeableProfits ChargeableProfits { get; set; }
    }

    [XmlRoot(ElementName = "ProfitsBeforeDonationsAndGroupRelief", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ProfitsBeforeDonationsAndGroupRelief
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "QualifyingDonations", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class QualifyingDonations
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "GroupRelief", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class GroupRelief
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "GroupReliefForCarriedForwardLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class GroupReliefForCarriedForwardLosses
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "CompanyInformation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CompanyInformation CompanyInformation { get; set; }
        [XmlElement(ElementName = "NonResidentCompany", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string NonResidentCompany { get; set; }
        [XmlElement(ElementName = "ClaimAuthorisation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ClaimAuthorisation ClaimAuthorisation { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "ChargesAndReliefs", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ChargesAndReliefs
    {
        [XmlElement(ElementName = "ProfitsBeforeDonationsAndGroupRelief", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ProfitsBeforeDonationsAndGroupRelief ProfitsBeforeDonationsAndGroupRelief { get; set; }
        [XmlElement(ElementName = "QualifyingDonations", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public QualifyingDonations QualifyingDonations { get; set; }
        [XmlElement(ElementName = "GroupRelief", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public GroupRelief GroupRelief { get; set; }
        [XmlElement(ElementName = "GroupReliefForCarriedForwardLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public GroupReliefForCarriedForwardLosses GroupReliefForCarriedForwardLosses { get; set; }
    }

    [XmlRoot(ElementName = "ChargeableProfits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ChargeableProfits
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "RingFenceProfitsIncluded", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RingFenceProfitsIncluded
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "NorthernIrelandProfitsIncluded", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NorthernIrelandProfitsIncluded
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AssociatedCompaniesFinancialYears", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AssociatedCompaniesFinancialYears
    {
        [XmlElement(ElementName = "FirstYear", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string FirstYear { get; set; }
        [XmlElement(ElementName = "SecondYear", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string SecondYear { get; set; }
    }

    [XmlRoot(ElementName = "AssociatedCompanies", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AssociatedCompanies
    {
        [XmlElement(ElementName = "ThisPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string ThisPeriod { get; set; }
        [XmlElement(ElementName = "AssociatedCompaniesFinancialYears", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AssociatedCompaniesFinancialYears AssociatedCompaniesFinancialYears { get; set; }
        [XmlElement(ElementName = "StartingOrSmallCompaniesRate", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string StartingOrSmallCompaniesRate { get; set; }
    }

    [XmlRoot(ElementName = "Profit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Profit
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Tax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Tax
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Details", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Details
    {
        [XmlElement(ElementName = "Profit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Profit Profit { get; set; }
        [XmlElement(ElementName = "TaxRate", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string TaxRate { get; set; }
        [XmlElement(ElementName = "Tax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Tax Tax { get; set; }
    }

    [XmlRoot(ElementName = "FinancialYearOne", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class FinancialYearOne
    {
        [XmlElement(ElementName = "Year", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Year { get; set; }
        [XmlElement(ElementName = "Details", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<Details> Details { get; set; }
        [XmlElement(ElementName = "AmountOfInterest", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountOfInterest AmountOfInterest { get; set; }
        [XmlElement(ElementName = "TaxRate", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string TaxRate { get; set; }
        [XmlElement(ElementName = "Tax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Tax Tax { get; set; }
    }

    [XmlRoot(ElementName = "FinancialYearTwo", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class FinancialYearTwo
    {
        [XmlElement(ElementName = "Year", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Year { get; set; }
        [XmlElement(ElementName = "Details", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<Details> Details { get; set; }
        [XmlElement(ElementName = "AmountOfInterest", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountOfInterest AmountOfInterest { get; set; }
        [XmlElement(ElementName = "TaxRate", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string TaxRate { get; set; }
        [XmlElement(ElementName = "Tax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Tax Tax { get; set; }
    }

    [XmlRoot(ElementName = "CorporationTaxChargeable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CorporationTaxChargeable
    {
        [XmlElement(ElementName = "AssociatedCompanies", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AssociatedCompanies AssociatedCompanies { get; set; }
        [XmlElement(ElementName = "FinancialYearOne", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public FinancialYearOne FinancialYearOne { get; set; }
        [XmlElement(ElementName = "FinancialYearTwo", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public FinancialYearTwo FinancialYearTwo { get; set; }
    }

    [XmlRoot(ElementName = "CorporationTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CorporationTax
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MarginalReliefForRingFenceTrades", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class MarginalReliefForRingFenceTrades
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "NetCorporationTaxChargeable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NetCorporationTaxChargeable
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CommunityInvestmentRelief", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CommunityInvestmentRelief
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DoubleTaxationRelief", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class DoubleTaxationRelief
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DoubleTaxation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class DoubleTaxation
    {
        [XmlElement(ElementName = "DoubleTaxationRelief", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public DoubleTaxationRelief DoubleTaxationRelief { get; set; }
        [XmlElement(ElementName = "UnderlyingRate", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string UnderlyingRate { get; set; }
        [XmlElement(ElementName = "AmountCarriedBack", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string AmountCarriedBack { get; set; }
    }

    [XmlRoot(ElementName = "AdvancedCorporationTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AdvancedCorporationTax
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalReliefsAndDeductions", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalReliefsAndDeductions
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxReliefsAndDeductions", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TaxReliefsAndDeductions
    {
        [XmlElement(ElementName = "CommunityInvestmentRelief", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CommunityInvestmentRelief CommunityInvestmentRelief { get; set; }
        [XmlElement(ElementName = "DoubleTaxation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public DoubleTaxation DoubleTaxation { get; set; }
        [XmlElement(ElementName = "AdvancedCorporationTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AdvancedCorporationTax AdvancedCorporationTax { get; set; }
        [XmlElement(ElementName = "TotalReliefsAndDeductions", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalReliefsAndDeductions TotalReliefsAndDeductions { get; set; }
    }

    [XmlRoot(ElementName = "CJRSreceived", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CJRSreceived
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CJRSdue", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CJRSdue
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CJRSoverpaymentAlreadyAssessed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CJRSoverpaymentAlreadyAssessed
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "JobRetentionBonusOverpayment", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class JobRetentionBonusOverpayment
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CJRS", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CJRS
    {
        [XmlElement(ElementName = "CJRSreceived", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CJRSreceived CJRSreceived { get; set; }
        [XmlElement(ElementName = "CJRSdue", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CJRSdue CJRSdue { get; set; }
        [XmlElement(ElementName = "CJRSoverpaymentAlreadyAssessed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CJRSoverpaymentAlreadyAssessed CJRSoverpaymentAlreadyAssessed { get; set; }
        [XmlElement(ElementName = "JobRetentionBonusOverpayment", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public JobRetentionBonusOverpayment JobRetentionBonusOverpayment { get; set; }
    }

    [XmlRoot(ElementName = "CompanyTaxCalculation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CompanyTaxCalculation
    {
        [XmlElement(ElementName = "Income", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Income Income { get; set; }
        [XmlElement(ElementName = "ChargeableGains", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ChargeableGains ChargeableGains { get; set; }
        [XmlElement(ElementName = "LossesBroughtForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LossesBroughtForward LossesBroughtForward { get; set; }
        [XmlElement(ElementName = "NonTradeDeficitsOnLoans", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NonTradeDeficitsOnLoans NonTradeDeficitsOnLoans { get; set; }
        [XmlElement(ElementName = "ProfitsBeforeOtherDeductions", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ProfitsBeforeOtherDeductions ProfitsBeforeOtherDeductions { get; set; }
        [XmlElement(ElementName = "DeductionsAndReliefs", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public DeductionsAndReliefs DeductionsAndReliefs { get; set; }
        [XmlElement(ElementName = "ChargesAndReliefs", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ChargesAndReliefs ChargesAndReliefs { get; set; }
        [XmlElement(ElementName = "ChargeableProfits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ChargeableProfits ChargeableProfits { get; set; }
        [XmlElement(ElementName = "RingFenceProfitsIncluded", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RingFenceProfitsIncluded RingFenceProfitsIncluded { get; set; }
        [XmlElement(ElementName = "NorthernIrelandProfitsIncluded", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIrelandProfitsIncluded NorthernIrelandProfitsIncluded { get; set; }
        [XmlElement(ElementName = "CorporationTaxChargeable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CorporationTaxChargeable CorporationTaxChargeable { get; set; }
        [XmlElement(ElementName = "CorporationTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CorporationTax CorporationTax { get; set; }
        [XmlElement(ElementName = "MarginalReliefForRingFenceTrades", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public MarginalReliefForRingFenceTrades MarginalReliefForRingFenceTrades { get; set; }
        [XmlElement(ElementName = "NetCorporationTaxChargeable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NetCorporationTaxChargeable NetCorporationTaxChargeable { get; set; }
        [XmlElement(ElementName = "TaxReliefsAndDeductions", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TaxReliefsAndDeductions TaxReliefsAndDeductions { get; set; }
        [XmlElement(ElementName = "CJRS", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CJRS CJRS { get; set; }
    }

    [XmlRoot(ElementName = "EOGPLamounts", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class EOGPLamounts
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "EGLamounts", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class EGLamounts
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "EnergyProfitsLevy", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class EnergyProfitsLevy
    {
        [XmlElement(ElementName = "EOGPLamounts", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public EOGPLamounts EOGPLamounts { get; set; }
        [XmlElement(ElementName = "EGLamounts", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public EGLamounts EGLamounts { get; set; }
    }

    [XmlRoot(ElementName = "NetCorporationTaxLiability", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NetCorporationTaxLiability
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LoansToParticipators", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class LoansToParticipators
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CFCtaxPayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CFCtaxPayable
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "BankLevyPayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class BankLevyPayable
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "BankSurchargePayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class BankSurchargePayable
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RPDTpayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RPDTpayable
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CFCandBankLevyTotal", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CFCandBankLevyTotal
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "EOGPLpayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class EOGPLpayable
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "EGLpayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class EGLpayable
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SupplementaryCharge", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class SupplementaryCharge
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "AmountBroughtForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountBroughtForward AmountBroughtForward { get; set; }
        [XmlElement(ElementName = "AmountTransferred", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountTransferred AmountTransferred { get; set; }
        [XmlElement(ElementName = "AmountUsed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountUsed AmountUsed { get; set; }
        [XmlElement(ElementName = "AmountCarriedForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountCarriedForward AmountCarriedForward { get; set; }
    }

    [XmlRoot(ElementName = "TaxChargeable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TaxChargeable
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DeductedIncomeTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class DeductedIncomeTax
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxRepayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TaxRepayable
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "IncomeTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class IncomeTax
    {
        [XmlElement(ElementName = "DeductedIncomeTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public DeductedIncomeTax DeductedIncomeTax { get; set; }
        [XmlElement(ElementName = "TaxRepayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TaxRepayable TaxRepayable { get; set; }
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxPayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TaxPayable
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CJRSoverpaymentsNowDue", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CJRSoverpaymentsNowDue
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RestitutionTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RestitutionTax
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "TaxCalculation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TaxCalculation TaxCalculation { get; set; }
    }

    [XmlRoot(ElementName = "TaxPayableIncludingRestitutionTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TaxPayableIncludingRestitutionTax
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CalculationOfTaxOutstandingOrOverpaid", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CalculationOfTaxOutstandingOrOverpaid
    {
        [XmlElement(ElementName = "NetCorporationTaxLiability", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NetCorporationTaxLiability NetCorporationTaxLiability { get; set; }
        [XmlElement(ElementName = "LoansToParticipators", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LoansToParticipators LoansToParticipators { get; set; }
        [XmlElement(ElementName = "CT600AreliefDue", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CT600AreliefDue { get; set; }
        [XmlElement(ElementName = "CFCtaxPayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CFCtaxPayable CFCtaxPayable { get; set; }
        [XmlElement(ElementName = "BankLevyPayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BankLevyPayable BankLevyPayable { get; set; }
        [XmlElement(ElementName = "BankSurchargePayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BankSurchargePayable BankSurchargePayable { get; set; }
        [XmlElement(ElementName = "RPDTpayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RPDTpayable RPDTpayable { get; set; }
        [XmlElement(ElementName = "CFCandBankLevyTotal", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CFCandBankLevyTotal CFCandBankLevyTotal { get; set; }
        [XmlElement(ElementName = "EOGPLpayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public EOGPLpayable EOGPLpayable { get; set; }
        [XmlElement(ElementName = "EGLpayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public EGLpayable EGLpayable { get; set; }
        [XmlElement(ElementName = "SupplementaryCharge", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public SupplementaryCharge SupplementaryCharge { get; set; }
        [XmlElement(ElementName = "TaxChargeable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TaxChargeable TaxChargeable { get; set; }
        [XmlElement(ElementName = "IncomeTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public IncomeTax IncomeTax { get; set; }
        [XmlElement(ElementName = "TaxPayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TaxPayable TaxPayable { get; set; }
        [XmlElement(ElementName = "CJRSoverpaymentsNowDue", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CJRSoverpaymentsNowDue CJRSoverpaymentsNowDue { get; set; }
        [XmlElement(ElementName = "RestitutionTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestitutionTax RestitutionTax { get; set; }
        [XmlElement(ElementName = "TaxPayableIncludingRestitutionTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TaxPayableIncludingRestitutionTax TaxPayableIncludingRestitutionTax { get; set; }
    }

    [XmlRoot(ElementName = "ResearchAndDevelopmentCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ResearchAndDevelopmentCredit
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "VaccineCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class VaccineCredit
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CreativeCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CreativeCredit
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "ResearchAndDevelopmentVaccineOrCreativeTaxCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ResearchAndDevelopmentVaccineOrCreativeTaxCredit
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LandRemediationCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class LandRemediationCredit
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "LifeAssuranceCompanyCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class LifeAssuranceCompanyCredit
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "LandOrLifeCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class LandOrLifeCredit
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CapitalAllowancesFirstYearCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CapitalAllowancesFirstYearCredit
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "SurplusResearchAndDevelopmentCreditsOrCreativeCreditPayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class SurplusResearchAndDevelopmentCreditsOrCreativeCreditPayable
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LandOrLifeCreditPayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class LandOrLifeCreditPayable
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CapitalAllowancesFirstYearCreditPayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CapitalAllowancesFirstYearCreditPayable
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RingFenceCorpTaxIncluded", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RingFenceCorpTaxIncluded
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "NIcorporationTaxIncluded", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NIcorporationTaxIncluded
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RingFenceSupplementaryChargeIncluded", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RingFenceSupplementaryChargeIncluded
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxAlreadyPaid", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TaxAlreadyPaid
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxOutstanding", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TaxOutstanding
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxOverpaid", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TaxOverpaid
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxOutstandingOrOverpaid", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TaxOutstandingOrOverpaid
    {
        [XmlElement(ElementName = "TaxOutstanding", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TaxOutstanding TaxOutstanding { get; set; }
        [XmlElement(ElementName = "TaxOverpaid", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TaxOverpaid TaxOverpaid { get; set; }
    }

    [XmlRoot(ElementName = "RefundsSurrendered", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RefundsSurrendered
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RandDExpenditureCreditsSurrendered", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RandDExpenditureCreditsSurrendered
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExporterInformation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ExporterInformation
    {
        [XmlElement(ElementName = "GoodsExported", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string GoodsExported { get; set; }
        [XmlElement(ElementName = "ServicesExported", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string ServicesExported { get; set; }
        [XmlElement(ElementName = "NeitherGoodsNorServicesExported", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string NeitherGoodsNorServicesExported { get; set; }
    }

    [XmlRoot(ElementName = "TaxReconciliation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TaxReconciliation
    {
        [XmlElement(ElementName = "ResearchAndDevelopmentCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ResearchAndDevelopmentCredit ResearchAndDevelopmentCredit { get; set; }
        [XmlElement(ElementName = "VaccineCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public VaccineCredit VaccineCredit { get; set; }
        [XmlElement(ElementName = "CreativeCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CreativeCredit CreativeCredit { get; set; }
        [XmlElement(ElementName = "ResearchAndDevelopmentVaccineOrCreativeTaxCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ResearchAndDevelopmentVaccineOrCreativeTaxCredit ResearchAndDevelopmentVaccineOrCreativeTaxCredit { get; set; }
        [XmlElement(ElementName = "LandRemediationCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LandRemediationCredit LandRemediationCredit { get; set; }
        [XmlElement(ElementName = "LifeAssuranceCompanyCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LifeAssuranceCompanyCredit LifeAssuranceCompanyCredit { get; set; }
        [XmlElement(ElementName = "LandOrLifeCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LandOrLifeCredit LandOrLifeCredit { get; set; }
        [XmlElement(ElementName = "CapitalAllowancesFirstYearCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CapitalAllowancesFirstYearCredit CapitalAllowancesFirstYearCredit { get; set; }
        [XmlElement(ElementName = "SurplusResearchAndDevelopmentCreditsOrCreativeCreditPayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public SurplusResearchAndDevelopmentCreditsOrCreativeCreditPayable SurplusResearchAndDevelopmentCreditsOrCreativeCreditPayable { get; set; }
        [XmlElement(ElementName = "LandOrLifeCreditPayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LandOrLifeCreditPayable LandOrLifeCreditPayable { get; set; }
        [XmlElement(ElementName = "CapitalAllowancesFirstYearCreditPayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CapitalAllowancesFirstYearCreditPayable CapitalAllowancesFirstYearCreditPayable { get; set; }
        [XmlElement(ElementName = "RingFenceCorpTaxIncluded", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RingFenceCorpTaxIncluded RingFenceCorpTaxIncluded { get; set; }
        [XmlElement(ElementName = "NIcorporationTaxIncluded", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NIcorporationTaxIncluded NIcorporationTaxIncluded { get; set; }
        [XmlElement(ElementName = "RingFenceSupplementaryChargeIncluded", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RingFenceSupplementaryChargeIncluded RingFenceSupplementaryChargeIncluded { get; set; }
        [XmlElement(ElementName = "TaxAlreadyPaid", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TaxAlreadyPaid TaxAlreadyPaid { get; set; }
        [XmlElement(ElementName = "TaxOutstandingOrOverpaid", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TaxOutstandingOrOverpaid TaxOutstandingOrOverpaid { get; set; }
        [XmlElement(ElementName = "RefundsSurrendered", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RefundsSurrendered RefundsSurrendered { get; set; }
        [XmlElement(ElementName = "RandDExpenditureCreditsSurrendered", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RandDExpenditureCreditsSurrendered RandDExpenditureCreditsSurrendered { get; set; }
        [XmlElement(ElementName = "ExporterInformation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ExporterInformation ExporterInformation { get; set; }
        [XmlElement(ElementName = "ResearchAndDevelopmentOrCreativeTaxCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ResearchAndDevelopmentOrCreativeTaxCredit ResearchAndDevelopmentOrCreativeTaxCredit { get; set; }
        [XmlElement(ElementName = "TotalLandAndLifeCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalLandAndLifeCredit TotalLandAndLifeCredit { get; set; }
    }

    [XmlRoot(ElementName = "FrankedInvestmentIncome", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class FrankedInvestmentIncome
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "EatOutToHelpOutScheme", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class EatOutToHelpOutScheme
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "IndicatorsAndInformation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class IndicatorsAndInformation
    {
        [XmlElement(ElementName = "FrankedInvestmentIncome", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public FrankedInvestmentIncome FrankedInvestmentIncome { get; set; }
        [XmlElement(ElementName = "NumberOf51groupCompanies", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string NumberOf51groupCompanies { get; set; }
        [XmlElement(ElementName = "InstalmentPayments", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string InstalmentPayments { get; set; }
        [XmlElement(ElementName = "VeryLargeQIPs", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string VeryLargeQIPs { get; set; }
        [XmlElement(ElementName = "GroupPayment", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string GroupPayment { get; set; }
        [XmlElement(ElementName = "IntangibleAssets", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string IntangibleAssets { get; set; }
        [XmlElement(ElementName = "CrossBorderRoyalty", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CrossBorderRoyalty { get; set; }
        [XmlElement(ElementName = "EatOutToHelpOutScheme", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public EatOutToHelpOutScheme EatOutToHelpOutScheme { get; set; }
    }

    [XmlRoot(ElementName = "RAndDExpenditureSME", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RAndDExpenditureSME
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RandDEnhancedExpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RandDEnhancedExpenditure
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CreativeEnhancedExpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CreativeEnhancedExpenditure
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RandDAndCreativeEnhancedExpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RandDAndCreativeEnhancedExpenditure
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SMEclaimAsLargeCompany", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class SMEclaimAsLargeCompany
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "VaccineResearch", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class VaccineResearch
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "EnhancedExpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class EnhancedExpenditure
    {
        [XmlElement(ElementName = "SMEclaim", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string SMEclaim { get; set; }
        [XmlElement(ElementName = "LargeCompanyClaim", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string LargeCompanyClaim { get; set; }
        [XmlElement(ElementName = "RAndDClaimNotificationForm", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string RAndDClaimNotificationForm { get; set; }
        [XmlElement(ElementName = "AdditionalRAndDForm", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string AdditionalRAndDForm { get; set; }
        [XmlElement(ElementName = "RAndDExpenditureSME", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RAndDExpenditureSME RAndDExpenditureSME { get; set; }
        [XmlElement(ElementName = "RandDEnhancedExpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RandDEnhancedExpenditure RandDEnhancedExpenditure { get; set; }
        [XmlElement(ElementName = "CreativeEnhancedExpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CreativeEnhancedExpenditure CreativeEnhancedExpenditure { get; set; }
        [XmlElement(ElementName = "RandDAndCreativeEnhancedExpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RandDAndCreativeEnhancedExpenditure RandDAndCreativeEnhancedExpenditure { get; set; }
        [XmlElement(ElementName = "SMEclaimAsLargeCompany", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public SMEclaimAsLargeCompany SMEclaimAsLargeCompany { get; set; }
        [XmlElement(ElementName = "VaccineResearch", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public VaccineResearch VaccineResearch { get; set; }
    }

    [XmlRoot(ElementName = "LandRemediationEnhancedExpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class LandRemediationEnhancedExpenditure
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "BalancingCharges", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class BalancingCharges
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "FullExpensing", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class FullExpensing
    {
        [XmlElement(ElementName = "BalancingCharges", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BalancingCharges BalancingCharges { get; set; }
        [XmlElement(ElementName = "CapitalAllowances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CapitalAllowances CapitalAllowances { get; set; }
    }

    [XmlRoot(ElementName = "AIACapitalAllowancesInc", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AIACapitalAllowancesInc
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MachineryAndPlantSuperDeduction", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class MachineryAndPlantSuperDeduction
    {
        [XmlElement(ElementName = "BalancingCharges", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BalancingCharges BalancingCharges { get; set; }
        [XmlElement(ElementName = "CapitalAllowances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CapitalAllowances CapitalAllowances { get; set; }
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MachineryAndPlantSpecialRateAllowance", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class MachineryAndPlantSpecialRateAllowance
    {
        [XmlElement(ElementName = "BalancingCharges", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BalancingCharges BalancingCharges { get; set; }
        [XmlElement(ElementName = "CapitalAllowances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CapitalAllowances CapitalAllowances { get; set; }
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MachineryAndPlantSpecialRatePool", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class MachineryAndPlantSpecialRatePool
    {
        [XmlElement(ElementName = "BalancingCharges", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BalancingCharges BalancingCharges { get; set; }
        [XmlElement(ElementName = "CapitalAllowances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CapitalAllowances CapitalAllowances { get; set; }
    }

    [XmlRoot(ElementName = "MachineryAndPlantMainPool", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class MachineryAndPlantMainPool
    {
        [XmlElement(ElementName = "BalancingCharges", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BalancingCharges BalancingCharges { get; set; }
        [XmlElement(ElementName = "CapitalAllowances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CapitalAllowances CapitalAllowances { get; set; }
    }

    [XmlRoot(ElementName = "StructuresAndBuildingsCapitalAllowances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class StructuresAndBuildingsCapitalAllowances
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ElectricChargePoints", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ElectricChargePoints
    {
        [XmlElement(ElementName = "BalancingCharges", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BalancingCharges BalancingCharges { get; set; }
        [XmlElement(ElementName = "CapitalAllowances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CapitalAllowances CapitalAllowances { get; set; }
    }

    [XmlRoot(ElementName = "BusinessPremisesRenovationIncluded", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class BusinessPremisesRenovationIncluded
    {
        [XmlElement(ElementName = "BalancingCharges", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BalancingCharges BalancingCharges { get; set; }
        [XmlElement(ElementName = "CapitalAllowances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CapitalAllowances CapitalAllowances { get; set; }
    }

    [XmlRoot(ElementName = "EnterpriseZones", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class EnterpriseZones
    {
        [XmlElement(ElementName = "BalancingCharges", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BalancingCharges BalancingCharges { get; set; }
        [XmlElement(ElementName = "CapitalAllowances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CapitalAllowances CapitalAllowances { get; set; }
    }

    [XmlRoot(ElementName = "ZeroEmissionsGoodsVehicles", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ZeroEmissionsGoodsVehicles
    {
        [XmlElement(ElementName = "BalancingCharges", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BalancingCharges BalancingCharges { get; set; }
        [XmlElement(ElementName = "CapitalAllowances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CapitalAllowances CapitalAllowances { get; set; }
    }

    [XmlRoot(ElementName = "ZeroEmissionsCars", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ZeroEmissionsCars
    {
        [XmlElement(ElementName = "BalancingCharges", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BalancingCharges BalancingCharges { get; set; }
        [XmlElement(ElementName = "CapitalAllowances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CapitalAllowances CapitalAllowances { get; set; }
    }

    [XmlRoot(ElementName = "Others", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Others
    {
        [XmlElement(ElementName = "BalancingCharges", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BalancingCharges BalancingCharges { get; set; }
        [XmlElement(ElementName = "CapitalAllowances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CapitalAllowances CapitalAllowances { get; set; }
    }

    [XmlRoot(ElementName = "AllowancesAndCharges", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AllowancesAndCharges
    {
        [XmlElement(ElementName = "FullExpensing", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public FullExpensing FullExpensing { get; set; }
        [XmlElement(ElementName = "AIACapitalAllowancesInc", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AIACapitalAllowancesInc AIACapitalAllowancesInc { get; set; }
        [XmlElement(ElementName = "MachineryAndPlantSuperDeduction", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public MachineryAndPlantSuperDeduction MachineryAndPlantSuperDeduction { get; set; }
        [XmlElement(ElementName = "MachineryAndPlantSpecialRateAllowance", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public MachineryAndPlantSpecialRateAllowance MachineryAndPlantSpecialRateAllowance { get; set; }
        [XmlElement(ElementName = "MachineryAndPlantSpecialRatePool", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public MachineryAndPlantSpecialRatePool MachineryAndPlantSpecialRatePool { get; set; }
        [XmlElement(ElementName = "MachineryAndPlantMainPool", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public MachineryAndPlantMainPool MachineryAndPlantMainPool { get; set; }
        [XmlElement(ElementName = "StructuresAndBuildingsCapitalAllowances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public StructuresAndBuildingsCapitalAllowances StructuresAndBuildingsCapitalAllowances { get; set; }
        [XmlElement(ElementName = "ElectricChargePoints", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ElectricChargePoints ElectricChargePoints { get; set; }
        [XmlElement(ElementName = "BusinessPremisesRenovationIncluded", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BusinessPremisesRenovationIncluded BusinessPremisesRenovationIncluded { get; set; }
        [XmlElement(ElementName = "EnterpriseZones", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public EnterpriseZones EnterpriseZones { get; set; }
        [XmlElement(ElementName = "ZeroEmissionsGoodsVehicles", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ZeroEmissionsGoodsVehicles ZeroEmissionsGoodsVehicles { get; set; }
        [XmlElement(ElementName = "ZeroEmissionsCars", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ZeroEmissionsCars ZeroEmissionsCars { get; set; }
        [XmlElement(ElementName = "Others", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Others Others { get; set; }
    }

    [XmlRoot(ElementName = "AIACapitalAllowancesNotInc", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AIACapitalAllowancesNotInc
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "BusinessPremisesRenovationNotIncluded", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class BusinessPremisesRenovationNotIncluded
    {
        [XmlElement(ElementName = "BalancingCharges", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BalancingCharges BalancingCharges { get; set; }
        [XmlElement(ElementName = "CapitalAllowances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CapitalAllowances CapitalAllowances { get; set; }
    }

    [XmlRoot(ElementName = "OtherAllowancesAndCharges", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class OtherAllowancesAndCharges
    {
        [XmlElement(ElementName = "BalancingCharges", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BalancingCharges BalancingCharges { get; set; }
        [XmlElement(ElementName = "CapitalAllowances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CapitalAllowances CapitalAllowances { get; set; }
    }

    [XmlRoot(ElementName = "NotIncluded", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NotIncluded
    {
        [XmlElement(ElementName = "FullExpensing", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public FullExpensing FullExpensing { get; set; }
        [XmlElement(ElementName = "AIACapitalAllowancesNotInc", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AIACapitalAllowancesNotInc AIACapitalAllowancesNotInc { get; set; }
        [XmlElement(ElementName = "StructuresAndBuildingsCapitalAllowances", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public StructuresAndBuildingsCapitalAllowances StructuresAndBuildingsCapitalAllowances { get; set; }
        [XmlElement(ElementName = "ElectricChargePoints", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ElectricChargePoints ElectricChargePoints { get; set; }
        [XmlElement(ElementName = "BusinessPremisesRenovationNotIncluded", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BusinessPremisesRenovationNotIncluded BusinessPremisesRenovationNotIncluded { get; set; }
        [XmlElement(ElementName = "MachineryAndPlantSuperDeduction", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public MachineryAndPlantSuperDeduction MachineryAndPlantSuperDeduction { get; set; }
        [XmlElement(ElementName = "MachineryAndPlantSpecialRateAllowance", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public MachineryAndPlantSpecialRateAllowance MachineryAndPlantSpecialRateAllowance { get; set; }
        [XmlElement(ElementName = "EnterpriseZones", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public EnterpriseZones EnterpriseZones { get; set; }
        [XmlElement(ElementName = "ZeroEmissionsGoodsVehicles", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ZeroEmissionsGoodsVehicles ZeroEmissionsGoodsVehicles { get; set; }
        [XmlElement(ElementName = "ZeroEmissionsCars", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ZeroEmissionsCars ZeroEmissionsCars { get; set; }
        [XmlElement(ElementName = "OtherAllowancesAndCharges", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public OtherAllowancesAndCharges OtherAllowancesAndCharges { get; set; }
    }

    [XmlRoot(ElementName = "MachineryAndPlantExpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class MachineryAndPlantExpenditure
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DesignatedEnvironmentallyFriendlyMachineryAndPlant", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class DesignatedEnvironmentallyFriendlyMachineryAndPlant
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MachineryAndPlantLongLife", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class MachineryAndPlantLongLife
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "StructuresAndBuildings", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class StructuresAndBuildings
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "OtherMachineryAndPlant", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class OtherMachineryAndPlant
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "QualifyingExpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class QualifyingExpenditure
    {
        [XmlElement(ElementName = "MachineryAndPlantExpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public MachineryAndPlantExpenditure MachineryAndPlantExpenditure { get; set; }
        [XmlElement(ElementName = "DesignatedEnvironmentallyFriendlyMachineryAndPlant", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public DesignatedEnvironmentallyFriendlyMachineryAndPlant DesignatedEnvironmentallyFriendlyMachineryAndPlant { get; set; }
        [XmlElement(ElementName = "MachineryAndPlantLongLife", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public MachineryAndPlantLongLife MachineryAndPlantLongLife { get; set; }
        [XmlElement(ElementName = "StructuresAndBuildings", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public StructuresAndBuildings StructuresAndBuildings { get; set; }
        [XmlElement(ElementName = "MachineryAndPlantSuperDeduction", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public MachineryAndPlantSuperDeduction MachineryAndPlantSuperDeduction { get; set; }
        [XmlElement(ElementName = "MachineryAndPlantSpecialRateAllowance", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public MachineryAndPlantSpecialRateAllowance MachineryAndPlantSpecialRateAllowance { get; set; }
        [XmlElement(ElementName = "OtherMachineryAndPlant", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public OtherMachineryAndPlant OtherMachineryAndPlant { get; set; }
    }

    [XmlRoot(ElementName = "Arising", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Arising
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SurrenderMaximum", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class SurrenderMaximum
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LossesOfTradesUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class LossesOfTradesUK
    {
        [XmlElement(ElementName = "Arising", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Arising Arising { get; set; }
        [XmlElement(ElementName = "SurrenderMaximum", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public SurrenderMaximum SurrenderMaximum { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "LossesOfTradesOutsideUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class LossesOfTradesOutsideUK
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "Loans", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Loans
    {
        [XmlElement(ElementName = "Arising", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Arising Arising { get; set; }
        [XmlElement(ElementName = "SurrenderMaximum", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public SurrenderMaximum SurrenderMaximum { get; set; }
    }

    [XmlRoot(ElementName = "OverseasPropertyBusinessLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class OverseasPropertyBusinessLosses
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MiscLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class MiscLosses
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CapitalLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CapitalLosses
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "NonTradingLossesIntangibles", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NonTradingLossesIntangibles
    {
        [XmlElement(ElementName = "Arising", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Arising Arising { get; set; }
        [XmlElement(ElementName = "SurrenderMaximum", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public SurrenderMaximum SurrenderMaximum { get; set; }
    }

    [XmlRoot(ElementName = "AmountArising", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountArising
    {
        [XmlElement(ElementName = "LossesOfTradesUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LossesOfTradesUK LossesOfTradesUK { get; set; }
        [XmlElement(ElementName = "LossesOfTradesOutsideUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LossesOfTradesOutsideUK LossesOfTradesOutsideUK { get; set; }
        [XmlElement(ElementName = "Loans", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Loans Loans { get; set; }
        [XmlElement(ElementName = "UKpropertyBusinessLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public UKpropertyBusinessLosses UKpropertyBusinessLosses { get; set; }
        [XmlElement(ElementName = "OverseasPropertyBusinessLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public OverseasPropertyBusinessLosses OverseasPropertyBusinessLosses { get; set; }
        [XmlElement(ElementName = "MiscLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public MiscLosses MiscLosses { get; set; }
        [XmlElement(ElementName = "CapitalLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CapitalLosses CapitalLosses { get; set; }
        [XmlElement(ElementName = "NonTradingLossesIntangibles", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NonTradingLossesIntangibles NonTradingLossesIntangibles { get; set; }
    }

    [XmlRoot(ElementName = "NonTradeCapital", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NonTradeCapital
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExcessAmounts", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ExcessAmounts
    {
        [XmlElement(ElementName = "NonTradeCapital", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NonTradeCapital NonTradeCapital { get; set; }
        [XmlElement(ElementName = "QualifyingDonations", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public QualifyingDonations QualifyingDonations { get; set; }
        [XmlElement(ElementName = "ManagementExpenses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ManagementExpenses ManagementExpenses { get; set; }
    }

    [XmlRoot(ElementName = "LossesDeficitsAndExcess", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class LossesDeficitsAndExcess
    {
        [XmlElement(ElementName = "AmountArising", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountArising AmountArising { get; set; }
        [XmlElement(ElementName = "ExcessAmounts", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ExcessAmounts ExcessAmounts { get; set; }
        [XmlElement(ElementName = "LossesOfTradesUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LossesOfTradesUK LossesOfTradesUK { get; set; }
        [XmlElement(ElementName = "LossesOfTradesOutsideUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LossesOfTradesOutsideUK LossesOfTradesOutsideUK { get; set; }
    }

    [XmlRoot(ElementName = "NIagainstUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NIagainstUK
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "NIagainstNI", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NIagainstNI
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "UKagainstNI", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class UKagainstNI
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "NorthernIrelandInformation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NorthernIrelandInformation
    {
        [XmlElement(ElementName = "NIagainstUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NIagainstUK NIagainstUK { get; set; }
        [XmlElement(ElementName = "NIagainstNI", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NIagainstNI NIagainstNI { get; set; }
        [XmlElement(ElementName = "UKagainstNI", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public UKagainstNI UKagainstNI { get; set; }
    }

    [XmlRoot(ElementName = "OwnRepaymentsLowerLimit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class OwnRepaymentsLowerLimit
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RandDTaxCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RandDTaxCredit
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RandDExpenditureCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RandDExpenditureCredit
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PayableCapitalAllowancesFirstYearCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class PayableCapitalAllowancesFirstYearCredit
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RepaymentsForThePeriodCoveredByThisReturn", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RepaymentsForThePeriodCoveredByThisReturn
    {
        [XmlElement(ElementName = "CorporationTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CorporationTax CorporationTax { get; set; }
        [XmlElement(ElementName = "IncomeTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public IncomeTax IncomeTax { get; set; }
        [XmlElement(ElementName = "RandDTaxCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RandDTaxCredit RandDTaxCredit { get; set; }
        [XmlElement(ElementName = "RandDExpenditureCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RandDExpenditureCredit RandDExpenditureCredit { get; set; }
        [XmlElement(ElementName = "CreativeCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CreativeCredit CreativeCredit { get; set; }
        [XmlElement(ElementName = "LandRemediationCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LandRemediationCredit LandRemediationCredit { get; set; }
        [XmlElement(ElementName = "PayableCapitalAllowancesFirstYearCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public PayableCapitalAllowancesFirstYearCredit PayableCapitalAllowancesFirstYearCredit { get; set; }
    }

    [XmlRoot(ElementName = "Amount", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Amount
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "JointNotice", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class JointNotice
    {
        [XmlElement(ElementName = "Attached", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Attached { get; set; }
    }

    [XmlRoot(ElementName = "StopUntilNotice", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class StopUntilNotice
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Surrender", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Surrender
    {
        [XmlElement(ElementName = "Amount", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Amount Amount { get; set; }
        [XmlElement(ElementName = "JointNotice", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public JointNotice JointNotice { get; set; }
        [XmlElement(ElementName = "StopUntilNotice", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public StopUntilNotice StopUntilNotice { get; set; }
    }

    [XmlRoot(ElementName = "BankAccountDetails", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class BankAccountDetails
    {
        [XmlElement(ElementName = "BankName", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string BankName { get; set; }
        [XmlElement(ElementName = "SortCode", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string SortCode { get; set; }
        [XmlElement(ElementName = "AccountNumber", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string AccountNumber { get; set; }
        [XmlElement(ElementName = "AccountName", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string AccountName { get; set; }
        [XmlElement(ElementName = "BuildingSocReference", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string BuildingSocReference { get; set; }
    }

    [XmlRoot(ElementName = "PaymentToPerson", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class PaymentToPerson
    {
        [XmlElement(ElementName = "Recipient", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Recipient { get; set; }
        [XmlElement(ElementName = "Address", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Address Address { get; set; }
        [XmlElement(ElementName = "NomineeReference", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string NomineeReference { get; set; }
    }

    [XmlRoot(ElementName = "OverpaymentsAndRepayments", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class OverpaymentsAndRepayments
    {
        [XmlElement(ElementName = "OwnRepaymentsLowerLimit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public OwnRepaymentsLowerLimit OwnRepaymentsLowerLimit { get; set; }
        [XmlElement(ElementName = "RepaymentsForThePeriodCoveredByThisReturn", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RepaymentsForThePeriodCoveredByThisReturn RepaymentsForThePeriodCoveredByThisReturn { get; set; }
        [XmlElement(ElementName = "Surrender", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Surrender Surrender { get; set; }
        [XmlElement(ElementName = "BankAccountDetails", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BankAccountDetails BankAccountDetails { get; set; }
        [XmlElement(ElementName = "PaymentToPerson", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public PaymentToPerson PaymentToPerson { get; set; }
    }

    [XmlRoot(ElementName = "Declaration", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Declaration
    {
        [XmlElement(ElementName = "AcceptDeclaration", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string AcceptDeclaration { get; set; }
        [XmlElement(ElementName = "Name", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Status", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Status { get; set; }
        [XmlElement(ElementName = "CompanyName", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CompanyName { get; set; }
        [XmlElement(ElementName = "TaxReference", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string TaxReference { get; set; }
        [XmlElement(ElementName = "AccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AccountingPeriod AccountingPeriod { get; set; }
        [XmlElement(ElementName = "FullNameOfPersonAuthorising", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string FullNameOfPersonAuthorising { get; set; }
    }

    [XmlRoot(ElementName = "AmountOfLoan", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountOfLoan
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Loan", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Loan
    {
        [XmlElement(ElementName = "Name", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Name { get; set; }
        [XmlElement(ElementName = "AmountOfLoan", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountOfLoan AmountOfLoan { get; set; }
        [XmlElement(ElementName = "AmountRepaid", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountRepaid AmountRepaid { get; set; }
        [XmlElement(ElementName = "AmountReleasedOrWrittenOff", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountReleasedOrWrittenOff AmountReleasedOrWrittenOff { get; set; }
        [XmlElement(ElementName = "Date", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Date { get; set; }
    }

    [XmlRoot(ElementName = "TotalLoans", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalLoans
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LoansInformation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class LoansInformation
    {
        [XmlElement(ElementName = "Loan", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<Loan> Loan { get; set; }
        [XmlElement(ElementName = "TotalLoans", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalLoans TotalLoans { get; set; }
        [XmlElement(ElementName = "TaxChargeable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TaxChargeable TaxChargeable { get; set; }
    }

    [XmlRoot(ElementName = "AmountRepaid", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountRepaid
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AmountReleasedOrWrittenOff", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountReleasedOrWrittenOff
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalAmountRepaid", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalAmountRepaid
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalAmountReleasedOrWritten", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalAmountReleasedOrWritten
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ReliefDue", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ReliefDue
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ReliefEarlierThan", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ReliefEarlierThan
    {
        [XmlElement(ElementName = "Loan", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<Loan> Loan { get; set; }
        [XmlElement(ElementName = "TotalAmountRepaid", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalAmountRepaid TotalAmountRepaid { get; set; }
        [XmlElement(ElementName = "TotalAmountReleasedOrWritten", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalAmountReleasedOrWritten TotalAmountReleasedOrWritten { get; set; }
        [XmlElement(ElementName = "TotalLoans", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalLoans TotalLoans { get; set; }
        [XmlElement(ElementName = "ReliefDue", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ReliefDue ReliefDue { get; set; }
    }

    [XmlRoot(ElementName = "LoanLaterReliefNow", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class LoanLaterReliefNow
    {
        [XmlElement(ElementName = "Loan", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<Loan> Loan { get; set; }
        [XmlElement(ElementName = "TotalAmountRepaid", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalAmountRepaid TotalAmountRepaid { get; set; }
        [XmlElement(ElementName = "TotalAmountReleasedOrWritten", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalAmountReleasedOrWritten TotalAmountReleasedOrWritten { get; set; }
        [XmlElement(ElementName = "TotalLoans", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalLoans TotalLoans { get; set; }
        [XmlElement(ElementName = "ReliefDue", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ReliefDue ReliefDue { get; set; }
    }

    [XmlRoot(ElementName = "TotalLoansOutstanding", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalLoansOutstanding
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LoansByCloseCompanies", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class LoansByCloseCompanies
    {
        [XmlElement(ElementName = "BeforeEndPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string BeforeEndPeriod { get; set; }
        [XmlElement(ElementName = "LoansInformation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LoansInformation LoansInformation { get; set; }
        [XmlElement(ElementName = "ReliefEarlierThan", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ReliefEarlierThan ReliefEarlierThan { get; set; }
        [XmlElement(ElementName = "LoanLaterReliefNow", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LoanLaterReliefNow LoanLaterReliefNow { get; set; }
        [XmlElement(ElementName = "TotalLoansOutstanding", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalLoansOutstanding TotalLoansOutstanding { get; set; }
        [XmlElement(ElementName = "TaxPayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TaxPayable TaxPayable { get; set; }
    }

    [XmlRoot(ElementName = "TotalTaxChargeable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalTaxChargeable
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalCreditableTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalCreditableTax
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalReliefInTaxTerms", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalReliefInTaxTerms
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalACTrestricted", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalACTrestricted
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalCFCtaxChargeble", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalCFCtaxChargeble
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalCounteraction", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalCounteraction
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalS259LAdeduction", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalS259LAdeduction
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalAllocationDIIsurplus", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalAllocationDIIsurplus
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalDIIsurplusConsentedTo", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalDIIsurplusConsentedTo
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "HybridAndOtherMismatches", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class HybridAndOtherMismatches
    {
        [XmlElement(ElementName = "HybridEntity", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string HybridEntity { get; set; }
        [XmlElement(ElementName = "TransactionsWithHybridEntities", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string TransactionsWithHybridEntities { get; set; }
        [XmlElement(ElementName = "HybridDeductionMismatches", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string HybridDeductionMismatches { get; set; }
        [XmlElement(ElementName = "ExcessivePEdeduction", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string ExcessivePEdeduction { get; set; }
        [XmlElement(ElementName = "MultinationalDeductionMismatch", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string MultinationalDeductionMismatch { get; set; }
        [XmlElement(ElementName = "Part6Acounteraction", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Part6Acounteraction { get; set; }
        [XmlElement(ElementName = "TotalCounteraction", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalCounteraction TotalCounteraction { get; set; }
        [XmlElement(ElementName = "TotalS259LAdeduction", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalS259LAdeduction TotalS259LAdeduction { get; set; }
        [XmlElement(ElementName = "TotalAllocationDIIsurplus", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalAllocationDIIsurplus TotalAllocationDIIsurplus { get; set; }
        [XmlElement(ElementName = "TotalDIIsurplusConsentedTo", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalDIIsurplusConsentedTo TotalDIIsurplusConsentedTo { get; set; }
    }

    [XmlRoot(ElementName = "ControlledForeignCompanies", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ControlledForeignCompanies
    {
        [XmlElement(ElementName = "CompanyInformation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<CompanyInformation> CompanyInformation { get; set; }
        [XmlElement(ElementName = "TotalTaxChargeable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalTaxChargeable TotalTaxChargeable { get; set; }
        [XmlElement(ElementName = "TotalCreditableTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalCreditableTax TotalCreditableTax { get; set; }
        [XmlElement(ElementName = "TotalReliefInTaxTerms", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalReliefInTaxTerms TotalReliefInTaxTerms { get; set; }
        [XmlElement(ElementName = "TotalACTrestricted", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalACTrestricted TotalACTrestricted { get; set; }
        [XmlElement(ElementName = "TotalCFCtaxChargeble", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalCFCtaxChargeble TotalCFCtaxChargeble { get; set; }
        [XmlElement(ElementName = "ForeignPermanentEstablishmentExemption", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string ForeignPermanentEstablishmentExemption { get; set; }
        [XmlElement(ElementName = "HybridAndOtherMismatches", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public HybridAndOtherMismatches HybridAndOtherMismatches { get; set; }
    }

    [XmlRoot(ElementName = "AccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AccountingPeriod
    {
        [XmlElement(ElementName = "From", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string From { get; set; }
        [XmlElement(ElementName = "To", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string To { get; set; }
    }

    [XmlRoot(ElementName = "AmountClaimed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountClaimed
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Company", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Company
    {
        [XmlElement(ElementName = "Name", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Name { get; set; }
        [XmlElement(ElementName = "AccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AccountingPeriod AccountingPeriod { get; set; }
        [XmlElement(ElementName = "TaxReference", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string TaxReference { get; set; }
        [XmlElement(ElementName = "AmountClaimed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountClaimed AmountClaimed { get; set; }
        [XmlElement(ElementName = "AmountSurrendered", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountSurrendered AmountSurrendered { get; set; }
    }

    [XmlRoot(ElementName = "TotalAmountClaimed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalAmountClaimed
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ClaimAuthorisation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ClaimAuthorisation
    {
        [XmlElement(ElementName = "CopyOfNoticesOfConsentAttached", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CopyOfNoticesOfConsentAttached { get; set; }
        [XmlElement(ElementName = "AuthorisationForSimplifiedArrangements", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AuthorisationForSimplifiedArrangements AuthorisationForSimplifiedArrangements { get; set; }
    }

    [XmlRoot(ElementName = "ClaimToGroupRelief", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ClaimToGroupRelief
    {
        [XmlElement(ElementName = "CompanyInformation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CompanyInformation CompanyInformation { get; set; }
        [XmlElement(ElementName = "NonResidentCompany", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string NonResidentCompany { get; set; }
        [XmlElement(ElementName = "LossesGeneratedAbroad", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string LossesGeneratedAbroad { get; set; }
        [XmlElement(ElementName = "ClaimAuthorisation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ClaimAuthorisation ClaimAuthorisation { get; set; }
    }

    [XmlRoot(ElementName = "NItradingLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NItradingLosses
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExcessNonTrading", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ExcessNonTrading
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "NonTradingDeficit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NonTradingDeficit
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExcessDonations", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ExcessDonations
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExcessLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ExcessLosses
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExcessManagementExpenses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ExcessManagementExpenses
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "NonTradingLossesOnIntangibleFixedAssets", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NonTradingLossesOnIntangibleFixedAssets
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalSurrender", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalSurrender
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AmountSurrendered", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountSurrendered
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AmountSurrenderedTotal", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountSurrenderedTotal
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SurrenderInformation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class SurrenderInformation
    {
        [XmlElement(ElementName = "Company", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<Company> Company { get; set; }
        [XmlElement(ElementName = "AmountSurrenderedTotal", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountSurrenderedTotal AmountSurrenderedTotal { get; set; }
    }

    [XmlRoot(ElementName = "ConsentOptions", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ConsentOptions
    {
        [XmlElement(ElementName = "SimplifiedArrangementInForce", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string SimplifiedArrangementInForce { get; set; }
        [XmlElement(ElementName = "NoticeOfConsentCompleted", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string NoticeOfConsentCompleted { get; set; }
        [XmlElement(ElementName = "CopyOfNoticesOfConsentAttached", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CopyOfNoticesOfConsentAttached { get; set; }
    }

    [XmlRoot(ElementName = "ConsentToSurrender", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ConsentToSurrender
    {
        [XmlElement(ElementName = "ConsentOptions", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ConsentOptions ConsentOptions { get; set; }
        [XmlElement(ElementName = "Declaration", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Declaration Declaration { get; set; }
    }

    [XmlRoot(ElementName = "SurrenderedGroupRelief", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class SurrenderedGroupRelief
    {
        [XmlElement(ElementName = "TradingLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TradingLosses TradingLosses { get; set; }
        [XmlElement(ElementName = "NItradingLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NItradingLosses NItradingLosses { get; set; }
        [XmlElement(ElementName = "ExcessNonTrading", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ExcessNonTrading ExcessNonTrading { get; set; }
        [XmlElement(ElementName = "NonTradingDeficit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NonTradingDeficit NonTradingDeficit { get; set; }
        [XmlElement(ElementName = "ExcessDonations", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ExcessDonations ExcessDonations { get; set; }
        [XmlElement(ElementName = "ExcessLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ExcessLosses ExcessLosses { get; set; }
        [XmlElement(ElementName = "ExcessManagementExpenses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ExcessManagementExpenses ExcessManagementExpenses { get; set; }
        [XmlElement(ElementName = "NonTradingLossesOnIntangibleFixedAssets", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NonTradingLossesOnIntangibleFixedAssets NonTradingLossesOnIntangibleFixedAssets { get; set; }
        [XmlElement(ElementName = "TotalSurrender", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalSurrender TotalSurrender { get; set; }
        [XmlElement(ElementName = "SurrenderInformation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public SurrenderInformation SurrenderInformation { get; set; }
        [XmlElement(ElementName = "ConsentToSurrender", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ConsentToSurrender ConsentToSurrender { get; set; }
    }

    [XmlRoot(ElementName = "NonTradingDeficitsOnIntangibleFixedAssets", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NonTradingDeficitsOnIntangibleFixedAssets
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SurrenderedGroupReliefForCarriedForwardLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class SurrenderedGroupReliefForCarriedForwardLosses
    {
        [XmlElement(ElementName = "TradingLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TradingLosses TradingLosses { get; set; }
        [XmlElement(ElementName = "NItradingLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NItradingLosses NItradingLosses { get; set; }
        [XmlElement(ElementName = "NonTradingDeficit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NonTradingDeficit NonTradingDeficit { get; set; }
        [XmlElement(ElementName = "UKpropertyBusinessLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public UKpropertyBusinessLosses UKpropertyBusinessLosses { get; set; }
        [XmlElement(ElementName = "ManagementExpenses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ManagementExpenses ManagementExpenses { get; set; }
        [XmlElement(ElementName = "NonTradingDeficitsOnIntangibleFixedAssets", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NonTradingDeficitsOnIntangibleFixedAssets NonTradingDeficitsOnIntangibleFixedAssets { get; set; }
        [XmlElement(ElementName = "TotalSurrender", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalSurrender TotalSurrender { get; set; }
        [XmlElement(ElementName = "SurrenderInformation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public SurrenderInformation SurrenderInformation { get; set; }
        [XmlElement(ElementName = "ConsentToSurrender", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ConsentToSurrender ConsentToSurrender { get; set; }
    }

    [XmlRoot(ElementName = "GroupAndConsortium", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class GroupAndConsortium
    {
        [XmlElement(ElementName = "ClaimToGroupRelief", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ClaimToGroupRelief ClaimToGroupRelief { get; set; }
        [XmlElement(ElementName = "SurrenderedGroupRelief", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public SurrenderedGroupRelief SurrenderedGroupRelief { get; set; }
        [XmlElement(ElementName = "GroupReliefForCarriedForwardLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public GroupReliefForCarriedForwardLosses GroupReliefForCarriedForwardLosses { get; set; }
        [XmlElement(ElementName = "SurrenderedGroupReliefForCarriedForwardLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public SurrenderedGroupReliefForCarriedForwardLosses SurrenderedGroupReliefForCarriedForwardLosses { get; set; }
    }

    [XmlRoot(ElementName = "Insurance", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Insurance
    {
        [XmlElement(ElementName = "Declaration", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Declaration { get; set; }
    }

    [XmlRoot(ElementName = "AllCharitable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AllCharitable
    {
        [XmlElement(ElementName = "AllExempt", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string AllExempt { get; set; }
    }

    [XmlRoot(ElementName = "Status", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Status
    {
        [XmlElement(ElementName = "ClaimingExemptionAllOrPart", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string ClaimingExemptionAllOrPart { get; set; }
        [XmlElement(ElementName = "AllCharitable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AllCharitable AllCharitable { get; set; }
    }

    [XmlRoot(ElementName = "ClaimExemption", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ClaimExemption
    {
        [XmlElement(ElementName = "RepaymentReference", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string RepaymentReference { get; set; }
        [XmlElement(ElementName = "RegistrationNumber", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string RegistrationNumber { get; set; }
        [XmlElement(ElementName = "Status", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Status Status { get; set; }
    }

    [XmlRoot(ElementName = "Repayments", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Repayments
    {
        [XmlElement(ElementName = "OverclaimedTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string OverclaimedTax { get; set; }
    }

    [XmlRoot(ElementName = "TotalTurnover", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalTurnover
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "InvestmentIncome", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class InvestmentIncome
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "UKlandBuildings", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class UKlandBuildings
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "GiftAid", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class GiftAid
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "OtherCharities", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class OtherCharities
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "GiftsOfShares", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class GiftsOfShares
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "GiftOfRealProperty", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class GiftOfRealProperty
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "OtherSources", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class OtherSources
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TradingCosts", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TradingCosts
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "GeneralAdminCosts", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class GeneralAdminCosts
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "GrantsDonationsWithinUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class GrantsDonationsWithinUK
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "GrantsDonationsOutsideUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class GrantsDonationsOutsideUK
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "OtherExpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class OtherExpenditure
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Expenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Expenditure
    {
        [XmlElement(ElementName = "TradingCosts", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TradingCosts TradingCosts { get; set; }
        [XmlElement(ElementName = "UKlandBuildings", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public UKlandBuildings UKlandBuildings { get; set; }
        [XmlElement(ElementName = "GeneralAdminCosts", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public GeneralAdminCosts GeneralAdminCosts { get; set; }
        [XmlElement(ElementName = "GrantsDonationsWithinUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public GrantsDonationsWithinUK GrantsDonationsWithinUK { get; set; }
        [XmlElement(ElementName = "GrantsDonationsOutsideUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public GrantsDonationsOutsideUK GrantsDonationsOutsideUK { get; set; }
        [XmlElement(ElementName = "OtherExpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public OtherExpenditure OtherExpenditure { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "Disposals", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Disposals
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Held", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Held
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TangibleFixed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TangibleFixed
    {
        [XmlElement(ElementName = "Disposals", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Disposals Disposals { get; set; }
        [XmlElement(ElementName = "Held", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Held Held { get; set; }
    }

    [XmlRoot(ElementName = "UKinvestments", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class UKinvestments
    {
        [XmlElement(ElementName = "Disposals", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Disposals Disposals { get; set; }
        [XmlElement(ElementName = "Held", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Held Held { get; set; }
    }

    [XmlRoot(ElementName = "SharesAndLoans", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class SharesAndLoans
    {
        [XmlElement(ElementName = "Disposals", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Disposals Disposals { get; set; }
        [XmlElement(ElementName = "Held", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Held Held { get; set; }
    }

    [XmlRoot(ElementName = "OverseasInvestments", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class OverseasInvestments
    {
        [XmlElement(ElementName = "Disposals", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Disposals Disposals { get; set; }
        [XmlElement(ElementName = "Held", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Held Held { get; set; }
    }

    [XmlRoot(ElementName = "LoansAndNonTradeDebtors", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class LoansAndNonTradeDebtors
    {
        [XmlElement(ElementName = "Held", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Held Held { get; set; }
    }

    [XmlRoot(ElementName = "OtherCurrent", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class OtherCurrent
    {
        [XmlElement(ElementName = "Held", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Held Held { get; set; }
    }

    [XmlRoot(ElementName = "ValueOfNonQualifying", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ValueOfNonQualifying
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "InvestmentsOrLoans", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class InvestmentsOrLoans
    {
        [XmlElement(ElementName = "Qualifying", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Qualifying { get; set; }
        [XmlElement(ElementName = "ValueOfNonQualifying", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ValueOfNonQualifying ValueOfNonQualifying { get; set; }
    }

    [XmlRoot(ElementName = "Assets", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Assets
    {
        [XmlElement(ElementName = "TangibleFixed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TangibleFixed TangibleFixed { get; set; }
        [XmlElement(ElementName = "UKinvestments", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public UKinvestments UKinvestments { get; set; }
        [XmlElement(ElementName = "SharesAndLoans", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public SharesAndLoans SharesAndLoans { get; set; }
        [XmlElement(ElementName = "OverseasInvestments", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public OverseasInvestments OverseasInvestments { get; set; }
        [XmlElement(ElementName = "LoansAndNonTradeDebtors", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LoansAndNonTradeDebtors LoansAndNonTradeDebtors { get; set; }
        [XmlElement(ElementName = "OtherCurrent", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public OtherCurrent OtherCurrent { get; set; }
        [XmlElement(ElementName = "InvestmentsOrLoans", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public InvestmentsOrLoans InvestmentsOrLoans { get; set; }
        [XmlElement(ElementName = "SubsidiaryOrAssociatedCompanies", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string SubsidiaryOrAssociatedCompanies { get; set; }
    }

    [XmlRoot(ElementName = "InformationRequired", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class InformationRequired
    {
        [XmlElement(ElementName = "Income", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Income Income { get; set; }
        [XmlElement(ElementName = "Expenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Expenditure Expenditure { get; set; }
        [XmlElement(ElementName = "Assets", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Assets Assets { get; set; }
    }

    [XmlRoot(ElementName = "Charity", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Charity
    {
        [XmlElement(ElementName = "ClaimExemption", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ClaimExemption ClaimExemption { get; set; }
        [XmlElement(ElementName = "Repayments", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Repayments Repayments { get; set; }
        [XmlElement(ElementName = "InformationRequired", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public InformationRequired InformationRequired { get; set; }
    }

    [XmlRoot(ElementName = "TonnageGroup", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TonnageGroup
    {
        [XmlElement(ElementName = "GroupElection", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string GroupElection { get; set; }
        [XmlElement(ElementName = "Name", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "Information", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Information
    {
        [XmlElement(ElementName = "TonnageGroup", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TonnageGroup TonnageGroup { get; set; }
        [XmlElement(ElementName = "TrainingCertificate", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string TrainingCertificate { get; set; }
        [XmlElement(ElementName = "CompanyMetCharteredInLimit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CompanyMetCharteredInLimit { get; set; }
        [XmlElement(ElementName = "GroupMetCharteredInLimit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string GroupMetCharteredInLimit { get; set; }
        [XmlElement(ElementName = "NotRegistered", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string NotRegistered { get; set; }
        [XmlElement(ElementName = "Flagging", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Flagging { get; set; }
        [XmlElement(ElementName = "OffshoreActivities", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string OffshoreActivities { get; set; }
    }

    [XmlRoot(ElementName = "OffsetAgainstCorpTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class OffsetAgainstCorpTax
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CarriedForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CarriedForward
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "OffshoreTrainingAllowance", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class OffshoreTrainingAllowance
    {
        [XmlElement(ElementName = "OffsetAgainstCorpTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public OffsetAgainstCorpTax OffsetAgainstCorpTax { get; set; }
        [XmlElement(ElementName = "CarriedForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CarriedForward CarriedForward { get; set; }
    }

    [XmlRoot(ElementName = "Other", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Other
    {
        [XmlElement(ElementName = "Profit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Profit Profit { get; set; }
    }

    [XmlRoot(ElementName = "DisposalOfAssets", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class DisposalOfAssets
    {
        [XmlElement(ElementName = "Profit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Profit Profit { get; set; }
    }

    [XmlRoot(ElementName = "GrossDividends", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class GrossDividends
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RelevantShippingProfits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RelevantShippingProfits
    {
        [XmlElement(ElementName = "Other", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Other Other { get; set; }
        [XmlElement(ElementName = "DisposalOfAssets", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public DisposalOfAssets DisposalOfAssets { get; set; }
        [XmlElement(ElementName = "GrossDividends", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public GrossDividends GrossDividends { get; set; }
    }

    [XmlRoot(ElementName = "Ship", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Ship
    {
        [XmlElement(ElementName = "Name", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Name { get; set; }
        [XmlElement(ElementName = "IMOnumber", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string IMOnumber { get; set; }
        [XmlElement(ElementName = "InterestInShip", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string InterestInShip { get; set; }
        [XmlElement(ElementName = "GrossTonnage", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string GrossTonnage { get; set; }
        [XmlElement(ElementName = "NetTonnage", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string NetTonnage { get; set; }
        [XmlElement(ElementName = "NumberDays", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string NumberDays { get; set; }
        [XmlElement(ElementName = "Profits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Profits Profits { get; set; }
        [XmlElement(ElementName = "Flagged", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Flagged { get; set; }
        [XmlElement(ElementName = "FirstTime", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string FirstTime { get; set; }
    }

    [XmlRoot(ElementName = "QualifyingShips", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class QualifyingShips
    {
        [XmlElement(ElementName = "Ship", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<Ship> Ship { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "TonnageTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TonnageTax
    {
        [XmlElement(ElementName = "Information", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Information Information { get; set; }
        [XmlElement(ElementName = "OffshoreTrainingAllowance", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public OffshoreTrainingAllowance OffshoreTrainingAllowance { get; set; }
        [XmlElement(ElementName = "RelevantShippingProfits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RelevantShippingProfits RelevantShippingProfits { get; set; }
        [XmlElement(ElementName = "QualifyingShips", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public QualifyingShips QualifyingShips { get; set; }
    }

    [XmlRoot(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RestOfUK
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LossesBroughtForwardUsed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class LossesBroughtForwardUsed
    {
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "NonTradeProfitsAndGains", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NonTradeProfitsAndGains
    {
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "TotalProfitsAndGains", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalProfitsAndGains
    {
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "TotalProfits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalProfits
    {
        [XmlElement(ElementName = "NonTradeProfitsAndGains", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NonTradeProfitsAndGains NonTradeProfitsAndGains { get; set; }
        [XmlElement(ElementName = "TotalProfitsAndGains", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalProfitsAndGains TotalProfitsAndGains { get; set; }
    }

    [XmlRoot(ElementName = "DeficitsBroughtForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class DeficitsBroughtForward
    {
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "ProfitsBeforeOtherDeductionsAndReliefs", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ProfitsBeforeOtherDeductionsAndReliefs
    {
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "ProfitsBeforeDeductions", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ProfitsBeforeDeductions
    {
        [XmlElement(ElementName = "LossesBroughtForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LossesBroughtForward LossesBroughtForward { get; set; }
        [XmlElement(ElementName = "DeficitsBroughtForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public DeficitsBroughtForward DeficitsBroughtForward { get; set; }
        [XmlElement(ElementName = "ProfitsBeforeOtherDeductionsAndReliefs", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ProfitsBeforeOtherDeductionsAndReliefs ProfitsBeforeOtherDeductionsAndReliefs { get; set; }
    }

    [XmlRoot(ElementName = "LossesUnquotedShares", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class LossesUnquotedShares
    {
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "CapitalAllowancesManagement", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CapitalAllowancesManagement
    {
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "TradingLossesUsed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TradingLossesUsed
    {
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "TradingLossesCarriedForwardUsed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TradingLossesCarriedForwardUsed
    {
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "TotalOfDeductionsAndReliefs", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalOfDeductionsAndReliefs
    {
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "ResearchAndDevelopmentOrCreativeTaxCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ResearchAndDevelopmentOrCreativeTaxCredit
    {
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "TotalLandAndLifeCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalLandAndLifeCredit
    {
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "RestOfUK", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestOfUK RestOfUK { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "Indicators", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Indicators
    {
        [XmlElement(ElementName = "BackOfficeActivities", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string BackOfficeActivities { get; set; }
        [XmlElement(ElementName = "PreCommencementAssets", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string PreCommencementAssets { get; set; }
        [XmlElement(ElementName = "SMEelectionIntoLargeCompanyRegime", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string SMEelectionIntoLargeCompanyRegime { get; set; }
    }

    [XmlRoot(ElementName = "AddressOfRecipient", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AddressOfRecipient
    {
        [XmlElement(ElementName = "Line", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<string> Line { get; set; }
        [XmlElement(ElementName = "AdditionalLine", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string AdditionalLine { get; set; }
        [XmlElement(ElementName = "PostCode", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string PostCode { get; set; }
    }

    [XmlRoot(ElementName = "RoyaltiesAgreement", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RoyaltiesAgreement
    {
        [XmlElement(ElementName = "InterestAndRoyalties", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string InterestAndRoyalties { get; set; }
    }

    [XmlRoot(ElementName = "DeductionAmount", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class DeductionAmount
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Royalties", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Royalties
    {
        [XmlElement(ElementName = "RecipientName", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string RecipientName { get; set; }
        [XmlElement(ElementName = "AddressOfRecipient", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AddressOfRecipient AddressOfRecipient { get; set; }
        [XmlElement(ElementName = "PaymentType", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string PaymentType { get; set; }
        [XmlElement(ElementName = "Amount", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Amount Amount { get; set; }
        [XmlElement(ElementName = "RoyaltiesAgreement", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RoyaltiesAgreement RoyaltiesAgreement { get; set; }
        [XmlElement(ElementName = "DeductionRate", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string DeductionRate { get; set; }
        [XmlElement(ElementName = "DeductionAmount", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public DeductionAmount DeductionAmount { get; set; }
        [XmlElement(ElementName = "AdditionalNotes", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string AdditionalNotes { get; set; }
    }

    [XmlRoot(ElementName = "CrossBorderRoyalties", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CrossBorderRoyalties
    {
        [XmlElement(ElementName = "Royalties", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<Royalties> Royalties { get; set; }
    }

    [XmlRoot(ElementName = "Trade", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Trade
    {
        [XmlElement(ElementName = "Amount", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Amount Amount { get; set; }
        [XmlElement(ElementName = "Profits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Profits { get; set; }
    }

    [XmlRoot(ElementName = "RelatedToCompany", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RelatedToCompany
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RelatedToLossRelief", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RelatedToLossRelief
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DisallowedFinancingCosts", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class DisallowedFinancingCosts
    {
        [XmlElement(ElementName = "RelatedToCompany", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RelatedToCompany RelatedToCompany { get; set; }
        [XmlElement(ElementName = "RelatedToLossRelief", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RelatedToLossRelief RelatedToLossRelief { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "DecommissioningAdjustment", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class DecommissioningAdjustment
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RevisedProfits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RevisedProfits
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MinusLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class MinusLosses
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DecommissioningReduction", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class DecommissioningReduction
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "FieldAllowance", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class FieldAllowance
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CalculationOfSupplementaryCharge", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CalculationOfSupplementaryCharge
    {
        [XmlElement(ElementName = "Trade", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Trade Trade { get; set; }
        [XmlElement(ElementName = "DisallowedFinancingCosts", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public DisallowedFinancingCosts DisallowedFinancingCosts { get; set; }
        [XmlElement(ElementName = "Profits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Profits Profits { get; set; }
        [XmlElement(ElementName = "DecommissioningAdjustment", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public DecommissioningAdjustment DecommissioningAdjustment { get; set; }
        [XmlElement(ElementName = "RevisedProfits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RevisedProfits RevisedProfits { get; set; }
        [XmlElement(ElementName = "MinusLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public MinusLosses MinusLosses { get; set; }
        [XmlElement(ElementName = "DecommissioningReduction", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public DecommissioningReduction DecommissioningReduction { get; set; }
        [XmlElement(ElementName = "FieldAllowance", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public FieldAllowance FieldAllowance { get; set; }
        [XmlElement(ElementName = "NetProfits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NetProfits NetProfits { get; set; }
        [XmlElement(ElementName = "Tax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Tax Tax { get; set; }
    }

    [XmlRoot(ElementName = "LossesArising", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class LossesArising
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SupplementaryChargeTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class SupplementaryChargeTax
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "NetRingFenceTrade", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NetRingFenceTrade
    {
        [XmlElement(ElementName = "RingFenceCorpTaxIncluded", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RingFenceCorpTaxIncluded RingFenceCorpTaxIncluded { get; set; }
        [XmlElement(ElementName = "SupplementaryChargeTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public SupplementaryChargeTax SupplementaryChargeTax { get; set; }
    }

    [XmlRoot(ElementName = "ElectionToTransfer", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ElectionToTransfer
    {
        [XmlElement(ElementName = "AssetAcquiredThisPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string AssetAcquiredThisPeriod { get; set; }
        [XmlElement(ElementName = "AssetDisposedOfThisPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string AssetDisposedOfThisPeriod { get; set; }
        [XmlElement(ElementName = "AssetAcquiredPreviousPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string AssetAcquiredPreviousPeriod { get; set; }
        [XmlElement(ElementName = "AssetDisposedOfPreviousPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string AssetDisposedOfPreviousPeriod { get; set; }
    }

    [XmlRoot(ElementName = "AmountBroughtForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountBroughtForward
    {
        [XmlElement(ElementName = "Profits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Profits Profits { get; set; }
        [XmlElement(ElementName = "Tax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Tax Tax { get; set; }
    }

    [XmlRoot(ElementName = "AmountTransferred", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountTransferred
    {
        [XmlElement(ElementName = "Profits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Profits Profits { get; set; }
        [XmlElement(ElementName = "Tax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Tax Tax { get; set; }
    }

    [XmlRoot(ElementName = "AmountUsed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountUsed
    {
        [XmlElement(ElementName = "Profits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Profits Profits { get; set; }
        [XmlElement(ElementName = "Tax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Tax Tax { get; set; }
    }

    [XmlRoot(ElementName = "AmountCarriedForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountCarriedForward
    {
        [XmlElement(ElementName = "Profits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Profits Profits { get; set; }
        [XmlElement(ElementName = "Tax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Tax Tax { get; set; }
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RingFenceCorporationTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RingFenceCorporationTax
    {
        [XmlElement(ElementName = "AmountBroughtForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountBroughtForward AmountBroughtForward { get; set; }
        [XmlElement(ElementName = "AmountTransferred", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountTransferred AmountTransferred { get; set; }
        [XmlElement(ElementName = "AmountUsed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountUsed AmountUsed { get; set; }
        [XmlElement(ElementName = "AmountCarriedForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountCarriedForward AmountCarriedForward { get; set; }
    }

    [XmlRoot(ElementName = "BalanceBroughtForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class BalanceBroughtForward
    {
        [XmlElement(ElementName = "Profits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Profits Profits { get; set; }
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ProfitsOrLossesForThisPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ProfitsOrLossesForThisPeriod
    {
        [XmlElement(ElementName = "Profits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Profits Profits { get; set; }
    }

    [XmlRoot(ElementName = "OtherAdjustmentsPlus", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class OtherAdjustmentsPlus
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TrackedProfitsOrLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TrackedProfitsOrLosses
    {
        [XmlElement(ElementName = "BalanceBroughtForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BalanceBroughtForward BalanceBroughtForward { get; set; }
        [XmlElement(ElementName = "ProfitsOrLossesForThisPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ProfitsOrLossesForThisPeriod ProfitsOrLossesForThisPeriod { get; set; }
        [XmlElement(ElementName = "OtherAdjustmentsPlus", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public OtherAdjustmentsPlus OtherAdjustmentsPlus { get; set; }
        [XmlElement(ElementName = "AmountCarriedForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountCarriedForward AmountCarriedForward { get; set; }
    }

    [XmlRoot(ElementName = "ExpenditureForThisPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ExpenditureForThisPeriod
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DecommissioningExpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class DecommissioningExpenditure
    {
        [XmlElement(ElementName = "BalanceBroughtForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BalanceBroughtForward BalanceBroughtForward { get; set; }
        [XmlElement(ElementName = "ExpenditureForThisPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ExpenditureForThisPeriod ExpenditureForThisPeriod { get; set; }
        [XmlElement(ElementName = "OtherAdjustmentsPlus", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public OtherAdjustmentsPlus OtherAdjustmentsPlus { get; set; }
        [XmlElement(ElementName = "AmountCarriedForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountCarriedForward AmountCarriedForward { get; set; }
    }

    [XmlRoot(ElementName = "PreviouslyActivated", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class PreviouslyActivated
    {
        [XmlElement(ElementName = "Profits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Profits Profits { get; set; }
        [XmlElement(ElementName = "Tax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Tax Tax { get; set; }
    }

    [XmlRoot(ElementName = "ActivatedThisPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ActivatedThisPeriod
    {
        [XmlElement(ElementName = "Profits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Profits Profits { get; set; }
        [XmlElement(ElementName = "Tax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Tax Tax { get; set; }
    }

    [XmlRoot(ElementName = "TotalActivated", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalActivated
    {
        [XmlElement(ElementName = "Profits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Profits Profits { get; set; }
        [XmlElement(ElementName = "Tax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Tax Tax { get; set; }
    }

    [XmlRoot(ElementName = "TotalUsed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalUsed
    {
        [XmlElement(ElementName = "Profits", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Profits Profits { get; set; }
        [XmlElement(ElementName = "Tax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Tax Tax { get; set; }
    }

    [XmlRoot(ElementName = "ActivatedRingFenceCorporationTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ActivatedRingFenceCorporationTax
    {
        [XmlElement(ElementName = "PreviouslyActivated", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public PreviouslyActivated PreviouslyActivated { get; set; }
        [XmlElement(ElementName = "ActivatedThisPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ActivatedThisPeriod ActivatedThisPeriod { get; set; }
        [XmlElement(ElementName = "TotalActivated", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalActivated TotalActivated { get; set; }
        [XmlElement(ElementName = "TotalUsed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalUsed TotalUsed { get; set; }
    }

    [XmlRoot(ElementName = "ActivatedSupplementaryCharge", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ActivatedSupplementaryCharge
    {
        [XmlElement(ElementName = "PreviouslyActivated", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public PreviouslyActivated PreviouslyActivated { get; set; }
        [XmlElement(ElementName = "ActivatedThisPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ActivatedThisPeriod ActivatedThisPeriod { get; set; }
        [XmlElement(ElementName = "TotalActivated", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalActivated TotalActivated { get; set; }
        [XmlElement(ElementName = "TotalUsed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalUsed TotalUsed { get; set; }
    }

    [XmlRoot(ElementName = "TrackingOfTransferredTaxHistory", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TrackingOfTransferredTaxHistory
    {
        [XmlElement(ElementName = "IncludedInTaxComputations", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string IncludedInTaxComputations { get; set; }
        [XmlElement(ElementName = "RingFenceCorporationTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RingFenceCorporationTax RingFenceCorporationTax { get; set; }
        [XmlElement(ElementName = "SupplementaryCharge", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public SupplementaryCharge SupplementaryCharge { get; set; }
        [XmlElement(ElementName = "TrackedProfitsOrLosses", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TrackedProfitsOrLosses TrackedProfitsOrLosses { get; set; }
        [XmlElement(ElementName = "DecommissioningExpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public DecommissioningExpenditure DecommissioningExpenditure { get; set; }
        [XmlElement(ElementName = "ActivatedRingFenceCorporationTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ActivatedRingFenceCorporationTax ActivatedRingFenceCorporationTax { get; set; }
        [XmlElement(ElementName = "ActivatedSupplementaryCharge", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ActivatedSupplementaryCharge ActivatedSupplementaryCharge { get; set; }
    }

    [XmlRoot(ElementName = "AssetInformation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AssetInformation
    {
        [XmlElement(ElementName = "DescriptionOfAsset", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string DescriptionOfAsset { get; set; }
        [XmlElement(ElementName = "AssetReference", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string AssetReference { get; set; }
        [XmlElement(ElementName = "OGAapprovedCessation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string OGAapprovedCessation { get; set; }
        [XmlElement(ElementName = "STOcertificationQualified", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string STOcertificationQualified { get; set; }
        [XmlElement(ElementName = "TrackingOfTransferredTaxHistory", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TrackingOfTransferredTaxHistory TrackingOfTransferredTaxHistory { get; set; }
    }

    [XmlRoot(ElementName = "TransferredTaxHistory", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TransferredTaxHistory
    {
        [XmlElement(ElementName = "ElectionToTransfer", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ElectionToTransfer ElectionToTransfer { get; set; }
        [XmlElement(ElementName = "AssetInformation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<AssetInformation> AssetInformation { get; set; }
    }

    [XmlRoot(ElementName = "RingFenceTrade", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RingFenceTrade
    {
        [XmlElement(ElementName = "CalculationOfSupplementaryCharge", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CalculationOfSupplementaryCharge CalculationOfSupplementaryCharge { get; set; }
        [XmlElement(ElementName = "LossesArising", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LossesArising LossesArising { get; set; }
        [XmlElement(ElementName = "NetRingFenceTrade", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NetRingFenceTrade NetRingFenceTrade { get; set; }
        [XmlElement(ElementName = "TransferredTaxHistory", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TransferredTaxHistory TransferredTaxHistory { get; set; }
    }

    [XmlRoot(ElementName = "AvoidanceSchemes", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AvoidanceSchemes
    {
        [XmlElement(ElementName = "ReferenceNumber", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string ReferenceNumber { get; set; }
        [XmlElement(ElementName = "AccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string AccountingPeriod { get; set; }
    }

    [XmlRoot(ElementName = "TaxAvoidanceSchemes", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TaxAvoidanceSchemes
    {
        [XmlElement(ElementName = "AvoidanceSchemes", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<AvoidanceSchemes> AvoidanceSchemes { get; set; }
    }

    [XmlRoot(ElementName = "SAbeforeRestitutionTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class SAbeforeRestitutionTax
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RestitutionInterest", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RestitutionInterest
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AmountOfInterest", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountOfInterest
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxCalculation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TaxCalculation
    {
        [XmlElement(ElementName = "FinancialYearOne", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public FinancialYearOne FinancialYearOne { get; set; }
        [XmlElement(ElementName = "FinancialYearTwo", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public FinancialYearTwo FinancialYearTwo { get; set; }
    }

    [XmlRoot(ElementName = "TotalRestitutionTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalRestitutionTax
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxAlreadyWithheld", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TaxAlreadyWithheld
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SAafterRestitutionTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class SAafterRestitutionTax
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RestitutionTaxNowPayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RestitutionTaxNowPayable
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Step2RestrictionBroughtForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Step2RestrictionBroughtForward
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PreStep1CorporationTaxLiability", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class PreStep1CorporationTaxLiability
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AmountOfStep2BroughtForwardRDEC", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountOfStep2BroughtForwardRDEC
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RemainingCorporationTaxLiability", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RemainingCorporationTaxLiability
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PreStep1Restriction", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class PreStep1Restriction
    {
        [XmlElement(ElementName = "Step2RestrictionBroughtForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Step2RestrictionBroughtForward Step2RestrictionBroughtForward { get; set; }
        [XmlElement(ElementName = "PreStep1CorporationTaxLiability", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public PreStep1CorporationTaxLiability PreStep1CorporationTaxLiability { get; set; }
        [XmlElement(ElementName = "AmountOfStep2BroughtForwardRDEC", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountOfStep2BroughtForwardRDEC AmountOfStep2BroughtForwardRDEC { get; set; }
        [XmlElement(ElementName = "AmountCarriedForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountCarriedForward AmountCarriedForward { get; set; }
        [XmlElement(ElementName = "RemainingCorporationTaxLiability", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RemainingCorporationTaxLiability RemainingCorporationTaxLiability { get; set; }
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RandDExpenditureOnWhichRDECisClaimedInThisAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RandDExpenditureOnWhichRDECisClaimedInThisAccountingPeriod
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RDECclaimForThisAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RDECclaimForThisAccountingPeriod
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AmountsFromAPreviousAccountingPeriodTreatedAsRDECforThisAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountsFromAPreviousAccountingPeriodTreatedAsRDECforThisAccountingPeriod
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalRDECforTheAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalRDECforTheAccountingPeriod
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CorporationTaxLiability", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CorporationTaxLiability
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "IncomeTaxDeductedFromProfitsApplicableToCorporationTaxLiability", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class IncomeTaxDeductedFromProfitsApplicableToCorporationTaxLiability
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MaximumAmountAvailableForStep1SetOff", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class MaximumAmountAvailableForStep1SetOff
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AmountOfRDECusedToDischargeCorporationTaxAtStep1", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountOfRDECusedToDischargeCorporationTaxAtStep1
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Step1", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Step1
    {
        [XmlElement(ElementName = "RandDExpenditureOnWhichRDECisClaimedInThisAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RandDExpenditureOnWhichRDECisClaimedInThisAccountingPeriod RandDExpenditureOnWhichRDECisClaimedInThisAccountingPeriod { get; set; }
        [XmlElement(ElementName = "RDECclaimForThisAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RDECclaimForThisAccountingPeriod RDECclaimForThisAccountingPeriod { get; set; }
        [XmlElement(ElementName = "AmountsFromAPreviousAccountingPeriodTreatedAsRDECforThisAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountsFromAPreviousAccountingPeriodTreatedAsRDECforThisAccountingPeriod AmountsFromAPreviousAccountingPeriodTreatedAsRDECforThisAccountingPeriod { get; set; }
        [XmlElement(ElementName = "TotalRDECforTheAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalRDECforTheAccountingPeriod TotalRDECforTheAccountingPeriod { get; set; }
        [XmlElement(ElementName = "CorporationTaxLiability", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CorporationTaxLiability CorporationTaxLiability { get; set; }
        [XmlElement(ElementName = "IncomeTaxDeductedFromProfitsApplicableToCorporationTaxLiability", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public IncomeTaxDeductedFromProfitsApplicableToCorporationTaxLiability IncomeTaxDeductedFromProfitsApplicableToCorporationTaxLiability { get; set; }
        [XmlElement(ElementName = "MaximumAmountAvailableForStep1SetOff", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public MaximumAmountAvailableForStep1SetOff MaximumAmountAvailableForStep1SetOff { get; set; }
        [XmlElement(ElementName = "AmountOfRDECusedToDischargeCorporationTaxAtStep1", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountOfRDECusedToDischargeCorporationTaxAtStep1 AmountOfRDECusedToDischargeCorporationTaxAtStep1 { get; set; }
    }

    [XmlRoot(ElementName = "Step1BalanceCarriedForwardToStep2", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Step1BalanceCarriedForwardToStep2
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CorporationTaxChargeOnRDECforThisAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CorporationTaxChargeOnRDECforThisAccountingPeriod
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalRDECarisingInThisAPlessCorporationTaxChargeOnTheRDECforThisAP", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalRDECarisingInThisAPlessCorporationTaxChargeOnTheRDECforThisAP
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RDECarisingInThisAPlessRemainingCorporationTaxLiabilityAtStep1", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RDECarisingInThisAPlessRemainingCorporationTaxLiabilityAtStep1
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Step2RestrictionCarriedForwardToNextAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Step2RestrictionCarriedForwardToNextAccountingPeriod
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Step2", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Step2
    {
        [XmlElement(ElementName = "Step1BalanceCarriedForwardToStep2", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Step1BalanceCarriedForwardToStep2 Step1BalanceCarriedForwardToStep2 { get; set; }
        [XmlElement(ElementName = "CorporationTaxChargeOnRDECforThisAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CorporationTaxChargeOnRDECforThisAccountingPeriod CorporationTaxChargeOnRDECforThisAccountingPeriod { get; set; }
        [XmlElement(ElementName = "TotalRDECarisingInThisAPlessCorporationTaxChargeOnTheRDECforThisAP", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalRDECarisingInThisAPlessCorporationTaxChargeOnTheRDECforThisAP TotalRDECarisingInThisAPlessCorporationTaxChargeOnTheRDECforThisAP { get; set; }
        [XmlElement(ElementName = "RDECarisingInThisAPlessRemainingCorporationTaxLiabilityAtStep1", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RDECarisingInThisAPlessRemainingCorporationTaxLiabilityAtStep1 RDECarisingInThisAPlessRemainingCorporationTaxLiabilityAtStep1 { get; set; }
        [XmlElement(ElementName = "Step2RestrictionCarriedForwardToNextAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Step2RestrictionCarriedForwardToNextAccountingPeriod Step2RestrictionCarriedForwardToNextAccountingPeriod { get; set; }
    }

    [XmlRoot(ElementName = "Step2BalanceCarriedForwardToStep3", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Step2BalanceCarriedForwardToStep3
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalRelevantExpenditureOnRandDWorkersPAYEandNationalInsuranceContributions", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalRelevantExpenditureOnRandDWorkersPAYEandNationalInsuranceContributions
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Step3RestrictionCarriedForwardToNextAP", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Step3RestrictionCarriedForwardToNextAP
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Step3", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Step3
    {
        [XmlElement(ElementName = "Step2BalanceCarriedForwardToStep3", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Step2BalanceCarriedForwardToStep3 Step2BalanceCarriedForwardToStep3 { get; set; }
        [XmlElement(ElementName = "TotalRelevantExpenditureOnRandDWorkersPAYEandNationalInsuranceContributions", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalRelevantExpenditureOnRandDWorkersPAYEandNationalInsuranceContributions TotalRelevantExpenditureOnRandDWorkersPAYEandNationalInsuranceContributions { get; set; }
        [XmlElement(ElementName = "Step3RestrictionCarriedForwardToNextAP", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Step3RestrictionCarriedForwardToNextAP Step3RestrictionCarriedForwardToNextAP { get; set; }
    }

    [XmlRoot(ElementName = "Step3BalanceCarriedForwardToStep4", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Step3BalanceCarriedForwardToStep4
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AmountUsedToDischargeCorporationTaxLiabilityOfAnotherAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountUsedToDischargeCorporationTaxLiabilityOfAnotherAccountingPeriod
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Step4", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Step4
    {
        [XmlElement(ElementName = "Step3BalanceCarriedForwardToStep4", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Step3BalanceCarriedForwardToStep4 Step3BalanceCarriedForwardToStep4 { get; set; }
        [XmlElement(ElementName = "AmountUsedToDischargeCorporationTaxLiabilityOfAnotherAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountUsedToDischargeCorporationTaxLiabilityOfAnotherAccountingPeriod AmountUsedToDischargeCorporationTaxLiabilityOfAnotherAccountingPeriod { get; set; }
    }

    [XmlRoot(ElementName = "Step4BalanceCarriedForwardToStep5", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Step4BalanceCarriedForwardToStep5
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CreditSurrenderedToGroupMember", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CreditSurrenderedToGroupMember
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Step5", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Step5
    {
        [XmlElement(ElementName = "Step4BalanceCarriedForwardToStep5", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Step4BalanceCarriedForwardToStep5 Step4BalanceCarriedForwardToStep5 { get; set; }
        [XmlElement(ElementName = "CreditSurrenderedToGroupMember", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CreditSurrenderedToGroupMember CreditSurrenderedToGroupMember { get; set; }
    }

    [XmlRoot(ElementName = "Step5BalanceCarriedForwardToStep6", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Step5BalanceCarriedForwardToStep6
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AmountUsedToDischargeOtherCompanyLiabilityOnThisCTSA", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountUsedToDischargeOtherCompanyLiabilityOnThisCTSA
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AmountUsedToDischargeAnyOtherCompanyLiability", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountUsedToDischargeAnyOtherCompanyLiability
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalUsedToDischargeOtherCompanyLiability", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalUsedToDischargeOtherCompanyLiability
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Step6", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Step6
    {
        [XmlElement(ElementName = "Step5BalanceCarriedForwardToStep6", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Step5BalanceCarriedForwardToStep6 Step5BalanceCarriedForwardToStep6 { get; set; }
        [XmlElement(ElementName = "AmountUsedToDischargeOtherCompanyLiabilityOnThisCTSA", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountUsedToDischargeOtherCompanyLiabilityOnThisCTSA AmountUsedToDischargeOtherCompanyLiabilityOnThisCTSA { get; set; }
        [XmlElement(ElementName = "AmountUsedToDischargeAnyOtherCompanyLiability", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountUsedToDischargeAnyOtherCompanyLiability AmountUsedToDischargeAnyOtherCompanyLiability { get; set; }
        [XmlElement(ElementName = "TotalUsedToDischargeOtherCompanyLiability", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalUsedToDischargeOtherCompanyLiability TotalUsedToDischargeOtherCompanyLiability { get; set; }
    }

    [XmlRoot(ElementName = "AmountsExtinguished", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountsExtinguished
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PayableRDEC", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class PayableRDEC
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Step7", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Step7
    {
        [XmlElement(ElementName = "AmountsExtinguished", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountsExtinguished AmountsExtinguished { get; set; }
        [XmlElement(ElementName = "PayableRDEC", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public PayableRDEC PayableRDEC { get; set; }
    }

    [XmlRoot(ElementName = "Step2Restriction", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Step2Restriction
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SurrenderedToOtherGroupCompany", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class SurrenderedToOtherGroupCompany
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "BalanceCarriedForwardToNextAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class BalanceCarriedForwardToNextAccountingPeriod
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Step3Restriction", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Step3Restriction
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalCarriedForwardToNextAP", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalCarriedForwardToNextAP
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RDECcarriedForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RDECcarriedForward
    {
        [XmlElement(ElementName = "PreStep1Restriction", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public PreStep1Restriction PreStep1Restriction { get; set; }
        [XmlElement(ElementName = "Step2Restriction", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Step2Restriction Step2Restriction { get; set; }
        [XmlElement(ElementName = "SurrenderedToOtherGroupCompany", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public SurrenderedToOtherGroupCompany SurrenderedToOtherGroupCompany { get; set; }
        [XmlElement(ElementName = "BalanceCarriedForwardToNextAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public BalanceCarriedForwardToNextAccountingPeriod BalanceCarriedForwardToNextAccountingPeriod { get; set; }
        [XmlElement(ElementName = "Step3Restriction", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Step3Restriction Step3Restriction { get; set; }
        [XmlElement(ElementName = "TotalCarriedForwardToNextAP", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalCarriedForwardToNextAP TotalCarriedForwardToNextAP { get; set; }
    }

    [XmlRoot(ElementName = "Step2RestrictionSurrendered", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Step2RestrictionSurrendered
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Step5CreditSurrenderedToGroupMember", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Step5CreditSurrenderedToGroupMember
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalSurrendered", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalSurrendered
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RDECsurrendered", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RDECsurrendered
    {
        [XmlElement(ElementName = "Step2RestrictionSurrendered", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Step2RestrictionSurrendered Step2RestrictionSurrendered { get; set; }
        [XmlElement(ElementName = "Step5CreditSurrenderedToGroupMember", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Step5CreditSurrenderedToGroupMember Step5CreditSurrenderedToGroupMember { get; set; }
        [XmlElement(ElementName = "TotalSurrendered", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalSurrendered TotalSurrendered { get; set; }
    }

    [XmlRoot(ElementName = "RandDexpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RandDexpenditure
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalExpenditureOnExternallyProvidedWorkersFromAndSubcontractingToConnectedPersons", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalExpenditureOnExternallyProvidedWorkersFromAndSubcontractingToConnectedPersons
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PAYENICforWhichTheCompanyIsLiableInThisAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class PAYENICforWhichTheCompanyIsLiableInThisAccountingPeriod
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "EmployerPAYEreference", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class EmployerPAYEreference
    {
        [XmlElement(ElementName = "HMRCofficeNumber", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string HMRCofficeNumber { get; set; }
        [XmlElement(ElementName = "EmployerPAYEreference", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string _EmployerPAYEreference { get; set; }
    }

    [XmlRoot(ElementName = "RelevantPAYENICliabilityOfConnectedCompanies", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RelevantPAYENICliabilityOfConnectedCompanies
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ConnectedCompaniesEmployerPAYEreference", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ConnectedCompaniesEmployerPAYEreference
    {
        [XmlElement(ElementName = "HMRCofficeNumber", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string HMRCofficeNumber { get; set; }
        [XmlElement(ElementName = "EmployerPAYEreference", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string EmployerPAYEreference { get; set; }
    }

    [XmlRoot(ElementName = "RandDPayableTaxCreditClaim", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RandDPayableTaxCreditClaim
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RandDPayableTaxCreditSetOffAgainstOtherLiabilitiesOnThisReturn", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RandDPayableTaxCreditSetOffAgainstOtherLiabilitiesOnThisReturn
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RandDBalancePayableTaxCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RandDBalancePayableTaxCredit
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RDECclaimFromWorkSubcontractedToItByALargeCompany", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RDECclaimFromWorkSubcontractedToItByALargeCompany
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RDECclaimFromSubsidisedAndCappedWork", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RDECclaimFromSubsidisedAndCappedWork
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SME", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class SME
    {
        [XmlElement(ElementName = "RandDexpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RandDexpenditure RandDexpenditure { get; set; }
        [XmlElement(ElementName = "DoesTheExceptionAtS1058DCTA2009apply", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string DoesTheExceptionAtS1058DCTA2009apply { get; set; }
        [XmlElement(ElementName = "TotalExpenditureOnExternallyProvidedWorkersFromAndSubcontractingToConnectedPersons", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalExpenditureOnExternallyProvidedWorkersFromAndSubcontractingToConnectedPersons TotalExpenditureOnExternallyProvidedWorkersFromAndSubcontractingToConnectedPersons { get; set; }
        [XmlElement(ElementName = "PAYENICforWhichTheCompanyIsLiableInThisAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public PAYENICforWhichTheCompanyIsLiableInThisAccountingPeriod PAYENICforWhichTheCompanyIsLiableInThisAccountingPeriod { get; set; }
        [XmlElement(ElementName = "EmployerPAYEreference", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<EmployerPAYEreference> EmployerPAYEreference { get; set; }
        [XmlElement(ElementName = "RelevantPAYENICliabilityOfConnectedCompanies", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RelevantPAYENICliabilityOfConnectedCompanies RelevantPAYENICliabilityOfConnectedCompanies { get; set; }
        [XmlElement(ElementName = "ConnectedCompaniesEmployerPAYEreference", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<ConnectedCompaniesEmployerPAYEreference> ConnectedCompaniesEmployerPAYEreference { get; set; }
        [XmlElement(ElementName = "RandDPayableTaxCreditClaim", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RandDPayableTaxCreditClaim RandDPayableTaxCreditClaim { get; set; }
        [XmlElement(ElementName = "RandDPayableTaxCreditSetOffAgainstOtherLiabilitiesOnThisReturn", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RandDPayableTaxCreditSetOffAgainstOtherLiabilitiesOnThisReturn RandDPayableTaxCreditSetOffAgainstOtherLiabilitiesOnThisReturn { get; set; }
        [XmlElement(ElementName = "RandDBalancePayableTaxCredit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RandDBalancePayableTaxCredit RandDBalancePayableTaxCredit { get; set; }
        [XmlElement(ElementName = "RDECclaimFromWorkSubcontractedToItByALargeCompany", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RDECclaimFromWorkSubcontractedToItByALargeCompany RDECclaimFromWorkSubcontractedToItByALargeCompany { get; set; }
        [XmlElement(ElementName = "RDECclaimFromSubsidisedAndCappedWork", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RDECclaimFromSubsidisedAndCappedWork RDECclaimFromSubsidisedAndCappedWork { get; set; }
    }

    [XmlRoot(ElementName = "RDECpreStep1DischargeAmount", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RDECpreStep1DischargeAmount
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RDECstep1DischargeAmount", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RDECstep1DischargeAmount
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RDECstep6DischargeAmountForThisAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RDECstep6DischargeAmountForThisAccountingPeriod
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SMERandDBalancePayableTaxCreditUsedToDischargeOtherLiabilitiesOnThisReturn", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class SMERandDBalancePayableTaxCreditUsedToDischargeOtherLiabilitiesOnThisReturn
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalRandDSetOffAgainstLiabilities", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalRandDSetOffAgainstLiabilities
    {
        [XmlElement(ElementName = "RDECpreStep1DischargeAmount", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RDECpreStep1DischargeAmount RDECpreStep1DischargeAmount { get; set; }
        [XmlElement(ElementName = "RDECstep1DischargeAmount", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RDECstep1DischargeAmount RDECstep1DischargeAmount { get; set; }
        [XmlElement(ElementName = "RDECstep6DischargeAmountForThisAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RDECstep6DischargeAmountForThisAccountingPeriod RDECstep6DischargeAmountForThisAccountingPeriod { get; set; }
        [XmlElement(ElementName = "SMERandDBalancePayableTaxCreditUsedToDischargeOtherLiabilitiesOnThisReturn", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public SMERandDBalancePayableTaxCreditUsedToDischargeOtherLiabilitiesOnThisReturn SMERandDBalancePayableTaxCreditUsedToDischargeOtherLiabilitiesOnThisReturn { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "ResearchAndDevelopment", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ResearchAndDevelopment
    {
        [XmlElement(ElementName = "PreStep1Restriction", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public PreStep1Restriction PreStep1Restriction { get; set; }
        [XmlElement(ElementName = "Step1", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Step1 Step1 { get; set; }
        [XmlElement(ElementName = "Step2", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Step2 Step2 { get; set; }
        [XmlElement(ElementName = "Step3", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Step3 Step3 { get; set; }
        [XmlElement(ElementName = "Step4", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Step4 Step4 { get; set; }
        [XmlElement(ElementName = "Step5", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Step5 Step5 { get; set; }
        [XmlElement(ElementName = "Step6", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Step6 Step6 { get; set; }
        [XmlElement(ElementName = "Step7", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Step7 Step7 { get; set; }
        [XmlElement(ElementName = "RDECcarriedForward", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RDECcarriedForward RDECcarriedForward { get; set; }
        [XmlElement(ElementName = "RDECsurrendered", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RDECsurrendered RDECsurrendered { get; set; }
        [XmlElement(ElementName = "SME", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public SME SME { get; set; }
        [XmlElement(ElementName = "TotalRandDSetOffAgainstLiabilities", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalRandDSetOffAgainstLiabilities TotalRandDSetOffAgainstLiabilities { get; set; }
    }

    [XmlRoot(ElementName = "AddressOfBusinessOperation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AddressOfBusinessOperation
    {
        [XmlElement(ElementName = "Line", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<string> Line { get; set; }
        [XmlElement(ElementName = "AdditionalLine", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string AdditionalLine { get; set; }
        [XmlElement(ElementName = "PostCode", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string PostCode { get; set; }
    }

    [XmlRoot(ElementName = "TotalAmountOfQualifyingExpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalAmountOfQualifyingExpenditure
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalSBAclaimAmount", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalSBAclaimAmount
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "EnhancedSBAinFreeports", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class EnhancedSBAinFreeports
    {
        [XmlElement(ElementName = "LocationOfFreeport", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string LocationOfFreeport { get; set; }
        [XmlElement(ElementName = "AddressOfBusinessOperation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AddressOfBusinessOperation AddressOfBusinessOperation { get; set; }
        [XmlElement(ElementName = "DateStructureOrBuildingWasBroughtIntoQualifyingUse", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string DateStructureOrBuildingWasBroughtIntoQualifyingUse { get; set; }
        [XmlElement(ElementName = "DateOfFirstContractForConstruction", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string DateOfFirstContractForConstruction { get; set; }
        [XmlElement(ElementName = "TotalAmountOfQualifyingExpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalAmountOfQualifyingExpenditure TotalAmountOfQualifyingExpenditure { get; set; }
        [XmlElement(ElementName = "TotalSBAclaimAmount", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalSBAclaimAmount TotalSBAclaimAmount { get; set; }
    }

    [XmlRoot(ElementName = "QualifyingExpenditureTotal", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class QualifyingExpenditureTotal
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SBAclaimTotal", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class SBAclaimTotal
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalAmountOfECAclaimedWithinTheAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalAmountOfECAclaimedWithinTheAccountingPeriod
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DisposalValue", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class DisposalValue
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ECAforPlantAndMachineryInFreeports", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ECAforPlantAndMachineryInFreeports
    {
        [XmlElement(ElementName = "LocationOfFreeport", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string LocationOfFreeport { get; set; }
        [XmlElement(ElementName = "AddressOfBusinessOperation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AddressOfBusinessOperation AddressOfBusinessOperation { get; set; }
        [XmlElement(ElementName = "MadeAnEnterpriseZoneClaimRelatingToThisECAclaim", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string MadeAnEnterpriseZoneClaimRelatingToThisECAclaim { get; set; }
        [XmlElement(ElementName = "TotalAmountOfECAclaimedWithinTheAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalAmountOfECAclaimedWithinTheAccountingPeriod TotalAmountOfECAclaimedWithinTheAccountingPeriod { get; set; }
        [XmlElement(ElementName = "DisposalValue", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public DisposalValue DisposalValue { get; set; }
    }

    [XmlRoot(ElementName = "AmountOfECAclaimedWithinTheAccountingPeriodTotal", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountOfECAclaimedWithinTheAccountingPeriodTotal
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DisposalValueTotal", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class DisposalValueTotal
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Freeports", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Freeports
    {
        [XmlElement(ElementName = "EnhancedSBAinFreeports", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<EnhancedSBAinFreeports> EnhancedSBAinFreeports { get; set; }
        [XmlElement(ElementName = "QualifyingExpenditureTotal", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public QualifyingExpenditureTotal QualifyingExpenditureTotal { get; set; }
        [XmlElement(ElementName = "SBAclaimTotal", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public SBAclaimTotal SBAclaimTotal { get; set; }
        [XmlElement(ElementName = "ECAforPlantAndMachineryInFreeports", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<ECAforPlantAndMachineryInFreeports> ECAforPlantAndMachineryInFreeports { get; set; }
        [XmlElement(ElementName = "AmountOfECAclaimedWithinTheAccountingPeriodTotal", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountOfECAclaimedWithinTheAccountingPeriodTotal AmountOfECAclaimedWithinTheAccountingPeriodTotal { get; set; }
        [XmlElement(ElementName = "DisposalValueTotal", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public DisposalValueTotal DisposalValueTotal { get; set; }
    }

    [XmlRoot(ElementName = "AllocationPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AllocationPeriod
    {
        [XmlElement(ElementName = "From", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string From { get; set; }
        [XmlElement(ElementName = "To", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string To { get; set; }
    }

    [XmlRoot(ElementName = "AmountAllocated", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AmountAllocated
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "GroupCompanyReceivingAllocationAllowance", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class GroupCompanyReceivingAllocationAllowance
    {
        [XmlElement(ElementName = "Name", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Name { get; set; }
        [XmlElement(ElementName = "AccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AccountingPeriod AccountingPeriod { get; set; }
        [XmlElement(ElementName = "TaxReference", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string TaxReference { get; set; }
        [XmlElement(ElementName = "AmountAllocated", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountAllocated AmountAllocated { get; set; }
    }

    [XmlRoot(ElementName = "TotalAllocated", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalAllocated
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Section1", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Section1
    {
        [XmlElement(ElementName = "NominatedAllocatingMember", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string NominatedAllocatingMember { get; set; }
        [XmlElement(ElementName = "AllocationStatementSent", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string AllocationStatementSent { get; set; }
        [XmlElement(ElementName = "AllocationPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AllocationPeriod AllocationPeriod { get; set; }
        [XmlElement(ElementName = "PreviousAllocatingMemberName", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string PreviousAllocatingMemberName { get; set; }
        [XmlElement(ElementName = "PreviousAllocatingMemberTaxReference", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string PreviousAllocatingMemberTaxReference { get; set; }
        [XmlElement(ElementName = "IsUltimateParentCompany", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string IsUltimateParentCompany { get; set; }
        [XmlElement(ElementName = "UltimateParentCompanyName", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string UltimateParentCompanyName { get; set; }
        [XmlElement(ElementName = "GroupCompanyReceivingAllocationAllowance", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<GroupCompanyReceivingAllocationAllowance> GroupCompanyReceivingAllocationAllowance { get; set; }
        [XmlElement(ElementName = "TotalAllocated", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalAllocated TotalAllocated { get; set; }
        [XmlElement(ElementName = "StatementAuthorised", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string StatementAuthorised { get; set; }
        [XmlElement(ElementName = "FullNameOfPersonAuthorising", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string FullNameOfPersonAuthorising { get; set; }
        [XmlElement(ElementName = "StatusOfThePersonAuthorising", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string StatusOfThePersonAuthorising { get; set; }
    }

    [XmlRoot(ElementName = "NotionalAllowanceClaimed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class NotionalAllowanceClaimed
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CompanyProvidingAllocationOfNotionalAllowanceForExcludedBody", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CompanyProvidingAllocationOfNotionalAllowanceForExcludedBody
    {
        [XmlElement(ElementName = "CompanyName", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string CompanyName { get; set; }
        [XmlElement(ElementName = "TaxReference", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string TaxReference { get; set; }
        [XmlElement(ElementName = "Amount", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Amount Amount { get; set; }
    }

    [XmlRoot(ElementName = "ExcludedCompanyThatIsJVCmember", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ExcludedCompanyThatIsJVCmember
    {
        [XmlElement(ElementName = "NameOfTheExcludedBody", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string NameOfTheExcludedBody { get; set; }
        [XmlElement(ElementName = "ExcludedBodysTaxReference", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string ExcludedBodysTaxReference { get; set; }
    }

    [XmlRoot(ElementName = "Section2", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Section2
    {
        [XmlElement(ElementName = "NotionalAllowanceClaimed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NotionalAllowanceClaimed NotionalAllowanceClaimed { get; set; }
        [XmlElement(ElementName = "NotionalAllowanceAllocatedToExcludedBody", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string NotionalAllowanceAllocatedToExcludedBody { get; set; }
        [XmlElement(ElementName = "CompanyProvidingAllocationOfNotionalAllowanceForExcludedBody", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<CompanyProvidingAllocationOfNotionalAllowanceForExcludedBody> CompanyProvidingAllocationOfNotionalAllowanceForExcludedBody { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
        [XmlElement(ElementName = "ExcludedCompanyThatIsJVCmember", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<ExcludedCompanyThatIsJVCmember> ExcludedCompanyThatIsJVCmember { get; set; }
    }

    [XmlRoot(ElementName = "DetailsOfSurrender", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class DetailsOfSurrender
    {
        [XmlElement(ElementName = "Name", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Name { get; set; }
        [XmlElement(ElementName = "AccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AccountingPeriod AccountingPeriod { get; set; }
        [XmlElement(ElementName = "TaxReference", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string TaxReference { get; set; }
        [XmlElement(ElementName = "AmountClaimed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountClaimed AmountClaimed { get; set; }
        [XmlElement(ElementName = "AmountSurrendered", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AmountSurrendered AmountSurrendered { get; set; }
    }

    [XmlRoot(ElementName = "AuthorisationForSimplifiedArrangements", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AuthorisationForSimplifiedArrangements
    {
        [XmlElement(ElementName = "StatementAuthorised", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string StatementAuthorised { get; set; }
        [XmlElement(ElementName = "FullNameOfPersonAuthorising", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string FullNameOfPersonAuthorising { get; set; }
        [XmlElement(ElementName = "Status", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string Status { get; set; }
        [XmlElement(ElementName = "NameOfAuthorisedCompany", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string NameOfAuthorisedCompany { get; set; }
    }

    [XmlRoot(ElementName = "Section3Part1", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Section3Part1
    {
        [XmlElement(ElementName = "DetailsOfSurrender", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<DetailsOfSurrender> DetailsOfSurrender { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
        [XmlElement(ElementName = "ClaimAuthorisation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ClaimAuthorisation ClaimAuthorisation { get; set; }
    }

    [XmlRoot(ElementName = "Section3Part2", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Section3Part2
    {
        [XmlElement(ElementName = "DetailsOfSurrender", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<DetailsOfSurrender> DetailsOfSurrender { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
        [XmlElement(ElementName = "ConsentToSurrender", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ConsentToSurrender ConsentToSurrender { get; set; }
    }

    [XmlRoot(ElementName = "Section3Part3", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Section3Part3
    {
        [XmlElement(ElementName = "DetailsOfSurrender", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<DetailsOfSurrender> DetailsOfSurrender { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
        [XmlElement(ElementName = "ClaimAuthorisation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ClaimAuthorisation ClaimAuthorisation { get; set; }
    }

    [XmlRoot(ElementName = "Section3Part4", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Section3Part4
    {
        [XmlElement(ElementName = "DetailsOfSurrender", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<DetailsOfSurrender> DetailsOfSurrender { get; set; }
        [XmlElement(ElementName = "Total", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Total Total { get; set; }
        [XmlElement(ElementName = "ConsentToSurrender", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ConsentToSurrender ConsentToSurrender { get; set; }
    }

    [XmlRoot(ElementName = "Section3", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Section3
    {
        [XmlElement(ElementName = "Section3Part1", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Section3Part1 Section3Part1 { get; set; }
        [XmlElement(ElementName = "Section3Part2", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Section3Part2 Section3Part2 { get; set; }
        [XmlElement(ElementName = "Section3Part3", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Section3Part3 Section3Part3 { get; set; }
        [XmlElement(ElementName = "Section3Part4", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Section3Part4 Section3Part4 { get; set; }
    }

    [XmlRoot(ElementName = "AdjustedProfit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AdjustedProfit
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AdjustedLoss", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AdjustedLoss
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "JointVentureProfit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class JointVentureProfit
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "JointVentureLoss", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class JointVentureLoss
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TotalOfProfit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class TotalOfProfit
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AllowableLossRelief", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AllowableLossRelief
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AllowableRPDTgroupReliefClaimed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AllowableRPDTgroupReliefClaimed
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AllowableRPDTgroupReliefForCarriedForwardLossesClaimed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AllowableRPDTgroupReliefForCarriedForwardLossesClaimed
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RPDprofitsForAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class RPDprofitsForAccountingPeriod
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AllowanceAllocationForAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AllowanceAllocationForAccountingPeriod
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ProfitsChargeableToRPDT", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ProfitsChargeableToRPDT
    {
        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Section4", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Section4
    {
        [XmlElement(ElementName = "AdjustedProfit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AdjustedProfit AdjustedProfit { get; set; }
        [XmlElement(ElementName = "AdjustedLoss", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AdjustedLoss AdjustedLoss { get; set; }
        [XmlElement(ElementName = "JointVentureProfit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public JointVentureProfit JointVentureProfit { get; set; }
        [XmlElement(ElementName = "JointVentureLoss", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public JointVentureLoss JointVentureLoss { get; set; }
        [XmlElement(ElementName = "TotalOfProfit", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TotalOfProfit TotalOfProfit { get; set; }
        [XmlElement(ElementName = "AllowableLossRelief", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AllowableLossRelief AllowableLossRelief { get; set; }
        [XmlElement(ElementName = "AllowableRPDTgroupReliefClaimed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AllowableRPDTgroupReliefClaimed AllowableRPDTgroupReliefClaimed { get; set; }
        [XmlElement(ElementName = "AllowableRPDTgroupReliefForCarriedForwardLossesClaimed", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AllowableRPDTgroupReliefForCarriedForwardLossesClaimed AllowableRPDTgroupReliefForCarriedForwardLossesClaimed { get; set; }
        [XmlElement(ElementName = "RPDprofitsForAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RPDprofitsForAccountingPeriod RPDprofitsForAccountingPeriod { get; set; }
        [XmlElement(ElementName = "AllowanceAllocationForAccountingPeriod", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AllowanceAllocationForAccountingPeriod AllowanceAllocationForAccountingPeriod { get; set; }
        [XmlElement(ElementName = "ProfitsChargeableToRPDT", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ProfitsChargeableToRPDT ProfitsChargeableToRPDT { get; set; }
        [XmlElement(ElementName = "RPDTpayable", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RPDTpayable RPDTpayable { get; set; }
    }

    [XmlRoot(ElementName = "ResidentialPropertyDeveloperTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class ResidentialPropertyDeveloperTax
    {
        [XmlElement(ElementName = "Section1", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Section1 Section1 { get; set; }
        [XmlElement(ElementName = "Section2", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Section2 Section2 { get; set; }
        [XmlElement(ElementName = "Section3", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Section3 Section3 { get; set; }
        [XmlElement(ElementName = "Section4", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Section4 Section4 { get; set; }
    }

    [XmlRoot(ElementName = "Attachment", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class Attachment
    {
        [XmlAttribute(AttributeName = "Description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "Filename")]
        public string Filename { get; set; }
        [XmlAttribute(AttributeName = "Format")]
        public string Format { get; set; }
        [XmlAttribute(AttributeName = "Size")]
        public string Size { get; set; }
        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AttachedFiles", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class AttachedFiles
    {
        [XmlElement(ElementName = "Attachment", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public List<Attachment> Attachment { get; set; }
    }

    [XmlRoot(ElementName = "CompanyTaxReturn", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class CompanyTaxReturn
    {
        [XmlElement(ElementName = "CompanyInformation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CompanyInformation CompanyInformation { get; set; }
        [XmlElement(ElementName = "ReturnInfoSummary", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ReturnInfoSummary ReturnInfoSummary { get; set; }
        [XmlElement(ElementName = "Turnover", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Turnover Turnover { get; set; }
        [XmlElement(ElementName = "CompanyTaxCalculation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CompanyTaxCalculation CompanyTaxCalculation { get; set; }
        [XmlElement(ElementName = "EnergyProfitsLevy", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public EnergyProfitsLevy EnergyProfitsLevy { get; set; }
        [XmlElement(ElementName = "CalculationOfTaxOutstandingOrOverpaid", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CalculationOfTaxOutstandingOrOverpaid CalculationOfTaxOutstandingOrOverpaid { get; set; }
        [XmlElement(ElementName = "TaxReconciliation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TaxReconciliation TaxReconciliation { get; set; }
        [XmlElement(ElementName = "IndicatorsAndInformation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public IndicatorsAndInformation IndicatorsAndInformation { get; set; }
        [XmlElement(ElementName = "EnhancedExpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public EnhancedExpenditure EnhancedExpenditure { get; set; }
        [XmlElement(ElementName = "LandRemediationEnhancedExpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LandRemediationEnhancedExpenditure LandRemediationEnhancedExpenditure { get; set; }
        [XmlElement(ElementName = "AllowancesAndCharges", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AllowancesAndCharges AllowancesAndCharges { get; set; }
        [XmlElement(ElementName = "NotIncluded", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NotIncluded NotIncluded { get; set; }
        [XmlElement(ElementName = "QualifyingExpenditure", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public QualifyingExpenditure QualifyingExpenditure { get; set; }
        [XmlElement(ElementName = "LossesDeficitsAndExcess", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LossesDeficitsAndExcess LossesDeficitsAndExcess { get; set; }
        [XmlElement(ElementName = "NorthernIrelandInformation", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIrelandInformation NorthernIrelandInformation { get; set; }
        [XmlElement(ElementName = "OverpaymentsAndRepayments", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public OverpaymentsAndRepayments OverpaymentsAndRepayments { get; set; }
        [XmlElement(ElementName = "Declaration", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Declaration Declaration { get; set; }
        [XmlElement(ElementName = "LoansByCloseCompanies", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public LoansByCloseCompanies LoansByCloseCompanies { get; set; }
        [XmlElement(ElementName = "ControlledForeignCompanies", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ControlledForeignCompanies ControlledForeignCompanies { get; set; }
        [XmlElement(ElementName = "GroupAndConsortium", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public GroupAndConsortium GroupAndConsortium { get; set; }
        [XmlElement(ElementName = "Insurance", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Insurance Insurance { get; set; }
        [XmlElement(ElementName = "Charity", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Charity Charity { get; set; }
        [XmlElement(ElementName = "TonnageTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TonnageTax TonnageTax { get; set; }
        [XmlElement(ElementName = "NorthernIreland", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public NorthernIreland NorthernIreland { get; set; }
        [XmlElement(ElementName = "CrossBorderRoyalties", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CrossBorderRoyalties CrossBorderRoyalties { get; set; }
        [XmlElement(ElementName = "RingFenceTrade", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RingFenceTrade RingFenceTrade { get; set; }
        [XmlElement(ElementName = "TaxAvoidanceSchemes", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public TaxAvoidanceSchemes TaxAvoidanceSchemes { get; set; }
        [XmlElement(ElementName = "RestitutionTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public RestitutionTax RestitutionTax { get; set; }
        [XmlElement(ElementName = "ResearchAndDevelopment", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ResearchAndDevelopment ResearchAndDevelopment { get; set; }
        [XmlElement(ElementName = "Freeports", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public Freeports Freeports { get; set; }
        [XmlElement(ElementName = "ResidentialPropertyDeveloperTax", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public ResidentialPropertyDeveloperTax ResidentialPropertyDeveloperTax { get; set; }
        [XmlElement(ElementName = "WelshReturn", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string WelshReturn { get; set; }
        [XmlElement(ElementName = "JointAccounts", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public string JointAccounts { get; set; }
        [XmlElement(ElementName = "AttachedFiles", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public AttachedFiles AttachedFiles { get; set; }
        [XmlAttribute(AttributeName = "ReturnType")]
        public string ReturnType { get; set; }
    }

    [XmlRoot(ElementName = "IRenvelope", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
    public class IRenvelope
    {
        [XmlElement(ElementName = "IRheader", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public IRheader IRheader { get; set; }
        [XmlElement(ElementName = "CompanyTaxReturn", Namespace = "http://www.govtalk.gov.uk/taxation/CT/5")]
        public CompanyTaxReturn CompanyTaxReturn { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

}

