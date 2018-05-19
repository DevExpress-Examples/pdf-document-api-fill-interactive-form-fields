
using DevExpress.Pdf;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PdfFormFilling {

    public partial class PdfFormFilling : Form {
        string filePath = Application.StartupPath + "\\..\\..\\";
        string fileName = "DocumentToFill";

        public PdfFormFilling() {
            InitializeComponent();
            pdfViewer1.LoadDocument(filePath + fileName + ".pdf");
        }

        private void btnGetFieldNames_Click(object sender, EventArgs e) {
            #region #GetFields

            // Load a document with an interactive form.
            using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
                documentProcessor.LoadDocument(filePath + fileName + ".pdf");

                // Get names of interactive form fields.
                PdfFormData formData = documentProcessor.GetFormData();
                IList<string> names = formData.GetFieldNames();

                // Show the field names in the rich text box.
                string[] strings = new string[names.Count];
                names.CopyTo(strings, 0);
                richTextBox1.Lines = strings;
            }
            #endregion #GetFields
        }

        private void btnFillFormData_Click(object sender, EventArgs e) {
            #region #FillFields

            // Load a document with an interactive form.
            using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
                documentProcessor.LoadDocument(filePath + fileName + ".pdf");

                // Obtain interactive form data from a document.
                PdfFormData formData = documentProcessor.GetFormData();

                // Specify values for FirstName, LastName and Gender form fields.
                formData["FirstName"].Value = "First Name";
                formData["LastName"].Value = "Last Name";
                formData["Gender"].Value = "Male";


                // Obtain data from the Address form field.
                PdfFormData address = formData["Address"];

                // Specify values for Address child form fields.
                address["Country"].Value = "Some Country";
                address["City"].Value = "Some City";
                address["Address"].Value = "Some Address";

                // Apply data to the interactive form. 
                documentProcessor.ApplyFormData(formData);

                // Save the modified document.
                documentProcessor.SaveDocument(filePath + fileName + "_new.pdf");

                btnFillFormData.Enabled = false;
                btnLoadFilledPDF.Enabled = true;
            }
            #endregion #FillFields
        }

        private void btnLoadFilledPDF_Click(object sender, EventArgs e) {

            // Load  a document in the PDF Viewer.
            pdfViewer1.LoadDocument(filePath + fileName + "_new.pdf");
        }
    }
}
