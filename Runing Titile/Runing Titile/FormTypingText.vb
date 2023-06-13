Public Class FormTypingText
    Private Sub typingText(ByVal word As String)
        Static nextChar As Integer
        Dim display As String
        Dim length As Integer
        nextChar = nextChar + 1
        length = length + 1
        display = Mid$(word, nextChar, length)
        Label1.Text = Label1.Text & display
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        typingText("SElamat Datang di pelatihan" & vbCrLf & "BY Andri")
    End Sub

    Private Sub FormTypingText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ""
    End Sub
End Class