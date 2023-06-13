Imports System.IO
Public Class FormODBC
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            Dim po As New Process
            Dim createPo As String

            createPo = "-s -a -cl -n """ & txtNdsn.Text & """ -t "" DRIVER=MySQL ODBC 8.0 ANSI Driver;SERVER=" & txtServer.Text & ";DATABASE=" & txtDB.Text & ";UID=" & txtUserId.Text & ";PWD=" & txtPwd.Text & """"
        Catch ex As Exception

        End Try
    End Sub
End Class