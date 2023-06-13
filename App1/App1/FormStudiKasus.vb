Imports System.Linq
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml
Imports MySql.Data.MySqlClient

Public Class FormStudiKasus

    Private Sub kondisiawal()
        Try

            KoneksiKeDatabase()
            QUERY = "Select * FROM amt order by id"
            DA = New MySqlDataAdapter(QUERY, CONN)
            DS = New DataSet
            DA.Fill(DS, "amt")
            DataGridView1.DataSource = DS.Tables("amt")

            With DataGridView1
                '    '.Columns(0).Width = 200
                '    .Columns(1).Width = 200
                '    .Columns(2).Width = 80
                '    .Columns(3).Width = 100
                '    .Columns(4).Width = 100
                '    .Columns(5).Width = 100
                '    .Columns(6).Width = 90
                '    .Columns(7).Width = 90
                '    .Columns(8).Width = 120

                '.Columns(0).DataPropertyName = "id"
                '.Columns(1).DataPropertyName = "nama_perusahaan"
                '.Columns(2).DataPropertyName = "no_plat_mobil"
                '.Columns(3).DataPropertyName = "mobil_tangki"
                '.Columns(4).DataPropertyName = "id_kompartemen1"
                '.Columns(5).DataPropertyName = "id_kompartemen2"
                '.Columns(6).DataPropertyName = "jrk_m_hole1"
                '.Columns(7).DataPropertyName = "jrk_m_hole2"
                '.Columns(8).DataPropertyName = "tgl_jam_ukur"


                .Columns(0).Visible = False

                .Columns(1).HeaderText = "No Urut"
                .Columns(2).HeaderText = "No. RFID"
                .Columns(3).HeaderText = "NOPOL"
                .Columns(4).HeaderText = "Perusahaan"
                .Columns(5).HeaderText = "Lokasi"
                .Columns(6).HeaderText = "NIK AMT"
                .Columns(7).HeaderText = "Nama AMT"
                .Columns(8).HeaderText = "Tempat Lahir"
                .Columns(9).HeaderText = "Tanggal Lahir"
                .Columns(10).HeaderText = "USIA"
                .Columns(11).HeaderText = "NIK AMT"
                .Columns(12).HeaderText = "Nama AMT"
                .Columns(13).HeaderText = "Tempat Lahir"
                .Columns(14).HeaderText = "Tanggal Lahir"
                .Columns(15).HeaderText = "USIA"
                .Columns(16).HeaderText = "NIK AMT"
                .Columns(17).HeaderText = "Nama AMT"
                .Columns(18).HeaderText = "Tempat Lahir"
                .Columns(19).HeaderText = "Tanggal Lahir"
                .Columns(20).HeaderText = "USIA"
                .Columns(21).HeaderText = "Transportir"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub FormStudiKasus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        KoneksiKeDatabase()
        kondisiawal()
    End Sub
    Private Sub TextBoxNumberOfRows_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNumberOfRows.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = "+") Then
            MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If
    End Sub

    Private Sub ButtonCreateData_Click(sender As Object, e As EventArgs) Handles ButtonCreateData.Click
        If TextBoxNumberOfRows.Text = "" Then
            MessageBox.Show("Number of Row cannot be empty !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ButtonCreateData.Text = "Please Wait..."
        ButtonCreateData.Enabled = False

        For i As Integer = 1 To TextBoxNumberOfRows.Text
            With DataGridView1.Rows
                .Add(i, "User " & i, "Indonesia", "Medan", "061-", "062-", "063-", "064-" & i)
            End With
        Next

        ButtonCreateData.Text = "Make Data"
        ButtonCreateData.Enabled = True
    End Sub

    Private Sub ButtonExportToExcel_Click(sender As Object, e As EventArgs) Handles ButtonExportToExcel.Click
        Try
            ButtonExportToExcel.Text = "Please Wait..."
            ButtonExportToExcel.Enabled = False

            SaveFileDialog1.Filter = "Excel Document (*.xlsx)|*.xlsx"
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim xlApp As Microsoft.Office.Interop.Excel.Application
                Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
                Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misValue As Object = System.Reflection.Missing.Value
                Dim i As Integer
                Dim j As Integer

                xlApp = New Microsoft.Office.Interop.Excel.Application
                'xlApp.Workbooks.Open()
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlWorkBook.Sheets("sheet1")

                For i = 0 To DataGridView1.RowCount - 2
                    For j = 0 To DataGridView1.ColumnCount - 1
                        For k As Integer = 1 To DataGridView1.Columns.Count
                            xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                            xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                        Next
                    Next
                Next

                xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
                xlWorkBook.Close()
                xlApp.Quit()

                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)

                MsgBox("Successfully saved" & vbCrLf & "File are saved at : " & SaveFileDialog1.FileName, MsgBoxStyle.Information, "Information")

                ButtonExportToExcel.Text = "Export To MS Excel"
                ButtonExportToExcel.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Buka File excel Failed to save !!!" & vbCrLf & ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MessageBox.Show("Failed to save !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub ButtonClearDGV_Click(sender As Object, e As EventArgs) Handles ButtonClearDGV.Click
        DataGridView1.Columns.Clear()
        If DataGridView1.Columns.Count = 0 Then
            With DataGridView1
                .Columns.Clear()
                .Columns.Add("No", "No")
                .Columns.Add("Name_User", "Name_User")
                .Columns.Add("Country", "Country")
                .Columns.Add("City", "City")
                .Columns.Add("Phone_Number", "Phone_Number")
                .Columns.Add("Phone_Number2", "Phone_Number2")
                .Columns.Add("Phone_Number3", "Phone_Number3")
                .Columns.Add("Phone_Number4", "Phone_Number4")
            End With
        End If
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub ButtonImportFromExcel_Click(sender As Object, e As EventArgs) Handles ButtonImportFromExcel.Click
        Dim conn As OleDbConnection
        'Dim dtr As OleDbDataReader
        Dim dta As OleDbDataAdapter
        'Dim cmd As OleDbCommand
        Dim dts As DataSet
        Dim excel As String
        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"

        If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            DataGridView1.Columns.Clear()

            Dim fi As New FileInfo(OpenFileDialog1.FileName)
            Dim FileName As String = OpenFileDialog1.FileName

            excel = fi.FullName
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
            dta = New OleDbDataAdapter("Select * From [Sheet1$]", conn)
            dts = New DataSet
            dta.Fill(dts, "[Sheet1$]")
            DataGridView1.DataSource = dts
            DataGridView1.DataMember = "[Sheet1$]"
            conn.Close()
        End If
    End Sub
End Class