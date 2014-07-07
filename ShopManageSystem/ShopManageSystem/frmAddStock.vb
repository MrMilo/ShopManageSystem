Imports System.Data.OleDb
Imports DevExpress.XtraEditors

Public Class frmAddStock
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub frmAddStock_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmAddStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            tvCategoryDropDown.Nodes.Clear()
            fillTreeView("1", "All Categories", Nothing, tvCategoryDropDown)
            tvCategoryDropDown.ExpandAll()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        'AddHandler txtCost.KeyPress, AddressOf CurrencyKeyPress
        'AddHandler txtPrice.KeyPress, AddressOf CurrencyKeyPress
    End Sub

    Dim CurrentSelectedNodeID As Integer = 2
    Private Sub tvCategoryDropDown_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvCategoryDropDown.NodeMouseDoubleClick
        If tvCategoryDropDown.SelectedNode.Name = 1 Then
            pceDDCategory.ClosePopup()
        Else
            pceDDCategory.Text = tvCategoryDropDown.SelectedNode.Text
            pceDDCategory.ClosePopup()

            CurrentSelectedNodeID = tvCategoryDropDown.SelectedNode.Name
        End If
    End Sub

    Private Sub TextValidate(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        'must be numeric / back space
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            txtQuantity.ToolTipController.ShowHint("Numeric only!", DevExpress.Utils.ToolTipLocation.BottomRight, txtQuantity.PointToScreen(New Point(20, -5)))
            Beep()
        End If
    End Sub

    Private Sub txtCost_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCost.Click
        txtCost.SelectAll()
    End Sub

    Private Sub txtPrice_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrice.Click
        txtPrice.SelectAll()
    End Sub

    Private Sub txtQuantity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.Click
        txtQuantity.SelectAll()
    End Sub

    Private Sub txtPrice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.EditValueChanged, txtCost.EditValueChanged
        If txtCost.Text.Length > 0 And txtPrice.Text.Length > 0 Then 'both field have data
            lblProductProfit.Text = String.Format("{0:RM#,##0.00}", txtPrice.Text - txtCost.Text)
        End If
    End Sub

    Private Sub lblProductProfit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblProductProfit.TextChanged
        If lblProductProfit.Text > 0 Then
            lblProductProfit.ForeColor = Color.DarkGreen
        Else
            lblProductProfit.ForeColor = Color.DarkRed
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtModel.Text.Length = 0 Then
            txtModel.ToolTipController.ShowHint("Please key in product model name!", DevExpress.Utils.ToolTipLocation.BottomRight, txtModel.PointToScreen(New Point(20, -15)))
        Else
            Dim insertNewStock As New OleDbCommand("INSERT INTO tblProduct (prod_model, prod_quantity, prod_cost, prod_price, prod_description, prod_category) VALUES (?, ?, ?, ?, ?, ?)", openConn())
            insertNewStock.Parameters.AddWithValue("prod_model", txtModel.Text)
            insertNewStock.Parameters.AddWithValue("prod_quantity", txtQuantity.Text)
            insertNewStock.Parameters.AddWithValue("prod_cost", txtCost.Text)
            insertNewStock.Parameters.AddWithValue("prod_price", txtPrice.Text)
            insertNewStock.Parameters.AddWithValue("prod_description", txtDescription.Text)
            insertNewStock.Parameters.AddWithValue("prod_category", CurrentSelectedNodeID)

            Try
                insertNewStock.ExecuteNonQuery()
                XtraMessageBox.Show("Product has been added!", "Product added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                txtModel.Text = ""
                txtQuantity.Text = "0"
                txtCost.Text = ""
                txtPrice.Text = ""
                txtDescription.Text = ""
                txtModel.Focus()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                frmStockManagement.fillStockGV()
                frmStockManagement.fillProductSearchGV()
            End Try
        End If
    End Sub

    Private Sub pceDDCategory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pceDDCategory.Click
        tvCategoryDropDown.ExpandAll()
    End Sub
End Class