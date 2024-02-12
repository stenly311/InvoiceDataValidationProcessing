namespace InvoiceDom.BusinessLayer
{
    public interface IEventMessenger
    {
        void WriteErrorMessage(string message);
        void WriteInfoMessage(string message);
        void WriteTraceMessage(string invoiceNumber, string message);
    }

    /// <summary>
    /// Event message handler
    /// </summary>
    public class EventMessenger : IEventMessenger
    {
        /// <summary>
        /// Writing events to console
        /// </summary>
        /// <param name="message"></param>
        public void WriteErrorMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void WriteTraceMessage(string invoiceNumber, string message)
        {
            Console.WriteLine($"Invoice # '{invoiceNumber}' Action: '{message}'");
        }

        public void WriteInfoMessage(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
        }
    }
}
