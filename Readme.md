<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595638/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T210253)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [PdfFormFilling.cs](./CS/PdfFormFilling/PdfFormFilling.cs) (VB: [PdfFormFilling.vb](./VB/PdfFormFilling/PdfFormFilling.vb))
<!-- default file list end -->
# How to programmatically fill an Interactive Form with values


The example shows how to fill an interactive form using field names. <br><br>To learn how to get a checked appearance name for the check box, see the <a href="https://documentation.devexpress.com/DocumentServer/119944/PDF-Document-Processor/Examples/Interactive-Form/How-to-Obtain-a-Checked-Appearance-Name-for-a-Check-Box">How to: Obtain a Checked Appearance Name for a Check Box </a>example.<br><br>To learn how to get a checked appearance name for the radio button, see <a href="https://www.devexpress.com/Support/Center/Example/Details/T622985/how-to-obtain-a-checked-appearance-name-for-each-radio-button-in-the-radio-group">How to obtain a checked appearance name for each radio button in the radio group</a> example.<br><br>The Universal Subscription or an additional Document Server Subscription is required to use this example in production code. Please refer to the <a href="https://www.devexpress.com/Subscriptions/">DevExpress Subscription</a> page for pricing information. <br><br>


<h3>Description</h3>

To obtain names of interactive form fields, call the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_GetFormDatatopic">PdfDocumentProcessor.GetFormData </a>method. Then, specify a value for a form field using the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfFormData_Valuetopic">PdfFormData.Value </a>property. <br><br>To apply data to the interactive form, call the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_ApplyFormDatatopic">PdfDocumentProcessor.ApplyFormData</a> method. <br><br>

<br/>


