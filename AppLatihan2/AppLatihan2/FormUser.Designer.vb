<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUser
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
        Me.BTNSAVE = New System.Windows.Forms.Button()
        Me.BTNUPDATE = New System.Windows.Forms.Button()
        Me.BTNDELETE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 64)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HALOO,"
        '
        'BTNSAVE
        '
        Me.BTNSAVE.Location = New System.Drawing.Point(133, 154)
        Me.BTNSAVE.Name = "BTNSAVE"
        Me.BTNSAVE.Size = New System.Drawing.Size(75, 23)
        Me.BTNSAVE.TabIndex = 1
        Me.BTNSAVE.Text = "SAVE"
        Me.BTNSAVE.UseVisualStyleBackColor = True
        '
        'BTNUPDATE
        '
        Me.BTNUPDATE.Location = New System.Drawing.Point(235, 154)
        Me.BTNUPDATE.Name = "BTNUPDATE"
        Me.BTNUPDATE.Size = New System.Drawing.Size(75, 23)
        Me.BTNUPDATE.TabIndex = 2
        Me.BTNUPDATE.Text = "UPDATE"
        Me.BTNUPDATE.UseVisualStyleBackColor = True
        '
        'BTNDELETE
        '
        Me.BTNDELETE.Location = New System.Drawing.Point(360, 154)
        Me.BTNDELETE.Name = "BTNDELETE"
        Me.BTNDELETE.Size = New System.Drawing.Size(75, 23)
        Me.BTNDELETE.TabIndex = 3
        Me.BTNDELETE.Text = "DELETE"
        Me.BTNDELETE.UseVisualStyleBackColor = True
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 341)
        Me.Controls.Add(Me.BTNDELETE)
        Me.Controls.Add(Me.BTNUPDATE)
        Me.Controls.Add(Me.BTNSAVE)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BTNSAVE As Button
    Friend WithEvents BTNUPDATE As Button
    Friend WithEvents BTNDELETE As Button
End Class
