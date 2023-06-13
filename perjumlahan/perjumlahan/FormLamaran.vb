Public Class FormLamaran
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        End
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtJurusan.SelectedIndexChanged

    End Sub

    Private Sub FormLamaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtJurusan.Items.Add("Teknik Informatika")
        TxtJurusan.Items.Add("Sistem Informasi")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles simpan.Click
        DataGridView1.Rows.Add(1)
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = TxtNama.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = TxtTTGL.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(3).Value = TxtNama.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(4).Value = TxtNama.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(5).Value = TxtNama.Text
    End Sub
End Class