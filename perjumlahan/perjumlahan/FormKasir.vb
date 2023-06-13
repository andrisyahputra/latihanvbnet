Public Class FormKasir
    Private Sub FormKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NamaPromo As String
        Dim Promo() As String = {"Promo 1", "Promo 2", "Promo 3"}
        For Each NamaPromo In Promo
            ComboBox1.Items.Add(NamaPromo)
        Next
        Dim i As Integer
        For i = 1 To 10
            ComboBox2.Items.Add(i)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Promo 1" Then
            TextBox1.Text = "Ayam Penyet & Teh"
            TextBox2.Text = "2500"
            TextBayar.Clear()
            TextKembalian.Clear()
            ComboBox2.Text = ""
            TxtTotal.Clear()
        ElseIf ComboBox1.Text = "Promo 2" Then
            TextBox1.Text = "Nasgor & Teh"
            TextBox2.Text = "1500"
            TextBayar.Clear()
            TextKembalian.Clear()
            ComboBox2.Text = ""
            TxtTotal.Clear()
        ElseIf ComboBox1.Text = "Promo 3" Then
            TextBox1.Text = "Nasi Padang & Teh"
            TextBox2.Text = "1000"
            TextBayar.Clear()
            TextKembalian.Clear()
            ComboBox2.Text = ""
            TxtTotal.Clear()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If TextBox1.Text = "" Or
                TextBox2.Text = "" Then
            MsgBox("Belum ada promo")
        Else
            TxtTotal.Text = Val(TextBox2.Text) * Val(ComboBox2.Text)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextKembalian.Text = Val(TextBayar.Text) - Val(TxtTotal.Text)
    End Sub
End Class