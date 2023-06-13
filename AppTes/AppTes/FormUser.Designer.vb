<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LBLPASSWORD = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.BTNCHANGEPASS = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.BTNCHANGEPASS)
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.LBLPASSWORD)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 207)
        Me.Panel1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(116, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(116, 67)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(192, 20)
        Me.TextBox2.TabIndex = 0
        '
        'LBLPASSWORD
        '
        Me.LBLPASSWORD.AutoSize = True
        Me.LBLPASSWORD.ForeColor = System.Drawing.Color.Yellow
        Me.LBLPASSWORD.Location = New System.Drawing.Point(40, 70)
        Me.LBLPASSWORD.Name = "LBLPASSWORD"
        Me.LBLPASSWORD.Size = New System.Drawing.Size(70, 13)
        Me.LBLPASSWORD.TabIndex = 1
        Me.LBLPASSWORD.Text = "PASSWORD"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.ForeColor = System.Drawing.Color.Yellow
        Me.lblUser.Location = New System.Drawing.Point(40, 35)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(37, 13)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "USER"
        '
        'BTNCHANGEPASS
        '
        Me.BTNCHANGEPASS.Location = New System.Drawing.Point(116, 118)
        Me.BTNCHANGEPASS.Name = "BTNCHANGEPASS"
        Me.BTNCHANGEPASS.Size = New System.Drawing.Size(142, 63)
        Me.BTNCHANGEPASS.TabIndex = 2
        Me.BTNCHANGEPASS.Text = "GANTI USER DAN PASSWORD"
        Me.BTNCHANGEPASS.UseVisualStyleBackColor = True
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 207)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblUser As Label
    Friend WithEvents LBLPASSWORD As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BTNCHANGEPASS As Button
End Class
