Imports System.Data.OleDb
Imports DevExpress.XtraEditors

Public Class frmEditCustomer
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub frmAddStock_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Public CurrentCustID As Integer = 0
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtCustomerName.Text.Length = 0 Then
            txtCustomerName.ToolTipController.ShowHint("Please key in customer name!", DevExpress.Utils.ToolTipLocation.BottomRight, txtCustomerName.PointToScreen(New Point(20, -15)))
        Else
            If txtPoints.Text.Length = 0 Then
                txtPoints.Text = "0"
            End If

            Dim UpdateCustomer As New OleDbCommand("UPDATE tblCustomer SET cust_name = ?, cust_contact = ?, cust_address = ?, cust_email = ?, cust_facebook = ?, cust_group = ?, cust_date_added = ?, cust_debt = ?, cust_points = ?, cust_note = ? WHERE cust_id = ?", openConn())
            UpdateCustomer.Parameters.AddWithValue("cust_name", txtCustomerName.Text)
            UpdateCustomer.Parameters.AddWithValue("cust_contact", txtContact.Text)
            UpdateCustomer.Parameters.AddWithValue("cust_address", txtAddress.Text)
            UpdateCustomer.Parameters.AddWithValue("cust_email", txtEmail.Text)
            UpdateCustomer.Parameters.AddWithValue("cust_facebook", txtFacebook.Text)
            UpdateCustomer.Parameters.AddWithValue("cust_group", cboGroup.SelectedValue)
            UpdateCustomer.Parameters.AddWithValue("cust_date_added", DateTimePicker.Text)
            UpdateCustomer.Parameters.AddWithValue("cust_debt", txtDebt.Text)
            UpdateCustomer.Parameters.AddWithValue("cust_points", txtPoints.Text)
            UpdateCustomer.Parameters.AddWithValue("cust_note", txtNote.Text)

            Try
                UpdateCustomer.ExecuteNonQuery()
                XtraMessageBox.Show("Customer has been edited!", "Customer edited", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                frmCustomerManagement.fillCustomerGV()
                frmCustomerManagement.fillSearchCustomerGV()
            End Try
        End If
    End Sub

    Private Sub txtPoints_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPoints.Click
        txtPoints.SelectAll()
    End Sub

    Private Sub txtDebt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDebt.Click
        txtDebt.SelectAll()
    End Sub

    Private Sub TextValidate(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPoints.KeyPress
        'must be numeric / back space
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            txtPoints.ToolTipController.ShowHint("Numeric only!", DevExpress.Utils.ToolTipLocation.BottomRight, txtPoints.PointToScreen(New Point(20, -5)))
            Beep()
        End If
    End Sub

    Private Sub fillGroupCbo()
        Dim da As New OleDbDataAdapter("SELECT custgroup_id, custgroup_type FROM tblCustomerGroup", openConn())
        Dim dt As New DataTable

        Try
            da.Fill(dt)

            cboGroup.DataSource = dt
            cboGroup.DisplayMember = "custgroup_type"
            cboGroup.ValueMember = "custgroup_id"

            'its okay to always select first data
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmAddCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillGroupCbo()
    End Sub

    Private Sub txtDebt_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDebt.EditValueChanged
        txtOldDebt.Text = txtOldDebt.Text + txtDebt.Text
    End Sub
End Class