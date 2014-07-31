Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils

Public Class frmSalesManagement
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub fillSalesTable()
        Dim dt As New DataTable("SalesTable")
        dt.Columns.Add("ProductID")
        dt.Columns.Add("Model Name")
        dt.Columns.Add("Category")
        dt.Columns.Add("Unit")
        dt.Columns.Add("Price/Unit")
        dt.Columns.Add("Total")
        dt.Columns.Add("Description")
        dt.Columns.Add("CHECKPOINT")

        For i = 0 To 6
            dt.Rows.Add({DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, "EMPTY"})
        Next

        SalesDGV.DataSource = dt

        SalesGV.Columns(0).Visible = False

        SalesGV.Columns(1).Width = 144

        SalesGV.Columns(2).Width = 144

        SalesGV.Columns(3).Width = 38
        SalesGV.Columns(3).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        SalesGV.Columns(4).Width = 144

        SalesGV.Columns(5).Width = 144

        SalesGV.Columns(6).Width = 147

        SalesGV.Columns(7).Visible = False

        SalesGV.IndicatorWidth = 35
    End Sub

    Private Sub fillTotalSales()
        Dim dt As New DataTable("TotalSalesTable")
        dt.Columns.Add("EMPTY")
        dt.Columns.Add("CATEGORY")
        dt.Columns.Add("UNIT")
        dt.Columns.Add("PRICE/UNIT")
        dt.Columns.Add("TOTAL")

        dt.Rows.Add({"TOTAL", DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value})

        TotalSalesDGV.DataSource = dt

        TotalSalesGV.Columns(0).Width = 288

        TotalSalesGV.Columns(1).Width = 38

        TotalSalesGV.Columns(2).Width = 144

        TotalSalesGV.Columns(3).Width = 144

        TotalSalesGV.Columns(4).Width = 147

        TotalSalesGV.IndicatorWidth = 35

        TotalSalesGV.OptionsView.ShowColumnHeaders = False
    End Sub

    Private Sub frmSalesManagement_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillSalesTable()
        fillTotalSales()
        fillSearchCustomerGV()
    End Sub

    Private Sub SalesGV_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles SalesGV.CustomDrawRowIndicator
        If e.Info.IsRowIndicator Then
            e.Info.DisplayText = e.RowHandle.ToString() + 1
        End If
    End Sub

    Private Sub TotalSalesGV_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles TotalSalesGV.RowCellStyle
        e.Appearance.BackColor = Color.BlueViolet
        e.Appearance.ForeColor = Color.White
    End Sub

    Public Sub fillSearchCustomerGV()
        CustomerSearchDGV.DataSource = Nothing

        Try
            Dim da As New OleDbDataAdapter("SELECT tblCustomer.cust_id, tblCustomer.cust_name FROM tblCustomer", openConn())

            Dim dt As New DataTable

            da.Fill(dt)

            CustomerSearchDGV.DataSource = dt

            CustomerSearchGV.Columns(0).Visible = False 'cust_id

            CustomerSearchGV.Columns(1).Caption = "Customer Name"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PopupContainerCustomer_ButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PopupContainerCustomer.ButtonClick
        PopupContainerCustomer.ShowPopup()
        CustomerSearchGV.ClearColumnsFilter()
        PopupContainerCustomer.Focus()
    End Sub

    Private Sub PopupContainerCustomer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PopupContainerCustomer.Click
        PopupContainerCustomer.SelectAll()
    End Sub

    Private Sub PopupContainerCustomer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopupContainerCustomer.EditValueChanged
        PopupContainerCustomer.ShowPopup()
        CustomerSearchGV.ActiveFilter.NonColumnFilter = "[cust_name] LIKE '%" & PopupContainerCustomer.Text & "%'"
        PopupContainerCustomer.Focus()

        If PopupContainerCustomer.Text.Length = 0 Then
            CustomerSearchGV.ClearColumnsFilter()
        End If
    End Sub

    Dim CurrentCID As Integer = 0
    Private Sub CustomerSearchGV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerSearchGV.DoubleClick
        If CustomerSearchGV.SelectedRowsCount = 0 Then
            XtraMessageBox.Show("Please select a record to perform this action!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            CurrentCID = CustomerSearchGV.GetRowCellValue(CustomerSearchGV.FocusedRowHandle, "cust_id")
            PopupContainerCustomer.Text = CustomerSearchGV.GetRowCellValue(CustomerSearchGV.FocusedRowHandle, "cust_name")
            PopupContainerCustomer.ClosePopup()
        End If
    End Sub

    Private Sub SalesDGV_DoubleClick(sender As System.Object, e As System.EventArgs) Handles SalesDGV.DoubleClick
        If SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "CHECKPOINT") = "EMPTY" Then
            frmAddSalesItem.ShowDialog()
        Else
            'taken
            frmEditSalesItem.ProductModelName = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Model Name")
            frmEditSalesItem.CurrentPID = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "ProductID")
            frmEditSalesItem.txtCategory.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Category")
            frmEditSalesItem.txtUnit.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Unit")
            frmEditSalesItem.txtPricePerUnit.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Price/Unit")
            frmEditSalesItem.txtTotalPrice.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Total")
            frmEditSalesItem.txtDescription.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Description")
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "CHECKPOINT", "EDIT")
            frmEditSalesItem.ShowDialog()
        End If
    End Sub
End Class