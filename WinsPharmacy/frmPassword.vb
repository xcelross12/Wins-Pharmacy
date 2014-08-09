Public Class frmPassword

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If checkExistence("select * from tblUsers where UserID=0001 and Password='" & MD5(txtPassword.Text) & "' ") Then
            MessageBox.Show("Password Authenticated!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Me.Dispose()
            frmVat.ShowDialog()
        Else
            MessageBox.Show("Incorrect Password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            txtPassword.Focus()
            txtPassword.SelectAll()
        End If

    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        AcceptAlphaNumericKeyPress(e)

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If checkExistence("select * from tblUsers where UserID=0001 and Password='" & MD5(txtPassword.Text) & "' ") Then
                MessageBox.Show("Password Authenticated!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.Dispose()
                frmVat.ShowDialog()
            Else
                MessageBox.Show("Incorrect Password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                txtPassword.Focus()
                txtPassword.SelectAll()
            End If
        End If
    End Sub
End Class