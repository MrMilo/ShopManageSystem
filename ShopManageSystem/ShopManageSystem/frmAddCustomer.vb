Imports System.Data.OleDb
Imports DevExpress.XtraEditors

Public Class frmAddCustomer
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub frmAddStock_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtCustomerName.Text.Length = 0 Then
            txtCustomerName.ToolTipController.ShowHint("Please key in customer name!", DevExpress.Utils.ToolTipLocation.BottomRight, txtCustomerName.PointToScreen(New Point(20, -15)))
        Else
            If txtPoints.Text.Length = 0 Then
                txtPoints.Text = "0"
            End If

            Dim insertNewCustomer As New OleDbCommand("INSERT INTO tblCustomer (cust_name, cust_contact, cust_address, cust_email, cust_facebook, cust_group, cust_date_added, cust_debt, cust_points, cust_note) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", openConn())
            insertNewCustomer.Parameters.AddWithValue("cust_name", txtCustomerName.Text)
            insertNewCustomer.Parameters.AddWithValue("cust_contact", txtContact.Text)
            insertNewCustomer.Parameters.AddWithValue("cust_address", txtAddress.Text)
            insertNewCustomer.Parameters.AddWithValue("cust_email", txtEmail.Text)
            insertNewCustomer.Parameters.AddWithValue("cust_facebook", txtFacebook.Text)
            insertNewCustomer.Parameters.AddWithValue("cust_group", cboGroup.SelectedValue)
            insertNewCustomer.Parameters.AddWithValue("cust_date_added", DateTimePicker.Text)
            insertNewCustomer.Parameters.AddWithValue("cust_debt", txtDebt.Text)
            insertNewCustomer.Parameters.AddWithValue("cust_points", txtPoints.Text)
            insertNewCustomer.Parameters.AddWithValue("cust_note", txtNote.Text)

            Try
                insertNewCustomer.ExecuteNonQuery()
                XtraMessageBox.Show("Customer has been added!", "Customer added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                txtCustomerName.Text = ""
                txtContact.Text = ""
                txtAddress.Text = ""
                txtEmail.Text = ""
                txtFacebook.Text = ""
                cboGroup.SelectedIndex = 0
                DateTimePicker.Text = Today
                txtDebt.Text = ""
                txtPoints.Text = "0"
                txtNote.Text = ""
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
        txtOldDebt.Text = txtDebt.Text
    End Sub
End Class