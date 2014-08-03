<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssistant
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAssistant))
        Me.lblShopName = New DevExpress.XtraEditors.LabelControl()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.ToolTipController = New DevExpress.Utils.ToolTipController(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.lblContact = New DevExpress.XtraEditors.LabelControl()
        Me.txtContact = New DevExpress.XtraEditors.TextEdit()
        Me.lblShopAddress = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSend = New DevExpress.XtraEditors.SimpleButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtMessage = New DevExpress.XtraEditors.MemoEdit()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSubject = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMessage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblShopName
        '
        Me.lblShopName.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShopName.Location = New System.Drawing.Point(55, 171)
        Me.lblShopName.Name = "lblShopName"
        Me.lblShopName.Size = New System.Drawing.Size(118, 16)
        Me.lblShopName.TabIndex = 1
        Me.lblShopName.Text = "Name (Required) :"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(184, 168)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Properties.Appearance.Options.UseFont = True
        Me.txtName.Size = New System.Drawing.Size(428, 22)
        Me.txtName.TabIndex = 2
        Me.txtName.ToolTipController = Me.ToolTipController
        '
        'ToolTipController
        '
        Me.ToolTipController.Rounded = True
        Me.ToolTipController.ShowBeak = True
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(20, 140)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(259, 16)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Fill in the form below, we'll contact you asap!"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(184, 207)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Properties.Appearance.Options.UseFont = True
        Me.txtEmail.Size = New System.Drawing.Size(428, 22)
        Me.txtEmail.TabIndex = 5
        Me.txtEmail.ToolTipController = Me.ToolTipController
        '
        'lblContact
        '
        Me.lblContact.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(58, 210)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(115, 16)
        Me.lblContact.TabIndex = 4
        Me.lblContact.Text = "Email (Required) :"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(184, 246)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Properties.Appearance.Options.UseFont = True
        Me.txtContact.Size = New System.Drawing.Size(428, 22)
        Me.txtContact.TabIndex = 7
        '
        'lblShopAddress
        '
        Me.lblShopAddress.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShopAddress.Location = New System.Drawing.Point(69, 249)
        Me.lblShopAddress.Name = "lblShopAddress"
        Me.lblShopAddress.Size = New System.Drawing.Size(104, 16)
        Me.lblShopAddress.TabIndex = 6
        Me.lblShopAddress.Text = "Phone Contact :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(33, 325)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(140, 16)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Message (Required) :"
        '
        'btnSend
        '
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.Location = New System.Drawing.Point(488, 474)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(124, 44)
        Me.btnSend.TabIndex = 12
        Me.btnSend.Text = "&Send"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(624, 530)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -5
        Me.LineShape1.X2 = 630
        Me.LineShape1.Y1 = 463
        Me.LineShape1.Y2 = 463
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(184, 324)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(428, 128)
        Me.txtMessage.TabIndex = 14
        Me.txtMessage.ToolTipController = Me.ToolTipController
        Me.txtMessage.UseOptimizedRendering = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-269, -23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(999, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(184, 285)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.Properties.Appearance.Options.UseFont = True
        Me.txtSubject.Size = New System.Drawing.Size(428, 22)
        Me.txtSubject.TabIndex = 16
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(115, 288)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl2.TabIndex = 15
        Me.LabelControl2.Text = "Subject :"
        '
        'frmAssistant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 530)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.lblShopAddress)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblShopName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAssistant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMessage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblShopName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblContact As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtContact As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblShopAddress As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSend As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtMessage As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtSubject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ToolTipController As DevExpress.Utils.ToolTipController
End Class
