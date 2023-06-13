Public Class Menu
    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnmenu1_Click(sender As Object, e As EventArgs) Handles btnmenu1.Click
        switchPanel(Menu1)
    End Sub

    Private Sub btnmenu2_Click(sender As Object, e As EventArgs) Handles btnmenu2.Click
        switchPanel(Menu2)
    End Sub

    Private Sub btnmenu3_Click(sender As Object, e As EventArgs) Handles btnmenu3.Click
        switchPanel(Menu3)
    End Sub
End Class