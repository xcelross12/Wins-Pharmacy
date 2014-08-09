Public Class frmUsersLog
    Dim DT As New DataTable
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frm As New frmViewReports("UsersLog", ExecuteSQLQuery("select * from tblUsersLog"))
        frm.Show()
    End Sub

    Private Sub frmUsersLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DT = ExecuteSQLQuery("SELECT * FROM tblUsersLog")
        For i As Integer = 0 To DT.Rows.Count - 1
            Dim item As New ListViewItem(DT.Rows(i)("LogID").ToString)
            item.SubItems.Add(DT.Rows(i)("UserID").ToString)
            item.SubItems.Add(DT.Rows(i)("FullName").ToString)
            item.SubItems.Add(DT.Rows(i)("UserType").ToString)
            item.SubItems.Add(DT.Rows(i)("LogDate").ToString)
            item.SubItems.Add(DT.Rows(i)("Login").ToString)
            item.SubItems.Add(DT.Rows(i)("Logout").ToString)
            lvUsersLog.Items.Add(item)
        Next
    End Sub
End Class