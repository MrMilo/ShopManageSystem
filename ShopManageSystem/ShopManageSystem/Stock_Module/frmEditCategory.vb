Imports System.Data.OleDb
Imports DevExpress.XtraEditors

Public Class frmEditCategory
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
    Public NodeToEdit As Integer = 0
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

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtCategoryName.Text.Length > 0 Then
            If CurrentSelectedNodeID <> NodeToEdit Then
                Dim UpdateCategory As New OleDbCommand("UPDATE tblCategory SET cat_name = ?, cat_parent_id = ? WHERE cat_id = ?", openConn())
                UpdateCategory.Parameters.AddWithValue("cat_name", txtCategoryName.Text)
                UpdateCategory.Parameters.AddWithValue("cat_parent_id", CurrentSelectedNodeID)
                UpdateCategory.Parameters.AddWithValue("cat_id", NodeToEdit)

                Try
                    UpdateCategory.ExecuteNonQuery()
                    XtraMessageBox.Show("Category has been edited!", "Category added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    UpdateCategory.Parameters.Clear()
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

                Me.Dispose()
            Else
                XtraMessageBox.Show("You may not pick the category itself as a parent!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            txtCategoryName.ToolTipController.ShowHint("Cannot be empty!", DevExpress.Utils.ToolTipLocation.BottomRight, txtCategoryName.PointToScreen(New Point(20, -20)))
        End If
    End Sub
End Class