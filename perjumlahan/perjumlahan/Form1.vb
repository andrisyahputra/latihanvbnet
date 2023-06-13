Public Class Form1
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        TxtJumlah.Text = Val(TxtAngka1.Text) + Val(TxtAngka2.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtAngka1.Focus()
    End Sub

    Private Sub BtnKurang_Click(sender As Object, e As EventArgs) Handles BtnKurang.Click
        TxtJumlah.Text = Val(TxtAngka1.Text) - Val(TxtAngka2.Text)
    End Sub

    Sub clear()
        TxtAngka1.Clear()
        TxtAngka2.Clear()
        TxtJumlah.Clear()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Call clear()
    End Sub

    Private Sub BtnKali_Click(sender As Object, e As EventArgs) Handles BtnKali.Click
        TxtJumlah.Text = Val(TxtAngka1.Text) * Val(TxtAngka2.Text)
    End Sub

    Private Sub BtnBagi_Click(sender As Object, e As EventArgs) Handles BtnBagi.Click
        TxtJumlah.Text = Val(TxtAngka1.Text) / Val(TxtAngka2.Text)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        End
    End Sub
End Class
