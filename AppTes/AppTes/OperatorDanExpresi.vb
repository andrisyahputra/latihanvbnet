Public Class OperatorDanExpresi
    Private Sub BtnResult_Click(sender As Object, e As EventArgs) Handles BtnResult.Click
        'aritmatika + - * /
        'lblResult.Text = Val(txt1.Text) + Val(txt2.Text)
        'compration expresi
        'If Val(txt1.Text) = Val(txt2.Text) Then 'angka yg sama
        '< kecil
        '> besar
        '<= kecil sama dgn berapa
        '& untuk menambhakan text
        If Val(txt1.Text) <> Val(txt2.Text) Then 'lawanya
            lblResult.Text = "T"
        Else
            lblResult.Text = "F"
        End If
    End Sub
End Class