Imports System.ComponentModel
Imports System.Text
Imports System.Data.OleDb
Imports DevExpress.XtraEditors

Public Class frmLogin
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub frmLogin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        formClose(Nothing)
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RemoveHandler cboUser.SelectedIndexChanged, AddressOf cboUser_SelectedIndexChanged 'to prevent selected index change function execute immediately, we'll need to remove the handler first

        fillAdminCombobox(cboUser) 'populate admin username into combobox

        AddHandler cboUser.SelectedIndexChanged, AddressOf cboUser_SelectedIndexChanged

        CheckPasswordExist()
    End Sub

    Dim PasswordNotSet As Integer = 0
    Public Sub cboUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUser.SelectedIndexChanged
        CheckPasswordExist()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If cboUser.SelectedIndex = -1 Then 'does not select anything
            XtraMessageBox.Show("Please select an admin to proceed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            XtraMessageBox.Show("Welcome to Shop Management System!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub CheckPasswordExist()
        lblPasswordNotSet.Visible = False

        Dim CheckIfPasswordSet As New OleDbCommand("SELECT admin_password FROM tblAdmin WHERE admin_username = ?", openConn())
        CheckIfPasswordSet.Parameters.AddWithValue("admin_username", cboUser.Text)

        Try
            If CheckIfPasswordSet.ExecuteScalar().ToString.Length = 0 Then
                PasswordNotSet = 0
            Else
                PasswordNotSet = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If PasswordNotSet = 0 Then
            lblPasswordNotSet.Visible = True
            lblPasswordNotSet.Text = "*Username '" & cboUser.Text & "' haven't set the password!"

            btnSetPassword.Enabled = True
        Else
            btnSetPassword.Enabled = True
            btnSetPassword.Text = "&Forget Password"
        End If
    End Sub
End Class