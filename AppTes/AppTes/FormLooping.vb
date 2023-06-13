Public Class FormLooping
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim im As Integer
        'For im = 1 To 100
        '    ComboBox1.Items.Add(im)
        'Next

        'ini  lebih lebih sederhana

        'For im As Integer = 1 To 200
        '    ComboBox1.Items.Add(im)
        'Next

        'ini jika keluar dari loop
        'dimaksud
        'Index | Value
        '0 =      1
        '1 =      2
        '2 =      3
        '3 =      4
        '4 =      5
        '5 =      6

        'For im As Integer = 1 To 200
        '    If ComboBox1.Items.IndexOf(5) = 4 Then
        '        Exit For
        '    End If

        '    ComboBox1.Items.Add(im)
        'Next

        'buat tahun sebulum 45 sampai sekarang 

        'For im = DateTime.Now.Year - 45 To DateTime.Now.Year
        '    ComboBox1.Items.Add(im)
        'Next

        ' buat  tipe for tipe
        'Dim mynum As String() = {"a1", "b2", "b3"}
        'For Each mynum2 In mynum
        '    ComboBox1.Items.Add(mynum2)
        'Next

        'for each dalam for each

        Dim mynum As String() = {"a1", "b2", "b3"}
        Dim yournum As Integer() = {"100", "200", "300"}
        For Each mynum2 In mynum
            For Each yournum2 In yournum

                ComboBox1.Items.Add(mynum2 & " " & yournum2)
            Next
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Items.Clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Dim ff As String
        'ff = ComboBox1.SelectedIndex
        'MessageBox.Show(ff)
    End Sub
End Class