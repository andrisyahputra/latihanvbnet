Public Class FormUser
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Font = myfont.getInstance(48, FontStyle.Regular)

        Dim user As String
        user = login.TXTNAMA.Text
        Label1.Text = "Hello, " & user
    End Sub
End Class