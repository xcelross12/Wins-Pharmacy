Public Class frmSupplierPO

    Private Sub frmSupplierPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If cbSupplier.Text <> "" Then
            Dim frm As New frmViewReports("PurchaseOrder", ExecuteSQLQuery("select * from tblPurchases where PurchaseID='" & txtPurchaseID.Text & "' and Supplier='" & cbSupplier.Text & "' order by Supplier"))
            frm.Show()
        End If
    End Sub
    Public Sub New(ByVal purID As String)
        InitializeComponent()
        txtPurchaseID.Text = purID
    End Sub

    Private Sub txtPurchaseID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPurchaseID.TextChanged
        If checkExistence("select * from tblPurchases where PurchaseID='" & txtPurchaseID.Text & "'") Then
            fillItems2("select distinct Supplier from tblPurchases where PurchaseID='" & txtPurchaseID.Text & "' and Confirmed='NO'", cbSupplier)
        Else
            MsgBox("No record for this Purchase ID.", MsgBoxStyle.Exclamation)
            cbSupplier.Items.Clear()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If purchaseIDForPrintingPO <> "" Then
            txtPurchaseID.Text = purchaseIDForPrintingPO
            purchaseIDForPrintingPO = ""
        End If
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        frmPurchaseIDView.ShowDialog()
    End Sub

    Private Sub lblID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblID.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class