Public Class LoopingDoWhile
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim myIndex As Integer = 0 'variabel

        'Do While myIndex < 100 'kondisi
        '    myIndex += 1 'statement
        '    ComboBox1.Items.Add(myIndex) 'statement
        'Loop

        'Do  'kondisi
        '    myIndex += 1 'statement
        '    ComboBox1.Items.Add(myIndex) 'statement
        'Loop While myIndex < 100

        'Do While myIndex < 100 'kondisi
        '    myIndex += 1 'statement
        '    ComboBox1.Items.Add(myIndex) 'statement


        '    If myIndex < 5 Then
        '        Continue Do
        '    ElseIf myIndex = 50 Then
        '        Exit Do
        '    End If
        'Loop

        Dim myWhile As Integer = 0
        While myWhile < 100 'kondisi
            myWhile += 2 'statement
            ComboBox1.Items.Add(myWhile) 'statement
            If myWhile = 14 Then
                Exit While
            End If
        End While
    End Sub
End Class