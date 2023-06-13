<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoading
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
        Me.components = New System.ComponentModel.Container()
        Me.LLOAD = New System.Windows.Forms.Label()
        Me.PLOAD = New System.Windows.Forms.ProgressBar()
        Me.TLOAD = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LLOAD
        '
        Me.LLOAD.AutoSize = True
        Me.LLOAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLOAD.Location = New System.Drawing.Point(237, 56)
        Me.LLOAD.Name = "LLOAD"
        Me.LLOAD.Size = New System.Drawing.Size(98, 108)
        Me.LLOAD.TabIndex = 0
        Me.LLOAD.Text = "0"
        '
        'PLOAD
        '
        Me.PLOAD.Location = New System.Drawing.Point(48, 168)
        Me.PLOAD.Name = "PLOAD"
        Me.PLOAD.Size = New System.Drawing.Size(477, 23)
        Me.PLOAD.TabIndex = 1
        '
        'TLOAD
        '
        Me.TLOAD.Enabled = True
        '
        'FormLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 224)
        Me.ControlBox = False
        Me.Controls.Add(Me.PLOAD)
        Me.Controls.Add(Me.LLOAD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLoading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLoading"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LLOAD As Label
    Friend WithEvents PLOAD As ProgressBar
    Friend WithEvents TLOAD As Timer
End Class
