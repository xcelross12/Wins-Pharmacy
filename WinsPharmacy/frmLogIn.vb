Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Public Class frmLogIn
    Dim ctr As Integer = 3
    Dim sql As String = ""
    Dim DT As New DataTable
    Public Function logUser(ByVal id As String) As Boolean
        Dim allowed As Boolean = False
        If checkExistence("select * from tblUsersLog where UserID='" & id & "' and Logout='in'") Then
            allowed = False
        Else
            allowed = True
            Dim dt As DataTable = ExecuteSQLQuery("select * from tblUsers where UserID='" & id & "'")
            Dim logID As Integer = putSingleNumber("select max(LogID) from tblUsersLog") + 1
            If dt.Rows.Count = 1 Then
                Dim name As String = dt.Rows(0)("Fullname").ToString
                Dim type As String = dt.Rows(0)("UserType").ToString
                Dim sql As String = "insert into tblUsersLog values('" & logID & "', '" & id & "', '" & name & "', '" & type & "', '" & Today & "', '" & FormatDateTime(Now, DateFormat.LongTime) & "', 'in')"
                ExecuteSQLQuery(sql)
            End If
        End If
        Return allowed
    End Function
    Public Sub doLogin()
        If txtUsername.Text <> "" Then
            If txtPassword.Text <> "" Then
                If checkExistence("select * from tblUsers where Username='" & txtUsername.Text.Replace("'", "`") & "'") Then
                    If checkExistence("select * from tblUsers where Username='" & txtUsername.Text.Replace("'", "`") & "' and Password='" & MD5(txtPassword.Text) & "' ") Then
                        If checkExistence("select * from tblUsers where Username='" & txtUsername.Text.Replace("'", "`") & "' and Password='" & MD5(txtPassword.Text) & "' ") Then
                            If checkExistence("select * from tblCurrentlyLoginUser where Username='" & txtUsername.Text.Replace("'", "`") & "'") Then
                                MsgBox("Username is currently Login.", MsgBoxStyle.Exclamation)
                            Else
                                Dim sql As String = "insert into tblCurrentlyLoginUser values('" & txtUsername.Text.Replace("'", "`") & "')"
                                ExecuteSQLQuery(sql)
                                MsgBox("User authenticated, Welcome " & txtUsername.Text, MsgBoxStyle.Information)
                                Dim userID As String = putSingleValue("select UserID from tblUsers where Username='" & txtUsername.Text.Replace("'", "`") & "' and Password='" & MD5(txtPassword.Text) & "'")
                                Dim userTpye As String = putSingleValue("select UserType from tblUsers where Username='" & txtUsername.Text & "'")
                                If logUser(userID) Then
                                    setupProductPrice() 'using FIFO
                                    If userTpye = "Administrator" Then
                                        Me.Hide()
                                        frmMain.Show()
                                        frmMain.lblFullname.Text = putSingleValue("select Fullname from tblUsers where Username='" & txtUsername.Text.Replace("'", "`") & "' and Password='" & MD5(txtPassword.Text) & "'")
                                        frmMain.lblType.Text = userTpye
                                        frmMain.lblUserID.Text = userID
                                        frmPOS.lblFullname.Text = putSingleValue("select Fullname from tblUsers where Username='" & txtUsername.Text.Replace("'", "`") & "' and Password='" & MD5(txtPassword.Text) & "'")
                                        frmPOS.lblType.Text = userTpye
                                        frmPOS.lblUserID.Text = userID
                                        updateInventory()
                                    ElseIf userTpye = "Cashier" Then
                                        MsgBox("You are allowed to open the Sales Master Module only as cashier.", MsgBoxStyle.Exclamation)
                                        Me.Hide()
                                        frmPOS.Show()
                                        frmPOS.lblFullname.Text = putSingleValue("select Fullname from tblUsers where Username='" & txtUsername.Text.Replace("'", "`") & "' and Password='" & MD5(txtPassword.Text) & "'")
                                        frmPOS.lblType.Text = userTpye
                                        frmPOS.lblUserID.Text = userID
                                        updateInventory()
                                    End If
                                Else
                                    Me.Hide()
                                    frmMain.Show()
                                    'frmMain.pbImage.BackgroundImage = putImage("select UserImage from tblUserImage where UserID='" & userID & "'")
                                    frmMain.lblFullname.Text = putSingleValue("select Fullname from tblUsers where Username='" & txtUsername.Text.Replace("'", "`") & "' and Password='" & MD5(txtPassword.Text) & "'")
                                    frmMain.lblType.Text = userTpye
                                    frmMain.lblUserID.Text = userID
                                    updateInventory()
                                    ' MsgBox("You are currently logged in to the system, you cannot perform another login.", MsgBoxStyle.Critical)
                                End If

                            End If
                        Else
                            MsgBox("Invalid user account.", MsgBoxStyle.Critical)
                            ctr -= 1

                        End If
                    Else
                        MsgBox("Invalid Username/Password!", MsgBoxStyle.Critical)
                        txtPassword.Focus()
                        txtPassword.SelectAll()
                        ctr -= 1
                    End If
                Else
                    MsgBox("Invalid Username/Password!", MsgBoxStyle.Critical)
                    txtUsername.Focus()
                    txtUsername.SelectAll()
                    ctr -= 1
                End If
                If ctr = 0 Then
                    MsgBox("You have reached maximum tries to log in, System will terminate!", MsgBoxStyle.Critical)
                    Me.Close()
                End If

            Else
                MsgBox("Provide password before you continue.", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Provide Username before you continue.", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        doLogin()
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            doLogin()
        End If
    End Sub

    Private Sub txtUsername_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsername.KeyPress
        AcceptLettersKeyPress(e)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            doLogin()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class