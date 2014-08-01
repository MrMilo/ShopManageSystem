Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils

Public Class frmRestockOrderRecord
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

        For i = 0 To 12
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

    Private Sub frmSalesRecord_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillSalesTable()
        fillTotalSales()
    End Sub
End Class