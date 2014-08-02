Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils
Imports DevExpress.XtraTab

Public Class frmRestockManagement
    Inherits DevExpress.XtraEditors.XtraForm

    Public Mode As Integer = 0 '0 = add, 1 = edit
    Public RecordID As Integer = 0 're-retrieve information
    Public Sub fillOldSalesInformation() 'customer, receipt number, etc.
        Dim da As New OleDbDataAdapter("SELECT tblSupplier.supp_id, tblSupplier.supp_name, tblSalesRecord.record_date, tblSalesRecord.record_number, tblSalesRecord.discount_on_sales, tblSalesRecord.sales_amount, tblSalesRecord.sales_payment_made" _
                                        & " FROM tblSalesRecord INNER JOIN tblSupplier ON tblSalesRecord.cust_id = tblSupplier.supp_id WHERE tblSalesRecord.record_id = ?", conn)
        da.SelectCommand.Parameters.AddWithValue("record_id", RecordID)

        Dim ds As New DataSet

        Try
            conn.Open()
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.SelectCommand.Parameters.Clear()
        End Try

        CurrentCID = ds.Tables(0).Rows(0)(0)
        PopupContainerCustomer.Text = ds.Tables(0).Rows(0)(1)
        DateTimePicker.Text = ds.Tables(0).Rows(0)(2)
        lblReceiptNumber.Text = ds.Tables(0).Rows(0)(3)

        If ds.Tables(0).Rows(0)(4) > 0 Then 'if got discount
            txtDiscountRate.Text = ds.Tables(0).Rows(0)(4)
            txtDiscountedPrice.Text = ds.Tables(0).Rows(0)(5) - (ds.Tables(0).Rows(0)(5) * (ds.Tables(0).Rows(0)(4) / 100)) 'sales amount * rate
        End If

        txtPayment.Text = ds.Tables(0).Rows(0)(6)

        PopupContainerCustomer.ClosePopup()
    End Sub

    Public Sub fillSalesTableEdit()
        SalesDGV.DataSource = Nothing
        SalesGV.Columns.Clear()

        Mode = 1
        ClearAll()
        btnClear.Text = "&Cancel"
        btnPlaceSales.Text = "&Update Sales"

        Dim da As New OleDbDataAdapter("SELECT tblProduct.prod_id, tblProduct.prod_model, tblCategory.cat_name, tblSalesItemRecord.item_quantity, tblSalesItemRecord.item_price, tblSalesItemRecord.item_total_price, tblProduct.prod_description" _
                                        & " FROM tblCategory INNER JOIN ((tblSalesItemRecord INNER JOIN tblSalesRecord ON tblSalesItemRecord.record_id = tblSalesRecord.record_id) INNER JOIN tblProduct ON tblSalesItemRecord.prod_id = tblProduct.prod_id) ON tblCategory.cat_id = tblProduct.prod_category WHERE tblSalesRecord.record_id = ?", conn)
        da.SelectCommand.Parameters.AddWithValue("record_id", RecordID)

        Dim dt As New DataTable
        Try
            conn.Open()
            da.Fill(dt)

            dt.Columns.Add("CHECKPOINT")

            SalesDGV.DataSource = dt

            For i = 0 To SalesGV.RowCount - 1
                If SalesGV.GetRowCellValue(i, "prod_id") > 0 Then
                    SalesGV.SetRowCellValue(i, "CHECKPOINT", "TAKEN")
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.SelectCommand.Parameters.Clear()
        End Try

        SalesGV.Columns(0).Visible = False
        'SalesGV.Columns(0).Caption = "ProductID"
        SalesGV.Columns(0).Caption = "ProductID"

        SalesGV.Columns(1).Width = 144
        SalesGV.Columns(1).Caption = "Model Name"

        SalesGV.Columns(2).Width = 144
        SalesGV.Columns(2).Caption = "Category"

        SalesGV.Columns(3).Width = 38
        SalesGV.Columns(3).Caption = "Unit"
        SalesGV.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        SalesGV.Columns(3).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        SalesGV.Columns(3).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near

        SalesGV.Columns(4).Width = 144
        SalesGV.Columns(4).Caption = "Price/Unit"
        SalesGV.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        SalesGV.Columns(4).DisplayFormat.FormatString = "RM000000.00"
        SalesGV.Columns(4).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near

        SalesGV.Columns(5).Width = 144
        SalesGV.Columns(5).Caption = "Total"
        SalesGV.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        SalesGV.Columns(5).DisplayFormat.FormatString = "RM000000.00"
        SalesGV.Columns(5).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near

        SalesGV.Columns(6).Width = 147
        SalesGV.Columns(6).Caption = "Description"

        SalesGV.Columns(7).Visible = False

        SalesGV.IndicatorWidth = 35

        For i = 0 To 6 - SalesGV.RowCount
            dt.Rows.Add({0, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, "EMPTY"})
        Next

        fillTotalSales()
        fillOldSalesInformation()
    End Sub

    Private Sub fillSalesTable()
        SalesDGV.DataSource = Nothing
        SalesGV.Columns.Clear()

        Dim dt As New DataTable("SalesTable")
        dt.Columns.Add("prod_id")
        dt.Columns.Add("prod_model")
        dt.Columns.Add("cat_name")
        dt.Columns.Add("item_quantity")
        dt.Columns.Add("item_price")
        dt.Columns.Add("item_total_price")
        dt.Columns.Add("prod_description")
        dt.Columns.Add("CHECKPOINT")

        For i = 0 To 6
            dt.Rows.Add({0, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, "EMPTY"})
        Next

        SalesDGV.DataSource = dt

        SalesGV.Columns(0).Visible = False

        SalesGV.Columns(1).Width = 144
        SalesGV.Columns(1).Caption = "Model Name"

        SalesGV.Columns(2).Width = 144
        SalesGV.Columns(2).Caption = "Category"

        SalesGV.Columns(3).Width = 38
        SalesGV.Columns(3).Caption = "Unit"
        SalesGV.Columns(3).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        SalesGV.Columns(4).Width = 144
        SalesGV.Columns(4).Caption = "Price/Unit"
        SalesGV.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        SalesGV.Columns(4).DisplayFormat.FormatString = "RM000000.00"
        SalesGV.Columns(4).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near

        SalesGV.Columns(5).Width = 144
        SalesGV.Columns(5).Caption = "Total"
        SalesGV.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        SalesGV.Columns(5).DisplayFormat.FormatString = "RM000000.00"
        SalesGV.Columns(5).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near

        SalesGV.Columns(6).Width = 147
        SalesGV.Columns(6).Caption = "Description"

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

        dt.Rows.Add({"TOTAL", 0, 0, 0, ""})

        TotalSalesDGV.DataSource = dt

        TotalSalesGV.Columns(0).Width = 288

        TotalSalesGV.Columns(1).Width = 38
        TotalSalesGV.Columns(1).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near

        TotalSalesGV.Columns(2).Width = 144
        TotalSalesGV.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        TotalSalesGV.Columns(2).DisplayFormat.FormatString = "RM000000.00"
        TotalSalesGV.Columns(2).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near

        TotalSalesGV.Columns(3).Width = 144
        TotalSalesGV.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        TotalSalesGV.Columns(3).DisplayFormat.FormatString = "RM000000.00"
        TotalSalesGV.Columns(3).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near

        TotalSalesGV.Columns(4).Width = 147

        TotalSalesGV.IndicatorWidth = 35

        TotalSalesGV.OptionsView.ShowColumnHeaders = False

        Dim PricePerUnit As Integer
        Dim TotalPrice As Integer = 0


        For i = 0 To SalesGV.RowCount - 1
            If SalesGV.GetRowCellValue(i, "CHECKPOINT") = "TAKEN" Then
                PricePerUnit = PricePerUnit + CInt(SalesGV.GetRowCellValue(i, "item_price"))
                TotalPrice = TotalPrice + CInt(SalesGV.GetRowCellValue(i, "item_total_price"))

                TotalSalesGV.SetRowCellValue(0, "Unit", Val(TotalSalesGV.GetRowCellValue(0, "Unit")) + Val(SalesGV.GetRowCellValue(i, "item_quantity")))
                TotalSalesGV.SetRowCellValue(0, "Price/Unit", Format(PricePerUnit, "RM000000.00"))
                TotalSalesGV.SetRowCellValue(0, "Total", Format(TotalPrice, "RM000000.00"))
            End If
        Next
    End Sub

    Public Sub fillSearchCustomerGV()
        CustomerSearchDGV.DataSource = Nothing

        Try
            Dim da As New OleDbDataAdapter("SELECT tblSupplier.supp_id, tblSupplier.supp_name FROM tblSupplier", openConn())

            Dim dt As New DataTable

            da.Fill(dt)

            CustomerSearchDGV.DataSource = dt

            CustomerSearchGV.Columns(0).Visible = False 'cust_id

            CustomerSearchGV.Columns(1).Caption = "Supplier Name"
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

        lblReceiptNumber.Text = "RM" & DateTimePicker.Value.ToString("ddMMyyyy") & "-" & Format(ReceiptNumber, "0000")
    End Sub

    Public Sub ClearAll()
        RemoveHandler txtDiscountRate.EditValueChanged, AddressOf txtDiscountRate_EditValueChanged
        RemoveHandler PopupContainerCustomer.EditValueChanged, AddressOf PopupContainerCustomer_EditValueChanged

        If Mode = 0 Then
            fillSalesTable()
            fillTotalSales()
            fillSearchCustomerGV()
            GenerateUniqueReceiptNumber()
        End If

        If Mode = 1 And btnClear.Text = "&Cancel" Then
            fillSalesTable()
            fillTotalSales()
            fillSearchCustomerGV()
            GenerateUniqueReceiptNumber()
            btnClear.Text = "&Clear"
            btnPlaceSales.Text = "&Place Sales"
            Mode = 0
        End If

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

    Private Sub TotalSalesGV_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles TotalSalesGV.CustomDrawRowIndicator
        e.Info.ImageIndex = -1
        e.Painter.DrawObject(e.Info)
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
        If CustomerSearchGV.RowCount = 0 Then
            PopupContainerCustomer.ClosePopup()
            CurrentCID = 0
        Else
            PopupContainerCustomer.ShowPopup()
        End If
        CustomerSearchGV.ActiveFilter.NonColumnFilter = "[supp_name] LIKE '%" & PopupContainerCustomer.Text & "%'"
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
            CurrentCID = CustomerSearchGV.GetRowCellValue(CustomerSearchGV.FocusedRowHandle, "supp_id")
            PopupContainerCustomer.Text = CustomerSearchGV.GetRowCellValue(CustomerSearchGV.FocusedRowHandle, "supp_name")
            PopupContainerCustomer.ClosePopup()
        End If
    End Sub

    Private Sub SalesDGV_DoubleClick(sender As System.Object, e As System.EventArgs) Handles SalesDGV.DoubleClick
        If SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "CHECKPOINT") = "EMPTY" Then
            frmAddRestockItem.ShowDialog()
        Else
            frmEditRestockItem.ProductModelName = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "prod_model")
            frmEditRestockItem.CurrentPID = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "prod_id")
            frmEditRestockItem.txtCategory.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "cat_name")
            frmEditRestockItem.txtUnit.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "item_quantity")
            frmEditRestockItem.txtPricePerUnit.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "item_price")
            frmEditRestockItem.txtTotalPrice.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "item_total_price")
            frmEditRestockItem.txtDescription.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "prod_description")
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "CHECKPOINT", "EDIT")
            frmEditRestockItem.ShowDialog()
        End If
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        frmAddRestockItem.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "CHECKPOINT") = "TAKEN" Then
            frmEditRestockItem.ProductModelName = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "prod_model")
            frmEditRestockItem.CurrentPID = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "prod_id")
            frmEditRestockItem.txtCategory.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "cat_name")
            frmEditRestockItem.txtUnit.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "item_quantity")
            frmEditRestockItem.txtPricePerUnit.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "item_price")
            frmEditRestockItem.txtTotalPrice.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "item_total_price")
            frmEditRestockItem.txtDescription.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "prod_description")
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "CHECKPOINT", "EDIT")
            frmEditRestockItem.ShowDialog()
        Else
            XtraMessageBox.Show("The selected row doesn't have a data for edit!", "Empty row", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnPlaceSales_Click(sender As System.Object, e As System.EventArgs) Handles btnPlaceSales.Click
        If PopupContainerCustomer.Text.Length > 0 Then
            For j = 0 To SalesGV.RowCount - 1
                If SalesGV.GetRowCellValue(j, "CHECKPOINT") = "TAKEN" Then 'contain data
                    If CurrentCID = 0 Then 'new customer
                        Dim InsertNewCustomer As New OleDbCommand("INSERT INTO tblSupplier (supp_name, supp_date_added) VALUES (?,?)", conn)
                        InsertNewCustomer.Parameters.AddWithValue("supp_name", PopupContainerCustomer.Text)
                        InsertNewCustomer.Parameters.AddWithValue("supp_date_added", DateTime.Now.ToString("dd/MM/yyyy"))

                        Try
                            conn.Open()
                            InsertNewCustomer.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            conn.Close()
                        End Try

                        Dim GetNewCustomerID As New OleDbCommand("SELECT MAX(supp_id) FROM tblSupplier", conn)

                        Try
                            conn.Open()
                            CurrentCID = GetNewCustomerID.ExecuteScalar
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            conn.Close()
                        End Try
                    End If

                    For k = 0 To SalesGV.RowCount - 1
                        If SalesGV.GetRowCellValue(k, "prod_id") = 0 And SalesGV.GetRowCellValue(k, "CHECKPOINT") = "TAKEN" Then 'need to get new id
                            Dim InsertSalesItemRecord As New OleDbCommand("INSERT INTO tblProduct (prod_model, prod_quantity, prod_cost) VALUES (?, ?, ?)", conn)
                            InsertSalesItemRecord.Parameters.AddWithValue("prod_model", SalesGV.GetRowCellValue(k, "prod_model"))
                            InsertSalesItemRecord.Parameters.AddWithValue("prod_quantity", 0 - SalesGV.GetRowCellValue(k, "item_quantity"))
                            InsertSalesItemRecord.Parameters.AddWithValue("prod_cost", SalesGV.GetRowCellValue(k, "item_price"))

                            Try
                                conn.Open()
                                InsertSalesItemRecord.ExecuteNonQuery()
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            Finally
                                conn.Close()
                                InsertSalesItemRecord.Parameters.Clear()
                            End Try
                        End If

                        Dim GetNewPID As New OleDbCommand("SELECT MAX(prod_id) FROM tblProduct", conn)
                        Try
                            conn.Open()
                            SalesGV.SetRowCellValue(k, "prod_id", GetNewPID.ExecuteScalar)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            conn.Close()
                        End Try
                    Next

                    If Mode = 0 Then 'add
                        Dim InsertSalesRecord As New OleDbCommand("INSERT INTO tblSalesRecord (record_date, record_number, cust_id, discount_on_sales, sales_amount, sales_payment_made, sales_remark, sales_type) VALUES (?, ?, ?, ?, ?, ?, ?, 1)", conn)
                        InsertSalesRecord.Parameters.AddWithValue("record_date", DateTimePicker.Text)
                        InsertSalesRecord.Parameters.AddWithValue("record_number", lblReceiptNumber.Text)
                        InsertSalesRecord.Parameters.AddWithValue("cust_id", CurrentCID)
                        InsertSalesRecord.Parameters.AddWithValue("discount_on_sales", txtDiscountRate.Text)
                        If txtDiscountRate.Text > 0 Or txtDiscountedPrice.Text > 0 Then
                            InsertSalesRecord.Parameters.AddWithValue("sales_amount", txtDiscountedPrice.Text)
                        Else
                            InsertSalesRecord.Parameters.AddWithValue("sales_amount", TotalSalesGV.GetRowCellValue(0, "Total"))
                        End If
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
                                Dim InsertSalesItemRecord As New OleDbCommand("INSERT INTO tblSalesItemRecord (prod_id, record_id, item_quantity, item_price, item_total_price) VALUES (?, (DMax('record_id', 'tblSalesRecord')), ?, ?, ?)", conn)
                                InsertSalesItemRecord.Parameters.AddWithValue("prod_id", SalesGV.GetRowCellValue(i, "prod_id"))
                                InsertSalesItemRecord.Parameters.AddWithValue("item_quantity", SalesGV.GetRowCellValue(i, "item_quantity"))
                                InsertSalesItemRecord.Parameters.AddWithValue("item_price", SalesGV.GetRowCellValue(i, "item_price"))
                                InsertSalesItemRecord.Parameters.AddWithValue("item_total_price", SalesGV.GetRowCellValue(i, "item_total_price"))

                                Try
                                    conn.Open()
                                    InsertSalesItemRecord.ExecuteNonQuery()
                                Catch ex As Exception
                                    MsgBox(ex.Message)
                                Finally
                                    conn.Close()
                                    InsertSalesItemRecord.Parameters.Clear()
                                End Try
                            End If
                        Next

                        Dim UpdateCustomerDebt As New OleDbCommand("UPDATE tblSupplier SET supp_debt = supp_debt + ? WHERE supp_id = ?", conn)
                        If txtDiscountRate.Text > 0 Or txtDiscountedPrice.Text > 0 Then
                            UpdateCustomerDebt.Parameters.AddWithValue("supp_debt", CInt(txtPayment.Text) - CInt(txtDiscountedPrice.Text))
                        Else
                            UpdateCustomerDebt.Parameters.AddWithValue("supp_debt", Val(txtPayment.Text) - TotalSalesGV.GetRowCellValue(0, "Total"))
                        End If
                        UpdateCustomerDebt.Parameters.AddWithValue("supp_id", CurrentCID)

                        Try
                            conn.Open()
                            UpdateCustomerDebt.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            conn.Close()
                        End Try

                        btnOldSalesReport.ToolTipController.ShowHint("You can always check the restock history here!", DevExpress.Utils.ToolTipLocation.TopLeft, btnOldSalesReport.PointToScreen(New Point(20, -5)))

                        XtraMessageBox.Show("You had successfully recorded this restock order!", "Restock order added", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ClearAll()

                        Exit For 'exit straight
                    Else
                        'update
                        Dim DeleteSalesItemRecord As New OleDbCommand("DELETE * FROM tblSalesItemRecord WHERE record_id = ?", conn)
                        DeleteSalesItemRecord.Parameters.AddWithValue("record_id", RecordID)

                        Try
                            conn.Open()
                            DeleteSalesItemRecord.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            conn.Close()
                            DeleteSalesItemRecord.Parameters.Clear()
                        End Try

                        For i = 0 To SalesGV.RowCount - 1
                            If SalesGV.GetRowCellValue(i, "CHECKPOINT") = "TAKEN" Then
                                Dim InsertSalesItemRecord As New OleDbCommand("INSERT INTO tblSalesItemRecord (prod_id, record_id, item_quantity, item_price, item_total_price) VALUES (?, ?, ?, ?, ?)", conn)
                                InsertSalesItemRecord.Parameters.AddWithValue("prod_id", SalesGV.GetRowCellValue(i, "prod_id"))
                                InsertSalesItemRecord.Parameters.AddWithValue("record_id", RecordID)
                                InsertSalesItemRecord.Parameters.AddWithValue("item_quantity", SalesGV.GetRowCellValue(i, "item_quantity"))
                                InsertSalesItemRecord.Parameters.AddWithValue("item_price", SalesGV.GetRowCellValue(i, "item_price"))
                                InsertSalesItemRecord.Parameters.AddWithValue("item_total_price", SalesGV.GetRowCellValue(i, "item_total_price"))

                                Try
                                    conn.Open()
                                    InsertSalesItemRecord.ExecuteNonQuery()
                                Catch ex As Exception
                                    MsgBox(ex.Message)
                                Finally
                                    conn.Close()
                                    InsertSalesItemRecord.Parameters.Clear()
                                End Try
                            End If
                        Next

                        Dim UpdateSalesRecord As New OleDbCommand("UPDATE tblSalesRecord SET record_date = ?, record_number = ?, cust_id = ?, discount_on_sales = ?, sales_amount = ?, sales_payment_made = ?, sales_remark = ? WHERE record_id = ?", conn)
                        UpdateSalesRecord.Parameters.AddWithValue("record_date", DateTimePicker.Text)
                        UpdateSalesRecord.Parameters.AddWithValue("record_number", lblReceiptNumber.Text)
                        UpdateSalesRecord.Parameters.AddWithValue("cust_id", CurrentCID)
                        UpdateSalesRecord.Parameters.AddWithValue("discount_on_sales", txtDiscountRate.Text)
                        If txtDiscountRate.Text > 0 Or txtDiscountedPrice.Text > 0 Then
                            UpdateSalesRecord.Parameters.AddWithValue("sales_amount", txtDiscountedPrice.Text)
                        Else
                            UpdateSalesRecord.Parameters.AddWithValue("sales_amount", TotalSalesGV.GetRowCellValue(0, "Total"))
                        End If
                        UpdateSalesRecord.Parameters.AddWithValue("sales_payment_made", txtPayment.Text)
                        UpdateSalesRecord.Parameters.AddWithValue("sales_remark", txtNote.Text)
                        UpdateSalesRecord.Parameters.AddWithValue("record_id", RecordID)

                        Try
                            conn.Open()
                            UpdateSalesRecord.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            conn.Close()
                        End Try

                        btnOldSalesReport.ToolTipController.ShowHint("You can always check the sales history here!", DevExpress.Utils.ToolTipLocation.TopLeft, btnOldSalesReport.PointToScreen(New Point(20, -5)))

                        XtraMessageBox.Show("You had successfully edited this restock order!", "Sales edited", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ClearAll()

                        Exit For
                    End If
                Else
                    XtraMessageBox.Show("Please add some items to place sales!", "No data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit For
                End If
            Next
        Else
            PopupContainerCustomer.ToolTipController.ShowHint("Customer field cannot be empty!", DevExpress.Utils.ToolTipLocation.BottomRight, PopupContainerCustomer.PointToScreen(New Point(20, -20)))
            Beep()
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
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "prod_id", DBNull.Value)
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "prod_model", DBNull.Value)
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "cat_name", DBNull.Value)
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "item_quantity", DBNull.Value)
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "item_price", DBNull.Value)
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "item_total_price", DBNull.Value)
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "prod_description", DBNull.Value)
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "CHECKPOINT", "EMPTY")
        Else
            XtraMessageBox.Show("Please select a data to delete!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnPayment_Click(sender As System.Object, e As System.EventArgs) Handles btnPayment.Click
        If txtDiscountedPrice.Text > 0 Or txtDiscountedPrice.Text > 0 Then
            txtPayment.Text = txtDiscountedPrice.Text
        Else
            txtPayment.Text = TotalSalesGV.GetRowCellValue(0, "Total")
        End If
    End Sub

    Private Sub btnExport_Click(sender As System.Object, e As System.EventArgs) Handles btnExport.Click
        If (Not System.IO.Directory.Exists(".\RestockExport")) Then
            System.IO.Directory.CreateDirectory(".\RestockExport")
        End If

        SalesDGV.ExportToXls(".\RestockExport\" & lblReceiptNumber.Text & "_Restock.xls")
        XtraMessageBox.Show("The data has been successfully exported!" & vbNewLine & "You can find your file at : " & Application.StartupPath & "\RestockExport\" & lblReceiptNumber.Text & "_Restock.xls", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnOldSalesReport_Click(sender As System.Object, e As System.EventArgs) Handles btnOldSalesReport.Click
        frmRestockOrderRecord.ShowDialog()
    End Sub
End Class