Public Class frmCritical
    Dim sql As String = ""
    Dim blinkSign As Integer = 0

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If blinkSign = 3 Then
            lblWarning.Visible = False
            blinkSign = 0
        Else
            lblWarning.Visible = True
            blinkSign += 1
        End If
    End Sub
    Public Sub loadCritical()
        sql = "select a.ProductCode, a.ProductName, a.Category, a.EndInv, b.ReorderLevel from tblRunningInventory as a, tblProducts as b where (a.ProductCode=b.ProductCode) and (a.EndInv <= b.ReorderLevel)"
        FillListView(ExecuteSQLQuery(sql), lvCritical)
    End Sub

    Private Sub frmCritical_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadCritical()
    End Sub

    Private Sub btnPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchase.Click
        Dim codesList As New ArrayList
        Dim qtyList As New ArrayList
        For i As Integer = 0 To lvCritical.CheckedItems.Count - 1
            codesList.Add(lvCritical.CheckedItems(i).Text)
            Dim qty As Double = Val(lvCritical.CheckedItems(i).SubItems(4).Text) - Val(lvCritical.CheckedItems(i).SubItems(3).Text) + 1
            qtyList.Add(qty)
        Next
        Dim frm As New frmPurchaseOrder(codesList, qtyList)
        frm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            For i As Integer = 0 To lvCritical.Items.Count - 1
                lvCritical.Items(i).Checked = True
            Next
        Else
            For i As Integer = 0 To lvCritical.Items.Count - 1
                lvCritical.Items(i).Checked = False
            Next
        End If
    End Sub

    Private Sub frmCritical_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        CheckBox1.Checked = False
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class