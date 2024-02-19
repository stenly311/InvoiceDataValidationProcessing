// See https://aka.ms/new-console-template for more information
using InvoiceDom.BusinessLayer;
using InvoiceDom.Types;

Console.WriteLine("Start");

// build invoice collectin run test data
var invoices = new List<Invoice>{
                new()
                {
                    InvoiceNumber = 1,
                    Customer = new Customer(),
                    Supplier = new Supplier
                    {
                        VAT = "DE-355869309~"
                    },
                    Date = new DateOnly(2024,2,10),
                    DueDate  = new DateOnly(2024,2,15),
                    LineItems = new List<InvoiceLineItem>{ new() { Code="A", Description="desc", UnitPrice=15.5m , Amount=10 } }
                },
                new()
                {
                    InvoiceNumber = 2,
                    Customer = new Customer(),
                    Supplier = new Supplier
                    {
                        VAT = "wrong VAT"
                    },
                    Date = new DateOnly(2024,2,10),
                    DueDate  = new DateOnly(2024,2,15),
                    LineItems = new List<InvoiceLineItem>{ new() { Code="A", Description="desc", UnitPrice=15.5m , Amount=10 } }
                },
                new()
                {
                    InvoiceNumber = 3,
                    Customer = new Customer(),
                    Supplier = new Supplier
                    {
                        VAT = "DE-355869309~"
                    },
                    Date = new DateOnly(2024,2,10),
                    DueDate  = new DateOnly(2024,2,9), // wrong due date
                    LineItems = new List<InvoiceLineItem>{ new() { Code="A", Description="desc", UnitPrice=15.5m , Amount=10 } }
                }

            };

// IoC
var eMessanger = new EventMessenger();
var iValidator = new InvoiceValidator();

var processor = new InvoiceProcessor(eMessanger, iValidator);

// process invoces
processor.Process(invoices);

Console.WriteLine("End");

/*

REQUIREMENTS LIST
-----------------------------

* VAT Normalisation
Our ERPX is unable to process VAT numbers with non-alphanumeric characters. Please come up with a solution that removes such characters from the VAT code.

* Unsupported Files
At CustomerX our vendors sometimes send irrelevant attachments which we don’t want to deal with like logos of their company. We would like to process only PDF files.

* Due Date
Due dates should not be in the past. Please emit an error if this occurs.

* Line Items Calculations
Line items only contain unit price and quantity but not total price which is not printed on the document. Please create a new column in line items and populate it with the product of unit price and quantity.

* Vendor Matching
The ERPX requires Vendor Code to be provided with the invoice data (sample list of vendors attached).
If the vendor is not recognised, the document should be blocked in Rossum with an error message.

* Data Points for Extraction
Should you need it, the list of fields CustomerX wishes to extract is also attached.
 
 */ 