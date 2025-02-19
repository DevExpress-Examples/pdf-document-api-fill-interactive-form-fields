
using DevExpress.Pdf;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;

namespace InteractiveFormFilling
{

    public partial class PdfFormFilling : XtraForm
    {
        string filePath = AppContext.BaseDirectory;
        string fileName = "FieldTypes";

        public PdfFormFilling()
        {
            InitializeComponent();
            pdfViewer1.LoadDocument(filePath + fileName + ".pdf");
        }

        private void btnGetFieldNames_Click(object sender, EventArgs e)
        {
            #region #GetFields

            // Load a document with an interactive form.
            using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor())
            {
                documentProcessor.LoadDocument(filePath + fileName + ".pdf");

                // Get names of interactive form fields.
                IList<string> names = documentProcessor.GetFormFieldNames();

                // Show the field names in the rich text box.
                string[] strings = new string[names.Count];
                names.CopyTo(strings, 0);
                richTextBox1.Lines = strings;
            }
            #endregion #GetFields
        }

        private void btnFillFormData_Click(object sender, EventArgs e)
        {
            #region #FillFields

            // Load a document with an interactive form.
            using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor())
            {
                documentProcessor.LoadDocument(filePath + fileName + ".pdf");

                PdfDocumentFacade documentFacade = documentProcessor.DocumentFacade;
                PdfAcroFormFacade acroForm = documentFacade.AcroForm;

                PdfTextFormFieldFacade nameField = acroForm.GetTextFormField("FirstName");
                nameField.Value = "Janet";

                PdfTextFormFieldFacade surnameField = acroForm.GetTextFormField("LastName");
                surnameField.Value = "Leverling";

                PdfListBoxFormFieldFacade categoryField = acroForm.GetListBoxFormField("Category");
                categoryField.Values = new List<string>() { "Entertainment", "Meals", "Morale" };

                PdfTextFormFieldFacade addressField = acroForm.GetTextFormField("Address.Address");
                addressField.Value = "98033, 722 Moss Bay Blvd.";

                PdfRadioGroupFormFieldFacade genderField = acroForm.GetRadioGroupFormField("Gender");
                genderField.Value = genderField.Field.Items[0].Value;

                PdfComboBoxFormFieldFacade countryField = acroForm.GetComboBoxFormField("Address.Country");
                countryField.Value = countryField.Items[0].Value;

                PdfCheckBoxFormFieldFacade checkField = acroForm.GetCheckBoxFormField("Check");
                checkField.IsChecked  = true;

                // Save the modified document.
                documentProcessor.SaveDocument(filePath + fileName + "_new.pdf");

                btnFillFormData.Enabled = false;
                btnLoadFilledPDF.Enabled = true;
            }
            #endregion #FillFields
        }

        private void btnLoadFilledPDF_Click(object sender, EventArgs e)
        {

            // Load  a document in the PDF Viewer.
            pdfViewer1.LoadDocument(filePath + fileName + "_new.pdf");
        }
    }
}
