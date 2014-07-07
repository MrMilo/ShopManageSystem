<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockManagement))
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PopupContainerProduct = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.PopupContainerControl_ProductSearch = New DevExpress.XtraEditors.PopupContainerControl()
        Me.ProductSearchDGV = New DevExpress.XtraGrid.GridControl()
        Me.ProductSearchGV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ToolTipController = New DevExpress.Utils.ToolTipController(Me.components)
        Me.lblProduct = New DevExpress.XtraEditors.LabelControl()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.lblStockManagement = New DevExpress.XtraEditors.LabelControl()
        Me.PopupContainerControl_Category = New DevExpress.XtraEditors.PopupContainerControl()
        Me.tvCategoryDropDown = New System.Windows.Forms.TreeView()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.chkSelectAll = New DevExpress.XtraEditors.CheckEdit()
        Me.PopupContainerCategory = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.btnBuckChangeCat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHideZeroStock = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.tvCategory = New System.Windows.Forms.TreeView()
        Me.StockDGV = New DevExpress.XtraGrid.GridControl()
        Me.StockGV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnAddNewCategory = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerControl_ProductSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl_ProductSearch.SuspendLayout()
        CType(Me.ProductSearchDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductSearchGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerControl_Category, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl_Category.SuspendLayout()
        Me.PanelButton.SuspendLayout()
        CType(Me.chkSelectAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.PictureBox1)
        Me.PanelTop.Controls.Add(Me.PopupContainerProduct)
        Me.PanelTop.Controls.Add(Me.lblProduct)
        Me.PanelTop.Controls.Add(Me.btnSearch)
        Me.PanelTop.Controls.Add(Me.lblStockManagement)
        Me.PanelTop.Location = New System.Drawing.Point(-1, -1)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(822, 50)
        Me.PanelTop.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PopupContainerProduct
        '
        Me.PopupContainerProduct.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PopupContainerProduct.Location = New System.Drawing.Point(532, 14)
        Me.PopupContainerProduct.Name = "PopupContainerProduct"
        Me.PopupContainerProduct.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopupContainerProduct.Properties.Appearance.Options.UseFont = True
        Me.PopupContainerProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PopupContainerProduct.Properties.NullValuePrompt = "Search by Model Name"
        Me.PopupContainerProduct.Properties.PopupControl = Me.PopupContainerControl_ProductSearch
        Me.PopupContainerProduct.Properties.PopupSizeable = False
        Me.PopupContainerProduct.Properties.ShowPopupCloseButton = False
        Me.PopupContainerProduct.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PopupContainerProduct.Size = New System.Drawing.Size(193, 22)
        Me.PopupContainerProduct.TabIndex = 10
        '
        'PopupContainerControl_ProductSearch
        '
        Me.PopupContainerControl_ProductSearch.Controls.Add(Me.ProductSearchDGV)
        Me.PopupContainerControl_ProductSearch.Location = New System.Drawing.Point(211, 458)
        Me.PopupContainerControl_ProductSearch.Name = "PopupContainerControl_ProductSearch"
        Me.PopupContainerControl_ProductSearch.Size = New System.Drawing.Size(314, 181)
        Me.PopupContainerControl_ProductSearch.TabIndex = 9
        '
        'ProductSearchDGV
        '
        Me.ProductSearchDGV.Location = New System.Drawing.Point(2, 1)
        Me.ProductSearchDGV.MainView = Me.ProductSearchGV
        Me.ProductSearchDGV.Name = "ProductSearchDGV"
        Me.ProductSearchDGV.Size = New System.Drawing.Size(310, 178)
        Me.ProductSearchDGV.TabIndex = 8
        Me.ProductSearchDGV.ToolTipController = Me.ToolTipController
        Me.ProductSearchDGV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ProductSearchGV})
        '
        'ProductSearchGV
        '
        Me.ProductSearchGV.GridControl = Me.ProductSearchDGV
        Me.ProductSearchGV.Name = "ProductSearchGV"
        Me.ProductSearchGV.OptionsBehavior.Editable = False
        Me.ProductSearchGV.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.ProductSearchGV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.ProductSearchGV.OptionsView.ShowGroupPanel = False
        Me.ProductSearchGV.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'ToolTipController
        '
        '
        'lblProduct
        '
        Me.lblProduct.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.Location = New System.Drawing.Point(446, 16)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(80, 16)
        Me.lblProduct.TabIndex = 7
        Me.lblProduct.Text = "Model Name :"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Location = New System.Drawing.Point(731, 13)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "&Search"
        '
        'lblStockManagement
        '
        Me.lblStockManagement.Appearance.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockManagement.Location = New System.Drawing.Point(48, 12)
        Me.lblStockManagement.Name = "lblStockManagement"
        Me.lblStockManagement.Size = New System.Drawing.Size(155, 22)
        Me.lblStockManagement.TabIndex = 4
        Me.lblStockManagement.Text = "Stock Management"
        '
        'PopupContainerControl_Category
        '
        Me.PopupContainerControl_Category.Controls.Add(Me.tvCategoryDropDown)
        Me.PopupContainerControl_Category.Location = New System.Drawing.Point(-1, 456)
        Me.PopupContainerControl_Category.Name = "PopupContainerControl_Category"
        Me.PopupContainerControl_Category.Size = New System.Drawing.Size(203, 238)
        Me.PopupContainerControl_Category.TabIndex = 8
        '
        'tvCategoryDropDown
        '
        Me.tvCategoryDropDown.Location = New System.Drawing.Point(1, 1)
        Me.tvCategoryDropDown.Name = "tvCategoryDropDown"
        Me.tvCategoryDropDown.Size = New System.Drawing.Size(202, 237)
        Me.tvCategoryDropDown.TabIndex = 0
        '
        'PanelButton
        '
        Me.PanelButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelButton.Controls.Add(Me.chkSelectAll)
        Me.PanelButton.Controls.Add(Me.PopupContainerCategory)
        Me.PanelButton.Controls.Add(Me.btnBuckChangeCat)
        Me.PanelButton.Controls.Add(Me.btnExport)
        Me.PanelButton.Controls.Add(Me.btnHideZeroStock)
        Me.PanelButton.Controls.Add(Me.btnDelete)
        Me.PanelButton.Controls.Add(Me.btnEdit)
        Me.PanelButton.Controls.Add(Me.btnNew)
        Me.PanelButton.Location = New System.Drawing.Point(-1, 48)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(822, 50)
        Me.PanelButton.TabIndex = 5
        '
        'chkSelectAll
        '
        Me.chkSelectAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkSelectAll.Location = New System.Drawing.Point(728, 14)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelectAll.Properties.Appearance.Options.UseFont = True
        Me.chkSelectAll.Properties.Caption = "Select All"
        Me.chkSelectAll.Size = New System.Drawing.Size(75, 20)
        Me.chkSelectAll.TabIndex = 9
        '
        'PopupContainerCategory
        '
        Me.PopupContainerCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PopupContainerCategory.Location = New System.Drawing.Point(615, 13)
        Me.PopupContainerCategory.Name = "PopupContainerCategory"
        Me.PopupContainerCategory.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopupContainerCategory.Properties.Appearance.Options.UseFont = True
        Me.PopupContainerCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PopupContainerCategory.Properties.NullValuePrompt = "Others"
        Me.PopupContainerCategory.Properties.PopupControl = Me.PopupContainerControl_Category
        Me.PopupContainerCategory.Properties.PopupSizeable = False
        Me.PopupContainerCategory.Properties.ShowPopupCloseButton = False
        Me.PopupContainerCategory.Size = New System.Drawing.Size(104, 22)
        Me.PopupContainerCategory.TabIndex = 8
        '
        'btnBuckChangeCat
        '
        Me.btnBuckChangeCat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuckChangeCat.Location = New System.Drawing.Point(501, 12)
        Me.btnBuckChangeCat.Name = "btnBuckChangeCat"
        Me.btnBuckChangeCat.Size = New System.Drawing.Size(115, 23)
        Me.btnBuckChangeCat.TabIndex = 0
        Me.btnBuckChangeCat.Text = "Change Category &To"
        '
        'btnExport
        '
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.Location = New System.Drawing.Point(395, 13)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(89, 23)
        Me.btnExport.TabIndex = 0
        Me.btnExport.Text = "E&xport"
        '
        'btnHideZeroStock
        '
        Me.btnHideZeroStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHideZeroStock.Location = New System.Drawing.Point(289, 13)
        Me.btnHideZeroStock.Name = "btnHideZeroStock"
        Me.btnHideZeroStock.Size = New System.Drawing.Size(89, 23)
        Me.btnHideZeroStock.TabIndex = 0
        Me.btnHideZeroStock.Text = "&Hide Zero Stock"
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Location = New System.Drawing.Point(197, 13)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "&Delete"
        '
        'btnEdit
        '
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Location = New System.Drawing.Point(105, 13)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 0
        Me.btnEdit.Text = "&Edit"
        '
        'btnNew
        '
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.Location = New System.Drawing.Point(13, 13)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "&New"
        '
        'tvCategory
        '
        Me.tvCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.tvCategory.Location = New System.Drawing.Point(-1, 97)
        Me.tvCategory.Name = "tvCategory"
        Me.tvCategory.Size = New System.Drawing.Size(140, 273)
        Me.tvCategory.TabIndex = 6
        '
        'StockDGV
        '
        Me.StockDGV.Location = New System.Drawing.Point(138, 97)
        Me.StockDGV.MainView = Me.StockGV
        Me.StockDGV.Name = "StockDGV"
        Me.StockDGV.Size = New System.Drawing.Size(675, 314)
        Me.StockDGV.TabIndex = 7
        Me.StockDGV.ToolTipController = Me.ToolTipController
        Me.StockDGV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.StockGV})
        '
        'StockGV
        '
        Me.StockGV.GridControl = Me.StockDGV
        Me.StockGV.Name = "StockGV"
        Me.StockGV.OptionsBehavior.Editable = False
        Me.StockGV.OptionsSelection.MultiSelect = True
        Me.StockGV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.StockGV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.StockGV.OptionsView.ShowGroupPanel = False
        Me.StockGV.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'btnAddNewCategory
        '
        Me.btnAddNewCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewCategory.Location = New System.Drawing.Point(0, 368)
        Me.btnAddNewCategory.Name = "btnAddNewCategory"
        Me.btnAddNewCategory.Size = New System.Drawing.Size(139, 43)
        Me.btnAddNewCategory.TabIndex = 0
        Me.btnAddNewCategory.Text = "New &Category"
        '
        'frmStockManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 411)
        Me.Controls.Add(Me.PopupContainerControl_ProductSearch)
        Me.Controls.Add(Me.PopupContainerControl_Category)
        Me.Controls.Add(Me.StockDGV)
        Me.Controls.Add(Me.btnAddNewCategory)
        Me.Controls.Add(Me.tvCategory)
        Me.Controls.Add(Me.PanelButton)
        Me.Controls.Add(Me.PanelTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStockManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerControl_ProductSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl_ProductSearch.ResumeLayout(False)
        CType(Me.ProductSearchDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductSearchGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerControl_Category, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl_Category.ResumeLayout(False)
        Me.PanelButton.ResumeLayout(False)
        CType(Me.chkSelectAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblStockManagement As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelButton As System.Windows.Forms.Panel
    Friend WithEvents tvCategory As System.Windows.Forms.TreeView
    Friend WithEvents StockDGV As DevExpress.XtraGrid.GridControl
    Friend WithEvents StockGV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnHideZeroStock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuckChangeCat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PopupContainerCategory As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents PopupContainerControl_Category As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents tvCategoryDropDown As System.Windows.Forms.TreeView
    Friend WithEvents chkSelectAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnAddNewCategory As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToolTipController As DevExpress.Utils.ToolTipController
    Friend WithEvents lblProduct As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PopupContainerProduct As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents PopupContainerControl_ProductSearch As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents ProductSearchDGV As DevExpress.XtraGrid.GridControl
    Friend WithEvents ProductSearchGV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
