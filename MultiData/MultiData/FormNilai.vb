Imports MySql.Data.MySqlClient
Public Class FormNilai
    Dim sks As Integer
    Dim nilaiAkhir As Double
    Dim bobot, jlhNilai As Integer
    Dim nilaiHuruf, keterangan As String
    Dim idNilai As String
    Dim nidn As Integer
    Private Sub AmbilDatadariListView()
        With ListView1.SelectedItems
            Try
                idNilai = .Item(0).SubItems(0).Text
                CBTAkhir.Text = .Item(0).SubItems(1).Text
                CBSem.Text = .Item(0).SubItems(2).Text
                txtNim.Text = .Item(0).SubItems(3).Text
                txtMHS.Text = .Item(0).SubItems(4).Text
                txtNidn.Text = .Item(0).SubItems(5).Text
                txtNDosen.Text = .Item(0).SubItems(6).Text
                txtMTK.Text = .Item(0).SubItems(7).Text
                txtNMTK.Text = .Item(0).SubItems(8).Text
                txtSKS.Text = .Item(0).SubItems(9).Text
                txtNAkhir.Text = .Item(0).SubItems(10).Text
                txtNHuruf.Text = .Item(0).SubItems(11).Text
                txtBobot.Text = .Item(0).SubItems(12).Text
                txtJnilai.Text = .Item(0).SubItems(13).Text
                txtKeterangan.Text = .Item(0).SubItems(14).Text

            Catch ex As Exception

            End Try
        End With

    End Sub
    Private Sub PosisiList()
        With ListView1.Columns
            .Add("ID NILAI", 60) '0
            .Add("TAHUN AKADEMIK", 100) '1
            .Add("SEMESTER", 70) '2
            .Add("NIM", 70) '3
            .Add("NAMA MAHASISWA", 130) '4
            .Add("NIDN", 70) '14
            .Add("NAMA DOSEN", 130) '15
            .Add("KODE MTK", 70) '18
            .Add("NAMA MATA KULIAH", 130) '19
            .Add("SKS", 70) '20
            .Add("NILAI AKHIR", 70)
            .Add("NILAI HURUF", 70)
            .Add("BOBOT", 70)
            .Add("JUMLAH", 70)
            .Add("KETERANGAN", 120) '25

        End With
    End Sub
    Private Sub isiList()
        Dim a As Integer
        Try
            Query = "SELECT * FROM relasinilai2 ORDER BY nim"
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
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(14))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(15))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(18))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(19))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(20))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(21))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(22))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(23))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(24))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(25))
                End With
            Next
            'MsgBox("Berhasil Masuk")

        Catch ex As Exception
            'MsgBox("Gagal Masuk")
        End Try
    End Sub
    Private Sub Prosesnilai()
        sks = txtSKS.Text
        nilaiAkhir = txtNAkhir.Text

        If ((nilaiAkhir >= 80) And (nilaiAkhir <= 100)) Then '80 sampai 100
            nilaiHuruf = "A"
            bobot = 4
            jlhNilai = sks * bobot
            keterangan = "Sangat Memuaskan"
        ElseIf ((nilaiAkhir >= 70) And (nilaiAkhir < 80)) Then '70 samoai 79,9
            nilaiHuruf = "B"
            bobot = 3
            jlhNilai = sks * bobot
            keterangan = "Memuaskan"
        ElseIf ((nilaiAkhir >= 60) And (nilaiAkhir < 70)) Then
            nilaiHuruf = "C"
            bobot = 2
            jlhNilai = sks * bobot
            keterangan = "Cukup"
        ElseIf ((nilaiAkhir >= 45) And (nilaiAkhir < 60)) Then
            nilaiHuruf = "D"
            bobot = 1
            jlhNilai = sks * bobot
            keterangan = "Kurang"
        ElseIf ((nilaiAkhir >= 0) And (nilaiAkhir < 45)) Then
            nilaiHuruf = "E"
            bobot = 1
            jlhNilai = sks * bobot
            keterangan = "Gagal"
        Else
            nilaiHuruf = "Error"
            bobot = 0
            jlhNilai = sks * bobot
            keterangan = "Nilai diluar range"
        End If

        txtBobot.Text = bobot
        txtNAkhir.Text = nilaiAkhir
        txtJnilai.Text = jlhNilai
        txtNHuruf.Text = nilaiHuruf
        txtKeterangan.Text = keterangan
    End Sub

    Private Sub btnCariMhs_Click(sender As Object, e As EventArgs) Handles btnCariMhs.Click
        FormCariMhs.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtNAkhir.Text = "" Then
            MsgBox("Isi data nilai akhir")
        Else
            Prosesnilai()
        End If


    End Sub
    Private Sub tableMHS()
        Dim a As Integer
        Try
            Query = "Select * FROM tbl_dosen ORDER BY nidn"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData)
            ListView1.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ComboBox1
                    .Items.Add(dsData.Tables(0).Rows(a).Item(2))
                End With
            Next
            MsgBox("Berhasil")
        Catch ex As Exception
            MsgBox("GAGAL")
        End Try
    End Sub

    Private Sub FormNilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        KoneksiKeDatabase()
        PosisiList()
        isiList()
        CBTAkhir.Items.Add("2019/2020")
        CBTAkhir.Items.Add("2020/2021")
        CBTAkhir.Items.Add("2021/2022")
        CBTAkhir.Items.Add("2022/2023")
        CBTAkhir.Items.Add("2024/2025")

        CBSem.Items.Add("Genap")
        CBSem.Items.Add("Ganjil")

        KoneksiKeDatabase()
        tableMHS()
    End Sub
    Private Sub bersihData()
        CBTAkhir.Focus()
        CBSem.Text = ""
        CBTAkhir.Text = ""
        txtNim.Text = ""
        txtMHS.Text = ""
        txtNidn.Text = ""
        txtNDosen.Text = ""
        txtSKS.Text = ""
        txtNAkhir.Text = ""
        txtNHuruf.Text = ""
        txtBobot.Text = ""
        txtJnilai.Text = ""
        txtMTK.Text = ""
        txtNMTK.Text = ""
        txtKeterangan.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If CBSem.Text = "" Or
               CBTAkhir.Text = "" Or
               txtNim.Text = "" Or
               txtMHS.Text = "" Or
               txtNidn.Text = "" Or
               txtNDosen.Text = "" Or
               txtSKS.Text = "" Or
               txtNAkhir.Text = "" Or
               txtNHuruf.Text = "" Or
               txtBobot.Text = "" Or
               txtJnilai.Text = "" Or
               txtMTK.Text = "" Or
               txtNMTK.Text = "" Or
               txtKeterangan.Text = "" Then
                MsgBox("Silakan Lengkapi Data Terlebih Dahulu", MsgBoxStyle.Critical, "Data Kosong")
            Else

                Call KoneksiKeDatabase()
                cmd = New MySqlCommand("SELECT * FROM tbl_nilai where nim='" & txtNim.Text & "' AND kode_mtk='" & txtMTK.Text & "'", Conn)
                RD = cmd.ExecuteReader
                RD.Read()
                If RD.HasRows = True Then
                    MsgBox("NIM dan KODE MTK Tidak boleh sama", MsgBoxStyle.Critical, "Data Dulpicat")
                Else
                    Call KoneksiKeDatabase()
                    Query = "INSERT INTO tbl_nilai(ta,semester,nim,nidn,kode_mtk,nilai_akhir,nilai_huruf,bobot_nilai,jumlah,keterangan) values ('" & CBTAkhir.Text & "','" & CBSem.Text & "','" & txtNim.Text & "','" & txtNidn.Text & "','" & txtMTK.Text & "','" & txtNAkhir.Text & "','" & txtNHuruf.Text & "','" & txtBobot.Text & "','" & txtJnilai.Text & "','" & txtKeterangan.Text & "')"
                    daData = New MySqlDataAdapter(Query, Conn)
                    dsData = New DataSet
                    daData.Fill(dsData)
                    MsgBox("Data berhasil Simpan", MsgBoxStyle.Critical, "SUKSES")
                    CBTAkhir.Focus()
                    txtNidn.Text = ""
                    txtNDosen.Text = ""
                    txtSKS.Text = ""
                    txtNAkhir.Text = ""
                    txtNHuruf.Text = ""
                    txtBobot.Text = ""
                    txtJnilai.Text = ""
                    txtMTK.Text = ""
                    txtNMTK.Text = ""
                    txtKeterangan.Text = ""

                    PosisiList()
                    isiList()
                End If

            End If
        Catch ex As Exception
            MsgBox("Data tidak Simpan", MsgBoxStyle.Critical, "Gagal")

        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        'txtidNilai.Text = idNilai
        AmbilDatadariListView()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If CBSem.Text = "" Or
               CBTAkhir.Text = "" Or
               txtNim.Text = "" Or
               txtMHS.Text = "" Or
               txtNidn.Text = "" Or
               txtNDosen.Text = "" Or
               txtSKS.Text = "" Or
               txtNAkhir.Text = "" Or
               txtNHuruf.Text = "" Or
               txtBobot.Text = "" Or
               txtJnilai.Text = "" Or
               txtMTK.Text = "" Or
               txtNMTK.Text = "" Or
               txtKeterangan.Text = "" Then
                MsgBox("Silakan Lengkapi Data yang mau di edit", MsgBoxStyle.Critical, "Data Kosong")
            Else
                Query = "UPDATE tbl_nilai set ta='" & CBTAkhir.Text & "',semester='" & CBSem.Text & "',nim='" & txtNim.Text & "',nidn='" & txtNidn.Text & "',kode_mtk='" & txtMTK.Text & "',nilai_akhir='" & txtNAkhir.Text & "',nilai_huruf='" & txtNHuruf.Text & "',bobot_nilai='" & txtBobot.Text & "',jumlah='" & txtJnilai.Text & "',keterangan='" & txtKeterangan.Text & "' WHERE id_nilai='" & idNilai & "'"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                MsgBox("Data berhasil Diedit", MsgBoxStyle.Critical, "SUKSES")
                CBTAkhir.Focus()
                PosisiList()
                isiList()
                bersihData()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim A As String
            A = MsgBox("Benar data mau dihapus...?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Hapus Data")
            Select Case A
                Case vbCancel
                    CBTAkhir.Focus()
                Case vbOK

                    Query = "DELETE FROM tbl_nilai WHERE id_nilai='" & idNilai & "'"
                    daData = New MySqlDataAdapter(Query, Conn)
                    dsData = New DataSet
                    daData.Fill(dsData)
                    isiList()
                    bersihData()
                    MsgBox("Data Berhasil Di hapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")

            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click, Label17.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTDMHS.Click
        FormMhs.ShowDialog()
    End Sub

    Private Sub btnTDDosen_Click(sender As Object, e As EventArgs) Handles btnTDDosen.Click
        FormDosen.ShowDialog()
    End Sub

    Private Sub btnTDMTK_Click(sender As Object, e As EventArgs) Handles btnTDMTK.Click
        FormMataKuliah.ShowDialog()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub cariMTK_Click(sender As Object, e As EventArgs) Handles cariDosen.Click
        FormCariDosen.Show()
    End Sub

    Private Sub btnCariMTK_Click(sender As Object, e As EventArgs) Handles btnCariMTK.Click
        FormCariMtk.ShowDialog()
    End Sub

    Private Sub txtNDosen_TextChanged(sender As Object, e As EventArgs) Handles txtNDosen.TextChanged

    End Sub

    Private Sub txtNidn_TextChanged(sender As Object, e As EventArgs) Handles txtNidn.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

    End Sub

    Private Sub btnLapor_Click(sender As Object, e As EventArgs) Handles btnLapor.Click
        FormLaporan.ShowDialog()
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Try
            KoneksiKeDatabase()
            cmd = New MySqlCommand("SELECT * FROM tbl_dosen where nidn='" & ComboBox1.Text & "'", Conn)
            RD = cmd.ExecuteReader
            RD.Read()
            If RD.HasRows = True Then
                txtNidn.Text = RD.Item("nidn")
                txtNDosen.Text = RD.Item("nama_dosen")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class