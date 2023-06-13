Public Class FormPrint
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strPrint As String
        strPrint = "COba store & Coffe" & vbCrLf
        strPrint = strPrint & "----------------------------------" & vbCrLf
        strPrint = strPrint & "No : TN1254389" & vbCrLf
        strPrint = strPrint & " " & vbCrLf
        strPrint = strPrint & "Nama     Qty. Const SubTotal" & vbCrLf
        strPrint = strPrint & "----------------------------------" & vbCrLf
        strPrint = strPrint & "Source   2    5000    10000" & vbCrLf
        strPrint = strPrint & "Source   2    5000    10000" & vbCrLf
        strPrint = strPrint & "Source   2    5000    10000" & vbCrLf
        strPrint = strPrint & "----------------------------------" & vbCrLf
        strPrint = strPrint & "Total" & vbCrLf
        Printer.Print(strPrint)
    End Sub
End Class