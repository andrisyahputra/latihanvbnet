Public Class FormPilihan
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.Text = "Promo 1" Then
            TxtNamaPromo.Text = "Nasi Padang + Capucino"
            txtHarga.Text = "20000"
            TxtBayar.Clear()
            TxtKembalian.Clear()
        ElseIf ComboBox1.Text = "Promo 2" Then
            TxtNamaPromo.Text = "Nasi Gurih + Teh"
            txtHarga.Text = "15000"
            TxtBayar.Clear()
            TxtKembalian.Clear()
        ElseIf ComboBox1.Text = "Promo " Then
            TxtNamaPromo.Text = "Nasi putih + Air"
            txtHarga.Text = "10000"
            TxtBayar.Clear()
            TxtKembalian.Clear()
        End If

    End Sub

    Private Sub FormPilihan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Items.Add("Pilih Promo")
        ComboBox1.Items.Add("Promo 1")
        ComboBox1.Items.Add("Promo 2")
        ComboBox1.Items.Add("Promo 3")
        ComboBox1.SelectedItem = "Pilih Promo"
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        End
    End Sub

    Private Sub TxtBayar_TextChanged(sender As Object, e As EventArgs) Handles TxtBayar.TextChanged
        TxtKembalian.Text = Val(TxtBayar.Text) - Val(txtHarga.Text)
    End Sub
End Class