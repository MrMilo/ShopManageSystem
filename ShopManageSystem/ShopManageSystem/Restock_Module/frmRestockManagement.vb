Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils
Imports DevExpress.XtraTab

Public Class frmRestockManagement
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub fillSalesTable()
        SalesDGV.DataSource = Nothing

        Dim dt As New DataTable("SalesTable")
        dt.Columns.Add("ProductID")
        dt.Columns.Add("Model Name")
        dt.Columns.Add("Category")
        dt.Columns.Add("Unit")
        dt.Columns.Add("Cost/Unit")
        dt.Columns.Add("Total")
        dt.Columns.Add("Description")
        dt.Columns.Add("CHECKPOINT")

        For i = 0 To 6
            dt.Rows.Add({"", DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, "EMPTY"})
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
        dt.Columns.Add("Cost/Unit")
        dt.Columns.Add("Total")
        dt.Columns.Add("Description")

        dt.Rows.Add({"TOTAL", "", "", ""})

        TotalSalesDGV.DataSource = dt

        TotalSalesGV.Columns(0).Width = 288

        TotalSalesGV.Columns(1).Width = 38

        TotalSalesGV.Columns(2).Width = 144

        TotalSalesGV.Columns(3).Width = 144

        TotalSalesGV.Columns(4).Width = 147

        TotalSalesGV.IndicatorWidth = 35

        TotalSalesGV.OptionsView.ShowColumnHeaders = False

        Dim PricePerUnit As Integer
        Dim TotalPrice As Integer

        For i = 0 To SalesGV.RowCount - 1
            If SalesGV.GetRowCellValue(i, "CHECKPOINT") = "TAKEN" Then
                PricePerUnit = PricePerUnit + Val(TotalSalesGV.GetRowCellValue(0, "Cost/Unit")) + Val(SalesGV.GetRowCellValue(i, "Cost/Unit").ToString.Substring(2))
                TotalPrice = TotalPrice + Val(TotalSalesGV.GetRowCellValue(0, "Total")) + Val(SalesGV.GetRowCellValue(i, "Total").ToString.Substring(2))

                TotalSalesGV.SetRowCellValue(0, "Unit", Val(TotalSalesGV.GetRowCellValue(0, "Unit")) + Val(SalesGV.GetRowCellValue(i, "Unit")))
                TotalSalesGV.SetRowCellValue(0, "Cost/Unit", Format(PricePerUnit, "RM000000.00"))
                TotalSalesGV.SetRowCellValue(0, "Total", Format(TotalPrice, "RM000000.00"))
            End If
        Next
    End Sub

    Public Sub fillSearchCustomerGV()
        SupplierSearchDGV.DataSource = Nothing

        Try
            Dim da As New OleDbDataAdapter("SELECT tblSupplier.supp_id, tblSupplier.supp_name FROM tblSupplier", openConn())

            Dim dt As New DataTable

            da.Fill(dt)

            SupplierSearchDGV.DataSource = dt

            SupplierSearchGV.Columns(0).Visible = False 'cust_id

            SupplierSearchGV.Columns(1).Caption = "Supplier Name"
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

    Private Sub ClearAll()
        RemoveHandler txtDiscountRate.EditValueChanged, AddressOf txtDiscountRate_EditValueChanged
        RemoveHandler PopupContainerSupplier.EditValueChanged, AddressOf PopupContainerCustomer_EditValueChanged

        fillSalesTable()
        fillTotalSales()
        fillSearchCustomerGV()
        GenerateUniqueReceiptNumber()

        PopupContainerSupplier.Text = ""
        txtNote.Text = ""
        txtDiscountRate.Text = ""
        txtDiscountedPrice.Text = ""
        txtPayment.Text = ""
        CurrentSID = 0
        DateTimePicker.Text = Today

        AddHandler txtDiscountRate.EditValueChanged, AddressOf txtDiscountRate_EditValueChanged
        AddHandler PopupContainerSupplier.EditValueChanged, AddressOf PopupContainerCustomer_EditValueChanged
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

    Private Sub PopupContainerCustomer_ButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PopupContainerSupplier.ButtonClick
        PopupContainerSupplier.ShowPopup()
        SupplierSearchGV.ClearColumnsFilter()
        PopupContainerSupplier.Focus()
    End Sub

    Private Sub PopupContainerCustomer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PopupContainerSupplier.Click
        PopupContainerSupplier.SelectAll()
    End Sub

    Private Sub PopupContainerCustomer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopupContainerSupplier.EditValueChanged
        If SupplierSearchGV.RowCount = 0 Then
            PopupContainerSupplier.ClosePopup()
            CurrentSID = 0
        Else
            PopupContainerSupplier.ShowPopup()
        End If

        SupplierSearchGV.ActiveFilter.NonColumnFilter = "[supp_name] LIKE '%" & PopupContainerSupplier.Text & "%'"
        PopupContainerSupplier.Focus()

        If PopupContainerSupplier.Text.Length = 0 Then
            SupplierSearchGV.ClearColumnsFilter()
        End If
    End Sub

    Dim CurrentSID As Integer = 0
    Private Sub CustomerSearchGV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles SupplierSearchGV.DoubleClick
        If SupplierSearchGV.SelectedRowsCount = 0 Then
            XtraMessageBox.Show("Please select a record to perform this action!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            CurrentSID = SupplierSearchGV.GetRowCellValue(SupplierSearchGV.FocusedRowHandle, "supp_id")
            PopupContainerSupplier.Text = SupplierSearchGV.GetRowCellValue(SupplierSearchGV.FocusedRowHandle, "supp_name")
            PopupContainerSupplier.ClosePopup()
        End If
    End Sub

    Private Sub SalesDGV_DoubleClick(sender As System.Object, e As System.EventArgs) Handles SalesDGV.DoubleClick
        If SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "CHECKPOINT") = "EMPTY" Then
            frmAddRestockItem.ShowDialog()
        Else
            'taken
            frmEditRestockItem.ProductModelName = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Model Name")
            If SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "ProductID") <> "INSERT" Then
                frmEditRestockItem.CurrentPID = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "ProductID")
            End If
            frmEditRestockItem.txtCategory.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Category")
            frmEditRestockItem.txtUnit.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Unit")
            frmEditRestockItem.txtPricePerUnit.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Cost/Unit")
            frmEditRestockItem.txtTotalPrice.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Total")
            frmEditRestockItem.txtDescription.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Description")
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "CHECKPOINT", "EDIT")
            frmEditRestockItem.ShowDialog()
        End If
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        frmAddRestockItem.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "CHECKPOINT") = "TAKEN" Then
            frmEditRestockItem.ProductModelName = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Model Name")
            If SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "ProductID") <> "INSERT" Then
                frmEditRestockItem.CurrentPID = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "ProductID")
            End If
            frmEditRestockItem.txtCategory.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Category")
            frmEditRestockItem.txtUnit.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Unit")
            frmEditRestockItem.txtPricePerUnit.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Cost/Unit")
            frmEditRestockItem.txtTotalPrice.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Total")
            frmEditRestockItem.txtDescription.Text = SalesGV.GetRowCellValue(SalesGV.FocusedRowHandle, "Description")
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "CHECKPOINT", "EDIT")
            frmEditRestockItem.ShowDialog()
        Else
            XtraMessageBox.Show("The selected row doesn't have a data for edit!", "Empty row", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnPlaceSales_Click(sender As System.Object, e As System.EventArgs) Handles btnPlaceSales.Click
        If PopupContainerSupplier.Text.Length > 0 Then
            For j = 0 To SalesGV.RowCount - 1
                If SalesGV.GetRowCellValue(j, "CHECKPOINT") = "TAKEN" Or SalesGV.GetRowCellValue(j, "ProductID") = "INSERT" Then 'contain data

                    If CurrentSID = 0 Then 'new supplier
                        Dim InsertNewCustomer As New OleDbCommand("INSERT INTO tblSupplier (supp_name, supp_date_added) VALUES (?,?)", conn)
                        InsertNewCustomer.Parameters.AddWithValue("supp_name", PopupContainerSupplier.Text)
                        InsertNewCustomer.Parameters.AddWithValue("supp_date_added", DateTime.Now.ToString("dd/MM/yyyy"))

                        Try
                            conn.Open()
                            InsertNewCustomer.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            conn.Close()
                        End Try

                        Dim GetNewSupplierID As New OleDbCommand("SELECT MAX(supp_id) FROM tblSupplier", conn)

                        Try
                            conn.Open()
                            CurrentSID = GetNewSupplierID.ExecuteScalar
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            conn.Close()
                        End Try
                    End If

                    For k = 0 To SalesGV.RowCount - 1
                        If SalesGV.GetRowCellValue(k, "ProductID") = "INSERT" Then 'need to add the product first
                            Dim InsertNewProduct As New OleDbCommand("INSERT INTO tblProduct (prod_model, prod_quantity, prod_cost) VALUES (?, ?, ?)", conn)
                            InsertNewProduct.Parameters.AddWithValue("prod_model", SalesGV.GetRowCellValue(k, "Model Name"))
                            InsertNewProduct.Parameters.AddWithValue("prod_quantity", SalesGV.GetRowCellValue(k, "Unit"))
                            InsertNewProduct.Parameters.AddWithValue("prod_cost", SalesGV.GetRowCellValue(k, "Cost/Unit"))

                            Try
                                conn.Open()
                                InsertNewProduct.ExecuteNonQuery()
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            Finally
                                conn.Close()
                                InsertNewProduct.Parameters.Clear()
                            End Try

                            'get new pid and change the "INSERT" to their respective PID
                            Dim GetNewPID As New OleDbCommand("SELECT MAX(prod_id) FROM tblProduct", conn)
                            Try
                                conn.Open()
                                SalesGV.SetRowCellValue(k, "ProductID", GetNewPID.ExecuteScalar)
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            Finally
                                conn.Close()
                            End Try
                        End If
                    Next

                    Dim InsertSalesRecord As New OleDbCommand("INSERT INTO tblSalesRecord (record_date, record_number, cust_id, discount_on_sales, sales_amount, sales_payment_made, sales_remark, sales_type) VALUES (?, ?, ?, ?, ?, ?, ?, 1)", conn)
                    InsertSalesRecord.Parameters.AddWithValue("record_date", DateTimePicker.Text)
                    InsertSalesRecord.Parameters.AddWithValue("record_number", lblReceiptNumber.Text)
                    InsertSalesRecord.Parameters.AddWithValue("cust_id", CurrentSID)
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
                                InsertSalesItemRecord.Parameters.AddWithValue("item_price", SalesGV.GetRowCellValue(i, "Cost/Unit"))
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
            PopupContainerSupplier.ToolTipController.ShowHint("Supplier field cannot be empty!", DevExpress.Utils.ToolTipLocation.BottomRight, PopupContainerSupplier.PointToScreen(New Point(20, -20)))
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
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "ProductID", DBNull.Value)
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "Model Name", DBNull.Value)
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "Category", DBNull.Value)
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "Unit", DBNull.Value)
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "Cost/Unit", DBNull.Value)
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "Total", DBNull.Value)
            SalesGV.SetRowCellValue(SalesGV.FocusedRowHandle, "Description", DBNull.Value)
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
        Dim Found As Boolean = False
        For pno As Integer = 0 To frmMain.TabControl.TabPages.Count - 1
            If frmMain.TabControl.TabPages(pno).Text = "Restock Order Record" Then
                Found = True
                frmMain.TabControl.SelectedTabPageIndex = pno
                Exit For
            End If
        Next

        If Not Found Then
            Dim TabPageResult As New XtraTabPage
            TabPageResult.Text = "Restock Order Record"
            frmMain.TabControl.TabPages.Add(TabPageResult)

            frmRestockOrderRecord.TopLevel = False
            frmRestockOrderRecord.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            frmRestockOrderRecord.Dock = DockStyle.Fill
            TabPageResult.Controls.Add(frmRestockOrderRecord)
            frmRestockOrderRecord.Show()
            frmMain.TabControl.SelectedTabPage = TabPageResult
        End If
    End Sub
End Class