Public Class FormLogika
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click

        If TxtAngka1.Text = "" Or TxtAngka2.Text = "" Then
            MsgBox("Wajib diisi")
            Exit Sub
        Else
            TxtHasil.Text = Val(TxtAngka1.Text) * Val(TxtAngka2.Text)
            If Val(TxtHasil.Text) > 15 Then
                lblLogic.Text = "Angka Lebih dari 15"
                Exit Sub
            ElseIf Val(TxtHasil.Text) = 15 Then
                lblLogic.Text = "Benar hasil ini 15"
                Exit Sub
            Else
                lblLogic.Text = "Angka kurang dari 15"
                Exit Sub
            End If
            Exit Sub
        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        End
    End Sub
End Class