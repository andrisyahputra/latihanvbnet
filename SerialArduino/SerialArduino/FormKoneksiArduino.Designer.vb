<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConnection
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
        Me.ButtonScanPort = New System.Windows.Forms.Button()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.ButtonDisconnect = New System.Windows.Forms.Button()
        Me.ButtonFormSensor = New System.Windows.Forms.Button()
        Me.ButtonOpenFormControlLED = New System.Windows.Forms.Button()
        Me.TimerCheck = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ButtonScanPort
        '
        Me.ButtonScanPort.Location = New System.Drawing.Point(22, 22)
        Me.ButtonScanPort.Name = "ButtonScanPort"
        Me.ButtonScanPort.Size = New System.Drawing.Size(75, 23)
        Me.ButtonScanPort.TabIndex = 0
        Me.ButtonScanPort.Text = "Scan Ports"
        Me.ButtonScanPort.UseVisualStyleBackColor = True
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(103, 24)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxPort.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Baud Rate:"
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"9600", "14400", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(338, 29)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxBaudRate.TabIndex = 3
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Location = New System.Drawing.Point(22, 66)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(202, 23)
        Me.ButtonConnect.TabIndex = 4
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'ButtonDisconnect
        '
        Me.ButtonDisconnect.Location = New System.Drawing.Point(247, 66)
        Me.ButtonDisconnect.Name = "ButtonDisconnect"
        Me.ButtonDisconnect.Size = New System.Drawing.Size(202, 23)
        Me.ButtonDisconnect.TabIndex = 5
        Me.ButtonDisconnect.Text = "Disconnect"
        Me.ButtonDisconnect.UseVisualStyleBackColor = True
        '
        'ButtonFormSensor
        '
        Me.ButtonFormSensor.Location = New System.Drawing.Point(22, 110)
        Me.ButtonFormSensor.Name = "ButtonFormSensor"
        Me.ButtonFormSensor.Size = New System.Drawing.Size(202, 23)
        Me.ButtonFormSensor.TabIndex = 4
        Me.ButtonFormSensor.Text = "Open Form Sensor value"
        Me.ButtonFormSensor.UseVisualStyleBackColor = True
        '
        'ButtonOpenFormControlLED
        '
        Me.ButtonOpenFormControlLED.Location = New System.Drawing.Point(247, 110)
        Me.ButtonOpenFormControlLED.Name = "ButtonOpenFormControlLED"
        Me.ButtonOpenFormControlLED.Size = New System.Drawing.Size(202, 23)
        Me.ButtonOpenFormControlLED.TabIndex = 4
        Me.ButtonOpenFormControlLED.Text = "Open Form Control Led"
        Me.ButtonOpenFormControlLED.UseVisualStyleBackColor = True
        '
        'TimerCheck
        '
        Me.TimerCheck.Enabled = True
        '
        'FormConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 162)
        Me.Controls.Add(Me.ButtonDisconnect)
        Me.Controls.Add(Me.ButtonOpenFormControlLED)
        Me.Controls.Add(Me.ButtonFormSensor)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Controls.Add(Me.ComboBoxBaudRate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxPort)
        Me.Controls.Add(Me.ButtonScanPort)
        Me.Name = "FormConnection"
        Me.Text = "FormKoneksiArduino"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonScanPort As Button
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ButtonDisconnect As Button
    Friend WithEvents ButtonFormSensor As Button
    Friend WithEvents ButtonOpenFormControlLED As Button
    Friend WithEvents TimerCheck As Timer
End Class
