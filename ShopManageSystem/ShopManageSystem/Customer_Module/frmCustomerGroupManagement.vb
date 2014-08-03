Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCustomerGroupManagement
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub frmCustomerGroupManagement_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub txtPointsRequired_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPointsRequired.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            txtPointsRequired.ToolTipController.ShowHint("Numeric only!", DevExpress.Utils.ToolTipLocation.BottomRight, txtPointsRequired.PointToScreen(New Point(20, -5)))
            Beep()
        End If
    End Sub

    Private Sub txtDiscountRate_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            txtDiscountRate.ToolTipController.ShowHint("Numeric only!", DevExpress.Utils.ToolTipLocation.BottomRight, txtDiscountRate.PointToScreen(New Point(20, -5)))
            Beep()
        End If
    End Sub

    Private Sub fillCustomerGroup()
        CustomerGroupDGV.DataSource = Nothing

        Try
            Dim da As New OleDbDataAdapter("SELECT * FROM tblCustomerGroup", openConn())

            Dim dt As New DataTable

            da.Fill(dt)

            CustomerGroupDGV.DataSource = dt

            For i = 1 To 3
                CustomerGroupGV.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Next

            CustomerGroupGV.Columns(0).Visible = False 'prod_id

            CustomerGroupGV.Columns(1).Caption = "Group Type"

            CustomerGroupGV.Columns(2).Caption = "Discount Rate (%)"
            CustomerGroupGV.Columns(2).Width = 45
            CustomerGroupGV.Columns(2).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            CustomerGroupGV.Columns(3).Caption = "Points Required"
            CustomerGroupGV.Columns(3).Width = 40
            CustomerGroupGV.Columns(3).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        CustomerGroupGV.IndicatorWidth = 35
    End Sub

    Private Sub CustomerGroupGV_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles CustomerGroupGV.CustomDrawRowIndicator
        If e.Info.IsRowIndicator Then
            e.Info.DisplayText = e.RowHandle.ToString() + 1
        End If
    End Sub

    Private Sub CustomerGroupGV_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles CustomerGroupGV.RowStyle
        Dim view As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim cgid As Integer = view.GetRowCellDisplayText(e.RowHandle, view.Columns("custgroup_id"))
            If cgid = 1 Then
                e.Appearance.ForeColor = Color.Silver
            End If
        End If
    End Sub

    Private Sub frmCustomerGroupManagement_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillCustomerGroup()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim InsertIntoCustomerGroup As New OleDbCommand("INSERT INTO tblCustomerGroup (custgroup_type, custgroup_discount_rate, custgroup_points_required) VALUES (?, ?, ?)", openConn)
        InsertIntoCustomerGroup.Parameters.AddWithValue("custgroup_type", txtTypeName.Text)
        InsertIntoCustomerGroup.Parameters.AddWithValue("custgroup_discount_rate", txtDiscountRate.Text)
        If txtPointsRequired.Text.Length = 0 Then
            InsertIntoCustomerGroup.Parameters.AddWithValue("custgroup_points_required", 0)
        Else
            InsertIntoCustomerGroup.Parameters.AddWithValue("custgroup_points_required", txtPointsRequired.Text)
        End If

        If txtTypeName.Text.Length = 0 Then
            txtTypeName.ToolTipController.ShowHint("Please key in group type name!", DevExpress.Utils.ToolTipLocation.BottomRight, txtTypeName.PointToScreen(New Point(20, -15)))
        Else
            Try
                InsertIntoCustomerGroup.ExecuteNonQuery()

                txtTypeName.Text = ""
                txtDiscountRate.Text = ""
                txtPointsRequired.Text = 0

                XtraMessageBox.Show("You had successfully added the customer group type!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                fillCustomerGroup()
                InsertIntoCustomerGroup.Parameters.Clear()
            End Try
        End If
    End Sub

    Dim CustomerGroupID As Integer = 0
    Private Sub CustomerGroupGV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerGroupGV.DoubleClick
        If CustomerGroupGV.SelectedRowsCount = 0 Then
            XtraMessageBox.Show("Please select a record to perform this action!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CustomerGroupGV.GetRowCellValue(CustomerGroupGV.FocusedRowHandle, "custgroup_id") = 1 Then
            XtraMessageBox.Show("You may not edit this customer group type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            CustomerGroupID = CustomerGroupGV.GetRowCellValue(CustomerGroupGV.FocusedRowHandle, "custgroup_id")
            txtTypeName.Text = CustomerGroupGV.GetRowCellValue(CustomerGroupGV.FocusedRowHandle, "custgroup_type")
            txtDiscountRate.Text = CustomerGroupGV.GetRowCellValue(CustomerGroupGV.FocusedRowHandle, "custgroup_discount_rate")
            txtPointsRequired.Text = CustomerGroupGV.GetRowCellValue(CustomerGroupGV.FocusedRowHandle, "custgroup_points_required")

            btnAdd.Enabled = False
            btnEdit.Enabled = True
        End If
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        Dim EditCustomerGroup As New OleDbCommand("UPDATE tblCustomerGroup SET custgroup_type = ?, custgroup_discount_rate = ?, custgroup_points_required = ? WHERE custgroup_id = ?", openConn)
        EditCustomerGroup.Parameters.AddWithValue("custgroup_type", txtTypeName.Text)
        EditCustomerGroup.Parameters.AddWithValue("custgroup_discount_rate", txtDiscountRate.Text)
        EditCustomerGroup.Parameters.AddWithValue("custgroup_points_required", txtPointsRequired.Text)
        EditCustomerGroup.Parameters.AddWithValue("custgroup_id", CustomerGroupID)

        Try
            EditCustomerGroup.ExecuteNonQuery()

            txtTypeName.Text = ""
            txtDiscountRate.Text = ""
            txtPointsRequired.Text = ""

            btnEdit.Enabled = False
            btnAdd.Enabled = True

            XtraMessageBox.Show("You had successfully edited the customer group type!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            fillCustomerGroup()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If CustomerGroupGV.SelectedRowsCount > 0 Then 'confirm yes no
            Dim dialogResult = XtraMessageBox.Show("Are you sure you want to delete the selected data?" & vbNewLine & "WARNING : All affected customer will be updated to 'Normal' type!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Dim ContainDefaultData As Integer = 0

            If dialogResult = Windows.Forms.DialogResult.Yes Then
                Dim Rows As New ArrayList()
                ' Add the selected rows to the list.
                Dim I As Integer
                For I = 0 To CustomerGroupGV.SelectedRowsCount() - 1
                    If (CustomerGroupGV.GetSelectedRows()(I) >= 0) Then
                        Rows.Add(CustomerGroupGV.GetDataRow(CustomerGroupGV.GetSelectedRows()(I)))
                    End If
                Next

                For I = 0 To Rows.Count - 1
                    Dim Row As DataRow = CType(Rows(I), DataRow)

                    Dim UpdateCustomerGroup As New OleDbCommand("UPDATE tblCustomer SET cust_group = 1 WHERE cust_group = ?", conn)
                    UpdateCustomerGroup.Parameters.AddWithValue("cust_group", Row("custgroup_id"))

                    Try
                        conn.Open()
                        UpdateCustomerGroup.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        conn.Close()
                        UpdateCustomerGroup.Parameters.Clear()
                    End Try

                    If Row("custgroup_id") > 1 Then 'cannot delete normal
                        Dim deleteStockProduct As New OleDbCommand("DELETE FROM tblCustomerGroup WHERE custgroup_id = ?", conn)
                        deleteStockProduct.Parameters.AddWithValue("custgroup_id", Row("custgroup_id"))

                        Try
                            conn.Open()
                            deleteStockProduct.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            conn.Close()
                            deleteStockProduct.Parameters.Clear()
                        End Try
                    End If

                    If Row("custgroup_id") = 1 Then
                        ContainDefaultData = 1
                    End If
                Next

                If ContainDefaultData > 0 Then
                    XtraMessageBox.Show("The selected data has been deleted" & vbNewLine & "WARNING : You may not delete 'Normal' customer group!", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Else
                    XtraMessageBox.Show("The selected data has been deleted", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

                txtTypeName.Text = ""
                txtDiscountRate.Text = ""
                txtPointsRequired.Text = ""

                'refresh
                fillCustomerGroup()
                frmCustomerManagement.fillCustomerGV()
                frmCustomerManagement.fillSearchCustomerGV()
            End If
        Else
            XtraMessageBox.Show("Please select a record to perform this action!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class