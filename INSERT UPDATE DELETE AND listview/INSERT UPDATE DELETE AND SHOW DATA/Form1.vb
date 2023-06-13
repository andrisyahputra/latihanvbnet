Imports MySql.Data.MySqlClient
Public Class Form1
#Region "declare"
    Dim mycmd As New MySqlCommand
    Dim myconnection As New DTConnection
    Dim objreader As MySqlDataReader
#End Region


    Private Sub BUTTONINSERT_Click(sender As Object, e As EventArgs) Handles BUTTONINSERT.Click
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "INSERT INTO tb_testing(id,nama) values('" & TXTID.Text & "','" & TXTNAMA.Text & "')"
        mycmd.ExecuteNonQuery()
        myconnection.close()
        MsgBox("Berhasil Tambah", MsgBoxStyle.Information, "PESAN")
    End Sub

    Private Sub BUTTONUPDATE_Click(sender As Object, e As EventArgs) Handles BUTTONUPDATE.Click
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "update tb_testing set nama='" & TXTNAMA.Text & "' where id='" & TXTID.Text & "'"
        mycmd.ExecuteNonQuery()
        myconnection.close()
        MsgBox("Berhasil Ubah", MsgBoxStyle.Information, "PESAN")
    End Sub

    Private Sub BUTTONDELETE_Click(sender As Object, e As EventArgs) Handles BUTTONDELETE.Click
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "DELETE FROM `tb_testing` WHERE id='" & TXTID.Text & "'"
        mycmd.ExecuteNonQuery()
        myconnection.close()
        MsgBox("Berhasil Hapus", MsgBoxStyle.Information, "PESAN")
    End Sub

    Private Sub BUTTONSHOW_Click(sender As Object, e As EventArgs) Handles BUTTONSHOW.Click
        Dim isi As ListViewItem
        LISTSHOW.Items.Clear()
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "SELECT * FROM `tb_testing`"
        objreader = mycmd.ExecuteReader
        While objreader.Read
            isi = LISTSHOW.Items.Add(objreader.Item("id").ToString)
            isi.SubItems.Add(objreader.Item("nama").ToString)
        End While
        myconnection.close()
    End Sub

    Private Sub LISTSHOW_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LISTSHOW.SelectedIndexChanged
        Dim index As Integer
        If LISTSHOW.SelectedItems.Count = 0 Then Exit Sub
        With LISTSHOW
            index = .SelectedIndices(0)
            TXTID.Text = .Items(index).Text
            TXTNAMA.Text = .Items(index).SubItems(1).Text
        End With
    End Sub
End Class
