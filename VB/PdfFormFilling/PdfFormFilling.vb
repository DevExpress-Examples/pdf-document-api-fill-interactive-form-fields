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
            ' Load a document with an interactive form.
            Using documentProcessor As PdfDocumentProcessor = New PdfDocumentProcessor()
                documentProcessor.LoadDocument(filePath & fileName & ".pdf")
                ' Get names of interactive form fields.
                Dim formData As PdfFormData = documentProcessor.GetFormData()
                Dim names As IList(Of String) = formData.GetFieldNames()
                ' Show the field names in the rich text box.
                Dim strings As String() = New String(names.Count - 1) {}
                names.CopyTo(strings, 0)
                richTextBox1.Lines = strings
            End Using
#End Region  ' #GetFields
        End Sub

        Private Sub btnFillFormData_Click(ByVal sender As Object, ByVal e As EventArgs)
#Region "#FillFields"
            ' Load a document with an interactive form.
            Using documentProcessor As PdfDocumentProcessor = New PdfDocumentProcessor()
                documentProcessor.LoadDocument(filePath & fileName & ".pdf")
                ' Obtain interactive form data from a document.
                Dim formData As PdfFormData = documentProcessor.GetFormData()
                ' Specify values for FirstName, LastName and Gender form fields.
                formData("FirstName").Value = "First Name"
                formData("LastName").Value = "Last Name"
                formData("Gender").Value = "Male"
                ' Obtain data from the Address form field.
                Dim address As PdfFormData = formData("Address")
                ' Specify values for Address child form fields.
                address("Country").Value = "Some Country"
                address("City").Value = "Some City"
                address("Address").Value = "Some Address"
                ' Apply data to the interactive form. 
                documentProcessor.ApplyFormData(formData)
                ' Save the modified document.
                documentProcessor.SaveDocument(filePath & fileName & "_new.pdf")
                btnFillFormData.Enabled = False
                btnLoadFilledPDF.Enabled = True
            End Using
#End Region  ' #FillFields
        End Sub

        Private Sub btnLoadFilledPDF_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Load  a document in the PDF Viewer.
            pdfViewer1.LoadDocument(filePath & fileName & "_new.pdf")
        End Sub
    End Class
End Namespace
