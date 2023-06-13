Imports MySql.Data.MySqlClient

Public Class autoid
#Region "declare"
    Dim mycmd As New MySqlCommand
    Dim myconection As New DTConnection
    Dim dadapter As MySqlDataAdapter
    Dim dtable As New DataTable
    Dim objdatareader As MySqlDataReader
#End Region

#Region "ForGridView"
    Sub VwGridView()
        mycmd.Connection = myconection.open
        mycmd.CommandText = "SELECT * FROM `tb_testing` ORDER BY id asc"
        dadapter = New MySqlDataAdapter(mycmd)
        dtable.Rows.Clear()
        dadapter.Fill(dtable)
        If Not dtable Is Nothing AndAlso dtable.Rows.Count > 0 Then
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = dtable
            DataGridView1.Columns(0).DataPropertyName = "id"
            DataGridView1.Columns(1).DataPropertyName = "nama"
            DataGridView1.Columns(2).DataPropertyName = "pwd"
        End If
    End Sub
#End Region
#Region "ClickFridView"
    Sub CLICKgRIDvIEW()
        Dim i As Integer
        Try
            With DataGridView1
                If .CurrentCell.Value Is Nothing Then
                    Exit Sub
                Else
                    i = .CurrentRow.Index
                    TXTID.Text = .Rows(i).Cells(0).Value.ToString
                    TXTNAMA.Text = .Rows(i).Cells(1).Value.ToString
                    TXTPWD.Text = .Rows(i).Cells(2).Value.ToString
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
#End Region

#Region "autonumber"
    Sub autonumber()
        Dim autoID As Single
        mycmd.Connection = myconection.open
        mycmd.CommandText = "SELECT COUNT(*) AS totalField from tb_testing"
        objdatareader = mycmd.ExecuteReader
        While objdatareader.Read
            autoID = Val(objdatareader.Item("totalField").ToString) + 1
        End While
        Select Case Len(Trim(autoID))
            Case 1 : TXTID.Text = "NS000" + Trim(Str(autoID)) + Format(Now, "ddMMyyyyhhmmss")
            Case 2 : TXTID.Text = "NS00" + Trim(Str(autoID)) + Format(Now, "ddMMyyyyhhmmss")
            Case 3 : TXTID.Text = "NS0" + Trim(Str(autoID)) + Format(Now, "ddMMyyyyhhmmss")
        End Select
        myconection.close()
    End Sub
#End Region

    Private Sub BUTTONINSERT_Click(sender As Object, e As EventArgs) Handles BUTTONINSERT.Click
        mycmd.Connection = myconection.open
        mycmd.CommandText = "INSERT INTO `tb_testing`(`id`, `nama`, `pwd`) VALUES ('" & TXTID.Text & "','" & TXTNAMA.Text & "','" & TXTPWD.Text & "')"
        mycmd.ExecuteNonQuery()
        myconection.close()
        VwGridView()
        MsgBox("Berhasil Ditambah", MsgBoxStyle.Information, "Pesan")
    End Sub

    Private Sub BUTTONUPDATE_Click(sender As Object, e As EventArgs) Handles BUTTONUPDATE.Click

        mycmd.Connection = myconection.open
        mycmd.CommandText = "UPDATE `tb_testing` SET `nama`='" & TXTNAMA.Text & "',`pwd`='" & TXTPWD.Text & "' WHERE `id`='" & TXTID.Text & "'"
        mycmd.ExecuteNonQuery()
        myconection.close()
        VwGridView()
        MsgBox("Berhasil diubah", MsgBoxStyle.Information, "Pesan")
    End Sub

    Private Sub BUTTONSHOW_Click(sender As Object, e As EventArgs) Handles BUTTONSHOW.Click
        VwGridView()
    End Sub

    Private Sub BUTTONDELETE_Click(sender As Object, e As EventArgs) Handles BUTTONDELETE.Click
        mycmd.Connection = myconection.open
        mycmd.CommandText = "DELETE FROM `tb_testing` WHERE `id`='" & TXTID.Text & "'"
        mycmd.ExecuteNonQuery()
        myconection.close()
        VwGridView()
        MsgBox("Berhasil dihapus", MsgBoxStyle.Information, "Pesan")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        CLICKgRIDvIEW()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        autonumber()
    End Sub

End Class