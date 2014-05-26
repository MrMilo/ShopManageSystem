<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.ImageSlider = New DevExpress.XtraEditors.Controls.ImageSlider()
        Me.AvatarDecoration = New System.Windows.Forms.PictureBox()
        Me.lblPasswordNotSet = New DevExpress.XtraEditors.LabelControl()
        Me.btnPassword = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLogin = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboUser = New System.Windows.Forms.ComboBox()
        CType(Me.ImageSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvatarDecoration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageSlider
        '
        Me.ImageSlider.AllowLooping = True
        Me.ImageSlider.AnimationTime = 600
        Me.ImageSlider.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.ImageSlider.Images.Add(CType(resources.GetObject("ImageSlider.Images"), System.Drawing.Image))
        Me.ImageSlider.Images.Add(CType(resources.GetObject("ImageSlider.Images1"), System.Drawing.Image))
        Me.ImageSlider.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleCenter
        Me.ImageSlider.Location = New System.Drawing.Point(0, 0)
        Me.ImageSlider.Name = "ImageSlider"
        Me.ImageSlider.ShowToolTips = False
        Me.ImageSlider.Size = New System.Drawing.Size(350, 264)
        Me.ImageSlider.TabIndex = 0
        '
        'AvatarDecoration
        '
        Me.AvatarDecoration.Image = CType(resources.GetObject("AvatarDecoration.Image"), System.Drawing.Image)
        Me.AvatarDecoration.Location = New System.Drawing.Point(119, 0)
        Me.AvatarDecoration.Name = "AvatarDecoration"
        Me.AvatarDecoration.Size = New System.Drawing.Size(127, 137)
        Me.AvatarDecoration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.AvatarDecoration.TabIndex = 1
        Me.AvatarDecoration.TabStop = False
        '
        'lblPasswordNotSet
        '
        Me.lblPasswordNotSet.Location = New System.Drawing.Point(73, 178)
        Me.lblPasswordNotSet.Name = "lblPasswordNotSet"
        Me.lblPasswordNotSet.Size = New System.Drawing.Size(218, 13)
        Me.lblPasswordNotSet.TabIndex = 4
        Me.lblPasswordNotSet.Text = "*Username ""Boss"" haven't set their password"
        Me.lblPasswordNotSet.Visible = False
        '
        'btnPassword
        '
        Me.btnPassword.Enabled = False
        Me.btnPassword.Location = New System.Drawing.Point(35, 220)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(113, 32)
        Me.btnPassword.TabIndex = 5
        Me.btnPassword.Text = "&Set Password"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(167, 220)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(162, 32)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "&Login"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cboUser)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.btnPassword)
        Me.Panel1.Controls.Add(Me.lblPasswordNotSet)
        Me.Panel1.Controls.Add(Me.AvatarDecoration)
        Me.Panel1.Location = New System.Drawing.Point(350, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(364, 264)
        Me.Panel1.TabIndex = 2
        '
        'cboUser
        '
        Me.cboUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboUser.FormattingEnabled = True
        Me.cboUser.Location = New System.Drawing.Point(72, 139)
        Me.cboUser.Name = "cboUser"
        Me.cboUser.Size = New System.Drawing.Size(218, 21)
        Me.cboUser.TabIndex = 7
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 265)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ImageSlider)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to Milo's Shop Management System"
        CType(Me.ImageSlider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvatarDecoration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageSlider As DevExpress.XtraEditors.Controls.ImageSlider
    Friend WithEvents AvatarDecoration As System.Windows.Forms.PictureBox
    Friend WithEvents lblPasswordNotSet As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPassword As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboUser As System.Windows.Forms.ComboBox
End Class
