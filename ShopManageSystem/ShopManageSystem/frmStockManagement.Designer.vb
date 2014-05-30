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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockManagement))
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.cboSearch = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblStockManagement = New DevExpress.XtraEditors.LabelControl()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.chkSelectAll = New DevExpress.XtraEditors.CheckEdit()
        Me.pceDDCategory = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.PopupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
        Me.tvCategoryDropDown = New System.Windows.Forms.TreeView()
        Me.btnBuckChangeCat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHideZeroStock = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.tvCategory = New System.Windows.Forms.TreeView()
        Me.StockDGV = New DevExpress.XtraGrid.GridControl()
        Me.StockGV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelTop.SuspendLayout()
        CType(Me.cboSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelButton.SuspendLayout()
        CType(Me.chkSelectAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pceDDCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl1.SuspendLayout()
        CType(Me.StockDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.btnSearch)
        Me.PanelTop.Controls.Add(Me.cboSearch)
        Me.PanelTop.Controls.Add(Me.lblStockManagement)
        Me.PanelTop.Location = New System.Drawing.Point(-1, -1)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(822, 50)
        Me.PanelTop.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(731, 13)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "&Search"
        '
        'cboSearch
        '
        Me.cboSearch.Location = New System.Drawing.Point(532, 15)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSearch.Size = New System.Drawing.Size(193, 20)
        Me.cboSearch.TabIndex = 5
        '
        'lblStockManagement
        '
        Me.lblStockManagement.Appearance.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockManagement.Location = New System.Drawing.Point(14, 12)
        Me.lblStockManagement.Name = "lblStockManagement"
        Me.lblStockManagement.Size = New System.Drawing.Size(155, 22)
        Me.lblStockManagement.TabIndex = 4
        Me.lblStockManagement.Text = "Stock Management"
        '
        'PanelButton
        '
        Me.PanelButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelButton.Controls.Add(Me.chkSelectAll)
        Me.PanelButton.Controls.Add(Me.pceDDCategory)
        Me.PanelButton.Controls.Add(Me.btnBuckChangeCat)
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
        Me.chkSelectAll.Location = New System.Drawing.Point(684, 15)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Properties.Caption = "Select All"
        Me.chkSelectAll.Size = New System.Drawing.Size(75, 19)
        Me.chkSelectAll.TabIndex = 9
        '
        'pceDDCategory
        '
        Me.pceDDCategory.Location = New System.Drawing.Point(549, 13)
        Me.pceDDCategory.Name = "pceDDCategory"
        Me.pceDDCategory.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pceDDCategory.Properties.Appearance.Options.UseFont = True
        Me.pceDDCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.pceDDCategory.Properties.NullValuePrompt = "All"
        Me.pceDDCategory.Properties.PopupControl = Me.PopupContainerControl1
        Me.pceDDCategory.Properties.PopupSizeable = False
        Me.pceDDCategory.Properties.ShowPopupCloseButton = False
        Me.pceDDCategory.Size = New System.Drawing.Size(100, 22)
        Me.pceDDCategory.TabIndex = 8
        '
        'PopupContainerControl1
        '
        Me.PopupContainerControl1.Controls.Add(Me.tvCategoryDropDown)
        Me.PopupContainerControl1.Location = New System.Drawing.Point(-1, 456)
        Me.PopupContainerControl1.Name = "PopupContainerControl1"
        Me.PopupContainerControl1.Size = New System.Drawing.Size(203, 238)
        Me.PopupContainerControl1.TabIndex = 8
        '
        'tvCategoryDropDown
        '
        Me.tvCategoryDropDown.Location = New System.Drawing.Point(1, 1)
        Me.tvCategoryDropDown.Name = "tvCategoryDropDown"
        Me.tvCategoryDropDown.Size = New System.Drawing.Size(202, 237)
        Me.tvCategoryDropDown.TabIndex = 0
        '
        'btnBuckChangeCat
        '
        Me.btnBuckChangeCat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuckChangeCat.Location = New System.Drawing.Point(434, 12)
        Me.btnBuckChangeCat.Name = "btnBuckChangeCat"
        Me.btnBuckChangeCat.Size = New System.Drawing.Size(115, 23)
        Me.btnBuckChangeCat.TabIndex = 0
        Me.btnBuckChangeCat.Text = "Change Category &To"
        '
        'btnHideZeroStock
        '
        Me.btnHideZeroStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHideZeroStock.Location = New System.Drawing.Point(318, 13)
        Me.btnHideZeroStock.Name = "btnHideZeroStock"
        Me.btnHideZeroStock.Size = New System.Drawing.Size(89, 23)
        Me.btnHideZeroStock.TabIndex = 0
        Me.btnHideZeroStock.Text = "&Hide Zero Stock"
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Location = New System.Drawing.Point(216, 13)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "&Delete"
        '
        'btnEdit
        '
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Location = New System.Drawing.Point(114, 13)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 0
        Me.btnEdit.Text = "&Edit"
        '
        'btnNew
        '
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.Location = New System.Drawing.Point(12, 13)
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
        Me.tvCategory.Size = New System.Drawing.Size(140, 260)
        Me.tvCategory.TabIndex = 6
        '
        'StockDGV
        '
        Me.StockDGV.Location = New System.Drawing.Point(138, 97)
        Me.StockDGV.MainView = Me.StockGV
        Me.StockDGV.Name = "StockDGV"
        Me.StockDGV.Size = New System.Drawing.Size(675, 302)
        Me.StockDGV.TabIndex = 7
        Me.StockDGV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.StockGV})
        '
        'StockGV
        '
        Me.StockGV.GridControl = Me.StockDGV
        Me.StockGV.Name = "StockGV"
        Me.StockGV.OptionsBehavior.Editable = False
        Me.StockGV.OptionsSelection.MultiSelect = True
        Me.StockGV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.StockGV.OptionsView.ShowGroupPanel = False
        Me.StockGV.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SimpleButton1.Location = New System.Drawing.Point(-1, 356)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(140, 43)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "New &Category"
        '
        'frmStockManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 411)
        Me.Controls.Add(Me.PopupContainerControl1)
        Me.Controls.Add(Me.StockDGV)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.tvCategory)
        Me.Controls.Add(Me.PanelButton)
        Me.Controls.Add(Me.PanelTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStockManagement"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.cboSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelButton.ResumeLayout(False)
        CType(Me.chkSelectAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pceDDCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl1.ResumeLayout(False)
        CType(Me.StockDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboSearch As DevExpress.XtraEditors.ComboBoxEdit
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
    Friend WithEvents pceDDCategory As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents PopupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents tvCategoryDropDown As System.Windows.Forms.TreeView
    Friend WithEvents chkSelectAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
