Public Class frmPurchaseConfirmation
    Dim sql As String = ""
    Public quantity As Integer
    Dim total As Double
    'variables for PO editing
    Dim isEditMode As Boolean = False
    Dim prevQty As Double = 0.0
    Dim editIndex As Integer = 0
    'end of scope
    Dim newproductexist = False

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        'uncomment when finished debugging
        '    AcceptNumbersKeyPress(e)
    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged
        If checkExistence("select * from tblProducts where ProductCode='" & txtCode.Text & "'") Then
            lblItemName.Text = putSingleValue("select ProductName from tblProducts where ProductCode='" & txtCode.Text & "'")
            'lblPrice.Text = putSingleNumber("select UnitPrice from tblProducts where ProductCode='" & txtCode.Text & "'") & " Php"
            showSupplierAndPrice()
            txtCount.Text = 1
            txtCount.Focus()
            'If chkMulti.Checked = False Then
            '    addToList()
            'End If
        Else
            lblItemName.Text = "Item Name"
            lblPrice.Text = "Price"
            lblSupplier.Text = "Supplier"
        End If
    End Sub
    Public Sub showSupplierAndPrice()
        Dim dt As DataTable = ExecuteSQLQuery("select * from tblProductSupplier where ProductCode='" & txtCode.Text & "'")
        If dt.Rows.Count = 1 Then
            For i As Integer = 1 To dt.Columns.Count - 1
                If dt.Rows(0)(i).ToString <> "" Then
                    Dim detail() As String = dt.Rows(0)(i).ToString.Split("|")
                    If detail(2) = "True" Then
                        lblSupplier.Text = putSingleValue("select SupplierName from tblSuppliers where SupplierID='" & detail(0) & "'")
                        lblPrice.Text = Format(Val(detail(1)), "####.00")
                        Exit For
                    End If
                End If
            Next
        End If
    End Sub
    Public Sub addToList()
        Dim item As New ListViewItem
        item.Text = txtCode.Text
        With item.SubItems
            .Add(lblItemName.Text)
            .Add(txtCount.Text)
            .Add(Format(Val(lblPrice.Text), "####.00"))
            .Add(Format((Val(lblPrice.Text) * Val(txtCount.Text)), "####.00"))
        End With

        If isEditMode = True Then
            'code for pending
            Dim remainingQty As Double = prevQty - Val(txtCount.Text)
            If remainingQty > 0 And remainingQty < prevQty Then
                If MsgBox("Product: " & lblItemName.Text & vbCrLf & "Remaining Qty:  " & remainingQty & vbCrLf & vbCrLf & "Do you want the remaining to be in pending order list?      ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Pending Order") = MsgBoxResult.Yes Then
                    Dim item2 As New ListViewItem
                    item2.Text = txtCode.Text
                    With item2.SubItems
                        .Add(lblItemName.Text)
                        .Add(remainingQty)
                        .Add(Format(Val(lblPrice.Text), "####.00"))
                        .Add(Format((Val(lblPrice.Text) * Val(remainingQty)), "####.00"))
                    End With

                    Dim index As Integer = isInThePendingList(txtCode.Text)
                    If index <> -1 Then
                        lvPending.Items(index).SubItems(2).Text = Val(lvPending.Items(index).SubItems(2).Text) + remainingQty
                        lvPending.Items(index).SubItems(3).Text = Format(Val(lblPrice.Text), "####.00")
                        lvPending.Items(index).SubItems(4).Text = Format((Val(lblPrice.Text) * Val(lvPending.Items(index).SubItems(2).Text)), "####.00")
                    Else
                        lvPending.Items.Add(item2)
                    End If

                    countPending()

                End If
                lvItems.Items(editIndex).SubItems(2).Text = txtCount.Text
                lvItems.Items(editIndex).SubItems(3).Text = Format(Val(lblPrice.Text), "####.00")
                lvItems.Items(editIndex).SubItems(4).Text = Format((Val(lblPrice.Text) * Val(txtCount.Text)), "####.00")
                countTotal()
            ElseIf remainingQty < 0 Then
                lvItems.Items(editIndex).SubItems(2).Text = txtCount.Text
                lvItems.Items(editIndex).SubItems(3).Text = Format(Val(lblPrice.Text), "####.00")
                lvItems.Items(editIndex).SubItems(4).Text = Format((Val(lblPrice.Text) * Val(txtCount.Text)), "####.00")
                countTotal()
            End If
            isEditMode = False
        Else    'code for generating PO only
            If isInTheList() Then
                MsgBox("Item already in the list!", MsgBoxStyle.Exclamation)
            Else
                lvItems.Items.Add(item)
            End If
        End If

        countTotal()
        txtCount.Text = ""
        txtCode.Text = ""
        txtCode.Focus()
    End Sub
    Public Sub countTotal()
        Dim total As Double = 0.0
        For i As Integer = 0 To lvItems.Items.Count - 1
            total += Val(lvItems.Items(i).SubItems(4).Text)
        Next
        If total = 0.0 Then
            lblSubTotal.Text = "0.00"
        Else
            lblSubTotal.Text = Format(total, "####.00")
        End If

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
    Public Function isInThePendingList(ByVal code As String) As Integer
        Dim index As Integer = -1
        For i As Integer = 0 To lvPending.Items.Count - 1
            If code = lvPending.Items(i).Text Then
                index = i
                Exit For
            End If
        Next
        Return index
    End Function

    Private Sub txtCount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCount.KeyPress
        AcceptNumbersKeyPress(e)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            addToList()
        End If
    End Sub

    Public Sub savePurchaseOrder()
        If MsgBox("Do you really want to proceed generating Purchase Order?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation") = MsgBoxResult.Yes Then
            Dim pID As String = generatePurchaseID()
            Dim subTotal As Double = Val(lblSubTotal.Text)
            Dim delivDate As String = dtpDelivery.Value.Date.ToString

            For i As Integer = 0 To lvItems.Items.Count - 1
                With lvItems.Items(i)
                    Dim code As String = .Text
                    Dim name As String = .SubItems(1).Text
                    Dim qty As Double = Val(.SubItems(2).Text)
                    Dim price As Double = Val(.SubItems(3).Text)
                    Dim total As Double = Val(.SubItems(4).Text)
                    Dim supplier As String = putSingleValue("select Supplier from tblProducts where ProductCode='" & code & "'")

                    sql = "insert into tblPurchases values('" & pID & "', '" & code & "', '" & name & "', " & qty & ", " & price & ", " & total & ", " & subTotal & ", '" & Today & "', '" & delivDate & "', '" & supplier & "', 'NO')"
                    ExecuteSQLQuery(sql)
                End With
            Next
            MsgBox("Purchase Order successfully saved!", MsgBoxStyle.Information)
            'Dim frm As New frmReportViewer("PurchaseOrder", ExecuteSQLQuery("select * from tblPurchases where PurchaseID='" & pID & "' order by Supplier"))
            'frm.Show()
            lvItems.Items.Clear()
        End If
    End Sub

    Public Sub deleteItem(ByVal id As String)
        sql = "delete from tblPurchases where PurchaseID='" & txtPurchaseID.Text & "' and ProductCode='" & id & "'"
        ExecuteSQLQuery(sql)
        loadPurchaseRecord(txtPurchaseID.Text)
    End Sub

    Public Sub loadPurchaseRecord(ByVal PurchaseID As String)
        lvItems.Items.Clear()
        Dim dt As New DataTable
        dt = ExecuteSQLQuery("select * from tblPurchases where PurchaseID='" & txtPurchaseID.Text & "' and Confirmed='NO'")
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim lItem As New ListViewItem
            Dim code As String = dt.Rows(i)("ProductCode").ToString
            lItem.Text = code
            lItem.SubItems.Add(dt.Rows(i)("ProductName").ToString)
            lItem.SubItems.Add(dt.Rows(i)("Quantity").ToString)
            'lItem.SubItems.Add(putSingleNumber("select UnitPrice from tblProducts where ProductCode='" & code & "'"))
            lItem.SubItems.Add(dt.Rows(i)("Price").ToString)
            lItem.SubItems.Add(dt.Rows(i)("Total").ToString)
            lvItems.Items.Add(lItem)
        Next
        'dtpDelivery.Text = dt.Rows(0)("DeliveryDate").ToString
        countTotal()
    End Sub
    'Public Sub loadFromCritical(ByVal list As ArrayList, ByVal qtyList As ArrayList)
    '    lvItems.Items.Clear()
    '    For i As Integer = 0 To list.Count - 1
    '        Dim lItem As New ListViewItem
    '        Dim code As String = list.Item(i).ToString
    '        lItem.Text = code
    '        lItem.SubItems.Add(putSingleValue("select ProductName from tblProducts where ProductCode='" & code & "'"))
    '        Dim qty As Double = Val(qtyList.Item(i).ToString)
    '        lItem.SubItems.Add(qty)
    '        'lItem.SubItems.Add(putSingleNumber("select UnitPrice from tblProducts where ProductCode='" & code & "'"))
    '        'Dim price As Double = putSingleNumber("select UnitPrice from tblProducts where ProductCode='" & code & "'")
    '        Dim price As Double = getSupplierPrice(code)
    '        lItem.SubItems.Add(price)
    '        Dim total As Double = qty * price
    '        lItem.SubItems.Add(total)
    '        lvItems.Items.Add(lItem)
    '    Next
    '    countTotal()
    'End Sub
    'Public Sub New(ByVal list As ArrayList, ByVal qtyList As ArrayList)
    '    InitializeComponent()
    '    loadFromCritical(list, qtyList)
    'End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        addToList()
    End Sub

    Private Sub txtPurchaseID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPurchaseID.TextChanged
        If checkExistence("select * from tblPurchases where PurchaseID='" & txtPurchaseID.Text & "' and Confirmed='NO'") = True Then
            loadPurchaseRecord(txtPurchaseID.Text)
        Else
            lvItems.Items.Clear()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If lvItems.SelectedItems.Count = 1 Then
            If MsgBox("You are about to cancel the order for this item, proceed?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Cancel Order") = MsgBoxResult.Yes Then
                deleteItem(lvItems.SelectedItems(0).Text)
                loadPurchaseRecord(txtPurchaseID.Text)
            End If
        End If
    End Sub
    Private Sub btnPending_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPending.Click
        If lvItems.SelectedItems.Count = 1 Then
            frmQTY.quantity = lvItems.SelectedItems(0).SubItems(2).Text
            frmQTY.ShowDialog()
            If quantity > 0 Then
                If MsgBox("You are about to put this item into the pending list, proceed?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Pending Order") = MsgBoxResult.Yes Then
                    Dim index As Integer = isInThePendingList(lvItems.SelectedItems(0).Text)
                    If index <> -1 Then
                        If quantity <> 0 Then
                            lvPending.Items(index).SubItems(1).Text = lvItems.SelectedItems(0).SubItems(1).Text
                            lvPending.Items(index).SubItems(0).Text = lvItems.SelectedItems(0).SubItems(0).Text
                            total = Val(quantity) * Val(lvItems.SelectedItems(0).SubItems(3).Text)
                            lvPending.SelectedItems(0).SubItems(4).Text = Format(total, "####.00")
                            lvPending.Items(index).SubItems(3).Text = Val(lvItems.SelectedItems(0).SubItems(3).Text)
                            lvPending.SelectedItems(0).SubItems(2).Text = quantity
                            '  countTotal()
                        Else
                            MsgBox("Invalid Quantity!", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        Dim item As New ListViewItem
                        item.Text = lvItems.SelectedItems(0).SubItems(0).Text
                        total = Val(quantity) * Val(lvItems.SelectedItems(0).SubItems(3).Text)
                        With item.SubItems
                            .Add(lvItems.SelectedItems(0).SubItems(1).Text)
                            .Add(quantity)
                            .Add(Val(lvItems.SelectedItems(0).SubItems(3).Text))
                            .Add(Format(total, "####.00"))
                        End With
                        lvPending.Items.Add(item)

                    End If

                    Dim itemQty = Val(lvItems.SelectedItems(0).SubItems(2).Text) - quantity
                    If itemQty = 0 Then
                        lvItems.SelectedItems(0).Remove()
                    Else
                        lvItems.SelectedItems(0).SubItems(2).Text = itemQty
                        total = Val(itemQty) * Val(lvItems.SelectedItems(0).SubItems(3).Text)
                        lvItems.SelectedItems(0).SubItems(4).Text = Format(total, "####.00")
                    End If
                    countTotal()
                    countPending()
                End If
                quantity = 0
            End If
        Else
            MessageBox.Show("Please select an item to put in the pending list.")
        End If

    End Sub
    Public Sub countPending()
        Dim total As Double = 0.0
        For i As Integer = 0 To lvPending.Items.Count - 1
            total += Val(lvPending.Items(i).SubItems(4).Text)
        Next
        If total = 0.0 Then
            lblPendingTotal.Text = "0.00"
        Else
            lblPendingTotal.Text = Format(total, "####.00")
        End If
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        If txtPurchaseID.Text = "" Then
            MsgBox("Please insert the purchase ID")
        ElseIf txtReceipt.Text = "" Then
            MsgBox("Please input the delivery receipt")
        ElseIf MsgBox("Do you want to proceed saving the changes?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Update") = MsgBoxResult.Yes Then
            ExecuteSQLQuery("delete from tblPurchases where PurchaseID='" & txtPurchaseID.Text & "'")
            Dim pID As String = txtPurchaseID.Text
            Dim subTotal As Double = Val(lblSubTotal.Text)
            Dim delivDate As String = dtpDelivery.Value.Date.ToString

            For i As Integer = 0 To lvItems.Items.Count - 1

                With lvItems.Items(i)
                    Dim code As String = .Text
                    Dim name As String = .SubItems(1).Text
                    Dim qty As Double = Val(.SubItems(2).Text)
                    Dim price As Double = Val(.SubItems(3).Text)
                    Dim total As Double = Val(.SubItems(4).Text)
                    Dim supplier As String = putSingleValue("select Supplier from tblProducts where ProductCode='" & code & "'")
                    
                        sql = "insert into tblPurchases values('" & pID & "', '" & code & "', '" & name & "', " & qty & ", " & price & ", " & total & ", " & subTotal & ", '" & Today & "', '" & delivDate & "', '" & supplier & "', 'YES', '" & txtReceipt.Text & "')"
                    ExecuteSQLQuery(sql)
                        sql = "update tblRunningInventory set Delivery =  Delivery +" & qty & ", Date='" & Today & "' where ProductCode = '" & code & "'"
                    ExecuteSQLQuery(sql)
                    updateInventory()
                    Dim endinv = putSingleValue("select EndInv from tblRunningInventory where ProductCode='" & code & "'")
                    sql = "update tblProducts set Quantity =  " & endinv & " where ProductCode = '" & code & "'"
                    ExecuteSQLQuery(sql)
                        Dim suppName As String = putSingleValue("select SupplierName from tblSuppliers where SupplierName='" & supplier & "'")
                        Dim recordID As Integer = putSingleNumber("select max(RecordID) from tblPriceStack") + 1
                        sql = "insert into tblPriceStack values(" & recordID & ", '" & code & "', '" & suppName & "', " & qty & ", " & price & ", '" & FormatDateTime(Now, DateFormat.GeneralDate) & "')"
                        ExecuteSQLQuery(sql)
                    updateInventory()

                End With
            Next
            updateInventory()
            ExecuteSQLQuery("update tblUpdateCommand set UpdateCommand = UpdateCommand +1")

            Dim subTotalPending As Double = Val(lblPendingTotal.Text)
            Dim delivDatePending As String = ""
            If Not dtpDelivery.Value.Date.Equals(Today) Then
                delivDatePending = DateAdd(DateInterval.Day, 2, dtpDelivery.Value.Date).ToString
            Else
                delivDatePending = delivDate
            End If
            For i As Integer = 0 To lvPending.Items.Count - 1
                With lvPending.Items(i)
                    Dim code As String = .Text
                    Dim name As String = .SubItems(1).Text
                    Dim qty As Double = Val(.SubItems(2).Text)
                    Dim price As Double = Val(.SubItems(3).Text)
                    Dim total As Double = Val(.SubItems(4).Text)

                    Dim supplier As String = putSingleValue("select Supplier from tblProducts where ProductCode='" & code & "'")
                    If .Text.Contains("Unknown") Then
                        supplier = putSingleValue("select tblSuppliers.SupplierName from tblPartialProducts join tblSuppliers on  tblPartialProducts.Supplier=tblSuppliers.SupplierID where tblPartialProducts.ID='" & code & "'")
                    End If
                    sql = "insert into tblPurchases values('" & pID & "', '" & code & "', '" & name & "', " & qty & ", " & price & ", " & total & ", " & subTotalPending & ", '" & Today & "', '" & delivDatePending & "', '" & supplier & "', 'NO', 'NONE')"
                    ExecuteSQLQuery(sql)
                End With
            Next
            MsgBox("Stock update successfully saved!", MsgBoxStyle.Information)
            reset()
            setupProductPrice()
            btnConfirm.Enabled = False
            btnConfirm.Enabled = False
            txtReceipt.Text = ""
        End If
    End Sub

    Private Sub btnProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProducts.Click
        frmProductsView2.ShowDialog()
    End Sub

    Private Sub tmrCode_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCode.Tick
        If selectedProduct <> "" Then
            txtCode.Text = selectedProduct
            selectedProduct = ""
        End If
    End Sub
    Public Sub reset()
        txtPurchaseID.Clear()
        txtCode.Clear()
        txtCount.Clear()
        lvItems.Items.Clear()
        lvPending.Items.Clear()
        countPending()
        countTotal()
    End Sub

    Private Sub lnkChange_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkChange.LinkClicked
        If checkExistence("select * from tblProducts where ProductCode='" & txtCode.Text & "'") Then
            'frmProductSupplier.Show()
            'frmProductSupplier.txtCode.Text = Me.txtCode.Text
            ' showSupplierAndPrice()
        End If
    End Sub

    Private Sub tmrChange_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrChange.Tick
        If signalForChangeSupp <> "" Then
            showSupplierAndPrice()
            signalForChangeSupp = ""
        End If
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        frmPurchaseIDView.ShowDialog()
    End Sub

    Private Sub tmrPurchaseID_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPurchaseID.Tick
        If purchaseIDForConfirmation <> "" Then
            txtPurchaseID.Text = purchaseIDForConfirmation
            purchaseIDForConfirmation = ""
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtReceipt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReceipt.TextChanged
        If txtReceipt.Text = "" Then
            btnConfirm.Enabled = False
        Else
            btnConfirm.Enabled = True
        End If

    End Sub

    Private Sub frmPurchaseConfirmation_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtReceipt.Clear()
        txtPurchaseID.Clear()
        lvItems.Items.Clear()
        lvPending.Items.Clear()
    End Sub

    Private Sub txtReceipt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReceipt.KeyPress
        AcceptNumbersKeyPress(e)
    End Sub
End Class