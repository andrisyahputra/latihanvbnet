Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        For x = 0 To 100
            If BackgroundWorker1.CancellationPending = True Then
                e.Cancel = True
                Exit For
            Else
                BackgroundWorker1.ReportProgress(x)
                System.Threading.Thread.Sleep(300)
                Label1.Refresh()
            End If
        Next
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'untuk menampilkan progres satu
        ProgressBar1.Value = e.ProgressPercentage
        Label1.Text = e.ProgressPercentage.ToString + " %" 'karrena double
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Cancelled = True Then
            Label1.Text = "Cenceled"
            ProgressBar1.Value = 0
        ElseIf e.Error IsNot Nothing Then
            MsgBox(e.Error.Message)
        Else
            'ini jika semua selesai
            Label1.Text = "selesai"
            Button1.Text = "Start"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'kasih perekondisian
        If Button1.Text = "Start" Then
            If Not BackgroundWorker1.IsBusy = True Then
                BackgroundWorker1.RunWorkerAsync()
                Button1.Text = "Cencel"
            End If
        ElseIf Button1.Text = "Cencel" Then
            If BackgroundWorker1.WorkerReportsProgress Then
                If BackgroundWorker1.WorkerSupportsCancellation = True Then
                    BackgroundWorker1.CancelAsync()
                    Button1.Text = "Start"
                End If
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    'groupbox 1

End Class
