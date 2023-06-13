<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnmenu1 = New System.Windows.Forms.Button()
        Me.btnmenu2 = New System.Windows.Forms.Button()
        Me.btnmenu3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btnmenu1
        '
        Me.btnmenu1.Location = New System.Drawing.Point(35, 54)
        Me.btnmenu1.Name = "btnmenu1"
        Me.btnmenu1.Size = New System.Drawing.Size(85, 28)
        Me.btnmenu1.TabIndex = 0
        Me.btnmenu1.Text = "MENU 1"
        Me.btnmenu1.UseVisualStyleBackColor = True
        '
        'btnmenu2
        '
        Me.btnmenu2.Location = New System.Drawing.Point(35, 102)
        Me.btnmenu2.Name = "btnmenu2"
        Me.btnmenu2.Size = New System.Drawing.Size(85, 28)
        Me.btnmenu2.TabIndex = 1
        Me.btnmenu2.Text = "MENU 2"
        Me.btnmenu2.UseVisualStyleBackColor = True
        '
        'btnmenu3
        '
        Me.btnmenu3.Location = New System.Drawing.Point(35, 156)
        Me.btnmenu3.Name = "btnmenu3"
        Me.btnmenu3.Size = New System.Drawing.Size(85, 28)
        Me.btnmenu3.TabIndex = 1
        Me.btnmenu3.Text = "MENU 3"
        Me.btnmenu3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(135, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(414, 264)
        Me.Panel1.TabIndex = 2
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 298)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnmenu3)
        Me.Controls.Add(Me.btnmenu2)
        Me.Controls.Add(Me.btnmenu1)
        Me.Name = "Menu"
        Me.Text = "FormMultiForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnmenu1 As Button
    Friend WithEvents btnmenu2 As Button
    Friend WithEvents btnmenu3 As Button
    Friend WithEvents Panel1 As Panel
End Class
