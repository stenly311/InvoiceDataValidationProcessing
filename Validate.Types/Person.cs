namespace InvoiceDom.Types
{
    public abstract class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public string CIN { get; set; }
        public string VAT { get; set; }
    }
}
