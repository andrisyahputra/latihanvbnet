Imports System.ComponentModel
'Imports Serial_Port_Multi_Form.FormSensorValueViewer
Imports Serial_Port_Multi_Form.FormControlLED

Public Class FormControlLED
    Public Shared FormControlLEDOpen As Boolean = False 'Variables to detect FormControlLED whether open or closed,True if it is open and vice versa

    Private Sub FormLed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        FormControlLEDOpen = True
        'Timer to check whether FormConnection or FormSensorValueViewer is open or closed.
        'If open, the ButtonShowConnectionForm or ButtonShowFormSensorValueViewer will be disabled, and vice versa.
        TimerControlButton.Start()
    End Sub

    Private Sub ButtonShowConnectionForm_Click(sender As Object, e As EventArgs) Handles ButtonShowConnectionForm.Click
        Dim openform As New FormConnection
        openform.Show()
    End Sub

    Private Sub ButtonLedOn_Click(sender As Object, e As EventArgs) Handles ButtonLedOn.Click
        Try
            SP_Write("led on")  'Writing / Sending / Printing data to serial port
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
            Dim openform As New FormConnection
            openform.Show()
        End Try
    End Sub

    Private Sub ButtonLedOff_Click(sender As Object, e As EventArgs) Handles ButtonLedOff.Click
        Try
            SP_Write("led off")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
            Dim openform As New FormConnection
            openform.Show()
        End Try
    End Sub

    Private Sub FormControlLED_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FormControlLEDOpen = False
        'If FormControlLED is closed and FormSensorValueViewer is not open and the FormConnection is not open, the FormConnection is opened.
        If FormConnectionStatusOpen = False And FormSensorValueViewerOpen = False Then
            Dim openform As New FormConnection
            openform.Show()
        End If
    End Sub

    Private Sub TimerControlButton_Tick(sender As Object, e As EventArgs) Handles TimerControlButton.Tick
        If FormConnectionStatusOpen = True Then
            ButtonShowConnectionForm.Enabled = False
        Else
            ButtonShowConnectionForm.Enabled = True
        End If

        If FormSensorValueViewerOpen = True Then
            ButtonShowFormSensorValueViewer.Enabled = False
        Else
            ButtonShowFormSensorValueViewer.Enabled = True
        End If
    End Sub
End Class