Public Class frmMain
    Public critList As New ArrayList
    Public ExpireList As New ArrayList
    Dim count As Integer = 0
    Dim blinkSign As Integer = 0
    Private Sub btnCashier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCashier.Click
        frmPOS.ShowDialog()
    End Sub

    Private Sub btnPurchases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchases.Click
        frmPurchaseOrder.ShowDialog()
    End Sub

    Private Sub btnSuppliers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuppliers.Click
        frmSupplier.ShowDialog()
    End Sub

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        frmInventory.ShowDialog()
    End Sub

    Private Sub btnReturns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturns.Click
        frmSalesReturn.ShowDialog()
    End Sub

    Private Sub btnProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProducts.Click
        frmProducts.ShowDialog()
    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        frmReportsTab.ShowDialog()
    End Sub

    Private Sub btnUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsers.Click
        frmUsers.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmPurchaseConfirmation.ShowDialog()
    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        logoutUser()
    End Sub
    Public Sub logoutUser()
        If MsgBox("Do you really want to log-out of the system?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Logout Confirmation") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub frmMain_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MsgBox("You have successfully logged-out from the system.", MsgBoxStyle.Information, "System Logout")
        Dim sql As String = "update tblUsersLog set Logout='" & FormatDateTime(Now, DateFormat.LongTime) & "' where UserID='" & lblUserID.Text & "' and Logout='in'"
        ExecuteSQLQuery(sql)
        Dim user = putSingleValue("select Username from tblUsers where FullName='" & lblFullname.Text & "' ")
        sql = "Delete from tblCurrentlyLoginUser where Username='" & user & "'"
        ExecuteSQLQuery(sql)
        frmLogIn.Show()
        frmLogIn.txtUsername.Clear()
        frmLogIn.txtPassword.Clear()
        frmLogIn.txtUsername.Focus()
    End Sub

    Private Sub tmrTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTime.Tick
        lblTime.Text = FormatDateTime(Now, DateFormat.LongTime)
        lblDateToday.Text = FormatDateTime(Today, DateFormat.LongDate)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If blinkSign = 3 Then
            tssExpire.Visible = False
            blinkSign = 0
        Else
            tssExpire.Visible = True
            blinkSign += 1
        End If
    End Sub
    
    Private Sub tmrCritical_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCritical.Tick
        checkCritical()
        If critList.Count <> 0 Then
            tssCL.Visible = False
            tmrDisplayWarning.Enabled = True
            tssCL.Visible = True
        Else
            tmrDisplayWarning.Enabled = False
            tssCL.Visible = False
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        adjustInventory()
        checkCritical()
        checkExpire()
        If critList.Count <> 0 Then
            MsgBox("Warning!" & vbCrLf & vbCrLf & "There are products that reached their critical limit.", MsgBoxStyle.Critical, "System Alert")
            frmCritical.ShowDialog()
        ElseIf ExpireList.Count <> 0 Then
            MsgBox("Warning!" & vbCrLf & vbCrLf & "There are products that are near to expire.", MsgBoxStyle.Critical, "System Alert")
            frmExpire.ShowDialog()
        End If
    End Sub

    Private Sub tmrDisplayWarning_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDisplayWarning.Tick
        If count = 1 Then
            tssCL.Visible = False
            tssExpire.Visible = False
            count = -1
        Else
            tssCL.Visible = True
            tssExpire.Visible = True
            count += 1
        End If
    End Sub
    Public Sub checkCritical()
        critList.Clear()
        Dim dt As DataTable = ExecuteSQLQuery("select * from tblRunningInventory")
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim reorderLevel As Double = putSingleNumber("select ReorderLevel from tblProducts where ProductCode='" & dt.Rows(i)("ProductCode").ToString & "'")
            If Val(dt.Rows(i)("EndInv").ToString) <= reorderLevel Then
                critList.Add(dt.Rows(i)("ProductCode").ToString)
            End If
        Next
    End Sub
    Public Sub checkExpire()
        ExpireList.Clear()
        Dim dt As DataTable = ExecuteQuery("Select * from tblProducts where ExpirationDate between '" & Today & "' and '" & Today.AddDays(30) & "'")
        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows.Count <> 0 Then
                ExpireList.Add(dt.Rows(i)("ProductCode").ToString)
            End If
        Next
    End Sub
    Private Sub btnDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiscount.Click
        frmPassword.ShowDialog()
    End Sub

    Private Sub tmrExpire_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrExpire.Tick
        checkExpire()
        If ExpireList.Count <> 0 Then
            tssExpire.Visible = False
            tmrDisplayWarning.Enabled = True
            tssExpire.Visible = True
        Else
            tmrDisplayWarning.Enabled = False
            tssExpire.Visible = False
        End If
    End Sub

    Private Sub tssCL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssCL.Click
        frmCritical.ShowDialog()
    End Sub

    Private Sub tssExpire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssExpire.Click
        frmExpire.ShowDialog()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        If blinkSign = 3 Then
            tssCL.Visible = False
            blinkSign = 0
        Else
            tssCL.Visible = True
            blinkSign += 1
        End If
    End Sub
End Class