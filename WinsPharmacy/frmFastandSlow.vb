Public Class frmFastandSlow
    Public Sub FillFast()
        Dim dt As DataTable = ExecuteQuery("select top(20) ProductName,Category,Sales from tblSavedInventory where Date between '" & dtpStart.Value.Date & "'  and '" & dtpEnd.Value.Date & "' and Sales > 0  order by Sales DESC")
        FillListView(dt, lvFast)
    End Sub
    Public Sub FillSlow()
        Dim dt As DataTable = ExecuteQuery("select top(20) ProductName,Category,Sales from tblSavedInventory where Date between '" & dtpStart.Value.Date & "'  and '" & dtpEnd.Value.Date & "' and Sales > 0  order by Sales")
        FillListView(dt, lvSlow)
    End Sub
    Private Sub frmFastandSlow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillSlow()
        FillFast()
    End Sub

    Private Sub dtpStart_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStart.ValueChanged
        FillFast()
        FillSlow()
    End Sub

    Private Sub dtpEnd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEnd.ValueChanged
        FillFast()
        FillSlow()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim dt As DataTable = ExecuteQuery("select top(20) ProductName,Category,Sales from tblSavedInventory where Date between '" & dtpStart.Value.Date & "'  and '" & dtpEnd.Value.Date & "' and Sales > 0  order by Sales")
        Dim frm As New frmViewReports("Slow", dt)
        frm.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt As DataTable = ExecuteQuery("select top(20) ProductName,Category,Sales from tblSavedInventory where Date between '" & dtpStart.Value.Date & "'  and '" & dtpEnd.Value.Date & "' and Sales > 0  order by Sales DESC")
        Dim frm As New frmViewReports("Fast", dt)
        frm.Show()
    End Sub
End Class