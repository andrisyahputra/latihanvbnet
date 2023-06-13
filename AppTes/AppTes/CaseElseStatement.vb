Public Class CaseElseStatement
    Private Sub btnTCase_Click(sender As Object, e As EventArgs) Handles btnTCase.Click
        'Dim mystate, MyResp As String
        'mystate = TextBox1.Text
        'Select Case mystate
        '    Case 1
        '        MyResp = "COBA SATU"
        '    Case 2
        '        MyResp = "COBA DUA"
        '    Case 3
        '        MyResp = "COBA TIGA"
        '    Case Else
        '        MyResp = "cOBA COBA"
        'End Select
        'MessageBox.Show(MyResp)

        'kasus kedua

        Dim mystate As Integer
        Dim MyResp As String

        mystate = Val(TextBox1.Text)

        Select Case mystate
            Case 1 To 5
                MyResp = "1 SAMPAI 5"
            Case 5 To 10
                MyResp = "6 SAMPAI 10"
            Case 10 To 15
                MyResp = "11 SAMPAI 15"
            Case Else
                MyResp = "DLL"
        End Select
        MessageBox.Show(MyResp)
    End Sub
End Class