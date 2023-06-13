Imports MySql.Data.MySqlClient

Public Class FormCariDosen
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
    Private Sub AmbilDataListview()
        'mengambil data dari list view
        With ListView1.SelectedItems
            Try
                FormNilai.txtNidn.Text = .Item(0).SubItems(0).Text
                FormNilai.txtNDosen.Text = .Item(0).SubItems(1).Text

            Catch ex As Exception

            End Try

        End With


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Caridata()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Caridata()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        AmbilDataListview()
        Dispose()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Hide()
    End Sub
End Class