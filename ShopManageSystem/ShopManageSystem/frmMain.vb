Imports System
Imports System.Xml

Public Class frmMain
    Inherits DevExpress.XtraEditors.XtraForm
    Dim MarqueeText As String = "A" 'because it can't afford empty string lol
    Dim sb As New System.Text.StringBuilder
    Dim Direction As Boolean = False 'true = left to right, false = right to left

    Public LoggedInUsername As String

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        formClose(Nothing)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarqueeTimer.Tick
        If sb.Length = 0 Then sb.Append(MarqueeText)
        If Direction Then
            sb.Insert(0, sb(sb.Length - 1))
            sb.Remove(sb.Length - 1, 1)
        Else
            sb.Append(sb(0))
            sb.Remove(0, 1)
        End If
        StatusStrip.Items(1).Text = sb.ToString

        Dim dateNow As Date = Now
        StatusStrip.Items(2).Text = "Date and Time : " & dateNow
    End Sub

    Private Sub btnSideBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSideBar.Click
        If SidePanel.Visible = True Then
            SidePanel.Visible = False
        Else
            SidePanel.Visible = True
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim xd As New XmlDocument
        xd.Load("ShopConfig.xml")

        Dim ShopName As XmlNode = xd.SelectSingleNode("/ShopData/ShopBasicConfig")
        MarqueeText = "Welcome to [" & ShopName.ChildNodes(0).InnerText & "], current user : " & LoggedInUsername & "   "
    End Sub
End Class