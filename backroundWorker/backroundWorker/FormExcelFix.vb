Imports System.Threading

Public Class FormExcelFix
    Private Sub FormExcelFix_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBLLOADER.Visible = False
        'BackgroundWorker1.RunWorkerAsync()

        Control.CheckForIllegalCrossThreadCalls = False
    End Sub
    Public Sub LOADDATA(lv As ListView)
        If lv.InvokeRequired Then
            lv.Invoke(Sub() lv.Items.Clear())
        Else
            lv.Items.Clear()
        End If


        'KoneksiKeDatabase()
        ''QUERY = "Select * FROM tbl_coba ORDER BY id"
        'QUERY = "Select * FROM tbl_coba"
        'DA = New MySqlDataAdapter(QUERY, CONN)

        Dim con As OleDb.OleDbConnection

        con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + TXTLOCATION.Text + ";Extended Properties=Excel 12.0;")
        'If filepath.EndsWith(".xls") Then
        '    connstring =
        'End If
        Dim cmd As New OleDb.OleDbDataAdapter("Select * from [" & ComboBox1.Text & "]", con)

        Dim ds As New DataTable
        'DS = New DataSet
        cmd.Fill(ds)
        ListView1.Items.Clear()
        For Each drow As DataRow In ds.Rows
            If lv.InvokeRequired Then
                lv.Invoke(Sub()
                              With ListView1
                                  .Items.Add(drow(0).ToString)
                                  .Items(ListView1.Items.Count - 1).SubItems.Add(drow(1).ToString)
                                  '.Items(ListView1.Items.Count - 1).SubItems.Add(drow(2).ToString)
                                  '.Items(ListView1.Items.Count - 1).SubItems.Add(drow(3).ToString)
                              End With
                          End Sub)
            Else
                With ListView1
                    .Items.Add(drow(0).ToString)
                    .Items(ListView1.Items.Count - 1).SubItems.Add(drow(1).ToString)
                    '.Items(ListView1.Items.Count - 1).SubItems.Add(drow(2).ToString)
                    '.Items(ListView1.Items.Count - 1).SubItems.Add(drow(3).ToString)
                End With
            End If
            Thread.Sleep(500)
        Next
        con.Close()

        If LBLLOADER.InvokeRequired Then
            LBLLOADER.Invoke(Sub()
                                 LBLLOADER.Visible = True
                             End Sub)
        Else
            LBLLOADER.Visible = False

        End If

    End Sub

    Private Sub BTNBROWSE_Click(sender As Object, e As EventArgs) Handles BTNBROWSE.Click
        Dim ofd As New OpenFileDialog
        Dim con As OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim da As New OleDb.OleDbDataAdapter
        'Dim dt As New DataTable

        Try
            With ofd
                .Filter = "Excel Files(*.xlsx)|*.xlsx| All files(*.*)|*.*"
                .FilterIndex = 1
                .Title = "Import data from excel file"
            End With
            If ofd.ShowDialog() = DialogResult.OK Then
                TXTLOCATION.Text = ofd.FileName

                con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + TXTLOCATION.Text + ";Extended Properties=Excel 12.0;")
                con.Open()
                ComboBox1.DataSource = con.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, Nothing)
                ComboBox1.DisplayMember = "Table_Name"
                ComboBox1.ValueMember = "Table_Name"

                'With cmd
                '    .Connection = con
                '    .CommandText = "SELECT * FROM [Sheet1$]"
                'End With
                'da.SelectCommand = cmd
                'da.Fill(dt)
                'DataGridView1.DataSource = dt
                con.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        LOADDATA(ListView1)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MessageBox.Show("Sucessfully imported", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProgressBar1.Visible = True

            ProgressBar1.Value = 0
        Else
            ProgressBar1.Value += 1
        End If
    End Sub
End Class