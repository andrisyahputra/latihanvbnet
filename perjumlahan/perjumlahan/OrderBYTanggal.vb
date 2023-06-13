Public Class OrderBYTanggal
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles periode.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim startdate_v As Date = Date.Parse(startdate.Value)
        Dim periode_v As Integer = Integer.Parse(periode.Text)
        end_date.Value = DateAdd(DateInterval.Month, periode_v, startdate_v) 'untuk bulan
        'end_date.Value = DateAdd("m", periode_v, startdate_v) 'untuk bulan
        end_date.Value = DateAdd("yyyy", periode_v, startdate_v) 'untuk tahun
    End Sub
End Class