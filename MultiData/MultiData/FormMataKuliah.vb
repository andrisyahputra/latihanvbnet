Imports MySql.Data.MySqlClient

Public Class FormMataKuliah
    Private Sub IsiList()
        ' Panggil koneksi yang sudah kita buat sub Koneksi()
        Dim a As Integer
        Try
            Query = "Select * FROM tbl_mata_kuliah ORDER BY kode_mtk"
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
            .Add("Kode Mtk", 60)
            .Add("nama mtk", 60)
            .Add("sks", 60)
            .Add("jam masuk", 130)
        End With
    End Sub

    Private Sub FormMataKuliah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jamKeluar.Format = DateTimePickerFormat.Time
        jamKeluar.ShowUpDown = True
        KoneksiKeDatabase()
        PosisiList()
        IsiList()
        Timer1.Start()
    End Sub
    Private Sub Bersih()
        txtMTK.Text = ""
        txtNMTK.Text = ""
        txtSKS.Text = ""
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Bersih()
        IsiList()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If txtMTK.Text = "" Or 'atau
                txtNMTK.Text = "" Or 'atau
                txtSKS.Text = "" Then
                MsgBox("Silakan lengkapi data terlebih dahulu!", MsgBoxStyle.Critical, "Error")
                txtMTK.Focus()
            Else
                Query = "INSERT INTO tbl_mata_kuliah values ('" & txtMTK.Text & "','" & txtNMTK.Text & "','" & txtSKS.Text & "','" & Format(jamKeluar.Value, "h:mm:ss") & "')"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                MsgBox("Data Berhasil Disimpan!", MsgBoxStyle.Critical, "SAVE")
                txtMTK.Focus()
                IsiList()
                Bersih()
            End If

        Catch ex As Exception
            MsgBox("NiM Sudah Ada!", MsgBoxStyle.Critical, "Error")
            txtMTK.Focus()
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If txtMTK.Text = "" Or 'atau
                txtNMTK.Text = "" Or 'atau
                txtSKS.Text = "" Then
                MsgBox("Silakan lengkapi data terlebih dahulu!", MsgBoxStyle.Critical, "Error")
                txtMTK.Focus()
            Else

                Query = "UPDATE tbl_mata_kuliah set nama_mtk='" & txtNMTK.Text & "',sks='" & txtSKS.Text & "'where kode_mtk='" & txtMTK.Text & "'"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                MsgBox("Data Berhasil Disimpan!", MsgBoxStyle.Critical, "SAVE")
                txtMTK.Focus()
                IsiList()
            End If

        Catch ex As Exception
            MsgBox("NiM Sudah Ada!", MsgBoxStyle.Critical, "Error")
            txtMTK.Focus()
        End Try
    End Sub
    Private Sub Caridata()
        Dim a As Integer
        Try
            Query = "SELECT * FROM tbl_mata_kuliah WHERE kode_mtk LIKE '%" & Trim(txtCari.Text) & "%' OR nama_mtk LIKE '%" & Trim(txtCari.Text) & "%';"
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

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Bersih()
        Caridata()
    End Sub
    Private Sub AmbilDataListview()
        'mengambil data dari list view
        With ListView1.SelectedItems
            Try
                txtMTK.Text = .Item(0).SubItems(0).Text
                txtNMTK.Text = .Item(0).SubItems(1).Text
                txtSKS.Text = .Item(0).SubItems(2).Text

            Catch ex As Exception

            End Try

        End With


    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        AmbilDataListview()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Bersih()
        Caridata()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim A As String
            A = MsgBox("Benar data mau dihapus...?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Hapus Data")
            Select Case A
                Case vbCancel
                    txtMTK.Focus()
                Case vbOK
                    If txtMTK.Text = "" Then
                        MsgBox("Input kode mtk Yang Akan di Hapus", MsgBoxStyle.Critical, "Data Kosong")
                        txtMTK.Focus()
                    Else
                        Query = "DELETE FROM tbl_mata_kuliah WHERE kode_mtk='" & txtMTK.Text & "'"
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
        Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        jam.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        jam.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub jam_Click(sender As Object, e As EventArgs) Handles jam.Click

    End Sub
End Class