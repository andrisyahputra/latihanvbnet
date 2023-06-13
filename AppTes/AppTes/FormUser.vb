Public Class FormUser
    Private Sub BTNCHANGEPASS_Click(sender As Object, e As EventArgs) Handles BTNCHANGEPASS.Click
        My.Settings.MyUserName = TextBox1.Text
        My.Settings.MyPassword = TextBox2.Text


        MsgBox("Password sudah terganti" & vbCrLf & "Contack admin", MsgBoxStyle.Information, "NOTIFIKASI")
        My.Settings.Save()

    End Sub
End Class