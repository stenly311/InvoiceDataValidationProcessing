using InvoiceDom.BusinessLayer.Helpers;
using InvoiceDom.Types;

namespace InvoiceDom.BusinessLayer
{
    public interface IInvoiceValidator
    {
        void Validate(Invoice invoice);
    }

    /// <summary>
    /// Validate Invoice
    /// </summary>
    public class InvoiceValidator : IInvoiceValidator
    {
        private Dictionary<string, string> _vATNumbersVendorsDic = new Dictionary<string, string>();

        public InvoiceValidator()
        {
            LoadVendorsVATNumbers();
        }

        /// <summary>
        /// Validates invoice as per requirements
        /// </summary>
        /// <param name="invoice"></param>
        /// <exception cref="Exception"></exception>
        public void Validate(Invoice invoice)
        {
            if (invoice == null)
            {
                throw new Exception("No invoice provided");
            }

            if (!IsVendorWhitelisted(invoice.Supplier.VAT.ToUpper()))
                throw new Exception($"Vendor on the invoice is not whitelisted.");

            if (!DueDateHelper.IsDueDateValid(invoice.DueDate, invoice.Date))
                throw new Exception($"The invoice with #'{0}' and issue date: {invoice.Date} has a wrong due date: '{invoice.DueDate}'.");

        }

        /// <summary>
        /// Validates whether Vendor VAT number is whitelisted
        /// </summary>
        /// <param name="vendorVATNumber"></param>
        private bool IsVendorWhitelisted(string vendorVATNumber)
        {
            return _vATNumbersVendorsDic.ContainsKey(vendorVATNumber);
        }


        /// <summary>
        /// Simple method how to populate and cache the list of vendors
        /// </summary>
        private void LoadVendorsVATNumbers()
        {
            // this can be change to external file/API etc.
            _vATNumbersVendorsDic = new() {
                { "DE355869309", "Ennel Holding" },
                { "DE379503850", "Browar Hergatz" },
                { "PL839274940", "Browar Kraków" },
                { "CZ34560613", "Supplier s.r.o." }
            };
        }
    }
}
