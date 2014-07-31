<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditSalesItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditSalesItem))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.PopupContainerControl_Product = New DevExpress.XtraEditors.PopupContainerControl()
        Me.StockDGV = New DevExpress.XtraGrid.GridControl()
        Me.StockGV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ToolTipController = New DevExpress.Utils.ToolTipController(Me.components)
        Me.PopupContainerProduct = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.txtCategory = New DevExpress.XtraEditors.TextEdit()
        Me.txtUnit = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalPrice = New DevExpress.XtraEditors.TextEdit()
        Me.txtPricePerUnit = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.lblStockAdd = New DevExpress.XtraEditors.LabelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PopupContainerControl_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl_Product.SuspendLayout()
        CType(Me.StockDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPricePerUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(47, 67)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(90, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Product Model :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(317, 109)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 16)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Price/Unit :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(311, 151)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(70, 16)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Total Price :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(77, 107)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(60, 16)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Category :"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(59, 147)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(78, 16)
        Me.LabelControl5.TabIndex = 0
        Me.LabelControl5.Text = "Product Unit :"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(18, 187)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(119, 16)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "Product Description :"
        '
        'PopupContainerControl_Product
        '
        Me.PopupContainerControl_Product.Controls.Add(Me.StockDGV)
        Me.PopupContainerControl_Product.Location = New System.Drawing.Point(2, 364)
        Me.PopupContainerControl_Product.Name = "PopupContainerControl_Product"
        Me.PopupContainerControl_Product.Size = New System.Drawing.Size(258, 238)
        Me.PopupContainerControl_Product.TabIndex = 9
        '
        'StockDGV
        '
        Me.StockDGV.Location = New System.Drawing.Point(2, 2)
        Me.StockDGV.MainView = Me.StockGV
        Me.StockDGV.Name = "StockDGV"
        Me.StockDGV.Size = New System.Drawing.Size(254, 234)
        Me.StockDGV.TabIndex = 9
        Me.StockDGV.ToolTipController = Me.ToolTipController
        Me.StockDGV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.StockGV})
        '
        'StockGV
        '
        Me.StockGV.GridControl = Me.StockDGV
        Me.StockGV.Name = "StockGV"
        Me.StockGV.OptionsBehavior.Editable = False
        Me.StockGV.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.StockGV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.StockGV.OptionsView.ShowGroupPanel = False
        Me.StockGV.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'ToolTipController
        '
        Me.ToolTipController.Rounded = True
        Me.ToolTipController.ShowBeak = True
        '
        'PopupContainerProduct
        '
        Me.PopupContainerProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PopupContainerProduct.Location = New System.Drawing.Point(143, 64)
        Me.PopupContainerProduct.Name = "PopupContainerProduct"
        Me.PopupContainerProduct.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopupContainerProduct.Properties.Appearance.Options.UseFont = True
        Me.PopupContainerProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PopupContainerProduct.Properties.NullValuePrompt = "Search by Product Name"
        Me.PopupContainerProduct.Properties.PopupControl = Me.PopupContainerControl_Product
        Me.PopupContainerProduct.Properties.PopupSizeable = False
        Me.PopupContainerProduct.Properties.ShowPopupCloseButton = False
        Me.PopupContainerProduct.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PopupContainerProduct.Size = New System.Drawing.Size(374, 22)
        Me.PopupContainerProduct.TabIndex = 1
        Me.PopupContainerProduct.ToolTipController = Me.ToolTipController
        '
        'txtCategory
        '
        Me.txtCategory.Enabled = False
        Me.txtCategory.Location = New System.Drawing.Point(143, 106)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Properties.Appearance.Options.UseFont = True
        Me.txtCategory.Size = New System.Drawing.Size(130, 22)
        Me.txtCategory.TabIndex = 2
        Me.txtCategory.ToolTipController = Me.ToolTipController
        '
        'txtUnit
        '
        Me.txtUnit.EditValue = "1"
        Me.txtUnit.Location = New System.Drawing.Point(143, 144)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Properties.Appearance.Options.UseFont = True
        Me.txtUnit.Size = New System.Drawing.Size(130, 22)
        Me.txtUnit.TabIndex = 3
        Me.txtUnit.ToolTipController = Me.ToolTipController
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.EditValue = "RM000000.00"
        Me.txtTotalPrice.Location = New System.Drawing.Point(387, 148)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.Properties.Appearance.Options.UseFont = True
        Me.txtTotalPrice.Properties.Mask.BeepOnError = True
        Me.txtTotalPrice.Properties.Mask.EditMask = "$000000.00"
        Me.txtTotalPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalPrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalPrice.Properties.MaxLength = 10
        Me.txtTotalPrice.Size = New System.Drawing.Size(130, 22)
        Me.txtTotalPrice.TabIndex = 5
        '
        'txtPricePerUnit
        '
        Me.txtPricePerUnit.EditValue = "RM00000000.00"
        Me.txtPricePerUnit.Location = New System.Drawing.Point(387, 106)
        Me.txtPricePerUnit.Name = "txtPricePerUnit"
        Me.txtPricePerUnit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPricePerUnit.Properties.Appearance.Options.UseFont = True
        Me.txtPricePerUnit.Properties.Mask.BeepOnError = True
        Me.txtPricePerUnit.Properties.Mask.EditMask = "$000000.00"
        Me.txtPricePerUnit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPricePerUnit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPricePerUnit.Size = New System.Drawing.Size(130, 22)
        Me.txtPricePerUnit.TabIndex = 4
        '
        'txtDescription
        '
        Me.txtDescription.EditValue = ""
        Me.txtDescription.Enabled = False
        Me.txtDescription.Location = New System.Drawing.Point(143, 184)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Size = New System.Drawing.Size(374, 22)
        Me.txtDescription.TabIndex = 6
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PanelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTop.Controls.Add(Me.lblStockAdd)
        Me.PanelTop.Location = New System.Drawing.Point(-5, -1)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(548, 50)
        Me.PanelTop.TabIndex = 13
        '
        'lblStockAdd
        '
        Me.lblStockAdd.Appearance.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockAdd.Location = New System.Drawing.Point(14, 12)
        Me.lblStockAdd.Name = "lblStockAdd"
        Me.lblStockAdd.Size = New System.Drawing.Size(117, 22)
        Me.lblStockAdd.TabIndex = 4
        Me.lblStockAdd.Text = "Edit Sales Item"
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Location = New System.Drawing.Point(393, 237)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 44)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&Cancel"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(539, 291)
        Me.ShapeContainer1.TabIndex = 15
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -14
        Me.LineShape1.X2 = 558
        Me.LineShape1.Y1 = 226
        Me.LineShape1.Y2 = 226
        '
        'btnEdit
        '
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Location = New System.Drawing.Point(247, 237)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(124, 44)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "&Edit"
        '
        'frmEditSalesItem
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 291)
        Me.Controls.Add(Me.PopupContainerControl_Product)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.txtPricePerUnit)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.PopupContainerProduct)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditSalesItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PopupContainerControl_Product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl_Product.ResumeLayout(False)
        CType(Me.StockDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPricePerUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PopupContainerControl_Product As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents PopupContainerProduct As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents txtCategory As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPricePerUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents lblStockAdd As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToolTipController As DevExpress.Utils.ToolTipController
    Friend WithEvents StockDGV As DevExpress.XtraGrid.GridControl
    Friend WithEvents StockGV As DevExpress.XtraGrid.Views.Grid.GridView
End Class
