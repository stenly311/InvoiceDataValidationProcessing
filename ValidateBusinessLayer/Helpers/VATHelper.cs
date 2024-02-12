using System.Text.RegularExpressions;

namespace InvoiceDom.BusinessLayer.Helpers;
public static class VATHelper
{
    private static string DefaultVATEmptyValue = "";

    public static string RemoveNonAlphanumeric(string input)
    {
        // Use regular expression to replace non-alphanumeric characters with an empty string
        if (input != null)
            return Regex.Replace(input, @"[^a-zA-Z0-9]", "");
        return DefaultVATEmptyValue;
    }
}
