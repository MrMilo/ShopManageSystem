<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockSearch))
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.lblCustomerManagement = New DevExpress.XtraEditors.LabelControl()
        Me.ToolTipController = New DevExpress.Utils.ToolTipController(Me.components)
        Me.ReportDGV = New DevExpress.XtraGrid.GridControl()
        Me.ReportGV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelTop.SuspendLayout()
        CType(Me.ReportDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.lblCustomerManagement)
        Me.PanelTop.Location = New System.Drawing.Point(-1, -1)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(822, 50)
        Me.PanelTop.TabIndex = 4
        '
        'lblCustomerManagement
        '
        Me.lblCustomerManagement.Appearance.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerManagement.Location = New System.Drawing.Point(13, 13)
        Me.lblCustomerManagement.Name = "lblCustomerManagement"
        Me.lblCustomerManagement.Size = New System.Drawing.Size(109, 22)
        Me.lblCustomerManagement.TabIndex = 4
        Me.lblCustomerManagement.Text = "Search Result"
        '
        'ToolTipController
        '
        Me.ToolTipController.AllowHtmlText = True
        Me.ToolTipController.Rounded = True
        Me.ToolTipController.ShowBeak = True
        '
        'ReportDGV
        '
        Me.ReportDGV.Location = New System.Drawing.Point(2, 49)
        Me.ReportDGV.MainView = Me.ReportGV
        Me.ReportDGV.Name = "ReportDGV"
        Me.ReportDGV.Size = New System.Drawing.Size(815, 360)
        Me.ReportDGV.TabIndex = 9
        Me.ReportDGV.ToolTipController = Me.ToolTipController
        Me.ReportDGV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ReportGV})
        '
        'ReportGV
        '
        Me.ReportGV.GridControl = Me.ReportDGV
        Me.ReportGV.Name = "ReportGV"
        Me.ReportGV.OptionsBehavior.Editable = False
        Me.ReportGV.OptionsCustomization.AllowColumnMoving = False
        Me.ReportGV.OptionsCustomization.AllowColumnResizing = False
        Me.ReportGV.OptionsCustomization.AllowFilter = False
        Me.ReportGV.OptionsCustomization.AllowSort = False
        Me.ReportGV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.ReportGV.OptionsView.ShowGroupPanel = False
        Me.ReportGV.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'frmStockSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 411)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.ReportDGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStockSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.ReportDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents lblCustomerManagement As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ToolTipController As DevExpress.Utils.ToolTipController
    Friend WithEvents ReportDGV As DevExpress.XtraGrid.GridControl
    Friend WithEvents ReportGV As DevExpress.XtraGrid.Views.Grid.GridView
End Class
