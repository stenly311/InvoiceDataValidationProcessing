using System.ComponentModel.DataAnnotations;

namespace InvoiceDom.Types
{
    public class InvoiceLineItem
    {
        public string Code { get; set; }
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal VAT { get; set; }
        public decimal TotalPrice
        {
            get
            {
                return UnitPrice * Amount;
            }
        }
    }
}
