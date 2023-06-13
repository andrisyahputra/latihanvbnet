Public Class FormComboBox
    Private Sub FormComboBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim a As Integer
        For i = 2015 To Year(Now)
            ComboBox1.Items.Add(i)
        Next
        For a = Year(Now) To 2015 Step -1 'pengulangan dari tahun sekarang mundur
            ComboBox2.Items.Add(a)
        Next
    End Sub
End Class