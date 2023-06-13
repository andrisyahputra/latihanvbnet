Imports MySql.Data.MySqlClient

Public Class FormTampilGambarSemua
    Private Sub resizeImage()

    End Sub

    Private Sub aturgirdgambar()
        Dim i As Integer
        'Dim img As Image = Image.FromStream
        'Dim img As Image = Image.FromStream(getImage(DataGridView1.Columns(1).DataPropertyName = "kode".ToString))

        With DataGridView1
            .Columns(0).Width = 150
            .Columns(1).Width = 150
            .Columns(2).Width = 150

            .Columns(1).DataPropertyName = "file"
            .Columns(2).DataPropertyName = "file"
            .Columns(0).HeaderText = "GAMBAR"
            .Columns(1).HeaderText = "NAMA GAMBAR"
            .Columns(2).HeaderText = "KODE"

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold)
            .DefaultCellStyle.ForeColor = Color.White
            .GridColor = Color.White
            .RowsDefaultCellStyle.BackColor = Color.Lime

        End With

        For i = 0 To DataGridView1.Rows.Count - 1
            Dim r As DataGridViewRow = DataGridView1.Rows(i)
            r.Height = 100
        Next

        Dim imagecolumn = DirectCast(DataGridView1.Columns(2), DataGridViewImageColumn)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch

    End Sub
    Private Sub tabelGambar()
        Try
            'AturGridKamar()
            'Query = "Select * FROM tbl_kamar ORDER BY id_kamar"
            Query = "Select * FROM tbl_gambar"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData, "tbl_gambar")
            DataGridView1.DataSource = dsData.Tables("tbl_gambar")
        Catch ex As Exception
            MsgBox("Gagal tampil data GAMBAR")
        End Try
    End Sub

    Private Sub FormTampilGambarSemua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiKeDatabase()
        tabelGambar()
        aturgirdgambar()
    End Sub
    'Private Function getImage(ByVal kode As String) As System.IO.MemoryStream
    '    Try
    '        Call KoneksiKeDatabase()
    '        Query = "Select `file` From `tbl_gambar` where `kode`=@kode"
    '        cmd = New MySqlCommand(Query, Conn)
    '        cmd.Parameters.AddWithValue("@kode", kode)
    '        RD = cmd.ExecuteReader
    '        RD.Read()
    '        Dim imgArray() As Byte = RD.Item("file")
    '        Dim ms As New System.IO.MemoryStream(imgArray)
    '        cmd.Dispose()
    '        Conn.Close()
    '        RD.Close()
    '        Return ms
    '    Catch ex As Exception
    '        MsgBox("gagal")
    '    End Try
    'End Function
End Class