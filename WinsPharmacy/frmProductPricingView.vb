Public Class frmProductPricingView
    Dim sql As String = "select ProductCode, ProductName from tblProducts"
    Private Sub btnChoose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoose.Click
        If lvProducts.SelectedItems.Count = 1 Then
            productForPricing = lvProducts.SelectedItems(0).Text
            productForSupplier = lvProducts.SelectedItems(0).Text
            Me.Close()
        End If
    End Sub
    Public Sub reload()
        Dim dt As DataTable = ExecuteSQLQuery(sql)
        lvProducts.Items.Clear()
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim item As New ListViewItem
            item.Text = dt.Rows(i)(0).ToString
            item.SubItems.Add(dt.Rows(i)(1).ToString)
            lvProducts.Items.Add(item)
        Next
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmProductPricingView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reload()
    End Sub

    Private Sub txtItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItem.TextChanged
        If txtItem.Text <> "" Then
            sql = "select ProductCode, ProductName from tblProducts where ProductName like '" & txtItem.Text & "%'"
        Else
            sql = "select ProductCode, ProductName from tblProducts"
        End If
        reload()
    End Sub

    Private Sub lvProducts_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvProducts.DoubleClick
        productForPricing = lvProducts.SelectedItems(0).Text
        productForSupplier = lvProducts.SelectedItems(0).Text
        Me.Close()
    End Sub
End Class