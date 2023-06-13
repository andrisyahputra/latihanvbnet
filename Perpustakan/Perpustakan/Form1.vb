Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Halaman.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pesan
        pesan = MsgBox("Benearkan menutup aplikasi?", vbYesNo + vbQuestion, "Konfirmasi")
        If pesan = vbYes Then
            End
        End If
    End Sub
End Class
