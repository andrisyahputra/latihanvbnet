Public Class Halaman
    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim pesan
        pesan = MsgBox("Benarkah mau keluar?", vbYesNo + vbQuestion, "KONFIRMASI")
        If pesan = vbYes Then
            End
        End If
    End Sub
End Class