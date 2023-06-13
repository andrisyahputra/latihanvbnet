Imports MySql.Data.MySqlClient

Public Class FormMhs
    Dim agama As String
    Dim jenkel As String
    Dim gender As String
    Private Sub Caridata()
        Dim a As Integer
        Try
            Query = "SELECT * FROM tbl_mahasiswa WHERE nim LIKE '%" & Trim(txtCari.Text) & "%' OR nama_mhs LIKE '%" & Trim(txtCari.Text) & "%'"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData)
            ListView1.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView1
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(4))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(5))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(6))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(7))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(8))
                End With
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        'ListView1.FullRowSelect = True
        'ListView1.GridLines = True
        'ListView1.MultiSelect = False
        'ListView1.View = View.Details
        AmbilDataListview()
    End Sub
    Private Sub AmbilDataListview()
        'mengambil data dari list view
        With ListView1.SelectedItems
            Try
                txtNim.Text = .Item(0).SubItems(0).Text
                txtMHS.Text = .Item(0).SubItems(1).Text
                txtTLahir.Text = .Item(0).SubItems(2).Text
                DateTLahir.Text = .Item(0).SubItems(3).Text
                txtUsia.Text = .Item(0).SubItems(4).Text

                gender = .Item(0).SubItems(5).Text
                If gender = rbLaki.Text Then
                    rbLaki.Checked = True
                ElseIf gender = rbPerempuan.Text Then
                    rbPerempuan.Checked = True
                End If

                agama = .Item(0).SubItems(6).Text
                If agama = cbIslam.Text Then
                    cbIslam.Checked = True
                ElseIf agama = cbKristen.Text Then
                    cbKristen.Checked = True
                ElseIf agama = cbHindu.Text Then
                    cbHindu.Checked = True
                ElseIf agama = cbbuddha.Text Then
                    cbbuddha.Checked = True
                ElseIf agama = cbKonghuchu.Text Then
                    cbKonghuchu.Checked = True
                End If

                txtAlamat.Text = .Item(0).SubItems(7).Text
                txtTelepon.Text = .Item(0).SubItems(8).Text

            Catch ex As Exception

            End Try

        End With


    End Sub
    Private Sub Usia()
        Dim thn, bln As String
        thn = Year(Now) - Year(DateTLahir.Value)
        bln = Month(DateTLahir.Value) - Month(Now)
        txtUsia.Text = thn & " Tahun, " & bln & " Bulan"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        KoneksiKeDatabase()
    End Sub
    Private Sub PosisiList()
        With ListView1.Columns
            .Add("Nim", 60)
            .Add("Nama", 60)
            .Add("Tempat Lahir", 60)
            .Add("Tanggal Lahir", 60)
            .Add("Usia", 60)
            .Add("Jenis Kelamin", 60)
            .Add("Agama", 60)
            .Add("Alamat", 60)
            .Add("No Telp/WA", 60)
        End With
    End Sub
    Private Sub IsiList()
        ' Panggil koneksi yang sudah kita buat sub Koneksi()
        Dim a As Integer
        Try
            Query = "Select * FROM tbl_mahasiswa ORDER BY nim"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData)
            ListView1.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView1
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(4))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(5))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(6))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(7))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(8))
                End With
                With ComboBox1
                    .Items.Add(dsData.Tables(0).Rows(a).Item(1))
                End With
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiKeDatabase()
        PosisiList()
        IsiList()
    End Sub

    Private Sub cbIslam_CheckedChanged(sender As Object, e As EventArgs) Handles cbIslam.CheckedChanged
        If cbIslam.Checked = True Then
            cbKristen.Checked = False
            cbHindu.Checked = False
            cbbuddha.Checked = False
            cbKonghuchu.Checked = False
            agama = cbIslam.Text
        End If
    End Sub

    Private Sub cbKristen_CheckedChanged(sender As Object, e As EventArgs) Handles cbKristen.CheckedChanged
        If cbKristen.Checked = True Then
            cbIslam.Checked = False
            cbHindu.Checked = False
            cbbuddha.Checked = False
            cbKonghuchu.Checked = False
            agama = cbKristen.Text
        End If
    End Sub

    Private Sub cbbuddha_CheckedChanged(sender As Object, e As EventArgs) Handles cbbuddha.CheckedChanged
        If cbbuddha.Checked = True Then
            cbKristen.Checked = False
            cbHindu.Checked = False
            cbIslam.Checked = False
            cbKonghuchu.Checked = False
            agama = cbbuddha.Text
        End If
    End Sub

    Private Sub cbHindu_CheckedChanged(sender As Object, e As EventArgs) Handles cbHindu.CheckedChanged
        If cbHindu.Checked = True Then
            cbKristen.Checked = False
            cbIslam.Checked = False
            cbbuddha.Checked = False
            cbKonghuchu.Checked = False
            agama = cbHindu.Text
        End If
    End Sub

    Private Sub cbKonghuchu_CheckedChanged(sender As Object, e As EventArgs) Handles cbKonghuchu.CheckedChanged
        If cbKonghuchu.Checked = True Then
            cbKristen.Checked = False
            cbHindu.Checked = False
            cbbuddha.Checked = False
            cbIslam.Checked = False
            agama = cbKonghuchu.Text
        End If
    End Sub
    Private Sub bersih()
        txtAlamat.Text = ""
        txtMHS.Text = ""
        txtNim.Text = ""
        txtTelepon.Text = ""
        txtTLahir.Text = ""
        txtUsia.Text = ""
        rbLaki.Checked = False
        rbPerempuan.Checked = False
        cbKristen.Checked = False
        cbHindu.Checked = False
        cbbuddha.Checked = False
        cbIslam.Checked = False
        cbKonghuchu.Checked = False
        txtUsia.Enabled = True
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        bersih()
        IsiList()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If txtAlamat.Text = "" Or 'atau
                txtMHS.Text = "" Or 'atau
                txtNim.Text = "" Or 'atau
                txtTelepon.Text = "" Or 'atau
                txtTLahir.Text = "" Or 'atau
                txtUsia.Text = "" Or 'atau
                rbLaki.Checked = False And 'dan
                rbPerempuan.Checked = False Or 'atau
                cbKristen.Checked = False And 'atau
                cbHindu.Checked = False And 'atau
                cbbuddha.Checked = False And 'atau
                cbIslam.Checked = False And 'atau
                cbKonghuchu.Checked = False Then
                MsgBox("Silakan lengkapi data terlebih dahulu!", MsgBoxStyle.Critical, "Error")
                txtNim.Focus()
            ElseIf DateTLahir.Text = Today Then
                MsgBox("Tanggal Lahir belum input!", MsgBoxStyle.Critical, "Error")
                DateTLahir.Focus()
            ElseIf DateTLahir.Text > Today Then
                MsgBox("Tanggal Lahir Kelewatan tahun!", MsgBoxStyle.Critical, "Error")
                DateTLahir.Focus()
            Else
                If rbLaki.Checked = True Then
                    gender = rbLaki.Text
                ElseIf rbPerempuan.Checked = True Then
                    gender = rbPerempuan.Text
                End If
                Query = "INSERT INTO tbl_mahasiswa values ('" & txtNim.Text & "','" & txtMHS.Text & "','" & txtTLahir.Text & "','" & Format(DateTLahir.Value, "yyyy-MM-dd") & "','" & txtUsia.Text & "','" & gender & "','" & agama & "','" & txtAlamat.Text & "','" & txtTelepon.Text & "','-','-')"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                MsgBox("Data Berhasil Disimpan!", MsgBoxStyle.Critical, "SAVE")
                txtNim.Focus()
                IsiList()
                bersih()
            End If

        Catch ex As Exception
            MsgBox("NiM Sudah Ada!", MsgBoxStyle.Critical, "Error")
            txtNim.Focus()
        End Try

    End Sub

    Private Sub DateTLahir_ValueChanged(sender As Object, e As EventArgs) Handles DateTLahir.ValueChanged
        Usia()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txtAlamat.Text = "" Or 'atau
                txtMHS.Text = "" Or 'atau
                txtNim.Text = "" Or 'atau
                txtTelepon.Text = "" Or 'atau
                txtTLahir.Text = "" Or 'atau
                txtUsia.Text = "" Or 'atau
                rbLaki.Checked = False And 'dan
                rbPerempuan.Checked = False Or 'atau
                cbKristen.Checked = False And 'atau
                cbHindu.Checked = False And 'atau
                cbbuddha.Checked = False And 'atau
                cbIslam.Checked = False And 'atau
                cbKonghuchu.Checked = False Then
                MsgBox("Silakan lengkapi data terlebih dahulu!", MsgBoxStyle.Critical, "Error")
                txtNim.Focus()
            ElseIf DateTLahir.Text = Today Then
                MsgBox("Tanggal Lahir belum input!", MsgBoxStyle.Critical, "Error")
                DateTLahir.Focus()
            ElseIf DateTLahir.Text > Today Then
                MsgBox("Tanggal Lahir Kelewatan tahun!", MsgBoxStyle.Critical, "Error")
                DateTLahir.Focus()
            Else
                If rbLaki.Checked = True Then
                    gender = rbLaki.Text
                ElseIf rbPerempuan.Checked = True Then
                    gender = rbPerempuan.Text
                End If
                Query = "UPDATE tbl_mahasiswa set nama_mhs='" & txtMHS.Text & "',tempat_lahir='" & txtTLahir.Text & "',tanggal_lahir='" & Format(DateTLahir.Value, "yyyy-MM-dd") & "',usia='" & txtUsia.Text & "',jenis_kelamin='" & gender & "',agama='" & agama & "',alamat='" & txtAlamat.Text & "',no_hp='" & txtTelepon.Text & "',a='-',b='-'where nim='" & txtNim.Text & "'"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                MsgBox("Data Berhasil Disimpan!", MsgBoxStyle.Critical, "SAVE")
                txtNim.Focus()
                IsiList()
            End If

        Catch ex As Exception
            MsgBox("NiM Sudah Ada!", MsgBoxStyle.Critical, "Error")
            txtNim.Focus()
        End Try
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        bersih()
        Caridata()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim A As String
            A = MsgBox("Benar data mau dihapus...?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Hapus Data")
            Select Case A
                Case vbCancel
                    txtNim.Focus()
                Case vbOK
                    If txtNim.Text = "" Then
                        MsgBox("Input Nim Yang Akan di Hapus", MsgBoxStyle.Critical, "Data Kosong")
                        txtNim.Focus()
                    Else
                        Query = "DELETE FROM tbl_mahasiswa WHERE nim='" & txtNim.Text & "'"
                        daData = New MySqlDataAdapter(Query, Conn)
                        dsData = New DataSet
                        daData.Fill(dsData)
                        IsiList()
                        bersih()
                        MsgBox("Data Berhasil Di hapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")
                    End If
            End Select
        Catch ex As Exception
            MsgBox("Data Tidak bisa di Hapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")
        End Try
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        bersih()
        Caridata()

    End Sub

    Private Sub txtUsia_TextChanged(sender As Object, e As EventArgs) Handles txtUsia.TextChanged

    End Sub
End Class
