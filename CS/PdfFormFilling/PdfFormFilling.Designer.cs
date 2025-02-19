namespace InteractiveFormFilling
{
    partial class PdfFormFilling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnFillFormData = new System.Windows.Forms.Button();
            pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            btnGetFieldNames = new System.Windows.Forms.Button();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            btnLoadFilledPDF = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnFillFormData
            // 
            btnFillFormData.Location = new System.Drawing.Point(466, 30);
            btnFillFormData.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            btnFillFormData.Name = "btnFillFormData";
            btnFillFormData.Size = new System.Drawing.Size(403, 135);
            btnFillFormData.TabIndex = 0;
            btnFillFormData.Text = "Fill Interactive Form";
            btnFillFormData.UseVisualStyleBackColor = true;
            btnFillFormData.Click += btnFillFormData_Click;
            // 
            // pdfViewer1
            // 
            pdfViewer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pdfViewer1.Location = new System.Drawing.Point(765, 187);
            pdfViewer1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            pdfViewer1.Name = "pdfViewer1";
            pdfViewer1.Size = new System.Drawing.Size(2221, 1657);
            pdfViewer1.TabIndex = 1;
            // 
            // btnGetFieldNames
            // 
            btnGetFieldNames.Location = new System.Drawing.Point(26, 30);
            btnGetFieldNames.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            btnGetFieldNames.Name = "btnGetFieldNames";
            btnGetFieldNames.Size = new System.Drawing.Size(403, 135);
            btnGetFieldNames.TabIndex = 0;
            btnGetFieldNames.Text = "Get Form Field Names";
            btnGetFieldNames.UseVisualStyleBackColor = true;
            btnGetFieldNames.Click += btnGetFieldNames_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(26, 187);
            richTextBox1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(693, 998);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // btnLoadFilledPDF
            // 
            btnLoadFilledPDF.Enabled = false;
            btnLoadFilledPDF.Location = new System.Drawing.Point(910, 30);
            btnLoadFilledPDF.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            btnLoadFilledPDF.Name = "btnLoadFilledPDF";
            btnLoadFilledPDF.Size = new System.Drawing.Size(403, 135);
            btnLoadFilledPDF.TabIndex = 3;
            btnLoadFilledPDF.Text = "Load Filled PDF";
            btnLoadFilledPDF.UseVisualStyleBackColor = true;
            btnLoadFilledPDF.Click += btnLoadFilledPDF_Click;
            // 
            // PdfFormFilling
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(3012, 1888);
            Controls.Add(btnLoadFilledPDF);
            Controls.Add(richTextBox1);
            Controls.Add(pdfViewer1);
            Controls.Add(btnGetFieldNames);
            Controls.Add(btnFillFormData);
            Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            Name = "PdfFormFilling";
            Text = "PDF Form Filling";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnFillFormData;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.Button btnGetFieldNames;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnLoadFilledPDF;
    }
}

