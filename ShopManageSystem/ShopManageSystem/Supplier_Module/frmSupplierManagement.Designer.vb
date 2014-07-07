<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplierManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupplierManagement))
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PopupContainerSupplier = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.PopupContainerControl_CustomerSearch = New DevExpress.XtraEditors.PopupContainerControl()
        Me.SupplierSearchDGV = New DevExpress.XtraGrid.GridControl()
        Me.SupplierSearchGV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ToolTipController = New DevExpress.Utils.ToolTipController(Me.components)
        Me.lblCustomer = New DevExpress.XtraEditors.LabelControl()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.lblCustomerManagement = New DevExpress.XtraEditors.LabelControl()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.lblDebt = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotalDebt = New DevExpress.XtraEditors.LabelControl()
        Me.btnHideZeroDebt = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.chkSelectAll = New DevExpress.XtraEditors.CheckEdit()
        Me.SupplierDGV = New DevExpress.XtraGrid.GridControl()
        Me.SupplierGV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerControl_CustomerSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl_CustomerSearch.SuspendLayout()
        CType(Me.SupplierSearchDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierSearchGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelButton.SuspendLayout()
        CType(Me.chkSelectAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.PictureBox1)
        Me.PanelTop.Controls.Add(Me.PopupContainerSupplier)
        Me.PanelTop.Controls.Add(Me.lblCustomer)
        Me.PanelTop.Controls.Add(Me.btnSearch)
        Me.PanelTop.Controls.Add(Me.lblCustomerManagement)
        Me.PanelTop.Location = New System.Drawing.Point(-1, -1)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(822, 50)
        Me.PanelTop.TabIndex = 4
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
        'PopupContainerSupplier
        '
        Me.PopupContainerSupplier.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PopupContainerSupplier.Location = New System.Drawing.Point(532, 14)
        Me.PopupContainerSupplier.Name = "PopupContainerSupplier"
        Me.PopupContainerSupplier.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopupContainerSupplier.Properties.Appearance.Options.UseFont = True
        Me.PopupContainerSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PopupContainerSupplier.Properties.NullValuePrompt = "Search by Supplier Name"
        Me.PopupContainerSupplier.Properties.PopupControl = Me.PopupContainerControl_CustomerSearch
        Me.PopupContainerSupplier.Properties.PopupSizeable = False
        Me.PopupContainerSupplier.Properties.ShowPopupCloseButton = False
        Me.PopupContainerSupplier.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PopupContainerSupplier.Size = New System.Drawing.Size(193, 22)
        Me.PopupContainerSupplier.TabIndex = 10
        '
        'PopupContainerControl_CustomerSearch
        '
        Me.PopupContainerControl_CustomerSearch.Controls.Add(Me.SupplierSearchDGV)
        Me.PopupContainerControl_CustomerSearch.Location = New System.Drawing.Point(252, 433)
        Me.PopupContainerControl_CustomerSearch.Name = "PopupContainerControl_CustomerSearch"
        Me.PopupContainerControl_CustomerSearch.Size = New System.Drawing.Size(193, 181)
        Me.PopupContainerControl_CustomerSearch.TabIndex = 9
        '
        'SupplierSearchDGV
        '
        Me.SupplierSearchDGV.Location = New System.Drawing.Point(1, 1)
        Me.SupplierSearchDGV.MainView = Me.SupplierSearchGV
        Me.SupplierSearchDGV.Name = "SupplierSearchDGV"
        Me.SupplierSearchDGV.Size = New System.Drawing.Size(194, 178)
        Me.SupplierSearchDGV.TabIndex = 8
        Me.SupplierSearchDGV.ToolTipController = Me.ToolTipController
        Me.SupplierSearchDGV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.SupplierSearchGV})
        '
        'SupplierSearchGV
        '
        Me.SupplierSearchGV.GridControl = Me.SupplierSearchDGV
        Me.SupplierSearchGV.Name = "SupplierSearchGV"
        Me.SupplierSearchGV.OptionsBehavior.Editable = False
        Me.SupplierSearchGV.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SupplierSearchGV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.SupplierSearchGV.OptionsView.ShowGroupPanel = False
        Me.SupplierSearchGV.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'ToolTipController
        '
        Me.ToolTipController.AllowHtmlText = True
        '
        'lblCustomer
        '
        Me.lblCustomer.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(433, 16)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(93, 16)
        Me.lblCustomer.TabIndex = 7
        Me.lblCustomer.Text = "Supplier Name :"
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
        'lblCustomerManagement
        '
        Me.lblCustomerManagement.Appearance.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerManagement.Location = New System.Drawing.Point(45, 12)
        Me.lblCustomerManagement.Name = "lblCustomerManagement"
        Me.lblCustomerManagement.Size = New System.Drawing.Size(177, 22)
        Me.lblCustomerManagement.TabIndex = 4
        Me.lblCustomerManagement.Text = "Supplier Management"
        '
        'PanelButton
        '
        Me.PanelButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelButton.Controls.Add(Me.btnExport)
        Me.PanelButton.Controls.Add(Me.lblDebt)
        Me.PanelButton.Controls.Add(Me.lblTotalDebt)
        Me.PanelButton.Controls.Add(Me.btnHideZeroDebt)
        Me.PanelButton.Controls.Add(Me.btnDelete)
        Me.PanelButton.Controls.Add(Me.btnEdit)
        Me.PanelButton.Controls.Add(Me.btnNew)
        Me.PanelButton.Controls.Add(Me.chkSelectAll)
        Me.PanelButton.Location = New System.Drawing.Point(-1, 48)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(822, 50)
        Me.PanelButton.TabIndex = 5
        '
        'btnExport
        '
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.Location = New System.Drawing.Point(434, 13)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 15
        Me.btnExport.Text = "E&xport"
        '
        'lblDebt
        '
        Me.lblDebt.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebt.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblDebt.Location = New System.Drawing.Point(730, 16)
        Me.lblDebt.Name = "lblDebt"
        Me.lblDebt.Size = New System.Drawing.Size(25, 16)
        Me.lblDebt.TabIndex = 14
        Me.lblDebt.Text = "0.00"
        '
        'lblTotalDebt
        '
        Me.lblTotalDebt.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDebt.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblTotalDebt.Location = New System.Drawing.Point(632, 16)
        Me.lblTotalDebt.Name = "lblTotalDebt"
        Me.lblTotalDebt.Size = New System.Drawing.Size(71, 16)
        Me.lblTotalDebt.TabIndex = 11
        Me.lblTotalDebt.Text = "Total debt : "
        '
        'btnHideZeroDebt
        '
        Me.btnHideZeroDebt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHideZeroDebt.Location = New System.Drawing.Point(318, 13)
        Me.btnHideZeroDebt.Name = "btnHideZeroDebt"
        Me.btnHideZeroDebt.Size = New System.Drawing.Size(89, 23)
        Me.btnHideZeroDebt.TabIndex = 12
        Me.btnHideZeroDebt.Text = "&Hide Zero Debt"
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Location = New System.Drawing.Point(216, 13)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "&Delete"
        '
        'btnEdit
        '
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Location = New System.Drawing.Point(114, 13)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "&Edit"
        '
        'btnNew
        '
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.Location = New System.Drawing.Point(12, 13)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 11
        Me.btnNew.Text = "&New"
        '
        'chkSelectAll
        '
        Me.chkSelectAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkSelectAll.Location = New System.Drawing.Point(538, 14)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelectAll.Properties.Appearance.Options.UseFont = True
        Me.chkSelectAll.Properties.Caption = "Select All"
        Me.chkSelectAll.Size = New System.Drawing.Size(75, 20)
        Me.chkSelectAll.TabIndex = 9
        '
        'SupplierDGV
        '
        Me.SupplierDGV.Location = New System.Drawing.Point(-1, 97)
        Me.SupplierDGV.MainView = Me.SupplierGV
        Me.SupplierDGV.Name = "SupplierDGV"
        Me.SupplierDGV.Size = New System.Drawing.Size(815, 231)
        Me.SupplierDGV.TabIndex = 7
        Me.SupplierDGV.ToolTipController = Me.ToolTipController
        Me.SupplierDGV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.SupplierGV})
        '
        'SupplierGV
        '
        Me.SupplierGV.GridControl = Me.SupplierDGV
        Me.SupplierGV.Name = "SupplierGV"
        Me.SupplierGV.OptionsBehavior.Editable = False
        Me.SupplierGV.OptionsSelection.MultiSelect = True
        Me.SupplierGV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.SupplierGV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.SupplierGV.OptionsView.ShowGroupPanel = False
        Me.SupplierGV.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'frmSupplierManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 411)
        Me.Controls.Add(Me.PopupContainerControl_CustomerSearch)
        Me.Controls.Add(Me.SupplierDGV)
        Me.Controls.Add(Me.PanelButton)
        Me.Controls.Add(Me.PanelTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSupplierManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerControl_CustomerSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl_CustomerSearch.ResumeLayout(False)
        CType(Me.SupplierSearchDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierSearchGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelButton.ResumeLayout(False)
        Me.PanelButton.PerformLayout()
        CType(Me.chkSelectAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCustomerManagement As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelButton As System.Windows.Forms.Panel
    Friend WithEvents SupplierDGV As DevExpress.XtraGrid.GridControl
    Friend WithEvents SupplierGV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chkSelectAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ToolTipController As DevExpress.Utils.ToolTipController
    Friend WithEvents lblCustomer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PopupContainerSupplier As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents PopupContainerControl_CustomerSearch As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents SupplierSearchDGV As DevExpress.XtraGrid.GridControl
    Friend WithEvents SupplierSearchGV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnHideZeroDebt As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTotalDebt As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDebt As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
