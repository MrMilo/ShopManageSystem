Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils
Imports DevExpress.XtraTab
Imports DevExpress.XtraCharts

Public Class frmStockSearch
    Inherits DevExpress.XtraEditors.XtraForm

    Public StringToSearch As String = "%%"

    Public Sub fillStockGV()
        ReportDGV.DataSource = Nothing

        Try
            Dim da As New OleDbDataAdapter("SELECT tblProduct.prod_id, tblProduct.prod_model, tblCategory.cat_name, tblProduct.prod_quantity, tblProduct.prod_cost, tblProduct.prod_price, tblProduct.prod_description, tblProduct.prod_category" _
                                            & " FROM tblCategory INNER JOIN tblProduct ON tblCategory.cat_id = tblProduct.prod_category WHERE tblProduct.prod_model LIKE ?", openConn())
            da.SelectCommand.Parameters.AddWithValue("prod_model", StringToSearch)

            Dim dt As New DataTable

            da.Fill(dt)

            ReportDGV.DataSource = dt

            For i = 1 To 5
                ReportGV.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Next

            ReportGV.Columns(0).Visible = False 'prod_id

            ReportGV.Columns(1).Caption = "Model"

            ReportGV.Columns(2).Caption = "Category"
            ReportGV.Columns(2).Width = 40

            ReportGV.Columns(3).Caption = "Qty"
            ReportGV.Columns(3).Width = 15
            ReportGV.Columns(3).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            ReportGV.Columns(4).Caption = "Cost"
            ReportGV.Columns(4).Width = 40
            ReportGV.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            ReportGV.Columns(4).DisplayFormat.FormatString = "c2"

            ReportGV.Columns(5).Caption = "Price"
            ReportGV.Columns(5).Width = 40
            ReportGV.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            ReportGV.Columns(5).DisplayFormat.FormatString = "c2"

            ReportGV.Columns(6).Visible = False 'prod_description

            ReportGV.Columns(7).Visible = False 'prod_category
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'ReportGV.IndicatorWidth = 35
    End Sub

    Private Sub frmStockSearch_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        fillStockGV()
    End Sub
End Class