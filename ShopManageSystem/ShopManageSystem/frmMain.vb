Imports System
Imports System.Xml
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo

Public Class frmMain
    Inherits DevExpress.XtraEditors.XtraForm
    Dim MarqueeText As String = "A" 'because it can't afford empty string lol
    Dim sb As New System.Text.StringBuilder
    Dim Direction As Boolean = False 'true = left to right, false = right to left

    Public LoggedInUsername As String = "Guest"

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        formClose(Nothing)
    End Sub

    Private Sub MarqueeTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarqueeTimer.Tick
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
        If mStock.Visible = True Then
            mStock.Visible = False
            mCustomer.Visible = False
            mSupplier.Visible = False
            mSales.Visible = False
            mRestock.Visible = False
            mReport.Visible = False
        Else
            mStock.Visible = True
            mCustomer.Visible = True
            mSupplier.Visible = True
            mSales.Visible = True
            mRestock.Visible = True
            mReport.Visible = True
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim xd As New XmlDocument
        xd.Load("ShopConfig.xml")

        Dim ShopName As XmlNode = xd.SelectSingleNode("/ShopData/ShopBasicConfig")
        MarqueeText = "Welcome to [" & ShopName.ChildNodes(0).InnerText & "], current user : " & LoggedInUsername & "   "

        lblVersion.BackColor = Color.Transparent
        lblVersion.Text = "v1.0.0.0"

        lblUsername.BackColor = Color.Transparent
        lblUsername.Text = LoggedInUsername

        'Seem like there's no other way..
        pbHome.BackColor = Color.Transparent
        pbReport.BackColor = Color.Transparent
        pbSettings.BackColor = Color.Transparent
        pbAssistant.BackColor = Color.Transparent

        lblHome.BackColor = Color.Transparent
        lblReporting.BackColor = Color.Transparent
        lblSetting.BackColor = Color.Transparent
        lblAssistant.BackColor = Color.Transparent

        TabControl.TabPages(0).ShowCloseButton = DevExpress.Utils.DefaultBoolean.False 'always hide home close button
    End Sub

    Private Sub pbHome_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbHome.MouseUp, pbHome.MouseHover
        pbHome.Image = My.Resources.home_icon_hover
        lblHome.ForeColor = Color.FromArgb(23, 181, 26)
    End Sub

    Private Sub pbReport_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbReport.MouseUp, pbReport.MouseHover
        pbReport.Image = My.Resources.char_icon_hover
        lblReporting.ForeColor = Color.FromArgb(23, 181, 26)
    End Sub

    Private Sub pbSettings_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbSettings.MouseUp, pbSettings.MouseHover
        pbSettings.Image = My.Resources.settings_icon_hover
        lblSetting.ForeColor = Color.FromArgb(23, 181, 26)
    End Sub

    Private Sub pbAssistant_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbAssistant.MouseUp, pbAssistant.MouseHover
        pbAssistant.Image = My.Resources.assistant_icon_hover
        lblAssistant.ForeColor = Color.FromArgb(23, 181, 26)
    End Sub

    Private Sub pbHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbHome.MouseDown, pbHome.MouseLeave
        pbHome.Image = My.Resources.home_icon
        lblHome.ForeColor = Color.White
    End Sub

    Private Sub pbReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbReport.MouseDown, pbReport.MouseLeave
        pbReport.Image = My.Resources.chart_icon
        lblReporting.ForeColor = Color.White
    End Sub

    Private Sub pbSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbSettings.MouseDown, pbSettings.MouseLeave
        pbSettings.Image = My.Resources.settings_icon
        lblSetting.ForeColor = Color.White
    End Sub

    Private Sub pbAssistant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbAssistant.MouseDown, pbAssistant.MouseLeave
        pbAssistant.Image = My.Resources.assistant_icon
        lblAssistant.ForeColor = Color.White
    End Sub

    'Tabpage index | Tabpage title
    '0 | Home
    '1 | Stock Management
    '2 | Customer
    '3 | Supplier
    '4 | Sales Order
    '5 | Restock Order
    '6 | Report
    Private Sub btnStockManagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStockManagement.Click, mStock.Click
        Dim Found As Boolean = False
        For pno As Integer = 0 To TabControl.TabPages.Count - 1
            If TabControl.TabPages(pno).Text = "Stock Management" Then
                Found = True
                TabControl.SelectedTabPageIndex = pno
                Exit For
            End If
        Next

        If Not Found Then
            Dim TabPageResult As New XtraTabPage
            TabPageResult.Text = "Stock Management"
            TabControl.TabPages.Add(TabPageResult)

            frmStockManagement.TopLevel = False
            frmStockManagement.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            frmStockManagement.Dock = DockStyle.Fill
            TabPageResult.Controls.Add(frmStockManagement)
            frmStockManagement.Show()
            TabControl.SelectedTabPage = TabPageResult
        End If
    End Sub

    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click, mCustomer.Click
        Dim Found As Boolean = False
        For pno As Integer = 0 To TabControl.TabPages.Count - 1
            If TabControl.TabPages(pno).Text = "Customer" Then
                Found = True
                TabControl.SelectedTabPageIndex = pno
                Exit For
            End If
        Next

        If Not Found Then
            Dim TabPageResult As New XtraTabPage
            TabPageResult.Text = "Customer"
            TabControl.TabPages.Add(TabPageResult)

            frmCustomerManagement.TopLevel = False
            frmCustomerManagement.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            frmCustomerManagement.Dock = DockStyle.Fill
            TabPageResult.Controls.Add(frmCustomerManagement)
            frmCustomerManagement.Show()
            TabControl.SelectedTabPage = TabPageResult
        End If
    End Sub

    Private Sub btnSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupplier.Click, mSupplier.Click
        Dim Found As Boolean = False
        For pno As Integer = 0 To TabControl.TabPages.Count - 1
            If TabControl.TabPages(pno).Text = "Supplier" Then
                Found = True
                TabControl.SelectedTabPageIndex = pno
                Exit For
            End If
        Next

        If Not Found Then
            Dim TabPageResult As New XtraTabPage
            TabPageResult.Text = "Supplier"
            TabControl.TabPages.Add(TabPageResult)

            frmSupplierManagement.TopLevel = False
            frmSupplierManagement.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            frmSupplierManagement.Dock = DockStyle.Fill
            TabPageResult.Controls.Add(frmSupplierManagement)
            frmSupplierManagement.Show()
            TabControl.SelectedTabPage = TabPageResult
        End If
    End Sub

    Private Sub btnSalesOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnSalesOrder.Click, mSales.Click
        Dim Found As Boolean = False
        For pno As Integer = 0 To TabControl.TabPages.Count - 1
            If TabControl.TabPages(pno).Text = "Sales Order" Then
                Found = True
                TabControl.SelectedTabPageIndex = pno
                Exit For
            End If
        Next

        If Not Found Then
            Dim TabPageResult As New XtraTabPage
            TabPageResult.Text = "Sales Order"
            TabControl.TabPages.Add(TabPageResult)

            frmSalesManagement.TopLevel = False
            frmSalesManagement.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            frmSalesManagement.Dock = DockStyle.Fill
            TabPageResult.Controls.Add(frmSalesManagement)
            frmSalesManagement.Show()
            TabControl.SelectedTabPage = TabPageResult
        End If
    End Sub

    'Private Sub btnRestockOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnRestockOrder.Click, mRestock.Click
    '    Dim Found As Boolean = False
    '    For pno As Integer = 0 To TabControl.TabPages.Count - 1
    '        If TabControl.TabPages(pno).Text = "Restock Order" Then
    '            Found = True
    '            TabControl.SelectedTabPageIndex = pno
    '            Exit For
    '        End If
    '    Next

    '    If Not Found Then
    '        Dim TabPageResult As New XtraTabPage
    '        TabPageResult.Text = "Restock Order"
    '        TabControl.TabPages.Add(TabPageResult)

    '        frmRestockManagement.TopLevel = False
    '        frmRestockManagement.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    '        frmRestockManagement.Dock = DockStyle.Fill
    '        TabPageResult.Controls.Add(frmRestockManagement)
    '        frmRestockManagement.Show()
    '        TabControl.SelectedTabPage = TabPageResult
    '    End If
    'End Sub

    Private Sub TabControl_CloseButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl.CloseButtonClick
        'TabControl.SelectedTabPage.PageVisible = False
        Dim tabControl As XtraTabControl = TryCast(sender, XtraTabControl)
        Dim arg As ClosePageButtonEventArgs = TryCast(e, ClosePageButtonEventArgs)
        TryCast(arg.Page, XtraTabPage).Dispose()
    End Sub
End Class