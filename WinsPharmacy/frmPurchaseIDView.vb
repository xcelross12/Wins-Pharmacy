Public Class frmPurchaseIDView

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If lvPurchases.SelectedItems.Count = 1 Then
            purchaseIDForConfirmation = lvPurchases.SelectedItems(0).Text
            Me.Close()
        Else
            MessageBox.Show("Please select an item to confirm.")
        End If
    End Sub

    Private Sub frmPurchaseIDView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = "select PurchaseID,ProductName, Subtotal, OrderDate, DeliveryDate from tblPurchases where Confirmed='NO' group by PurchaseID,ProductName, Subtotal, OrderDate, DeliveryDate"
        FillListView(ExecuteSQLQuery(sql), lvPurchases)
    End Sub

    Private Sub lvPurchases_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvPurchases.DoubleClick
        If lvPurchases.SelectedItems.Count = 1 Then
            purchaseIDForConfirmation = lvPurchases.SelectedItems(0).Text
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class