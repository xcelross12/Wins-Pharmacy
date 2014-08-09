Public Class frmPurchaseOrder
    Dim sql As String = ""

    'variables for PO editing
    Dim isEditMode As Boolean = False
    Dim prevQty As Double = 0.0
    Dim editIndex As Integer = 0
    'end of scope
    Public purchaseitemcode


    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If checkExistence("select * from tblProducts where ProductCode='" & txtCode.Text & "'") Then
            lblItemName.Text = putSingleValue("select ProductName from tblProducts where ProductCode='" & txtCode.Text & "'")
            showSupplierAndPrice()
            txtCount.Text = 1
            txtCount.Focus()

            lblStocks.Text = putSingleNumber("select EndInv from tblRunningInventory where ProductCode='" & txtCode.Text & "'")
        Else
            lblItemName.Text = "Item Name"
            lblPrice.Text = "Price"
            lblSupplier.Text = "Supplier"
            lblStocks.Text = "Stocks"
        End If
    End Sub
    Public Sub showSupplierAndPrice()
        Dim dt As DataTable = ExecuteSQLQuery("select * from tblProductSupplier where ProductCode='" & txtCode.Text & "'")
        If dt.Rows.Count = 1 Then
            For i As Integer = 1 To dt.Columns.Count - 1
                If dt.Rows(0)(i).ToString <> "" Then
                    Dim detail() As String = dt.Rows(0)(i).ToString.Split("|")
                    If detail(2) = "True" Then
                        Dim supp = putSingleValue("select SupplierName from tblSuppliers where SupplierID='" & detail(0) & "'")
                        sql = "select SupplierName from tblSuppliers"
                        Dim dt2 As DataTable = ExecuteSQLQuery(sql)
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
            .Add(lblSupplier.Text)
        End With
        If isEditMode Then
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
    Private Sub txtCount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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
                    Dim supplier As String = .SubItems(5).Text
                    sql = "insert into tblPurchases values('" & pID & "', '" & code & "', '" & name & "', " & qty & ", " & price & ", " & total & ", " & subTotal & ", '" & Today & "', '" & delivDate & "', '" & supplier & "', 'NO', 'NONE')"
                    ExecuteSQLQuery(sql)
                End With
            Next
            MsgBox("Purchase Order successfully saved!", MsgBoxStyle.Information)
            'Dim frm As New frmReportViewer("PurchaseOrder", ExecuteSQLQuery("select * from tblPurchases where PurchaseID='" & pID & "' order by Supplier"))
            'frm.Show()
            Dim frm As New frmSupplierPO(pID)
            frm.ShowDialog()
            lvItems.Items.Clear()
        End If
    End Sub

    Public Sub loadPurchaseRecord(ByVal PurchaseID As String)
        lvItems.Items.Clear()
        Dim dt As New DataTable
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
        dtpDelivery.Text = dt.Rows(0)("DeliveryDate").ToString
        countTotal()
    End Sub
    Public Sub loadFromCritical(ByVal list As ArrayList, ByVal qtyList As ArrayList)
        lvItems.Items.Clear()
        For i As Integer = 0 To list.Count - 1
            Dim lItem As New ListViewItem
            Dim code As String = list.Item(i).ToString
            lItem.Text = code
            lItem.SubItems.Add(putSingleValue("select ProductName from tblProducts where ProductCode='" & code & "'"))
            Dim qty As Double = Val(qtyList.Item(i).ToString)
            lItem.SubItems.Add(qty)
            'lItem.SubItems.Add(putSingleNumber("select UnitPrice from tblProducts where ProductCode='" & code & "'"))
            'Dim price As Double = putSingleNumber("select UnitPrice from tblProducts where ProductCode='" & code & "'")
            Dim price As Double = getSupplierPricePreferred(code)
            lItem.SubItems.Add(price)
            Dim total As Double = qty * price
            lItem.SubItems.Add(total)
            lItem.SubItems.Add(putSingleValue("select Supplier from tblProducts where ProductCode='" & code & "'"))
            lvItems.Items.Add(lItem)

        Next
        countTotal()
    End Sub
    Public Sub New(ByVal list As ArrayList, ByVal qtyList As ArrayList)
        InitializeComponent()
        loadFromCritical(list, qtyList)
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If lvItems.Items.Count = 0 Then
            MsgBox("Cart is empty.", MsgBoxStyle.Exclamation)
        Else
            savePurchaseOrder()
            reset()
        End If

    End Sub

    Private Sub frmPurchases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDelivery.Value = dtpDelivery.Value.Date.AddDays(5)
        'reset()
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        If (txtCode.Text = "") Then
            MsgBox("Please select a product first")
            txtCode.Focus()
        ElseIf (txtCode.Text <> "" And txtCount.Text = "" Or txtCount.Text = "0") Then
            MsgBox("Please input how many will you order.")
            txtCount.SelectAll()
            txtCount.Focus()
        Else
            addToList()
        End If
    End Sub

    Private Sub cbMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnRemove.Visible = True
        lblDirection.Visible = True
    End Sub

    Private Sub btnProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lvChoose = ""
        frmProductsView.ShowDialog()
    End Sub

    Private Sub tmrCode_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCode.Tick
        If purchaseitemcode <> "" Then
            txtCode.Text = purchaseitemcode
            purchaseitemcode = ""
        End If
    End Sub
    Public Sub reset()
        txtCode.Clear()
        txtCount.Clear()
        lvItems.Items.Clear()
        countTotal()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        reset()
    End Sub

    Private Sub lvItems_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvItems.DoubleClick
        Dim newQty As String = InputBox("Enter new quantity for: " & lvItems.SelectedItems(0).SubItems(1).Text, "Set Quantity", lvItems.SelectedItems(0).SubItems(2).Text)
        If newQty <> "" Then
            If Val(newQty) <> 0 Then
                lvItems.SelectedItems(0).SubItems(2).Text = newQty
                Dim total As Double = Val(newQty) * Val(lvItems.SelectedItems(0).SubItems(3).Text)
                lvItems.SelectedItems(0).SubItems(4).Text = Format(total, "####.00")
                countTotal()
            Else
                MsgBox("Invalid Quantity!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If lvItems.SelectedItems.Count = 1 Then
            lvItems.Items.RemoveAt(lvItems.SelectedItems(0).Index)
            countTotal()
        End If
    End Sub

    Private Sub tmrChange_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrChange.Tick
        If signalForChangeSupp <> "" Then
            showSupplierAndPrice()
            signalForChangeSupp = ""
        End If
    End Sub

    Private Sub frmPurchases_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        frmProductsView2.ShowDialog()
    End Sub

    Private Sub txtCode_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged
        If checkExistence("select * from tblProducts where ProductCode='" & txtCode.Text & "'") Then
            lblItemName.Text = putSingleValue("select ProductName from tblProducts where ProductCode='" & txtCode.Text & "'")
            lblSupplier.Text = putSingleValue("select Supplier from tblProducts where ProductCode='" & txtCode.Text & "'")
            showSupplierAndPrice()
            txtCount.Text = 1
            txtCount.Focus()
            lblStocks.Text = putSingleNumber("select EndInv from tblRunningInventory where ProductCode='" & txtCode.Text & "'")
        Else
            lblItemName.Text = "Item Name"
            lblPrice.Text = "Price"
            lblSupplier.Text = "Supplier"
            lblStocks.Text = "Stocks"
        End If
    End Sub

    Private Sub txtCount_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCount.KeyPress
        AcceptNumbersKeyPress(e)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            addToList()
        End If
    End Sub
End Class