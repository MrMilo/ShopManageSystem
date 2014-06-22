Imports System.Data.OleDb
Imports DevExpress.XtraEditors

Module Library
    Public Sub formClose(ByVal e As System.Windows.Forms.FormClosingEventArgs)
        Dim response As MsgBoxResult
        response = XtraMessageBox.Show("Do you want to exit program?", "Exit Program?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            Environment.Exit(0)
        ElseIf response = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

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