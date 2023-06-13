Imports System.Data.Odbc

Public Class FormUser
    Dim gender As String
    Sub no_user()
        CMD = New OdbcCommand("select * from tbl_user where id_user in(select max(id_user) from tbl_user) order by id_user DESC", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            TxtUserID.Text = "U" + "001"
        Else
            TxtUserID.Text = Val(Microsoft.VisualBasic.Mid(RD.Item("id_user").ToString, 2, 3)) + 1
            If Len(TxtUserID.Text) = 1 Then
                TxtUserID.Text = "U00" & TxtUserID.Text & ""
            ElseIf Len(TxtUserID.Text) = 2 Then
                TxtUserID.Text = "U0" & TxtUserID.Text & ""
            ElseIf Len(TxtUserID.Text) = 3 Then
                TxtUserID.Text = "U" & TxtUserID.Text & ""
            End If
        End If
    End Sub
    Sub KondisiAwal()
        LblKode.Visible = False
        TxtUserID.Text = ""
        TxtNamaLengkap.Text = ""
        TxtAlamat.Text = ""
        TxtPassword.Text = ""
        TxtUsername.Text = ""
        RBLaki.Text = "Laki Laki"
        RBPerempuan.Text = "Perempuan"

        TxtUserID.Enabled = False
        TxtNamaLengkap.Enabled = False
        TxtAlamat.Enabled = False
        TxtPassword.Enabled = False
        TxtUsername.Enabled = False
        CBLevel.Enabled = False
        RBLaki.Enabled = False
        RBPerempuan.Enabled = False
        DateTanggalLahir.Enabled = False
        TxtUsername.MaxLength = 10
        TxtPassword.MaxLength = 10

        RBLaki.Checked = False
        RBPerempuan.Checked = False

        BtnTambah.Text = "INPUT"
        BtnEdit.Text = "EDIT"
        BtnHapus.Text = "HAPUS"
        BtnTutup.Text = "TUTUP"

        BtnTambah.Enabled = True
        BtnHapus.Enabled = True
        BtnEdit.Enabled = True
        BtnTutup.Enabled = True

        ' Panggil koneksi yang sudah kita buat sub Koneksi()
        Call koneksi()

        ' Memanggil table yang sudah kita buat yaitu mahasiswa
        DA = New OdbcDataAdapter("Select * From tbl_user", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_user")
        DataGridView1.DataSource = DS.Tables("tbl_user")

    End Sub
    Sub KosongkanData()
        TxtUserID.Text = ""
        TxtNamaLengkap.Text = ""
        TxtAlamat.Text = ""
        TxtPassword.Text = ""
        TxtUsername.Text = ""
        CBLevel.Text = ""
        RBLaki.Checked = False
        RBPerempuan.Checked = False
        DateTanggalLahir.Value = Today
    End Sub
    Sub FieldAktif()
        ' untuk mengaktifkan form
        TxtUserID.Enabled = True
        TxtNamaLengkap.Enabled = True
        TxtAlamat.Enabled = True
        TxtPassword.Enabled = True
        TxtUsername.Enabled = True
        CBLevel.Enabled = True
        RBLaki.Enabled = True
        RBPerempuan.Enabled = True
        RBLaki.Checked = False
        RBPerempuan.Checked = False
        DateTanggalLahir.Enabled = True
        BtnHapus.Enabled = True
    End Sub
    Sub AturGrid()
        DataGridView1.Columns(0).Width = 50
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 70
        DataGridView1.Columns(3).Width = 250
        DataGridView1.Columns(4).Width = 70
        DataGridView1.Columns(5).Width = 80
        DataGridView1.Columns(6).Width = 80
        DataGridView1.Columns(7).Width = 50
        DataGridView1.Columns(0).DataPropertyName = "id_user"
        DataGridView1.Columns(1).DataPropertyName = "namalengkap"
        DataGridView1.Columns(2).DataPropertyName = "jeniskelamin"
        DataGridView1.Columns(3).DataPropertyName = "alamat"
        DataGridView1.Columns(4).DataPropertyName = "tangallahir"
        DataGridView1.Columns(5).DataPropertyName = "user_name"
        DataGridView1.Columns(6).DataPropertyName = "pwd"
        DataGridView1.Columns(7).DataPropertyName = "Level"
        DataGridView1.Columns(0).HeaderText = "ID User"
        DataGridView1.Columns(1).HeaderText = "Nama Lengkap"
        DataGridView1.Columns(2).HeaderText = "Jenis Kelamin"
        DataGridView1.Columns(3).HeaderText = "Alamat"
        DataGridView1.Columns(4).HeaderText = "Tanggal Lahir"
        DataGridView1.Columns(5).HeaderText = "Username"
        DataGridView1.Columns(6).HeaderText = "Password"
        DataGridView1.Columns(7).HeaderText = "Level"
        DataGridView1.Columns(8).Visible = False
        DataGridView1.Columns(9).Visible = False
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold)
        DataGridView1.DefaultCellStyle.ForeColor = Color.DarkRed
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.SkyBlue
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat
        DataGridView1.GridColor = Color.DarkRed
    End Sub


    Private Sub tutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        If BtnTutup.Text = "TUTUP" Then
            Me.Close()
        Else
            KondisiAwal()
            BtnHapus.Visible = True
        End If
    End Sub


    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call AturGrid()
        CBLevel.DropDownStyle = ComboBoxStyle.DropDownList
        CBLevel.Items.Add("Admin")
        CBLevel.Items.Add("Kasir")
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If BtnHapus.Text = "HAPUS" Then
            BtnHapus.Text = "DELETE"
            ' button1 non aktifkan
            BtnEdit.Enabled = False
            ' button2 juga kita non aktifkan, jadi dia ga bisa di klik sama sekali ketika button hapus kita klik
            BtnTambah.Enabled = False
            ' button4.text kita ubah textnya dari tutup menjadi batal
            BtnTutup.Text = "BATAL"
            ' setelah itu kita aktifkan FieldAktif() yang mana artinya kita mengaktifkan textbox1, textbox2, textbox3 dan textbox4
            LblKode.Visible = True
            TxtUserID.Enabled = True
            TxtNamaLengkap.Enabled = False
            TxtAlamat.Enabled = False
            TxtUsername.Enabled = False
            TxtPassword.Enabled = False
            RBLaki.Enabled = False
            RBPerempuan.Enabled = False
            CBLevel.Enabled = False
            TxtUserID.Focus()

        Else
            If TxtUserID.Text = "" Then
                MsgBox("Silahkan isi ID untuk hapus data")
            ElseIf TxtNamaLengkap.Text = "" Or
                TxtAlamat.Text = "" Or
                TxtPassword.Text = "" Or
                TxtUsername.Text = "" Or
                CBLevel.Text = "" Or
                RBLaki.Checked = False And RBPerempuan.Checked = False Then
                MsgBox("Silahkan Isi Semua Data")
            ElseIf DateTanggalLahir.Text = Today Then
                MsgBox("Tanggal Lahir belum input")
            ElseIf DateTanggalLahir.Text > Today Then
                MsgBox("Tanggal Lahir Kelewatan tahun")
            Else

                ' jika sudah kita isi fieldnya maka bisa kita hapus, prosesnya adalah
                ' kita panggil Koneksi()
                Call koneksi()
                ' lalu kita panggil table mahasiswa lalu dia bilang "tolongin aku dong, aku mau hapus dengan nim xxx tolong di bantu ya. makasih:)"
                Dim HapusData As String = "delete from tbl_user where id_user='" & TxtUserID.Text & "'"
                CMD = New OdbcCommand(HapusData, CONN)
                CMD.ExecuteNonQuery()
                ' kalau berhasil kita tampilkan alert / message dengan tulisan "hapus data berhasil"
                MsgBox("Hapus data berhasil")
                ' lalu kita panggil kondisiAwal()
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If BtnTambah.Text = "INPUT" Then
            BtnTambah.Text = "SIMPAN"
            Call no_user()
            BtnEdit.Text = "CLEAR"
            BtnHapus.Visible = False
            BtnTutup.Text = "BATAL"
            Call FieldAktif()
            TxtUserID.Enabled = False
            TxtNamaLengkap.Focus()
        Else

            If TxtUserID.Text = "" Then
                MsgBox("Silahkan isi ID untuk edit data")
            ElseIf TxtNamaLengkap.Text = "" Or
                TxtAlamat.Text = "" Or
                TxtPassword.Text = "" Or
                TxtUsername.Text = "" Or
                CBLevel.Text = "" Or
                RBLaki.Checked = False And RBPerempuan.Checked = False Then
                MsgBox("Silahkan Isi Semua Data")
            ElseIf DateTanggalLahir.Text = Today Then
                MsgBox("Tanggal Lahir belum input")
            ElseIf DateTanggalLahir.Text > Today Then
                MsgBox("Tanggal Lahir Kelewatan tahun")
            Else

                Call koneksi()
                If RBLaki.Checked = True Then
                    gender = RBLaki.Text
                ElseIf RBPerempuan.Checked = True Then
                    gender = RBPerempuan.Text
                End If
                Dim simpan As String = "insert into tbl_user values ('" & TxtUserID.Text & "','" & TxtNamaLengkap.Text & "','" & TxtAlamat.Text & "','" & Format(DateTanggalLahir.Value, "yyyy-MM-dd") & "','" & TxtUsername.Text & "','" & TxtPassword.Text & "','" & CBLevel.Text & "','" & gender & "','-','-')"
                CMD = New OdbcCommand(simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Input data berhasil")
                Call KondisiAwal()
                Call KosongkanData()
            End If
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If BtnEdit.Text = "CLEAR" Then
            TxtNamaLengkap.Text = ""
            TxtAlamat.Text = ""
            TxtPassword.Text = ""
            TxtUsername.Text = ""
            CBLevel.Text = ""
            RBLaki.Checked = False
            RBPerempuan.Checked = False
            DateTanggalLahir.Value = Today
            TxtNamaLengkap.Focus()
            Exit Sub
        End If

        If BtnEdit.Text = "EDIT" Then
            BtnEdit.Text = "UPDATE"
            BtnHapus.Enabled = False
            BtnTambah.Enabled = False
            BtnTutup.Text = "BATAL"
            LblKode.Visible = True
            TxtUserID.Enabled = True
            TxtNamaLengkap.Enabled = False
            TxtAlamat.Enabled = False
            TxtUsername.Enabled = False
            TxtPassword.Enabled = False
            RBLaki.Enabled = False
            RBPerempuan.Enabled = False
            CBLevel.Enabled = False

            TxtUserID.Focus()
        Else
            ' ini adalah validasi jika textbox1, textbox2, textbox3 dan textbox 4 tidak terisi maka akan muncul alert ("pastikan semua terisi)
            If TxtUserID.Text = "" Or
                TxtNamaLengkap.Text = "" Or
                TxtAlamat.Text = "" Or
                TxtPassword.Text = "" Or
                TxtUsername.Text = "" Or
                CBLevel.Text = "" Or
                RBLaki.Checked = False And RBPerempuan.Checked = False Then
                MsgBox("Silahkan Isi Semua Form")
            ElseIf DateTanggalLahir.Text = Today Then
                MsgBox("Tanggal Lahir belum input")
            ElseIf DateTanggalLahir.Text > Today Then
                MsgBox("Tanggal Lahir Kelewatan tahun")
            Else
                ' jika semua terisi panggil Koneksi()
                Call koneksi()
                ' kita update table mahasiswa
                Dim EditData As String = "Update tbl_user set namalengkap='" & TxtNamaLengkap.Text & "',alamat='" & TxtAlamat.Text & "',tangallahir='" & Format(DateTanggalLahir.Value, "yyyy-MM-dd") & "',user_name='" & TxtUsername.Text & "',pwd='" & TxtPassword.Text & "',level='" & CBLevel.Text & "',b='-',c='-'where id_user='" & TxtUserID.Text & "'"
                CMD = New OdbcCommand(EditData, CONN)
                CMD.ExecuteNonQuery()
                ' jika berhasil tampilkan alert / message ("edit data berhasil")
                MsgBox("Edit data berhasil")
                ' setelah semua sudah tolong tampilkan KondisiAwal()
                Call KondisiAwal()
            End If

        End If
    End Sub

    Private Sub TxtUserID_TextChanged(sender As Object, e As EventArgs) Handles TxtUserID.TextChanged

    End Sub

    Private Sub TxtUserID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUserID.KeyPress

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles LblKode.Click
        Call koneksi()
        CMD = New OdbcCommand("Select * from tbl_user where id_user='" & TxtUserID.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            TxtNamaLengkap.Text = RD.Item("namalengkap")
            gender = RD.Item("jeniskelamin")

            If gender = RBLaki.Text Then
                RBLaki.Checked = True
            ElseIf gender = RBPerempuan.Text Then
                RBPerempuan.Checked = True
            Else
                RBLaki.Checked = False
                RBPerempuan.Checked = False
            End If

            TxtUserID.Enabled = False
            TxtNamaLengkap.Enabled = True
            TxtAlamat.Enabled = True
            RBLaki.Enabled = True
            RBPerempuan.Enabled = True
            DateTanggalLahir.Enabled = True
            TxtUsername.Enabled = True
            TxtPassword.Enabled = True
            CBLevel.Enabled = True
            LblKode.Visible = False
            TxtNamaLengkap.Focus()

            TxtUsername.Text = RD.Item("user_name")
            TxtAlamat.Text = RD.Item("alamat")
            DateTanggalLahir.Value = RD.Item("tangallahir")
            TxtPassword.Text = RD.Item("pwd")
            CBLevel.Text = RD.Item("level")


        Else
            ' Jika nim yang kita ketikan salah, maka akan menampilkan alert atau message ("data tidak ada")
            MsgBox("Data Tidak Ada")
        End If
    End Sub


    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        TxtUserID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
    End Sub
End Class