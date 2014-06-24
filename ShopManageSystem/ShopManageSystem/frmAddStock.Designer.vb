<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddStock))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.PopupContainerControl = New DevExpress.XtraEditors.PopupContainerControl()
        Me.tvCategoryDropDown = New System.Windows.Forms.TreeView()
        Me.pceDDCategory = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.txtModel = New DevExpress.XtraEditors.TextEdit()
        Me.txtQuantity = New DevExpress.XtraEditors.TextEdit()
        Me.txtPrice = New DevExpress.XtraEditors.TextEdit()
        Me.txtCost = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.lblStockAdd = New DevExpress.XtraEditors.LabelControl()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.lblProductProfit = New DevExpress.XtraEditors.LabelControl()
        Me.ToolTipController = New DevExpress.Utils.ToolTipController(Me.components)
        CType(Me.PopupContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl.SuspendLayout()
        CType(Me.pceDDCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(25, 67)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(112, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Product Model (*) :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(300, 109)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(81, 16)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Product Cost :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(297, 151)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(84, 16)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Product Price :"
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
        Me.LabelControl5.Location = New System.Drawing.Point(34, 147)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(103, 16)
        Me.LabelControl5.TabIndex = 0
        Me.LabelControl5.Text = "Product Quantity :"
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
        'PopupContainerControl
        '
        Me.PopupContainerControl.Controls.Add(Me.tvCategoryDropDown)
        Me.PopupContainerControl.Location = New System.Drawing.Point(0, 436)
        Me.PopupContainerControl.Name = "PopupContainerControl"
        Me.PopupContainerControl.Size = New System.Drawing.Size(203, 238)
        Me.PopupContainerControl.TabIndex = 9
        '
        'tvCategoryDropDown
        '
        Me.tvCategoryDropDown.Location = New System.Drawing.Point(1, 1)
        Me.tvCategoryDropDown.Name = "tvCategoryDropDown"
        Me.tvCategoryDropDown.Size = New System.Drawing.Size(202, 237)
        Me.tvCategoryDropDown.TabIndex = 0
        '
        'pceDDCategory
        '
        Me.pceDDCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pceDDCategory.Location = New System.Drawing.Point(143, 106)
        Me.pceDDCategory.Name = "pceDDCategory"
        Me.pceDDCategory.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pceDDCategory.Properties.Appearance.Options.UseFont = True
        Me.pceDDCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.pceDDCategory.Properties.NullValuePrompt = "Others"
        Me.pceDDCategory.Properties.PopupControl = Me.PopupContainerControl
        Me.pceDDCategory.Properties.PopupSizeable = False
        Me.pceDDCategory.Properties.ShowPopupCloseButton = False
        Me.pceDDCategory.Size = New System.Drawing.Size(130, 22)
        Me.pceDDCategory.TabIndex = 3
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(143, 64)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModel.Properties.Appearance.Options.UseFont = True
        Me.txtModel.Size = New System.Drawing.Size(374, 22)
        Me.txtModel.TabIndex = 1
        Me.txtModel.ToolTipController = Me.ToolTipController
        '
        'txtQuantity
        '
        Me.txtQuantity.EditValue = "0"
        Me.txtQuantity.Location = New System.Drawing.Point(143, 144)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Properties.Appearance.Options.UseFont = True
        Me.txtQuantity.Size = New System.Drawing.Size(130, 22)
        Me.txtQuantity.TabIndex = 4
        Me.txtQuantity.ToolTip = "Numeric only"
        Me.txtQuantity.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Warning
        '
        'txtPrice
        '
        Me.txtPrice.EditValue = "0.00"
        Me.txtPrice.Location = New System.Drawing.Point(387, 148)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Properties.Appearance.Options.UseFont = True
        Me.txtPrice.Properties.Mask.BeepOnError = True
        Me.txtPrice.Properties.Mask.EditMask = "$000000.00"
        Me.txtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrice.Properties.MaxLength = 10
        Me.txtPrice.Size = New System.Drawing.Size(130, 22)
        Me.txtPrice.TabIndex = 6
        '
        'txtCost
        '
        Me.txtCost.EditValue = "0.00"
        Me.txtCost.Location = New System.Drawing.Point(387, 106)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Properties.Appearance.Options.UseFont = True
        Me.txtCost.Properties.Mask.BeepOnError = True
        Me.txtCost.Properties.Mask.EditMask = "$000000.00"
        Me.txtCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCost.Size = New System.Drawing.Size(130, 22)
        Me.txtCost.TabIndex = 5
        '
        'txtDescription
        '
        Me.txtDescription.EditValue = ""
        Me.txtDescription.Location = New System.Drawing.Point(143, 184)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Size = New System.Drawing.Size(374, 22)
        Me.txtDescription.TabIndex = 11
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
        Me.lblStockAdd.Size = New System.Drawing.Size(119, 22)
        Me.lblStockAdd.TabIndex = 4
        Me.lblStockAdd.Text = "Add New Stock"
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Location = New System.Drawing.Point(403, 273)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 44)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "&Cancel"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(539, 329)
        Me.ShapeContainer1.TabIndex = 15
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -14
        Me.LineShape1.X2 = 558
        Me.LineShape1.Y1 = 262
        Me.LineShape1.Y2 = 262
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Location = New System.Drawing.Point(257, 273)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(124, 44)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "&Add"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(51, 227)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(86, 16)
        Me.LabelControl7.TabIndex = 0
        Me.LabelControl7.Text = "Product Profit :"
        '
        'lblProductProfit
        '
        Me.lblProductProfit.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductProfit.Location = New System.Drawing.Point(143, 227)
        Me.lblProductProfit.Name = "lblProductProfit"
        Me.lblProductProfit.Size = New System.Drawing.Size(43, 16)
        Me.lblProductProfit.TabIndex = 0
        Me.lblProductProfit.Text = "RM0.00"
        '
        'ToolTipController
        '
        Me.ToolTipController.Rounded = True
        Me.ToolTipController.ShowBeak = True
        '
        'frmAddStock
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 329)
        Me.Controls.Add(Me.lblProductProfit)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.pceDDCategory)
        Me.Controls.Add(Me.PopupContainerControl)
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
        Me.Name = "frmAddStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PopupContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl.ResumeLayout(False)
        CType(Me.pceDDCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PopupContainerControl As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents tvCategoryDropDown As System.Windows.Forms.TreeView
    Friend WithEvents pceDDCategory As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents txtModel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtQuantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents lblStockAdd As DevExpress.XtraEditors.LabelControl
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblProductProfit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ToolTipController As DevExpress.Utils.ToolTipController
End Class
