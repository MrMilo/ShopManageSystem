Imports System.ComponentModel
Imports System.Text

Partial Public Class frmLogin
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Visual Studio 2013 Light"
        DevExpress.Skins.SkinManager.EnableFormSkins()
        InitializeComponent()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class