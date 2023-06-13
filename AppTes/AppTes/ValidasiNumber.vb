Public Class ValidasiNumber
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If Not IsNumeric(TextBox1.Text) Then
        '    If TextBox1.Text <> "" Then
        '        MsgBox("NOTIF", MsgBoxStyle.Information, "HANYA BOLEH ANGKA")
        '        TextBox1.Text = ""
        '    End If
        'Else
        '    lblResut.Text = "SUKSES"
        'End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Not IsNumeric(TextBox1.Text) Then
            If TextBox1.Text <> "" Then
                MsgBox("NOTIF", MsgBoxStyle.Information, "HANYA BOLEH ANGKA")
                'TextBox1.Text = ""
                TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
            End If
        Else
            lblResut.Text = "SUKSES"
        End If
    End Sub

    Private Sub ValidasiNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 0 To 255
            ListBox1.Items.Add("Decimal " & i & " Crakter :" & Chr(i))
        Next


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'If e.KeyChar = Chr(45) Or e.KeyChar = Chr(13) Then
        '    e.KeyChar = Chr(0)
        '    MsgBox("Notif handle by keypress minus -")
        'End If

        If e.KeyChar = Chr(45) Then
            e.KeyChar = Chr(0)
            MsgBox("Notif handle by keypress minus -")
        End If

    End Sub

    Private Sub ValidasiNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class