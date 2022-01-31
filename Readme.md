<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595638/17.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T210253)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# PDF Document API - Fill Interactive Form Fields

This example demonstrates how to retrieve a list of form field names and specify field values of an interactive form.

> You need a license for the [DevExpress Office File API Subscription](https://www.devexpress.com/products/net/office-file-api/) or [DevExpress Universal Subscription](https://www.devexpress.com/subscriptions/universal.xml) to use this library in production code. 

## Implementation Details

1. Call the [PdfDocumentProcessor.LoadDocument](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.LoadDocument.overloads) method to load a PDF document with an interactive form. 
2. Call the [PdfDocumentProcessor.GetFormData](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.GetFormData) method to retrieve the [PdfFormData](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfFormData) object that contains interactive form data. 
3. Specify field values of an interactive form. Call the [PdfDocumentProcessor.ApplyFormData](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.ApplyFormData(DevExpress.Pdf.PdfFormData)) method to apply data to the interactive form and save the PDF document.
4. You can call the [PdfDocumentProcessor.GetFormFieldNames](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.GetFormFieldNames) method to retrieve a list of field names and iterate through the returned string collection.

Starting with 21.1, we recommend that you use the [PdfDocumentFacade](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentFacade) class to change the PDF document without access to its inner structure. Use the [PdfDocumentFacade.AcroForm](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentFacade.AcroForm) property to get interactive form field options. You can change form fields and appearance properties. Refer to the following example for information on how to use the [PdfDocumentFacade](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentFacade) class: [PDF Document API - How to Change PDF Form Field Parameters](https://github.com/DevExpress-Examples/how-to-change-pdf-form-field-parameters).

<!-- default file list -->
## Files to Look At
[PdfFormFilling.cs](./CS/PdfFormFilling/PdfFormFilling.cs) (VB: [PdfFormFilling.vb](./VB/PdfFormFilling/PdfFormFilling.vb))
<!-- default file list end -->

## More Examples

- [PDF Document API - Obtain a Checked Appearance Name for a Check Box](https://github.com/DevExpress-Examples/how-to-obtain-a-checked-appearance-name-for-a-check-box-t609857)
- [PDF Document API - Obtain a Checked Appearance Name for Each Radio Button in the Radio Group](https://github.com/DevExpress-Examples/how-to-obtain-a-checked-appearance-name-for-each-radio-button-in-the-radio-group-T622985)

