Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils

Public Class frmSupplierManagement
    Inherits DevExpress.XtraEditors.XtraForm

    'drawing row number
    Private Sub SupplierGV_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles SupplierGV.CustomDrawRowIndicator
        If e.Info.IsRowIndicator Then
            e.Info.DisplayText = e.RowHandle.ToString() + 1
        End If
    End Sub

    Public Sub fillSupplierGV()
        SupplierDGV.DataSource = Nothing

        Try
            Dim da As New OleDbDataAdapter("SELECT tblSupplier.supp_id, tblSupplier.supp_name, tblSupplier.supp_contact, tblSupplier.supp_address, tblSupplier.supp_email, tblSupplier.supp_facebook, tblSupplier.supp_date_added, tblSupplier.supp_debt, tblSupplier.supp_note" _
                                           & " FROM tblSupplier", openConn())

            Dim dt As New DataTable

            da.Fill(dt)

            SupplierDGV.DataSource = dt

            For i = 0 To 8
                SupplierGV.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Next

            SupplierGV.Columns(0).Visible = False 'cust_id

            SupplierGV.Columns(1).Caption = "Supplier Name"

            SupplierGV.Columns(2).Caption = "Contact"
            SupplierGV.Columns(2).Width = 25

            SupplierGV.Columns(3).Visible = False 'cust_address
            SupplierGV.Columns(4).Visible = False 'cust_email
            SupplierGV.Columns(5).Visible = False 'cust_facebook

            SupplierGV.Columns(6).Visible = False 'cust_date_added

            SupplierGV.Columns(7).Caption = "Debt"
            SupplierGV.Columns(7).Width = 30
            SupplierGV.Columns(7).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            SupplierGV.Columns(7).DisplayFormat.FormatString = "c2"

            SupplierGV.Columns(8).Visible = False 'cust_note
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SupplierGV.IndicatorWidth = 35

        'calculate total debt
        Dim CalDebtFromDB As New OleDbCommand("SELECT SUM(supp_debt) AS Supplier_Deb FROM tblSupplier", conn)

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

    Public Sub fillSearchSupplierGV()
        SupplierSearchDGV.DataSource = Nothing

        Try
            Dim da As New OleDbDataAdapter("SELECT tblSupplier.supp_id, tblSupplier.supp_name FROM tblSupplier", openConn())

            Dim dt As New DataTable

            da.Fill(dt)

            SupplierSearchDGV.DataSource = dt

            SupplierSearchGV.Columns(0).Visible = False 'supp_id

            SupplierSearchGV.Columns(1).Caption = "Supplier Name"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SupplierGV_CustomDrawEmptyForeground(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs) Handles SupplierGV.CustomDrawEmptyForeground, SupplierSearchGV.CustomDrawEmptyForeground
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender

        If (view.RowCount <> 0) Then Return

        Dim drawFormat As New StringFormat

        drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center
        e.Graphics.DrawString("No data exists here!", e.Appearance.Font, Brushes.DarkRed, New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat)
    End Sub

    Private Sub ToolTipController_GetActiveObjectInfo(ByVal sender As Object, ByVal e As DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs) Handles ToolTipController.GetActiveObjectInfo
        If Not e.SelectedControl Is SupplierDGV Then Return

        Dim hitInfo As GridHitInfo = SupplierGV.CalcHitInfo(e.ControlMousePosition)

        If hitInfo.InRow = False Then Return

        Dim toolTipArgs As SuperToolTipSetupArgs = New SuperToolTipSetupArgs

        Dim drCurrentRow As DataRow = SupplierGV.GetDataRow(hitInfo.RowHandle)
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

        If drCurrentRow(6).ToString.Length > 0 Then
            ContentText = ContentText + vbNewLine + "<b><u>Date Added</u></b>" & vbNewLine & drCurrentRow(6).ToString
        End If

        If drCurrentRow(8).ToString.Length > 0 Then
            ContentText = ContentText + vbNewLine + "<b><u>Note</u></b>" & vbNewLine & drCurrentRow(8).ToString
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

    Private Sub frmSupplierManagement_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fillSupplierGV()
        fillSearchSupplierGV()
    End Sub

    Dim HideZeroDebtState As Integer = 0 '0 = no click ; 1 = click
    Private Sub btnHideZeroDebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideZeroDebt.Click
        If HideZeroDebtState = 0 Then
            HideZeroDebtState = 1
            SupplierGV.ActiveFilter.NonColumnFilter = "[supp_debt] > 0"
            btnHideZeroDebt.Text = "&Show All"
        Else
            HideZeroDebtState = 0
            SupplierGV.ClearColumnsFilter()
            btnHideZeroDebt.Text = "&Hide Zero Debt"
        End If
    End Sub

    Private Sub PopupContainerSupplier_ButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PopupContainerSupplier.ButtonClick
        PopupContainerSupplier.ShowPopup()
        SupplierSearchGV.ClearColumnsFilter()
        PopupContainerSupplier.Focus()
    End Sub

    Private Sub PopupContainerSupplier_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PopupContainerSupplier.Click
        PopupContainerSupplier.SelectAll()
    End Sub

    Private Sub PopupContainerSupplier_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopupContainerSupplier.EditValueChanged
        PopupContainerSupplier.ShowPopup()
        SupplierSearchGV.ActiveFilter.NonColumnFilter = "[supp_name] LIKE '%" & PopupContainerSupplier.Text & "%'"
        PopupContainerSupplier.Focus()

        If PopupContainerSupplier.Text.Length = 0 Then
            SupplierSearchGV.ClearColumnsFilter()
            SupplierGV.ClearColumnsFilter()
        End If
    End Sub

    Private Sub SupplierSearchGV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles SupplierSearchGV.DoubleClick
        If SupplierSearchGV.SelectedRowsCount = 0 Then
            XtraMessageBox.Show("Please select a record to perform this action!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            PopupContainerSupplier.Text = SupplierSearchGV.GetRowCellValue(SupplierSearchGV.FocusedRowHandle, "supp_name")
            SupplierGV.ActiveFilter.NonColumnFilter = "[supp_name] = '" & SupplierSearchGV.GetRowCellValue(SupplierSearchGV.FocusedRowHandle, "supp_name") & "'"
            PopupContainerSupplier.ClosePopup()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If PopupContainerSupplier.Text.Length > 0 Then
            SupplierGV.ActiveFilter.NonColumnFilter = "[supp_name] LIKE '%" & PopupContainerSupplier.Text & "%'"
        Else
            SupplierGV.ClearColumnsFilter()
            SupplierSearchGV.ClearColumnsFilter()
        End If
    End Sub

    Private Sub chkSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        If chkSelectAll.Checked = True Then
            SupplierGV.SelectAll()
        Else
            SupplierGV.ClearSelection()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If SupplierGV.SelectedRowsCount > 0 Then 'confirm yes no
            Dim dialogResult = XtraMessageBox.Show("Are you sure you want to delete the selected data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If dialogResult = Windows.Forms.DialogResult.Yes Then
                Dim Rows As New ArrayList()
                ' Add the selected rows to the list.
                Dim I As Integer
                For I = 0 To SupplierGV.SelectedRowsCount() - 1
                    If (SupplierGV.GetSelectedRows()(I) >= 0) Then
                        Rows.Add(SupplierGV.GetDataRow(SupplierGV.GetSelectedRows()(I)))
                    End If
                Next

                For I = 0 To Rows.Count - 1
                    Dim Row As DataRow = CType(Rows(I), DataRow)

                    Dim deleteSupplier As New OleDbCommand("DELETE FROM tblSupplier WHERE supp_id = ?", conn)
                    deleteSupplier.Parameters.AddWithValue("supp_id", Row("supp_id"))

                    Try
                        conn.Open()
                        deleteSupplier.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        conn.Close()
                        deleteSupplier.Parameters.Clear()
                    End Try
                Next
                XtraMessageBox.Show("The selected data has been deleted", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                'finally remove the rows from grid control, so that no repopulation is needed
                SupplierGV.DeleteSelectedRows()

                'refresh
                fillSupplierGV()
            End If
        Else
            XtraMessageBox.Show("Please select a record to perform this action!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If SupplierGV.SelectedRowsCount > 1 Then
            XtraMessageBox.Show("You may only select one row of data!", "More than one data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf SupplierGV.SelectedRowsCount = 0 Then
            XtraMessageBox.Show("Please select a record to perform this action!", "No data selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            frmEditSupplier.CurrentSuppID = SupplierGV.GetRowCellValue(SupplierGV.FocusedRowHandle, "supp_id").ToString
            frmEditSupplier.txtSupplierName.Text = SupplierGV.GetRowCellValue(SupplierGV.FocusedRowHandle, "supp_name").ToString
            frmEditSupplier.txtContact.Text = SupplierGV.GetRowCellValue(SupplierGV.FocusedRowHandle, "supp_contact").ToString
            frmEditSupplier.txtAddress.Text = SupplierGV.GetRowCellValue(SupplierGV.FocusedRowHandle, "supp_address").ToString
            frmEditSupplier.txtEmail.Text = SupplierGV.GetRowCellValue(SupplierGV.FocusedRowHandle, "supp_email").ToString
            frmEditSupplier.txtFacebook.Text = SupplierGV.GetRowCellValue(SupplierGV.FocusedRowHandle, "supp_facebook").ToString
            frmEditSupplier.DateTimePicker.Text = SupplierGV.GetRowCellValue(SupplierGV.FocusedRowHandle, "supp_date_added").ToString
            frmEditSupplier.txtDebt.Text = SupplierGV.GetRowCellValue(SupplierGV.FocusedRowHandle, "supp_debt").ToString
            frmEditSupplier.txtOldDebt.Text = SupplierGV.GetRowCellValue(SupplierGV.FocusedRowHandle, "supp_debt").ToString 'should calculate total debt instead
            frmEditSupplier.txtNote.Text = SupplierGV.GetRowCellValue(SupplierGV.FocusedRowHandle, "supp_note").ToString
            frmEditSupplier.ShowDialog()
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        frmAddSupplier.ShowDialog()
    End Sub

    Private Sub lblDebt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDebt.TextChanged
        If lblDebt.Text <= 0 Then
            lblDebt.ForeColor = Color.Green
        Else
            lblDebt.ForeColor = Color.DarkRed
        End If
    End Sub

    Private Sub btnExport_Click(sender As System.Object, e As System.EventArgs) Handles btnExport.Click
        SupplierDGV.ExportToXls("" & DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") & "_Supplier.xls")
        XtraMessageBox.Show("The data has been successfully exported!" & vbNewLine & "You can find your file at : " & Application.StartupPath & "\" & DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") & "_Supplier", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class