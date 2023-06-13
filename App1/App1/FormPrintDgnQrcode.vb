Imports System.Drawing.Printing

Public Class FormPrintDgnQrcode
    Dim WithEvents PD2 As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim Longpaper As Integer

    Private Sub PD2_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PD2.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 500) 'fixed long paper
        'pagesetup.PaperSize = New PaperSize("Custom", 250, Longpaper)
        PD2.DefaultPageSettings = pagesetup
    End Sub
    Private Sub PD2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PD2.PrintPage
        Try
            Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
            Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
            Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
            Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

            Dim leftmargin As Integer = PD2.DefaultPageSettings.Margins.Left
            Dim centermargin As Integer = PD2.DefaultPageSettings.PaperSize.Width / 2
            Dim rightmargin As Integer = PD2.DefaultPageSettings.PaperSize.Width

            'font alignment
            Dim right As New StringFormat
            Dim center As New StringFormat
            right.Alignment = StringAlignment.Far
            center.Alignment = StringAlignment.Center

            Dim line As String
            line = "***************************************************************************"
            'e.Graphics.DrawString("Coba Stroe", f14, Brushes.Black, centermargin, 5, center)
            Dim logo As Image = My.Resources.ResourceManager.GetObject("tanki")
            e.Graphics.DrawImage(logo, CInt((e.PageBounds.Width - 150) / 2), 5, 150, 35)
            e.Graphics.DrawString("New York", f10, Brushes.Black, centermargin, 40, center)
            e.Graphics.DrawString("TEL +1987", f8, Brushes.Black, centermargin, 55, center)

            e.Graphics.DrawString("Invoice ID", f8, Brushes.Black, 0, 75)
            e.Graphics.DrawString(":", f8, Brushes.Black, 50, 75)
            e.Graphics.DrawString("KFGS1654", f8, Brushes.Black, 70, 75)

            e.Graphics.DrawString("Cashier", f8, Brushes.Black, 0, 85)
            e.Graphics.DrawString(":", f8, Brushes.Black, 50, 85)
            e.Graphics.DrawString("Andri", f8, Brushes.Black, 70, 85)

            e.Graphics.DrawString(Today, f8, Brushes.Black, 0, 95)

            e.Graphics.DrawString(line, f8, Brushes.Black, 0, 115)

            Dim height As Integer
            Dim i As Long
            DataGridView1.AllowUserToAddRows = False
            For row As Integer = 0 To DataGridView1.RowCount - 1
                height += 15
                e.Graphics.DrawString(DataGridView1.Rows(row).Cells(1).Value.ToString, f10, Brushes.Black, 0, 115 + height)
                e.Graphics.DrawString(DataGridView1.Rows(row).Cells(0).Value.ToString, f10, Brushes.Black, 25, 115 + height)

                i = DataGridView1.Rows(row).Cells(2).Value
                DataGridView1.Rows(row).Cells(2).Value = Format(i, "##,##0")
                e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString, f10, Brushes.Black, rightmargin, 115 + height, right)

            Next

            Dim height2 As Integer
            total()

            height2 = 140 + height
            e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
            e.Graphics.DrawString("Total :" & Format(t_price, "##,##0"), f10b, Brushes.Black, rightmargin, 15 + height2, right)
            e.Graphics.DrawString(t_qty, f10b, Brushes.Black, 0, 15 + height2)


            'bercode
            Dim qrCode As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
            Try
                Dim qrCodeImage As Image
                qrCodeImage = New Bitmap(qrCode.Encode("KFGS1654"))
                e.Graphics.DrawImage(qrCodeImage, CInt((e.PageBounds.Width - 60) / 2), 60 + height2, 60, 60)
            Catch ex As Exception
                MsgBox(ex.Message, "EROR")
            End Try
            e.Graphics.DrawString("~~ TERIMAKASIH ~~", f10b, Brushes.Black, centermargin, 120 + height2, center)
            e.Graphics.DrawString("~~ STORE ~~", f10b, Brushes.Black, centermargin, 135 + height2, center)
        Catch ex As Exception

        End Try


    End Sub
    Dim t_price As Long
    Dim t_qty As Long

    Sub total()
        Dim countprince As Long = 0
        For rowItem As Long = 0 To DataGridView1.RowCount - 1
            countprince = countprince + Val(DataGridView1.Rows(rowItem).Cells(2).Value * Val(DataGridView1.Rows(rowItem).Cells(1).Value))
        Next
        t_price = countprince

        Dim countqty As Long
        For rowItem As Long = 0 To DataGridView1.RowCount - 1
            countqty = countqty + Val(DataGridView1.Rows(rowItem).Cells(1).Value)
        Next
        t_qty = countqty
    End Sub

    Private Sub changelongpaper()
        Dim rowcount As Integer
        Longpaper = 0
        rowcount = DataGridView1.Rows.Count
        Longpaper = rowcount * 15
        Longpaper = Longpaper + 210
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        changelongpaper()
        PPD.Document = PD2
        PPD.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.AllowUserToAddRows = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'changelongpaper()
        'PPD.Document = PD2
        'PPD.PrintPreviewControl(PPD.Document)
    End Sub
End Class