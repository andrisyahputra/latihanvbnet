Imports MySql.Data.MySqlClient
Module Module1
    Public Conn As New MySql.Data.MySqlClient.MySqlConnection
    Public daData As New MySqlDataAdapter
    Public dsData As New DataSet
    Public Query As String
    Public cmd As New MySqlCommand
    Public RD As MySqlDataReader

    Public Sub KoneksiKeDatabase()
        Try
            Dim str As String = "Server=localhost;user id=root;database=db_crud"
            Conn = New MySqlConnection(str)
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As System.Data.SqlClient.SqlException
            MsgBox("Koneksi ke server gagal")

        End Try

        'MessageBox.Show("Koneksi Berhasil")
    End Sub




End Module
