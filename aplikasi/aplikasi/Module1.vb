Imports System.Data.Odbc

Module Module1
    Public CONN As OdbcConnection
    Public DA As OdbcDataAdapter
    Public CMD As OdbcCommand
    Public DS As DataSet
    Public RD As OdbcDataReader
    Dim MyDB As String

    Sub koneksi()
        MyDB = "Driver={MySQL ODBC 8.0 ANSI Driver};Database=db_aplikasi;server=localhost;uid=root"
        CONN = New OdbcConnection(MyDB)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
        'MessageBox.Show("Koneksi Berhasil")
    End Sub




End Module
