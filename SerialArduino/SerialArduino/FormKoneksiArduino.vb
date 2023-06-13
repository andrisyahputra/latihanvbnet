Imports System.ComponentModel
'Imports Serial_Port_Multi_Form.FormSensorValueViewer
Imports Serial_Port_Multi_Form.FormControlLED

Public Class FormConnection
    Public Shared FormConnectionStatusOpen As Boolean = True    'Variables to detect FormConnection whether open or closed, True if it is open and vice versa
    Dim AppClose As Boolean = True  'Variables to close the Application



    Private Sub FormKoneksiArduino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        'Timer to check whether FormSensorValueViewer or FormControlLED is open or closed.
        'If open, the ButtonOpenFormSensorValueViewer or ButtonOpenFormControlLED will be disabled, and vice versa.
        TimerCheck.Start()
        'Enter items from My.Settings.CmbPort to ComboBoxPort. 
        'If this Is Not done Then, the ComboBoxPort will be empty every time FormConnection Is closed And open another form
        For Each Item As String In My.Settings.CmbPort
            ComboBoxPort.Items.Add(Item)
        Next
        If My.Settings.CmbPort.Count > 0 Then
            ComboBoxPort.SelectedIndex = My.Settings.cmbPortLastSelect
        End If
        ComboBoxBaudRate.SelectedIndex = My.Settings.CmbBaudRateLastSelect
        If My.Settings.ConnectionStatus = 1 Then    'My.Settings.ConnectionStatus = 1 means that the Serial Port is open and connected.
            ButtonScanPort.Enabled = False
            ButtonConnect.Enabled = False
            ButtonDisconnect.Enabled = True
            ComboBoxPort.Enabled = False
            ComboBoxBaudRate.Enabled = False
        Else
            ButtonScanPort.Enabled = True
            ButtonConnect.Enabled = True
            ButtonDisconnect.Enabled = False
            ComboBoxPort.Enabled = True
            ComboBoxBaudRate.Enabled = True
        End If
        FormConnectionStatusOpen = True
        If My.Settings.ConnectionStatus = 1 Then
            TimerCheck.Start()
        End If
    End Sub

    Private Sub ButtonScanPort_Click(sender As Object, e As EventArgs) Handles ButtonScanPort.Click
        ComboBoxPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(myPort)
        i = ComboBoxPort.Items.Count
        i = i - i
        Try
            ComboBoxPort.SelectedIndex = i
        Catch ex As Exception
            MsgBox("Com port not detected", MsgBoxStyle.Critical, "Error Message")
            ComboBoxPort.Text = ""
            ComboBoxPort.Items.Clear()
            Return
        End Try
        ComboBoxPort.DroppedDown = True
    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        Try
            SP_Open(ComboBoxPort.SelectedItem, ComboBoxBaudRate.SelectedItem)   'SP_Open (port_name, baudrate_speed)

            My.Settings.CmbPort.Clear()
            '------------------------------------------------------------------Save the last condition of the FormConnection before it is closed, 
            '                                                                  For later To be reloaded When FormConnection Is Opened / Shown
            For Each Item As String In ComboBoxPort.Items
                My.Settings.CmbPort.Add(Item)
            Next
            My.Settings.cmbPortLastSelect = ComboBoxPort.SelectedIndex
            My.Settings.CmbBaudRateLastSelect = ComboBoxBaudRate.SelectedIndex
            My.Settings.ConnectionStatus = 1
            '------------------------------------------------------------------
            ButtonScanPort.Enabled = False
            ButtonConnect.Enabled = False
            ButtonDisconnect.Enabled = True
            ComboBoxPort.Enabled = False
            ComboBoxBaudRate.Enabled = False

            MsgBox("Connection successful", MsgBoxStyle.Information, "Information Message")

            TimerCheck.Start()

            '------------------------------------------------------------------When ButtonConnect is clicked and the Serial Port is successfully opened, 
            '                                                                  then if FormSensorValueViewer Or FormControlLED Is opened 
            '                                                                  then FormConnection will be closed immediately.
            'If My.Settings.ConnectionStatus = 1 And ButtonOpenFormSensorValueViewer.Enabled = False Then
            '    FormConnectionStatusOpen = False
            '    AppClose = False
            '    Me.Close()
            'End If

            If My.Settings.ConnectionStatus = 1 And ButtonOpenFormControlLED.Enabled = False Then
                FormConnectionStatusOpen = False
                AppClose = False
                Me.Close()
            End If
            '------------------------------------------------------------------            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub ButtonDisconnect_Click(sender As Object, e As EventArgs) Handles ButtonDisconnect.Click
        TimerCheck.Stop()
        SP_Close()
        My.Settings.ConnectionStatus = 0
        ButtonScanPort.Enabled = True
        ButtonConnect.Enabled = True
        ButtonDisconnect.Enabled = False
        ComboBoxPort.Enabled = True
        ComboBoxBaudRate.Enabled = True
    End Sub

    Private Sub ButtonFormLed_Click(sender As Object, e As EventArgs) Handles ButtonOpenFormControlLED.Click
        FormConnectionStatusOpen = False
        AppClose = False
        Dim openform As New FormControlLED
        openform.Show()
        Me.Close()
    End Sub

    Private Sub ButtonFormSensor_Click(sender As Object, e As EventArgs) Handles ButtonFormSensor.Click
        FormConnectionStatusOpen = False
        AppClose = False
        Dim openform As New FormControlLED
        openform.Show()
        Me.Close()
    End Sub

    Private Sub FormConnection_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'If FormSensorValueViewerOpen = True Then
        '    FormConnectionStatusOpen = False
        '    AppClose = False
        'End If
        If FormControlLEDOpen = True Then
            FormConnectionStatusOpen = False
            AppClose = False
        End If
        '------------------------------------------------------------------
        '------------------------------------------------------------------If the FormConnection is closed and the other forms have been closed, 
        '                                                                  then My.Setting Items Is cleared.
        If AppClose = True Then
            If My.Settings.ConnectionStatus = 1 Then
                SP_Close()
            End If
            My.Settings.CmbPort.Clear()
            My.Settings.cmbPortLastSelect = 0
            My.Settings.CmbBaudRateLastSelect = 0
            My.Settings.ConnectionStatus = 0
        End If
    End Sub

    Private Sub TimerCheck_Tick(sender As Object, e As EventArgs) Handles TimerCheck.Tick
        'Timer to check whether FormSensorValueViewer or FormControlLED is open or closed.
        'If open, the ButtonOpenFormSensorValueViewer or ButtonOpenFormControlLED will be disabled, and vice versa.
        'If FormSensorValueViewerOpen = False Then
        '    ButtonOpenFormSensorValueViewer.Enabled = True
        'Else
        '    ButtonOpenFormSensorValueViewer.Enabled = False
        'End If

        If FormControlLEDOpen = False Then
            ButtonOpenFormControlLED.Enabled = True
        Else
            ButtonOpenFormControlLED.Enabled = False
        End If
    End Sub
End Class