Imports System.Configuration
Imports System
Imports System.Xml
Imports DevExpress.XtraEditors

Public Class frmSetUp
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub frmSetUp_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        formClose(Nothing)
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        If txtShopName.Text.Length = 0 Then
            XtraMessageBox.Show("Please enter your shop name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txtEmailAddress.Text.Length = 0 Then
            XtraMessageBox.Show("Please enter your email address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim xd As New XmlDocument
                xd.Load("ShopConfig.xml")

                Dim ShopBasicConfig As XmlNode = xd.SelectSingleNode("/ShopData/ShopBasicConfig")
                ShopBasicConfig.ChildNodes(0).InnerText = txtShopName.Text 'ShopName
                ShopBasicConfig.ChildNodes(1).InnerText = txtShopAddress.Text 'ShopAddress
                ShopBasicConfig.ChildNodes(2).InnerText = txtEmailAddress.Text 'EmailAddress

                Dim ShopVariables As XmlNode = xd.SelectSingleNode("/ShopData/ShopVariables")
                ShopVariables.ChildNodes(0).InnerText = 1 'ShopSetupCondition

                xd.Save("ShopConfig.xml")

                XtraMessageBox.Show("Congratulation! You are all set and ready to go!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Hide()
                frmLogin.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class