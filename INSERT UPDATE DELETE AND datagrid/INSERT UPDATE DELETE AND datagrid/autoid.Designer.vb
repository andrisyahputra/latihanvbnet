<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class autoid
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTNAMA = New System.Windows.Forms.TextBox()
        Me.TXTID = New System.Windows.Forms.TextBox()
        Me.BUTTONSHOW = New System.Windows.Forms.Button()
        Me.BUTTONDELETE = New System.Windows.Forms.Button()
        Me.BUTTONUPDATE = New System.Windows.Forms.Button()
        Me.BUTTONINSERT = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTPWD = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pwd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.NAMA, Me.pwd})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(27, 180)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(394, 114)
        Me.DataGridView1.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "NAMA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "ID"
        '
        'TXTNAMA
        '
        Me.TXTNAMA.Location = New System.Drawing.Point(108, 51)
        Me.TXTNAMA.Name = "TXTNAMA"
        Me.TXTNAMA.Size = New System.Drawing.Size(126, 20)
        Me.TXTNAMA.TabIndex = 25
        '
        'TXTID
        '
        Me.TXTID.Location = New System.Drawing.Point(108, 25)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.Size = New System.Drawing.Size(198, 20)
        Me.TXTID.TabIndex = 24
        '
        'BUTTONSHOW
        '
        Me.BUTTONSHOW.Location = New System.Drawing.Point(270, 136)
        Me.BUTTONSHOW.Name = "BUTTONSHOW"
        Me.BUTTONSHOW.Size = New System.Drawing.Size(75, 23)
        Me.BUTTONSHOW.TabIndex = 23
        Me.BUTTONSHOW.Text = "TAMPIL"
        Me.BUTTONSHOW.UseVisualStyleBackColor = True
        '
        'BUTTONDELETE
        '
        Me.BUTTONDELETE.Location = New System.Drawing.Point(189, 136)
        Me.BUTTONDELETE.Name = "BUTTONDELETE"
        Me.BUTTONDELETE.Size = New System.Drawing.Size(75, 23)
        Me.BUTTONDELETE.TabIndex = 22
        Me.BUTTONDELETE.Text = "HAPUS"
        Me.BUTTONDELETE.UseVisualStyleBackColor = True
        '
        'BUTTONUPDATE
        '
        Me.BUTTONUPDATE.Location = New System.Drawing.Point(108, 136)
        Me.BUTTONUPDATE.Name = "BUTTONUPDATE"
        Me.BUTTONUPDATE.Size = New System.Drawing.Size(75, 23)
        Me.BUTTONUPDATE.TabIndex = 21
        Me.BUTTONUPDATE.Text = "UBAH"
        Me.BUTTONUPDATE.UseVisualStyleBackColor = True
        '
        'BUTTONINSERT
        '
        Me.BUTTONINSERT.Location = New System.Drawing.Point(27, 136)
        Me.BUTTONINSERT.Name = "BUTTONINSERT"
        Me.BUTTONINSERT.Size = New System.Drawing.Size(75, 23)
        Me.BUTTONINSERT.TabIndex = 20
        Me.BUTTONINSERT.Text = "TAMBAH"
        Me.BUTTONINSERT.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(312, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "GENERATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "PASSWORD"
        '
        'TXTPWD
        '
        Me.TXTPWD.Location = New System.Drawing.Point(108, 82)
        Me.TXTPWD.Name = "TXTPWD"
        Me.TXTPWD.Size = New System.Drawing.Size(126, 20)
        Me.TXTPWD.TabIndex = 31
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'NAMA
        '
        Me.NAMA.HeaderText = "NAMA"
        Me.NAMA.Name = "NAMA"
        Me.NAMA.Width = 150
        '
        'pwd
        '
        Me.pwd.HeaderText = "PASSWORD"
        Me.pwd.Name = "pwd"
        '
        'autoid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 334)
        Me.Controls.Add(Me.TXTPWD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTNAMA)
        Me.Controls.Add(Me.TXTID)
        Me.Controls.Add(Me.BUTTONSHOW)
        Me.Controls.Add(Me.BUTTONDELETE)
        Me.Controls.Add(Me.BUTTONUPDATE)
        Me.Controls.Add(Me.BUTTONINSERT)
        Me.Name = "autoid"
        Me.Text = "autoid"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTNAMA As TextBox
    Friend WithEvents TXTID As TextBox
    Friend WithEvents BUTTONSHOW As Button
    Friend WithEvents BUTTONDELETE As Button
    Friend WithEvents BUTTONUPDATE As Button
    Friend WithEvents BUTTONINSERT As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTPWD As TextBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents NAMA As DataGridViewTextBoxColumn
    Friend WithEvents pwd As DataGridViewTextBoxColumn
End Class
