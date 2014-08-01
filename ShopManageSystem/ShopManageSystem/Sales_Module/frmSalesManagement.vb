Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils

Public Class frmSalesManagement
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub fillSalesTable()
        SalesDGV.DataSource = Nothing

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

    Public Sub fillTotalSales()
        TotalSalesDGV.DataSource = Nothing

        Dim dt As New DataTable("TotalSalesTable")
        dt.Columns.Add("EMPTY")
        dt.Columns.Add("Unit")
        dt.Columns.Add("Price/Unit")
        dt.Columns.Add("Total")
        dt.Columns.Add("Description")

        dt.Rows.Add({"TOTAL", "", "", ""})

        TotalSalesDGV.DataSource = dt

        TotalSalesGV.Columns(0).Width = 288

        TotalSalesGV.Columns(1).Width = 38

        TotalSalesGV.Columns(2).Width = 144

        TotalSalesGV.Columns(3).Width = 144

        TotalSalesGV.Columns(4).Width = 144

        TotalSalesGV.IndicatorWidth = 35

        TotalSalesGV.OptionsView.ShowColumnHeaders = False

        Dim PricePerUnit As Integer
        Dim TotalPrice As Integer = 0

        For i = 0 To SalesGV.RowCount - 1
            If SalesGV.GetRowCellValue(i, "CHECKPOINT") = "TAKEN" Then
                PricePerUnit = PricePerUnit + Val(TotalSalesGV.GetRowCellValue(0, "Price/Unit")) + Val(SalesGV.GetRowCellValue(i, "Price/Unit").ToString.Substring(2))
                TotalPrice = TotalPrice + Val(TotalSalesGV.GetRowCellValue(0, "Total")) + Val(SalesGV.GetRowCellValue(i, "Total").ToString.Substring(2))

                TotalSalesGV.SetRowCellValue(0, "Unit", Val(TotalSalesGV.GetRowCellValue(0, "Unit")) + Val(SalesGV.GetRowCellValue(i, "Unit")))
                TotalSalesGV.SetRowCellValue(0, "Price/Unit", Format(PricePerUnit, "RM000000.00"))
                TotalSalesGV.SetRowCellValue(0, "Total", Format(TotalPrice, "RM000000.00"))
            End If
        Next
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

    Private Sub GenerateUniqueReceiptNumber()
        Dim GetMaxRecordID As New OleDbCommand("SELECT MAX(record_id) FROM tblSalesRecord", conn)
        Dim ReceiptNumber As Integer

        Try
            conn.Open()
            If IsDBNull(GetMaxRecordID.ExecuteScalar()) Then
                ReceiptNumber = 1
            Else
                ReceiptNumber = GetMaxRecordID.ExecuteScalar() + 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        lblReceiptNumber.Text = "MS" & DateTimePicker.Text & "-" & Format(ReceiptNumber, "0000")
    End Sub

    Private Sub ClearAll()
        RemoveHandler txtDiscountRate.EditValueChanged, AddressOf txtDiscountRate_EditValueChanged
        RemoveHandler PopupContainerCustomer.EditValueChanged, AddressOf PopupContainerCustomer_EditValueChanged

        fillSalesTable()
        fillTotalSales()
        fillSearchCustomerGV()
        GenerateUniqueReceiptNumber()

        PopupContainerCustomer.Text = ""
        txtNote.Text = ""
        txtDiscountRate.Text = ""
        txtDiscountedPrice.Text = ""
        txtPayment.Text = ""
        CurrentCID = 0
        DateTimePicker.Text = Today

        AddHandler txtDiscountRate.EditValueChanged, AddressOf txtDiscountRate_EditValueChanged
        AddHandler PopupContainerCustomer.EditValueChanged, AddressOf PopupContainerCustomer_EditValueChanged
    End Sub

    Private Sub frmSalesManagement_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillSalesTable()
        fillTotalSales()
        fillSearchCustomerGV()
        GenerateUniqueReceiptNumber()
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

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        frmAddSalesItem.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "CHECKPOINT") = "TAKEN" Then
            frmEditSalesItem.ProductModelName = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Model Name")
            frmEditSalesItem.CurrentPID = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "ProductID")
            frmEditSalesItem.txtCategory.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Category")
            frmEditSalesItem.txtUnit.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Unit")
            frmEditSalesItem.txtPricePerUnit.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Price/Unit")
            frmEditSalesItem.txtTotalPrice.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Total")
            frmEditSalesItem.txtDescription.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Description")
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "CHECKPOINT", "EDIT")
            frmEditSalesItem.ShowDialog()
        Else
            XtraMessageBox.Show("The selected row doesn't have a data for edit!", "Empty row", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnPlaceSales_Click(sender As System.Object, e As System.EventArgs) Handles btnPlaceSales.Click
        If CurrentCID > 0 Then
            For j = 0 To SalesGV.RowCount - 1
                If SalesGV.GetRowCellValue(j, "CHECKPOINT") = "TAKEN" Then 'contain data

                    Dim InsertSalesRecord As New OleDbCommand("INSERT INTO tblSalesRecord (record_date, record_number, cust_id, discount_on_sales, sales_amount, sales_payment_made, sales_remark) VALUES (?, ?, ?, ?, ?, ?, ?)", conn)
                    InsertSalesRecord.Parameters.AddWithValue("record_date", DateTimePicker.Text)
                    InsertSalesRecord.Parameters.AddWithValue("record_number", lblReceiptNumber.Text)
                    InsertSalesRecord.Parameters.AddWithValue("cust_id", CurrentCID)
                    InsertSalesRecord.Parameters.AddWithValue("discount_on_sales", txtDiscountRate.Text)
                    InsertSalesRecord.Parameters.AddWithValue("sales_amount", txtDiscountedPrice.Text)
                    InsertSalesRecord.Parameters.AddWithValue("sales_payment_made", txtPayment.Text)
                    InsertSalesRecord.Parameters.AddWithValue("sales_remark", txtNote.Text)

                    Try
                        conn.Open()
                        InsertSalesRecord.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        conn.Close()
                    End Try

                    For i = 0 To SalesGV.RowCount - 1
                        If SalesGV.GetRowCellValue(i, "CHECKPOINT") = "TAKEN" Then
                            Try
                                Dim InsertSalesItemRecord As New OleDbCommand("INSERT INTO tblSalesItemRecord (prod_id, record_id, item_quantity, item_price, item_total_price) VALUES (?, (DMax('record_id', 'tblSalesRecord')), ?, ?, ?)", conn)
                                InsertSalesItemRecord.Parameters.AddWithValue("prod_id", SalesGV.GetRowCellValue(i, "ProductID"))
                                InsertSalesItemRecord.Parameters.AddWithValue("item_quantity", SalesGV.GetRowCellValue(i, "Unit"))
                                InsertSalesItemRecord.Parameters.AddWithValue("item_price", SalesGV.GetRowCellValue(i, "Price/Unit"))
                                InsertSalesItemRecord.Parameters.AddWithValue("item_total_price", SalesGV.GetRowCellValue(i, "Total"))

                                conn.Open()
                                InsertSalesItemRecord.ExecuteNonQuery()
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            Finally
                                conn.Close()
                                InsertSalesRecord.Parameters.Clear()
                            End Try
                        End If
                    Next

                    btnOldSalesReport.ToolTipController.ShowHint("You can always check the sales history here!", DevExpress.Utils.ToolTipLocation.TopLeft, btnOldSalesReport.PointToScreen(New Point(20, -5)))

                    XtraMessageBox.Show("You had successfully recorded this sales order!", "Sales added", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ClearAll()

                    Exit For 'exit straight
                Else
                    XtraMessageBox.Show("Please add some items to place sales!", "No data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit For
                End If
            Next
        Else
            XtraMessageBox.Show("Please select a customer to continue!", "Customer empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtNote_Click(sender As Object, e As System.EventArgs) Handles txtNote.Click
        txtNote.SelectAll()
    End Sub

    Private Sub txtTotalPrice_Click(sender As Object, e As System.EventArgs) Handles txtDiscountedPrice.Click
        txtDiscountedPrice.SelectAll()
    End Sub

    Private Sub txtDiscountRate_Click(sender As Object, e As System.EventArgs) Handles txtDiscountRate.Click
        txtDiscountRate.SelectAll()
    End Sub

    Private Sub txtPayment_Click(sender As Object, e As System.EventArgs) Handles txtPayment.Click
        txtPayment.SelectAll()
    End Sub

    Private Sub txtDiscountRate_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtDiscountRate.EditValueChanged
        If txtDiscountRate.Text > 100 Then
            txtDiscountRate.ToolTipController.ShowHint("Value cannot be more than 100!", DevExpress.Utils.ToolTipLocation.BottomRight, txtDiscountRate.PointToScreen(New Point(20, -5)))
            txtDiscountedPrice.Text = ""
        Else
            txtDiscountedPrice.Text = TotalSalesGV.GetRowCellValue(0, "Total") - (TotalSalesGV.GetRowCellValue(0, "Total") * (Val(txtDiscountRate.Text) / 100))
        End If
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ClearAll()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If SalesGV.SelectedRowsCount > 0 Then
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "ProductID", DBNull.Value)
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "Model Name", DBNull.Value)
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "Category", DBNull.Value)
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "Unit", DBNull.Value)
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "Price/Unit", DBNull.Value)
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "Total", DBNull.Value)
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "Description", DBNull.Value)
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "CHECKPOINT", "EMPTY")
        Else
            XtraMessageBox.Show("Please select a data to delete!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class