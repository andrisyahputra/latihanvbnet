Public Class FormColorChangeDisableEnable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "MERAH" Then
            Me.BackColor = Color.Red
        ElseIf ComboBox1.Text = "KUNING" Then
            Me.BackColor = Color.Yellow
        ElseIf ComboBox1.Text = "HIJAU" Then
            Me.BackColor = Color.Green
        ElseIf ComboBox1.Text = "BIRU" Then
            Me.BackColor = Color.Blue
        ElseIf ComboBox1.Text = "HITAM" Then
            Me.BackColor = Color.Black
        Else
            Me.BackColor = Color.Empty
        End If
    End Sub
End Class