Public Class FormQCodevb
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim generate As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
        Try
            PictureBox1.Image = generate.Encode(TextBox1.Text)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class