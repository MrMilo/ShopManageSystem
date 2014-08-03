Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils
Imports DevExpress.XtraTab
Imports DevExpress.XtraCharts

Public Class frmReporting
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub frmReporting_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        cboGraphViewOpt.SelectedIndex = 0
        fillChartControlTop5Product()
        fillChartControlTop5Customer()
        fillChartControlRevenue()

        btnGraphView.Enabled = True
        btnListView.Enabled = False
        cboGraphViewOpt.Enabled = False
        LabelControl3.Enabled = False

        fillReportingData()
        fillTotalSales()
    End Sub

    Private Sub fillReportingData()
        ReportDGV.DataSource = Nothing
        Dim da As New OleDbDataAdapter("SELECT tblSalesRecord.record_id, tblSalesRecord.record_date, tblSalesRecord.record_number, tblSalesRecord.sales_remark, tblCustomer.cust_name, tblSalesRecord.sales_note, tblSalesRecord.sales_payment_made" _
                                    & " FROM tblCustomer INNER JOIN tblSalesRecord ON tblCustomer.cust_id = tblSalesRecord.cust_id WHERE sales_type = 0 AND (tblSalesRecord.record_date >= @date1 AND tblSalesRecord.record_date <= @date2)", conn)
        da.SelectCommand.Parameters.AddWithValue("@date1", DateTimePicker1.Text)
        da.SelectCommand.Parameters.AddWithValue("@date2", DateTimePicker2.Text)

        Dim dt As New DataTable

        Try
            conn.Open()
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        For i = 0 To 11 - dt.Rows.Count
            dt.Rows.Add({DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value})
        Next

        ReportDGV.DataSource = dt

        ReportGV.Columns(0).Visible = False

        ReportGV.Columns(1).Width = 80
        ReportGV.Columns(1).Caption = "Record Date"
        ReportGV.Columns(1).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        ReportGV.Columns(1).DisplayFormat.FormatString = "yyyy-MM-dd"

        ReportGV.Columns(2).Width = 130
        ReportGV.Columns(2).Caption = "Receipt Number"

        ReportGV.Columns(3).Width = 150
        ReportGV.Columns(3).Caption = "Remark"

        ReportGV.Columns(4).Width = 130
        ReportGV.Columns(4).Caption = "Customer Name"

        ReportGV.Columns(5).Width = 150
        ReportGV.Columns(5).Caption = "Sales Note"

        ReportGV.Columns(6).Width = 120
        ReportGV.Columns(6).Caption = "Income"
        ReportGV.Columns(6).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        ReportGV.Columns(6).DisplayFormat.FormatString = "RM000000.00"
        ReportGV.Columns(6).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near

        ReportGV.IndicatorWidth = 35
    End Sub

    Public Sub fillTotalSales()
        TotalSalesDGV.DataSource = Nothing

        Dim dt As New DataTable("TotalSalesTable")
        dt.Columns.Add("EMPTY1")
        dt.Columns.Add("EMPTY2")
        dt.Columns.Add("EMPTY3")
        dt.Columns.Add("EMPTY4")
        dt.Columns.Add("EMPTY5")
        dt.Columns.Add("EMPTY6")

        Dim PrevIncome As Integer = 0

        Dim GetSumPaymentofPreviousMonth As New OleDbCommand("SELECT SUM(sales_payment_made) AS total_sales FROM tblSalesRecord WHERE MONTH(record_date) = ? AND sales_type = 0", conn)
        GetSumPaymentofPreviousMonth.Parameters.AddWithValue("record_date", DateTimePicker1.Value.Month - 1)

        Try
            conn.Open()
            If Not IsDBNull(GetSumPaymentofPreviousMonth.ExecuteScalar) Then
                PrevIncome = GetSumPaymentofPreviousMonth.ExecuteScalar
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            GetSumPaymentofPreviousMonth.Parameters.Clear()
        End Try

        dt.Rows.Add({DateTimePicker1.Value.ToString("yyyy-MM-01"), "", "Previous income", "", "", PrevIncome.ToString("RM000000.00")})

        Dim TotalIncome As Integer = 0
        For i = 0 To ReportGV.RowCount - 1
            If Not IsDBNull(ReportGV.GetRowCellValue(i, "record_id")) Then
                TotalIncome = TotalIncome + ReportGV.GetRowCellValue(i, "sales_payment_made")
            End If
        Next
        dt.Rows.Add({"TOTAL", "", "", "", "", (TotalIncome + PrevIncome).ToString("RM000000.00")})

        TotalSalesDGV.DataSource = dt

        TotalSalesGV.Columns(0).Width = 80

        TotalSalesGV.Columns(1).Width = 130
        TotalSalesGV.Columns(1).AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near

        TotalSalesGV.Columns(2).Width = 150
        TotalSalesGV.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric

        TotalSalesGV.Columns(3).Width = 130
        TotalSalesGV.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric

        TotalSalesGV.Columns(4).Width = 150

        TotalSalesGV.Columns(5).Width = 120

        TotalSalesGV.IndicatorWidth = 35

        TotalSalesGV.OptionsView.ShowColumnHeaders = False
    End Sub

    Private Sub TotalSalesGV_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles TotalSalesGV.RowCellStyle
        e.Appearance.BackColor = Color.BlueViolet
        e.Appearance.ForeColor = Color.White
    End Sub

    Private Sub ReportGV_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles ReportGV.CustomDrawRowIndicator
        If e.Info.IsRowIndicator Then
            e.Info.DisplayText = e.RowHandle.ToString() + 1
        End If
    End Sub

    Private Sub TotalSalesGV_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles TotalSalesGV.CustomDrawRowIndicator
        e.Info.ImageIndex = -1
        e.Painter.DrawObject(e.Info)
    End Sub

    Dim HaveTitleChartControl1 As Integer = 0
    Private Sub fillChartControlTop5Product()
        ChartControl.DataSource = Nothing

        Dim da As New OleDbDataAdapter("SELECT TOP 5 SUM(tblSalesItemRecord.item_quantity) AS total_qty, tblProduct.prod_model FROM tblProduct INNER JOIN tblSalesItemRecord ON tblProduct.prod_id = tblSalesItemRecord.prod_id GROUP BY tblProduct.prod_model ORDER BY SUM(tblSalesItemRecord.item_quantity) DESC", conn)
        Dim dt As New DataTable

        Try
            conn.Open()
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        'ChartControl.Series.Add("", DevExpress.XtraCharts.ViewType.Bar)
        If HaveTitleChartControl1 = 0 Then
            Dim Title As New ChartTitle()
            Title.Text = "Top 5 Sales Product of All-Time"
            ChartControl.Titles.Add(Title)
            HaveTitleChartControl1 = 1
        End If

        ChartControl.DataSource = dt
        ChartControl.SeriesDataMember = "prod_model"
        ChartControl.SeriesTemplate.ArgumentDataMember = "prod_model"
        ChartControl.SeriesTemplate.ValueDataMembers.AddRange("total_qty")
    End Sub

    Dim HaveTitleChartControl2 As Integer = 0
    Private Sub fillChartControlTop5Customer()
        ChartControl1.DataSource = Nothing

        Dim da As New OleDbDataAdapter("SELECT TOP 5 SUM(tblSalesRecord.sales_payment_made) AS total_sales, tblCustomer.cust_name FROM tblCustomer INNER JOIN tblSalesRecord ON tblCustomer.cust_id = tblSalesRecord.cust_id WHERE tblSalesRecord.sales_type = 0 GROUP BY tblCustomer.cust_name ORDER BY SUM(tblSalesRecord.sales_payment_made) DESC", conn)
        Dim dt As New DataTable

        Try
            conn.Open()
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        'ChartControl1.Series.Add("", DevExpress.XtraCharts.ViewType.Line)
        If HaveTitleChartControl2 = 0 Then
            Dim Title As New ChartTitle()
            Title.Text = "Top 5 Royal Customer of All-Time"
            ChartControl1.Titles.Add(Title)
            HaveTitleChartControl2 = 1
        End If

        ChartControl1.DataSource = dt
        ChartControl1.SeriesDataMember = "cust_name"
        ChartControl1.SeriesTemplate.ArgumentDataMember = "cust_name"
        ChartControl1.SeriesTemplate.ValueDataMembers.AddRange("total_sales")
    End Sub

    Dim HaveTitleChartControl3 As Integer = 0
    Private Sub fillChartControlRevenue()
        ChartControl2.DataSource = Nothing

        Dim da As New OleDbDataAdapter("SELECT SUM(sales_payment_made) AS total_sales, record_date FROM tblSalesRecord WHERE MONTH(record_date) = ? AND sales_type = 0 GROUP BY record_date ORDER BY record_date DESC", conn)
        da.SelectCommand.Parameters.AddWithValue("record_date", DateTime.Now.Month)

        Dim dt As New DataTable

        Try
            conn.Open()
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.SelectCommand.Parameters.Clear()
        End Try

        'ChartControl2.Series.Add("x", DevExpress.XtraCharts.ViewType.Line)
        If HaveTitleChartControl3 = 0 Then
            Dim Title As New ChartTitle()
            Title.Text = "Revenue of the month"
            ChartControl2.Titles.Add(Title)
            HaveTitleChartControl3 = 1
        End If

        ChartControl2.DataSource = dt
        ChartControl2.SeriesDataMember = "record_date"
        ChartControl2.SeriesTemplate.ArgumentDataMember = "record_date"
        ChartControl2.SeriesTemplate.ValueDataMembers.AddRange("total_sales")
        'ChartControl2.SeriesTemplate.View = New LineSeriesView
    End Sub

    Private Sub btnListView_Click(sender As System.Object, e As System.EventArgs) Handles btnListView.Click
        XtraTabControl1.SelectedTabPageIndex = 0
        btnGraphView.Enabled = True
        btnListView.Enabled = False
        cboGraphViewOpt.Enabled = False
        LabelControl3.Enabled = False
    End Sub

    Private Sub btnGraphView_Click(sender As System.Object, e As System.EventArgs) Handles btnGraphView.Click
        XtraTabControl1.SelectedTabPageIndex = 1
        btnGraphView.Enabled = False
        btnListView.Enabled = True
        cboGraphViewOpt.Enabled = True
        LabelControl3.Enabled = True
        cboGraphViewOpt.SelectedIndex = 0
    End Sub

    Private Sub cboGraphViewOpt_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboGraphViewOpt.SelectedIndexChanged
        If cboGraphViewOpt.SelectedIndex = 0 Then
            XtraTabControl2.SelectedTabPageIndex = 0
        ElseIf cboGraphViewOpt.SelectedIndex = 1 Then
            XtraTabControl2.SelectedTabPageIndex = 1
        ElseIf cboGraphViewOpt.SelectedIndex = 2 Then
            XtraTabControl2.SelectedTabPageIndex = 2
        End If
    End Sub

    Private Sub btnExport_Click(sender As System.Object, e As System.EventArgs) Handles btnExport.Click
        If btnGraphView.Enabled = False Then 'now in graph view mode
            If XtraTabControl2.SelectedTabPageIndex = 0 Then
                If (Not System.IO.Directory.Exists(".\Top5ProductExport")) Then
                    System.IO.Directory.CreateDirectory(".\Top5ProductExport")
                End If

                ChartControl.ExportToXls(".\Top5ProductExport\" & DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") & "_Top5Product.xls")
                XtraMessageBox.Show("The data has been successfully exported!" & vbNewLine & "You can find your file at : " & Application.StartupPath & "\Top5ProductExport\" & DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") & "_Top5Product.xls", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf XtraTabControl2.SelectedTabPageIndex = 1 Then
                If (Not System.IO.Directory.Exists(".\Top5CustomerExport")) Then
                    System.IO.Directory.CreateDirectory(".\Top5CustomerExport")
                End If

                ChartControl.ExportToXls(".\Top5CustomerExport\" & DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") & "_Top5Customer.xls")
                XtraMessageBox.Show("The data has been successfully exported!" & vbNewLine & "You can find your file at : " & Application.StartupPath & "\Top5CustomerExport\" & DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") & "_Top5Customer.xls", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf XtraTabControl2.SelectedTabPageIndex = 2 Then
                If (Not System.IO.Directory.Exists(".\ShopAvenueExport")) Then
                    System.IO.Directory.CreateDirectory(".\ShopAvenueExport")
                End If

                ChartControl.ExportToXls(".\ShopAvenueExport\" & DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") & "_ShopAvenue.xls")
                XtraMessageBox.Show("The data has been successfully exported!" & vbNewLine & "You can find your file at : " & Application.StartupPath & "\ShopAvenueExport\" & DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") & "_ShopAvenue.xls", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        fillTotalSales()
    End Sub
End Class