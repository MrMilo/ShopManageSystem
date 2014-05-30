<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.MarqueeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnSideBar = New System.Windows.Forms.Button()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ssVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ssAnnouncement = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ssDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.lblReporting = New System.Windows.Forms.Label()
        Me.lblSetting = New System.Windows.Forms.Label()
        Me.lblAssistant = New System.Windows.Forms.Label()
        Me.pbSettings = New System.Windows.Forms.PictureBox()
        Me.pbReport = New System.Windows.Forms.PictureBox()
        Me.pbHome = New System.Windows.Forms.PictureBox()
        Me.pbAssistant = New System.Windows.Forms.PictureBox()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.pTop = New System.Windows.Forms.Panel()
        Me.btnSearch = New DevExpress.XtraEditors.ButtonEdit()
        Me.TabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.TP0 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnRestockOrder = New System.Windows.Forms.Button()
        Me.btnSalesOrder = New System.Windows.Forms.Button()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnStockManagement = New System.Windows.Forms.Button()
        Me.TP1 = New DevExpress.XtraTab.XtraTabPage()
        Me.TP2 = New DevExpress.XtraTab.XtraTabPage()
        Me.TP3 = New DevExpress.XtraTab.XtraTabPage()
        Me.TP4 = New DevExpress.XtraTab.XtraTabPage()
        Me.TP5 = New DevExpress.XtraTab.XtraTabPage()
        Me.TP6 = New DevExpress.XtraTab.XtraTabPage()
        Me.StatusStrip.SuspendLayout()
        CType(Me.pbSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAssistant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pTop.SuspendLayout()
        CType(Me.btnSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TP0.SuspendLayout()
        Me.SuspendLayout()
        '
        'MarqueeTimer
        '
        Me.MarqueeTimer.Enabled = True
        '
        'btnSideBar
        '
        Me.btnSideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnSideBar.BackgroundImage = CType(resources.GetObject("btnSideBar.BackgroundImage"), System.Drawing.Image)
        Me.btnSideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSideBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSideBar.FlatAppearance.BorderSize = 0
        Me.btnSideBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSideBar.Location = New System.Drawing.Point(0, 93)
        Me.btnSideBar.Name = "btnSideBar"
        Me.btnSideBar.Size = New System.Drawing.Size(50, 25)
        Me.btnSideBar.TabIndex = 1
        Me.btnSideBar.UseVisualStyleBackColor = False
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.SidePanel.BackgroundImage = CType(resources.GetObject("SidePanel.BackgroundImage"), System.Drawing.Image)
        Me.SidePanel.Location = New System.Drawing.Point(0, 117)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(50, 435)
        Me.SidePanel.TabIndex = 2
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ssVersion, Me.ssAnnouncement, Me.ssDate})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 528)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip.Size = New System.Drawing.Size(864, 24)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 3
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ssVersion
        '
        Me.ssVersion.AutoSize = False
        Me.ssVersion.Name = "ssVersion"
        Me.ssVersion.Size = New System.Drawing.Size(290, 19)
        Me.ssVersion.Text = "Version 1.0.0.0"
        '
        'ssAnnouncement
        '
        Me.ssAnnouncement.AutoSize = False
        Me.ssAnnouncement.Name = "ssAnnouncement"
        Me.ssAnnouncement.Size = New System.Drawing.Size(290, 19)
        Me.ssAnnouncement.Text = "Announcement"
        '
        'ssDate
        '
        Me.ssDate.AutoSize = False
        Me.ssDate.Name = "ssDate"
        Me.ssDate.Size = New System.Drawing.Size(290, 19)
        Me.ssDate.Text = "Date Time"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.White
        Me.lblVersion.Location = New System.Drawing.Point(90, 395)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(66, 16)
        Me.lblVersion.TabIndex = 0
        Me.lblVersion.Text = "Username"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(90, 417)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(66, 16)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username"
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblHome.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome.ForeColor = System.Drawing.Color.White
        Me.lblHome.Location = New System.Drawing.Point(219, 450)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(41, 16)
        Me.lblHome.TabIndex = 0
        Me.lblHome.Text = "Home"
        '
        'lblReporting
        '
        Me.lblReporting.AutoSize = True
        Me.lblReporting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReporting.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReporting.ForeColor = System.Drawing.Color.White
        Me.lblReporting.Location = New System.Drawing.Point(339, 450)
        Me.lblReporting.Name = "lblReporting"
        Me.lblReporting.Size = New System.Drawing.Size(63, 16)
        Me.lblReporting.TabIndex = 0
        Me.lblReporting.Text = "Reporting"
        '
        'lblSetting
        '
        Me.lblSetting.AutoSize = True
        Me.lblSetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSetting.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetting.ForeColor = System.Drawing.Color.White
        Me.lblSetting.Location = New System.Drawing.Point(476, 450)
        Me.lblSetting.Name = "lblSetting"
        Me.lblSetting.Size = New System.Drawing.Size(54, 16)
        Me.lblSetting.TabIndex = 0
        Me.lblSetting.Text = "Settings"
        '
        'lblAssistant
        '
        Me.lblAssistant.AutoSize = True
        Me.lblAssistant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAssistant.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssistant.ForeColor = System.Drawing.Color.White
        Me.lblAssistant.Location = New System.Drawing.Point(605, 450)
        Me.lblAssistant.Name = "lblAssistant"
        Me.lblAssistant.Size = New System.Drawing.Size(59, 16)
        Me.lblAssistant.TabIndex = 0
        Me.lblAssistant.Text = "Assistant"
        '
        'pbSettings
        '
        Me.pbSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.pbSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbSettings.Image = CType(resources.GetObject("pbSettings.Image"), System.Drawing.Image)
        Me.pbSettings.Location = New System.Drawing.Point(472, 387)
        Me.pbSettings.Name = "pbSettings"
        Me.pbSettings.Size = New System.Drawing.Size(60, 60)
        Me.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSettings.TabIndex = 4
        Me.pbSettings.TabStop = False
        '
        'pbReport
        '
        Me.pbReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.pbReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbReport.Image = CType(resources.GetObject("pbReport.Image"), System.Drawing.Image)
        Me.pbReport.Location = New System.Drawing.Point(340, 387)
        Me.pbReport.Name = "pbReport"
        Me.pbReport.Size = New System.Drawing.Size(60, 60)
        Me.pbReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbReport.TabIndex = 4
        Me.pbReport.TabStop = False
        '
        'pbHome
        '
        Me.pbHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.pbHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbHome.Image = CType(resources.GetObject("pbHome.Image"), System.Drawing.Image)
        Me.pbHome.Location = New System.Drawing.Point(208, 387)
        Me.pbHome.Name = "pbHome"
        Me.pbHome.Size = New System.Drawing.Size(60, 60)
        Me.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHome.TabIndex = 4
        Me.pbHome.TabStop = False
        '
        'pbAssistant
        '
        Me.pbAssistant.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.pbAssistant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAssistant.Image = CType(resources.GetObject("pbAssistant.Image"), System.Drawing.Image)
        Me.pbAssistant.Location = New System.Drawing.Point(604, 387)
        Me.pbAssistant.Name = "pbAssistant"
        Me.pbAssistant.Size = New System.Drawing.Size(60, 60)
        Me.pbAssistant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAssistant.TabIndex = 4
        Me.pbAssistant.TabStop = False
        '
        'pbLogo
        '
        Me.pbLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(9, 387)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(75, 75)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogo.TabIndex = 4
        Me.pbLogo.TabStop = False
        '
        'pTop
        '
        Me.pTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.pTop.Controls.Add(Me.btnSearch)
        Me.pTop.Controls.Add(Me.pbLogo)
        Me.pTop.Controls.Add(Me.pbAssistant)
        Me.pTop.Controls.Add(Me.pbHome)
        Me.pTop.Controls.Add(Me.pbReport)
        Me.pTop.Controls.Add(Me.pbSettings)
        Me.pTop.Controls.Add(Me.lblAssistant)
        Me.pTop.Controls.Add(Me.lblSetting)
        Me.pTop.Controls.Add(Me.lblReporting)
        Me.pTop.Controls.Add(Me.lblHome)
        Me.pTop.Controls.Add(Me.lblUsername)
        Me.pTop.Controls.Add(Me.lblVersion)
        Me.pTop.Location = New System.Drawing.Point(0, -375)
        Me.pTop.Name = "pTop"
        Me.pTop.Size = New System.Drawing.Size(914, 493)
        Me.pTop.TabIndex = 6
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(689, 444)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Properties.Appearance.Options.UseFont = True
        Me.btnSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("btnSearch.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.btnSearch.Properties.NullValuePrompt = "Search anything here"
        Me.btnSearch.Size = New System.Drawing.Size(163, 22)
        Me.btnSearch.TabIndex = 6
        '
        'TabControl
        '
        Me.TabControl.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.TabControl.Appearance.Options.UseBackColor = True
        Me.TabControl.Appearance.Options.UseImage = True
        Me.TabControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
        Me.TabControl.Location = New System.Drawing.Point(50, 92)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedTabPage = Me.TP0
        Me.TabControl.Size = New System.Drawing.Size(814, 436)
        Me.TabControl.TabIndex = 33
        Me.TabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TP0, Me.TP1, Me.TP2, Me.TP3, Me.TP4, Me.TP5, Me.TP6})
        '
        'TP0
        '
        Me.TP0.Controls.Add(Me.btnReport)
        Me.TP0.Controls.Add(Me.btnRestockOrder)
        Me.TP0.Controls.Add(Me.btnSalesOrder)
        Me.TP0.Controls.Add(Me.btnSupplier)
        Me.TP0.Controls.Add(Me.btnCustomer)
        Me.TP0.Controls.Add(Me.btnStockManagement)
        Me.TP0.Name = "TP0"
        Me.TP0.Size = New System.Drawing.Size(808, 408)
        Me.TP0.Text = "Home"
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Image)
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReport.Location = New System.Drawing.Point(536, 236)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(143, 92)
        Me.btnReport.TabIndex = 35
        Me.btnReport.Text = "REPORT"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnRestockOrder
        '
        Me.btnRestockOrder.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRestockOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestockOrder.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestockOrder.Image = CType(resources.GetObject("btnRestockOrder.Image"), System.Drawing.Image)
        Me.btnRestockOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRestockOrder.Location = New System.Drawing.Point(333, 236)
        Me.btnRestockOrder.Name = "btnRestockOrder"
        Me.btnRestockOrder.Size = New System.Drawing.Size(143, 92)
        Me.btnRestockOrder.TabIndex = 37
        Me.btnRestockOrder.Text = "RESTOCK ORDER"
        Me.btnRestockOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRestockOrder.UseVisualStyleBackColor = False
        '
        'btnSalesOrder
        '
        Me.btnSalesOrder.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSalesOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalesOrder.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesOrder.Image = CType(resources.GetObject("btnSalesOrder.Image"), System.Drawing.Image)
        Me.btnSalesOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalesOrder.Location = New System.Drawing.Point(130, 236)
        Me.btnSalesOrder.Name = "btnSalesOrder"
        Me.btnSalesOrder.Size = New System.Drawing.Size(143, 92)
        Me.btnSalesOrder.TabIndex = 38
        Me.btnSalesOrder.Text = "SALES ORDER"
        Me.btnSalesOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalesOrder.UseVisualStyleBackColor = False
        '
        'btnSupplier
        '
        Me.btnSupplier.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSupplier.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplier.Image = CType(resources.GetObject("btnSupplier.Image"), System.Drawing.Image)
        Me.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSupplier.Location = New System.Drawing.Point(536, 74)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(143, 92)
        Me.btnSupplier.TabIndex = 36
        Me.btnSupplier.Text = "SUPPLIER"
        Me.btnSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSupplier.UseVisualStyleBackColor = False
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), System.Drawing.Image)
        Me.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCustomer.Location = New System.Drawing.Point(333, 74)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(143, 92)
        Me.btnCustomer.TabIndex = 34
        Me.btnCustomer.Text = "CUSTOMER"
        Me.btnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'btnStockManagement
        '
        Me.btnStockManagement.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnStockManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStockManagement.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockManagement.Image = CType(resources.GetObject("btnStockManagement.Image"), System.Drawing.Image)
        Me.btnStockManagement.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnStockManagement.Location = New System.Drawing.Point(130, 74)
        Me.btnStockManagement.Name = "btnStockManagement"
        Me.btnStockManagement.Size = New System.Drawing.Size(143, 92)
        Me.btnStockManagement.TabIndex = 33
        Me.btnStockManagement.Text = "STOCK MANAGEMENT"
        Me.btnStockManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStockManagement.UseVisualStyleBackColor = False
        '
        'TP1
        '
        Me.TP1.Name = "TP1"
        Me.TP1.PageVisible = False
        Me.TP1.Size = New System.Drawing.Size(808, 408)
        Me.TP1.Text = "Stock Management"
        '
        'TP2
        '
        Me.TP2.Name = "TP2"
        Me.TP2.PageVisible = False
        Me.TP2.Size = New System.Drawing.Size(808, 408)
        Me.TP2.Text = "Customer"
        '
        'TP3
        '
        Me.TP3.Name = "TP3"
        Me.TP3.PageVisible = False
        Me.TP3.Size = New System.Drawing.Size(808, 408)
        Me.TP3.Text = "Supplier"
        '
        'TP4
        '
        Me.TP4.Name = "TP4"
        Me.TP4.PageVisible = False
        Me.TP4.Size = New System.Drawing.Size(808, 408)
        Me.TP4.Text = "Sales Order"
        '
        'TP5
        '
        Me.TP5.Name = "TP5"
        Me.TP5.PageVisible = False
        Me.TP5.Size = New System.Drawing.Size(808, 408)
        Me.TP5.Text = "Restock Order"
        '
        'TP6
        '
        Me.TP6.Name = "TP6"
        Me.TP6.PageVisible = False
        Me.TP6.Size = New System.Drawing.Size(808, 408)
        Me.TP6.Text = "Report"
        '
        'frmMain
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 552)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.btnSideBar)
        Me.Controls.Add(Me.pTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.pbSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAssistant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pTop.ResumeLayout(False)
        Me.pTop.PerformLayout()
        CType(Me.btnSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TP0.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MarqueeTimer As System.Windows.Forms.Timer
    Friend WithEvents btnSideBar As System.Windows.Forms.Button
    Friend WithEvents SidePanel As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ssVersion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ssAnnouncement As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ssDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblHome As System.Windows.Forms.Label
    Friend WithEvents lblReporting As System.Windows.Forms.Label
    Friend WithEvents lblSetting As System.Windows.Forms.Label
    Friend WithEvents lblAssistant As System.Windows.Forms.Label
    Friend WithEvents pbSettings As System.Windows.Forms.PictureBox
    Friend WithEvents pbReport As System.Windows.Forms.PictureBox
    Friend WithEvents pbHome As System.Windows.Forms.PictureBox
    Friend WithEvents pbAssistant As System.Windows.Forms.PictureBox
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents pTop As System.Windows.Forms.Panel
    Friend WithEvents TabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TP0 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnRestockOrder As System.Windows.Forms.Button
    Friend WithEvents btnSalesOrder As System.Windows.Forms.Button
    Friend WithEvents btnSupplier As System.Windows.Forms.Button
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents btnStockManagement As System.Windows.Forms.Button
    Friend WithEvents btnSearch As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents TP1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TP2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TP3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TP4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TP5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TP6 As DevExpress.XtraTab.XtraTabPage
End Class
