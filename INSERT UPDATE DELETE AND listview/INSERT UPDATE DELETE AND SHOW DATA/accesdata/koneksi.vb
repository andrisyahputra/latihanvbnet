Imports MySql.Data.MySqlClient

Public Class DTConnection
    Dim connect As New MySqlConnection("server='localhost';user='root';password='';database='tes_crud'")

    Public Function open()
        Try
            connect.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return connect
    End Function

    Public Function close()
        Try
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return connect
    End Function
End Class