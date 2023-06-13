Imports MySql.Data.MySqlClient

Public Class FormCariMtk
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
        End With
    End Sub

    Private Sub FormCariMtk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiKeDatabase()
        IsiList()
        PosisiList()
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
                End With
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Caridata()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Caridata()
    End Sub
    Private Sub AmbilDataListview()
        'mengambil data dari list view
        With ListView1.SelectedItems
            Try
                FormNilai.txtMTK.Text = .Item(0).SubItems(0).Text
                FormNilai.txtNMTK.Text = .Item(0).SubItems(1).Text
                FormNilai.txtSKS.Text = .Item(0).SubItems(2).Text

            Catch ex As Exception

            End Try

        End With


    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        AmbilDataListview()
        Me.Close()
    End Sub
End Class