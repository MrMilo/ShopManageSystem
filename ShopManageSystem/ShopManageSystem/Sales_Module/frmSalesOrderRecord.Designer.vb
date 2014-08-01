<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesOrderRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesOrderRecord))
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCustomerManagement = New DevExpress.XtraEditors.LabelControl()
        Me.ToolTipController = New DevExpress.Utils.ToolTipController(Me.components)
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.SalesDGV = New DevExpress.XtraGrid.GridControl()
        Me.SalesGV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TotalSalesDGV = New DevExpress.XtraGrid.GridControl()
        Me.TotalSalesGV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelTop.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelButton.SuspendLayout()
        CType(Me.SalesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalSalesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalSalesGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.LabelControl1)
        Me.PanelTop.Controls.Add(Me.LabelControl2)
        Me.PanelTop.Controls.Add(Me.DateTimePicker2)
        Me.PanelTop.Controls.Add(Me.DateTimePicker1)
        Me.PanelTop.Controls.Add(Me.SimpleButton1)
        Me.PanelTop.Controls.Add(Me.TextEdit1)
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
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(506, 15)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(101, 21)
        Me.DateTimePicker2.TabIndex = 30
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(626, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(101, 21)
        Me.DateTimePicker1.TabIndex = 29
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SimpleButton1.Location = New System.Drawing.Point(733, 14)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 28
        Me.SimpleButton1.Text = "&Search"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(223, 14)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.NullValuePrompt = "Search by any keyword"
        Me.TextEdit1.Properties.NullValuePromptShowForEmptyValue = True
        Me.TextEdit1.Size = New System.Drawing.Size(236, 22)
        Me.TextEdit1.TabIndex = 12
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
        Me.lblCustomerManagement.Size = New System.Drawing.Size(150, 22)
        Me.lblCustomerManagement.TabIndex = 4
        Me.lblCustomerManagement.Text = "Sales Order Record"
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
        Me.PanelButton.Controls.Add(Me.btnExport)
        Me.PanelButton.Controls.Add(Me.btnNew)
        Me.PanelButton.Controls.Add(Me.btnEdit)
        Me.PanelButton.Controls.Add(Me.btnDelete)
        Me.PanelButton.Location = New System.Drawing.Point(-1, 48)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(822, 50)
        Me.PanelButton.TabIndex = 5
        '
        'btnExport
        '
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.Location = New System.Drawing.Point(313, 13)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 27
        Me.btnExport.Text = "E&xport"
        '
        'btnNew
        '
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.Location = New System.Drawing.Point(10, 13)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 11
        Me.btnNew.Text = "&Close"
        '
        'btnEdit
        '
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Location = New System.Drawing.Point(111, 13)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "&Edit"
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Location = New System.Drawing.Point(212, 13)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "&Delete"
        '
        'SalesDGV
        '
        Me.SalesDGV.Location = New System.Drawing.Point(-1, 97)
        Me.SalesDGV.MainView = Me.SalesGV
        Me.SalesDGV.Name = "SalesDGV"
        Me.SalesDGV.Size = New System.Drawing.Size(815, 295)
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
        Me.SalesGV.OptionsCustomization.AllowFilter = False
        Me.SalesGV.OptionsCustomization.AllowSort = False
        Me.SalesGV.OptionsView.ColumnAutoWidth = False
        Me.SalesGV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.SalesGV.OptionsView.ShowGroupPanel = False
        Me.SalesGV.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'TotalSalesDGV
        '
        Me.TotalSalesDGV.Location = New System.Drawing.Point(-1, 391)
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
        'frmSalesOrderRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 411)
        Me.Controls.Add(Me.TotalSalesDGV)
        Me.Controls.Add(Me.SalesDGV)
        Me.Controls.Add(Me.PanelButton)
        Me.Controls.Add(Me.PanelTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSalesOrderRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelButton.ResumeLayout(False)
        CType(Me.SalesDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalSalesDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalSalesGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents lblCustomerManagement As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelButton As System.Windows.Forms.Panel
    Friend WithEvents SalesDGV As DevExpress.XtraGrid.GridControl
    Friend WithEvents SalesGV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ToolTipController As DevExpress.Utils.ToolTipController
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TotalSalesDGV As DevExpress.XtraGrid.GridControl
    Friend WithEvents TotalSalesGV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
