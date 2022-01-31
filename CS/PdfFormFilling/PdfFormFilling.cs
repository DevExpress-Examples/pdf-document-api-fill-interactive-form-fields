using DevExpress.Pdf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InteractiveFormFilling {

    public partial class PdfFormFilling : Form {
        string filePath = Application.StartupPath + "\\..\\..\\";
        string fileName = "DocumentToFill";

        public PdfFormFilling() {
            InitializeComponent();
            pdfViewer1.LoadDocument(filePath + fileName + ".pdf");
        }

        private void btnGetFieldNames_Click(object sender, EventArgs e) {
            #region #GetFields
            using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
                documentProcessor.LoadDocument(filePath + fileName + ".pdf");

                // Get all fields at a root level.
                PdfFormData formData = documentProcessor.GetFormData();

                IList<string> names = formData.GetFieldNames();

                string[] strings = new string[names.Count];
                names.CopyTo(strings, 0);

                richTextBox1.Lines = strings;
            }
            #endregion #GetFields
        }

        private void btnFillFormData_Click(object sender, EventArgs e) {
            #region #FillFields
            using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
                documentProcessor.LoadDocument(filePath + fileName + ".pdf");

                // Get all fields at a root level.
                PdfFormData formData = documentProcessor.GetFormData();
                formData["FirstName"].Value = "First Name";
                formData["LastName"].Value = "Last Name";
                formData["Gender"].Value = "Male";

                // Get all fields contained in the Address field.
                PdfFormData address = formData["Address"];
                address["Country"].Value = "Some Country";
                address["City"].Value = "Some City";
                address["Address"].Value = "Some Address";

                documentProcessor.ApplyFormData(formData);
                documentProcessor.SaveDocument(filePath + fileName + "_new.pdf");

                btnFillFormData.Enabled = false;
                btnLoadFilledPDF.Enabled = true;
            }
            #endregion #FillFields
        }

        private void btnLoadFilledPDF_Click(object sender, EventArgs e) {
            pdfViewer1.LoadDocument(filePath + fileName + "_new.pdf");
        }
    }
}
