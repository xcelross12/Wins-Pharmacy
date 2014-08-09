Public Class frmProductPricing
    Public Sub reset()
        txtCode.Clear()
        txtUnitPrice.Clear()
        txtPercentage.Clear()
        txtSellingPrice.Clear()
        lblCategory.Text = "Type of product"
        lblName.Text = "Name of the product"
        lblSupplier.Text = "Name of the supplier"
        lblReorder.Text = "Critical or Reorder level"
    End Sub
    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        If txtCode.Text = "" Or txtPercentage.Text = "" Then
            MessageBox.Show("Please complete all information.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MsgBox("Do you really want to save the changes?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Update") = MsgBoxResult.Yes Then
                'ExecuteSQLQuery("update tblProducts set UnitPrice=" & Val(txtUnitPrice.Text) & " where ProductCode='" & txtCode.Text & "'")
                ExecuteSQLQuery("update tblPriceProfit set Profit=" & Val(txtPercentage.Text * 0.01) & " where ProductCode='" & txtCode.Text & "'")
                MsgBox("Changes were successfully saved.", MsgBoxStyle.Information)
                setupProductPrice()

                Reset()
                frmProducts.refreshList()
                frmProducts.reset()
            End If
            frmProducts.refreshList()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub txtPercentage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPercentage.TextChanged
        If checkProductExistence(txtCode.Text) Then
            If txtPercentage.Text <> "" Then
                If txtPercentage.Focused Then
                    Dim converted As Double = 0.0
                    Dim capital As Double = Val(txtUnitPrice.Text)
                    Dim profit As Double = (capital * (Val(txtPercentage.Text * 0.01)))
                    converted = capital + profit
                    txtSellingPrice.Text = Format(converted, "####.00")
                End If
            Else
                txtSellingPrice.Clear()
            End If
        End If
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        frmProductPricingView.ShowDialog()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If productForPricing <> "" Then
            txtCode.Text = productForPricing
            productForPricing = ""
        End If
    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged
       If checkExistence("select * from tblProducts where ProductCode='" & txtCode.Text & "'") Then
            Dim dt As DataTable = ExecuteSQLQuery("select * from tblProducts where ProductCode='" & txtCode.Text & "'")
            If dt.Rows.Count = 1 Then
                lblName.Text = dt.Rows(0)("ProductName").ToString
                lblCategory.Text = dt.Rows(0)("Category").ToString
                lblSupplier.Text = dt.Rows(0)("Supplier").ToString
                lblReorder.Text = dt.Rows(0)("ReorderLevel").ToString
                txtUnitPrice.Text = getSupplierPricePreferred(txtCode.Text)
                txtPercentage.Text = putSingleNumber("select Profit from tblPriceProfit where ProductCode='" & txtCode.Text & "'")
                txtPercentage.Text = Val(txtPercentage.Text * 100)
                Dim converted As Double = 0.0
                Dim capital As Double = Val(txtUnitPrice.Text)
                Dim profit As Double = (capital * (Val(txtPercentage.Text) * 0.01))
                converted = capital + profit
                txtSellingPrice.Text = Format(converted, "####.00")

            End If
        End If
    End Sub

    Private Sub txtPercentage_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPercentage.KeyPress
        AcceptNumbersPeriodKeyPressControlled(e, txtPercentage)
    End Sub

    Private Sub txtSellingPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSellingPrice.KeyPress
        AcceptNumbersPeriodKeyPressControlled(e, txtSellingPrice)
    End Sub
End Class