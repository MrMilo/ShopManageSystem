Imports System.Data.OleDb
Imports DevExpress.XtraEditors

Public Class frmAddSupplier
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub frmAddStock_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtSupplierName.Text.Length = 0 Then
            txtSupplierName.ToolTipController.ShowHint("Please key in supplier name!", DevExpress.Utils.ToolTipLocation.BottomRight, txtSupplierName.PointToScreen(New Point(20, -15)))
        Else

            Dim insertNewSupplier As New OleDbCommand("INSERT INTO tblSupplier (supp_name, supp_contact, supp_address, supp_email, supp_facebook, supp_date_added, supp_debt, supp_note) VALUES (?, ?, ?, ?, ?, ?, ?, ?)", openConn())
            insertNewSupplier.Parameters.AddWithValue("supp_name", txtSupplierName.Text)
            insertNewSupplier.Parameters.AddWithValue("supp_contact", txtContact.Text)
            insertNewSupplier.Parameters.AddWithValue("suppt_address", txtAddress.Text)
            insertNewSupplier.Parameters.AddWithValue("supp_email", txtEmail.Text)
            insertNewSupplier.Parameters.AddWithValue("supp_facebook", txtFacebook.Text)
            insertNewSupplier.Parameters.AddWithValue("supp_date_added", DateTimePicker.Text)
            insertNewSupplier.Parameters.AddWithValue("supp_debt", txtDebt.Text)
            insertNewSupplier.Parameters.AddWithValue("supp_note", txtNote.Text)

            Try
                insertNewSupplier.ExecuteNonQuery()
                XtraMessageBox.Show("Supplier has been added!", "Supplier added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                txtSupplierName.Text = ""
                txtContact.Text = ""
                txtAddress.Text = ""
                txtEmail.Text = ""
                txtFacebook.Text = ""
                DateTimePicker.Text = Today
                txtDebt.Text = ""
                txtNote.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                frmSupplierManagement.fillSupplierGV()
                frmSupplierManagement.fillSearchSupplierGV()
            End Try
        End If
    End Sub

    Private Sub txtDebt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDebt.Click
        txtDebt.SelectAll()
    End Sub

    Private Sub txtDebt_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDebt.EditValueChanged
        txtOldDebt.Text = txtDebt.Text
    End Sub
End Class