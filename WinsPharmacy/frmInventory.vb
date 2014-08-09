Public Class frmInventory
    Dim currDT As New DataTable
    Dim table As String = "tblRunningInventory"
    Private Sub frmInventory_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
        If dtpDate.Value.Date = Today Then
            saveInventory()
        End If
    End Sub
    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        updateInventory()
        tmrUpdateMonitoring.Enabled = True
        dtpDate.Text = Today
        sql = "select * from " & table & " where Date='" & Date.Now.Date & "'"
        currDT = ExecuteSQLQuery(sql)
        FillListView(currDT, lvInventory)
    End Sub
    Public Sub loadInventory(ByVal byDate As Date, ByVal cat As String)
        If cat = "ProductCode" Then
            updateInventory()
            sql = "select * from " & table & " where Date='" & byDate & "'"
            currDT = ExecuteSQLQuery(sql)
            FillListView(currDT, lvInventory)
        ElseIf cat = "ProductName" Then
            updateInventory()
            sql = "select * from " & table & " where Date='" & byDate & "'"
            currDT = ExecuteSQLQuery(sql)
            FillListView(currDT, lvInventory)
        ElseIf cat = "Category" Then
            updateInventory()
            sql = "select * from " & table & " where Date='" & byDate & "'"
            currDT = ExecuteSQLQuery(sql)
            FillListView(currDT, lvInventory)
        ElseIf cat = "Supplier" Then
            updateInventory()
            sql = "select * from " & table & " where Date='" & byDate & "'"
            currDT = ExecuteSQLQuery(sql)
            FillListView(currDT, lvInventory)
        Else
            currDT = ExecuteSQLQuery("select * from " & table & " where Date='" & byDate & "' and Category='" & cat & "'")
            FillListView(currDT, lvInventory)
        End If
    End Sub
    Public Sub saveInventory()
        ExecuteSQLQuery("delete from tblSavedInventory where Date='" & Today & "'")
        For i As Integer = 0 To lvInventory.Items.Count - 1
            With lvInventory.Items(i)
                sql = "insert into tblSavedInventory values('" & .Text & "', '" & .SubItems(1).Text & "', '" & .SubItems(2).Text & "', '" & .SubItems(3).Text & "', '" & .SubItems(4).Text & "', '" & .SubItems(5).Text & "', '" & .SubItems(6).Text & "', '" & .SubItems(7).Text & "', '" & .SubItems(8).Text & "', '" & Today & "')"
                ExecuteSQLQuery(sql)
            End With
        Next
    End Sub
    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim frm As New frmViewReports("Inventory", currDT)
        frm.Show()
    End Sub


    Private Sub dtpDate_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpDate.ValueChanged
        If dtpDate.Value.Date = Today Then
            table = "tblRunningInventory"
        Else
            table = "tblSavedInventory"
        End If
        cbFields.SelectedItem = "ProductCode"
        loadInventory(dtpDate.Value.Date, cbFields.Text)
    End Sub

    Private Sub frmInventory_FormClosed_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If dtpDate.Value.Date = Today Then
            saveInventory()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If dtpDate.Value.Date = Date.Now.Date Then
            sql = "select * from tblRunningInventory where " & cbFields.Text & " like '" & txtSearch.Text & "%' order by ProductCode"
            currDT = ExecuteSQLQuery(sql)
            FillListView(currDT, lvInventory)
        ElseIf dtpDate.Value.Date <> Date.Now.Date Then
            sql = "select * from tblSavedInventory where " & cbFields.Text & " like '" & txtSearch.Text & "%' and date='" & dtpDate.Text + " 00:00:00.000" & "' order by ProductCode"
            currDT = ExecuteSQLQuery(sql)
            FillListView(currDT, lvInventory)
        End If

    End Sub

    Private Sub cbFields_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFields.SelectedIndexChanged
        txtSearch.Text = ""
        If dtpDate.Value.Date = Today Then
            table = "tblRunningInventory"
        Else
            table = "tblSavedInventory"
        End If
        loadInventory(dtpDate.Value.Date, cbFields.Text)
    End Sub

    Private Sub tmrUpdateMonitoring_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUpdateMonitoring.Tick
        If putSingleNumber("select UpdateCommand from tblUpdateCommand") <> 0 Then
            updateInventory()
            saveInventory()
            cbFields.SelectedItem = "ProductCode"
            loadInventory(Today, cbFields.Text)
            ExecuteSQLQuery("update tblUpdateCommand set UpdateCommand=0")
        End If
    End Sub
    Private Sub btnFastSlowMovingProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFastSlowMovingProducts.Click
        frmFastandSlow.ShowDialog()
    End Sub
End Class