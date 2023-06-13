Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FormInsertIMG
#Region "declare"
    Dim mycmd As New MySqlCommand
    Dim myconection As New DTConnection
    Dim dadapter As MySqlDataAdapter
    Dim dtable As New DataTable
#End Region

#Region "ForGridView"
    Sub VwGridView()
        mycmd.Connection = myconection.open
        mycmd.CommandText = "SELECT * FROM `tb_img` ORDER BY id asc"
        dadapter = New MySqlDataAdapter(mycmd)
        dtable.Rows.Clear()
        dadapter.Fill(dtable)
        If Not dtable Is Nothing AndAlso dtable.Rows.Count > 0 Then
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = dtable
            DataGridView1.Columns(0).DataPropertyName = "id"
            DataGridView1.Columns(1).DataPropertyName = "nama"
            DataGridView1.Columns(2).DataPropertyName = "pwd"
        End If
    End Sub
#End Region

#Region "ClikGDV"
    Sub CLICKgRIDvIEW()
        Dim i As Integer
        Try
            With DataGridView1
                If .CurrentCell.Value Is Nothing Then
                    Exit Sub
                Else
                    i = .CurrentRow.Index
                    TXTID.Text = .Rows(i).Cells(0).Value.ToString
                    TXTNAMA.Text = .Rows(i).Cells(1).Value.ToString
                    TXTPASSWORD.Text = .Rows(i).Cells(2).Value.ToString
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
#End Region

    Private Sub BUTTONINSERT_Click(sender As Object, e As EventArgs) Handles BUTTONINSERT.Click
        Try
            mycmd.Connection = myconection.open
            mycmd.CommandText = "INSERT INTO `tb_img`(`id`, `nama`, `pwd`) VALUES ('" & TXTID.Text & "','" & TXTNAMA.Text & "','" & TXTPASSWORD.Text & "')"
            mycmd.ExecuteNonQuery()
            myconection.close()
            savephoto()
            VwGridView()
            MsgBox("Berhasil Ditambah", MsgBoxStyle.Information, "Pesan")
        Catch ex As Exception
            MsgBox("ID Tidak boleh sama")
        End Try
    End Sub

    Private Sub BUTTONUPDATE_Click(sender As Object, e As EventArgs) Handles BUTTONUPDATE.Click
        mycmd.Connection = myconection.open
        mycmd.CommandText = "UPDATE `tb_img` SET `nama`='" & TXTNAMA.Text & "',`pwd`='" & TXTPASSWORD.Text & "' WHERE `id`='" & TXTID.Text & "'"
        mycmd.ExecuteNonQuery()
        myconection.close()
        VwGridView()
        MsgBox("Berhasil diubah", MsgBoxStyle.Information, "Pesan")
    End Sub

    Private Sub BUTTONDELETE_Click(sender As Object, e As EventArgs) Handles BUTTONDELETE.Click
        mycmd.Connection = myconection.open
        mycmd.CommandText = "DELETE FROM `tb_img` WHERE `id`='" & TXTID.Text & "'"
        mycmd.ExecuteNonQuery()
        myconection.close()
        VwGridView()
        MsgBox("Berhasil dihapus", MsgBoxStyle.Information, "Pesan")
    End Sub

    Private Sub BUTTONSHOW_Click(sender As Object, e As EventArgs) Handles BUTTONSHOW.Click
        VwGridView()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        CLICKgRIDvIEW()
        bacaphoto()
    End Sub

    Dim a As New OpenFileDialog
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim lokasifile As String
        a.Filter = "Image File|*.jpg;*.png;*.gif;*.tiff"
        lokasifile = a.FileName
        Try
            If a.ShowDialog = Windows.Forms.DialogResult.OK Then
                PictureBox1.Image = New Bitmap(a.FileName)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub savephoto()
        Try
            Dim ms As New MemoryStream
            Try
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Catch ex As Exception
                MessageBox.Show("ERORR" & ex.Message, "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Using msql As New MySqlCommand("UPDATE tb_img set photo=@photo where id='" & TXTID.Text & "'", myconection.open)
                If a.FileName = Nothing Then
                    MsgBox("photo belum ada", MsgBoxStyle.Information, "pesan")
                    myconection.close()
                    Exit Sub
                Else
                    'msql.Parameters.Add(New MySqlParameter("@photo", MySqlDbType.Blob)).Value = IO.File.ReadAllBytes(a.FileName)
                    'msql.Parameters.Add("@photo", MySqlDbType.Blob).Value = IO.File.ReadAllBytes(a.FileName)
                    msql.Parameters.Add("@photo", MySqlDbType.Blob).Value = ms.ToArray()
                    'msql.Parameters.Add(New MySqlParameter("@photo", MySqlDbType.Blob)).Value = ms.ToArray()
                    MessageBox.Show("Photo Kamu ID:" & TXTID.Text & " akan di save.", "SUKSES", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                msql.ExecuteNonQuery()
                myconection.close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub bacaphoto()
        Try
            Using msql As New MySqlCommand("SELECT * FROM `tb_img` WHERE id='" & TXTID.Text & "'", myconection.open)
                Using dr As MySqlDataReader = msql.ExecuteReader()
                    Using dt As New DataTable
                        dt.Load(dr)
                        If dt.Rows.Count = 1 Then
                            Dim row As DataRow = dt.Rows(0)
                            Using ms As New IO.MemoryStream(CType(row(2), Byte()))
                                Dim img As Image = Image.FromStream(ms)
                                PictureBox1.Image = img
                                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                            End Using
                        End If
                    End Using
                End Using
            End Using
            myconection.close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class