Imports System.Data.OleDb
Imports DevExpress.XtraEditors

Public Class frmEditSalesItem
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub frmEditSalesItem_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Public CurrentPID As Integer = 0
    Private Sub PopupContainerProduct_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PopupContainerProduct.Click
        PopupContainerProduct.SelectAll()
    End Sub

    Private Sub PopupContainerProduct_ButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PopupContainerProduct.ButtonClick
        PopupContainerProduct.ShowPopup()
        StockGV.ClearColumnsFilter()
        PopupContainerProduct.Focus()
    End Sub

    Private Sub PopupContainerProduct_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopupContainerProduct.EditValueChanged
        PopupContainerProduct.ShowPopup()
        StockGV.ActiveFilter.NonColumnFilter = "[prod_model] LIKE '%" & PopupContainerProduct.Text & "%'"
        PopupContainerProduct.Focus()

        If PopupContainerProduct.Text.Length = 0 Then
            StockGV.ClearColumnsFilter()
        End If
    End Sub

    Dim ProductPrice As Integer = 0
    Private Sub StockGV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles StockGV.DoubleClick
        If StockGV.SelectedRowsCount = 0 Then
            XtraMessageBox.Show("Please select a record to perform this action!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            CurrentPID = StockGV.GetRowCellValue(StockGV.FocusedRowHandle, "prod_id")
            PopupContainerProduct.Text = StockGV.GetRowCellValue(StockGV.FocusedRowHandle, "prod_model")
            txtCategory.Text = StockGV.GetRowCellValue(StockGV.FocusedRowHandle, "cat_name")
            txtPricePerUnit.Text = StockGV.GetRowCellValue(StockGV.FocusedRowHandle, "prod_price")
            txtTotalPrice.Text = StockGV.GetRowCellValue(StockGV.FocusedRowHandle, "prod_price")
            ProductPrice = StockGV.GetRowCellValue(StockGV.FocusedRowHandle, "prod_price")
            txtDescription.Text = StockGV.GetRowCellValue(StockGV.FocusedRowHandle, "prod_model")

            CurrentStockQty = StockGV.GetRowCellValue(StockGV.FocusedRowHandle, "prod_quantity")

            txtTotalPrice.Text = ProductPrice * Val(txtUnit.Text)

            PopupContainerProduct.ClosePopup()
        End If
    End Sub

    Dim CurrentStockQty As Integer = 1
    Public Sub fillStockGV()
        StockDGV.DataSource = Nothing

        Try
            Dim da As New OleDbDataAdapter("SELECT tblProduct.prod_id, tblProduct.prod_model, tblCategory.cat_name, tblProduct.prod_quantity, tblProduct.prod_cost, tblProduct.prod_price, tblProduct.prod_description, tblProduct.prod_category" _
                                            & " FROM tblCategory INNER JOIN tblProduct ON tblCategory.cat_id = tblProduct.prod_category", openConn())

            Dim dt As New DataTable

            da.Fill(dt)

            StockDGV.DataSource = dt

            For i = 1 To 5
                StockGV.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Next

            StockGV.Columns(0).Visible = False 'prod_id

            StockGV.Columns(1).Caption = "Model"

            StockGV.Columns(2).Caption = "Category"
            StockGV.Columns(2).Width = 40

            StockGV.Columns(3).Visible = False 'qty

            StockGV.Columns(4).Visible = False 'cost

            StockGV.Columns(5).Visible = False 'price

            StockGV.Columns(6).Visible = False 'prod_description

            StockGV.Columns(7).Visible = False 'prod_category
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public ProductModelName As String = ""
    Private Sub frmEditSalesItem_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillStockGV()
        PopupContainerProduct.Text = ProductModelName
    End Sub

    Private Sub txtUnit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtUnit.EditValueChanged
        If txtUnit.Text > CurrentStockQty And CurrentPID <> 0 Then
            txtUnit.ToolTipController.ShowHint("WARNING : You only have " & CurrentStockQty & " stock left!", DevExpress.Utils.ToolTipLocation.BottomRight, txtUnit.PointToScreen(New Point(20, 10)))
        End If
        txtTotalPrice.Text = Val(txtUnit.Text) * ProductPrice
    End Sub

    Private Sub txtPricePerUnit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtPricePerUnit.EditValueChanged
        ProductPrice = txtPricePerUnit.Text
    End Sub

    Private Sub TextValidate(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnit.KeyPress
        'must be numeric / back space
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            txtUnit.ToolTipController.ShowHint("Numeric only!", DevExpress.Utils.ToolTipLocation.BottomRight, txtUnit.PointToScreen(New Point(20, -5)))
            Beep()
        End If
    End Sub

    Private Sub txtPricePerUnit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPricePerUnit.Click
        txtPricePerUnit.SelectAll()
    End Sub

    Private Sub txtTotalPrice_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotalPrice.Click
        txtTotalPrice.SelectAll()
    End Sub

    Private Sub txtUnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnit.Click
        txtUnit.SelectAll()
    End Sub
    'dt.Columns.Add("ProductID")
    'dt.Columns.Add("Model Name")
    'dt.Columns.Add("Category")
    'dt.Columns.Add("Unit")
    'dt.Columns.Add("Price/Unit")
    'dt.Columns.Add("Total")
    'dt.Columns.Add("Description")
    'dt.Columns.Add("CHECKPOINT")
    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If PopupContainerProduct.Text.Length > 0 And CurrentPID > 0 Then
            For i = 0 To frmSalesManagement.SalesGV.RowCount - 1
                If frmSalesManagement.SalesGV.GetRowCellValue(i, "CHECKPOINT") = "EDIT" Then
                    frmSalesManagement.SalesGV.SetRowCellValue(i, "ProductID", CurrentPID)
                    frmSalesManagement.SalesGV.SetRowCellValue(i, "Model Name", PopupContainerProduct.Text)
                    frmSalesManagement.SalesGV.SetRowCellValue(i, "Category", txtCategory.Text)
                    frmSalesManagement.SalesGV.SetRowCellValue(i, "Unit", txtUnit.Text)
                    frmSalesManagement.SalesGV.SetRowCellValue(i, "Price/Unit", txtPricePerUnit.Text)
                    frmSalesManagement.SalesGV.SetRowCellValue(i, "Total", txtTotalPrice.Text)
                    frmSalesManagement.SalesGV.SetRowCellValue(i, "Description", txtDescription.Text)
                    frmSalesManagement.SalesGV.SetRowCellValue(i, "CHECKPOINT", "TAKEN") 'taken

                    Me.Dispose()

                    Exit For 'exit loop
                End If
            Next
        Else
            PopupContainerProduct.ToolTipController.ShowHint("You must select a product to proceed edit!", DevExpress.Utils.ToolTipLocation.BottomRight, PopupContainerProduct.PointToScreen(New Point(20, -20)))
        End If
    End Sub
End Class