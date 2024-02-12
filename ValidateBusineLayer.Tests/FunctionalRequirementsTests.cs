using System.Globalization;
using InvoiceDom.BusinessLayer.Helpers;


namespace ValidateBusineLayer.Tests
{
    public class FunctionalRequirementsTests
    {
        [Theory]
        [InlineData("CZ34560613", "CZ34560613")]
        [InlineData("CZ-34560613", "CZ34560613")]
        [InlineData("!, \", #, $, %, &, ', (, ), *, +, ,, -, ., /, :, ;, <, =, >, ?, @, [, \\, ], ^, _, `, {, |, }, ~", "")]
        public void VATNormalizationTest(string input, string expected)
        {
            Assert.Equal(expected, VATHelper.RemoveNonAlphanumeric(input));
        }

        [Theory]
        [InlineData("invoice_2.pdf", true)]
        [InlineData("invoice_3.txt", false)]
        [InlineData("invoice_4", false)]
        [InlineData("invoice_4.", false)]
        [InlineData("invoice_5.png", false)]
        public void IsFileTypeValidTest(string input, bool expected)
        {
            Assert.Equal(expected, FileHelper.IsFileTypeValid(input));
        }

        public readonly DateOnly RelativeDateOnlyNow = new DateOnly(2024, 02, 12);

        [Theory]
        [InlineData("12/2/2024", true)]
        [InlineData("1/1/2024", false)]
        [InlineData("13/2/2024", true)]
        public void IsDueDateValidTest(string date, bool expected)
        {
            var input = DateOnly.ParseExact(date, "d/M/yyyy", CultureInfo.InvariantCulture);
            Assert.Equal(expected, DueDateHelper.IsDueDateValid(input, RelativeDateOnlyNow));
        }
    }
}