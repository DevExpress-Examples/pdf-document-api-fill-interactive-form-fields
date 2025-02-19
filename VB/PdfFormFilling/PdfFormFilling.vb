Imports DevExpress.Pdf
Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic

Namespace InteractiveFormFilling

	Partial Public Class PdfFormFilling
		Inherits XtraForm

		Private filePath As String = AppContext.BaseDirectory
		Private fileName As String = "FieldTypes"

		Public Sub New()
			InitializeComponent()
			pdfViewer1.LoadDocument(filePath & fileName & ".pdf")
		End Sub

		Private Sub btnGetFieldNames_Click(ByVal sender As Object, ByVal e As EventArgs)
			'			#Region "#GetFields"

			' Load a document with an interactive form.
			Using documentProcessor As New PdfDocumentProcessor()
				documentProcessor.LoadDocument(filePath & fileName & ".pdf")

				' Get names of interactive form fields.
				Dim names As IList(Of String) = documentProcessor.GetFormFieldNames()

				' Show the field names in the rich text box.
				Dim strings(names.Count - 1) As String
				names.CopyTo(strings, 0)
				richTextBox1.Lines = strings
			End Using
			'			#End Region ' #GetFields
		End Sub

		Private Sub btnFillFormData_Click(ByVal sender As Object, ByVal e As EventArgs)
			'			#Region "#FillFields"

			' Load a document with an interactive form.
			Using documentProcessor As New PdfDocumentProcessor()
				documentProcessor.LoadDocument(filePath & fileName & ".pdf")

				Dim documentFacade As PdfDocumentFacade = documentProcessor.DocumentFacade
				Dim acroForm As PdfAcroFormFacade = documentFacade.AcroForm

				Dim nameField As PdfTextFormFieldFacade = acroForm.GetTextFormField("FirstName")
				nameField.Value = "Janet"

				Dim surnameField As PdfTextFormFieldFacade = acroForm.GetTextFormField("LastName")
				surnameField.Value = "Leverling"

				Dim categoryField As PdfListBoxFormFieldFacade = acroForm.GetListBoxFormField("Category")
				categoryField.Values = New List(Of String)() From {"Entertainment", "Meals", "Morale"}

				Dim addressField As PdfTextFormFieldFacade = acroForm.GetTextFormField("Address.Address")
				addressField.Value = "98033, 722 Moss Bay Blvd."

				Dim genderField As PdfRadioGroupFormFieldFacade = acroForm.GetRadioGroupFormField("Gender")
				genderField.Value = genderField.Field.Items(0).Value

				Dim countryField As PdfComboBoxFormFieldFacade = acroForm.GetComboBoxFormField("Address.Country")
				countryField.Value = countryField.Items(0).Value

				Dim checkField As PdfCheckBoxFormFieldFacade = acroForm.GetCheckBoxFormField("Check")
				checkField.IsChecked = True

				' Save the modified document.
				documentProcessor.SaveDocument(filePath & fileName & "_new.pdf")

				btnFillFormData.Enabled = False
				btnLoadFilledPDF.Enabled = True
			End Using
			'			#End Region ' #FillFields
		End Sub

		Private Sub btnLoadFilledPDF_Click(ByVal sender As Object, ByVal e As EventArgs)

			' Load  a document in the PDF Viewer.
			pdfViewer1.LoadDocument(filePath & fileName & "_new.pdf")
		End Sub
	End Class
End Namespace
