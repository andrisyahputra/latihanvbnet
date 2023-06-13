<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGetTimeDate
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
        Me.BTNTIME = New System.Windows.Forms.Button()
        Me.BTNDATE = New System.Windows.Forms.Button()
        Me.LBLTIME = New System.Windows.Forms.Label()
        Me.LBLDATE = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LBLDATETIMEPICKER = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTNTIME
        '
        Me.BTNTIME.Location = New System.Drawing.Point(208, 61)
        Me.BTNTIME.Name = "BTNTIME"
        Me.BTNTIME.Size = New System.Drawing.Size(75, 23)
        Me.BTNTIME.TabIndex = 0
        Me.BTNTIME.Text = "GET TIME"
        Me.BTNTIME.UseVisualStyleBackColor = True
        '
        'BTNDATE
        '
        Me.BTNDATE.Location = New System.Drawing.Point(208, 129)
        Me.BTNDATE.Name = "BTNDATE"
        Me.BTNDATE.Size = New System.Drawing.Size(75, 23)
        Me.BTNDATE.TabIndex = 0
        Me.BTNDATE.Text = "GET DATE"
        Me.BTNDATE.UseVisualStyleBackColor = True
        '
        'LBLTIME
        '
        Me.LBLTIME.AutoSize = True
        Me.LBLTIME.Location = New System.Drawing.Point(340, 66)
        Me.LBLTIME.Name = "LBLTIME"
        Me.LBLTIME.Size = New System.Drawing.Size(67, 13)
        Me.LBLTIME.TabIndex = 1
        Me.LBLTIME.Text = "HASIL TIME"
        '
        'LBLDATE
        '
        Me.LBLDATE.AutoSize = True
        Me.LBLDATE.Location = New System.Drawing.Point(340, 139)
        Me.LBLDATE.Name = "LBLDATE"
        Me.LBLDATE.Size = New System.Drawing.Size(70, 13)
        Me.LBLDATE.TabIndex = 1
        Me.LBLDATE.Text = "HASIL DATE"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(222, 188)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'LBLDATETIMEPICKER
        '
        Me.LBLDATETIMEPICKER.AutoSize = True
        Me.LBLDATETIMEPICKER.Location = New System.Drawing.Point(449, 188)
        Me.LBLDATETIMEPICKER.Name = "LBLDATETIMEPICKER"
        Me.LBLDATETIMEPICKER.Size = New System.Drawing.Size(126, 13)
        Me.LBLDATETIMEPICKER.TabIndex = 1
        Me.LBLDATETIMEPICKER.Text = "GET DATETIMEPICKER"
        '
        'FormGetTimeDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 296)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.LBLDATETIMEPICKER)
        Me.Controls.Add(Me.LBLDATE)
        Me.Controls.Add(Me.LBLTIME)
        Me.Controls.Add(Me.BTNDATE)
        Me.Controls.Add(Me.BTNTIME)
        Me.Name = "FormGetTimeDate"
        Me.Text = "FormGetTimeDate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNTIME As Button
    Friend WithEvents BTNDATE As Button
    Friend WithEvents LBLTIME As Label
    Friend WithEvents LBLDATE As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LBLDATETIMEPICKER As Label
End Class
