# How to programmatically fill an Interactive Form with values


The example shows how to fill an interactive form using field names. <br><br>To learn how to get a checked appearance name for the check box, see the <a href="https://documentation.devexpress.com/DocumentServer/119944/PDF-Document-Processor/Examples/Interactive-Form/How-to-Obtain-a-Checked-Appearance-Name-for-a-Check-Box">How to: Obtain a Checked Appearance Name for a Check Box </a>example.<br><br>To learn how to get a checked appearance name for the radio button, see <a href="https://www.devexpress.com/Support/Center/Example/Details/T622985/how-to-obtain-a-checked-appearance-name-for-each-radio-button-in-the-radio-group">How to obtain a checked appearance name for each radio button in the radio group</a> example.<br><br>The Universal Subscription or an additional Document Server Subscription is required to use this example in production code. Please refer to the <a href="https://www.devexpress.com/Subscriptions/">DevExpress Subscription</a> page for pricing information. <br><br>


<h3>Description</h3>

To obtain names of interactive form fields, call the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_GetFormDatatopic">PdfDocumentProcessor.GetFormData </a>method. Then, specify a value for a form field using the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfFormData_Valuetopic">PdfFormData.Value </a>property. <br><br>To apply data to the interactive form, call the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_ApplyFormDatatopic">PdfDocumentProcessor.ApplyFormData</a> method. <br><br>

<br/>


