Namespace InteractiveFormFilling

    Partial Class PdfFormFilling

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.btnFillFormData = New System.Windows.Forms.Button()
            Me.pdfViewer1 = New DevExpress.XtraPdfViewer.PdfViewer()
            Me.btnGetFieldNames = New System.Windows.Forms.Button()
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
            Me.btnLoadFilledPDF = New System.Windows.Forms.Button()
            SuspendLayout()
            ' 
            ' btnFillFormData
            ' 
            Me.btnFillFormData.Location = New System.Drawing.Point(466, 30)
            Me.btnFillFormData.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
            Me.btnFillFormData.Name = "btnFillFormData"
            Me.btnFillFormData.Size = New System.Drawing.Size(403, 135)
            Me.btnFillFormData.TabIndex = 0
            Me.btnFillFormData.Text = "Fill Interactive Form"
            Me.btnFillFormData.UseVisualStyleBackColor = True
            Me.btnFillFormData.Click += AddressOf btnFillFormData_Click
            ' 
            ' pdfViewer1
            ' 
            Me.pdfViewer1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.pdfViewer1.Location = New System.Drawing.Point(765, 187)
            Me.pdfViewer1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
            Me.pdfViewer1.Name = "pdfViewer1"
            Me.pdfViewer1.Size = New System.Drawing.Size(2221, 1657)
            Me.pdfViewer1.TabIndex = 1
            ' 
            ' btnGetFieldNames
            ' 
            Me.btnGetFieldNames.Location = New System.Drawing.Point(26, 30)
            Me.btnGetFieldNames.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
            Me.btnGetFieldNames.Name = "btnGetFieldNames"
            Me.btnGetFieldNames.Size = New System.Drawing.Size(403, 135)
            Me.btnGetFieldNames.TabIndex = 0
            Me.btnGetFieldNames.Text = "Get Form Field Names"
            Me.btnGetFieldNames.UseVisualStyleBackColor = True
            Me.btnGetFieldNames.Click += AddressOf btnGetFieldNames_Click
            ' 
            ' richTextBox1
            ' 
            Me.richTextBox1.Location = New System.Drawing.Point(26, 187)
            Me.richTextBox1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.Size = New System.Drawing.Size(693, 998)
            Me.richTextBox1.TabIndex = 2
            Me.richTextBox1.Text = ""
            ' 
            ' btnLoadFilledPDF
            ' 
            Me.btnLoadFilledPDF.Enabled = False
            Me.btnLoadFilledPDF.Location = New System.Drawing.Point(910, 30)
            Me.btnLoadFilledPDF.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
            Me.btnLoadFilledPDF.Name = "btnLoadFilledPDF"
            Me.btnLoadFilledPDF.Size = New System.Drawing.Size(403, 135)
            Me.btnLoadFilledPDF.TabIndex = 3
            Me.btnLoadFilledPDF.Text = "Load Filled PDF"
            Me.btnLoadFilledPDF.UseVisualStyleBackColor = True
            Me.btnLoadFilledPDF.Click += AddressOf btnLoadFilledPDF_Click
            ' 
            ' PdfFormFilling
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(13F, 32F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New System.Drawing.Size(3012, 1888)
            Controls.Add(Me.btnLoadFilledPDF)
            Controls.Add(Me.richTextBox1)
            Controls.Add(Me.pdfViewer1)
            Controls.Add(Me.btnGetFieldNames)
            Controls.Add(Me.btnFillFormData)
            Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
            Name = "PdfFormFilling"
            Me.Text = "PDF Form Filling"
            ResumeLayout(False)
        End Sub

#End Region
        Private btnFillFormData As System.Windows.Forms.Button

        Private pdfViewer1 As DevExpress.XtraPdfViewer.PdfViewer

        Private btnGetFieldNames As System.Windows.Forms.Button

        Private richTextBox1 As System.Windows.Forms.RichTextBox

        Private btnLoadFilledPDF As System.Windows.Forms.Button
    End Class
End Namespace
