Public Class frmVat
    Dim dis

    Private Sub txtVat_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVat.KeyPress, txtVatRate.KeyPress
        AcceptNumbersPeriodKeyPressControlled(e, txtVat)
    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        AcceptNumbersPeriodKeyPressControlled(e, txtDiscount)
    End Sub

    Private Sub frmVat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable = ExecuteSQLQuery("select * from tblDiscountVAt")
        txtDiscount.Text = dt.Rows(0)(1).ToString.Replace("2.", ".") * 100
        txtVat.Text = dt.Rows(0)(2).ToString.Replace("1.", "")
        btnEditDiscount.Show()
        btnEditVat.Show()
    End Sub

    Private Sub btnEditVat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditVat.Click
        If btnEditVat.Text = "Edit" Then
            btnEditVat.Text = "Save"
            txtVat.Enabled = True
            txtVat.SelectAll()
        ElseIf btnEditVat.Text = "Save" Then
            If txtVat.Text.Count = "2" Then
                dis = "0." + txtVat.Text
            Else
                dis = "0.0" + txtVat.Text
            End If
            sql = "UPDATE tblDiscountVAt SET Vat='" & "1." + txtVat.Text & "' WHERE id=1"
            ExecuteSQLQuery(sql)
            txtVat.Enabled = False
            btnEditVat.Text = "Edit"
            MsgBox("Settings Updated!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnEditDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditDiscount.Click
        If btnEditDiscount.Text = "Edit" Then
            btnEditDiscount.Text = "Save"
            txtDiscount.Enabled = True
            txtVat.SelectAll()
        ElseIf btnEditDiscount.Text = "Save" Then
            If txtDiscount.Text.Count = "2" Then
                dis = "0." + txtDiscount.Text
            Else
                dis = "0.0" + txtDiscount.Text
            End If
            sql = "UPDATE tblDiscountVAt SET Discount= '" & dis & "' WHERE id=1"
            ExecuteSQLQuery(sql)
            txtDiscount.Enabled = False
            btnEditDiscount.Text = "Edit"
            MsgBox("Settings Updated!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub frmVat_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        btnEditDiscount.Text = "Edit"
        btnEditVat.Text = "Edit"
    End Sub
End Class