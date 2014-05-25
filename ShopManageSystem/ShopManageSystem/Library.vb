Imports System.Data.OleDb

Module Library
    Public Sub fillAdminCombobox(ByVal sender As Object)
        Dim da As New OleDbDataAdapter("SELECT admin_username, admin_level FROM tblAdmin", openConn())
        Dim dt As New DataTable

        Try
            da.Fill(dt)
            sender.DataSource = dt
            sender.DisplayMember = "admin_username"
            sender.ValueMember = "admin_level"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module