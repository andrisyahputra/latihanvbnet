﻿Imports System.Drawing.Printing
Public Class printjual
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim Longpaper As Integer

    Private Sub changelongpaper()
        Dim rowcount As Integer
        Longpaper = 0
        rowcount = DataGridView1.Rows.Count
        Longpaper = rowcount * 15
        Longpaper = Longpaper + 210
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        'pagesetup.PaperSize = New PaperSize("Custom", 250, 500) 'fixed long paper
        pagesetup.PaperSize = New PaperSize("Custom", 250, Longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "--------------------------------------------------------------------------"
        e.Graphics.DrawString("Coba Stroe", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("New York", f10, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("TEL +1987", f8, Brushes.Black, centermargin, 40, center)

        e.Graphics.DrawString("Invoice ID", f8, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 60)
        e.Graphics.DrawString("KFGS1654", f8, Brushes.Black, 70, 60)

        e.Graphics.DrawString("Cashier", f8, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 75)
        e.Graphics.DrawString("Andri", f8, Brushes.Black, 70, 75)

        e.Graphics.DrawString(Today, f8, Brushes.Black, 0, 90)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 100)

        Dim height As Integer
        Dim i As Long
        DataGridView1.AllowUserToAddRows = False
        For row As Integer = 0 To DataGridView1.RowCount - 1
            height += 15
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(1).Value.ToString, f10, Brushes.Black, 0, 100 + height)
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(0).Value.ToString, f10, Brushes.Black, 25, 100 + height)

            i = DataGridView1.Rows(row).Cells(2).Value
            DataGridView1.Rows(row).Cells(2).Value = Format(i, "##,##0")
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString, f10, Brushes.Black, rightmargin, 100 + height, right)

        Next

        Dim height2 As Integer
        total()

        height2 = 110 + height
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("Total :" & Format(t_price, "##,##0"), f10b, Brushes.Black, rightmargin, 15 + height2, right)
        e.Graphics.DrawString(t_qty, f10b, Brushes.Black, 0, 15 + height2)

        e.Graphics.DrawString("~~ TERIMAKASIH ~~", f10b, Brushes.Black, centermargin, 40 + height2, center)
        e.Graphics.DrawString("~~ STORE ~~", f10b, Brushes.Black, centermargin, 55 + height2, center)


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

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        changelongpaper()
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

End Class
