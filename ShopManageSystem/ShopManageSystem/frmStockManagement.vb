Imports System.Data.OleDb
Imports DevExpress.XtraEditors

Public Class frmStockManagement
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub frmStockManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillStockGV() 'fill stock grid view

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

        'finally remove the rows from grid control, so that no repopulation is needed
        StockGV.DeleteSelectedRows()
    End Sub

    Private Sub fillStockGV()
        StockDGV.DataSource = Nothing

        Try
            Dim da As OleDbDataAdapter 'define it here so it escape the undefine error below

            If HideZeroStockState = 0 Then
                da = New OleDbDataAdapter("SELECT tblProduct.prod_id, tblProduct.prod_model, tblCategory.cat_name, tblProduct.prod_quantity, tblProduct.prod_cost, tblProduct.prod_price" _
                                                & " FROM tblCategory INNER JOIN tblProduct ON tblCategory.cat_id = tblProduct.prod_category", openConn())
            Else
                da = New OleDbDataAdapter("SELECT tblProduct.prod_id, tblProduct.prod_model, tblCategory.cat_name, tblProduct.prod_quantity, tblProduct.prod_cost, tblProduct.prod_price" _
                                                & " FROM tblCategory INNER JOIN tblProduct ON tblCategory.cat_id = tblProduct.prod_category WHERE tblProduct.prod_quantity > 0", openConn())
            End If

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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        StockGV.IndicatorWidth = 35
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

    Dim CurrentSelectedNodeID As Integer = 0
    Private Sub tvCategoryDropDown_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvCategoryDropDown.NodeMouseDoubleClick
        pceDDCategory.Text = tvCategoryDropDown.SelectedNode.Text
        pceDDCategory.ClosePopup()

        CurrentSelectedNodeID = tvCategoryDropDown.SelectedNode.Name
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
            XtraMessageBox.Show("Please select a record to perform this action!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

    Dim HideZeroStockState As Integer = 0 '0 = no click ; 1 = click
    Private Sub btnHideZeroStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideZeroStock.Click
        If HideZeroStockState = 0 Then
            HideZeroStockState = 1
            btnHideZeroStock.Text = "&Show All"
        Else
            HideZeroStockState = 0
            btnHideZeroStock.Text = "&Hide Zero Stock"
        End If

        fillStockGV()
    End Sub
End Class