Public Class frmViewReports
    Public Sub New(ByVal rptFile As String, ByVal dt As DataTable)
        InitializeComponent()
        Dim report As Object

        If rptFile = "Products" Then
            report = New rptProducts
            report.SetDatabaseLogon("sa", "lw9kee", "CHUA-PC\DTCSQLEXPRESS", "WinsPharmacy")
        ElseIf rptFile = "Suppliers" Then
            report = New rptSuppliers
            report.SetDatabaseLogon("sa", "lw9kee", "CHUA-PC\DTCSQLEXPRESS", "WinsPharmacy")
        ElseIf rptFile = "Users" Then
            report = New rptUsers
            report.SetDatabaseLogon("sa", "lw9kee", "CHUA-PC\DTCSQLEXPRESS", "WinsPharmacy")
        ElseIf rptFile = "SalesReceipt" Then
            report = New rptSalesReceipt
            report.SetDatabaseLogon("sa", "lw9kee", "CHUA-PC\DTCSQLEXPRESS", "WinsPharmacy")
        ElseIf rptFile = "FastSlow" Then
            report = New rptFastSlow
            report.SetDatabaseLogon("sa", "lw9kee", "CHUA-PC\DTCSQLEXPRESS", "WinsPharmacy")
        ElseIf rptFile = "Fast" Then
            report = New rptFast
            report.SetDatabaseLogon("sa", "lw9kee", "CHUA-PC\DTCSQLEXPRESS", "WinsPharmacy")
        ElseIf rptFile = "Slow" Then
            report = New rptSlow
            report.SetDatabaseLogon("sa", "lw9kee", "CHUA-PC\DTCSQLEXPRESS", "WinsPharmacy")
        ElseIf rptFile = "PurchaseOrder" Then
            report = New rptPurchaseOrder
            report.SetDatabaseLogon("sa", "lw9kee", "CHUA-PC\DTCSQLEXPRESS", "WinsPharmacy")
        ElseIf rptFile = "Inventory" Then
            report = New rptInventory
            report.SetDatabaseLogon("sa", "lw9kee", "CHUA-PC\DTCSQLEXPRESS", "WinsPharmacy")
        ElseIf rptFile = "SalesReport" Then
            report = New rptSalesReport
            report.SetDatabaseLogon("sa", "lw9kee", "CHUA-PC\DTCSQLEXPRESS", "WinsPharmacy")
        ElseIf rptFile = "Senior" Then
            report = New rptSeniorDetails
            report.SetDatabaseLogon("sa", "lw9kee", "CHUA-PC\DTCSQLEXPRESS", "WinsPharmacy")
        ElseIf rptFile = "PurchaseReport" Then
            report = New rptPurchases
            report.SetDatabaseLogon("sa", "lw9kee", "CHUA-PC\DTCSQLEXPRESS", "WinsPharmacy")
        ElseIf rptFile = "UsersLog" Then
            report = New rptUserlogs
            report.SetDatabaseLogon("sa", "lw9kee", "CHUA-PC\DTCSQLEXPRESS", "WinsPharmacy")
        ElseIf rptFile = "SalesReturns" Then
            report = New rptSalesReturn
            report.SetDatabaseLogon("sa", "lw9kee", "CHUA-PC\DTCSQLEXPRESS", "WinsPharmacy")
        ElseIf rptFile = "Delivery" Then
            report = New rptDeliverHistory
            report.SetDatabaseLogon("sa", "lw9kee", "CHUA-PC\DTCSQLEXPRESS", "WinsPharmacy")
        End If

        Try
            report.SetDataSource(dt)
            crvViewer.ReportSource = report
        Catch ex As Exception
            MsgBox("Error showing report.", MsgBoxStyle.Exclamation)
        End Try


    End Sub
End Class