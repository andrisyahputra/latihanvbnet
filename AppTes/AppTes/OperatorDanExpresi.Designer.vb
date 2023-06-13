<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OperatorDanExpresi
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
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.BtnResult = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(102, 121)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(30, 13)
        Me.lblResult.TabIndex = 6
        Me.lblResult.Text = "Hasil"
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(137, 74)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 20)
        Me.txt2.TabIndex = 4
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(7, 74)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 5
        '
        'BtnResult
        '
        Me.BtnResult.Location = New System.Drawing.Point(74, 12)
        Me.BtnResult.Name = "BtnResult"
        Me.BtnResult.Size = New System.Drawing.Size(107, 56)
        Me.BtnResult.TabIndex = 3
        Me.BtnResult.Text = "PROSES"
        Me.BtnResult.UseVisualStyleBackColor = True
        '
        'OperatorDanExpresi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 149)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.BtnResult)
        Me.Name = "OperatorDanExpresi"
        Me.Text = "OperatorDanExpresi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblResult As Label
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt1 As TextBox
    Friend WithEvents BtnResult As Button
End Class
