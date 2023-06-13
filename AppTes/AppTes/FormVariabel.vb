Imports AppTes.ClassVariabel
Public Class FormVariabel
    'Public a1 As String 'global varia  bel
    'Dim a2 As String 'local variabel
    'Private a3 As String 'local variabel

    Const nama As String = " Andri" 'bisa juga sperti dim

    Private Sub btnKlik_Click(sender As Object, e As EventArgs) Handles btnKlik.Click
        'stastic hanya dapat mendeklarasikan dicode didalm ini saja
        'Static a4 As String 'member variabel
        'a4 = "INI SAYA"
        'txthasil.Text = a4
        'Const nama As String = " Andri" 'bisa juga

        a1 = "A"
        txthasil.Text = a1 & nama
    End Sub
End Class