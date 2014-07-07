Imports System.Data.OleDb
Imports DevExpress.XtraEditors

Public Class frmSetPassword
    Inherits DevExpress.XtraEditors.XtraForm
    Public GetAdminID As Integer
    Public GetAdminUserName As String

    Private Sub frmSetPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim GetAdminEmail As New OleDbCommand("SELECT admin_email FROM tblAdmin WHERE admin_id = ?", openConn())
        GetAdminEmail.Parameters.AddWithValue("admin_id", GetAdminID)

        Try
            txtEmailAddress.Text = GetAdminEmail.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        lblUsername.Text = GetAdminUserName.ToString
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        If txtPassword.Text.GetHashCode <> txtRePassword.Text.GetHashCode Then
            XtraMessageBox.Show("Your passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtPassword.Text.GetHashCode = txtRePassword.Text.GetHashCode And txtEmailAddress.Text.Length <> 0 Then
            Dim UpdateBossData As New OleDbCommand("UPDATE tblAdmin SET admin_email = ?, admin_password = ? WHERE admin_id = ?", openConn())
            UpdateBossData.Parameters.AddWithValue("admin_email", txtEmailAddress.Text)
            UpdateBossData.Parameters.AddWithValue("admin_password", txtRePassword.Text.GetHashCode)
            UpdateBossData.Parameters.AddWithValue("admin_id", GetAdminID)

            Try
                UpdateBossData.ExecuteNonQuery()
                XtraMessageBox.Show("Congratulation! You had successfully set up your account password!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmLogin.CheckPasswordExist()
                Me.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class