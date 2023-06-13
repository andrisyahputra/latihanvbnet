Public Class FormGetTimeDate
    Private Sub BTNTIME_Click(sender As Object, e As EventArgs) Handles BTNTIME.Click
        LBLTIME.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub BTNDATE_Click(sender As Object, e As EventArgs) Handles BTNDATE.Click
        LBLDATE.Text = Format(Now, "dd/MM/yyyy")
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        LBLDATETIMEPICKER.Text = Format(DateTimePicker1.Value, "dd/MM/yyyy")
    End Sub
End Class