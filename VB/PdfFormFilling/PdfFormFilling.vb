Imports DevExpress.Pdf
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace InteractiveFormFilling

    Public Partial Class PdfFormFilling
        Inherits Form

        Private filePath As String = Application.StartupPath & "\..\..\"

        Private fileName As String = "FieldTypes"

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
                ' Specify the value for FirstName and LastName text boxes.
                formData("FirstName").Value = "Janet"
                formData("LastName").Value = "Leverling"
                ' Specify the value for the Gender radio group.
                formData("Gender").Value = "Female"
                ' Specify the check box checked appearance name.
                formData("Check").Value = "Yes"
                ' Specify values for the Category list box.
                formData("Category").Value = New String() {"Entertainment", "Meals", "Morale"}
                ' Obtain data from the Address form field and specify values for Address child form fields.
                Dim address As PdfFormData = formData("Address")
                ' Specify the value for the Country combo box. 
                address("Country").Value = "United States"
                ' Specify the value for City and Address text boxes. 
                address("City").Value = "California"
                address("Address").Value = "20 Maple Avenue"
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
