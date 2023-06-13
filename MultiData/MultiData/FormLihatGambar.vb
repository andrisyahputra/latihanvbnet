Imports MySql.Data.MySqlClient
Imports System.IO
Public Class FormLihatGambar
    Private Sub FormLihatGambar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call KoneksiKeDatabase()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FormAddImage.ShowDialog()
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Query = "SELECT * FROM tbl_gambar WHERE kode like '" & TextBox1.Text & "'"
            cmd = New MySqlCommand(Query, Conn)
            RD = cmd.ExecuteReader
            RD.Read()
            Try
                Dim gambar() As Byte
                If RD.HasRows() Then
                    gambar = RD("FILE")

                    Dim ms As New MemoryStream(gambar)
                    PictureBox1.Image = Image.FromStream(ms)
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                End If
                RD.Close()
            Catch ex As Exception
                MessageBox.Show("EROR : " & ex.Message, "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            If TextBox1.Text = "" Then
                PictureBox1.Image = Nothing
            End If

        End If
    End Sub
End Class