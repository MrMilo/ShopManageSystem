<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MarqueeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnSideBar = New System.Windows.Forms.Button()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblAnnouncement = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MarqueeTimer
        '
        Me.MarqueeTimer.Enabled = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-23, -397)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(914, 515)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'btnSideBar
        '
        Me.btnSideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnSideBar.BackgroundImage = CType(resources.GetObject("btnSideBar.BackgroundImage"), System.Drawing.Image)
        Me.btnSideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSideBar.FlatAppearance.BorderSize = 0
        Me.btnSideBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSideBar.Location = New System.Drawing.Point(0, 93)
        Me.btnSideBar.Name = "btnSideBar"
        Me.btnSideBar.Size = New System.Drawing.Size(50, 25)
        Me.btnSideBar.TabIndex = 1
        Me.btnSideBar.UseVisualStyleBackColor = False
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.SidePanel.BackgroundImage = CType(resources.GetObject("SidePanel.BackgroundImage"), System.Drawing.Image)
        Me.SidePanel.Location = New System.Drawing.Point(0, 117)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(50, 435)
        Me.SidePanel.TabIndex = 2
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblVersion, Me.lblAnnouncement, Me.lblDate})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 528)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip.Size = New System.Drawing.Size(864, 24)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 3
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = False
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(290, 19)
        Me.lblVersion.Text = "Version 1.0.0.0"
        '
        'lblAnnouncement
        '
        Me.lblAnnouncement.AutoSize = False
        Me.lblAnnouncement.Name = "lblAnnouncement"
        Me.lblAnnouncement.Size = New System.Drawing.Size(290, 17)
        Me.lblAnnouncement.Text = "Announcement"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = False
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(290, 17)
        Me.lblDate.Text = "Date Time"
        '
        'frmMain
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 552)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.btnSideBar)
        Me.Controls.Add(Me.PictureBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MarqueeTimer As System.Windows.Forms.Timer
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSideBar As System.Windows.Forms.Button
    Friend WithEvents SidePanel As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents lblVersion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblAnnouncement As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDate As System.Windows.Forms.ToolStripStatusLabel
End Class
