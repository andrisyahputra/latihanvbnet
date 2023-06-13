<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNilai
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBTAkhir = New System.Windows.Forms.ComboBox()
        Me.CBSem = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTDMHS = New System.Windows.Forms.Button()
        Me.btnCariMhs = New System.Windows.Forms.Button()
        Me.txtMHS = New System.Windows.Forms.TextBox()
        Me.txtNim = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnTDMTK = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSKS = New System.Windows.Forms.TextBox()
        Me.txtNMTK = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMTK = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCariMTK = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnTDDosen = New System.Windows.Forms.Button()
        Me.txtNDosen = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNidn = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cariDosen = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtBobot = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.txtJnilai = New System.Windows.Forms.TextBox()
        Me.txtNHuruf = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNAkhir = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnLapor = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 25)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Form Input Data Nilai"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Tahun Akademik"
        '
        'CBTAkhir
        '
        Me.CBTAkhir.FormattingEnabled = True
        Me.CBTAkhir.Location = New System.Drawing.Point(181, 48)
        Me.CBTAkhir.Name = "CBTAkhir"
        Me.CBTAkhir.Size = New System.Drawing.Size(121, 21)
        Me.CBTAkhir.TabIndex = 26
        '
        'CBSem
        '
        Me.CBSem.FormattingEnabled = True
        Me.CBSem.Location = New System.Drawing.Point(181, 84)
        Me.CBSem.Name = "CBSem"
        Me.CBSem.Size = New System.Drawing.Size(121, 21)
        Me.CBSem.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Semester"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.btnTDMHS)
        Me.Panel1.Controls.Add(Me.btnCariMhs)
        Me.Panel1.Controls.Add(Me.txtMHS)
        Me.Panel1.Controls.Add(Me.txtNim)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(46, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 119)
        Me.Panel1.TabIndex = 28
        '
        'btnTDMHS
        '
        Me.btnTDMHS.Location = New System.Drawing.Point(251, 84)
        Me.btnTDMHS.Name = "btnTDMHS"
        Me.btnTDMHS.Size = New System.Drawing.Size(103, 32)
        Me.btnTDMHS.TabIndex = 39
        Me.btnTDMHS.Text = "Tambah Data"
        Me.btnTDMHS.UseVisualStyleBackColor = True
        '
        'btnCariMhs
        '
        Me.btnCariMhs.Location = New System.Drawing.Point(279, 16)
        Me.btnCariMhs.Name = "btnCariMhs"
        Me.btnCariMhs.Size = New System.Drawing.Size(75, 37)
        Me.btnCariMhs.TabIndex = 38
        Me.btnCariMhs.Text = "Cari Data"
        Me.btnCariMhs.UseVisualStyleBackColor = True
        '
        'txtMHS
        '
        Me.txtMHS.Location = New System.Drawing.Point(173, 58)
        Me.txtMHS.Name = "txtMHS"
        Me.txtMHS.Size = New System.Drawing.Size(194, 20)
        Me.txtMHS.TabIndex = 7
        '
        'txtNim
        '
        Me.txtNim.Location = New System.Drawing.Point(173, 23)
        Me.txtNim.Name = "txtNim"
        Me.txtNim.Size = New System.Drawing.Size(100, 20)
        Me.txtNim.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nama Mahasiswa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "NIM"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightCoral
        Me.Panel2.Controls.Add(Me.btnTDMTK)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtSKS)
        Me.Panel2.Controls.Add(Me.txtNMTK)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtMTK)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.btnCariMTK)
        Me.Panel2.Location = New System.Drawing.Point(466, 141)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(393, 152)
        Me.Panel2.TabIndex = 28
        '
        'btnTDMTK
        '
        Me.btnTDMTK.Location = New System.Drawing.Point(277, 100)
        Me.btnTDMTK.Name = "btnTDMTK"
        Me.btnTDMTK.Size = New System.Drawing.Size(96, 32)
        Me.btnTDMTK.TabIndex = 40
        Me.btnTDMTK.Text = "Tambah Data"
        Me.btnTDMTK.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 20)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "SKS"
        '
        'txtSKS
        '
        Me.txtSKS.Location = New System.Drawing.Point(171, 100)
        Me.txtSKS.Name = "txtSKS"
        Me.txtSKS.Size = New System.Drawing.Size(100, 20)
        Me.txtSKS.TabIndex = 44
        '
        'txtNMTK
        '
        Me.txtNMTK.Location = New System.Drawing.Point(171, 58)
        Me.txtNMTK.Name = "txtNMTK"
        Me.txtNMTK.Size = New System.Drawing.Size(149, 20)
        Me.txtNMTK.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Nama MTK"
        '
        'txtMTK
        '
        Me.txtMTK.Location = New System.Drawing.Point(171, 18)
        Me.txtMTK.Name = "txtMTK"
        Me.txtMTK.Size = New System.Drawing.Size(100, 20)
        Me.txtMTK.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 20)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Kode Mata kuliah"
        '
        'btnCariMTK
        '
        Me.btnCariMTK.Location = New System.Drawing.Point(298, 14)
        Me.btnCariMTK.Name = "btnCariMTK"
        Me.btnCariMTK.Size = New System.Drawing.Size(75, 37)
        Me.btnCariMTK.TabIndex = 38
        Me.btnCariMTK.Text = "Cari Data "
        Me.btnCariMTK.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.GreenYellow
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.btnTDDosen)
        Me.Panel3.Controls.Add(Me.txtNDosen)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtNidn)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.cariDosen)
        Me.Panel3.Location = New System.Drawing.Point(46, 259)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(393, 100)
        Me.Panel3.TabIndex = 28
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(115, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 46
        '
        'btnTDDosen
        '
        Me.btnTDDosen.Location = New System.Drawing.Point(279, 56)
        Me.btnTDDosen.Name = "btnTDDosen"
        Me.btnTDDosen.Size = New System.Drawing.Size(97, 32)
        Me.btnTDDosen.TabIndex = 45
        Me.btnTDDosen.Text = "Tambah Data"
        Me.btnTDDosen.UseVisualStyleBackColor = True
        '
        'txtNDosen
        '
        Me.txtNDosen.Location = New System.Drawing.Point(115, 68)
        Me.txtNDosen.Name = "txtNDosen"
        Me.txtNDosen.Size = New System.Drawing.Size(149, 20)
        Me.txtNDosen.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 20)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Nama Dosen"
        '
        'txtNidn
        '
        Me.txtNidn.Location = New System.Drawing.Point(115, 14)
        Me.txtNidn.Name = "txtNidn"
        Me.txtNidn.Size = New System.Drawing.Size(100, 20)
        Me.txtNidn.TabIndex = 42
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(10, 40)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 20)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "NIDN"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 20)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "NIDN"
        '
        'cariDosen
        '
        Me.cariDosen.Location = New System.Drawing.Point(292, 5)
        Me.cariDosen.Name = "cariDosen"
        Me.cariDosen.Size = New System.Drawing.Size(75, 37)
        Me.cariDosen.TabIndex = 38
        Me.cariDosen.Text = "Cari Data"
        Me.cariDosen.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Yellow
        Me.Panel4.Controls.Add(Me.txtBobot)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.txtKeterangan)
        Me.Panel4.Controls.Add(Me.txtJnilai)
        Me.Panel4.Controls.Add(Me.txtNHuruf)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.txtNAkhir)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Location = New System.Drawing.Point(466, 299)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(393, 198)
        Me.Panel4.TabIndex = 28
        '
        'txtBobot
        '
        Me.txtBobot.Location = New System.Drawing.Point(192, 92)
        Me.txtBobot.Name = "txtBobot"
        Me.txtBobot.Size = New System.Drawing.Size(100, 20)
        Me.txtBobot.TabIndex = 45
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(29, 165)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 20)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Keterangan"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(29, 90)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 20)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Bobot"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(28, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 20)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Jumlah Nilai"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(192, 165)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(100, 20)
        Me.txtKeterangan.TabIndex = 44
        '
        'txtJnilai
        '
        Me.txtJnilai.Location = New System.Drawing.Point(192, 131)
        Me.txtJnilai.Name = "txtJnilai"
        Me.txtJnilai.Size = New System.Drawing.Size(100, 20)
        Me.txtJnilai.TabIndex = 44
        '
        'txtNHuruf
        '
        Me.txtNHuruf.Location = New System.Drawing.Point(192, 59)
        Me.txtNHuruf.Name = "txtNHuruf"
        Me.txtNHuruf.Size = New System.Drawing.Size(149, 20)
        Me.txtNHuruf.TabIndex = 43
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(29, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 20)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Nilai Huruf"
        '
        'txtNAkhir
        '
        Me.txtNAkhir.Location = New System.Drawing.Point(192, 23)
        Me.txtNAkhir.Name = "txtNAkhir"
        Me.txtNAkhir.Size = New System.Drawing.Size(100, 20)
        Me.txtNAkhir.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(29, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 20)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Nilai Akhir"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(298, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 37)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Proses"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(254, 430)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 37)
        Me.Button4.TabIndex = 46
        Me.Button4.Text = "Cari"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(139, 437)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(109, 20)
        Me.txtCari.TabIndex = 45
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(89, 503)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(681, 213)
        Me.ListView1.TabIndex = 44
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(364, 382)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 37)
        Me.btnExit.TabIndex = 39
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(283, 382)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 37)
        Me.btnDelete.TabIndex = 40
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(202, 382)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 37)
        Me.btnEdit.TabIndex = 41
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(121, 382)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 37)
        Me.btnSave.TabIndex = 42
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(40, 382)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 37)
        Me.btnRefresh.TabIndex = 43
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(53, 435)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 20)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Pencarian"
        '
        'btnLapor
        '
        Me.btnLapor.Location = New System.Drawing.Point(338, 430)
        Me.btnLapor.Name = "btnLapor"
        Me.btnLapor.Size = New System.Drawing.Size(75, 37)
        Me.btnLapor.TabIndex = 47
        Me.btnLapor.Text = "LAPOR"
        Me.btnLapor.UseVisualStyleBackColor = True
        '
        'FormNilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 732)
        Me.Controls.Add(Me.btnLapor)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CBSem)
        Me.Controls.Add(Me.CBTAkhir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormNilai"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CBTAkhir As ComboBox
    Friend WithEvents CBSem As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtMHS As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCariMhs As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCariMTK As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSKS As TextBox
    Friend WithEvents txtNMTK As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMTK As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cariDosen As Button
    Friend WithEvents txtNDosen As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNidn As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents txtJnilai As TextBox
    Friend WithEvents txtNHuruf As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNAkhir As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txtBobot As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btnTDMHS As Button
    Friend WithEvents btnTDDosen As Button
    Friend WithEvents btnTDMTK As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents btnLapor As Button
End Class
