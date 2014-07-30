<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerGroupManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerGroupManagement))
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCatAdd = New DevExpress.XtraEditors.LabelControl()
        Me.ToolTipController = New DevExpress.Utils.ToolTipController(Me.components)
        Me.CustomerGroupDGV = New DevExpress.XtraGrid.GridControl()
        Me.CustomerGroupGV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTypeName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPointsRequired = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtDiscountRate = New DevExpress.XtraEditors.SpinEdit()
        Me.PanelTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerGroupDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerGroupGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTypeName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPointsRequired.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscountRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PanelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTop.Controls.Add(Me.PictureBox1)
        Me.PanelTop.Controls.Add(Me.lblCatAdd)
        Me.PanelTop.Location = New System.Drawing.Point(-1, -1)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(875, 50)
        Me.PanelTop.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'lblCatAdd
        '
        Me.lblCatAdd.Appearance.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatAdd.Location = New System.Drawing.Point(43, 10)
        Me.lblCatAdd.Name = "lblCatAdd"
        Me.lblCatAdd.Size = New System.Drawing.Size(222, 22)
        Me.lblCatAdd.TabIndex = 4
        Me.lblCatAdd.Text = "Customer Group Magement"
        '
        'ToolTipController
        '
        Me.ToolTipController.Rounded = True
        Me.ToolTipController.ShowBeak = True
        '
        'CustomerGroupDGV
        '
        Me.CustomerGroupDGV.Location = New System.Drawing.Point(9, 55)
        Me.CustomerGroupDGV.MainView = Me.CustomerGroupGV
        Me.CustomerGroupDGV.Name = "CustomerGroupDGV"
        Me.CustomerGroupDGV.Size = New System.Drawing.Size(523, 258)
        Me.CustomerGroupDGV.TabIndex = 15
        Me.ToolTip.SetToolTip(Me.CustomerGroupDGV, "Double click on the row to edit!")
        Me.CustomerGroupDGV.ToolTipController = Me.ToolTipController
        Me.CustomerGroupDGV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.CustomerGroupGV})
        '
        'CustomerGroupGV
        '
        Me.CustomerGroupGV.GridControl = Me.CustomerGroupDGV
        Me.CustomerGroupGV.Name = "CustomerGroupGV"
        Me.CustomerGroupGV.OptionsBehavior.Editable = False
        Me.CustomerGroupGV.OptionsSelection.MultiSelect = True
        Me.CustomerGroupGV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.CustomerGroupGV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.CustomerGroupGV.OptionsView.ShowGroupPanel = False
        Me.CustomerGroupGV.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Location = New System.Drawing.Point(692, 269)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 44)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "&Cancel"
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Location = New System.Drawing.Point(544, 200)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(124, 44)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "&Add"
        '
        'btnEdit
        '
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Enabled = False
        Me.btnEdit.Location = New System.Drawing.Point(544, 269)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(124, 44)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "&Edit"
        '
        'txtTypeName
        '
        Me.txtTypeName.Location = New System.Drawing.Point(652, 55)
        Me.txtTypeName.Name = "txtTypeName"
        Me.txtTypeName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTypeName.Properties.Appearance.Options.UseFont = True
        Me.txtTypeName.Size = New System.Drawing.Size(164, 22)
        Me.txtTypeName.TabIndex = 1
        Me.txtTypeName.ToolTipController = Me.ToolTipController
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(567, 58)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(75, 16)
        Me.LabelControl1.TabIndex = 20
        Me.LabelControl1.Text = "Group Type :"
        '
        'txtPointsRequired
        '
        Me.txtPointsRequired.EditValue = "0"
        Me.txtPointsRequired.Location = New System.Drawing.Point(652, 148)
        Me.txtPointsRequired.Name = "txtPointsRequired"
        Me.txtPointsRequired.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPointsRequired.Properties.Appearance.Options.UseFont = True
        Me.txtPointsRequired.Size = New System.Drawing.Size(164, 22)
        Me.txtPointsRequired.TabIndex = 3
        Me.txtPointsRequired.ToolTipController = Me.ToolTipController
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(544, 151)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(98, 16)
        Me.LabelControl2.TabIndex = 22
        Me.LabelControl2.Text = "Points Required :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(555, 104)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(87, 16)
        Me.LabelControl3.TabIndex = 24
        Me.LabelControl3.Text = "Discount Rate :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(804, 104)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(12, 16)
        Me.LabelControl4.TabIndex = 26
        Me.LabelControl4.Text = "%"
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Location = New System.Drawing.Point(691, 200)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(124, 44)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "&Delete"
        '
        'txtDiscountRate
        '
        Me.txtDiscountRate.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDiscountRate.Location = New System.Drawing.Point(652, 101)
        Me.txtDiscountRate.Name = "txtDiscountRate"
        Me.txtDiscountRate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscountRate.Properties.Appearance.Options.UseFont = True
        Me.txtDiscountRate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDiscountRate.Properties.IsFloatValue = False
        Me.txtDiscountRate.Properties.Mask.EditMask = "N00"
        Me.txtDiscountRate.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtDiscountRate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtDiscountRate.Size = New System.Drawing.Size(146, 22)
        Me.txtDiscountRate.TabIndex = 27
        '
        'frmCustomerGroupManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 325)
        Me.Controls.Add(Me.txtDiscountRate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtPointsRequired)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtTypeName)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.CustomerGroupDGV)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomerGroupManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerGroupDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerGroupGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTypeName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPointsRequired.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscountRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents lblCatAdd As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ToolTipController As DevExpress.Utils.ToolTipController
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CustomerGroupDGV As DevExpress.XtraGrid.GridControl
    Friend WithEvents CustomerGroupGV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTypeName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPointsRequired As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents txtDiscountRate As DevExpress.XtraEditors.SpinEdit
End Class
