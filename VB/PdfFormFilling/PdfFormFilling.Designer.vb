Namespace PdfFormFilling

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

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.btnFillFormData = New System.Windows.Forms.Button()
            Me.pdfViewer1 = New DevExpress.XtraPdfViewer.PdfViewer()
            Me.btnGetFieldNames = New System.Windows.Forms.Button()
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
            Me.SuspendLayout()
            ' 
            ' btnFillFormData
            ' 
            Me.btnFillFormData.Location = New System.Drawing.Point(353, 15)
            Me.btnFillFormData.Name = "btnFillFormData"
            Me.btnFillFormData.Size = New System.Drawing.Size(186, 55)
            Me.btnFillFormData.TabIndex = 0
            Me.btnFillFormData.Text = "Fill Form Data"
            Me.btnFillFormData.UseVisualStyleBackColor = True
            AddHandler Me.btnFillFormData.Click, New System.EventHandler(AddressOf Me.btnFillFormData_Click)
            ' 
            ' pdfViewer1
            ' 
            Me.pdfViewer1.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.pdfViewer1.Location = New System.Drawing.Point(353, 76)
            Me.pdfViewer1.Name = "pdfViewer1"
            Me.pdfViewer1.Size = New System.Drawing.Size(1025, 673)
            Me.pdfViewer1.TabIndex = 1
            ' 
            ' btnGetFieldNames
            ' 
            Me.btnGetFieldNames.Location = New System.Drawing.Point(12, 12)
            Me.btnGetFieldNames.Name = "btnGetFieldNames"
            Me.btnGetFieldNames.Size = New System.Drawing.Size(186, 55)
            Me.btnGetFieldNames.TabIndex = 0
            Me.btnGetFieldNames.Text = "Get Field Names"
            Me.btnGetFieldNames.UseVisualStyleBackColor = True
            AddHandler Me.btnGetFieldNames.Click, New System.EventHandler(AddressOf Me.btnGetFieldNames_Click)
            ' 
            ' richTextBox1
            ' 
            Me.richTextBox1.Location = New System.Drawing.Point(12, 76)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.Size = New System.Drawing.Size(322, 408)
            Me.richTextBox1.TabIndex = 2
            Me.richTextBox1.Text = ""
            ' 
            ' PdfFormFilling
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1390, 767)
            Me.Controls.Add(Me.richTextBox1)
            Me.Controls.Add(Me.pdfViewer1)
            Me.Controls.Add(Me.btnGetFieldNames)
            Me.Controls.Add(Me.btnFillFormData)
            Me.Name = "PdfFormFilling"
            Me.Text = "PDF Form Filling"
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private btnFillFormData As System.Windows.Forms.Button

        Private pdfViewer1 As DevExpress.XtraPdfViewer.PdfViewer

        Private btnGetFieldNames As System.Windows.Forms.Button

        Private richTextBox1 As System.Windows.Forms.RichTextBox
    End Class
End Namespace
