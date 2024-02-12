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

