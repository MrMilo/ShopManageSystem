Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils
Imports DevExpress.XtraTab

Public Class frmSalesOrderRecord
    Inherits DevExpress.XtraEditors.XtraForm
    Private Sub SalesOrderRecordGV_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles SalesOrderRecordGV.CustomDrawRowIndicator
        If e.Info.IsRowIndicator Then
            e.Info.DisplayText = e.RowHandle.ToString() + 1
        End If
    End Sub

    Private Sub TotalSalesGV_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles TotalSalesGV.CustomDrawRowIndicator
        e.Info.ImageIndex = -1
        e.Painter.DrawObject(e.Info)
    End Sub


    Private Sub ToolTipController_GetActiveObjectInfo(ByVal sender As Object, ByVal e As DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs) Handles ToolTipController.GetActiveObjectInfo
        If Not e.SelectedControl Is SalesOrderRecordDGV Then Return

        Dim hitInfo As GridHitInfo = SalesOrderRecordGV.CalcHitInfo(e.ControlMousePosition)

        If hitInfo.InRow = False Then Return

        Dim toolTipArgs As SuperToolTipSetupArgs = New SuperToolTipSetupArgs

        Dim drCurrentRow As DataRow = SalesOrderRecordGV.GetDataRow(hitInfo.RowHandle)
        Dim ContentText As String = ""

        If drCurrentRow(1).ToString.Length > 0 Then
            ContentText = ContentText + vbNewLine + "<b><u>Date</u></b>" & vbNewLine & Format(drCurrentRow(1), "yyyy-MM-dd")
        End If

        If drCurrentRow(3).ToString.Length > 0 Then
            ContentText = ContentText + vbNewLine + "<b><u>Customer Name</u></b>" & vbNewLine & drCurrentRow(3).ToString
        End If

        If drCurrentRow(4).ToString.Length > 0 Then
            ContentText = ContentText + vbNewLine + "<b><u>Sales Amount</u></b>" & vbNewLine & Format(drCurrentRow(4), "RM000000.00")
        End If

        If drCurrentRow(5).ToString.Length > 0 Then
            ContentText = ContentText + vbNewLine + "<b><u>Discounted Amount</u></b>" & vbNewLine & Format(drCurrentRow(5), "RM000000.00")
        End If

        If drCurrentRow(6).ToString.Length > 0 Then
            ContentText = ContentText + vbNewLine + "<b><u>Payment Made</u></b>" & vbNewLine & Format(drCurrentRow(6), "RM000000.00")
        End If

        If drCurrentRow(7).ToString.Length > 0 Then
            ContentText = ContentText + vbNewLine + "<b><u>Remark</u></b>" & vbNewLine & drCurrentRow(7).ToString
        End If


        If drCurrentRow IsNot Nothing Then
            toolTipArgs.Title.Text = drCurrentRow(2).ToString
            toolTipArgs.Contents.Text = ContentText
        End If

        e.Info = New ToolTipControlInfo
        e.Info.Object = hitInfo.HitTest.ToString() + hitInfo.RowHandle.ToString()
        e.Info.ToolTipType = ToolTipType.SuperTip
        e.Info.SuperTip = New SuperToolTip
        e.Info.SuperTip.Setup(toolTipArgs)
    End Sub

    Private Sub fillSalesOrderRecord()
        SalesOrderRecordDGV.DataSource = Nothing

        Dim da As New OleDbDataAdapter("SELECT tblSalesRecord.record_id, tblSalesRecord.record_date, tblSalesRecord.record_number, tblCustomer.cust_name, tblSalesRecord.sales_amount, (tblSalesRecord.sales_amount - ((tblSalesRecord.sales_amount) * (tblSalesRecord.discount_on_sales/100))) AS discounted_price, tblSalesRecord.sales_payment_made, tblSalesRecord.sales_remark" _
                                    & " FROM tblCustomer INNER JOIN tblSalesRecord ON tblCustomer.cust_id = tblSalesRecord.cust_id WHERE tblSalesRecord.sales_type = 0 AND tblSalesRecord.record_date = ?", conn)
        da.SelectCommand.Parameters.AddWithValue("record_date", DateTimePicker1.Text)

        Dim dt As New DataTable

        Try
            conn.Open()
            da.Fill(dt)

            SalesOrderRecordDGV.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        For i = 0 To 7
            SalesOrderRecordGV.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Next

        SalesOrderRecordGV.Columns(0).Visible = False 'record_id

        SalesOrderRecordGV.Columns(1).Width = 80
        SalesOrderRecordGV.Columns(1).Caption = "Record Date"
        SalesOrderRecordGV.Columns(1).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        SalesOrderRecordGV.Columns(1).DisplayFormat.FormatString = "yyyy-MM-dd"

        SalesOrderRecordGV.Columns(2).Width = 121
        SalesOrderRecordGV.Columns(2).Caption = "Receipt Number"

        SalesOrderRecordGV.Columns(3).Width = 130
        SalesOrderRecordGV.Columns(3).Caption = "Customer Name"

        SalesOrderRecordGV.Columns(4).Width = 100
        SalesOrderRecordGV.Columns(4).Caption = "Sales Amount"
        SalesOrderRecordGV.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        SalesOrderRecordGV.Columns(4).DisplayFormat.FormatString = "RM000000.00"

        SalesOrderRecordGV.Columns(5).Width = 110
        SalesOrderRecordGV.Columns(5).Caption = "Discounted Amount"
        SalesOrderRecordGV.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        SalesOrderRecordGV.Columns(5).DisplayFormat.FormatString = "RM000000.00"

        SalesOrderRecordGV.Columns(6).Width = 100
        SalesOrderRecordGV.Columns(6).Caption = "Payment Made"
        SalesOrderRecordGV.Columns(6).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        SalesOrderRecordGV.Columns(6).DisplayFormat.FormatString = "RM000000.00"

        SalesOrderRecordGV.Columns(7).Width = 120
        SalesOrderRecordGV.Columns(7).Caption = "Remark"

        SalesOrderRecordGV.IndicatorWidth = 35

        For i = 0 To 12 - SalesOrderRecordGV.RowCount
            dt.Rows.Add({0, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value})
        Next
    End Sub

    Public Sub fillTotalSales()
        TotalSalesDGV.DataSource = Nothing

        Dim dt As New DataTable("TotalSalesTable")
        dt.Columns.Add("EMPTY")
        dt.Columns.Add("Sales Amount")
        dt.Columns.Add("Discounted Amount")
        dt.Columns.Add("Payment Made")
        dt.Columns.Add("Remark")

        dt.Rows.Add({"TOTAL", "", "", "", ""})

        TotalSalesDGV.DataSource = dt

        TotalSalesGV.Columns(0).Width = 331

        TotalSalesGV.Columns(1).Width = 100

        TotalSalesGV.Columns(2).Width = 110

        TotalSalesGV.Columns(3).Width = 100

        TotalSalesGV.Columns(4).Width = 120

        TotalSalesGV.IndicatorWidth = 35

        TotalSalesGV.OptionsView.ShowColumnHeaders = False

        Dim SalesAmount As Integer
        Dim DiscountedAmount As Integer
        Dim PaymentMade As Integer

        For i = 0 To SalesOrderRecordGV.RowCount - 1
            If SalesOrderRecordGV.GetRowCellValue(i, "record_id") > 0 Then
                SalesAmount = SalesAmount + Val(TotalSalesGV.GetRowCellValue(0, "Sales Amount")) + Val(SalesOrderRecordGV.GetRowCellValue(i, "sales_amount"))
                DiscountedAmount = DiscountedAmount + Val(TotalSalesGV.GetRowCellValue(0, "Discounted Amount")) + Val(SalesOrderRecordGV.GetRowCellValue(i, "discounted_price"))
                PaymentMade = PaymentMade + Val(TotalSalesGV.GetRowCellValue(0, "Payment Made")) + Val(SalesOrderRecordGV.GetRowCellValue(i, "sales_payment_made"))

                TotalSalesGV.SetRowCellValue(0, "Sales Amount", Format(SalesAmount, "RM000000.00"))
                TotalSalesGV.SetRowCellValue(0, "Discounted Amount", Format(DiscountedAmount, "RM000000.00"))
                TotalSalesGV.SetRowCellValue(0, "Payment Made", Format(PaymentMade, "RM000000.00"))
            End If
        Next
    End Sub

    Private Sub fillSalesOrderRecordWithSearch()
        SalesOrderRecordDGV.DataSource = Nothing
        Dim SearchString As String = "%%"
        If txtSearch.Text.Length > 0 Then
            SearchString = "%" & txtSearch.Text & "%"
        End If

        Dim da As New OleDbDataAdapter("SELECT tblSalesRecord.record_id, tblSalesRecord.record_date, tblSalesRecord.record_number, tblCustomer.cust_name, tblSalesRecord.sales_amount, (tblSalesRecord.sales_amount - ((tblSalesRecord.sales_amount) * (tblSalesRecord.discount_on_sales/100))) AS discounted_price, tblSalesRecord.sales_payment_made, tblSalesRecord.sales_remark" _
                                    & " FROM tblCustomer INNER JOIN tblSalesRecord ON tblCustomer.cust_id = tblSalesRecord.cust_id WHERE tblSalesRecord.sales_type = 0 AND (record_date >= @date1 AND record_date <= @date2)  AND (tblSalesRecord.record_number LIKE ?) OR (tblCustomer.cust_name LIKE ?) OR (tblSalesRecord.sales_remark LIKE ?)", conn)
        da.SelectCommand.Parameters.AddWithValue("@date1", DateTimePicker1.Text)
        da.SelectCommand.Parameters.AddWithValue("@date2", DateTimePicker2.Text)
        da.SelectCommand.Parameters.AddWithValue("record_number", SearchString)
        da.SelectCommand.Parameters.AddWithValue("cust_name", SearchString)
        da.SelectCommand.Parameters.AddWithValue("sales_remark", SearchString)

        Dim dt As New DataTable

        Try
            conn.Open()
            da.Fill(dt)

            SalesOrderRecordDGV.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.SelectCommand.Parameters.Clear()
        End Try

        For i = 0 To 7
            SalesOrderRecordGV.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Next

        SalesOrderRecordGV.Columns(0).Visible = False 'record_id

        SalesOrderRecordGV.Columns(1).Width = 80
        SalesOrderRecordGV.Columns(1).Caption = "Record Date"
        SalesOrderRecordGV.Columns(1).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        SalesOrderRecordGV.Columns(1).DisplayFormat.FormatString = "yyyy-MM-dd"

        SalesOrderRecordGV.Columns(2).Width = 121
        SalesOrderRecordGV.Columns(2).Caption = "Receipt Number"

        SalesOrderRecordGV.Columns(3).Width = 130
        SalesOrderRecordGV.Columns(3).Caption = "Customer Name"

        SalesOrderRecordGV.Columns(4).Width = 100
        SalesOrderRecordGV.Columns(4).Caption = "Sales Amount"
        SalesOrderRecordGV.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        SalesOrderRecordGV.Columns(4).DisplayFormat.FormatString = "RM000000.00"

        SalesOrderRecordGV.Columns(5).Width = 110
        SalesOrderRecordGV.Columns(5).Caption = "Discounted Amount"
        SalesOrderRecordGV.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        SalesOrderRecordGV.Columns(5).DisplayFormat.FormatString = "RM000000.00"

        SalesOrderRecordGV.Columns(6).Width = 100
        SalesOrderRecordGV.Columns(6).Caption = "Payment Made"
        SalesOrderRecordGV.Columns(6).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        SalesOrderRecordGV.Columns(6).DisplayFormat.FormatString = "RM000000.00"

        SalesOrderRecordGV.Columns(7).Width = 120
        SalesOrderRecordGV.Columns(7).Caption = "Remark"

        SalesOrderRecordGV.IndicatorWidth = 35

        For i = 0 To 12 - SalesOrderRecordGV.RowCount
            dt.Rows.Add({0, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value})
        Next
    End Sub

    Private Sub frmSalesOrderRecord_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmSalesRecord_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillSalesOrderRecord()
        fillTotalSales()
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        fillSalesOrderRecordWithSearch()
    End Sub

    Private Sub btnExport_Click(sender As System.Object, e As System.EventArgs) Handles btnExport.Click
        If (Not System.IO.Directory.Exists(".\SalesRecordExport")) Then
            System.IO.Directory.CreateDirectory(".\SalesRecordExport")
        End If

        SalesOrderRecordDGV.ExportToXls(".\SalesRecordExport\" & DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") & "_SalesRecord.xls")
        XtraMessageBox.Show("The data has been successfully exported!" & vbNewLine & "You can find your file at : " & Application.StartupPath & "\SalesRecordExport\" & DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") & "_SalesRecord.xls", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If SalesOrderRecordGV.SelectedRowsCount > 0 And SalesOrderRecordGV.GetRowCellValue(SalesOrderRecordGV.FocusedRowHandle, "record_id") > 0 Then 'confirm yes no
            Dim dialogResult = XtraMessageBox.Show("Are you sure you want to delete the selected data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If dialogResult = Windows.Forms.DialogResult.Yes Then
                Dim DeleteSalesRecord As New OleDbCommand("DELETE FROM tblSalesRecord WHERE record_id = ?", conn)
                DeleteSalesRecord.Parameters.AddWithValue("record_id", SalesOrderRecordGV.GetRowCellValue(SalesOrderRecordGV.FocusedRowHandle, "record_id").ToString)

                Try
                    conn.Open()
                    DeleteSalesRecord.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    conn.Close()
                    DeleteSalesRecord.Parameters.Clear()
                End Try

                Dim DeleteSalesItemRecord As New OleDbCommand("DELETE FROM tblSalesItemRecord WHERE record_id = ?", conn)
                DeleteSalesItemRecord.Parameters.AddWithValue("record_id", SalesOrderRecordGV.GetRowCellValue(SalesOrderRecordGV.FocusedRowHandle, "record_id").ToString)

                Try
                    conn.Open()
                    DeleteSalesItemRecord.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    conn.Close()
                    DeleteSalesItemRecord.Parameters.Clear()
                End Try

                XtraMessageBox.Show("The selected data has been deleted", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                'refresh
                fillSalesOrderRecordWithSearch()
            End If
        Else
            XtraMessageBox.Show("Please select a record to perform this action!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If SalesOrderRecordGV.SelectedRowsCount > 0 And SalesOrderRecordGV.GetRowCellValue(SalesOrderRecordGV.FocusedRowHandle, "record_id") > 0 Then 'confirm yes no
            Dim Found As Boolean = False
            For pno As Integer = 0 To frmMain.TabControl.TabPages.Count - 1
                If frmMain.TabControl.TabPages(pno).Text = "Sales Order" Then
                    Found = True

                    frmSalesManagement.RecordID = SalesOrderRecordGV.GetRowCellValue(SalesOrderRecordGV.FocusedRowHandle, "record_id")
                    frmSalesManagement.fillSalesTableEdit()

                    Me.Close()
                    Exit For
                End If
            Next

            If Not Found Then
                Dim TabPageResult As New XtraTabPage
                TabPageResult.Text = "Sales Order"
                frmMain.TabControl.TabPages.Add(TabPageResult)

                frmSalesManagement.TopLevel = False
                frmSalesManagement.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                frmSalesManagement.Dock = DockStyle.Fill
                TabPageResult.Controls.Add(frmSalesManagement)
                frmSalesManagement.Show()
                frmSalesManagement.RecordID = SalesOrderRecordGV.GetRowCellValue(SalesOrderRecordGV.FocusedRowHandle, "record_id")
                frmSalesManagement.fillSalesTableEdit()

                frmMain.TabControl.SelectedTabPage = TabPageResult
            End If
        Else
            XtraMessageBox.Show("Please select a record to perform this action!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
End Class