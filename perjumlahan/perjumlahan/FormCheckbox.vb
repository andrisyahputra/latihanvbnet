Public Class FormCheckbox
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        End
    End Sub

    Private Sub FormCheckbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtLainya.Visible = False
        LblLainnya.Visible = False
    End Sub

    Private Sub ChkLainnya_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLainnya.CheckedChanged
        If ChkLainnya.Checked = True Then
            TxtLainya.Visible = True
            LblLainnya.Visible = True
            TxtLainya.Focus()
        Else
            TxtLainya.Visible = False
            LblLainnya.Visible = False
        End If
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim vText As String
        vText = ""
        If ChkMobil.Checked = True Then
            vText &= ChkMobil.Text
            vText &= ", "
        End If

        If ChkMotor.Checked = True Then
            vText &= ChkMotor.Text
            vText &= ", "
        End If

        If ChkOlahraga.Checked = True Then
            vText &= ChkOlahraga.Text
            vText &= ", "
        End If

        If ChkIbadah.Checked = True Then
            vText &= ChkIbadah.Text
            vText &= ", "
        End If

        If ChkBisnis.Checked = True Then
            vText &= ChkBisnis.Text
            vText &= ", "
        End If

        If ChkLainnya.Checked = True Then
            vText &= TxtLainya.Text
        End If

        If vText <> Nothing Then
            MsgBox(vText + vbLf + vbLf + "Terimakasih", MsgBoxStyle.Question, "Informasi")
        End If
    End Sub
End Class