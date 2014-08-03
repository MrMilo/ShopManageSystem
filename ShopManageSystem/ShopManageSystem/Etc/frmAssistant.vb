Imports System.Configuration
Imports System
Imports System.Xml
Imports DevExpress.XtraEditors
Imports System.Data.OleDb
Imports System.Net.Mail

Public Class frmAssistant
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub frmSetUp_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        If txtEmail.Text.Length = 0 Then
            txtEmail.ToolTipController.ShowHint("Please enter your email!", DevExpress.Utils.ToolTipLocation.BottomRight, txtEmail.PointToScreen(New Point(20, -5)))
        ElseIf txtName.Text.Length = 0 Then
            txtName.ToolTipController.ShowHint("Please enter your name!", DevExpress.Utils.ToolTipLocation.BottomRight, txtName.PointToScreen(New Point(20, -5)))
        ElseIf txtSubject.Text.Length = 0 Then
            txtSubject.ToolTipController.ShowHint("Please enter the subject!", DevExpress.Utils.ToolTipLocation.BottomRight, txtSubject.PointToScreen(New Point(20, -5)))
        ElseIf txtMessage.Text.Length = 0 Then
            txtMessage.ToolTipController.ShowHint("Please enter the message!", DevExpress.Utils.ToolTipLocation.BottomRight, txtMessage.PointToScreen(New Point(20, -5)))
        Else
            If My.Computer.Network.IsAvailable Then
                If My.Computer.Network.Ping("www.google.com") Then
                    Try

                        Try
                            Dim SmtpServer As New SmtpClient()
                            Dim PasswordRecoveryMail As New MailMessage()
                            SmtpServer.Credentials = New Net.NetworkCredential("shop@milostudio.net", "DN3p1WWL")
                            SmtpServer.Port = 587
                            SmtpServer.Host = "mail.milostudio.net"
                            SmtpServer.EnableSsl = False
                            PasswordRecoveryMail = New MailMessage()
                            PasswordRecoveryMail.From = New MailAddress(txtEmail.Text)
                            PasswordRecoveryMail.To.Add("milo@milostudio.net")
                            PasswordRecoveryMail.Subject = txtSubject.Text & "-Support Email"
                            PasswordRecoveryMail.Body = txtMessage.Text
                            SmtpServer.Send(PasswordRecoveryMail)
                            XtraMessageBox.Show("The email has been sent to MiloStudio, we'll get back to you as soon as possible!", "Mail Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            txtContact.Text = ""
                            txtEmail.Text = ""
                            txtMessage.Text = ""
                            txtName.Text = ""
                            txtSubject.Text = ""
                            Me.Close()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
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
End Class