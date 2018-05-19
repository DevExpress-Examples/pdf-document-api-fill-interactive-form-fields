Imports DevExpress.Pdf
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace PdfFormFilling

    Partial Public Class PdfFormFilling
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private filePath As String = Application.StartupPath & "\..\..\"
        Private fileName As String = "DocumentToFill"

        Private Sub btnGetFieldNames_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGetFieldNames.Click
'            #Region "#GetFields"
            Dim documentProcessor As New PdfDocumentProcessor()
            documentProcessor.LoadDocument(filePath & fileName & ".pdf")

            ' Get all fields at a root level.
            Dim formData As PdfFormData = documentProcessor.GetFormData()
            Dim names As IList(Of String) = formData.GetFieldNames()

            Dim strings(names.Count - 1) As String
            names.CopyTo(strings, 0)

            richTextBox1.Lines = strings
'            #End Region ' #GetFields
        End Sub

        Private Sub btnFillFormData_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFillFormData.Click
'            #Region "#FillFields"
            Dim documentProcessor As New PdfDocumentProcessor()
            documentProcessor.LoadDocument(filePath & fileName & ".pdf")

            ' Get all fields at a root level.
            Dim formData As PdfFormData = documentProcessor.GetFormData()
            formData("FirstName").Value = "First Name"
            formData("LastName").Value = "Last Name"
            formData("Gender").Value = "Female"

            ' Get all fields contained in the Address field.
            Dim address As PdfFormData = formData("Address")
            address("Country").Value = "Some Country"
            address("City").Value = "Some City"
            address("Address").Value = "Some Address"

            documentProcessor.ApplyFormData(formData)
            documentProcessor.SaveDocument(filePath & fileName & "_new.pdf")

            pdfViewer1.LoadDocument(filePath & fileName & "_new.pdf")
'            #End Region ' #FillFields
        End Sub

    End Class

End Namespace
