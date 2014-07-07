Imports DevExpress.LookAndFeel
Imports System
Imports System.Xml

Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            DevExpress.UserSkins.BonusSkins.Register()

            DevExpress.LookAndFeel.UserLookAndFeel.Default.UseWindowsXPTheme = False
            DevExpress.LookAndFeel.UserLookAndFeel.Default.UseDefaultLookAndFeel = False
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Visual Studio 2013 Light"

            DevExpress.Skins.SkinManager.EnableMdiFormSkins()
            DevExpress.Skins.SkinManager.EnableFormSkins()

            If GlobalVariables.AlwaysCreateShopConfig Or IO.File.Exists("ShopConfig.xml") = False Then 'create the XML if not exist
                Dim XmlSettings As New XmlWriterSettings
                Dim XmlWrite As XmlWriter = XmlWriter.Create("ShopConfig.xml", XmlSettings)

                With XmlWrite
                    .WriteStartDocument()
                    .WriteComment("ShopConfiguration")

                    'Start of ShopData
                    .WriteStartElement("ShopData")

                    'Start of ShopBasicConfig
                    .WriteStartElement("ShopBasicConfig")

                    .WriteStartElement("ShopName")
                    .WriteString("DefaultShopName")
                    .WriteEndElement()

                    .WriteStartElement("ShopAddress")
                    .WriteString("123, Abc")
                    .WriteEndElement()

                    .WriteStartElement("EmailAddress")
                    .WriteString("noreply@milostudio.net")
                    .WriteEndElement()

                    .WriteEndElement()
                    'End of ShopBasicConfig


                    'Start of ShopVariables
                    .WriteStartElement("ShopVariables")

                    .WriteStartElement("ShopSetupCondition")
                    .WriteString("0")
                    .WriteEndElement()

                    .WriteEndElement()
                    'End of ShopVariables

                    .WriteEndElement()
                    'End of ShopData

                    .WriteEndDocument()

                    .Close()
                End With
            End If

            Dim ShopSetupCondition As Integer = 0

            Dim xd As New XmlDocument
            xd.Load("ShopConfig.xml")

            Dim ShopVariables As XmlNode = xd.SelectSingleNode("/ShopData/ShopVariables")
            ShopSetupCondition = ShopVariables.ChildNodes(0).InnerText

            If Not GlobalVariables.IgnoreStartupCode Then
                If ShopSetupCondition = 0 Then
                    My.Application.MainForm = frmSetUp
                Else
                    My.Application.MainForm = frmLogin
                End If
            End If

            'MsgBox(ShopSetupCondition)
        End Sub
    End Class
End Namespace

