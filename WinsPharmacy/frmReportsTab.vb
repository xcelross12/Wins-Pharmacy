Public Class frmReportsTab
    Private Sub btnGenGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenGeneral.Click
        If rbProducts.Checked = True Then
            If cbCategory.Text = "All" Then
                Dim frm As New frmViewReports("Products", ExecuteSQLQuery("select * from tblProducts ORDER BY ProductName"))
                frm.Show()
            Else
                Dim frm As New frmViewReports("Products", ExecuteSQLQuery("select * from tblProducts where Category ='" & cbCategory.Text & "'ORDER BY ProductName"))
                frm.Show()
            End If
        ElseIf rbSuppliers.Checked = True Then
            Dim frm As New frmViewReports("Suppliers", ExecuteSQLQuery("select * from tblSuppliers"))
            frm.Show()
        ElseIf rbUsers.Checked = True Then
            Dim frm As New frmViewReports("Users", ExecuteSQLQuery("select * from tblUsers"))
            frm.Show()
        ElseIf rbUsersLog.Checked = True Then
            If cbLogCat.Text = "All" Then
                Dim frm As New frmViewReports("UsersLog", ExecuteSQLQuery("select * from tblUsersLog where LogDate='" & dtpLogDate.Value.Date & "' and Logout<>'in'"))
                frm.Show()
            ElseIf cbLogCat.Text = "Administrator" Then
                Dim frm As New frmViewReports("UsersLog", ExecuteSQLQuery("select * from tblUsersLog where LogDate='" & dtpLogDate.Value.Date & "' and Logout<>'in' and UserType='Administrator'"))
                frm.Show()
            ElseIf cbLogCat.Text = "Cashier" Then
                Dim frm As New frmViewReports("UsersLog", ExecuteSQLQuery("select * from tblUsersLog where LogDate='" & dtpLogDate.Value.Date & "' and Logout<>'in' and UserType='Cashier'"))
                frm.Show()
            End If
        ElseIf rdbFast.Checked = True Then
            Dim dt As DataTable = ExecuteQuery("select top(20) ProductName,Category,Sales from tblSavedInventory where Date between '" & dtpStart.Value.Date & "'  and '" & dtpEnd.Value.Date & "' and Sales > 0  order by Sales DESC")
            Dim frm As New frmViewReports("Fast", dt)
            frm.Show()
        ElseIf rdbSlow.Checked = True Then
            Dim dt As DataTable = ExecuteQuery("select top(20) ProductName,Category,Sales from tblSavedInventory where Date between '" & dtpStart.Value.Date & "'  and '" & dtpEnd.Value.Date & "' and Sales > 0  order by Sales")
            Dim frm As New frmViewReports("Slow", dt)
            frm.Show()
        End If
    End Sub

    Private Sub btnGenSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenSales.Click
        Dim sql As String = "select * from tblSalesMaster where TransDate between '" & dtpStart.Value.Date & "' and '" & dtpEnd.Value.Date & "'"
        Dim frm As New frmViewReports("SalesReport", ExecuteSQLQuery(sql))
        frm.Show()
        frm.TopMost = True
    End Sub

    Private Sub btnGenInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenInventory.Click
        Dim sql As String = "select * from tblSavedInventory where Date between '" & dtpInvStart.Value.Date & "' and '" & dtpInvEnd.Value.Date & "'"
        Dim frm As New frmViewReports("Inventory", ExecuteSQLQuery(sql))
        frm.Show()
        frm.TopMost = True
    End Sub

    Private Sub btngenPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenPurchase.Click
        Dim sql As String = "select * from tblPurchases where OrderDate between '" & dtpPurStart.Value.Date & "' and '" & dtpPurEnd.Value.Date & "' and Confirmed='" & cbDelivered.Text & "'"
        Dim frm As New frmViewReports("PurchaseReport", ExecuteSQLQuery(sql))
        frm.Show()
        frm.TopMost = True
    End Sub

    Private Sub frmReportsTAb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbDelivered.SelectedIndex = 0
        fillItems2("select Category from tblCategory", cbCategory)
    End Sub

    Private Sub rbUsersLog_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbUsersLog.CheckedChanged
        If rbUsersLog.Checked = True Then
            dtpLogDate.Visible = True
            cbLogCat.Visible = True
        Else
            dtpLogDate.Visible = False
            cbLogCat.Visible = False
        End If
    End Sub

    Private Sub btnGenReturns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenReturns.Click
        Dim sql As String = "select * from tblSalesReturns where DateReturned between '" & dtpRetStart.Value.Date & "' and '" & dtpRetEnd.Value.Date & "' order by Supplier"
        Dim frm As New frmViewReports("SalesReturns", ExecuteSQLQuery(sql))
        frm.Show()
        frm.TopMost = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String = "select * from tblPriceStack where DateReceived between '" & dtpDeliveryStart.Value.Date & "' and '" & dtpDeliveryEnd.Value.AddDays(1) & "' order by DateReceived"
        Dim frm As New frmViewReports("Delivery", ExecuteSQLQuery(sql))
        frm.Show()
        frm.TopMost = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sql As String = "select * from tblSeniorDetails where TransDate between '" & dtpSeniorStart.Value.Date & "' and '" & dtpSeniorEnd.Value.Date & "'"
        Dim frm As New frmViewReports("Senior", ExecuteSQLQuery(sql))
        frm.Show()
        frm.TopMost = True
    End Sub

    Private Sub rbProducts_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbProducts.CheckedChanged
        If rbProducts.Checked = True Then
            cbCategory.Visible = True
        Else
            cbCategory.Visible = False
        End If
    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click

    End Sub

    Private Sub rdbFastSlow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbFast.CheckedChanged
        If rdbFast.Checked = True Then
            DateTimePicker1.Visible = True
            DateTimePicker2.Visible = True
            Label17.Visible = True
            Label16.Visible = True
        Else
            DateTimePicker1.Visible = False
            DateTimePicker2.Visible = False
            Label17.Visible = False
            Label16.Visible = False
        End If
    End Sub

    Private Sub rdbSlow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSlow.CheckedChanged
        If rdbSlow.Checked = True Then
            DateTimePicker1.Visible = True
            DateTimePicker2.Visible = True
            Label17.Visible = True
            Label16.Visible = True
        Else
            DateTimePicker1.Visible = False
            DateTimePicker2.Visible = False
            Label17.Visible = False
            Label16.Visible = False
        End If
    End Sub
End Class