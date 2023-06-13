Public Class FormArray
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nomor(3) As String

        'value
        nomor(0) = "Andri"
        nomor(1) = "Andri2"
        nomor(2) = "Andri3"
        nomor(3) = "Andri4"

        'clear combo box
        ComboBox1.Items.Clear()

        'isi combobox
        For i As Integer = 0 To nomor.Length - 1
            ComboBox1.Items.Add(nomor(i))
        Next
    End Sub
End Class