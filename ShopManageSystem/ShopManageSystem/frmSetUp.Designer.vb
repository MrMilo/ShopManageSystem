<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetUp))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblShopName = New DevExpress.XtraEditors.LabelControl()
        Me.txtShopName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtContactNumber = New DevExpress.XtraEditors.TextEdit()
        Me.lblContact = New DevExpress.XtraEditors.LabelControl()
        Me.txtShopAddress = New DevExpress.XtraEditors.TextEdit()
        Me.lblShopAddress = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmailAddress = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lblEmailWarning = New DevExpress.XtraEditors.LabelControl()
        Me.btnConfirm = New DevExpress.XtraEditors.SimpleButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShopName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContactNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShopAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmailAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-8, -68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(664, 194)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblShopName
        '
        Me.lblShopName.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShopName.Location = New System.Drawing.Point(20, 171)
        Me.lblShopName.Name = "lblShopName"
        Me.lblShopName.Size = New System.Drawing.Size(158, 16)
        Me.lblShopName.TabIndex = 1
        Me.lblShopName.Text = "Shop Name (Required) : "
        '
        'txtShopName
        '
        Me.txtShopName.Location = New System.Drawing.Point(184, 168)
        Me.txtShopName.Name = "txtShopName"
        Me.txtShopName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShopName.Properties.Appearance.Options.UseFont = True
        Me.txtShopName.Size = New System.Drawing.Size(428, 22)
        Me.txtShopName.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(20, 140)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(459, 16)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Please fill in your basic detail, the information are required to use the softwar" & _
            "e :"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(184, 207)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.Properties.Appearance.Options.UseFont = True
        Me.txtContactNumber.Size = New System.Drawing.Size(428, 22)
        Me.txtContactNumber.TabIndex = 5
        '
        'lblContact
        '
        Me.lblContact.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(60, 210)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(113, 16)
        Me.lblContact.TabIndex = 4
        Me.lblContact.Text = "Contact Number :"
        '
        'txtShopAddress
        '
        Me.txtShopAddress.Location = New System.Drawing.Point(184, 244)
        Me.txtShopAddress.Name = "txtShopAddress"
        Me.txtShopAddress.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShopAddress.Properties.Appearance.Options.UseFont = True
        Me.txtShopAddress.Size = New System.Drawing.Size(428, 22)
        Me.txtShopAddress.TabIndex = 7
        '
        'lblShopAddress
        '
        Me.lblShopAddress.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShopAddress.Location = New System.Drawing.Point(74, 247)
        Me.lblShopAddress.Name = "lblShopAddress"
        Me.lblShopAddress.Size = New System.Drawing.Size(103, 16)
        Me.lblShopAddress.TabIndex = 6
        Me.lblShopAddress.Text = "Shop Address : "
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(184, 310)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddress.Properties.Appearance.Options.UseFont = True
        Me.txtEmailAddress.Size = New System.Drawing.Size(428, 22)
        Me.txtEmailAddress.TabIndex = 9
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(66, 313)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(107, 16)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Email Address* :"
        '
        'lblEmailWarning
        '
        Me.lblEmailWarning.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailWarning.Location = New System.Drawing.Point(20, 283)
        Me.lblEmailWarning.Name = "lblEmailWarning"
        Me.lblEmailWarning.Size = New System.Drawing.Size(541, 16)
        Me.lblEmailWarning.TabIndex = 10
        Me.lblEmailWarning.Text = "Please fill in your email address (THIS IS IMPORTANT!), password recovery will be" & _
            " sent here :"
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(488, 364)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(124, 44)
        Me.btnConfirm.TabIndex = 12
        Me.btnConfirm.Text = "&Confirm"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(624, 414)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -5
        Me.LineShape1.X2 = 630
        Me.LineShape1.Y1 = 354
        Me.LineShape1.Y2 = 354
        '
        'frmSetUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 414)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblEmailWarning)
        Me.Controls.Add(Me.txtEmailAddress)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtShopAddress)
        Me.Controls.Add(Me.lblShopAddress)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtShopName)
        Me.Controls.Add(Me.lblShopName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSetUp"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShopName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContactNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShopAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmailAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblShopName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtShopName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtContactNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblContact As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtShopAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblShopAddress As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmailAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEmailWarning As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnConfirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
