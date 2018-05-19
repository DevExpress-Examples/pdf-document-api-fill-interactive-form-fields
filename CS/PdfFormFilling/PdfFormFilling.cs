
using DevExpress.Pdf;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PdfFormFilling {

    public partial class PdfFormFilling : Form {
        string filePath = Application.StartupPath + "\\..\\..\\";
        string fileName = "FieldTypes";

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

                // Specify the value for FirstName and LastName text boxes.
                formData["FirstName"].Value = "Janet";
                formData["LastName"].Value = "Leverling";

                // Specify the value for the Gender radio group.
                formData["Gender"].Value = "Female";

                // Specify the check box checked appearance name.
                formData["Check"].Value = "Yes";

                // Specify values for the Category list box.
                formData["Category"].Value = new string[] { "Entertainment", "Meals", "Morale" };

                // Obtain data from the Address form field and specify values for Address child form fields.
                PdfFormData address = formData["Address"];

                // Specify the value for the Country combo box. 
                address["Country"].Value = "United States";

                // Specify the value for City and Address text boxes. 
                address["City"].Value = "California";
                address["Address"].Value = "20 Maple Avenue";

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
