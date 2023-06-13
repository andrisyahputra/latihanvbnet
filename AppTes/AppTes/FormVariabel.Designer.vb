<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVariabel
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
        Me.btnKlik = New System.Windows.Forms.Button()
        Me.txthasil = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnKlik
        '
        Me.btnKlik.Location = New System.Drawing.Point(235, 168)
        Me.btnKlik.Name = "btnKlik"
        Me.btnKlik.Size = New System.Drawing.Size(75, 23)
        Me.btnKlik.TabIndex = 0
        Me.btnKlik.Text = "KLIK SAYA"
        Me.btnKlik.UseVisualStyleBackColor = True
        '
        'txthasil
        '
        Me.txthasil.AutoSize = True
        Me.txthasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthasil.Location = New System.Drawing.Point(248, 86)
        Me.txthasil.Name = "txthasil"
        Me.txthasil.Size = New System.Drawing.Size(51, 24)
        Me.txthasil.TabIndex = 1
        Me.txthasil.Text = "Hasil"
        '
        'FormVariabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 296)
        Me.Controls.Add(Me.txthasil)
        Me.Controls.Add(Me.btnKlik)
        Me.Name = "FormVariabel"
        Me.Text = "FormVariabel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnKlik As Button
    Friend WithEvents txthasil As Label
End Class
