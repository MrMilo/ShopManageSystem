Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils

Public Class frmCustomerManagement
    Inherits DevExpress.XtraEditors.XtraForm

    'drawing row number
    Private Sub CustomerGV_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles CustomerGV.CustomDrawRowIndicator
        If e.Info.IsRowIndicator Then
            e.Info.DisplayText = e.RowHandle.ToString() + 1
        End If
    End Sub

    Public Sub fillCustomerGV()
        CustomerDGV.DataSource = Nothing

        Try
            Dim da As New OleDbDataAdapter("SELECT tblCustomer.cust_id, tblCustomer.cust_name, tblCustomer.cust_contact, tblCustomer.cust_address, tblCustomer.cust_email, tblCustomer.cust_facebook, tblCustomerGroup.custgroup_type, tblCustomer.cust_date_added, tblCustomer.cust_debt, tblCustomer.cust_points, tblCustomer.cust_note" _
                                           & " FROM tblCustomer INNER JOIN tblCustomerGroup ON tblCustomer.cust_group = tblCustomerGroup.custgroup_id", openConn())

            Dim dt As New DataTable

            da.Fill(dt)

            CustomerDGV.DataSource = dt

            For i = 0 To 9
                CustomerGV.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Next

            CustomerGV.Columns(0).Visible = False 'cust_id

            CustomerGV.Columns(1).Caption = "Customer Name"

            CustomerGV.Columns(2).Caption = "Contact"
            CustomerGV.Columns(2).Width = 25

            CustomerGV.Columns(3).Visible = False 'cust_address
            CustomerGV.Columns(3).Caption = "Customer Address"

            CustomerGV.Columns(4).Visible = False 'cust_email
            CustomerGV.Columns(4).Caption = "Customer Email"

            CustomerGV.Columns(5).Visible = False 'cust_facebook
            CustomerGV.Columns(5).Caption = "Customer Facebook"

            CustomerGV.Columns(6).Caption = "Type"
            CustomerGV.Columns(6).Width = 25

            CustomerGV.Columns(7).Visible = False 'cust_date_added
            CustomerGV.Columns(7).Caption = "Customer Added Date"

            CustomerGV.Columns(8).Caption = "Debt"
            CustomerGV.Columns(8).Width = 30
            CustomerGV.Columns(8).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            CustomerGV.Columns(8).DisplayFormat.FormatString = "c2"

            CustomerGV.Columns(9).Visible = False 'cust_points
            CustomerGV.Columns(9).Caption = "Customer Points"

            CustomerGV.Columns(10).Visible = False 'cust_note
            CustomerGV.Columns(10).Caption = "Customer Note"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        CustomerGV.IndicatorWidth = 35

        'calculate total debt
        Dim CalDebtFromDB As New OleDbCommand("SELECT SUM(cust_debt) AS Customer_Deb FROM tblCustomer", conn)

        Try
            conn.Open()
            lblDebt.Text = CalDebtFromDB.ExecuteScalar

            lblDebt.Text = Format(lblDebt.Text, "Currency")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub fillSearchCustomerGV()
        CustomerSearchDGV.DataSource = Nothing

        Try
            Dim da As New OleDbDataAdapter("SELECT tblCustomer.cust_id, tblCustomer.cust_name FROM tblCustomer", openConn())

            Dim dt As New DataTable

            da.Fill(dt)

            CustomerSearchDGV.DataSource = dt

            CustomerSearchGV.Columns(0).Visible = False 'cust_id

            CustomerSearchGV.Columns(1).Caption = "Customer Name"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CustomerGV_CustomDrawEmptyForeground(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs) Handles CustomerGV.CustomDrawEmptyForeground, CustomerSearchGV.CustomDrawEmptyForeground
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender

        If (view.RowCount <> 0) Then Return

        Dim drawFormat As New StringFormat

        drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center
        e.Graphics.DrawString("No data exists here!", e.Appearance.Font, Brushes.DarkRed, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat)
    End Sub

    Private Sub ToolTipController_GetActiveObjectInfo(ByVal sender As Object, ByVal e As DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs) Handles ToolTipController.GetActiveObjectInfo
        If Not e.SelectedControl Is CustomerDGV Then Return

        Dim hitInfo As GridHitInfo = CustomerGV.CalcHitInfo(e.ControlMousePosition)

        If hitInfo.InRow = False Then Return

        Dim toolTipArgs As SuperToolTipSetupArgs = New SuperToolTipSetupArgs

        Dim drCurrentRow As DataRow = CustomerGV.GetDataRow(hitInfo.RowHandle)
        Dim ContentText As String = ""

        If drCurrentRow(2).ToString.Length > 0 Then
            ContentText = ContentText + vbNewLine + "<b><u>Contact</u></b>" & vbNewLine & drCurrentRow(2).ToString
        End If

        If drCurrentRow(3).ToString.Length > 0 Then
            ContentText = ContentText + vbNewLine + "<b><u>Address</u></b>" & vbNewLine & drCurrentRow(3).ToString
        End If

        If drCurrentRow(4).ToString.Length > 0 Then
            ContentText = ContentText + vbNewLine + "<b><u>Email</u></b>" & vbNewLine & drCurrentRow(4).ToString
        End If

        If drCurrentRow(5).ToString.Length > 0 Then
            ContentText = ContentText + vbNewLine + "<b><u>Facebook</u></b>" & vbNewLine & drCurrentRow(5).ToString
        End If

        If drCurrentRow(7).ToString.Length > 0 Then
            ContentText = ContentText + vbNewLine + "<b><u>Date Added</u></b>" & vbNewLine & drCurrentRow(7).ToString
        End If

        If drCurrentRow(9).ToString.Length > 0 Then
            ContentText = ContentText + vbNewLine + "<b><u>Points</u></b>" & vbNewLine & drCurrentRow(9).ToString
        End If

        If drCurrentRow(10).ToString.Length > 0 Then
            ContentText = ContentText + vbNewLine + "<b><u>Note</u></b>" & vbNewLine & drCurrentRow(10).ToString
        End If


        If drCurrentRow IsNot Nothing Then
            toolTipArgs.Title.Text = drCurrentRow(1).ToString
            toolTipArgs.Contents.Text = ContentText
        End If

        e.Info = New ToolTipControlInfo
        e.Info.Object = hitInfo.HitTest.ToString() + hitInfo.RowHandle.ToString()
        e.Info.ToolTipType = ToolTipType.SuperTip
        e.Info.SuperTip = New SuperToolTip
        e.Info.SuperTip.Setup(toolTipArgs)
    End Sub

    Private Sub frmCustomerManagement_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fillCustomerGV()
        fillSearchCustomerGV()
    End Sub

    Dim HideZeroDebtState As Integer = 0 '0 = no click ; 1 = click
    Private Sub btnHideZeroDebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideZeroDebt.Click
        If HideZeroDebtState = 0 Then
            HideZeroDebtState = 1
            CustomerGV.ActiveFilter.NonColumnFilter = "[cust_debt] > 0"
            btnHideZeroDebt.Text = "&Show All"
        Else
            HideZeroDebtState = 0
            CustomerGV.ClearColumnsFilter()
            btnHideZeroDebt.Text = "&Hide Zero Debt"
        End If
    End Sub

    Private Sub PopupContainerCustomer_ButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PopupContainerCustomer.ButtonClick
        PopupContainerCustomer.ShowPopup()
        CustomerSearchGV.ClearColumnsFilter()
        PopupContainerCustomer.Focus()
    End Sub

    Private Sub PopupContainerCustomer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PopupContainerCustomer.Click
        PopupContainerCustomer.SelectAll()
    End Sub

    Private Sub PopupContainerCustomer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopupContainerCustomer.EditValueChanged
        PopupContainerCustomer.ShowPopup()
        CustomerSearchGV.ActiveFilter.NonColumnFilter = "[cust_name] LIKE '%" & PopupContainerCustomer.Text & "%'"
        PopupContainerCustomer.Focus()

        If PopupContainerCustomer.Text.Length = 0 Then
            CustomerSearchGV.ClearColumnsFilter()
            CustomerGV.ClearColumnsFilter()
        End If
    End Sub

    Private Sub CustomerSearchGV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerSearchGV.DoubleClick
        If CustomerSearchGV.SelectedRowsCount = 0 Then
            XtraMessageBox.Show("Please select a record to perform this action!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            PopupContainerCustomer.Text = CustomerSearchGV.GetRowCellValue(CustomerSearchGV.FocusedRowHandle, "cust_name")
            CustomerGV.ActiveFilter.NonColumnFilter = "[cust_name] = '" & CustomerSearchGV.GetRowCellValue(CustomerSearchGV.FocusedRowHandle, "cust_name") & "'"
            PopupContainerCustomer.ClosePopup()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If PopupContainerCustomer.Text.Length > 0 Then
            CustomerGV.ActiveFilter.NonColumnFilter = "[cust_name] LIKE '%" & PopupContainerCustomer.Text & "%'"
        Else
            CustomerGV.ClearColumnsFilter()
            CustomerSearchGV.ClearColumnsFilter()
        End If
    End Sub

    Private Sub chkSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        If chkSelectAll.Checked = True Then
            CustomerGV.SelectAll()
        Else
            CustomerGV.ClearSelection()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If CustomerGV.SelectedRowsCount > 0 Then 'confirm yes no
            Dim dialogResult = XtraMessageBox.Show("Are you sure you want to delete the selected data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If dialogResult = Windows.Forms.DialogResult.Yes Then
                Dim Rows As New ArrayList()
                ' Add the selected rows to the list.
                Dim I As Integer
                For I = 0 To CustomerGV.SelectedRowsCount() - 1
                    If (CustomerGV.GetSelectedRows()(I) >= 0) Then
                        Rows.Add(CustomerGV.GetDataRow(CustomerGV.GetSelectedRows()(I)))
                    End If
                Next

                For I = 0 To Rows.Count - 1
                    Dim Row As DataRow = CType(Rows(I), DataRow)

                    Dim deleteCustomer As New OleDbCommand("DELETE FROM tblCustomer WHERE cust_id = ?", conn)
                    deleteCustomer.Parameters.AddWithValue("cust_id", Row("cust_id"))

                    Try
                        conn.Open()
                        deleteCustomer.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        conn.Close()
                        deleteCustomer.Parameters.Clear()
                    End Try
                Next
                XtraMessageBox.Show("The selected data has been deleted", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                'finally remove the rows from grid control, so that no repopulation is needed
                CustomerGV.DeleteSelectedRows()

                'refresh
                fillCustomerGV()
            End If
        Else
            XtraMessageBox.Show("Please select a record to perform this action!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If CustomerGV.SelectedRowsCount > 1 Then
            XtraMessageBox.Show("You may only select one row of data!", "More than one data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CustomerGV.SelectedRowsCount = 0 Then
            XtraMessageBox.Show("Please select a record to perform this action!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            frmEditCustomer.CurrentCustID = CustomerGV.GetRowCellValue(CustomerGV.FocusedRowHandle, "cust_id").ToString
            frmEditCustomer.txtCustomerName.Text = CustomerGV.GetRowCellValue(CustomerGV.FocusedRowHandle, "cust_name").ToString
            frmEditCustomer.txtContact.Text = CustomerGV.GetRowCellValue(CustomerGV.FocusedRowHandle, "cust_contact").ToString
            frmEditCustomer.txtAddress.Text = CustomerGV.GetRowCellValue(CustomerGV.FocusedRowHandle, "cust_address").ToString
            frmEditCustomer.txtEmail.Text = CustomerGV.GetRowCellValue(CustomerGV.FocusedRowHandle, "cust_email").ToString
            frmEditCustomer.txtFacebook.Text = CustomerGV.GetRowCellValue(CustomerGV.FocusedRowHandle, "cust_facebook").ToString
            frmEditCustomer.cboGroup.Text = CustomerGV.GetRowCellValue(CustomerGV.FocusedRowHandle, "custgroup_type").ToString
            frmEditCustomer.DateTimePicker.Text = CustomerGV.GetRowCellValue(CustomerGV.FocusedRowHandle, "cust_date_added").ToString
            frmEditCustomer.txtDebt.Text = CustomerGV.GetRowCellValue(CustomerGV.FocusedRowHandle, "cust_debt").ToString
            frmEditCustomer.txtOldDebt.Text = CustomerGV.GetRowCellValue(CustomerGV.FocusedRowHandle, "cust_debt").ToString 'should calculate total debt instead
            frmEditCustomer.txtPoints.Text = CustomerGV.GetRowCellValue(CustomerGV.FocusedRowHandle, "cust_points").ToString
            frmEditCustomer.txtNote.Text = CustomerGV.GetRowCellValue(CustomerGV.FocusedRowHandle, "cust_note").ToString
            frmEditCustomer.ShowDialog()
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        frmAddCustomer.ShowDialog()
    End Sub

    Private Sub lblDebt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDebt.TextChanged
        If lblDebt.Text <= 0 Then
            lblDebt.ForeColor = Color.Green
        Else
            lblDebt.ForeColor = Color.DarkRed
        End If
    End Sub

    Private Sub btnCustomerGroup_Click(sender As System.Object, e As System.EventArgs) Handles btnCustomerGroup.Click
        frmCustomerGroupManagement.ShowDialog()
    End Sub

    Private Sub btnExport_Click(sender As System.Object, e As System.EventArgs) Handles btnExport.Click
        If (Not System.IO.Directory.Exists(".\CustomerExport")) Then
            System.IO.Directory.CreateDirectory(".\CustomerExport")
        End If

        CustomerGV.Columns(3).Visible = True 'cust_address
        CustomerGV.Columns(4).Visible = True 'cust_email
        CustomerGV.Columns(5).Visible = True 'cust_facebook
        CustomerGV.Columns(7).Visible = True 'cust_date_added
        CustomerGV.Columns(9).Visible = True 'cust_points
        CustomerGV.Columns(10).Visible = True 'cust_note

        CustomerDGV.ExportToXls(".\CustomerExport\" & DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") & "_Customer.xls")

        CustomerGV.Columns(3).Visible = False 'cust_address
        CustomerGV.Columns(4).Visible = False 'cust_email
        CustomerGV.Columns(5).Visible = False 'cust_facebook
        CustomerGV.Columns(7).Visible = False 'cust_date_added
        CustomerGV.Columns(9).Visible = False 'cust_points
        CustomerGV.Columns(10).Visible = False 'cust_note
        XtraMessageBox.Show("The data has been successfully exported!" & vbNewLine & "You can find your file at : " & Application.StartupPath & "\CustomerExport\" & DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") & "_Customer.xls", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class