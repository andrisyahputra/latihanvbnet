Module koneksi
    Public Class DTConnection
        Dim conect As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath.ToString & "\db_connect.mdb")

        Public Function open()
            conect.Open()


            Return conect
        End Function
        Public Function close()
            conect.Close()


            Return conect
        End Function

    End Class
End Module
