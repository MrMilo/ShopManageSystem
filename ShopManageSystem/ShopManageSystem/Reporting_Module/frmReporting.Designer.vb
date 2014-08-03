<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporting))
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.btnCalculate = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCustomerManagement = New DevExpress.XtraEditors.LabelControl()
        Me.ToolTipController = New DevExpress.Utils.ToolTipController(Me.components)
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cboGraphViewOpt = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnGraphView = New DevExpress.XtraEditors.SimpleButton()
        Me.btnListView = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.TotalSalesDGV = New DevExpress.XtraGrid.GridControl()
        Me.TotalSalesGV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ReportDGV = New DevExpress.XtraGrid.GridControl()
        Me.ReportGV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.ChartControl = New DevExpress.XtraCharts.ChartControl()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.ChartControl2 = New DevExpress.XtraCharts.ChartControl()
        Me.PanelTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelButton.SuspendLayout()
        CType(Me.cboGraphViewOpt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.TotalSalesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalSalesGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.ChartControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.LabelControl1)
        Me.PanelTop.Controls.Add(Me.LabelControl2)
        Me.PanelTop.Controls.Add(Me.DateTimePicker1)
        Me.PanelTop.Controls.Add(Me.DateTimePicker2)
        Me.PanelTop.Controls.Add(Me.btnCalculate)
        Me.PanelTop.Controls.Add(Me.PictureBox1)
        Me.PanelTop.Controls.Add(Me.lblCustomerManagement)
        Me.PanelTop.Location = New System.Drawing.Point(-1, -1)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(822, 50)
        Me.PanelTop.TabIndex = 4
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(465, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(35, 16)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "Date :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(609, 17)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(15, 16)
        Me.LabelControl2.TabIndex = 31
        Me.LabelControl2.Text = "To"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(506, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(101, 21)
        Me.DateTimePicker1.TabIndex = 30
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(626, 15)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(101, 21)
        Me.DateTimePicker2.TabIndex = 29
        '
        'btnCalculate
        '
        Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalculate.Location = New System.Drawing.Point(733, 14)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 28
        Me.btnCalculate.Text = "&Compute"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'lblCustomerManagement
        '
        Me.lblCustomerManagement.Appearance.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerManagement.Location = New System.Drawing.Point(45, 12)
        Me.lblCustomerManagement.Name = "lblCustomerManagement"
        Me.lblCustomerManagement.Size = New System.Drawing.Size(189, 22)
        Me.lblCustomerManagement.TabIndex = 4
        Me.lblCustomerManagement.Text = "Margin Profit Reporting"
        '
        'ToolTipController
        '
        Me.ToolTipController.AllowHtmlText = True
        Me.ToolTipController.Rounded = True
        Me.ToolTipController.ShowBeak = True
        '
        'PanelButton
        '
        Me.PanelButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelButton.Controls.Add(Me.LabelControl3)
        Me.PanelButton.Controls.Add(Me.cboGraphViewOpt)
        Me.PanelButton.Controls.Add(Me.btnGraphView)
        Me.PanelButton.Controls.Add(Me.btnListView)
        Me.PanelButton.Controls.Add(Me.btnExport)
        Me.PanelButton.Location = New System.Drawing.Point(-1, 48)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(822, 50)
        Me.PanelButton.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(499, 16)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(75, 16)
        Me.LabelControl3.TabIndex = 33
        Me.LabelControl3.Text = "Graph View :"
        '
        'cboGraphViewOpt
        '
        Me.cboGraphViewOpt.Location = New System.Drawing.Point(580, 13)
        Me.cboGraphViewOpt.Name = "cboGraphViewOpt"
        Me.cboGraphViewOpt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGraphViewOpt.Properties.Appearance.Options.UseFont = True
        Me.cboGraphViewOpt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGraphViewOpt.Properties.Items.AddRange(New Object() {"Top 5 Sales Products", "Top 5 Royal Customers", "Revenue of the month"})
        Me.cboGraphViewOpt.Size = New System.Drawing.Size(168, 22)
        Me.cboGraphViewOpt.TabIndex = 16
        '
        'btnGraphView
        '
        Me.btnGraphView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGraphView.Image = CType(resources.GetObject("btnGraphView.Image"), System.Drawing.Image)
        Me.btnGraphView.Location = New System.Drawing.Point(754, 11)
        Me.btnGraphView.Name = "btnGraphView"
        Me.btnGraphView.Size = New System.Drawing.Size(27, 27)
        Me.btnGraphView.TabIndex = 15
        '
        'btnListView
        '
        Me.btnListView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListView.Image = CType(resources.GetObject("btnListView.Image"), System.Drawing.Image)
        Me.btnListView.Location = New System.Drawing.Point(780, 11)
        Me.btnListView.Name = "btnListView"
        Me.btnListView.Size = New System.Drawing.Size(27, 27)
        Me.btnListView.TabIndex = 14
        '
        'btnExport
        '
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.Location = New System.Drawing.Point(10, 13)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 13
        Me.btnExport.Text = "&Export"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 97)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 315)
        Me.XtraTabControl1.TabIndex = 9
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.TotalSalesDGV)
        Me.XtraTabPage1.Controls.Add(Me.ReportDGV)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(814, 309)
        Me.XtraTabPage1.Text = "XtraTabPage1"
        '
        'TotalSalesDGV
        '
        Me.TotalSalesDGV.Location = New System.Drawing.Point(0, 269)
        Me.TotalSalesDGV.MainView = Me.TotalSalesGV
        Me.TotalSalesDGV.Name = "TotalSalesDGV"
        Me.TotalSalesDGV.Size = New System.Drawing.Size(815, 45)
        Me.TotalSalesDGV.TabIndex = 10
        Me.TotalSalesDGV.ToolTipController = Me.ToolTipController
        Me.TotalSalesDGV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TotalSalesGV})
        '
        'TotalSalesGV
        '
        Me.TotalSalesGV.GridControl = Me.TotalSalesDGV
        Me.TotalSalesGV.Name = "TotalSalesGV"
        Me.TotalSalesGV.OptionsBehavior.Editable = False
        Me.TotalSalesGV.OptionsView.ColumnAutoWidth = False
        Me.TotalSalesGV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.TotalSalesGV.OptionsView.ShowGroupPanel = False
        Me.TotalSalesGV.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        Me.TotalSalesGV.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'ReportDGV
        '
        Me.ReportDGV.Location = New System.Drawing.Point(0, 0)
        Me.ReportDGV.MainView = Me.ReportGV
        Me.ReportDGV.Name = "ReportDGV"
        Me.ReportDGV.Size = New System.Drawing.Size(815, 274)
        Me.ReportDGV.TabIndex = 9
        Me.ReportDGV.ToolTipController = Me.ToolTipController
        Me.ReportDGV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ReportGV})
        '
        'ReportGV
        '
        Me.ReportGV.GridControl = Me.ReportDGV
        Me.ReportGV.Name = "ReportGV"
        Me.ReportGV.OptionsBehavior.Editable = False
        Me.ReportGV.OptionsCustomization.AllowColumnMoving = False
        Me.ReportGV.OptionsCustomization.AllowColumnResizing = False
        Me.ReportGV.OptionsCustomization.AllowFilter = False
        Me.ReportGV.OptionsCustomization.AllowSort = False
        Me.ReportGV.OptionsView.ColumnAutoWidth = False
        Me.ReportGV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.ReportGV.OptionsView.ShowGroupPanel = False
        Me.ReportGV.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.XtraTabControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(814, 309)
        Me.XtraTabPage2.Text = "XtraTabPage2"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl2.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.XtraTabControl2.Size = New System.Drawing.Size(820, 315)
        Me.XtraTabControl2.TabIndex = 2
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.ChartControl)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(814, 309)
        Me.XtraTabPage3.Text = "XtraTabPage3"
        '
        'ChartControl
        '
        Me.ChartControl.Location = New System.Drawing.Point(3, 3)
        Me.ChartControl.Name = "ChartControl"
        Me.ChartControl.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl.Size = New System.Drawing.Size(807, 302)
        Me.ChartControl.TabIndex = 1
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.ChartControl1)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(814, 309)
        Me.XtraTabPage4.Text = "XtraTabPage4"
        '
        'ChartControl1
        '
        Me.ChartControl1.Location = New System.Drawing.Point(4, 3)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.Size = New System.Drawing.Size(807, 302)
        Me.ChartControl1.TabIndex = 2
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.ChartControl2)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(814, 309)
        Me.XtraTabPage5.Text = "XtraTabPage5"
        '
        'ChartControl2
        '
        Me.ChartControl2.Location = New System.Drawing.Point(4, 3)
        Me.ChartControl2.Name = "ChartControl2"
        Me.ChartControl2.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl2.Size = New System.Drawing.Size(807, 302)
        Me.ChartControl2.TabIndex = 2
        '
        'frmReporting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 411)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.PanelButton)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReporting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelButton.ResumeLayout(False)
        Me.PanelButton.PerformLayout()
        CType(Me.cboGraphViewOpt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.TotalSalesDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalSalesGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.ChartControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents lblCustomerManagement As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelButton As System.Windows.Forms.Panel
    Friend WithEvents ToolTipController As DevExpress.Utils.ToolTipController
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCalculate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnListView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGraphView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TotalSalesDGV As DevExpress.XtraGrid.GridControl
    Friend WithEvents TotalSalesGV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ReportDGV As DevExpress.XtraGrid.GridControl
    Friend WithEvents ReportGV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboGraphViewOpt As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ChartControl As DevExpress.XtraCharts.ChartControl
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents ChartControl2 As DevExpress.XtraCharts.ChartControl
End Class
