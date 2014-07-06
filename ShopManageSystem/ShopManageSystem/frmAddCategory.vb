Imports System.Data.OleDb
Imports DevExpress.XtraEditors

Public Class frmAddCategory
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub frmAddCategory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmAddCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            fillTreeView("1", "All Categories", Nothing, tvCategoryDropDown)
            tvCategoryDropDown.ExpandAll()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Dim CurrentSelectedNodeID As Integer = 1
    Private Sub tvCategoryDropDown_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvCategoryDropDown.NodeMouseDoubleClick
        If tvCategoryDropDown.SelectedNode.Name = 1 Then
            pceDDCategory.ClosePopup()
        Else
            pceDDCategory.Text = tvCategoryDropDown.SelectedNode.Text
            pceDDCategory.ClosePopup()

            CurrentSelectedNodeID = tvCategoryDropDown.SelectedNode.Name
        End If

        tvCategoryDropDown.ExpandAll() 'always expand
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtCategoryName.Text.Length > 0 Then
            Dim InsertNewCategory As New OleDbCommand("INSERT INTO tblCategory (cat_name, cat_parent_id) VALUES (?, ?)", openConn())
            InsertNewCategory.Parameters.AddWithValue("cat_name", txtCategoryName.Text)
            InsertNewCategory.Parameters.AddWithValue("cat_parent_id", CurrentSelectedNodeID)

            Try
                InsertNewCategory.ExecuteNonQuery()
                XtraMessageBox.Show("Category has been added!", "Category added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                InsertNewCategory.Parameters.Clear()
                txtCategoryName.Text = ""
                txtCategoryName.Focus()
            End Try

            'refresh
            Try
                conn.Open()
                frmStockManagement.tvCategory.Nodes.Clear()
                frmStockManagement.tvCategoryDropDown.Nodes.Clear()
                fillTreeView("1", "All Categories", Nothing, frmStockManagement.tvCategory)
                fillTreeView("1", "All Categories", Nothing, frmStockManagement.tvCategoryDropDown)
                frmStockManagement.tvCategory.ExpandAll()
                frmStockManagement.tvCategoryDropDown.ExpandAll()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            txtCategoryName.ToolTipController.ShowHint("Cannot be empty!", DevExpress.Utils.ToolTipLocation.BottomRight, txtCategoryName.PointToScreen(New Point(20, -20)))
        End If
    End Sub
End Class