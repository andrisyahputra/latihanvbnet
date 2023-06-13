<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtAngka1 = New System.Windows.Forms.TextBox()
        Me.TxtAngka2 = New System.Windows.Forms.TextBox()
        Me.TxtJumlah = New System.Windows.Forms.TextBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnKurang = New System.Windows.Forms.Button()
        Me.BtnKali = New System.Windows.Forms.Button()
        Me.BtnBagi = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(57, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Angka 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(57, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Angka 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(57, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Jumlah"
        '
        'TxtAngka1
        '
        Me.TxtAngka1.BackColor = System.Drawing.Color.Gold
        Me.TxtAngka1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAngka1.ForeColor = System.Drawing.Color.DarkGreen
        Me.TxtAngka1.Location = New System.Drawing.Point(122, 42)
        Me.TxtAngka1.Name = "TxtAngka1"
        Me.TxtAngka1.Size = New System.Drawing.Size(96, 24)
        Me.TxtAngka1.TabIndex = 1
        '
        'TxtAngka2
        '
        Me.TxtAngka2.BackColor = System.Drawing.Color.Gold
        Me.TxtAngka2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAngka2.ForeColor = System.Drawing.Color.DarkGreen
        Me.TxtAngka2.Location = New System.Drawing.Point(122, 74)
        Me.TxtAngka2.Name = "TxtAngka2"
        Me.TxtAngka2.Size = New System.Drawing.Size(96, 24)
        Me.TxtAngka2.TabIndex = 2
        '
        'TxtJumlah
        '
        Me.TxtJumlah.BackColor = System.Drawing.Color.Gold
        Me.TxtJumlah.Enabled = False
        Me.TxtJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJumlah.ForeColor = System.Drawing.Color.DarkGreen
        Me.TxtJumlah.Location = New System.Drawing.Point(122, 105)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(96, 24)
        Me.TxtJumlah.TabIndex = 3
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.Gold
        Me.BtnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnTambah.Location = New System.Drawing.Point(224, 34)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(96, 28)
        Me.BtnTambah.TabIndex = 4
        Me.BtnTambah.Text = "(+) Tambah"
        Me.BtnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'BtnKurang
        '
        Me.BtnKurang.BackColor = System.Drawing.Color.Gold
        Me.BtnKurang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnKurang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnKurang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKurang.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnKurang.Location = New System.Drawing.Point(224, 60)
        Me.BtnKurang.Name = "BtnKurang"
        Me.BtnKurang.Size = New System.Drawing.Size(96, 28)
        Me.BtnKurang.TabIndex = 5
        Me.BtnKurang.Text = "(-) Kurang"
        Me.BtnKurang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKurang.UseVisualStyleBackColor = False
        '
        'BtnKali
        '
        Me.BtnKali.BackColor = System.Drawing.Color.Gold
        Me.BtnKali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnKali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnKali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKali.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnKali.Location = New System.Drawing.Point(224, 86)
        Me.BtnKali.Name = "BtnKali"
        Me.BtnKali.Size = New System.Drawing.Size(96, 28)
        Me.BtnKali.TabIndex = 6
        Me.BtnKali.Text = "(x) Kali"
        Me.BtnKali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKali.UseVisualStyleBackColor = False
        '
        'BtnBagi
        '
        Me.BtnBagi.BackColor = System.Drawing.Color.Gold
        Me.BtnBagi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnBagi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBagi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBagi.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnBagi.Location = New System.Drawing.Point(224, 112)
        Me.BtnBagi.Name = "BtnBagi"
        Me.BtnBagi.Size = New System.Drawing.Size(96, 28)
        Me.BtnBagi.TabIndex = 7
        Me.BtnBagi.Text = "(/) Bagi"
        Me.BtnBagi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBagi.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.Gold
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnClear.Location = New System.Drawing.Point(122, 146)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(96, 28)
        Me.BtnClear.TabIndex = 7
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(348, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 33)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "X"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(385, 192)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnBagi)
        Me.Controls.Add(Me.BtnKali)
        Me.Controls.Add(Me.BtnKurang)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TxtJumlah)
        Me.Controls.Add(Me.TxtAngka2)
        Me.Controls.Add(Me.TxtAngka1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perjumlahan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtAngka1 As TextBox
    Friend WithEvents TxtAngka2 As TextBox
    Friend WithEvents TxtJumlah As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnKurang As Button
    Friend WithEvents BtnKali As Button
    Friend WithEvents BtnBagi As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents Label4 As Label
End Class
