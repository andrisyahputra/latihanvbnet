Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FormAddImage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pathfile As String = Nothing

        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg*"
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        pathfile = OpenFileDialog1.FileName

        TextBox2.Text = pathfile.Substring(pathfile.LastIndexOf("\") + 1)
        Label1.Text = OpenFileDialog1.FileName

        PictureBox1.Image = Image.FromFile(Label1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ms As New MemoryStream
        Try
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Catch ex As Exception
            MessageBox.Show("ERORR" & ex.Message, "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        cmd = New MySqlCommand
        cmd.Connection = Conn
        Query = "INSERT INTO `tbl_gambar`(`kode`, `nama`, `file`) VALUES (@kode,@nama,@foto)"

        cmd.Parameters.Add("@kode", MySqlDbType.UInt64).Value = TextBox1.Text
        cmd.Parameters.Add("@nama", MySqlDbType.VarChar).Value = TextBox2.Text
        cmd.Parameters.Add("@foto", MySqlDbType.Blob).Value = ms.ToArray()
        cmd.CommandText = Query
        Try
            cmd.ExecuteNonQuery()
            MsgBox("INPUT GAMBAR BERHASIL", vbInformation)
            kosongdata()
        Catch ex As Exception
            MessageBox.Show("ERORR" & ex.Message, "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub kosongdata()
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label1.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub FormAddImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiKeDatabase()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FormLihatGambar.ShowDialog()
        Me.Close()
    End Sub
End Class