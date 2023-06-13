Module ModuleKoneksiUno
    Dim SP As New System.IO.Ports.SerialPort

    Public Sub SP_Open(ByVal P As String, ByVal B As Integer)
        SP.PortName = P
        SP.BaudRate = B
        SP.Open()
    End Sub

    Public Sub SP_Close()
        SP.Close()
    End Sub

    Public Function SP_Read()
        Dim Result As String = ""
        Result = SP.ReadExisting
        Return Result
    End Function

    Public Function SP_Write(ByVal Str As String)
        SP.WriteLine(Str)
        Return Str
    End Function
End Module
