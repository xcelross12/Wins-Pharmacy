Public Class frmSalesReturnsLogs
    Dim currDT As DataTable
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        sql = "select * from tblSalesReturns order by DateReturned"
        currDT = ExecuteSQLQuery(sql)
        Dim frm As New frmViewReports("SalesReturns", currDT)
        frm.Show()
    End Sub

    Private Sub frmSalesReturnsLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select * from tblSalesReturns order by DateReturned"
        currDT = ExecuteSQLQuery(sql)
        FillListView(currDT, lvUsersLog)
    End Sub
End Class