namespace InvoiceDom.Types
{
    public class PaymentDetails
    {
        public string Bank { get; set; }
        public string SWIFT { get; set; }
        public string IBAN { get; set; }
        public string AccountNumber { get; set; }
    }
}
