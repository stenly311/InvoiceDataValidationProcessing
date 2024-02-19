# InvoiceDataValidationProcessing Interview Exercise

Dear Martin, 
 
Thank you for a very nice and productive discovery session with our team here at CustomerX.
 
After this upcoming call the CustomerX team should know what’s ahead for them on the journey to unlocking the full potential of the Rossum solution.
Feel free to combine life demonstrations with any type of assets you find useful. All relevant stakeholders will be represented by Rossum team members.
We would like to review the requirements that you have most certainly identified during the Discovery Call with our key stakeholders. Please walk us through your solutions to our troubles and teach us how to maintain and further develop these.
Discuss all project-management related items, touch on commercials, discuss cooperation with CustomerX personnel, SLAs, KPIs and everything that you believe should be discussed when kicking off implementation of a professional services project.

# Access to Rossum Team
Before the final solution design presentation role play feel free to reach out to the team you have been in touch on the discovery call, this time as part of the Rossum team. This should give you all the needed inputs as if this was a real business case.

# Hands-on Tasks
Please be ready to present solutions to all the following tasks. Make sure to explain how to further maintain this; please touch on the even model as well as the data structures one should be aware of (mainly annotation). Make sure to walk us through the concept of server-less functions and explain briefly how it actually works. We want to see some code.

## VAT Normalisation
Our ERPX is unable to process VAT numbers with non-alphanumeric characters. Please come up with a solution that removes such characters from the VAT code.

## Unsupported Files
At CustomerX our vendors sometimes send irrelevant attachments which we don’t want to deal with like logos of their company. We would like to process only PDF files.

## Due Date
Due dates should not be in the past. Please emit an error if this occurs.

## Line Items Calculations
Line items only contain unit price and quantity but not total price which is not printed on the document. Please create a new column in line items and populate it with the product of unit price and quantity.

## Vendor Matching
The ERPX requires Vendor Code to be provided with the invoice data (sample list of vendors attached).
If the vendor is not recognised, the document should be blocked in Rossum with an error message.

## Data Points for Extraction
Should you need it, the list of fields CustomerX wishes to extract is also attached.
 
Looking forward to meeting you on our next call.
 
Kind Regards!
CustomerX

----------------------

Hi Kate, how are you?

Apologies for my late reply, but this week was my last week with QBE so the last few days were workload intense. 

Anyway, while reading the exercise requirements in your last email, some things are not quite clear to me. 

## Would you be able to bring more lights to these, please?

- Is there any preference in what format/document to choose for presentation purposes?
- when mentioning coding in Hands-on Task section, the chapters below that line are the functional requirements? **Is the selection of the runtime application up to me or is there any preference (non-functional requirement)**
- I am happy to explain the architecture and purpose/fit of serverless functions if that's what is required

Looking forward to hearing from you. 
Regards, Martin.

------------------------

Hi Martin, 

Thanks for your email. Happy to answer your questions:

**- Presentation format:** PowerPoint is a classic choice, we've seen successful variations beyond that. We encourage creativity in choosing your presentation format. If you have any uncertainties or need further guidance, please don't hesitate to ask.

**- Hands-on Task section:** When mentioning coding, the subsequent chapters are indeed focused on the functional requirements. **As for the selection of the runtime application, it's entirely up to you.** If you prefer Python over Node.js for serverless functions, that's perfectly acceptable. 

**- Architecture and purpose/fit of serverless functions:** yes, please walk us through it :)

I hope this helps!

Have a nice weekend,

Katerina
