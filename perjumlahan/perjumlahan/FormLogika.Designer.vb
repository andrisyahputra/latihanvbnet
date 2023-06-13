<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogika
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAngka1 = New System.Windows.Forms.TextBox()
        Me.TxtAngka2 = New System.Windows.Forms.TextBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLogic = New System.Windows.Forms.Label()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(30, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Angka 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(30, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Angka 2"
        '
        'TxtAngka1
        '
        Me.TxtAngka1.BackColor = System.Drawing.Color.Gold
        Me.TxtAngka1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAngka1.ForeColor = System.Drawing.Color.DarkGreen
        Me.TxtAngka1.Location = New System.Drawing.Point(98, 40)
        Me.TxtAngka1.Name = "TxtAngka1"
        Me.TxtAngka1.Size = New System.Drawing.Size(96, 24)
        Me.TxtAngka1.TabIndex = 1
        '
        'TxtAngka2
        '
        Me.TxtAngka2.BackColor = System.Drawing.Color.Gold
        Me.TxtAngka2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAngka2.ForeColor = System.Drawing.Color.DarkGreen
        Me.TxtAngka2.Location = New System.Drawing.Point(98, 80)
        Me.TxtAngka2.Name = "TxtAngka2"
        Me.TxtAngka2.Size = New System.Drawing.Size(96, 24)
        Me.TxtAngka2.TabIndex = 2
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.Gold
        Me.BtnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnTambah.Location = New System.Drawing.Point(98, 116)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(96, 28)
        Me.BtnTambah.TabIndex = 3
        Me.BtnTambah.Text = "SUBMIT"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(30, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "HASIL"
        '
        'lblLogic
        '
        Me.lblLogic.AutoSize = True
        Me.lblLogic.ForeColor = System.Drawing.Color.Gold
        Me.lblLogic.Location = New System.Drawing.Point(30, 205)
        Me.lblLogic.Name = "lblLogic"
        Me.lblLogic.Size = New System.Drawing.Size(16, 13)
        Me.lblLogic.TabIndex = 0
        Me.lblLogic.Text = "..."
        '
        'TxtHasil
        '
        Me.TxtHasil.BackColor = System.Drawing.Color.Gold
        Me.TxtHasil.Enabled = False
        Me.TxtHasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHasil.ForeColor = System.Drawing.Color.DarkGreen
        Me.TxtHasil.Location = New System.Drawing.Point(98, 158)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(96, 24)
        Me.TxtHasil.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(232, -1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 33)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "X"
        '
        'FormLogika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(269, 303)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.TxtAngka2)
        Me.Controls.Add(Me.lblLogic)
        Me.Controls.Add(Me.TxtAngka1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLogika"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogika"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAngka1 As TextBox
    Friend WithEvents TxtAngka2 As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLogic As Label
    Friend WithEvents TxtHasil As TextBox
    Friend WithEvents Label4 As Label
End Class
