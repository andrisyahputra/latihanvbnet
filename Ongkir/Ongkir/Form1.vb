Imports RestSharp
Imports Newtonsoft.Json.Linq
Public Class Form1
    Dim apiKey As String = "d2bb878d91c40259cf6d56680055ca35"
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("JNE")
        ComboBox1.Items.Add("POS")
        ComboBox1.Items.Add("TIKI")
    End Sub
End Class
