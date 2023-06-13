Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tc As New DTConnection
        Try
            tc.open()
            MsgBox("Koneksi Berhasil")
            tc.close()
        Catch ex As Exception
            MsgBox("Gagal koneksi")
            tc.close()
        End Try
    End Sub
End Class
