namespace InvoiceDom.BusinessLayer.Helpers
{
    public static class FileHelper
    {
        private const string ValidTypes = "pdf";
        public static bool IsFileTypeValid(string fileName)
        {
            if (fileName.Contains("."))
                return ValidTypes.Equals(fileName?.ToLower().Split(".")[1]);
            return false;
        }
    }
}
