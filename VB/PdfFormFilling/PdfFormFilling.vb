Imports DevExpress.Pdf
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace InteractiveFormFilling

    Public Partial Class PdfFormFilling
        Inherits Form

        Private filePath As String = Application.StartupPath & "\..\..\"

        Private fileName As String = "DocumentToFill"

        Public Sub New()
            InitializeComponent()
            pdfViewer1.LoadDocument(filePath & fileName & ".pdf")
        End Sub

        Private Sub btnGetFieldNames_Click(ByVal sender As Object, ByVal e As EventArgs)
#Region "#GetFields"
            Using documentProcessor As PdfDocumentProcessor = New PdfDocumentProcessor()
                documentProcessor.LoadDocument(filePath & fileName & ".pdf")
                ' Get all fields at a root level.
                Dim formData As PdfFormData = documentProcessor.GetFormData()
                Dim names As IList(Of String) = formData.GetFieldNames()
                Dim strings As String() = New String(names.Count - 1) {}
                names.CopyTo(strings, 0)
                richTextBox1.Lines = strings
            End Using
#End Region  ' #GetFields
        End Sub

        Private Sub btnFillFormData_Click(ByVal sender As Object, ByVal e As EventArgs)
#Region "#FillFields"
            Using documentProcessor As PdfDocumentProcessor = New PdfDocumentProcessor()
                documentProcessor.LoadDocument(filePath & fileName & ".pdf")
                ' Get all fields at a root level.
                Dim formData As PdfFormData = documentProcessor.GetFormData()
                formData("FirstName").Value = "First Name"
                formData("LastName").Value = "Last Name"
                formData("Gender").Value = "Male"
                ' Get all fields contained in the Address field.
                Dim address As PdfFormData = formData("Address")
                address("Country").Value = "Some Country"
                address("City").Value = "Some City"
                address("Address").Value = "Some Address"
                documentProcessor.ApplyFormData(formData)
                documentProcessor.SaveDocument(filePath & fileName & "_new.pdf")
                btnFillFormData.Enabled = False
                btnLoadFilledPDF.Enabled = True
            End Using
#End Region  ' #FillFields
        End Sub

        Private Sub btnLoadFilledPDF_Click(ByVal sender As Object, ByVal e As EventArgs)
            pdfViewer1.LoadDocument(filePath & fileName & "_new.pdf")
        End Sub
    End Class
End Namespace
