Imports DevExpress.XtraEditors
Imports System.Data.OleDb
Imports System.Net.Mail
Imports System.Text

Public Class frmForgetPassword
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        If txtEmailAddress.Text.Length = 0 Then
            XtraMessageBox.Show("Please enter the email address field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If My.Computer.Network.IsAvailable Then
                If My.Computer.Network.Ping("www.google.com") Then
                    openConn()
                    Dim ValidateEmail As New OleDbCommand("SELECT admin_email FROM tblAdmin WHERE admin_email = ?", databaseConn)
                    ValidateEmail.Parameters.AddWithValue("admin_email", txtEmailAddress.Text)

                    Try
                        Dim sdr As OleDbDataReader = ValidateEmail.ExecuteReader()

                        If (sdr.Read() = True) Then 'email exist
                            'Generate password
                            Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
                            Dim r As New Random
                            Dim sb As New StringBuilder
                            For i As Integer = 1 To 8
                                Dim idx As Integer = r.Next(0, 61)
                                sb.Append(s.Substring(idx, 1))
                            Next

                            Dim UpdateNewPassword As New OleDbCommand("UPDATE tblAdmin SET admin_password = ? WHERE admin_email = ?", databaseConn)
                            UpdateNewPassword.Parameters.AddWithValue("admin_password", sb.ToString.GetHashCode)
                            UpdateNewPassword.Parameters.AddWithValue("admin_email", txtEmailAddress.Text)

                            Try
                                UpdateNewPassword.ExecuteNonQuery()
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try

                            Try
                                Dim SmtpServer As New SmtpClient()
                                Dim PasswordRecoveryMail As New MailMessage()
                                SmtpServer.Credentials = New Net.NetworkCredential("shop@milostudio.net", "DN3p1WWL")
                                SmtpServer.Port = 587
                                SmtpServer.Host = "mail.milostudio.net"
                                SmtpServer.EnableSsl = False
                                PasswordRecoveryMail = New MailMessage()
                                PasswordRecoveryMail.From = New MailAddress("shop@milostudio.net")
                                PasswordRecoveryMail.To.Add(txtEmailAddress.Text)
                                PasswordRecoveryMail.Subject = "Password Recovery of Shop Management System"
                                PasswordRecoveryMail.Body = "Our respecful customer," & vbNewLine & vbNewLine & "Good day! Your new password had been reseted to : " & sb.ToString & vbNewLine & vbNewLine & "Please change your password after you login!" & vbNewLine & vbNewLine & "This is a system generated email, please do not reply!"
                                SmtpServer.Send(PasswordRecoveryMail)
                                XtraMessageBox.Show("New password had been sent to your email, please check.", "Mail Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try
                        Else
                            XtraMessageBox.Show("The email you entered are not found, please make sure your enter the correct recovery email!", "Incorrect Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    XtraMessageBox.Show("You need an internet connection to perform this action!", "Connection Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                XtraMessageBox.Show("You need an internet connection to perform this action!", "Connection Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub frmForgetPassword_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
End Class