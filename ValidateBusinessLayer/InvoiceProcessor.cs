using InvoiceDom.BusinessLayer.Helpers;
using InvoiceDom.Types;

namespace InvoiceDom.BusinessLayer
{
    /// <summary>
    /// Invoice processor
    /// </summary>
    public class InvoiceProcessor
    {
        private readonly IEventMessenger eventMessenger;
        private readonly IInvoiceValidator invoiceValidator;

        public InvoiceProcessor(IEventMessenger eventMessenger, IInvoiceValidator invoiceValidator)
        {
            this.eventMessenger = eventMessenger;
            this.invoiceValidator = invoiceValidator;
        }


        /// <summary>
        /// Invoice validating & sanitizing & processing
        /// </summary>
        /// <param name="invoices"></param>
        public void Process(IEnumerable<Invoice> invoices)
        {
            foreach (var invoice in invoices)
            {
                try
                {
                    eventMessenger.WriteInfoMessage($"Process has started");
                    eventMessenger.WriteTraceMessage(invoice.InvoiceNumber.ToString(), "Sanizizing ...");

                    SanitizeInvoice(invoice);

                    eventMessenger.WriteTraceMessage(invoice.InvoiceNumber.ToString(), "Validating ...");

                    invoiceValidator.Validate(invoice);


                    eventMessenger.WriteTraceMessage(invoice.InvoiceNumber.ToString(), "Uploading to ERP ...");

                    UploadToERP(invoice);
                }
                catch (Exception e)
                {
                    eventMessenger.WriteErrorMessage($" ---> Error: {e.Message}");
                }
                finally
                {
                    eventMessenger.WriteInfoMessage("Process has finished");
                }
            }
        }

        private void SanitizeInvoice(Invoice invoice)
        {
            invoice.Supplier.VAT = VATHelper.RemoveNonAlphanumeric(invoice.Supplier.VAT);
            invoice.Customer.VAT = VATHelper.RemoveNonAlphanumeric(invoice.Customer.VAT);
        }

        private void UploadToERP(Invoice invoice)
        {
            eventMessenger.WriteTraceMessage(invoice.InvoiceNumber.ToString(), "The invoice data Upload to ERP has finished successfully");
        }
    }
}
