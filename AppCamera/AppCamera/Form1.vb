Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form1
    Dim camera As VideoCaptureDevice
    Dim bmp As Bitmap

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
            camera = cameras.VideoDevice
            AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            camera.Start()
        End If
    End Sub

    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox2.Image = PictureBox1.Image
        'Dim file_name As String = Application.ExecutablePath
        'file_name = file_name.Substring(0, file_name.LastIndexOf("\bin")) &
        '    "\test."

        '' Get a Bitmap.
        'Dim bm As Bitmap = PictureBox1.Image

        '' Save the picture as a bitmap, JPEG, and GIF.
        ''bm.Save(file_name & "bmp", System.Drawing.Imaging.ImageFormat.Bmp)
        'bm.Save(file_name & "jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        ''bm.Save(file_name & "gif", System.Drawing.Imaging.ImageFormat.Gif)
        'Dim img As Bitmap = PictureBox2.Image.Clone
        'img.Save("D:\tes\test.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        'MsgBox("Ok")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaveFileDialog1.DefaultExt = ".jpg"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox2.Image.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)

        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        camera.Stop()
    End Sub
    Private Sub kosongdata()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call KoneksiKeDatabase()

        cmd = New MySqlCommand
        cmd.Connection = Conn
        Query = "INSERT INTO `tbl_gambar`(`kode`, `nama`, `file`) VALUES (@kode,@nama,@foto)"
        Dim ms As New MemoryStream
        Dim bmpImage As New Bitmap(bmp)
        bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim data As Byte() = ms.GetBuffer()
        Dim p As New MySqlParameter("@foto", MySqlDbType.Blob)
        p.Value = data


        cmd.Parameters.Add("@kode", MySqlDbType.UInt64).Value = TextBox1.Text
        cmd.Parameters.Add("@nama", MySqlDbType.VarChar).Value = TextBox2.Text
        cmd.Parameters.Add(p)
        cmd.CommandText = Query
        Try
            cmd.ExecuteNonQuery()
            MsgBox("INPUT GAMBAR BERHASIL", vbInformation)
            kosongdata()
        Catch ex As Exception
            MessageBox.Show("ERORR" & ex.Message, "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        'untuk local otomatis
        'Dim img As Bitmap = PictureBox2.Image.Clone
        'img.Save("D:\tes\test.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

    End Sub
End Class
