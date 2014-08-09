Public Class frmProducts
    Dim sql As String = ""
    Dim currDT As DataTable

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Add new" Then
            btnGBCode.Enabled = True
            btnAddSupp.Enabled = True
            btnAddCat.Enabled = True
            enable()
            dtpExpirationDate.Enabled = True
            txtCode.Text = ""
            txtName.Text = ""
            fillItems2("select SupplierName from tblSuppliers", cbSupplier)
            fillItems2("select Category from tblCategory", cbCategory)
            txtUnitPrice.Text = ""
            numCritical.Text = ""
            txtDescription.Text = ""
            txtUnitPrice.Text = "0.00"
            txtQuantity.Text = "0"
            txtName.Focus()
            btnAdd.Text = "Save new"
            lvProducts.Enabled = False
            dtpExpirationDate.Value = Today.Date.AddDays(365)
        Else
            If txtUnitPrice.Text = "0.00" Then
                MsgBox("Enter Unit Price", MsgBoxStyle.Exclamation)
            ElseIf txtUnitPrice.Text = 0 Then
                MsgBox("Enter Unit Price", MsgBoxStyle.Exclamation)
            ElseIf dtpExpirationDate.Value <= Date.Now.Date Then
                MessageBox.Show("Invalid Expiration Date!", Me.Text)
            Else
                If txtCode.Text <> "" And txtName.Text <> "" And cbCategory.Text <> "" And txtDescription.Text <> "" And txtQuantity.Text <> "" And cbSupplier.Text <> "" And txtUnitPrice.Text <> "" Then
                    If checkExistence("select * from tblProducts where ProductCode='" & txtCode.Text & "'") Then
                        MsgBox("Your product code already exists.", MsgBoxStyle.Critical)
                    Else
                        sql = "insert into tblProducts values('" & txtCode.Text & "', '" & txtName.Text.Replace("'", "`") & "', '" & txtDescription.Text & "', '" & cbSupplier.Text & "', '" & cbCategory.Text & "', " & txtUnitPrice.Text & ", " & txtQuantity.Text & ", " & numCritical.Value & ", '" & dtpExpirationDate.Value.Date & "')"
                        ExecuteQuery(sql)
                        sql = "insert into tblBarcode values('" & txtCode.Text & "')"
                        ExecuteQuery(sql)
                        sql = "insert into tblRunningInventory values('" & txtCode.Text & "', '" & txtName.Text.Replace("'", "`") & "', '" & cbSupplier.Text & "', '" & cbCategory.Text & "', '" & txtQuantity.Text & "', 0, 0, 0, '0', '" & Today & "')"
                        ExecuteQuery(sql)
                        updateInventory()
                        Dim suppID As String = putSingleValue("select SupplierID from tblSuppliers where SupplierName='" & cbSupplier.Text & "'")
                        Dim record As String = suppID & "|" & txtUnitPrice.Text & "|" & "True"
                        sql = "insert into tblProductSupplier(ProductCode, Supplier1) values('" & txtCode.Text & "', '" & record & "')"
                        ExecuteQuery(sql)
                        sql = "insert into tblPriceProfit values('" & txtCode.Text & "', 0)"
                        ExecuteQuery(sql)
                        MsgBox("Product Saved!", MsgBoxStyle.Information)
                        reset()
                        refreshList()
                        btnGBCode.Enabled = False

                    End If
                Else
                    MsgBox("Incomplete Information", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub frmProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To lvProducts.Items.Count - 1
            Dim endinv = putSingleNumber("select EndInv from tblRunningInventory where ProductCode = '" & lvProducts.Items(i).Text & "'")
            Dim sql2 = "update tblProducts set Quantity = '" & endinv & "' where ProductCode='" & lvProducts.Items(i).Text & "'"
            ExecuteQuery(sql2)
        Next
        reset()

        refreshList()
        txtDescription.Clear()
        fillItems2("select SupplierName from tblSuppliers", cbSupplier)
        fillItems2("select Category from tblCategory", cbCategory)
        fillComboWithFields("select * from tblProducts", cbFields)
    End Sub
    Public Sub refreshList()
        sql = "select * from tblProducts order by ProductName"
        currDT = ExecuteQuery(sql)
        FillListView(currDT, lvProducts)
        txtCode.Enabled = False
    End Sub
    Public Sub reset()
        For Each ctr As Control In Me.gb1.Controls
            If TypeOf ctr Is TextBox Or TypeOf ctr Is ComboBox Then
                ctr.Text = ""
                ctr.Enabled = False
            End If
        Next
        lvProducts.Enabled = True
        fillItems2("select SupplierName from tblSuppliers", cbSupplier)
        fillItems2("select Category from tblCategory", cbCategory)
        fillComboWithFields("select * from tblProducts", cbFields)
        numCritical.Value = 1
        numCritical.Enabled = False
        btnAdd.Text = "Add new"
        btnUpdate.Text = "Update"
        dtpExpirationDate.Enabled = False
        dtpExpirationDate.Value = Date.Now.Date
        btnAdd.Enabled = True
        txtCode.Enabled = False
        btnUpdate.Enabled = False
        btnRemove.Enabled = False
        btnAddSupp.Enabled = False
        btnAddCat.Enabled = False
        btnGBCode.Enabled = False
    End Sub
    Public Sub enable()
        For Each ctr As Control In Me.gb1.Controls
            If TypeOf ctr Is TextBox Or TypeOf ctr Is ComboBox Then
                ctr.Enabled = True
            End If
        Next
        numCritical.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "Update" Then
            reset()
            enable()
            btnAddSupp.Enabled = True
            btnAddCat.Enabled = True
            dtpExpirationDate.Enabled = True
            btnAdd.Enabled = False
            With lvProducts.SelectedItems(0)
                txtCode.Text = .Text
                txtName.Text = .SubItems(1).Text
                txtDescription.Text = .SubItems(2).Text
                cbSupplier.SelectedItem = .SubItems(3).Text
                cbCategory.SelectedItem = .SubItems(4).Text
                txtUnitPrice.Text = .SubItems(5).Text
                txtQuantity.Text = .SubItems(6).Text
                numCritical.Value = Val(.SubItems(7).Text)
                dtpExpirationDate.Text = .SubItems(8).Text
            End With
            txtCode.Enabled = False
            txtName.Focus()
            btnUpdate.Enabled = True
            btnUpdate.Text = "Save"

        Else
            If txtName.Text <> "" And cbCategory.Text <> "" And cbSupplier.Text <> "" And txtUnitPrice.Text <> "" Then
                sql = "update tblProducts set ProductName='" & txtName.Text.Replace("'", "`") & "', Description='" & txtDescription.Text & "', Supplier='" & cbSupplier.Text & "', Category='" & cbCategory.Text & "', UnitPrice=" & txtUnitPrice.Text & ", Quantity=" & txtQuantity.Text & ", ReorderLevel=" & numCritical.Value & ", ExpirationDate='" & dtpExpirationDate.Value.Date & "' where ProductCode='" & txtCode.Text & "'"
                ExecuteQuery(sql)
                sql = "update tblRunningInventory set ProductName='" & txtName.Text.Replace("'", "`") & "',Supplier = '" & cbSupplier.Text & "', BegInv = '" & txtQuantity.Text & "', Category = '" & cbCategory.Text & "'  where ProductCode='" & txtCode.Text & "'"
                ExecuteQuery(sql)
                updateInventory()
                sql = "update tblPriceStack set SupplierPrice='" & txtUnitPrice.Text & "' where ProductCode='" & txtCode.Text & "'"
                ExecuteQuery(sql)
                Dim price As Double = 0.0
                Dim dt As DataTable = ExecuteQuery("select Supplier1  from tblProductSupplier where ProductCode='" & txtCode.Text & "'")
                If dt.Rows.Count = 1 Then
                    If dt.Rows(0)(0).ToString <> "" Then
                        Dim detail() As String = dt.Rows(0)(0).ToString.Split("|")
                        sql = "update tblProductSupplier set Supplier1='" & detail(0) + "|" + txtUnitPrice.Text + "|" + detail(2) & "'  where ProductCode='" & txtCode.Text & "'"
                        ExecuteQuery(sql)
                    End If
                End If
                MsgBox("Product Updated!", MsgBoxStyle.Information)
                reset()
                refreshList()
            Else
                MsgBox("Incomplete Information", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If cbFields.Text = "" Then
            Exit Sub
        End If
        If cbFields.Text <> "UnitPrice" And cbFields.Text <> "ReorderLevel" Then
            sql = "select * from tblProducts where " & cbFields.Text & " like '" & txtSearch.Text & "%' order by ProductCode"
        Else
            sql = "select * from tblProducts where " & cbFields.Text & " = " & txtSearch.Text & " order by ProductCode"
        End If
        currDT = ExecuteQuery(sql)
        fillListView(currDT, lvProducts)
    End Sub

    Private Sub txtUnitPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnitPrice.Click
        txtUnitPrice.Text = ""
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        AcceptAlphaNumericKeyPress(e)
    End Sub

    Private Sub txtUnitPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnitPrice.KeyPress
        AcceptNumbersPeriodKeyPressControlled(e, txtUnitPrice)
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If MsgBox("You are about to delete " & lvProducts.SelectedItems.Count & " record(s), do you wish to proceed?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Delete") = MsgBoxResult.Yes Then
            For i As Integer = 0 To lvProducts.SelectedItems.Count - 1
                sql = "delete from tblProducts where ProductCode='" & lvProducts.SelectedItems(i).Text & "'"
                ExecuteQuery(sql)
                sql = "delete from tblRunningInventory where ProductCode='" & lvProducts.SelectedItems(i).Text & "'"
                ExecuteQuery(sql)
                sql = "delete from tblProductSupplier where ProductCode='" & lvProducts.SelectedItems(i).Text & "'"
                ExecuteQuery(sql)
            Next
            MsgBox("Product Deleted!", MsgBoxStyle.Information)
            reset()
            refreshList()
        End If
    End Sub

    Private Sub btnGBCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGBCode.Click
        frmGenerateCode.ShowDialog()
    End Sub

    Private Sub lvProducts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvProducts.SelectedIndexChanged
        txtCode.Enabled = False
        If lvProducts.SelectedItems.Count > 0 Then
            txtCode.Text = lvProducts.SelectedItems(0).Text
            txtName.Text = lvProducts.SelectedItems(0).SubItems(1).Text
            txtDescription.Text = lvProducts.SelectedItems(0).SubItems(2).Text
            cbSupplier.Text = lvProducts.SelectedItems(0).SubItems(3).Text
            cbCategory.Text = lvProducts.SelectedItems(0).SubItems(4).Text
            txtUnitPrice.Text = lvProducts.SelectedItems(0).SubItems(5).Text
            txtQuantity.Text = lvProducts.SelectedItems(0).SubItems(6).Text
            numCritical.Text = lvProducts.SelectedItems(0).SubItems(7).Text
            dtpExpirationDate.Text = lvProducts.SelectedItems(0).SubItems(8).Text
        End If

        With lvProducts.SelectedItems
            If .Count = 1 Then
                btnUpdate.Enabled = True
                btnRemove.Enabled = True
                btnGBCode.Enabled = True
                txtCode.Enabled = False
            ElseIf .Count = 0 Then
                btnUpdate.Enabled = False
                btnRemove.Enabled = False
                btnGBCode.Enabled = False
                txtCode.Enabled = False
            ElseIf .Count > 1 Then
                btnUpdate.Enabled = False
                btnRemove.Enabled = True
                btnGBCode.Enabled = False
                txtCode.Enabled = False
            End If
        End With
    End Sub

    Private Sub btnAddSupp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSupp.Click
        frmSupplier.ShowDialog()
    End Sub

    Private Sub btnAddCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCat.Click
        frmAddCategory.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmProductPricing.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        reset()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        sql = "select * from tblProducts order by ProductName"
        currDT = ExecuteQuery(sql)
        Dim frm As New frmViewReports("Products", currDT)
        frm.Show()
    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        AcceptNumbersKeyPress(e)
    End Sub

    Private Sub frmProducts_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class