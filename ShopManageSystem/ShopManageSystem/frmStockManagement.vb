Imports System.Data.OleDb

Public Class frmStockManagement
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub frmStockManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StockDGV.DataSource = Nothing

        Try
            Dim da As New OleDbDataAdapter("SELECT * FROM tblCategory", openConn()) 'testing
            Dim dt As New DataTable

            da.Fill(dt)

            StockDGV.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        StockGV.IndicatorWidth = 45
    End Sub

    'drawing row number
    Private Sub StockGV_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles StockGV.CustomDrawRowIndicator
        If e.Info.IsRowIndicator Then
            e.Info.DisplayText = e.RowHandle.ToString() + 1
        End If
    End Sub
End Class