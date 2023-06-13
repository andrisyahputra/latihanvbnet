Public Class SaveDataGunakanDataBinding
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TXTUSER.Text <> My.Settings.MyUserName) Or (TXTPASSWORD.Text <> My.Settings.MyPassword) Then
            MsgBox("Username or passeord salah" & vbCrLf & "Contack admin", MsgBoxStyle.Information, "NOTIFIKASI")
        Else
            FormUser.Show()
        End If
    End Sub
End Class