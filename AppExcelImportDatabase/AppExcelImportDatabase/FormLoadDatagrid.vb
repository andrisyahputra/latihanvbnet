Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient

Public Class FormLoadDatagrid
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

    Private Structure MyExcelRows
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
        Dim column27 As String
        Dim column28 As String
        Dim column29 As String
        Dim column30 As String
        Dim column31 As String
        Dim column32 As String
        Dim column33 As String
        Dim column34 As String
        Dim column35 As String
        Dim column36 As String
        Dim column37 As String
        Dim column38 As String
        Dim column39 As String
        Dim column40 As String
        Dim column41 As String
        Dim column42 As String
        Dim column43 As String
        Dim column44 As String
        Dim column45 As String
        Dim column46 As String
        Dim column47 As String
        Dim column48 As String
        Dim column49 As String
        Dim column50 As String
        Dim column51 As String
        Dim column52 As String
        Dim column53 As String
        Dim column54 As String
        Dim column55 As String
        Dim column56 As String
        Dim column57 As String
        Dim column58 As String
        Dim column59 As String
        Dim column60 As String
        Dim column61 As String
        Dim column62 As String
        Dim column63 As String
        Dim column64 As String
        Dim column65 As String
        Dim column66 As String
        Dim column67 As String
        Dim column68 As String
        Dim column69 As String
        Dim column70 As String
        Dim column71 As String
        Dim column72 As String
        Dim column73 As String
        Dim column74 As String
        Dim column75 As String
        Dim column76 As String
        Dim column77 As String
        Dim column78 As String
        Dim column79 As String
        Dim column80 As String
    End Structure


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
        ThisExcelFile.Range("A3").Activate()
        'I start extracting rows
        Dim CurrentRow As New MyExcelRows
        'If Len(wks.Cells(1, "A").Value) = 0 Then Exit Sub 
        Do
            If ThisExcelFile.ActiveCell.Value > Nothing Or ThisExcelFile.ActiveCell.Text > Nothing Then

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
                    CurrentRow.column3 = ThisExcelFile.ActiveCell.Value                 'column3
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column3 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column4 = ThisExcelFile.ActiveCell.Value                 'column4
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column4 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column5 = ThisExcelFile.ActiveCell.Value                 'column5
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column5 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column6 = ThisExcelFile.ActiveCell.Value                 'column6
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column6 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column7 = ThisExcelFile.ActiveCell.Value                 'column7
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column7 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column8 = ThisExcelFile.ActiveCell.Value                 'column8
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column8 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column9 = ThisExcelFile.ActiveCell.Value                 'column9
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column9 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column10 = ThisExcelFile.ActiveCell.Value                 'column10
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column10 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column11 = ThisExcelFile.ActiveCell.Value                 'column11
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column11 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column12 = ThisExcelFile.ActiveCell.Value                 'column12
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column12 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column13 = ThisExcelFile.ActiveCell.Value                 'column13
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column13 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column14 = ThisExcelFile.ActiveCell.Value                 'column14
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column14 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column15 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column15 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column16 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column16 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column17 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column17 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column18 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column19 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column20 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column20 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column21 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column21 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column22 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column22 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column23 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column23 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If


                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column24 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column24 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column25 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column25 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column26 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column26 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column27 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column27 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column28 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column28 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column29 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column29 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column30 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column30 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column31 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column31 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column32 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column32 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column33 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column33 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column34 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column34 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column35 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column35 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column36 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column36 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column37 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column37 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column38 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column38 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column39 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column39 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column40 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column40 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column41 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column41 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column42 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column42 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If
                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column43 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column43 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column44 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column44 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column45 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column45 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column46 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column46 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column47 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column47 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column48 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column48 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column49 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column49 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column50 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column50 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column51 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column51 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column52 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column52 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column53 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column53 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column54 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column54 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column55 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column55 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column56 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column56 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column57 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column57 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column58 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column58 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column59 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column59 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column60 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column60 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column61 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column61 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column62 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column62 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column63 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column63 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column64 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column64 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column65 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column65 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column66 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column66 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column67 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column67 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column68 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column68 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column69 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column69 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column70 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column70 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column71 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column71 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column72 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column72 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column73 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column73 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column74 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column74 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                CurrentRow.column75 = ThisExcelFile.ActiveCell.Value                 'column15
                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column75 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column76 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column76 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column77 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column77 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column78 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column78 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column79 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column78 = "0.00"
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                End If

                If Not (String.IsNullOrWhiteSpace(ThisExcelFile.ActiveCell.Value)) Then
                    CurrentRow.column80 = ThisExcelFile.ActiveCell.Value                 'column15
                    ThisExcelFile.ActiveCell.Offset(0, 1).Activate()
                Else
                    CurrentRow.column80 = "0.00"
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
        Try
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
                        LvItem.SubItems.AddRange(New String() {xitem.column1, xitem.column2, xitem.column3, xitem.column4, xitem.column5, xitem.column6, xitem.column7, xitem.column8, xitem.column9, xitem.column10, xitem.column11, xitem.column12, xitem.column13, xitem.column14, xitem.column15, xitem.column16, xitem.column17, xitem.column18, xitem.column19, xitem.column20, xitem.column21, xitem.column22, xitem.column23, xitem.column24, xitem.column25, xitem.column26, xitem.column27, xitem.column28, xitem.column29, xitem.column30, xitem.column31, xitem.column32, xitem.column33, xitem.column34, xitem.column35, xitem.column36, xitem.column37, xitem.column38, xitem.column39, xitem.column40, xitem.column41, xitem.column42, xitem.column43, xitem.column44, xitem.column45, xitem.column46, xitem.column47, xitem.column48, xitem.column49, xitem.column50, xitem.column51, xitem.column52, xitem.column53, xitem.column54, xitem.column55, xitem.column56, xitem.column57, xitem.column58, xitem.column59, xitem.column60, xitem.column61, xitem.column62, xitem.column63, xitem.column64, xitem.column65, xitem.column66, xitem.column67, xitem.column68, xitem.column69, xitem.column70, xitem.column71, xitem.column72, xitem.column73, xitem.column74, xitem.column75, xitem.column76, xitem.column77, xitem.column78, xitem.column79, xitem.column80, xitem.column15})

                        counter = counter + 1
                        BackgroundWorker1.ReportProgress(counter)
                        ProgressBar1.Value = ProgressBar1.Value + 1
                        System.Threading.Thread.Sleep(1)

                    Next
                End If
            Else
                MsgBox("Wrong Spreadsheet file !" & vbCrLf & vbCrLf & "Browse for the file containing the stock list.", MsgBoxStyle.Critical, "Wrong Spreadsheet File")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Label1.Text = "Imported    " & e.ProgressPercentage.ToString() & "    of    " & MyExcelRowList.Count
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        workbookfile = ""
    End Sub

    Private Sub FormLoadDatagrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posisilist()
    End Sub
    'Private Function saveData(sql As String)
    '    Dim CONN As MySqlConnection = New MySqlConnection("server=localhost;User Id=root;password=;Persist Security Info=True;database=tes_appexcel;Convert Zero Datetime=True")
    '    Dim mysqlcmd As MySqlCommand
    '    Dim mysqlresult As Boolean

    '    Try
    '        CONN.Open()
    '        mysqlcmd = New MySqlCommand
    '        With mysqlcmd
    '            .Connection = CONN
    '            .CommandText = sql
    '            mysqlresult = .ExecuteNonQuery
    '        End With
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        CONN.Close()
    '    End Try
    '    Return mysqlresult

    'End Function

    'Private Sub btnUploud_Click(sender As Object, e As EventArgs) Handles btnUploud.Click
    '    Try
    '        Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + TextBox1.Text + ";Extended Properties=Excel 12.0;")
    '        Dim cmd1 As New OleDb.OleDbCommand
    '        Dim da As New OleDb.OleDbDataAdapter
    '        Dim dt As New DataTable
    '        Dim result As Boolean
    '        Dim sql As String

    '        Call KoneksiKeDatabase()
    '        QUERY = "SELECT * FROM `tbl_coba`"
    '        CMD = New MySqlCommand(QUERY, CONN)
    '        CMD.ExecuteNonQuery()

    '        With cmd1
    '            .Connection = con
    '            .CommandText = "SELECT * FROM [Sheet1$]"
    '        End With

    '        da.SelectCommand = cmd1
    '        da.Fill(dt)

    '        For Each r As DataRow In dt.Rows
    '            'sql = "INSERT INTO mt (fname,lname) VALUES ('" & r(0).ToString & "','" & r(1).ToString & "')"
    '            'sql = "INSERT INTO `mt`(`id`, `no_urut`, `kode_rfid`, `no_polis`, `ket_blokir`, `title`, `nama_perusahaan`, `sts`, `merk_type`, `model`, `thn_pembuatan`, `kapasitas`, `kompartemen`, `produk`, `no_mesin`, `no_rangka`, `hsl_uji_emisi`, `pas_masuk`, `stnk`, `keur`, `tera`, `ijin_brg_khusus`, `skt`, `no_pas`, `status2`, `ksong`, `keterangan`, `tgl_penerima`, `no_surat_tera`, `komp1_t1`, `komp1_t2`, `komp1_t3`, `komp1_ruang_ksg`, `komp1_k1`, `komp2_t1`, `komp2_t2`, `komp2_t3`, `komp2_ruang_ksg`, `komp2_k1`, `tera2`, `thn_pembuatan2`, `no_stnk`, `m_berlaku_stnk`, `no_keur`, `m_berlaku_kier`, `no_dok_uji_emisi`, `hasil_uji_emisi`, `m_berlaku_uji_emisi`, `no_spb_skt`, `m_berlaku_spb_mkt`, `no_z_m_terminal_bbm`, `no_izin_masuk`, `kode_area`, `area`, `kd_lokasi`, `lokasi`, `kd_kategori`, `kategori`, `delivery_point`, `sewa`, `tarif`, `agen`, `industri`, `angkutan_sendiri`, `umur`, `kat`, `produk2`, `engkel_tronton_semit`, `pabrikan_tangki`, `material_tangki`, `pembuatan_tangki`, `sts_armada`, `plat`, `asuransi`, `alamat`, `telepon`, `email`, `npwp`, `penanggung_jawab`, `jabatan`, `data_umur_mt`) VALUES ('','" & r(1).ToString & "','" & r(2).ToString & "','" & r(3).ToString & "','" & r(4).ToString & "','" & r(5).ToString & "','" & r(6).ToString & "','" & r(7).ToString & "','" & r(8).ToString & "','" & r(9).ToString & "','" & r(10).ToString & "','" & Format(r(11).ToString, "yyyy-MM-dd") & "','" & r(12).ToString & "','" & r(13).ToString & "','" & r(14).ToString & "','" & r(15).ToString & "','" & r(16).ToString & "','" & r(17).ToString & "','" & r(18).ToString & "','" & r(19).ToString & "','" & r(20).ToString & "','" & r(21).ToString & "','" & r(22).ToString & "','" & r(23).ToString & "','" & r(24).ToString & "','" & r(25).ToString & "','" & r(26).ToString & "','" & r(27).ToString & "','" & r(28).ToString & "','" & r(29).ToString & "','" & r(30).ToString & "','" & r(31).ToString & "','" & r(32).ToString & "','" & r(33).ToString & "','" & r(34).ToString & "','" & r(35).ToString & "','" & r(36).ToString & "','" & r(37).ToString & "','" & r(38).ToString & "','" & r(39).ToString & "','" & r(40).ToString & "','" & r(41).ToString & "','" & r(42).ToString & "','" & r(43).ToString & "','" & r(44).ToString & "','" & r(45).ToString & "','" & r(46).ToString & "','" & r(47).ToString & "','" & r(48).ToString & "','" & r(49).ToString & "','" & r(50).ToString & "','" & r(51).ToString & "','" & r(52).ToString & "','" & r(53).ToString & "','" & r(54).ToString & "','" & r(55).ToString & "','" & r(56).ToString & "','" & r(57).ToString & "','" & r(58).ToString & "','" & r(59).ToString & "','" & r(69).ToString & "','" & r(61).ToString & "','" & r(62).ToString & "','" & r(63).ToString & "','" & r(64).ToString & "','" & r(65).ToString & "','" & r(66).ToString & "','" & r(67).ToString & "','" & r(68).ToString & "','" & r(69).ToString & "','" & r(70).ToString & "','" & r(71).ToString & "','" & r(72).ToString & "','" & r(73).ToString & "','" & r(74).ToString & "','" & r(75).ToString & "','" & r(76).ToString & "','" & r(77).ToString & "','" & r(78).ToString & "','" & r(79).ToString & "','" & r(80).ToString & "')"
    '            sql = "INSERT INTO `tbl_coba`(`nama_depan`, `nama_belakang`, `alamat`, `tes`) VALUES ('" & r(1).ToString & "','" & r(2).ToString & "','" & r(3).ToString & "','" & r(4).ToString & "')"
    '            result = saveData(sql)
    '            ProgressBar1.Visible = False
    '            If result Then
    '                Timer1.Start()
    '            End If
    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    If ProgressBar2.Value = 100 Then
    '        Timer1.Stop()
    '        MessageBox.Show("Sucessfully imported", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        ProgressBar1.Visible = True

    '        ProgressBar2.Value = 0
    '    Else
    '        ProgressBar2.Value += 1
    '    End If
    'End Sub
End Class