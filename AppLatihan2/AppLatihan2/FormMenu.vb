Imports MySql.Data.MySqlClient

Public Class FormMenu
#Region "declare"
    Dim mycmd As New MySqlCommand
    Dim myconnection As New DTConnection
    Dim objdatareader As MySqlDataReader
    Dim kdform As String
#End Region


    Private Sub MenuUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuUserToolStripMenuItem.Click
        'FormUser.Show()
        mycmd.Connection = myconnection.open
        kdform = "FUSER"
        mycmd.CommandText = "select BTSAVE,BTUPDATE,BTDELETE from tbl_privileges where formcode='" & kdform & "' and occupation='" & CMBPILIHAN.Text & "'and FOPEN='" & "Y" & "'"
        objdatareader = mycmd.ExecuteReader
        If objdatareader.HasRows = 0 Then
            MsgBox("Tidak bisa akses" & vbCrLf & "Hanya Admin", MsgBoxStyle.Exclamation, "Pesan")
            myconnection.close()
        Else
            myconnection.close()
            mycmd.Connection = myconnection.open
            objdatareader = mycmd.ExecuteReader
            While objdatareader.Read
                If (Trim(objdatareader(0)) = "Y") Then
                    FormUser.BTNSAVE.Enabled = True
                Else
                    FormUser.BTNSAVE.Enabled = False
                End If

                If (Trim(objdatareader(1)) = "Y") Then
                    FormUser.BTNUPDATE.Enabled = True
                Else
                    FormUser.BTNUPDATE.Enabled = False
                End If

                If (Trim(objdatareader(2)) = "Y") Then
                    FormUser.BTNDELETE.Enabled = True
                Else
                    FormUser.BTNDELETE.Enabled = False
                End If
            End While
            FormUser.Show()
        End If
        myconnection.close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class