<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKomunikasi
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
        Me.CmbBaudRate = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbPort = New System.Windows.Forms.ComboBox()
        Me.BtnConnect = New System.Windows.Forms.Button()
        Me.btnScanPort = New System.Windows.Forms.Button()
        Me.BtnDisconnect = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblNilai = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.btnOn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmbBaudRate
        '
        Me.CmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBaudRate.FormattingEnabled = True
        Me.CmbBaudRate.Location = New System.Drawing.Point(332, 78)
        Me.CmbBaudRate.Name = "CmbBaudRate"
        Me.CmbBaudRate.Size = New System.Drawing.Size(121, 21)
        Me.CmbBaudRate.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(277, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Baud Rate"
        '
        'CmbPort
        '
        Me.CmbPort.FormattingEnabled = True
        Me.CmbPort.Location = New System.Drawing.Point(133, 78)
        Me.CmbPort.Name = "CmbPort"
        Me.CmbPort.Size = New System.Drawing.Size(121, 21)
        Me.CmbPort.TabIndex = 11
        '
        'BtnConnect
        '
        Me.BtnConnect.Location = New System.Drawing.Point(491, 76)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(75, 23)
        Me.BtnConnect.TabIndex = 8
        Me.BtnConnect.Text = "Koneksi"
        Me.BtnConnect.UseVisualStyleBackColor = True
        '
        'btnScanPort
        '
        Me.btnScanPort.Location = New System.Drawing.Point(52, 78)
        Me.btnScanPort.Name = "btnScanPort"
        Me.btnScanPort.Size = New System.Drawing.Size(75, 23)
        Me.btnScanPort.TabIndex = 9
        Me.btnScanPort.Text = "Scan Port"
        Me.btnScanPort.UseVisualStyleBackColor = True
        '
        'BtnDisconnect
        '
        Me.BtnDisconnect.Location = New System.Drawing.Point(491, 76)
        Me.BtnDisconnect.Name = "BtnDisconnect"
        Me.BtnDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.BtnDisconnect.TabIndex = 10
        Me.BtnDisconnect.Text = "Disconnect"
        Me.BtnDisconnect.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'lblNilai
        '
        Me.lblNilai.AutoSize = True
        Me.lblNilai.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNilai.Location = New System.Drawing.Point(488, 204)
        Me.lblNilai.Name = "lblNilai"
        Me.lblNilai.Size = New System.Drawing.Size(38, 25)
        Me.lblNilai.TabIndex = 18
        Me.lblNilai.Text = "00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(431, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "BACA DATA MASUK"
        '
        'btnOff
        '
        Me.btnOff.Location = New System.Drawing.Point(295, 164)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(93, 37)
        Me.btnOff.TabIndex = 16
        Me.btnOff.Text = "MATI"
        Me.btnOff.UseVisualStyleBackColor = True
        '
        'btnOn
        '
        Me.btnOn.Location = New System.Drawing.Point(295, 121)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(93, 37)
        Me.btnOn.TabIndex = 17
        Me.btnOn.Text = "HIDUP"
        Me.btnOn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(643, 37)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "KOMUNIKASI ANTAR SERIAL ARDUINO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(52, 151)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(295, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 37)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "KEDIP"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(295, 267)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 37)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "DATA MASUK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormKomunikasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 328)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CmbBaudRate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbPort)
        Me.Controls.Add(Me.BtnConnect)
        Me.Controls.Add(Me.btnScanPort)
        Me.Controls.Add(Me.BtnDisconnect)
        Me.Controls.Add(Me.lblNilai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.btnOn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormKomunikasi"
        Me.Text = "FormKomunikasi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbBaudRate As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbPort As ComboBox
    Friend WithEvents BtnConnect As Button
    Friend WithEvents btnScanPort As Button
    Friend WithEvents BtnDisconnect As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblNilai As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOff As Button
    Friend WithEvents btnOn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
