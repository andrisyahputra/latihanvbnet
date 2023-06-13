Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Imports System.Threading
Public Class Form1
    Dim workbookfile As String
    Dim counter As Integer = 0
    Private MyExcelRowList As List(Of MyExcelRows) = New List(Of MyExcelRows)

    Private Sub posisilist()
        With ListView1.Columns
            .Add("No. Urute", 100)
            .Add("KODE RFID", 100)
            .Add("Nomor Polisi", 100)
            .Add("KETERANGAN BLOKIR", 100)
            .Add("Title", 100)
            .Add("Nama Perusahaan", 100)
            .Add("Status", 100)
            .Add("Merk / Type", 100)
            .Add("Model", 100)
            .Add("Thn Pembuatan", 100)
            .Add("Kapasitas", 100)
            .Add("Kompartemen", 100)
            .Add("Produk", 100)
            .Add("Nomor Mesin", 100)
            .Add("Nomor Rangka", 100)
            .Add("Hasil Uji Emisi %", 100)
            .Add("Pas Masuk", 100)
            .Add("STNK", 100)
            .Add("KEUR", 100)
            .Add("TERA", 100)
            .Add("IJIN BARANG KHUSUS", 100)
            .Add("SKT", 100)
            .Add("No Pas", 100)
            .Add("STATUS", 100)
            .Add("keterangan", 100)
            .Add("TANGGAL PENERIMAAN", 100)
            .Add("NOMOR SURAT TERA", 100)
            .Add("T1", 100)
            .Add("T2", 100)
            .Add("T3", 100)
            .Add("Ruang kosong(ltr)", 100)
            .Add("Kl (mm/ltr)", 100)
            .Add("T1", 100)
            .Add("T2", 100)
            .Add("T3", 100)
            .Add("Ruang kosong(ltr)", 100)
            .Add("Kl (mm/ltr)", 100)
            .Add("TERA", 100)
            .Add("Th. Pembuatan", 100)
            .Add("No. STNK", 100)
            .Add("Masa Berlaku STNK", 100)
            .Add("No. Keur", 100)
            .Add("Masa Berlaku Kier", 100)
            .Add("No. Dok. Uji Emisi", 100)
            .Add("Hasil Uji Emisi", 100)
            .Add("Masa Berlaku Uji Emisi", 100)
            .Add("No. SPB/SKT", 100)
            .Add("Masa Berlaku SPB/SKT", 100)
            .Add("No. Izin Prinsip Masuk Terminal BBM", 100)
            .Add("No. Izin Masuk", 100)
            .Add("Kode Area", 100)
            .Add("Area", 100)
            .Add("Kode Lokasi", 100)
            .Add("Lokasi", 100)
            .Add("Kode Kategori", 100)
            .Add("Kategori", 100)
            .Add("DELIVERY POINT", 100)
            .Add("SEWA", 100)
            .Add("TARIF", 100)
            .Add("AGEN", 100)
            .Add("INDUSTRI", 100)
            .Add("ANGKUTAN SENDIRI", 100)
            .Add("UMUR", 100)
            .Add("KAT", 100)
            .Add("PRODUK", 100)
            .Add("(ENGKEL/TRONTON/SEMI TRAILER)", 100)
            .Add("PABRIKAN TANGKI", 100)
            .Add("MATERIAL TANGKI", 100)
            .Add("MS/CARBON/AL", 100)
            .Add("PEMBUATAN TANGKI TGL/BLN/TH", 100)
            .Add("STATUS ARMADA", 100)
            .Add("Plat", 100)
            .Add("ASURANSI", 100)
            .Add("ALAMAT", 100)
            .Add("TELEPON", 100)
            .Add("EMAIL", 100)
            .Add("NPWP", 100)
            .Add("PENANGGUNG JAWAB", 100)
            .Add("JABATAN", 100)
            .Add("Data Umur MT", 100)

        End With
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBLLOADER.Visible = True
        BackgroundWorker2.RunWorkerAsync()

        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Structure MyExcelRows
        Dim productcode As String
        Dim productdesc As String
        Dim qty As String
        Dim price As String

        Dim column1 As String
        Dim column2 As String
        Dim column3 As String
        Dim column4 As String
        Dim column5 As String
        Dim column6 As String
        Dim column7 As String
        Dim column8 As String
        Dim column9 As String
        Dim column10 As String
        Dim column11 As String
        Dim column12 As String
        Dim column13 As String
        Dim column14 As String
        Dim column15 As String
        Dim column16 As String
        Dim column17 As String
        Dim column18 As String
        Dim column19 As String
        Dim column20 As String
        Dim column21 As String
        Dim column22 As String
        Dim column23 As String
        Dim column24 As String
        Dim column25 As String
        Dim column26 As String
    End Structure


    Public Sub LOADDATA(lv As ListView)
        If lv.InvokeRequired Then
            lv.Invoke(Sub() lv.Items.Clear())
        Else
            lv.Items.Clear()
        End If


        KoneksiKeDatabase()
        'QUERY = "Select * FROM tbl_coba ORDER BY id"
        QUERY = "Select * FROM tbl_coba"
        DA = New MySqlDataAdapter(QUERY, CONN)
        Dim dt As New DataTable
        'DS = New DataSet
        DA.Fill(dt)
        ListView1.Items.Clear()
        For Each drow As DataRow In dt.Rows

            If lv.InvokeRequired Then
                lv.Invoke(Sub()
                              With ListView1
                                  .Items.Add(drow(0).ToString)
                                  .Items(ListView1.Items.Count - 1).SubItems.Add(drow(1).ToString)
                                  .Items(ListView1.Items.Count - 1).SubItems.Add(drow(2).ToString)
                                  .Items(ListView1.Items.Count - 1).SubItems.Add(drow(3).ToString)
                              End With
                          End Sub)
            Else
                With ListView1
                    .Items.Add(drow(0).ToString)
                    .Items(ListView1.Items.Count - 1).SubItems.Add(drow(1).ToString)
                    .Items(ListView1.Items.Count - 1).SubItems.Add(drow(2).ToString)
                    .Items(ListView1.Items.Count - 1).SubItems.Add(drow(3).ToString)
                End With
            End If
            Thread.Sleep(500)
        Next
        CONN.Close()

        If LBLLOADER.InvokeRequired Then
            LBLLOADER.Invoke(Sub()
                                 LBLLOADER.Visible = False
                             End Sub)
        Else
            LBLLOADER.Visible = False

        End If

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lokasifile As String
        OpenFileDialog1.FileName = Nothing
        OpenFileDialog1.Title = "Select an Excel File"
        OpenFileDialog1.Filter = "Excel File|*.xlsx|Excel File|*.xls"
        OpenFileDialog1.InitialDirectory = Application.StartupPath
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            workbookfile = Me.OpenFileDialog1.FileName
            TextBox1.Text = Me.OpenFileDialog1.FileName
            lokasifile = Me.OpenFileDialog1.FileName
            Label1.Text = "Searching for items"
            ProgressBar1.Value = 0
            counter = 0
            MyExcelRowList.Clear()
            BackgroundWorker1.RunWorkerAsync()
        Else

        End If
    End Sub

    Private Function GetExcelData() As Boolean
        Dim Data_IsCopied As Boolean = False
        Dim ps As Process
        Dim p As Process()

        p = Process.GetProcessesByName("EXCEL")
        If p.Length > 0 Then
            For Each ps In p
                ps.Kill()
            Next
        Else

        End If


        'open workbook
        Dim ThisExcelFile As New Excel.Application

        ThisExcelFile.Workbooks.Open(workbookfile)

        'extract data
        ThisExcelFile.Sheets("mt").activate()
        'ThisExcelFile.Sheets("sheet1").activate()
        ThisExcelFile.Range("A3").Activate()
        'I start extracting rows
        Dim CurrentRow As New MyExcelRows
        'If Len(wks.Cells(1, "A").Value) = 0 Then Exit Sub 
        Do
            If ThisExcelFile.ActiveCell.Value > Nothing Or ThisExcelFile.ActiveCell.Text > Nothing Then

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.productcode = ThisExcelFile.ActiveCell.Value         'Productcode 
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.productcode = "n/a"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If


                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.productdesc = ThisExcelFile.ActiveCell.Value         'productdesc
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.productdesc = "n/a"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If


                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.qty = ThisExcelFile.ActiveCell.Value             'qty
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.qty = "0"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If


                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.price = ThisExcelFile.ActiveCell.Value                 'Price
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.price = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column1 = ThisExcelFile.ActiveCell.Value                 'clumn1
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column1 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column2 = ThisExcelFile.ActiveCell.Value                 'column2
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column2 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column3 = ThisExcelFile.ActiveCell.Value                 'column2
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column3 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column4 = ThisExcelFile.ActiveCell.Value                 'column2
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column4 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column5 = ThisExcelFile.ActiveCell.Value                 'column2
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column5 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column6 = ThisExcelFile.ActiveCell.Value                 'column2
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column6 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column7 = ThisExcelFile.ActiveCell.Value                 'column2
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column7 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column8 = ThisExcelFile.ActiveCell.Value                 'column2
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column8 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column9 = ThisExcelFile.ActiveCell.Value                 'column2
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column9 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column10 = ThisExcelFile.ActiveCell.Value                 'column2
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column10 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column11 = ThisExcelFile.ActiveCell.Value                 'column2
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column11 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column12 = ThisExcelFile.ActiveCell.Value                 'column2
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column12 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column13 = ThisExcelFile.ActiveCell.Value                 'column2
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column13 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column14 = ThisExcelFile.ActiveCell.Value                 'column2
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column14 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column15 = ThisExcelFile.ActiveCell.Value                 'column2
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column15 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If



                MyExcelRowList.Add(CurrentRow)                                  'add above row to my list
                ThisExcelFile.ActiveCell.Offset(1, -19).Activate()              'move to the next row
            Else
                Data_IsCopied = True
                Exit Do
            End If
        Loop
        'close workbook
        ThisExcelFile.Workbooks.Close()
        ThisExcelFile = Nothing
        Return Data_IsCopied


    End Function

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim excelFile As String

        excelFile = workbookfile
        If (excelFile.IndexOf("xlsx") <> -1) Or (excelFile.IndexOf("xls") <> -1) Then
            ListView1.Items.Clear()

            If GetExcelData() = True Then   'add it to listview

                ProgressBar1.Minimum = 0
                ProgressBar1.Maximum = MyExcelRowList.Count

                ListView1.Items.Clear()

                For Each xitem In MyExcelRowList
                    Dim LvItem As ListViewItem
                    LvItem = Me.ListView1.Items.Add(ListView1.Items.Count + 1)
                    LvItem.SubItems.AddRange(New String() {xitem.productcode, xitem.productdesc, xitem.qty, xitem.price, xitem.column1, xitem.column2, xitem.column3, xitem.column4, xitem.column5, xitem.column6, xitem.column7, xitem.column8, xitem.column9, xitem.column10, xitem.column11, xitem.column12, xitem.column13, xitem.column14, xitem.column15})

                    counter = counter + 1
                    BackgroundWorker1.ReportProgress(counter)
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    System.Threading.Thread.Sleep(1)

                Next
            End If
        Else
            MsgBox("Wrong Spreadsheet file !" & vbCrLf & vbCrLf & "Browse for the file containing the stock list.", MsgBoxStyle.Critical, "Wrong Spreadsheet File")
        End If
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Label1.Text = "Imported    " & e.ProgressPercentage.ToString() & "    of    " & MyExcelRowList.Count
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        workbookfile = ""
    End Sub

    Private Sub BackgroundWorker2_DoWork1(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        LOADDATA(ListView1)
    End Sub


    Private Function saveData(sql As String)
        Dim CONN As MySqlConnection = New MySqlConnection("server=localhost;User Id=root;password=;Persist Security Info=True;database=tes_appexcel;Convert Zero Datetime=True")
        Dim mysqlcmd As MySqlCommand
        Dim mysqlresult As Boolean

        Try
            CONN.Open()
            mysqlcmd = New MySqlCommand
            With mysqlcmd
                .Connection = CONN
                .CommandText = sql
                mysqlresult = .ExecuteNonQuery
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CONN.Close()
        End Try
        Return mysqlresult

    End Function

    Private Sub btnUploud_Click(sender As Object, e As EventArgs) Handles btnUploud.Click
        Try
            Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + TextBox1.Text + ";Extended Properties=Excel 12.0;")
            Dim cmd1 As New OleDb.OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            Dim dt As New DataTable
            Dim result As Boolean
            Dim sql As String

            Call KoneksiKeDatabase()
            QUERY = "SELECT * FROM `tbl_coba`"
            CMD = New MySqlCommand(QUERY, CONN)
            CMD.ExecuteNonQuery()

            With cmd1
                .Connection = con
                .CommandText = "SELECT * FROM [Sheet1$]"
            End With

            da.SelectCommand = cmd1
            da.Fill(dt)

            For Each r As DataRow In dt.Rows
                'sql = "INSERT INTO mt (fname,lname) VALUES ('" & r(0).ToString & "','" & r(1).ToString & "')"
                'sql = "INSERT INTO `mt`(`id`, `no_urut`, `kode_rfid`, `no_polis`, `ket_blokir`, `title`, `nama_perusahaan`, `sts`, `merk_type`, `model`, `thn_pembuatan`, `kapasitas`, `kompartemen`, `produk`, `no_mesin`, `no_rangka`, `hsl_uji_emisi`, `pas_masuk`, `stnk`, `keur`, `tera`, `ijin_brg_khusus`, `skt`, `no_pas`, `status2`, `ksong`, `keterangan`, `tgl_penerima`, `no_surat_tera`, `komp1_t1`, `komp1_t2`, `komp1_t3`, `komp1_ruang_ksg`, `komp1_k1`, `komp2_t1`, `komp2_t2`, `komp2_t3`, `komp2_ruang_ksg`, `komp2_k1`, `tera2`, `thn_pembuatan2`, `no_stnk`, `m_berlaku_stnk`, `no_keur`, `m_berlaku_kier`, `no_dok_uji_emisi`, `hasil_uji_emisi`, `m_berlaku_uji_emisi`, `no_spb_skt`, `m_berlaku_spb_mkt`, `no_z_m_terminal_bbm`, `no_izin_masuk`, `kode_area`, `area`, `kd_lokasi`, `lokasi`, `kd_kategori`, `kategori`, `delivery_point`, `sewa`, `tarif`, `agen`, `industri`, `angkutan_sendiri`, `umur`, `kat`, `produk2`, `engkel_tronton_semit`, `pabrikan_tangki`, `material_tangki`, `pembuatan_tangki`, `sts_armada`, `plat`, `asuransi`, `alamat`, `telepon`, `email`, `npwp`, `penanggung_jawab`, `jabatan`, `data_umur_mt`) VALUES ('','" & r(1).ToString & "','" & r(2).ToString & "','" & r(3).ToString & "','" & r(4).ToString & "','" & r(5).ToString & "','" & r(6).ToString & "','" & r(7).ToString & "','" & r(8).ToString & "','" & r(9).ToString & "','" & r(10).ToString & "','" & Format(r(11).ToString, "yyyy-MM-dd") & "','" & r(12).ToString & "','" & r(13).ToString & "','" & r(14).ToString & "','" & r(15).ToString & "','" & r(16).ToString & "','" & r(17).ToString & "','" & r(18).ToString & "','" & r(19).ToString & "','" & r(20).ToString & "','" & r(21).ToString & "','" & r(22).ToString & "','" & r(23).ToString & "','" & r(24).ToString & "','" & r(25).ToString & "','" & r(26).ToString & "','" & r(27).ToString & "','" & r(28).ToString & "','" & r(29).ToString & "','" & r(30).ToString & "','" & r(31).ToString & "','" & r(32).ToString & "','" & r(33).ToString & "','" & r(34).ToString & "','" & r(35).ToString & "','" & r(36).ToString & "','" & r(37).ToString & "','" & r(38).ToString & "','" & r(39).ToString & "','" & r(40).ToString & "','" & r(41).ToString & "','" & r(42).ToString & "','" & r(43).ToString & "','" & r(44).ToString & "','" & r(45).ToString & "','" & r(46).ToString & "','" & r(47).ToString & "','" & r(48).ToString & "','" & r(49).ToString & "','" & r(50).ToString & "','" & r(51).ToString & "','" & r(52).ToString & "','" & r(53).ToString & "','" & r(54).ToString & "','" & r(55).ToString & "','" & r(56).ToString & "','" & r(57).ToString & "','" & r(58).ToString & "','" & r(59).ToString & "','" & r(69).ToString & "','" & r(61).ToString & "','" & r(62).ToString & "','" & r(63).ToString & "','" & r(64).ToString & "','" & r(65).ToString & "','" & r(66).ToString & "','" & r(67).ToString & "','" & r(68).ToString & "','" & r(69).ToString & "','" & r(70).ToString & "','" & r(71).ToString & "','" & r(72).ToString & "','" & r(73).ToString & "','" & r(74).ToString & "','" & r(75).ToString & "','" & r(76).ToString & "','" & r(77).ToString & "','" & r(78).ToString & "','" & r(79).ToString & "','" & r(80).ToString & "')"
                sql = "INSERT INTO `tbl_coba`(`nama_depan`, `nama_belakang`, `alamat`, `tes`) VALUES ('" & r(1).ToString & "','" & r(2).ToString & "','" & r(3).ToString & "','" & r(4).ToString & "')"
                result = saveData(sql)
                ProgressBar1.Visible = False
                If result Then
                    Timer1.Start()
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar2.Value = 100 Then
            Timer1.Stop()
            MessageBox.Show("Sucessfully imported", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProgressBar1.Visible = True

            ProgressBar2.Value = 0
        Else
            ProgressBar2.Value += 1
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
