Public Class frmQTY

    Public quantity
    Public salesmasterquantity As Boolean = False

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        enterquantity()
    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        AcceptNumbersKeyPress(e)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            enterquantity()
        End If
    End Sub
    Public Sub enterquantity()
        If salesmasterquantity = True Then
            If txtQuantity.Text = "" Then
                txtQuantity.Focus()
                txtQuantity.SelectAll()
            ElseIf Val(txtQuantity.Text) = 0 Then
                frmPOS.newQty = 0
                MsgBox("Invalid Input")
                frmPOS.txtCode.Clear()
                salesmasterquantity = False
                txtQuantity.Text = ""
                Me.Close()
            Else
                frmPOS.newQty = txtQuantity.Text
                txtQuantity.Text = ""
                salesmasterquantity = False
                Me.Close()
            End If
        Else
            If Val(txtQuantity.Text) > quantity Then
                txtQuantity.Text = ""
                MsgBox("Invalid Quantity")
            Else
                frmPurchaseConfirmation.quantity = txtQuantity.Text
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub frmQTY_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class