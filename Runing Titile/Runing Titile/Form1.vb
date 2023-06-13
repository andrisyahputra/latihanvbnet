Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Text = Me.Text.Substring(1) & Me.Text.Substring(0, 1)
    End Sub
End Class
