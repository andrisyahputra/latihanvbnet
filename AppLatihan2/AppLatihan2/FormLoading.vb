Public Class FormLoading
    Private Sub TLOAD_Tick(sender As Object, e As EventArgs) Handles TLOAD.Tick
        Dim i As Double
        Static ictr As Integer

        For i = 1 To 100
            LLOAD.Text = PLOAD.Value
        Next

        If ictr <= 100 Then
            PLOAD.Value = ictr
            ictr = ictr + 1
        Else
            'FormUser.Show()
            FormMenu.Show()
            login.Hide()
            Me.Close()
        End If
    End Sub

    Private Sub FormLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LLOAD.Font = myfont.getInstance(48, FontStyle.Italic)
        'transparent
        Me.BackColor = Nothing
        TransparencyKey = BackColor
    End Sub
End Class