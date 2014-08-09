Public Class frmProductsView
    Dim sql As String = "select tblrunninginventory.ProductCode, tblrunninginventory.ProductName,tblrunninginventory.BegInv,tblrunninginventory.EndInv, tblProducts.Description,tblProducts.ExpirationDate from tblRunningInventory INNER JOIN tblProducts ON tblRunningInventory.ProductCode = tblProducts.ProductCode"
    Private Sub frmProductsView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reload()
    End Sub
    Public Sub reload()
        Dim dt As DataTable = ExecuteSQLQuery(sql)
        lvProducts.Items.Clear()
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim item As New ListViewItem
            item.Text = dt.Rows(i)(0).ToString
            item.SubItems.Add(dt.Rows(i)(1).ToString)
            item.SubItems.Add(dt.Rows(i)(4).ToString)
            item.SubItems.Add(dt.Rows(i)(5).ToString)
            lvProducts.Items.Add(item)
        Next
    End Sub
    Private Sub txtItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItem.TextChanged
        If txtItem.Text <> "" Then
            sql = "select tblrunninginventory.ProductCode, tblrunninginventory.ProductName,tblrunninginventory.BegInv,tblrunninginventory.EndInv, tblProducts.Description,tblProducts.ExpirationDate from tblRunningInventory INNER JOIN tblProducts ON tblRunningInventory.ProductCode = tblProducts.ProductCode where tblrunninginventory.ProductName like '" & txtItem.Text & "%'"
        Else
            sql = "select tblrunninginventory.ProductCode, tblrunninginventory.ProductName,tblrunninginventory.BegInv,tblrunninginventory.EndInv, tblProducts.Description,tblProducts.ExpirationDate from tblRunningInventory INNER JOIN tblProducts ON tblRunningInventory.ProductCode = tblProducts.ProductCode"
        End If
        reload()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnChoose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoose.Click
        If lvProducts.SelectedItems.Count = 1 Then
            setChoice()
            Me.Close()
        Else
            MsgBox("Please select a product.")
        End If
    End Sub

    Private Sub lvProducts_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvProducts.DoubleClick
        setChoice()
        Me.Close()
    End Sub
    Public Sub setChoice()

        selectedProduct = lvProducts.SelectedItems(0).Text

        productForSales = lvProducts.SelectedItems(0).Text

        productForStackView = lvProducts.SelectedItems(0).Text

    End Sub

    Private Sub lvProducts_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvProducts.KeyDown
        If e.KeyCode = Keys.Enter Then
            If lvProducts.SelectedItems.Count = 1 Then
                setChoice()
                Me.Close()
            Else
                MsgBox("Please select a product.")
            End If
        End If
    End Sub
End Class