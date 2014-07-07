Imports System.Data.OleDb
Imports DevExpress.XtraEditors

Public Class frmEditSupplier
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub frmAddStock_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Public CurrentSuppID As Integer = 0
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtSupplierName.Text.Length = 0 Then
            txtSupplierName.ToolTipController.ShowHint("Please key in supplier name!", DevExpress.Utils.ToolTipLocation.BottomRight, txtSupplierName.PointToScreen(New Point(20, -15)))
        Else
            Dim UpdateSupplier As New OleDbCommand("UPDATE tblSupplier SET supp_name = ?, supp_contact = ?, supp_address = ?, supp_email = ?, supp_facebook = ?, supp_date_added = ?, supp_debt = ?, supp_note = ? WHERE supp_id = ?", openConn())
            UpdateSupplier.Parameters.AddWithValue("supp_name", txtSupplierName.Text)
            UpdateSupplier.Parameters.AddWithValue("supp_contact", txtContact.Text)
            UpdateSupplier.Parameters.AddWithValue("supp_address", txtAddress.Text)
            UpdateSupplier.Parameters.AddWithValue("supp_email", txtEmail.Text)
            UpdateSupplier.Parameters.AddWithValue("supp_facebook", txtFacebook.Text)
            UpdateSupplier.Parameters.AddWithValue("supp_date_added", DateTimePicker.Text)
            UpdateSupplier.Parameters.AddWithValue("supp_debt", txtDebt.Text)
            UpdateSupplier.Parameters.AddWithValue("supp_note", txtNote.Text)
            UpdateSupplier.Parameters.AddWithValue("supp_id", CurrentSuppID)

            Try
                UpdateSupplier.ExecuteNonQuery()
                XtraMessageBox.Show("Supplier has been edited!", "Supplier edited", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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
        txtOldDebt.Text = txtOldDebt.Text + txtDebt.Text
    End Sub
End Class