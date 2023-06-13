Public Class FormMessage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim exMessage As Integer = MessageBox.Show("Ini pesan", "Notfikasi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
        If exMessage = DialogResult.Yes Then
            MessageBox.Show("User Select Yes")
        ElseIf exMessage = DialogResult.No Then
            MessageBox.Show("User Select No")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Ini Pesan", MsgBoxStyle.Exclamation, "Notif ....")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("this example of warning" & vbCrLf & "By admin", MsgBoxStyle.Critical, "Careful")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim i As Integer = 0
            Button4.Text = i + "Salah"
        Catch ex As Exception
            MsgBox(" Program Eror: " & ex.Message, MsgBoxStyle.Information, "Informasi")
        End Try
    End Sub
End Class