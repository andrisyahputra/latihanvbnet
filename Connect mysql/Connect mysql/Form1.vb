Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim McN As New DTConennection

        Try
            McN.open()
            MsgBox("Koneksi Berhasil")
            McN.close()
        Catch ex As Exception
            MsgBox(ex.Message, "Gagal Koneksi")
            McN.close()
        End Try
    End Sub
End Class
