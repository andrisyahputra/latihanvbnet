'Imports Emgu.CV
'Imports Emgu.CV.UI
'Imports Emgu.CV.Structure
'Public Class FormCam
'    Dim cap As New VideoCapture

'    Private Sub FormCam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        Timer1.Enabled = True
'        Timer1.Start()
'    End Sub

'    Private Sub FormCam_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
'        Timer1.Stop()
'        Timer1.Enabled = False
'    End Sub

'    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
'        frmBorrower.picbox.Image = picbox.Image

'        Timer1.Stop()
'        Timer1.Enabled = False
'        Me.Close()
'    End Sub

'    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
'        picbox.Image = cap.QueryFrame.Bitmap()
'    End Sub
'End Class