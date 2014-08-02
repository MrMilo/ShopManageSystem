<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddCustomer))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCustomerName = New DevExpress.XtraEditors.TextEdit()
        Me.ToolTipController = New DevExpress.Utils.ToolTipController(Me.components)
        Me.txtContact = New DevExpress.XtraEditors.TextEdit()
        Me.txtOldDebt = New DevExpress.XtraEditors.TextEdit()
        Me.txtDebt = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.lblStockAdd = New DevExpress.XtraEditors.LabelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAddress = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNote = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFacebook = New DevExpress.XtraEditors.TextEdit()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPoints = New DevExpress.XtraEditors.TextEdit()
        Me.cboGroup = New System.Windows.Forms.ComboBox()
        CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOldDebt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFacebook.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPoints.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(14, 67)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(123, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Customer Name (*) :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(512, 67)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(82, 16)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Current Debt :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Enabled = False
        Me.LabelControl3.Location = New System.Drawing.Point(536, 109)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Old Debt :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(94, 151)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Group :"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(295, 108)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl5.TabIndex = 0
        Me.LabelControl5.Text = "Contact :"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(553, 151)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(40, 16)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "Email :"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(143, 64)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Properties.Appearance.Options.UseFont = True
        Me.txtCustomerName.Size = New System.Drawing.Size(340, 22)
        Me.txtCustomerName.TabIndex = 1
        Me.txtCustomerName.ToolTipController = Me.ToolTipController
        '
        'ToolTipController
        '
        Me.ToolTipController.Rounded = True
        Me.ToolTipController.ShowBeak = True
        '
        'txtContact
        '
        Me.txtContact.EditValue = ""
        Me.txtContact.Location = New System.Drawing.Point(353, 105)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Properties.Appearance.Options.UseFont = True
        Me.txtContact.Size = New System.Drawing.Size(130, 22)
        Me.txtContact.TabIndex = 3
        Me.txtContact.ToolTipController = Me.ToolTipController
        '
        'txtOldDebt
        '
        Me.txtOldDebt.EditValue = "0.00"
        Me.txtOldDebt.Enabled = False
        Me.txtOldDebt.Location = New System.Drawing.Point(599, 106)
        Me.txtOldDebt.Name = "txtOldDebt"
        Me.txtOldDebt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldDebt.Properties.Appearance.Options.UseFont = True
        Me.txtOldDebt.Properties.Mask.BeepOnError = True
        Me.txtOldDebt.Properties.Mask.EditMask = "$000000.00"
        Me.txtOldDebt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtOldDebt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtOldDebt.Properties.MaxLength = 10
        Me.txtOldDebt.Size = New System.Drawing.Size(130, 22)
        Me.txtOldDebt.TabIndex = 8
        '
        'txtDebt
        '
        Me.txtDebt.EditValue = "0.00"
        Me.txtDebt.Location = New System.Drawing.Point(599, 64)
        Me.txtDebt.Name = "txtDebt"
        Me.txtDebt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebt.Properties.Appearance.Options.UseFont = True
        Me.txtDebt.Properties.Mask.BeepOnError = True
        Me.txtDebt.Properties.Mask.EditMask = "$000000.00"
        Me.txtDebt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDebt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDebt.Size = New System.Drawing.Size(130, 22)
        Me.txtDebt.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.EditValue = ""
        Me.txtEmail.Location = New System.Drawing.Point(599, 148)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Properties.Appearance.Options.UseFont = True
        Me.txtEmail.Size = New System.Drawing.Size(130, 22)
        Me.txtEmail.TabIndex = 9
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PanelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTop.Controls.Add(Me.lblStockAdd)
        Me.PanelTop.Location = New System.Drawing.Point(-5, -1)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(802, 50)
        Me.PanelTop.TabIndex = 13
        '
        'lblStockAdd
        '
        Me.lblStockAdd.Appearance.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockAdd.Location = New System.Drawing.Point(14, 12)
        Me.lblStockAdd.Name = "lblStockAdd"
        Me.lblStockAdd.Size = New System.Drawing.Size(153, 22)
        Me.lblStockAdd.TabIndex = 4
        Me.lblStockAdd.Text = "Add New Customer"
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Location = New System.Drawing.Point(605, 280)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 44)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "&Cancel"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(737, 338)
        Me.ShapeContainer1.TabIndex = 15
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -11
        Me.LineShape1.X2 = 794
        Me.LineShape1.Y1 = 270
        Me.LineShape1.Y2 = 270
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Location = New System.Drawing.Point(459, 280)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(124, 44)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "&Add"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(69, 191)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(68, 16)
        Me.LabelControl7.TabIndex = 0
        Me.LabelControl7.Text = "Addresses :"
        '
        'txtAddress
        '
        Me.txtAddress.EditValue = ""
        Me.txtAddress.Location = New System.Drawing.Point(143, 188)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Properties.Appearance.Options.UseFont = True
        Me.txtAddress.Size = New System.Drawing.Size(340, 22)
        Me.txtAddress.TabIndex = 6
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(102, 232)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(35, 16)
        Me.LabelControl8.TabIndex = 0
        Me.LabelControl8.Text = "Note :"
        '
        'txtNote
        '
        Me.txtNote.EditValue = ""
        Me.txtNote.Location = New System.Drawing.Point(143, 229)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Properties.Appearance.Options.UseFont = True
        Me.txtNote.Size = New System.Drawing.Size(586, 22)
        Me.txtNote.TabIndex = 11
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(531, 190)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl9.TabIndex = 0
        Me.LabelControl9.Text = "Facebook :"
        '
        'txtFacebook
        '
        Me.txtFacebook.EditValue = ""
        Me.txtFacebook.Location = New System.Drawing.Point(599, 187)
        Me.txtFacebook.Name = "txtFacebook"
        Me.txtFacebook.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacebook.Properties.Appearance.Options.UseFont = True
        Me.txtFacebook.Properties.NullText = "fb.com/24minutes"
        Me.txtFacebook.Size = New System.Drawing.Size(130, 22)
        Me.txtFacebook.TabIndex = 10
        '
        'DateTimePicker
        '
        Me.DateTimePicker.CalendarFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker.Location = New System.Drawing.Point(143, 105)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(130, 21)
        Me.DateTimePicker.TabIndex = 2
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(62, 109)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(75, 16)
        Me.LabelControl10.TabIndex = 0
        Me.LabelControl10.Text = "Date Added :"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(304, 150)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl11.TabIndex = 0
        Me.LabelControl11.Text = "Points :"
        '
        'txtPoints
        '
        Me.txtPoints.EditValue = "0"
        Me.txtPoints.Location = New System.Drawing.Point(353, 147)
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoints.Properties.Appearance.Options.UseFont = True
        Me.txtPoints.Size = New System.Drawing.Size(130, 22)
        Me.txtPoints.TabIndex = 5
        Me.txtPoints.ToolTipController = Me.ToolTipController
        '
        'cboGroup
        '
        Me.cboGroup.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGroup.FormattingEnabled = True
        Me.cboGroup.Location = New System.Drawing.Point(143, 148)
        Me.cboGroup.Name = "cboGroup"
        Me.cboGroup.Size = New System.Drawing.Size(130, 24)
        Me.cboGroup.TabIndex = 16
        '
        'frmAddCustomer
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 338)
        Me.Controls.Add(Me.cboGroup)
        Me.Controls.Add(Me.txtPoints)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.txtFacebook)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.txtDebt)
        Me.Controls.Add(Me.txtOldDebt)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtCustomerName)
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
        Me.Name = "frmAddCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOldDebt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFacebook.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPoints.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustomerName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtContact As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOldDebt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDebt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents lblStockAdd As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToolTipController As DevExpress.Utils.ToolTipController
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNote As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFacebook As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPoints As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboGroup As System.Windows.Forms.ComboBox
End Class
