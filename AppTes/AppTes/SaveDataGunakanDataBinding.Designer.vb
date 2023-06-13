<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveDataGunakanDataBinding
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
        Me.TXTUSER = New System.Windows.Forms.TextBox()
        Me.TXTPASSWORD = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LBLUSER = New System.Windows.Forms.Label()
        Me.LBLPASSWORD = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TXTPASSWORD)
        Me.Panel1.Controls.Add(Me.TXTUSER)
        Me.Panel1.Location = New System.Drawing.Point(151, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 200)
        Me.Panel1.TabIndex = 0
        '
        'TXTUSER
        '
        Me.TXTUSER.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTUSER.Location = New System.Drawing.Point(35, 47)
        Me.TXTUSER.Name = "TXTUSER"
        Me.TXTUSER.Size = New System.Drawing.Size(198, 20)
        Me.TXTUSER.TabIndex = 0
        '
        'TXTPASSWORD
        '
        Me.TXTPASSWORD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTPASSWORD.Location = New System.Drawing.Point(35, 73)
        Me.TXTPASSWORD.Name = "TXTPASSWORD"
        Me.TXTPASSWORD.Size = New System.Drawing.Size(198, 20)
        Me.TXTPASSWORD.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(87, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 41)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "LOGIN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LBLUSER
        '
        Me.LBLUSER.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLUSER.AutoSize = True
        Me.LBLUSER.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.AppTes.My.MySettings.Default, "MyUserName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.LBLUSER.ForeColor = System.Drawing.Color.Maroon
        Me.LBLUSER.Location = New System.Drawing.Point(498, 111)
        Me.LBLUSER.Name = "LBLUSER"
        Me.LBLUSER.Size = New System.Drawing.Size(0, 13)
        Me.LBLUSER.TabIndex = 1
        Me.LBLUSER.Text = Global.AppTes.My.MySettings.Default.MyUserName
        '
        'LBLPASSWORD
        '
        Me.LBLPASSWORD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLPASSWORD.AutoSize = True
        Me.LBLPASSWORD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.AppTes.My.MySettings.Default, "MyPassword", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.LBLPASSWORD.ForeColor = System.Drawing.Color.Maroon
        Me.LBLPASSWORD.Location = New System.Drawing.Point(498, 190)
        Me.LBLPASSWORD.Name = "LBLPASSWORD"
        Me.LBLPASSWORD.Size = New System.Drawing.Size(0, 13)
        Me.LBLPASSWORD.TabIndex = 1
        Me.LBLPASSWORD.Text = Global.AppTes.My.MySettings.Default.MyPassword
        '
        'SaveDataGunakanDataBinding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 352)
        Me.Controls.Add(Me.LBLPASSWORD)
        Me.Controls.Add(Me.LBLUSER)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SaveDataGunakanDataBinding"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SaveDataGunakanDataBinding"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TXTPASSWORD As TextBox
    Friend WithEvents TXTUSER As TextBox
    Friend WithEvents LBLUSER As Label
    Friend WithEvents LBLPASSWORD As Label
End Class
