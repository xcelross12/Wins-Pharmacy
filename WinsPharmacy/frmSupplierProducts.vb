Public Class frmSupplierProducts
    Public supplier As String = ""
    Public Sub fillTree()
        tvProducts.Nodes.Clear()
        Dim dt As DataTable = ExecuteSQLQuery("select distinct Category from tblProducts where Supplier='" & supplier & "' order by Category")

        If dt.Rows.Count = 0 Then
            MsgBox("There is no product supplied by this Supplier.", MsgBoxStyle.Exclamation)
            Me.Close()
        End If

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim node As New TreeNode
            Dim cat As String = dt.Rows(i)(0).ToString
            node.Text = cat
            Dim dt2 As DataTable = ExecuteSQLQuery("select ProductCode, ProductName from tblProducts where Category='" & cat & "' and Supplier='" & supplier & "' order by ProductName")

            For j As Integer = 0 To dt2.Rows.Count - 1
                Dim pCode As String = dt2.Rows(j)(0).ToString
                Dim suppID As String = putSingleValue("select SupplierID from tblSuppliers where SupplierName='" & supplier & "'")
                node.Nodes.Add(dt2.Rows(j)(1).ToString & "  @ " & Format(getSupplierPrice(pCode, suppID), "####.00"))
            Next
            tvProducts.Nodes.Add(node)
        Next
    End Sub
    Private Sub frmSupplierProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillTree()
    End Sub
End Class