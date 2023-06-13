Public Class Form1
    Dim _book As String 'tidak disarankan
    Dim book As String 'disaran kan

    Dim MyBags$ ' string
    Dim myMoney@ 'decimal
    Dim myNumber! 'sigle
    Dim MyNum% 'integer
    Dim NumMy& 'long true atau false
    Dim YouNum# 'double



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox1
            .Items.Add("Tambah")
            .Items.Add("Kurang")
        End With
    End Sub
End Class
