Imports System.Data.Odbc

Public Class FormLengkap
    Dim gender As String
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        RadioButton1.Text = "Laki Laki"
        RadioButton2.Text = "Perempuan"
        lblKode.Visible = False

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        DateTimePicker1.Enabled = False
        TextBox1.MaxLength = 8

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        Button2.Text = "INPUT"
        Button3.Text = "EDIT"
        Button4.Text = "HAPUS"
        Button5.Text = "TUTUP"

        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True

        ' Panggil koneksi yang sudah kita buat sub Koneksi()
        Call koneksi()

        ' Memanggil table yang sudah kita buat yaitu mahasiswa
        DA = New OdbcDataAdapter("Select * From tbl_percobaan", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_percobaan")
        DataGridView1.DataSource = DS.Tables("tbl_percobaan")
    End Sub
    Sub AturGrid()
        DataGridView1.Columns(0).Width = 70
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 200
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(0).HeaderText = "Kode Anggota"
        DataGridView1.Columns(1).HeaderText = "Nama Anggota"
        DataGridView1.Columns(2).HeaderText = "Jenis Kelamin"
        DataGridView1.Columns(3).HeaderText = "Alamat"
        DataGridView1.Columns(4).HeaderText = "Tanggal Lahir"
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(8).Visible = False
        DataGridView1.GridColor = Color.Blue
        DataGridView1.DefaultCellStyle.ForeColor = Color.DarkRed
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.SkyBlue
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat
        DataGridView1.GridColor = Color.DarkRed
    End Sub
    Sub KosongkanData()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Sub FieldAktif()
        ' untuk mengaktifkan form
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        DateTimePicker1.Enabled = True
    End Sub

    Private Sub FormLengkap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call AturGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Button2.Text = "INPUT" Then
            Button2.Text = "SIMPAN"
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Text = "BATAL"
            Call FieldAktif()
            TextBox1.Focus()
        Else

            If TextBox1.Text = "" Or
                TextBox2.Text = "" Or
                TextBox3.Text = "" Or
                RadioButton1.Checked = False And RadioButton2.Checked = False Then
                MsgBox("Silahkan Isi Semua Form")
            ElseIf DateTimePicker1.Text = Today Then
                MsgBox("Tanggal Lahir belum input")
            ElseIf DateTimePicker1.Text > Today Then
                MsgBox("Tanggal Lahir Kelewatan tahun")
            Else

                Call koneksi()
                If RadioButton1.Checked = True Then
                    gender = RadioButton1.Text
                ElseIf RadioButton2.Checked = True Then
                    gender = RadioButton2.Text
                End If
                Dim simpan As String = "insert into tbl_percobaan values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & gender & "','" & TextBox3.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','-','-','-','-')"
                CMD = New OdbcCommand(simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Input data berhasil")
                Call KondisiAwal()
                Call KosongkanData()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "EDIT" Then
            Button3.Text = "UPDATE"
            Button2.Enabled = False
            Button4.Enabled = False
            Button5.Text = "BATAL"
            lblKode.Visible = True
            lblKode.Text = "Masukan Kode Anggota"
            TextBox1.Enabled = True
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            TextBox1.Focus()
        Else
            ' ini adalah validasi jika textbox1, textbox2, textbox3 dan textbox 4 tidak terisi maka akan muncul alert ("pastikan semua terisi)
            If TextBox1.Text = "" Or
                TextBox2.Text = "" Or
                TextBox3.Text = "" Or
                RadioButton1.Checked = False And RadioButton2.Checked = False Then
                MsgBox("Silahkan Isi Semua Form")
            ElseIf DateTimePicker1.Text = Today Then
                MsgBox("Tanggal Lahir belum input")
            ElseIf DateTimePicker1.Text > Today Then
                MsgBox("Tanggal Lahir Kelewatan tahun")
            Else
                ' jika semua terisi panggil Koneksi()
                Call koneksi()
                ' kita update table mahasiswa
                Dim EditData As String = "Update tbl_percobaan set nama_anggota='" & TextBox2.Text & "',jenis_kelamin   ='" & gender & "',alamat_anggota='" & TextBox3.Text & "',tanggal_lahir='" & DateTimePicker1.Text & "',a='-',b='-',c='-',d='-'where kode_anggota='" & TextBox1.Text & "'"
                CMD = New OdbcCommand(EditData, CONN)
                CMD.ExecuteNonQuery()
                ' jika berhasil tampilkan alert / message ("edit data berhasil")
                MsgBox("Edit data berhasil")
                ' setelah semua sudah tolong tampilkan KondisiAwal()
                Call KondisiAwal()
            End If

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' if chr 13 kita tekan, btw chr 13 itu adalah enter ya 
        If e.KeyChar = Chr(13) Then
            ' setelah tekan entar maka Koneksi() akan terpanggil
            Call koneksi()
            ' lalu ketika kita masukan nim di textbox1 (tekan enter) 
            ' selanjutnya tolong panggilkan table mahasiswa dan tolong isi isi form textbox2 dan textbox3 dan textbox4 

            CMD = New OdbcCommand("Select * from tbl_percobaan where kode_anggota='" & TextBox1.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            ' if kita panggil nim lalu tekan enter maka otomatis textbox2, textbox3, dan textbox4 akan terisi secara otomatis
            If RD.HasRows Then
                TextBox2.Text = RD.Item("nama_anggota")
                gender = RD.Item("jenis_kelamin")

                If gender = RadioButton1.Text Then
                    RadioButton1.Checked = True
                ElseIf gender = RadioButton2.Text Then
                    RadioButton2.Checked = True
                Else
                    RadioButton1.Checked = False
                    RadioButton2.Checked = False
                End If

                TextBox1.Enabled = False
                TextBox2.Enabled = True
                TextBox3.Enabled = True
                RadioButton1.Enabled = True
                RadioButton2.Enabled = True
                DateTimePicker1.Enabled = True
                lblKode.Visible = False
                TextBox2.Focus()


                TextBox3.Text = RD.Item("alamat_anggota")
                DateTimePicker1.Value = RD.Item("tanggal_lahir")

            Else
                ' Jika nim yang kita ketikan salah, maka akan menampilkan alert atau message ("data tidak ada")
                MsgBox("Data Tidak Ada")
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Jika button3.text yang mana textnya adalah hapus maka kita ubah texttnya menjadi delete  
        If Button4.Text = "HAPUS" Then
            Button4.Text = "DELETE"
            ' button1 non aktifkan
            Button2.Enabled = False
            ' button2 juga kita non aktifkan, jadi dia ga bisa di klik sama sekali ketika button hapus kita klik
            Button3.Enabled = False
            ' button4.text kita ubah textnya dari tutup menjadi batal
            Button5.Text = "BATAL"
            ' setelah itu kita aktifkan FieldAktif() yang mana artinya kita mengaktifkan textbox1, textbox2, textbox3 dan textbox4
            lblKode.Visible = True
            lblKode.Text = "Masukan Kode Anggota"
            TextBox1.Enabled = True
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            DateTimePicker1.Enabled = False
            TextBox1.Focus()

        Else
            If TextBox1.Text = "" Or
                TextBox2.Text = "" Or
                TextBox3.Text = "" Or
                RadioButton1.Checked = False And RadioButton2.Checked = False Then
                MsgBox("Silahkan Isi Semua Form")
            ElseIf DateTimePicker1.Text = Today Then
                MsgBox("Tanggal Lahir belum input")
            ElseIf DateTimePicker1.Text > Today Then
                MsgBox("Tanggal Lahir Kelewatan tahun")
            Else

                ' jika sudah kita isi fieldnya maka bisa kita hapus, prosesnya adalah
                ' kita panggil Koneksi()
                Call koneksi()
                ' lalu kita panggil table mahasiswa lalu dia bilang "tolongin aku dong, aku mau hapus dengan nim xxx tolong di bantu ya. makasih:)"
                Dim HapusData As String = "delete from tbl_anggota where kodeanggota='" & TextBox1.Text & "'"
                CMD = New OdbcCommand(HapusData, CONN)
                CMD.ExecuteNonQuery()
                ' kalau berhasil kita tampilkan alert / message dengan tulisan "hapus data berhasil"
                MsgBox("Hapus data berhasil")
                ' lalu kita panggil kondisiAwal()
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.Text = "TUTUP" Then
            End
        Else
            KondisiAwal()
        End If
    End Sub
End Class