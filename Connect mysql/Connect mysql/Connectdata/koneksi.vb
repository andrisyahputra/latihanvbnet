Imports MySql.Data.MySqlClient
Module koneksi
    Public Class DTConennection
        Dim conect As New MySqlConnection("server='localhost';user='root';password='';database='tes_db2'")


        Public Function open() As MySqlConnection
            conect.Open()
            Return conect
        End Function
        Public Function close() As MySqlConnection
            conect.Close()
            Return conect
        End Function

    End Class


End Module
