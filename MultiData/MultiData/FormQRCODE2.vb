Public Class FormQRCODE2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gbarcode As New MessagingToolkit.barcode.barcodeEncoder
        Try
            PictureBox1.Image = New Bitmap(gbarcode.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, TextBox1.Text))
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
End Class