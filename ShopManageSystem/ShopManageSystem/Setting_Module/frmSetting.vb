Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils
Imports System.Xml

Public Class frmSetting
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub frmSetting_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim xd As New XmlDocument
        xd.Load("ShopConfig.xml")

        Dim GetData As XmlNode = xd.SelectSingleNode("/ShopData/ShopBasicConfig")
        txtShopName.Text = GetData.ChildNodes(0).InnerText
        txtShopAddress.Text = GetData.ChildNodes(1).InnerText
        txtShopEmail.Text = GetData.ChildNodes(2).InnerText
        txtContactNumber.Text = GetData.ChildNodes(3).InnerText

        GetAdminData()
        cboUser_SelectedIndexChanged(cboUser, New EventArgs())
    End Sub

    Private Sub GetAdminData()
        cboUser.DataSource = Nothing
        cboUser.Items.Clear()
        Dim da As New OleDbDataAdapter("SELECT admin_id, admin_username FROM tblAdmin", conn)
        Dim dt As New DataTable

        Try
            conn.Open()
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        cboUser.DataSource = dt
        cboUser.DisplayMember = "admin_username"
        cboUser.ValueMember = "admin_id"
    End Sub

    Private Sub btnSaveShop_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveShop.Click
        Try
            Dim xd As New XmlDocument
            xd.Load("ShopConfig.xml")

            Dim ShopBasicConfig As XmlNode = xd.SelectSingleNode("/ShopData/ShopBasicConfig")
            ShopBasicConfig.ChildNodes(0).InnerText = txtShopName.Text 'ShopName
            ShopBasicConfig.ChildNodes(1).InnerText = txtShopAddress.Text 'ShopAddress
            ShopBasicConfig.ChildNodes(2).InnerText = txtShopEmail.Text 'EmailAddress
            ShopBasicConfig.ChildNodes(3).InnerText = txtContactNumber.Text 'contact number

            xd.Save("ShopConfig.xml")

            XtraMessageBox.Show("You had successfully updated the respective record!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboUser_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cboUser.SelectionChangeCommitted
        Dim da As New OleDbDataAdapter("SELECT admin_email, user_permission FROM tblAdmin WHERE admin_id = ?", conn)
        da.SelectCommand.Parameters.AddWithValue("admin_id", cboUser.SelectedValue)

        Dim dt As New DataTable

        Try
            conn.Open()
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.SelectCommand.Parameters.Clear()
        End Try

        txtEmail.Text = dt.Rows(0)("admin_email").ToString

        If cboUser.SelectedValue = 1 Then
            btnDeleteUser.Enabled = False
            GroupBox1.Enabled = False
        Else
            btnDeleteUser.Enabled = True
            GroupBox1.Enabled = True
        End If

        Dim strArr() As String
        strArr = dt.Rows(0)("user_permission").ToString.Split(",")

        If strArr(0) = 1 Then
            chkStockManagement.Checked = True
        Else
            chkStockManagement.Checked = False
        End If

        If strArr(1) = 1 Then
            chkCustomerManagement.Checked = True
        Else
            chkCustomerManagement.Checked = False
        End If

        If strArr(2) = 1 Then
            chkSupplierManagement.Checked = True
        Else
            chkSupplierManagement.Checked = False
        End If

        If strArr(3) = 1 Then
            chkSalesOrder.Checked = True
        Else
            chkSalesOrder.Checked = False
        End If

        If strArr(4) = 1 Then
            chkRestockOrder.Checked = True
        Else
            chkRestockOrder.Checked = False
        End If

        If strArr(5) = 1 Then
            chkReporting.Checked = True
        Else
            chkReporting.Checked = False
        End If

        If strArr(6) = 1 Then
            chkSettings.Checked = True
        Else
            chkSettings.Checked = False
        End If

        If strArr(7) = 1 Then
            chkAssistant.Checked = True
        Else
            chkAssistant.Checked = False
        End If
    End Sub

    Private Sub btnAddUser_Click(sender As System.Object, e As System.EventArgs) Handles btnAddUser.Click
        If btnAddUser.Text = "&Add" Then
            btnAddUser.Text = "Cancel"
            btnUpdateUser.Text = "Save"
            txtNewPassword.Text = ""
            txtConfirmPassword.Text = ""
            txtEmail.Text = ""
            cboUser.SelectedIndex = -1

            GroupBox1.Enabled = True
            cboUser.DropDownStyle = ComboBoxStyle.Simple
        Else
            btnAddUser.Text = "&Add"
            btnUpdateUser.Text = "&Update"
            cboUser.DropDownStyle = ComboBoxStyle.DropDownList
            cboUser.SelectedIndex = 0
            GroupBox1.Enabled = False
            cboUser_SelectedIndexChanged(cboUser, New EventArgs())
        End If
    End Sub

    Private Sub btnUpdateUser_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdateUser.Click
        Dim GeneratePermission As String = ""
        If chkStockManagement.Checked = True Then
            GeneratePermission = GeneratePermission & "1"
        Else
            GeneratePermission = GeneratePermission & "0"
        End If

        If chkCustomerManagement.Checked = True Then
            GeneratePermission = GeneratePermission & ",1"
        Else
            GeneratePermission = GeneratePermission & ",0"
        End If

        If chkSupplierManagement.Checked = True Then
            GeneratePermission = GeneratePermission & ",1"
        Else
            GeneratePermission = GeneratePermission & ",0"
        End If

        If chkSalesOrder.Checked = True Then
            GeneratePermission = GeneratePermission & ",1"
        Else
            GeneratePermission = GeneratePermission & ",0"
        End If

        If chkRestockOrder.Checked = True Then
            GeneratePermission = GeneratePermission & ",1"
        Else
            GeneratePermission = GeneratePermission & ",0"
        End If

        If chkReporting.Checked = True Then
            GeneratePermission = GeneratePermission & ",1"
        Else
            GeneratePermission = GeneratePermission & ",0"
        End If

        If chkSettings.Checked = True Then
            GeneratePermission = GeneratePermission & ",1"
        Else
            GeneratePermission = GeneratePermission & ",0"
        End If

        If chkAssistant.Checked = True Then
            GeneratePermission = GeneratePermission & ",1"
        Else
            GeneratePermission = GeneratePermission & ",0"
        End If


        If btnUpdateUser.Text = "Save" Then
            If cboUser.Text.Length > 0 Then
                If txtEmail.Text.Length > 0 Then
                    If txtNewPassword.Text = txtConfirmPassword.Text Then
                        Dim InsertUserIntoDB As New OleDbCommand("INSERT INTO tblAdmin (admin_username, admin_email, admin_password, user_permission) VALUES (?, ?, ?, ?)", conn)
                        InsertUserIntoDB.Parameters.AddWithValue("admin_username", cboUser.Text)
                        InsertUserIntoDB.Parameters.AddWithValue("admin_email", txtEmail.Text)
                        If txtConfirmPassword.Text.Length > 0 Then
                            InsertUserIntoDB.Parameters.AddWithValue("admin_password", txtConfirmPassword.Text.GetHashCode)
                        Else
                            InsertUserIntoDB.Parameters.AddWithValue("admin_password", "")
                        End If
                        InsertUserIntoDB.Parameters.AddWithValue("user_permission", GeneratePermission)

                        Try
                            conn.Open()
                            InsertUserIntoDB.ExecuteNonQuery()
                            XtraMessageBox.Show("User has been added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            conn.Close()
                            btnAddUser.Text = "&Add"
                            btnUpdateUser.Text = "&Update"
                            cboUser.DropDownStyle = ComboBoxStyle.DropDownList
                            cboUser.SelectedIndex = 0
                            GroupBox1.Enabled = False
                            GetAdminData()
                            cboUser_SelectedIndexChanged(cboUser, New EventArgs())
                        End Try
                    Else
                        XtraMessageBox.Show("Password mistmatch!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    txtEmail.ToolTipController.ShowHint("Please enter your email!", DevExpress.Utils.ToolTipLocation.BottomRight, txtEmail.PointToScreen(New Point(20, -5)))
                End If
            Else
                XtraMessageBox.Show("Username cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            If cboUser.Text.Length > 0 Then
                If txtEmail.Text.Length > 0 Then
                    If txtNewPassword.Text = txtConfirmPassword.Text Then
                        Dim UpdateUser As New OleDbCommand("UPDATE tblAdmin SET admin_email = ?, admin_password = ?, user_permission = ? WHERE admin_id = ?", conn)
                        UpdateUser.Parameters.AddWithValue("admin_email", txtEmail.Text)
                        If txtConfirmPassword.Text.Length > 0 Then
                            UpdateUser.Parameters.AddWithValue("admin_password", txtConfirmPassword.Text.GetHashCode)
                        Else
                            UpdateUser.Parameters.AddWithValue("admin_password", "")
                        End If
                        UpdateUser.Parameters.AddWithValue("user_permission", GeneratePermission)
                        UpdateUser.Parameters.AddWithValue("admin_id", cboUser.SelectedValue)

                        Try
                            conn.Open()
                            UpdateUser.ExecuteNonQuery()
                            XtraMessageBox.Show("User has been updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            conn.Close()
                            btnAddUser.Text = "&Add"
                            btnUpdateUser.Text = "&Update"
                            cboUser.DropDownStyle = ComboBoxStyle.DropDownList
                            cboUser.SelectedIndex = 0
                            GroupBox1.Enabled = False
                            GetAdminData()
                            cboUser_SelectedIndexChanged(cboUser, New EventArgs())
                        End Try
                    Else
                        XtraMessageBox.Show("Password mistmatch!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    txtEmail.ToolTipController.ShowHint("Please enter your email!", DevExpress.Utils.ToolTipLocation.BottomRight, txtEmail.PointToScreen(New Point(20, -5)))
                End If
            Else
                XtraMessageBox.Show("Username cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnDeleteUser_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteUser.Click
        If cboUser.SelectedValue > 0 Then
            Dim DeleteUser As New OleDbCommand("DELETE * FROM tblAdmin WHERE admin_id = ?", conn)
            DeleteUser.Parameters.AddWithValue("admin_id", cboUser.SelectedValue)

            Try
                conn.Open()
                DeleteUser.ExecuteNonQuery()
                XtraMessageBox.Show("The selected user has been deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
                GetAdminData()
                cboUser_SelectedIndexChanged(cboUser, New EventArgs())
            End Try
        Else
            XtraMessageBox.Show("You may not delete the 'Boss' account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class