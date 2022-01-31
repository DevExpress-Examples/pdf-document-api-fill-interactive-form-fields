using DevExpress.Pdf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InteractiveFormFilling {

    public partial class PdfFormFilling : Form {

        public PdfFormFilling() {
            InitializeComponent();
        }

        string filePath = Application.StartupPath + "\\..\\..\\";
        string fileName = "DocumentToFill";

        private void btnGetFieldNames_Click(object sender, EventArgs e) {
            #region #GetFields
            PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor();
            documentProcessor.LoadDocument(filePath + fileName + ".pdf");

            // Get all fields at a root level.
            PdfFormData formData = documentProcessor.GetFormData();
            IList<string> names = formData.GetFieldNames();

            string[] strings = new string[names.Count];
            names.CopyTo(strings, 0);

            richTextBox1.Lines = strings;
            #endregion #GetFields
        }

        private void btnFillFormData_Click(object sender, EventArgs e) {
            #region #FillFields
            PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor();
            documentProcessor.LoadDocument(filePath + fileName + ".pdf");

            // Get all fields at a root level.
            PdfFormData formData = documentProcessor.GetFormData();
            formData["FirstName"].Value = "First Name";
            formData["LastName"].Value = "Last Name";
            formData["Gender"].Value = "Female";

            // Get all fields contained in the Address field.
            PdfFormData address = formData["Address"];
            address["Country"].Value = "Some Country";
            address["City"].Value = "Some City";
            address["Address"].Value = "Some Address";

            documentProcessor.ApplyFormData(formData);
            documentProcessor.SaveDocument(filePath + fileName + "_new.pdf");

            pdfViewer1.LoadDocument(filePath + fileName + "_new.pdf");
            #endregion #FillFields
        }

    }

}
