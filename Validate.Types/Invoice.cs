using System.ComponentModel.DataAnnotations;

namespace InvoiceDom.Types
{
    public class Invoice
    {
        [Required]
        public int InvoiceNumber { get; set; }
        public Supplier Supplier { get; set; }
        public Customer Customer { get; set; }
        public PaymentDetails PaymentDetails { get; set; }
        public List<InvoiceLineItem> LineItems { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        [Required]
        public DateOnly Date { get; set; }
        public DateOnly DueDate { get; set; }
        public DateOnly DateOfTaxableSupply { get; set; }

        [Required]
        public decimal TotalWithoutVAT { get; set; }
        public decimal Total { get; set; }

        public void IsValid()
        {
            ValidateVendor();
        }

        private void ValidateVendor()
        {

        }
    }

    public enum PaymentMethod
    {
        transfer, creditCard
    }
}
