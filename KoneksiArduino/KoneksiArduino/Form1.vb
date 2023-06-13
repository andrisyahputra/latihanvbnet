Public Class Form1
    Dim onn As String
    Dim off As String
    Dim data_masuk As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbBaudRate.Items.Add("9600")
        CmbBaudRate.Items.Add("14400")
        CmbBaudRate.Items.Add("19200")
        CmbBaudRate.Items.Add("38400")
        CmbBaudRate.Items.Add("57600")
        CmbBaudRate.Items.Add("115200")

        CmbBaudRate.Text = CmbBaudRate.Items(0)
        Timer1.Start()


        Me.CenterToParent()
        BtnConnect.Enabled = False
        BtnConnect.BringToFront()

        BtnDisconnect.Enabled = False
        BtnDisconnect.SendToBack()

    End Sub


    Private Sub btnScanPort_Click(sender As Object, e As EventArgs) Handles btnScanPort.Click
        CmbPort.Items.Clear()
        Dim myport As Array
        Dim i As Integer
        myport = IO.Ports.SerialPort.GetPortNames()
        CmbPort.Items.AddRange(myport)
        i = CmbPort.Items.Count
        i = i - i
        Try
            CmbPort.SelectedIndex = i
        Catch ex As Exception
            Dim result As DialogResult
            result = MessageBox.Show("com port tidak tedeteksi", "Warning", MessageBoxButtons.OK)
            CmbPort.Text = ""
            CmbPort.Items.Clear()
            Call Form1_Load(Me, e)

        End Try
        BtnConnect.Enabled = True
        BtnConnect.BringToFront()
        CmbPort.DroppedDown = True

    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        BtnConnect.Enabled = False
        BtnConnect.SendToBack()

        SerialPort1.BaudRate = CmbBaudRate.SelectedItem
        SerialPort1.PortName = CmbPort.SelectedItem
        SerialPort1.Open()
        MsgBox("Koneksi arduino Berhasil")
        Timer1.Enabled = True


        BtnDisconnect.Enabled = True
        BtnDisconnect.BringToFront()

    End Sub

    Private Sub BtnDisconnect_Click(sender As Object, e As EventArgs) Handles BtnDisconnect.Click
        BtnDisconnect.Enabled = False
        BtnDisconnect.SendToBack()

        SerialPort1.Close()
        MsgBox("koneksi terputus")

        BtnConnect.Enabled = True
        BtnConnect.BringToFront()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim i As Single = SerialPort1.ReadExisting
            lblNilai.Text = data_masuk
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SerialPort1_dataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        data_masuk = SerialPort1.ReadLine()
    End Sub
End Class
