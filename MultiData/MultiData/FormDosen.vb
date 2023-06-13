Imports MySql.Data.MySqlClient

Public Class FormDosen
    Private Sub IsiList()
        ' Panggil koneksi yang sudah kita buat sub Koneksi()
        Dim a As Integer
        Try
            Query = "Select * FROM tbl_dosen ORDER BY nidn"
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
                End With
            Next
        Catch ex As Exception

        End Try

    End Sub
    Private Sub PosisiList()
        With ListView1.Columns
            .Add("NIDN", 60)
            .Add("NAMA DOSEN", 60)
            .Add("EMAIL", 60)
            .Add("TELPON", 60)
        End With
    End Sub

    Private Sub FormDosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        KoneksiKeDatabase()
        IsiList()
        PosisiList()
    End Sub
    Private Sub Bersih()
        txtEmail.Text = ""
        txtNDosen.Text = ""
        txtNidn.Text = ""
        txtTelepon.Text = ""
    End Sub
    Private Sub AmbilDataListview()
        'mengambil data dari list view
        With ListView1.SelectedItems
            Try
                txtNidn.Text = .Item(0).SubItems(0).Text
                txtNDosen.Text = .Item(0).SubItems(1).Text
                txtEmail.Text = .Item(0).SubItems(2).Text
                txtTelepon.Text = .Item(0).SubItems(3).Text

            Catch ex As Exception

            End Try

        End With


    End Sub
    Private Sub Caridata()
        Dim a As Integer
        Try
            Query = "SELECT * FROM tbl_dosen WHERE nidn LIKE '%" & Trim(txtCari.Text) & "%' OR nama_dosen LIKE '%" & Trim(txtCari.Text) & "%'"
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
                End With
            Next
            'MsgBox("berhasil")
        Catch ex As Exception
            'MsgBox("error")

        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Bersih()
        IsiList()
    End Sub
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Caridata()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If txtEmail.Text = "" Or 'atau
                txtNidn.Text = "" Or 'atau
                txtNDosen.Text = "" Or
                txtTelepon.Text = "" Then
                MsgBox("Silakan lengkapi data terlebih dahulu!", MsgBoxStyle.Critical, "Error")
                txtNidn.Focus()
            Else
                Query = "INSERT INTO tbl_dosen values ('" & txtNidn.Text & "','" & txtNDosen.Text & "','" & txtEmail.Text & "','" & txtTelepon.Text & "')"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                MsgBox("Data Berhasil Disimpan!", MsgBoxStyle.Critical, "SAVE")
                txtNidn.Focus()
                IsiList()
                Bersih()
            End If

        Catch ex As Exception
            MsgBox("NiM Sudah Ada!", MsgBoxStyle.Critical, "Error")
            txtNidn.Focus()
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        AmbilDataListview()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txtEmail.Text = "" Or 'atau
                txtNidn.Text = "" Or 'atau
                txtNDosen.Text = "" Or
                txtTelepon.Text = "" Then
                MsgBox("Silakan lengkapi data terlebih dahulu!", MsgBoxStyle.Critical, "Error")
                txtNidn.Focus()
            Else
                Query = "UPDATE tbl_dosen set nama_dosen='" & txtNDosen.Text & "',email='" & txtEmail.Text & "',telp='" & txtTelepon.Text & "'where nidn='" & txtNidn.Text & "'"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                MsgBox("Data Berhasil Disimpan!", MsgBoxStyle.Critical, "SAVE")
                txtNidn.Focus()
                IsiList()
            End If

        Catch ex As Exception
            MsgBox("NiM Sudah Ada!", MsgBoxStyle.Critical, "Error")
            txtNidn.Focus()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim A As String
            A = MsgBox("Benar data mau dihapus...?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Hapus Data")
            Select Case A
                Case vbCancel
                    txtNidn.Focus()
                Case vbOK
                    If txtNidn.Text = "" Then
                        MsgBox("Input Nim Yang Akan di Hapus", MsgBoxStyle.Critical, "Data Kosong")
                        txtNidn.Focus()
                    Else
                        Query = "DELETE FROM tbl_dosen WHERE nidn='" & txtNidn.Text & "'"
                        daData = New MySqlDataAdapter(Query, Conn)
                        dsData = New DataSet
                        daData.Fill(dsData)
                        IsiList()
                        Bersih()
                        MsgBox("Data Berhasil Di hapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")
                    End If
            End Select
        Catch ex As Exception
            MsgBox("Data Tidak bisa di Hapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub



    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Caridata()
    End Sub
End Class