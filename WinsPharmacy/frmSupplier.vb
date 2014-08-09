Public Class frmSupplier

    Dim sql As String = ""
    Dim util As New RegexUtilities()
    Dim currDT As DataTable
    Private Sub frmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reset()
        refreshList()
        fillComboWithFields("select * from tblSuppliers", cbFields)
    End Sub
    Public Sub refreshList()
        sql = "select * from tblSuppliers order by SupplierID"
        currDT = ExecuteSQLQuery(sql)
        FillListView(currDT, lvSuppliers)
    End Sub
    Public Function setCode() As String
        Return Format(putSingleNumber("select max(SupplierID) from tblSuppliers") + 1, "00000")
    End Function
    Public Sub reset()
        For Each ctr As Control In Me.gb1.Controls
            If TypeOf ctr Is TextBox Or TypeOf ctr Is ComboBox Then
                ctr.Text = ""
                ctr.Enabled = False
            End If
        Next
        btnAdd.Text = "Add new"
        btnAdd.Enabled = True
        btnUpdate.Text = "Update"
        btnUpdate.Enabled = False
        btnRemove.Enabled = False
        fillComboWithFields("select * from tblSuppliers", cbFields)
    End Sub
    Public Sub enable()
        For Each ctr As Control In Me.gb1.Controls
            If TypeOf ctr Is TextBox Or TypeOf ctr Is ComboBox Then
                ctr.Enabled = True
            End If
        Next
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        AcceptLettersKeyPress(e)
    End Sub

    Private Sub txtAddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        AcceptAlphaNumericKeyPress(e)
    End Sub

    Private Sub txtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        AcceptNumbersKeyPress(e)
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If btnUpdate.Text = "Update" Then
            reset()
            enable()
            With lvSuppliers.SelectedItems(0)
                txtID.Text = .Text
                txtName.Text = .SubItems(1).Text
                txtAddress.Text = .SubItems(2).Text
                txtContact.Text = .SubItems(3).Text
                txtEmail.Text = .SubItems(4).Text
            End With
            txtID.Enabled = False
            txtName.Focus()
            btnUpdate.Enabled = True
            btnAdd.Enabled = False

            btnUpdate.Text = "Save"
        Else
            If txtName.Text = "" Or txtAddress.Text = "" Or txtContact.Text = "" Or txtEmail.Text = "" Then
                MsgBox("Please complete all information", MsgBoxStyle.Exclamation)
            ElseIf Not util.IsValidEmail(txtEmail.Text) Then
                MsgBox("Invalid Email Address", MsgBoxStyle.Exclamation)
                txtEmail.SelectAll()
                txtEmail.Focus()
            Else
                sql = "update tblSuppliers set SupplierName='" & txtName.Text.Replace("'", "`") & "', Address='" & txtAddress.Text & "', ContactInfo='" & txtContact.Text & "',  EmailAddress='" & txtEmail.Text.Replace("'", "`") & "' where SupplierID='" & txtID.Text & "'"
                ExecuteSQLQuery(sql)
                reset()
                refreshList()
                MsgBox("Record Updated!")
            End If
        End If
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If lvSuppliers.SelectedItems.Count = 1 Then
            Dim supplier As String = lvSuppliers.SelectedItems(0).SubItems(1).Text
            frmSupplierProducts.lblSupplier.Text = supplier
            frmSupplierProducts.supplier = supplier
            frmSupplierProducts.ShowDialog()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If cbFields.Text <> "" Then
            sql = "select * from tblSuppliers where " & cbFields.Text & " like '" & txtSearch.Text & "%' order by SupplierID"
            currDT = ExecuteSQLQuery(sql)
            FillListView(currDT, lvSuppliers)
        End If
    End Sub
    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If MsgBox("You are about to delete " & lvSuppliers.SelectedItems.Count & " record(s), do you wish to proceed?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Delete") = MsgBoxResult.Yes Then
            For i As Integer = 0 To lvSuppliers.SelectedItems.Count - 1
                sql = "delete from tblSuppliers where SupplierID='" & lvSuppliers.SelectedItems(i).Text & "'"
                ExecuteSQLQuery(sql)
            Next
            reset()
            refreshList()
            MsgBox("Record Deleted!")
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If lvSuppliers.SelectedItems.Count = 1 Then
            btnView.Enabled = True
        Else
            btnView.Enabled = False
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Add new" Then
            reset()
            enable()
            txtID.Enabled = False
            txtID.Text = setCode()
            txtName.Focus()
            btnAdd.Text = "Save new"
        Else
            If txtName.Text = "" Or txtAddress.Text = "" Or txtContact.Text = "" Or txtEmail.Text = "" Then
                MsgBox("Please complete all information", MsgBoxStyle.Exclamation)
            ElseIf Not util.IsValidEmail(txtEmail.Text) Then
                MsgBox("Invalid Email Address", MsgBoxStyle.Exclamation)
                txtEmail.SelectAll()
                txtEmail.Focus()
            Else
                sql = "insert into tblSuppliers values('" & txtID.Text & "', '" & txtName.Text.Replace("'", "`") & "', '" & txtAddress.Text.Replace("'", "`") & "', '" & txtContact.Text & "', '" & txtEmail.Text & "')"
                ExecuteSQLQuery(sql)
                reset()
                refreshList()
                MsgBox("Record Saved!")
                fillItems2("select SupplierName from tblSuppliers", frmProducts.cbSupplier)
            End If
        End If
    End Sub

    Private Sub lvSuppliers_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvSuppliers.SelectedIndexChanged
        If lvSuppliers.SelectedItems.Count > 0 Then
            txtID.Text = lvSuppliers.SelectedItems(0).Text
            txtName.Text = lvSuppliers.SelectedItems(0).SubItems(1).Text
            txtAddress.Text = lvSuppliers.SelectedItems(0).SubItems(2).Text
            txtContact.Text = lvSuppliers.SelectedItems(0).SubItems(3).Text
            txtEmail.Text = lvSuppliers.SelectedItems(0).SubItems(4).Text
        End If

        With lvSuppliers.SelectedItems
            If .Count = 1 Then
                btnUpdate.Enabled = True
                btnRemove.Enabled = True
            ElseIf .Count = 0 Then
                btnUpdate.Enabled = False
                btnRemove.Enabled = False
            ElseIf .Count > 1 Then
                btnUpdate.Enabled = False
                btnRemove.Enabled = True
            End If
        End With
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frm As New frmViewReports("Suppliers", currDT)
        frm.Show()
    End Sub
End Class