Public Class ValidasiKarakter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Len(Me.TextBox1.Text) < 5 Or Len(Me.TextBox1.Text) > 10 Then
            MsgBox("input minimal 5 maksimal 10", MsgBoxStyle.Critical, "INFORMASI")
        Else
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Len(Me.TextBox3.Text) < 5 Or Len(Me.TextBox3.Text) > 10 Then
            MsgBox("input minimal 5 maksimal 10", MsgBoxStyle.Critical, "INFORMASI")
        Else
            TextBox2.Focus()
        End If
    End Sub
End Class