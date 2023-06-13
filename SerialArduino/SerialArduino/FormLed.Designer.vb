<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormControlLED
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
        Me.ButtonLedOff = New System.Windows.Forms.Button()
        Me.ButtonShowConnectionForm = New System.Windows.Forms.Button()
        Me.ButtonLedOn = New System.Windows.Forms.Button()
        Me.TimerControlButton = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ButtonLedOff
        '
        Me.ButtonLedOff.Location = New System.Drawing.Point(24, 128)
        Me.ButtonLedOff.Name = "ButtonLedOff"
        Me.ButtonLedOff.Size = New System.Drawing.Size(365, 23)
        Me.ButtonLedOff.TabIndex = 0
        Me.ButtonLedOff.Text = "Button LED OFF"
        Me.ButtonLedOff.UseVisualStyleBackColor = True
        '
        'ButtonShowConnectionForm
        '
        Me.ButtonShowConnectionForm.Location = New System.Drawing.Point(24, 54)
        Me.ButtonShowConnectionForm.Name = "ButtonShowConnectionForm"
        Me.ButtonShowConnectionForm.Size = New System.Drawing.Size(118, 23)
        Me.ButtonShowConnectionForm.TabIndex = 0
        Me.ButtonShowConnectionForm.Text = "Show Koneksi Form"
        Me.ButtonShowConnectionForm.UseVisualStyleBackColor = True
        '
        'ButtonLedOn
        '
        Me.ButtonLedOn.Location = New System.Drawing.Point(24, 99)
        Me.ButtonLedOn.Name = "ButtonLedOn"
        Me.ButtonLedOn.Size = New System.Drawing.Size(365, 23)
        Me.ButtonLedOn.TabIndex = 0
        Me.ButtonLedOn.Text = "Button LED ON"
        Me.ButtonLedOn.UseVisualStyleBackColor = True
        '
        'TimerControlButton
        '
        Me.TimerControlButton.Enabled = True
        '
        'FormControlLED
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 259)
        Me.Controls.Add(Me.ButtonShowConnectionForm)
        Me.Controls.Add(Me.ButtonLedOn)
        Me.Controls.Add(Me.ButtonLedOff)
        Me.Name = "FormControlLED"
        Me.Text = "FormLed"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonLedOff As Button
    Friend WithEvents ButtonShowConnectionForm As Button
    Friend WithEvents ButtonLedOn As Button
    Friend WithEvents TimerControlButton As Timer
End Class
