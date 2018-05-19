Imports DevExpress.Pdf
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace PdfFormFilling

    Partial Public Class PdfFormFilling
        Inherits Form

        Private filePath As String = Application.StartupPath & "\..\..\"
        Private fileName As String = "DocumentToFill"

        Public Sub New()
            InitializeComponent()
            pdfViewer1.LoadDocument(filePath & fileName & ".pdf")
        End Sub

        Private Sub btnGetFieldNames_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGetFieldNames.Click
'            #Region "#GetFields"
            Using documentProcessor As New PdfDocumentProcessor()
                documentProcessor.LoadDocument(filePath & fileName & ".pdf")

                ' Get all fields at a root level.
                Dim formData As PdfFormData = documentProcessor.GetFormData()

                Dim names As IList(Of String) = formData.GetFieldNames()

                Dim strings(names.Count - 1) As String
                names.CopyTo(strings, 0)

                richTextBox1.Lines = strings
            End Using
'            #End Region ' #GetFields
        End Sub

        Private Sub btnFillFormData_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFillFormData.Click
'            #Region "#FillFields"
            Using documentProcessor As New PdfDocumentProcessor()
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
'            #End Region ' #FillFields
        End Sub

        Private Sub btnLoadFilledPDF_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadFilledPDF.Click
            pdfViewer1.LoadDocument(filePath & fileName & "_new.pdf")
        End Sub
    End Class
End Namespace
