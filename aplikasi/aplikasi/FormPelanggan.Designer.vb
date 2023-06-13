<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPelanggan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tutup = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtIDNama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TTKendaraan = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ID_Kendaraan = New System.Windows.Forms.TextBox()
        Me.DTTKendaraan = New System.Windows.Forms.DateTimePicker()
        Me.DTTempo = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CBType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBiaya = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBKamar = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Navy
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(46, 253)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(187, 47)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "TAMBAH"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID"
        '
        'tutup
        '
        Me.tutup.BackColor = System.Drawing.Color.Navy
        Me.tutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tutup.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tutup.ForeColor = System.Drawing.Color.White
        Me.tutup.Location = New System.Drawing.Point(713, 253)
        Me.tutup.Name = "tutup"
        Me.tutup.Size = New System.Drawing.Size(187, 47)
        Me.tutup.TabIndex = 3
        Me.tutup.Text = "TUTUP"
        Me.tutup.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 33)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Kamar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 33)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Type"
        '
        'TxtIDNama
        '
        Me.TxtIDNama.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIDNama.Location = New System.Drawing.Point(180, 35)
        Me.TxtIDNama.Name = "TxtIDNama"
        Me.TxtIDNama.Size = New System.Drawing.Size(154, 29)
        Me.TxtIDNama.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(376, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 33)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ID Kendaraan"
        '
        'TTKendaraan
        '
        Me.TTKendaraan.AutoSize = True
        Me.TTKendaraan.BackColor = System.Drawing.Color.Transparent
        Me.TTKendaraan.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTKendaraan.Location = New System.Drawing.Point(376, 84)
        Me.TTKendaraan.Name = "TTKendaraan"
        Me.TTKendaraan.Size = New System.Drawing.Size(230, 33)
        Me.TTKendaraan.TabIndex = 4
        Me.TTKendaraan.Text = "Tanggal Kendaraan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(376, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(258, 33)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Tanggal Tatuh Tempo"
        '
        'ID_Kendaraan
        '
        Me.ID_Kendaraan.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_Kendaraan.Location = New System.Drawing.Point(635, 26)
        Me.ID_Kendaraan.Name = "ID_Kendaraan"
        Me.ID_Kendaraan.Size = New System.Drawing.Size(154, 29)
        Me.ID_Kendaraan.TabIndex = 5
        '
        'DTTKendaraan
        '
        Me.DTTKendaraan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTTKendaraan.Location = New System.Drawing.Point(635, 87)
        Me.DTTKendaraan.Name = "DTTKendaraan"
        Me.DTTKendaraan.Size = New System.Drawing.Size(265, 29)
        Me.DTTKendaraan.TabIndex = 6
        Me.DTTKendaraan.Value = New Date(2023, 2, 23, 8, 11, 43, 0)
        '
        'DTTempo
        '
        Me.DTTempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTTempo.Location = New System.Drawing.Point(635, 149)
        Me.DTTempo.Name = "DTTempo"
        Me.DTTempo.Size = New System.Drawing.Size(265, 29)
        Me.DTTempo.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Navy
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(268, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 47)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "EDIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Navy
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(501, 253)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(187, 47)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "HAPUS"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'CBType
        '
        Me.CBType.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBType.FormattingEnabled = True
        Me.CBType.Location = New System.Drawing.Point(180, 149)
        Me.CBType.Name = "CBType"
        Me.CBType.Size = New System.Drawing.Size(154, 29)
        Me.CBType.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 33)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Biaya"
        '
        'TxtBiaya
        '
        Me.TxtBiaya.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBiaya.Location = New System.Drawing.Point(180, 197)
        Me.TxtBiaya.Name = "TxtBiaya"
        Me.TxtBiaya.Size = New System.Drawing.Size(154, 29)
        Me.TxtBiaya.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(46, 346)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(854, 223)
        Me.DataGridView1.TabIndex = 8
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(206, 313)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(255, 29)
        Me.TextBox5.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(48, 309)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 33)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Pencariaan :"
        '
        'CBKamar
        '
        Me.CBKamar.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.CBKamar.FormattingEnabled = True
        Me.CBKamar.Location = New System.Drawing.Point(180, 96)
        Me.CBKamar.Name = "CBKamar"
        Me.CBKamar.Size = New System.Drawing.Size(154, 29)
        Me.CBKamar.TabIndex = 11
        '
        'FormPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(949, 600)
        Me.Controls.Add(Me.CBKamar)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CBType)
        Me.Controls.Add(Me.DTTempo)
        Me.Controls.Add(Me.DTTKendaraan)
        Me.Controls.Add(Me.ID_Kendaraan)
        Me.Controls.Add(Me.TxtIDNama)
        Me.Controls.Add(Me.TxtBiaya)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TTKendaraan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tutup)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_User"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tutup As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtIDNama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TTKendaraan As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ID_Kendaraan As TextBox
    Friend WithEvents DTTKendaraan As DateTimePicker
    Friend WithEvents DTTempo As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents CBType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBiaya As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CBKamar As ComboBox
End Class
