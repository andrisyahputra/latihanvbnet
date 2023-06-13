<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormODBC
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
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDB = New System.Windows.Forms.TextBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtNdsn = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtUserId
        '
        Me.txtUserId.Location = New System.Drawing.Point(174, 112)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(154, 20)
        Me.txtUserId.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "User ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Database"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Server"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nama Dsn"
        '
        'txtDB
        '
        Me.txtDB.Location = New System.Drawing.Point(174, 87)
        Me.txtDB.Name = "txtDB"
        Me.txtDB.Size = New System.Drawing.Size(154, 20)
        Me.txtDB.TabIndex = 10
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(174, 62)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(154, 20)
        Me.txtServer.TabIndex = 10
        '
        'txtNdsn
        '
        Me.txtNdsn.Location = New System.Drawing.Point(174, 34)
        Me.txtNdsn.Name = "txtNdsn"
        Me.txtNdsn.Size = New System.Drawing.Size(154, 20)
        Me.txtNdsn.TabIndex = 10
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(140, 185)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(102, 40)
        Me.btnCreate.TabIndex = 11
        Me.btnCreate.Text = "CREATE DSN"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Password"
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(174, 138)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(154, 20)
        Me.txtPwd.TabIndex = 10
        Me.txtPwd.Text = " "
        '
        'FormODBC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 253)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtNdsn)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.txtDB)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUserId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormODBC"
        Me.Text = "FormODBC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUserId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDB As TextBox
    Friend WithEvents txtServer As TextBox
    Friend WithEvents txtNdsn As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPwd As TextBox
End Class
