Public Class frmPOS
    Public discount
    Public vat
    Dim subtotal As Double
    Public mode As String
    Dim totalall
    Dim change As Double
    Public newQty As Double = 1
    Public Sub getdiscount()
        Dim dt As DataTable = ExecuteSQLQuery("select * from tblDiscountVAt")
        vat = dt.Rows(0)(2).ToString
    End Sub
    Public Sub addToList()
        frmQTY.salesmasterquantity = True
        frmQTY.ShowDialog()
        If newQty <> 0 Then
            lblPrice.Text = putSingleNumber("select UnitPrice from tblProducts where ProductCode='" & txtCode.Text & "'")
            Dim endInv As Double = putSingleValue("select EndInv from tblRunningInventory where ProductCode = '" & txtCode.Text & "'")

            If newQty <= endInv Then
                Dim item As New ListViewItem
                item.Text = txtCode.Text
                With item.SubItems
                    .Add(lblItemName.Text)
                    .Add(newQty)
                    .Add(Format(Val(lblPrice.Text), "####.00"))
                    .Add(Format((Val(lblPrice.Text) * Val(newQty)), "####.00"))
                End With

                If isInTheList() Then
                    MsgBox("Item already in the list!", MsgBoxStyle.Exclamation)
                Else
                    lvItems.Items.Add(item)
                End If
            Else
                MsgBox("This product doesn't have enough stocks!", MsgBoxStyle.Exclamation)
            End If
            countTotal()
            txtCode.Text = ""
            txtCode.Focus()
            chkMulti.Checked = False
        End If
    End Sub
    Public Sub logoutUser()
        If lblType.Text = "Cashier" Then
            If MsgBox("Do you really want to log-out of the system?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Logout Confirmation") = MsgBoxResult.Yes Then
                Dim sql As String = "update tblUsersLog set Logout='" & FormatDateTime(Now, DateFormat.LongTime) & "' where UserID='" & lblUserID.Text & "' and Logout='in'"
                ExecuteSQLQuery(sql)
                Dim user = putSingleValue("select Username from tblUsers where FullName='" & lblFullname.Text & "' ")
                sql = "Delete from tblCurrentlyLoginUser where Username='" & user & "'"
                ExecuteSQLQuery(sql)
                frmLogin.Show()
                frmLogin.txtUsername.Clear()
                frmLogin.txtPassword.Clear()
                frmLogin.txtUsername.Focus()
                Me.Close()
            End If
        Else
            Me.Close()
        End If
        setupProductPrice()
    End Sub
    Public Sub countTotal()
        Dim vatable
        Dim total As Double = 0.0
        For i As Integer = 0 To lvItems.Items.Count - 1
            total += CDbl(lvItems.Items(i).SubItems(4).Text)
        Next
        totalall = total
        lblTotalAmount.Text = (Format(total, "####.00"))
        lblDiscount.Text = (Format(total * discount, "####.00"))
        lblVATable.Text = (Format(total / vat, "####.00"))
        vatable = total / vat
        lblVat.Text = (Format(total - Convert.ToDouble(vatable), "####.00"))
        lblTotalDue.Text = FormatNumber(Format(total - lblDiscount.Text, "####.00"), 2)
        subtotal = Format(total - lblDiscount.Text, "####.00")
    End Sub

    Public Function isInTheList() As Boolean
        isInTheList = False
        For i As Integer = 0 To lvItems.Items.Count - 1
            If txtCode.Text = lvItems.Items(i).Text Then
                isInTheList = True
                Exit For
            End If
        Next
    End Function
    Private Sub frmPOS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        getdiscount()
        txtCode.Focus()
        productForSales = ""
        reset()
        lblVatName.Text = "VAT" + putSingleValue("select Vat from tblDiscountVat where id = 1").Replace("1.", "") + "%"
    End Sub

    Private Sub txtCode_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCode.TextChanged
        If checkExistence("select * from tblProducts where ProductCode='" & txtCode.Text & "'") Then
            lblItemName.Text = putSingleValue("select ProductName from tblProducts where ProductCode='" & txtCode.Text & "'")
            lblPrice.Text = putSingleNumber("select UnitPrice from tblProducts where ProductCode='" & txtCode.Text & "'") & " Php"
            addToList()
        Else
            lblItemName.Text = "Item Name"
            lblPrice.Text = "Price"
        End If
    End Sub

    Private Sub txtCount_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        AcceptNumbersKeyPress(e)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            addToList()
        End If
    End Sub

    Private Sub frmPOS_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If lblType.Text.Contains("Cashier") Then
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

            setupProductPrice()
        End If
    End Sub

    Private Sub btnTransact_Click(sender As System.Object, e As System.EventArgs) Handles btnTransact.Click
        If lvItems.Items.Count = 0 Then
            MessageBox.Show("Cart is empty!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf lvItems.Items(0).SubItems(2).Text < 0 Then
            MsgBox("Invalid Quantity", MsgBoxStyle.Critical)
        Else
            If rdbSenior.Checked = True Then
                If txtCustName.Text = "" Then
                    MessageBox.Show("Please enter customer name.")
                    txtCustName.Focus()
                    txtCustName.SelectAll()
                ElseIf txtSenID.Text = "" Then
                    MessageBox.Show("Please enter Senior Citizen ID.")
                    txtSenID.Focus()
                    txtSenID.SelectAll()
                Else
                    commitSales()
                    setupProductPrice()
                    getdiscount()
                End If
            Else
                commitSales()
                setupProductPrice()
                getdiscount()
            End If
        End If

    End Sub
    Public Sub commitSales()
        Dim id As String = generateSalesID()

        Dim cash As Double = FormatNumber(Val(txtCashAmount.Text), 2)
        Dim disc As Double = Val(lblDiscount.Text)

        If rdbNonSenior.Checked = True Then
            mode = rdbNonSenior.Text
        ElseIf rdbSenior.Checked = True Then
            mode = rdbSenior.Text
        End If

        If rdbNonSenior.Checked = True Then

            sql = "insert into tblSalesMaster values('" & id & "', '" & totalall & "', '" & cash & "', '" & lblChange.Text & "', '" & FormatDateTime(Now, DateFormat.GeneralDate) & "', '" & lblUserID.Text & "', '" & lblFullname.Text & "', '" & txtCustName.Text & "', '" & lblVATable.Text & "', '" & subtotal & "', '" & lblVat.Text & "', '" & lblDiscount.Text & "','" & mode & "', '" & txtSenID.Text & "')"
            ExecuteSQLQuery(sql)

            ExecuteSQLQuery("update tblUpdateCommand set UpdateCommand = UpdateCommand +1")
            MsgBox("Transaction saved!", MsgBoxStyle.Information)
            rdbNonSenior.Checked = False
            rdbSenior.Checked = True
            For i As Integer = 0 To lvItems.Items.Count - 1
                Dim code As String = lvItems.Items(i).Text
                Dim itemName As String = lvItems.Items(i).SubItems(1).Text
                Dim qty As Double = Val(lvItems.Items(i).SubItems(2).Text)

                Dim price As Double = Val(lvItems.Items(i).SubItems(3).Text)
                Dim total As Double = Val(lvItems.Items(i).SubItems(4).Text)

                sql = "insert into tblSalesDetails values('" & id & "', '" & code & "', '" & itemName & "', '" & qty & "', '" & price & "', '" & total & "')"
                ExecuteSQLQuery(sql)
                sql = "update tblRunningInventory set Sales=Sales + " & qty & " where ProductCode = '" & code & "'"
                ExecuteSQLQuery(sql)

                decreaseStock(code, qty)

            Next
            updateInventory()
            Dim frm As New frmViewReports("SalesReceipt", ExecuteSQLQuery("select * from tblSalesMaster where SalesID='" & id & "'"))
            frm.Show()
            frm.TopMost = True
            Reset()

        Else
            sql = "insert into tblSalesMaster values('" & id & "', '" & totalall & "', '" & cash & "', '" & lblChange.Text & "', '" & FormatDateTime(Now, DateFormat.GeneralDate) & "', '" & lblUserID.Text & "', '" & lblFullname.Text & "', '" & txtCustName.Text & "', '" & lblVATable.Text & "', '" & subtotal & "', '" & lblVat.Text & "', '" & lblDiscount.Text & "','" & mode & "', '" & txtSenID.Text & "')"
            ExecuteSQLQuery(sql)
            sql = "insert into tblSeniorDetails values('" & id & "', '" & txtSenID.Text & "','" & totalall & "', '" & cash & "', '" & lblChange.Text & "', '" & FormatDateTime(Now, DateFormat.GeneralDate) & "', '" & lblUserID.Text & "', '" & lblFullname.Text & "', '" & txtCustName.Text & "', '" & lblVATable.Text & "', '" & subtotal & "', '" & lblVat.Text & "', '" & lblDiscount.Text & "')"
            ExecuteSQLQuery(sql)
            If checkExistence("select SeniorID from tblSeniorClients where SeniorID = '" & txtSenID.Text & "'") Then
            Else
                sql = "insert into tblSeniorClients values('" & txtSenID.Text & "', '" & txtCustName.Text & "')"
                ExecuteSQLQuery(sql)
            End If

            getdiscount()
            ExecuteSQLQuery("update tblUpdateCommand set UpdateCommand = UpdateCommand +1")
            MsgBox("Transaction saved!", MsgBoxStyle.Information)
            rdbNonSenior.Checked = False
            rdbSenior.Checked = True
            For i As Integer = 0 To lvItems.Items.Count - 1
                Dim code As String = lvItems.Items(i).Text
                Dim itemName As String = lvItems.Items(i).SubItems(1).Text
                Dim qty As Double = Val(lvItems.Items(i).SubItems(2).Text)

                Dim price As Double = Val(lvItems.Items(i).SubItems(3).Text)
                Dim total As Double = Val(lvItems.Items(i).SubItems(4).Text)

                sql = "insert into tblSalesDetails values('" & id & "', '" & code & "', '" & itemName & "', '" & qty & "', '" & price & "', '" & total & "')"
                ExecuteSQLQuery(sql)
                sql = "update tblRunningInventory set Sales=Sales + " & qty & " where ProductCode = '" & code & "'"
                ExecuteSQLQuery(sql)

                decreaseStock(code, qty)
            Next
            updateInventory()
            Dim frm As New frmViewReports("SalesReceipt", ExecuteSQLQuery("select * from tblSalesMaster where SalesID='" & id & "'"))
            frm.Show()
            frm.TopMost = True
            reset()
        End If
    End Sub
    Public Sub reset()
        lvItems.Items.Clear()
        lblTotalAmount.Text = "0.00"
        lblTotalDue.Text = "0.00"
        lblItemName.Text = "Item Name"
        lblPrice.Text = "0.00"
        txtCode.Clear()
        txtCashAmount.Clear()
        lblVat.Text = "0.00"
        lblVATable.Text = "0.00"
        lblDiscount.Text = "0.00"
        lblChange.Text = "0.00"
        chkDiscount.Checked = False
        rdbNonSenior.Checked = True
        txtCode.Focus()
        setupProductPrice()
    End Sub

    Private Sub txtCashAmount_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCashAmount.KeyPress
        AcceptNumbersPeriodKeyPressControlled(e, txtCashAmount)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If lblTotalDue.Text < 0 Then
                MsgBox("Invalid Quantity", MsgBoxStyle.Critical)
            Else
                If change >= 0.0 Then
                    commitSales()
                    getdiscount()
                End If
            End If
        End If
    End Sub

    Private Sub txtCashAmount_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCashAmount.TextChanged
        computeChange()
    End Sub
    Public Sub computeChange()
        change = Val(txtCashAmount.Text) - Val(subtotal)
        If change < 0 Then
            lblChange.Text = 0.0
        Else
            lblChange.Text = FormatNumber(change, 2)
        End If
    End Sub
    Public Sub removeItem()
        If lvItems.SelectedItems.Count = 1 Then
            lvItems.Items.RemoveAt(lvItems.SelectedItems(0).Index)
            countTotal()
            setupProductPrice()
        End If
    End Sub

    Private Sub lvItems_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvItems.DoubleClick
        Dim endInv As Double = putSingleValue("select EndInv from tblRunningInventory where ProductCode = '" & lvItems.SelectedItems(0).Text & "'")
        Dim newQty As String = InputBox("Enter new quantity for: " & lvItems.SelectedItems(0).SubItems(1).Text, "Set Quantity", lvItems.SelectedItems(0).SubItems(2).Text)
        If newQty <> "" Then
            If newQty > endInv Then
                MsgBox("Out of Stock", MsgBoxStyle.Critical)
            ElseIf Val(newQty) <> 0 Then
                lvItems.SelectedItems(0).SubItems(2).Text = newQty
                Dim total As Double = Val(newQty) * Val(lvItems.SelectedItems(0).SubItems(3).Text)
                lvItems.SelectedItems(0).SubItems(4).Text = Format(total, "####.00")
                countTotal()
            Else
                MsgBox("Invalid Quantity!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Val(txtCashAmount.Text) >= Val(lblTotalDue.Text) And txtCashAmount.Text <> "" Then
            If Val(lblChange.Text) >= 0 Then
                btnTransact.Enabled = True
            End If
        Else
            btnTransact.Enabled = False
        End If
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        reset()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        logoutUser()
    End Sub

    Private Sub btnProducts_Click(sender As System.Object, e As System.EventArgs) Handles btnProducts.Click
        frmProductsView.ShowDialog()
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If productForSales <> "" Then
            txtCode.Text = productForSales
            productForSales = ""
        End If
    End Sub

    Private Sub lvItems_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvItems.SelectedIndexChanged
        If lvItems.SelectedItems.Count > 0 Then
            btnRemoveItem.Enabled = True
        End If
    End Sub

    Private Sub btnRemoveItem_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveItem.Click
        removeItem()
    End Sub

    Private Sub rdbSenior_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSenior.CheckedChanged
        btnViewClients.Enabled = True
        txtSenID.Enabled = True
        txtCustName.Enabled = True
        Dim dt As DataTable = ExecuteSQLQuery("select * from tblDiscountVAt")
        discount = dt.Rows(0)(1).ToString
        countTotal()
    End Sub

    Private Sub rdbNonSenior_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbNonSenior.CheckedChanged
        txtSenID.Enabled = False
        txtCustName.Enabled = False
        txtCustName.Clear()
        txtSenID.Clear()
        btnViewClients.Enabled = False
        Dim vatable
        Dim total As Double = 0.0
        For i As Integer = 0 To lvItems.Items.Count - 1
            total += CDbl(lvItems.Items(i).SubItems(4).Text)
        Next
        discount = 0
        totalall = total
        lblTotalAmount.Text = FormatNumber((Format(total, "####.00")), 2)
        lblDiscount.Text = FormatNumber((Format(0, "####.00")), 2)
        lblVATable.Text = FormatNumber((Format(total / vat, "####.00")), 2)
        vatable = total / vat
        lblVat.Text = FormatNumber((Format(total - Convert.ToDouble(vatable), "####.00")), 2)
        lblTotalDue.Text = FormatNumber(Format(total - lblDiscount.Text, "####.00"), 2)
        subtotal = FormatNumber(Format(total - lblDiscount.Text, "####.00"), 2)
    End Sub

    Private Sub tmrTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTime.Tick

        lblTime.Text = FormatDateTime(Now, DateFormat.LongTime)
        lblDateToday.Text = FormatDateTime(Today, DateFormat.LongDate)
    End Sub

    Private Sub btnViewClients_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewClients.Click
        frmSeniorClient.ShowDialog()
    End Sub

    Private Sub txtCustName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustName.KeyPress
        AcceptAlphaNumericKeyPress(e)
    End Sub

    Private Sub txtSenID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSenID.KeyPress
        AcceptNumbersKeyPress(e)
    End Sub
End Class