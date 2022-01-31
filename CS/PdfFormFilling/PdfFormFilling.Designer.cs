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
            this.components = new System.ComponentModel.Container();
            this.btnFillFormData = new System.Windows.Forms.Button();
            this.pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.btnGetFieldNames = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnLoadFilledPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFillFormData
            // 
            this.btnFillFormData.Location = new System.Drawing.Point(215, 12);
            this.btnFillFormData.Name = "btnFillFormData";
            this.btnFillFormData.Size = new System.Drawing.Size(186, 55);
            this.btnFillFormData.TabIndex = 0;
            this.btnFillFormData.Text = "Fill Form Data";
            this.btnFillFormData.UseVisualStyleBackColor = true;
            this.btnFillFormData.Click += new System.EventHandler(this.btnFillFormData_Click);
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfViewer1.Location = new System.Drawing.Point(353, 76);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(1025, 673);
            this.pdfViewer1.TabIndex = 1;
            // 
            // btnGetFieldNames
            // 
            this.btnGetFieldNames.Location = new System.Drawing.Point(12, 12);
            this.btnGetFieldNames.Name = "btnGetFieldNames";
            this.btnGetFieldNames.Size = new System.Drawing.Size(186, 55);
            this.btnGetFieldNames.TabIndex = 0;
            this.btnGetFieldNames.Text = "Get Field Names";
            this.btnGetFieldNames.UseVisualStyleBackColor = true;
            this.btnGetFieldNames.Click += new System.EventHandler(this.btnGetFieldNames_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 76);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 408);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // btnLoadFilledPDF
            // 
            this.btnLoadFilledPDF.Enabled = false;
            this.btnLoadFilledPDF.Location = new System.Drawing.Point(420, 12);
            this.btnLoadFilledPDF.Name = "btnLoadFilledPDF";
            this.btnLoadFilledPDF.Size = new System.Drawing.Size(186, 55);
            this.btnLoadFilledPDF.TabIndex = 3;
            this.btnLoadFilledPDF.Text = "Load Filled Form Data PDF";
            this.btnLoadFilledPDF.UseVisualStyleBackColor = true;
            this.btnLoadFilledPDF.Click += new System.EventHandler(this.btnLoadFilledPDF_Click);
            // 
            // InteractiveFormFilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 767);
            this.Controls.Add(this.btnLoadFilledPDF);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.btnGetFieldNames);
            this.Controls.Add(this.btnFillFormData);
            this.Name = "InteractiveFormFilling";
            this.Text = "PDF Form Filling";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFillFormData;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.Button btnGetFieldNames;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnLoadFilledPDF;
    }
}

