Imports MySql.Data.MySqlClient

Public Class login
#Region "declare"
    Dim mycmd As New MySqlCommand
    Dim myconnection As New DTConnection
    Dim objreader As MySqlDataReader
#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If Not TXTNAMA.Text.Length >= 5 Or Not TXTPASSWORD.Text.Length >= 5 Then
                MessageBox.Show("Username atau Password Minimal 5 huruf atau angka")
            ElseIf TXTNAMA.Text = "" Or TXTPASSWORD.Text = "" Then
                MessageBox.Show("Username atau Password Masih Kosong")
            Else
                mycmd.Connection = myconnection.open
                mycmd.CommandText = "select * from tb_testing where nama='" & TXTNAMA.Text & "' and pwd='" & TXTPASSWORD.Text & "'"
                objreader = mycmd.ExecuteReader
                objreader.Read()
                If objreader.HasRows = True Then
                    'FormMenu.LABELNAMA.Text = objreader.Item("nama")
                    FormLoading.Show()
                    Me.Hide()
                    'FormMenu.Show()
                Else
                    mycmd.Connection = myconnection.close
                    MsgBox("Password atau Username Salah!!", MsgBoxStyle.Critical, "GAGAL LOGIN!!")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




End Class
