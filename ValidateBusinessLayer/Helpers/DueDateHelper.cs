namespace InvoiceDom.BusinessLayer.Helpers
{
    public class DueDateHelper
    {
        public static bool IsDueDateValid(DateOnly dateOnly, DateOnly currentDateOnly)
        {
            return currentDateOnly.CompareTo(dateOnly) <= 0;
        }
    }
}
