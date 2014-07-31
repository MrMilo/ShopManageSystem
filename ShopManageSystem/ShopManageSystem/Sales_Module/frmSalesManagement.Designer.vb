<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesManagement))
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.lblReceiptNumber = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCustomer = New DevExpress.XtraEditors.LabelControl()
        Me.btnOldSalesReport = New DevExpress.XtraEditors.SimpleButton()
        Me.lblCustomerManagement = New DevExpress.XtraEditors.LabelControl()
        Me.ToolTipController = New DevExpress.Utils.ToolTipController(Me.components)
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.PopupContainerCustomer = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.PopupContainerControl_CustomerSearch = New DevExpress.XtraEditors.PopupContainerControl()
        Me.CustomerSearchDGV = New DevExpress.XtraGrid.GridControl()
        Me.CustomerSearchGV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.SalesDGV = New DevExpress.XtraGrid.GridControl()
        Me.SalesGV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TotalSalesDGV = New DevExpress.XtraGrid.GridControl()
        Me.TotalSalesGV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPlaceSales = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtNote = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiscountedPrice = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiscountRate = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPayment = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelButton.SuspendLayout()
        CType(Me.PopupContainerCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerControl_CustomerSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl_CustomerSearch.SuspendLayout()
        CType(Me.CustomerSearchDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerSearchGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalSalesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalSalesGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscountedPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscountRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPayment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.lblReceiptNumber)
        Me.PanelTop.Controls.Add(Me.PictureBox1)
        Me.PanelTop.Controls.Add(Me.lblCustomer)
        Me.PanelTop.Controls.Add(Me.btnOldSalesReport)
        Me.PanelTop.Controls.Add(Me.lblCustomerManagement)
        Me.PanelTop.Location = New System.Drawing.Point(-1, -1)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(822, 50)
        Me.PanelTop.TabIndex = 4
        '
        'lblReceiptNumber
        '
        Me.lblReceiptNumber.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptNumber.Location = New System.Drawing.Point(564, 16)
        Me.lblReceiptNumber.Name = "lblReceiptNumber"
        Me.lblReceiptNumber.Size = New System.Drawing.Size(107, 16)
        Me.lblReceiptNumber.TabIndex = 12
        Me.lblReceiptNumber.Text = "MS20140731-0000"
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
        'lblCustomer
        '
        Me.lblCustomer.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(460, 16)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(104, 16)
        Me.lblCustomer.TabIndex = 7
        Me.lblCustomer.Text = "Receipt Number : "
        '
        'btnOldSalesReport
        '
        Me.btnOldSalesReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOldSalesReport.Location = New System.Drawing.Point(687, 13)
        Me.btnOldSalesReport.Name = "btnOldSalesReport"
        Me.btnOldSalesReport.Size = New System.Drawing.Size(119, 23)
        Me.btnOldSalesReport.TabIndex = 6
        Me.btnOldSalesReport.Text = "&Check Old Sales"
        '
        'lblCustomerManagement
        '
        Me.lblCustomerManagement.Appearance.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerManagement.Location = New System.Drawing.Point(45, 12)
        Me.lblCustomerManagement.Name = "lblCustomerManagement"
        Me.lblCustomerManagement.Size = New System.Drawing.Size(152, 22)
        Me.lblCustomerManagement.TabIndex = 4
        Me.lblCustomerManagement.Text = "Sales Management"
        '
        'ToolTipController
        '
        Me.ToolTipController.AllowHtmlText = True
        '
        'PanelButton
        '
        Me.PanelButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelButton.Controls.Add(Me.PopupContainerCustomer)
        Me.PanelButton.Controls.Add(Me.DateTimePicker)
        Me.PanelButton.Controls.Add(Me.LabelControl2)
        Me.PanelButton.Controls.Add(Me.LabelControl1)
        Me.PanelButton.Location = New System.Drawing.Point(-1, 48)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(822, 50)
        Me.PanelButton.TabIndex = 5
        '
        'PopupContainerCustomer
        '
        Me.PopupContainerCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PopupContainerCustomer.Location = New System.Drawing.Point(82, 15)
        Me.PopupContainerCustomer.Name = "PopupContainerCustomer"
        Me.PopupContainerCustomer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopupContainerCustomer.Properties.Appearance.Options.UseFont = True
        Me.PopupContainerCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PopupContainerCustomer.Properties.NullValuePrompt = "Search by Customer Name"
        Me.PopupContainerCustomer.Properties.PopupControl = Me.PopupContainerControl_CustomerSearch
        Me.PopupContainerCustomer.Properties.PopupSizeable = False
        Me.PopupContainerCustomer.Properties.ShowPopupCloseButton = False
        Me.PopupContainerCustomer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PopupContainerCustomer.Size = New System.Drawing.Size(193, 22)
        Me.PopupContainerCustomer.TabIndex = 16
        '
        'PopupContainerControl_CustomerSearch
        '
        Me.PopupContainerControl_CustomerSearch.Controls.Add(Me.CustomerSearchDGV)
        Me.PopupContainerControl_CustomerSearch.Location = New System.Drawing.Point(356, 457)
        Me.PopupContainerControl_CustomerSearch.Name = "PopupContainerControl_CustomerSearch"
        Me.PopupContainerControl_CustomerSearch.Size = New System.Drawing.Size(193, 181)
        Me.PopupContainerControl_CustomerSearch.TabIndex = 14
        '
        'CustomerSearchDGV
        '
        Me.CustomerSearchDGV.Location = New System.Drawing.Point(1, 1)
        Me.CustomerSearchDGV.MainView = Me.CustomerSearchGV
        Me.CustomerSearchDGV.Name = "CustomerSearchDGV"
        Me.CustomerSearchDGV.Size = New System.Drawing.Size(194, 178)
        Me.CustomerSearchDGV.TabIndex = 8
        Me.CustomerSearchDGV.ToolTipController = Me.ToolTipController
        Me.CustomerSearchDGV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.CustomerSearchGV})
        '
        'CustomerSearchGV
        '
        Me.CustomerSearchGV.GridControl = Me.CustomerSearchDGV
        Me.CustomerSearchGV.Name = "CustomerSearchGV"
        Me.CustomerSearchGV.OptionsBehavior.Editable = False
        Me.CustomerSearchGV.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CustomerSearchGV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.CustomerSearchGV.OptionsView.ShowGroupPanel = False
        Me.CustomerSearchGV.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'DateTimePicker
        '
        Me.DateTimePicker.CalendarFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker.Location = New System.Drawing.Point(701, 14)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(104, 21)
        Me.DateTimePicker.TabIndex = 15
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(656, 18)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl2.TabIndex = 14
        Me.LabelControl2.Text = "Date : "
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(64, 16)
        Me.LabelControl1.TabIndex = 13
        Me.LabelControl1.Text = "Customer :"
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Location = New System.Drawing.Point(214, 376)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "&Delete"
        '
        'btnEdit
        '
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Location = New System.Drawing.Point(112, 376)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "&Edit"
        '
        'btnNew
        '
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.Location = New System.Drawing.Point(10, 376)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 11
        Me.btnNew.Text = "&New"
        '
        'SalesDGV
        '
        Me.SalesDGV.Location = New System.Drawing.Point(-1, 97)
        Me.SalesDGV.MainView = Me.SalesGV
        Me.SalesDGV.Name = "SalesDGV"
        Me.SalesDGV.Size = New System.Drawing.Size(815, 171)
        Me.SalesDGV.TabIndex = 7
        Me.SalesDGV.ToolTipController = Me.ToolTipController
        Me.SalesDGV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.SalesGV})
        '
        'SalesGV
        '
        Me.SalesGV.GridControl = Me.SalesDGV
        Me.SalesGV.Name = "SalesGV"
        Me.SalesGV.OptionsBehavior.Editable = False
        Me.SalesGV.OptionsCustomization.AllowColumnMoving = False
        Me.SalesGV.OptionsCustomization.AllowColumnResizing = False
        Me.SalesGV.OptionsView.ColumnAutoWidth = False
        Me.SalesGV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.SalesGV.OptionsView.ShowGroupPanel = False
        Me.SalesGV.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'TotalSalesDGV
        '
        Me.TotalSalesDGV.Location = New System.Drawing.Point(-1, 267)
        Me.TotalSalesDGV.MainView = Me.TotalSalesGV
        Me.TotalSalesDGV.Name = "TotalSalesDGV"
        Me.TotalSalesDGV.Size = New System.Drawing.Size(815, 20)
        Me.TotalSalesDGV.TabIndex = 8
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
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Location = New System.Drawing.Point(720, 376)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "&Clear"
        '
        'btnPlaceSales
        '
        Me.btnPlaceSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlaceSales.Location = New System.Drawing.Point(617, 376)
        Me.btnPlaceSales.Name = "btnPlaceSales"
        Me.btnPlaceSales.Size = New System.Drawing.Size(75, 23)
        Me.btnPlaceSales.TabIndex = 13
        Me.btnPlaceSales.Text = "&Place Sales"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(80, 300)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl3.TabIndex = 17
        Me.LabelControl3.Text = "Note : "
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(12, 339)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(103, 16)
        Me.LabelControl4.TabIndex = 18
        Me.LabelControl4.Text = "Discounted Price :"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(819, 411)
        Me.ShapeContainer1.TabIndex = 19
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -12
        Me.LineShape1.X2 = 886
        Me.LineShape1.Y1 = 365
        Me.LineShape1.Y2 = 365
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(125, 297)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Properties.Appearance.Options.UseFont = True
        Me.txtNote.Size = New System.Drawing.Size(670, 22)
        Me.txtNote.TabIndex = 20
        '
        'txtDiscountedPrice
        '
        Me.txtDiscountedPrice.Location = New System.Drawing.Point(125, 336)
        Me.txtDiscountedPrice.Name = "txtDiscountedPrice"
        Me.txtDiscountedPrice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscountedPrice.Properties.Appearance.Options.UseFont = True
        Me.txtDiscountedPrice.Size = New System.Drawing.Size(110, 22)
        Me.txtDiscountedPrice.TabIndex = 20
        '
        'txtDiscountRate
        '
        Me.txtDiscountRate.Location = New System.Drawing.Point(337, 336)
        Me.txtDiscountRate.Name = "txtDiscountRate"
        Me.txtDiscountRate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscountRate.Properties.Appearance.Options.UseFont = True
        Me.txtDiscountRate.Size = New System.Drawing.Size(110, 22)
        Me.txtDiscountRate.TabIndex = 22
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(244, 339)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(87, 16)
        Me.LabelControl5.TabIndex = 21
        Me.LabelControl5.Text = "Discount Rate :"
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(685, 336)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayment.Properties.Appearance.Options.UseFont = True
        Me.txtPayment.Size = New System.Drawing.Size(110, 22)
        Me.txtPayment.TabIndex = 24
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(621, 339)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl6.TabIndex = 23
        Me.LabelControl6.Text = "Payment :"
        '
        'frmSalesManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 411)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtDiscountRate)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtDiscountedPrice)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.PopupContainerControl_CustomerSearch)
        Me.Controls.Add(Me.btnPlaceSales)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.TotalSalesDGV)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.SalesDGV)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.PanelButton)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSalesManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelButton.ResumeLayout(False)
        Me.PanelButton.PerformLayout()
        CType(Me.PopupContainerCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerControl_CustomerSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl_CustomerSearch.ResumeLayout(False)
        CType(Me.CustomerSearchDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerSearchGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalSalesDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalSalesGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscountedPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscountRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPayment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents btnOldSalesReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCustomerManagement As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelButton As System.Windows.Forms.Panel
    Friend WithEvents SalesDGV As DevExpress.XtraGrid.GridControl
    Friend WithEvents SalesGV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ToolTipController As DevExpress.Utils.ToolTipController
    Friend WithEvents lblCustomer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblReceiptNumber As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TotalSalesDGV As DevExpress.XtraGrid.GridControl
    Friend WithEvents TotalSalesGV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PopupContainerCustomer As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents PopupContainerControl_CustomerSearch As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents CustomerSearchDGV As DevExpress.XtraGrid.GridControl
    Friend WithEvents CustomerSearchGV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPlaceSales As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtNote As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiscountedPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiscountRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPayment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
End Class
