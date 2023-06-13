Public Class FunctionDanParameter

    Function Hello(ByVal names As String)
        Dim msg As String = "HELLO " & names
        Return msg
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pesanz As String
        Dim nama As String
        nama = ComboBox1.Text
        pesanz = Hello(nama)

        MessageBox.Show(pesanz)
    End Sub


    Private Sub FunctionDanParameter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox1
            .Items.Add("ANDRI")
            .Items.Add("ZIRO")
            .Items.Add("ANDRIMC")
        End With
    End Sub


End Class