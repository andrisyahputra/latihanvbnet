Imports MySql.Data.MySqlClient
Public Class FormCariMhs
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
            Next
        Catch ex As Exception

        End Try

    End Sub
    Private Sub AmbilDataListview()
        'mengambil data dari list view
        With ListView1.SelectedItems
            Try
                FormNilai.txtNim.Text = .Item(0).SubItems(0).Text
                FormNilai.txtMHS.Text = .Item(0).SubItems(1).Text
            Catch ex As Exception

            End Try

        End With


    End Sub

    Private Sub FormCariMhs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiKeDatabase()
        PosisiList()
        IsiList()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Caridata()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Caridata()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        AmbilDataListview()
        Me.Close()
    End Sub
End Class