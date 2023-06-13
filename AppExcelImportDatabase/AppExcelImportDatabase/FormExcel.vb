Public Class FormExcel
    Private Sub FormExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Structure MyExcelRows
        Dim productcode As String
        Dim productdesc As String
        Dim qty As String
        Dim price As String
    End Structure


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'OpenFileDialog1.FileName = Nothing
        'OpenFileDialog1.Title = "Select an Excel File"
        'OpenFileDialog1.Filter = "Excel File|*.xlsx|Excel File|*.xls"
        'OpenFileDialog1.InitialDirectory = Application.StartupPath
        'If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        '    workbookfile = Me.OpenFileDialog1.FileName
        '    TextBox1.Text = Me.OpenFileDialog1.FileName
        '    Label1.Text = "Searching for items"
        '    ProgressBar1.Value = 0
        '    counter = 0
        '    MyExcelRowList.Clear()
        '    BackgroundWorker1.RunWorkerAsync()
        'Else

        'End If
    End Sub
End Class