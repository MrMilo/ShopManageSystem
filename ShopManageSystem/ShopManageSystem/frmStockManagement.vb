﻿Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils

Public Class frmStockManagement
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub frmStockManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillStockGV() 'fill stock grid view
        fillProductSearchGV() 'fill container product grid
        Try
            conn.Open()
            tvCategory.Nodes.Clear()
            tvCategoryDropDown.Nodes.Clear()
            fillTreeView("1", "All Categories", Nothing, tvCategory)
            fillTreeView("1", "All Categories", Nothing, tvCategoryDropDown)
            tvCategory.ExpandAll()
            tvCategoryDropDown.ExpandAll()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    'drawing row number
    Private Sub StockGV_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles StockGV.CustomDrawRowIndicator
        If e.Info.IsRowIndicator Then
            e.Info.DisplayText = e.RowHandle.ToString() + 1
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If StockGV.SelectedRowsCount > 0 Then 'confirm yes no
            Dim dialogResult = XtraMessageBox.Show("Are you sure you want to delete the selected data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If dialogResult = Windows.Forms.DialogResult.Yes Then
                Dim Rows As New ArrayList()
                ' Add the selected rows to the list.
                Dim I As Integer
                For I = 0 To StockGV.SelectedRowsCount() - 1
                    If (StockGV.GetSelectedRows()(I) >= 0) Then
                        Rows.Add(StockGV.GetDataRow(StockGV.GetSelectedRows()(I)))
                    End If
                Next

                For I = 0 To Rows.Count - 1
                    Dim Row As DataRow = CType(Rows(I), DataRow)

                    Dim deleteStockProduct As New OleDbCommand("DELETE FROM tblProduct WHERE prod_id = ?", conn)
                    deleteStockProduct.Parameters.AddWithValue("prod_id", Row("prod_id"))

                    Try
                        conn.Open()
                        deleteStockProduct.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        conn.Close()
                        deleteStockProduct.Parameters.Clear()
                    End Try
                Next
                XtraMessageBox.Show("The selected data has been deleted", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                'finally remove the rows from grid control, so that no repopulation is needed
                StockGV.DeleteSelectedRows()
            End If
        Else
            XtraMessageBox.Show("Please select a record to perform this action!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Public Sub fillStockGV()
        StockDGV.DataSource = Nothing

        Try
            Dim da As New OleDbDataAdapter("SELECT tblProduct.prod_id, tblProduct.prod_model, tblCategory.cat_name, tblProduct.prod_quantity, tblProduct.prod_cost, tblProduct.prod_price, tblProduct.prod_description, tblProduct.prod_category" _
                                            & " FROM tblCategory INNER JOIN tblProduct ON tblCategory.cat_id = tblProduct.prod_category", openConn())

            Dim dt As New DataTable

            da.Fill(dt)

            StockDGV.DataSource = dt

            'basic styling
            'StockGV.BestFitColumns()

            For i = 1 To 5
                StockGV.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Next

            StockGV.Columns(0).Visible = False 'prod_id

            StockGV.Columns(1).Caption = "Model"

            StockGV.Columns(2).Caption = "Category"
            StockGV.Columns(2).Width = 40

            StockGV.Columns(3).Caption = "Qty"
            StockGV.Columns(3).Width = 15
            StockGV.Columns(3).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            StockGV.Columns(4).Caption = "Cost"
            StockGV.Columns(4).Width = 40
            StockGV.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            StockGV.Columns(4).DisplayFormat.FormatString = "c2"

            StockGV.Columns(5).Caption = "Price"
            StockGV.Columns(5).Width = 40
            StockGV.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            StockGV.Columns(5).DisplayFormat.FormatString = "c2"

            StockGV.Columns(6).Visible = False 'prod_description

            StockGV.Columns(7).Visible = False 'prod_category
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        StockGV.IndicatorWidth = 35
    End Sub

    Public Sub fillProductSearchGV()
        ProductSearchDGV.DataSource = Nothing

        Try
            Dim da As New OleDbDataAdapter("SELECT tblCategory.cat_name, tblProduct.prod_model FROM tblCategory INNER JOIN tblProduct ON tblCategory.cat_id = tblProduct.prod_category", openConn())

            Dim dt As New DataTable

            da.Fill(dt)

            ProductSearchDGV.DataSource = dt

            For i = 0 To 1
                ProductSearchGV.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Next

            ProductSearchGV.Columns(0).Caption = "Category"

            ProductSearchGV.Columns(1).Caption = "Model"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim CurrentSelectedNodeID As Integer = 2
    Private Sub tvCategoryDropDown_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvCategoryDropDown.NodeMouseDoubleClick
        If tvCategoryDropDown.SelectedNode.Name = 1 Then
            PopupContainerCategory.ClosePopup()
        Else
            PopupContainerCategory.Text = tvCategoryDropDown.SelectedNode.Text
            PopupContainerCategory.ClosePopup()

            CurrentSelectedNodeID = tvCategoryDropDown.SelectedNode.Name
        End If
    End Sub

    Private Sub btnBuckChangeCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuckChangeCat.Click
        If StockGV.SelectedRowsCount > 0 Then
            Dim Rows As New ArrayList()
            ' Add the selected rows to the list.
            Dim I As Integer
            For I = 0 To StockGV.SelectedRowsCount() - 1
                If (StockGV.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(StockGV.GetDataRow(StockGV.GetSelectedRows()(I)))
                End If
            Next

            For I = 0 To Rows.Count - 1
                Dim Row As DataRow = CType(Rows(I), DataRow)

                Dim UpdateProductCat As New OleDbCommand("UPDATE tblProduct SET prod_category = ? WHERE prod_id = ?", conn)
                UpdateProductCat.Parameters.AddWithValue("prod_category", CurrentSelectedNodeID)
                UpdateProductCat.Parameters.AddWithValue("prod_id", Row("prod_id"))

                Try
                    conn.Open()
                    UpdateProductCat.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    conn.Close()
                    UpdateProductCat.Parameters.Clear()
                End Try
            Next

            'finally refresh gridview
            fillStockGV()
        Else
            XtraMessageBox.Show("Please select a record to perform this action!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub chkSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        If chkSelectAll.Checked = True Then
            StockGV.SelectAll()
        Else
            StockGV.ClearSelection()
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        frmAddStock.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click, StockGV.DoubleClick
        If StockGV.SelectedRowsCount > 1 Then
            XtraMessageBox.Show("You may only select one row of data!", "More than one data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf StockGV.SelectedRowsCount = 0 Then
            XtraMessageBox.Show("Please select a record to perform this action!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            frmEditStock.CurrentProdID = StockGV.GetRowCellValue(StockGV.FocusedRowHandle, "prod_id")
            frmEditStock.txtModel.Text = StockGV.GetRowCellValue(StockGV.FocusedRowHandle, "prod_model")
            frmEditStock.txtQuantity.Text = StockGV.GetRowCellValue(StockGV.FocusedRowHandle, "prod_quantity")
            frmEditStock.txtCost.Text = StockGV.GetRowCellValue(StockGV.FocusedRowHandle, "prod_cost")
            frmEditStock.txtPrice.Text = StockGV.GetRowCellValue(StockGV.FocusedRowHandle, "prod_price")
            frmEditStock.txtDescription.Text = StockGV.GetRowCellValue(StockGV.FocusedRowHandle, "prod_description")
            frmEditStock.pceDDCategory.Text = StockGV.GetRowCellValue(StockGV.FocusedRowHandle, "cat_name")
            frmEditStock.CurrentSelectedNodeID = StockGV.GetRowCellValue(StockGV.FocusedRowHandle, "prod_category")
            frmEditStock.ShowDialog()
        End If
    End Sub

    Dim HideZeroStockState As Integer = 0 '0 = no click ; 1 = click
    Private Sub btnHideZeroStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideZeroStock.Click
        If HideZeroStockState = 0 Then
            HideZeroStockState = 1
            StockGV.ActiveFilter.NonColumnFilter = "[prod_quantity] > 0"
            btnHideZeroStock.Text = "&Show All"
        Else
            HideZeroStockState = 0
            StockGV.ClearColumnsFilter()
            btnHideZeroStock.Text = "&Hide Zero Stock"
        End If

        fillStockGV()
    End Sub

    Private Sub ToolTipController_GetActiveObjectInfo(ByVal sender As Object, ByVal e As DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs) Handles ToolTipController.GetActiveObjectInfo
        If Not e.SelectedControl Is StockDGV Then Return

        Dim hitInfo As GridHitInfo = StockGV.CalcHitInfo(e.ControlMousePosition)

        If hitInfo.InRow = False Then Return

        Dim toolTipArgs As SuperToolTipSetupArgs = New SuperToolTipSetupArgs

        Dim drCurrentRow As DataRow = StockGV.GetDataRow(hitInfo.RowHandle)
        If drCurrentRow IsNot Nothing Then
            toolTipArgs.Title.Text = drCurrentRow(1).ToString
            toolTipArgs.Contents.Text = drCurrentRow(6).ToString
        End If

        e.Info = New ToolTipControlInfo
        e.Info.Object = hitInfo.HitTest.ToString() + hitInfo.RowHandle.ToString()
        e.Info.ToolTipType = ToolTipType.SuperTip
        e.Info.SuperTip = New SuperToolTip
        e.Info.SuperTip.Setup(toolTipArgs)
    End Sub

    Private Sub StockGV_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles StockGV.RowStyle
        Dim view As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim qty As Integer = view.GetRowCellDisplayText(e.RowHandle, view.Columns("prod_quantity"))
            If qty <= 0 Then
                e.Appearance.ForeColor = Color.DarkRed
            End If
        End If
    End Sub

    Private Sub PopUpContainerCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopupContainerCategory.Click
        tvCategoryDropDown.ExpandAll()
    End Sub

    Dim currentNodeCount As Integer = 0
    Dim NodeCollectionList As String = ""
    Private Sub CheckAllChildNodes(ByVal treeNode As TreeNode)
        Dim node As TreeNode
        For Each node In treeNode.Nodes
            currentNodeCount = currentNodeCount + 1
            NodeCollectionList = NodeCollectionList + node.Text + ","
            If node.Nodes.Count > 0 Then
                ' If the current node has child nodes, call the CheckAllChildsNodes method recursively. 
                CheckAllChildNodes(node)
            End If
        Next node
    End Sub

    Private Sub tvCategory_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvCategory.AfterSelect
        If tvCategory.SelectedNode.Name = 1 Then
            StockGV.ClearColumnsFilter()
        Else
            If e.Action <> TreeViewAction.Unknown Then
                currentNodeCount = 0 'reset value
                NodeCollectionList = "" 'reset value
                If e.Node.Nodes.Count > 0 Then
                    Me.CheckAllChildNodes(e.Node)
                End If
                NodeCollectionList = NodeCollectionList + tvCategory.SelectedNode.Text 'append the selected node
            End If

            If currentNodeCount > 0 Then
                Dim arr() As String = NodeCollectionList.Split(",")
                Dim vals As List(Of String) = arr.ToList
                Dim FilterText As String = ""

                For Each node As String In vals
                    FilterText = FilterText + "[cat_name] = '" & node & "'" + " OR "
                Next

                StockGV.ActiveFilter.NonColumnFilter = FilterText.Substring(0, FilterText.Length - 4)
            Else
                StockGV.ActiveFilter.NonColumnFilter = "[cat_name] = '" & NodeCollectionList & "'"
            End If
        End If
    End Sub

    Private Sub btnAddNewCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewCategory.Click
        frmAddCategory.ShowDialog()
    End Sub

    Private Sub PopupContainerProduct_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PopupContainerProduct.Click
        PopupContainerProduct.SelectAll()
    End Sub

    Private Sub PopupContainerProduct_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopupContainerProduct.EditValueChanged
        PopupContainerProduct.ShowPopup()
        ProductSearchGV.ActiveFilter.NonColumnFilter = "[prod_model] LIKE '%" & PopupContainerProduct.Text & "%'"
        PopupContainerProduct.Focus()
    End Sub

    Private Sub ProductSearchGV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductSearchGV.DoubleClick
        If ProductSearchGV.SelectedRowsCount = 0 Then
            XtraMessageBox.Show("Please select a record to perform this action!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            PopupContainerProduct.Text = ProductSearchGV.GetRowCellValue(ProductSearchGV.FocusedRowHandle, "prod_model")
            StockGV.ActiveFilter.NonColumnFilter = "[prod_model] = '" & ProductSearchGV.GetRowCellValue(ProductSearchGV.FocusedRowHandle, "prod_model") & "'"
            PopupContainerProduct.ClosePopup()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If PopupContainerProduct.Text.Length > 0 Then
            StockGV.ActiveFilter.NonColumnFilter = "[prod_model] LIKE '%" & PopupContainerProduct.Text & "%'"
        End If
    End Sub
End Class