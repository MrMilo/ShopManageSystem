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

    Public Sub fillTreeView(ByVal Key As String, ByVal Txt As String, ByVal N As TreeNode, ByVal sender As Object)
        Dim TN As TreeNode

        If N Is Nothing Then 'if no node
            TN = sender.Nodes.Add(Key, Txt) 'then this will be parent node, create the node
        Else
            TN = N.Nodes.Add(Key, Txt) 'use the node to add a child node
        End If

        'get the children of current node
        Dim getCategoryParent As New OleDbCommand("SELECT * FROM tblCategory WHERE cat_parent_id = ?", conn)
        getCategoryParent.Parameters.AddWithValue("cat_parent_id", Key)

        Dim sdr = getCategoryParent.ExecuteReader
        'recursive
        Do While sdr.Read()
            fillTreeView(sdr("cat_id"), sdr("cat_name"), TN, Nothing)
        Loop
        sdr.Close()
        getCategoryParent.Dispose()
    End Sub
End Module