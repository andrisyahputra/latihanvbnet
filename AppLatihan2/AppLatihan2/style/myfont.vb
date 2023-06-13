Imports System.Drawing.Text
Imports System.Runtime.InteropServices

Module myfont
    Private _plc As PrivateFontCollection = Nothing

    Public ReadOnly Property getInstance(ByVal size As Single, ByVal style As FontStyle) As Font
        Get
            If _plc Is Nothing Then LoadFont()
            Return New Font(_plc.Families(0), size, style)
        End Get
    End Property

    Private Sub LoadFont()
        Try
            _plc = New PrivateFontCollection
            Dim fontMemPointer As IntPtr = Marshal.AllocCoTaskMem(My.Resources.DS_DIGIB.Length)

            Marshal.Copy(My.Resources.DS_DIGIB, 0, fontMemPointer, My.Resources.DS_DIGIB.Length)
            _plc.AddMemoryFont(fontMemPointer, My.Resources.DS_DIGIB.Length)
            Marshal.FreeCoTaskMem(fontMemPointer)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try
    End Sub
End Module
