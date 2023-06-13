Public Class FormHandleErorDgnTry
    Private Sub btnTryEror_Click(sender As Object, e As EventArgs) Handles btnTryEror.Click
        Try
            Dim xFalse As Integer = 123
            Dim yFalse As String = "WOW"
            Dim erorTest As Integer = xFalse + yFalse
            MessageBox.Show(erorTest)
        Catch ex As Exception
            MessageBox.Show("INI EROR, CHECK KODE EROR" _
                        & vbCrLf & ex.Message)
            'Exit Try
        Finally
            MessageBox.Show("SELALU DIEKSEKUSI")
        End Try
    End Sub
End Class