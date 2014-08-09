Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Public Class frmUsers
    Private mImageFile As Image
    Private nImageFile As Image
    Private mImageFilePath As String

    Dim sql As String = ""
    Public currCatID As String = ""
    Public currTestID As String = ""
    Public currTypeID As String = ""
    Public currQueID As String = ""
    Dim currDT As DataTable
    Private Sub frmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Reset()
        refreshList()
        fillItems2("select Type from tblUserType", cbType)
        fillComboWithFields("select UserID, FullName, UserType, Username from tblUsers", cbFields)
        btnChangePass.Hide()
    End Sub
    Public Sub refreshList()
        sql = "select UserID, FullName, UserType, Username from tblUsers order by UserID"
        currDT = ExecuteSQLQuery(sql)
        FillListView(currDT, lvUsers)
    End Sub
    Public Function setCode() As String
        Return Format(putSingleNumber("select max(UserID) from tblUsers") + 1, "00000")
    End Function
    Public Sub reset()

        For Each ctr As Control In Me.gb1.Controls
            If TypeOf ctr Is TextBox Or TypeOf ctr Is ComboBox Then
                ctr.Text = ""
                ctr.Enabled = False
            End If
        Next
        btnAdd.Text = "Add new"
        btnUpdate.Text = "Update"
        btnUpdate.Enabled = False
        btnRemove.Enabled = False
        fillItems2("select Type from tblUserType", cbType)
        fillComboWithFields("select UserID, FullName, UserType, Username from tblUsers", cbFields)


    End Sub
    Public Sub enable()
        For Each ctr As Control In Me.gb1.Controls
            If TypeOf ctr Is TextBox Or TypeOf ctr Is ComboBox Then
                ctr.Enabled = True
            End If
        Next
    End Sub

    Private Sub lvUsers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvUsers.SelectedIndexChanged

        If lvUsers.SelectedItems.Count > 0 Then
            txtID.Text = lvUsers.SelectedItems(0).Text
            txtName.Text = lvUsers.SelectedItems(0).SubItems(1).Text
            cbType.Text = lvUsers.SelectedItems(0).SubItems(2).Text
            txtUsername.Text = lvUsers.SelectedItems(0).SubItems(3).Text
        End If

        With lvUsers.SelectedItems
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

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        AcceptLettersKeyPress(e)
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
            If txtPassword.Text <> txtConfirmPass.Text Then
                MsgBox("Password does not match!", MsgBoxStyle.Exclamation)
            Else
                If txtName.Text <> "" And cbType.Text <> "" And txtUsername.Text <> "" And txtPassword.Text <> "" Then
                    If checkExistence("select * from tblUsers where Username='" & txtUsername.Text & "'") Then
                        MsgBox("Your preferred username is already exist, please choose another username.", MsgBoxStyle.Critical)
                        txtPassword.Focus()
                        txtPassword.SelectAll()
                    Else
                        sql = "insert into tblUsers values('" & txtID.Text & "', '" & txtName.Text.Replace("'", "`") & "', '" & cbType.Text & "', '" & txtUsername.Text & "', '" & MD5(txtPassword.Text) & "')"
                        ExecuteSQLQuery(sql)
                        reset()
                        refreshList()
                        MsgBox("User added!")
                    End If
                Else
                    MsgBox("Incomplete Information", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "Update" Then
            reset()
            enable()
            With lvUsers.SelectedItems(0)
                txtID.Text = .Text
                txtName.Text = .SubItems(1).Text
                cbType.SelectedItem = .SubItems(2).Text
                txtUsername.Text = .SubItems(3).Text
                txtPassword.Text = ""
            End With
            btnAdd.Enabled = False
            btnChangePass.Show()
            txtID.Enabled = False
            txtName.Focus()
            btnUpdate.Enabled = True
            btnUpdate.Text = "Save"
        Else
            If txtName.Text <> "" And cbType.Text <> "" And txtUsername.Text <> "" Then
                sql = "update tblUsers set FullName='" & txtName.Text.Replace("'", "`") & "', UserType='" & cbType.Text & "', Username='" & txtUsername.Text.Replace("'", "`") & "' where UserID='" & txtID.Text & "'"
                ExecuteSQLQuery(sql)
                reset()
                refreshList()
            Else
                MsgBox("Incomplete Information", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        If lvUsers.SelectedItems(0).Text = "00001" Then
            MessageBox.Show("Owner's account cannot be deleted!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If MsgBox("You are about to delete " & lvUsers.SelectedItems.Count & " record(s), do you wish to proceed?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Delete") = MsgBoxResult.Yes Then
                For i As Integer = 0 To lvUsers.SelectedItems.Count - 1
                    sql = "delete from tblUsers where UserID='" & lvUsers.SelectedItems(i).Text & "'"
                    ExecuteSQLQuery(sql)
                Next
                reset()
                refreshList()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        reset()
        refreshList()
        btnChangePass.Hide()
        btnAdd.Enabled = True
    End Sub
    Private Sub btnAddType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddType.Click
        Dim newType As String = InputBox("Enter new User type.", "New User type")
        If newType.Trim <> "" Then
            newType = newType.Replace("'", "`")
            If checkExistence("select * from tblUserType where Type='" & newType & "'") = False Then
                sql = "insert into tblUserType values('" & newType & "')"
                ExecuteSQLQuery(sql)
                MsgBox("User type successfully added.", MsgBoxStyle.Information)
                fillItems2("select Type from tblUserType", cbType)
            Else
                MsgBox("User type already exist", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePass.Click
        If checkExistence("select * from tblUsers where UserID='" & txtID.Text & "'") = True Then
            If MsgBox("Do you really want to change your password?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Password Change") = MsgBoxResult.Yes Then
                Dim dialog As New frmPassChange("Provide previous password.", txtID.Text, "previous")
                dialog.Show()
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frm As New frmViewReports("Users", currDT)
        frm.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewUserLogs.Click
        frmUsersLog.ShowDialog()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If cbFields.Text <> "" Then
            sql = "select UserID, FullName, UserType, Username from tblUsers where " & cbFields.Text & " like '" & txtSearch.Text & "%' order by UserID"
            currDT = ExecuteSQLQuery(sql)
            FillListView(currDT, lvUsers)
        End If
    End Sub

    Private Sub txtConfirm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConfirmPass.TextChanged

    End Sub
End Class