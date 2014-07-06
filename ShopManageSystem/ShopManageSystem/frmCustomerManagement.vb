Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils

Public Class frmCustomerManagement
    Inherits DevExpress.XtraEditors.XtraForm

    'drawing row number
    Private Sub CustomerGV_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles CustomerGV.CustomDrawRowIndicator
        If e.Info.IsRowIndicator Then
            e.Info.DisplayText = e.RowHandle.ToString() + 1
        End If
    End Sub

    Public Sub fillCustomerGV()
        CustomerDGV.DataSource = Nothing

        Try
            Dim da As New OleDbDataAdapter("SELECT tblCustomer.cust_id, tblCustomer.cust_name, tblCustomer.cust_contact, tblCustomerGroup.custgroup_type, tblCustomer.cust_debt" _
                                           & " FROM tblCustomer INNER JOIN tblCustomerGroup ON tblCustomer.cust_group = tblCustomerGroup.custgroup_id", openConn())

            Dim dt As New DataTable

            da.Fill(dt)

            CustomerDGV.DataSource = dt

            For i = 1 To 4
                CustomerGV.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Next

            CustomerGV.Columns(0).Visible = False 'cust_id

            CustomerGV.Columns(1).Caption = "Name"

            CustomerGV.Columns(2).Caption = "Contact"
            CustomerGV.Columns(2).Width = 25

            CustomerGV.Columns(3).Caption = "Type"
            CustomerGV.Columns(3).Width = 25

            CustomerGV.Columns(4).Caption = "Debt"
            CustomerGV.Columns(4).Width = 30
            CustomerGV.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            CustomerGV.Columns(4).DisplayFormat.FormatString = "c2"
            CustomerGV.Columns(4).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        CustomerGV.IndicatorWidth = 35
    End Sub

    Public Sub fillSearchCustomerGV()
        CustomerSearchDGV.DataSource = Nothing

        Try
            Dim da As New OleDbDataAdapter("SELECT tblCustomer.cust_id, tblCustomer.cust_name FROM tblCustomer", openConn())

            Dim dt As New DataTable

            da.Fill(dt)

            CustomerSearchDGV.DataSource = dt

            CustomerSearchGV.Columns(0).Visible = False 'cust_id

            CustomerSearchGV.Columns(1).Caption = "Name"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmCustomerManagement_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fillCustomerGV()
        fillSearchCustomerGV()

        If lblDebt.Text <= 0 Then
            lblDebt.ForeColor = Color.Green
        Else
            lblDebt.ForeColor = Color.DarkRed
        End If
    End Sub

    Dim HideZeroDebtState As Integer = 0 '0 = no click ; 1 = click
    Private Sub btnHideZeroDebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideZeroDebt.Click
        If HideZeroDebtState = 0 Then
            HideZeroDebtState = 1
            CustomerGV.ActiveFilter.NonColumnFilter = "[cust_debt] > 0"
            btnHideZeroDebt.Text = "&Show All"
        Else
            HideZeroDebtState = 0
            CustomerGV.ClearColumnsFilter()
            btnHideZeroDebt.Text = "&Hide Zero Debt"
        End If
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
            CustomerGV.ClearColumnsFilter()
        End If
    End Sub

    Private Sub CustomerSearchGV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerSearchGV.DoubleClick
        If CustomerSearchGV.SelectedRowsCount = 0 Then
            XtraMessageBox.Show("Please select a record to perform this action!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            PopupContainerCustomer.Text = CustomerSearchGV.GetRowCellValue(CustomerSearchGV.FocusedRowHandle, "cust_name")
            CustomerGV.ActiveFilter.NonColumnFilter = "[cust_name] = '" & CustomerSearchGV.GetRowCellValue(CustomerSearchGV.FocusedRowHandle, "cust_name") & "'"
            PopupContainerCustomer.ClosePopup()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If PopupContainerCustomer.Text.Length > 0 Then
            CustomerGV.ActiveFilter.NonColumnFilter = "[cust_name] LIKE '%" & PopupContainerCustomer.Text & "%'"
        Else
            CustomerGV.ClearColumnsFilter()
            CustomerSearchGV.ClearColumnsFilter()
        End If
    End Sub

    Private Sub chkSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        If chkSelectAll.Checked = True Then
            CustomerGV.SelectAll()
        Else
            CustomerGV.ClearSelection()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If CustomerGV.SelectedRowsCount > 0 Then 'confirm yes no
            Dim dialogResult = XtraMessageBox.Show("Are you sure you want to delete the selected data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If dialogResult = Windows.Forms.DialogResult.Yes Then
                Dim Rows As New ArrayList()
                ' Add the selected rows to the list.
                Dim I As Integer
                For I = 0 To CustomerGV.SelectedRowsCount() - 1
                    If (CustomerGV.GetSelectedRows()(I) >= 0) Then
                        Rows.Add(CustomerGV.GetDataRow(CustomerGV.GetSelectedRows()(I)))
                    End If
                Next

                For I = 0 To Rows.Count - 1
                    Dim Row As DataRow = CType(Rows(I), DataRow)

                    Dim deleteCustomer As New OleDbCommand("DELETE FROM tblCustomer WHERE cust_id = ?", conn)
                    deleteCustomer.Parameters.AddWithValue("cust_id", Row("cust_id"))

                    Try
                        conn.Open()
                        deleteCustomer.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        conn.Close()
                        deleteCustomer.Parameters.Clear()
                    End Try
                Next
                XtraMessageBox.Show("The selected data has been deleted", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                'finally remove the rows from grid control, so that no repopulation is needed
                CustomerGV.DeleteSelectedRows()

                'refresh
                fillCustomerGV()
            End If
        Else
            XtraMessageBox.Show("Please select a record to perform this action!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class