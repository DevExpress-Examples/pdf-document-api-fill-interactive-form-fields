Imports System.Linq
Imports System.Threading.Tasks

Namespace InteractiveFormFilling

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New PdfFormFilling())
        End Sub
    End Module
End Namespace
