Imports System.Data.Odbc

Public Class FormLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TxtNama.Text = "" Or TextPwd.Text = "" Then
            MessageBox.Show("Username atau Password Masih Kosong")
        Else
            Call koneksi()
            CMD = New OdbcCommand("select * from tbl_user where user_name='" & TxtNama.Text & "' and pwd='" & TextPwd.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows = True Then
                Me.Hide()
                Form_Menu.Show()
            Else
                MessageBox.Show("Password dan Username Salah !!!")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtNama.Text = ""
        TextPwd.Text = ""
        TxtNama.Focus()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class