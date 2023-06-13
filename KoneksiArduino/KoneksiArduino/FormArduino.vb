Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Public Class FormArduino
    Dim myPort As Array
    Private Sub FormArduino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames()
        'Nilai Baud Rate yang bisa digunakan
        ComboBox2.Items.Add(9600)
        ComboBox2.Items.Add(19200)
        ComboBox2.Items.Add(38400)
        ComboBox2.Items.Add(57600)
        ComboBox2.Items.Add(115200)
        For i = 0 To UBound(myPort)
            ComboBox1.Items.Add(myPort(i))
        Next
        'Atur Com Port pada Port yang pertama terdeteksi
        ComboBox1.Text = ComboBox1.Items(0)
        'Atur Baud Rate pada Baud yang pertama terdeteksi
        ComboBox2.Text = ComboBox2.Items(0)
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SerialPort1.PortName = ComboBox1.Text
        SerialPort1.BaudRate = ComboBox2.Text
        SerialPort1.Open()
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SerialPort1.Close()
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SerialPort1.Write(TextBox1.Text)
    End Sub
End Class