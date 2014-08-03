<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditCategory))
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.lblCatAdd = New DevExpress.XtraEditors.LabelControl()
        Me.PopupContainerControl = New DevExpress.XtraEditors.PopupContainerControl()
        Me.tvCategoryDropDown = New System.Windows.Forms.TreeView()
        Me.pceDDCategory = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCategoryName = New DevExpress.XtraEditors.TextEdit()
        Me.ToolTipController = New DevExpress.Utils.ToolTipController(Me.components)
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelTop.SuspendLayout()
        CType(Me.PopupContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl.SuspendLayout()
        CType(Me.pceDDCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategoryName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PanelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTop.Controls.Add(Me.lblCatAdd)
        Me.PanelTop.Location = New System.Drawing.Point(-1, -1)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(559, 50)
        Me.PanelTop.TabIndex = 14
        '
        'lblCatAdd
        '
        Me.lblCatAdd.Appearance.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatAdd.Location = New System.Drawing.Point(14, 12)
        Me.lblCatAdd.Name = "lblCatAdd"
        Me.lblCatAdd.Size = New System.Drawing.Size(106, 22)
        Me.lblCatAdd.TabIndex = 4
        Me.lblCatAdd.Text = "Edit Category"
        '
        'PopupContainerControl
        '
        Me.PopupContainerControl.Controls.Add(Me.tvCategoryDropDown)
        Me.PopupContainerControl.Location = New System.Drawing.Point(-1, 241)
        Me.PopupContainerControl.Name = "PopupContainerControl"
        Me.PopupContainerControl.Size = New System.Drawing.Size(203, 238)
        Me.PopupContainerControl.TabIndex = 15
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
        Me.pceDDCategory.Location = New System.Drawing.Point(134, 117)
        Me.pceDDCategory.Name = "pceDDCategory"
        Me.pceDDCategory.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pceDDCategory.Properties.Appearance.Options.UseFont = True
        Me.pceDDCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.pceDDCategory.Properties.NullValuePrompt = "All Categories"
        Me.pceDDCategory.Properties.PopupControl = Me.PopupContainerControl
        Me.pceDDCategory.Properties.PopupSizeable = False
        Me.pceDDCategory.Properties.ShowPopupCloseButton = False
        Me.pceDDCategory.Size = New System.Drawing.Size(150, 22)
        Me.pceDDCategory.TabIndex = 16
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(27, 120)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(101, 16)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "Parent Category :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(31, 76)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(97, 16)
        Me.LabelControl1.TabIndex = 17
        Me.LabelControl1.Text = "Category Name :"
        '
        'txtCategoryName
        '
        Me.txtCategoryName.Location = New System.Drawing.Point(134, 73)
        Me.txtCategoryName.Name = "txtCategoryName"
        Me.txtCategoryName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoryName.Properties.Appearance.Options.UseFont = True
        Me.txtCategoryName.Size = New System.Drawing.Size(150, 22)
        Me.txtCategoryName.TabIndex = 1
        Me.txtCategoryName.ToolTipController = Me.ToolTipController
        '
        'ToolTipController
        '
        Me.ToolTipController.Rounded = True
        Me.ToolTipController.ShowBeak = True
        '
        'btnEdit
        '
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Location = New System.Drawing.Point(24, 182)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(124, 44)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "&Edit"
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Location = New System.Drawing.Point(170, 182)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 44)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        '
        'frmEditCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 238)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtCategoryName)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.pceDDCategory)
        Me.Controls.Add(Me.PopupContainerControl)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.PopupContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl.ResumeLayout(False)
        CType(Me.pceDDCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategoryName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents lblCatAdd As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PopupContainerControl As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents tvCategoryDropDown As System.Windows.Forms.TreeView
    Friend WithEvents pceDDCategory As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCategoryName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToolTipController As DevExpress.Utils.ToolTipController
End Class
