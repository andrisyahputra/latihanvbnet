Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Public Class FormKomunikasi
    Dim data_masuk As String
    Dim kedip As Integer
    Dim imgKedip As Bitmap

    Private Sub FormKomunikasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Nilai Baud Rate yang bisa digunakan
        CmbBaudRate.Items.Add(9600)
        CmbBaudRate.Items.Add(19200)
        CmbBaudRate.Items.Add(38400)
        CmbBaudRate.Items.Add(57600)
        CmbBaudRate.Items.Add(115200)
        'For i = 0 To UBound(myPort)
        '    CmbPort.Items.Add(myPort(i))
        'Next
        'Atur Com Port pada Port yang pertama terdeteksi
        'CmbPort.Text = CmbPort.Items(0)
        'Atur Baud Rate pada Baud yang pertama terdeteksi
        CmbBaudRate.Text = CmbBaudRate.Items(0)
        imgKedip = KoneksiArduino.My.Resources.Resources.kedip

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
            Call FormKomunikasi_Load(Me, e)

        End Try
        BtnConnect.Enabled = True
        BtnConnect.BringToFront()
        CmbPort.DroppedDown = True
    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        If CmbPort.Text = "" Then
            MsgBox("Masukan port")
        Else
            BtnConnect.Enabled = False
            BtnConnect.SendToBack()

            SerialPort1.BaudRate = CmbBaudRate.SelectedItem
            SerialPort1.PortName = CmbPort.SelectedItem
            SerialPort1.Open()

            MsgBox("Koneksi arduino Berhasil")
            Timer1.Enabled = True
            Timer1.Start()

            BtnDisconnect.Enabled = True
            BtnDisconnect.BringToFront()
        End If

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

    Private Sub btnOn_Click(sender As Object, e As EventArgs) Handles btnOn.Click
        Try
            SerialPort1.Write("hidup")
            Panel1.BackColor = Color.Crimson
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")

        End Try
    End Sub

    Private Sub btnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click
        Try
            SerialPort1.Write("mati")
            Panel1.BackColor = Color.Black
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")

        End Try
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            data_masuk = SerialPort1.ReadLine()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            SerialPort1.Write("kedip")
            'Panel1.BackColor = Color.Crimson
            kedip = kedip + 1
            'If kedip = 2 Then
            '    kedip = 0
            'End If
            'If kedip Mod 2 = 0 Then
            '    Panel1.BackColor = Color.Crimson
            'Else
            '    Panel1.BackColor = Color.Black
            'End If
            'Panel1.BackgroundImage = imgKedip
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            SerialPort1.Write("datamasuk")
            Panel1.BackColor = Color.Black
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")

        End Try
    End Sub
End Class