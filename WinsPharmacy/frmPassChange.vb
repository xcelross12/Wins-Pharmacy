Public Class frmPassChange
    Dim userID As String
    Dim mode As String
  
    Public Sub New(ByVal str As String, ByVal id As String, ByVal m_mode As String)
        InitializeComponent()
        lblTag.Text = str
        userID = id
        mode = m_mode
    End Sub
    Public Sub doSubmit()
        If mode = "previous" Then
            If checkExistence("select * from tblUsers where UserID='" & userID & "' and Password='" & MD5(txtString.Text) & "'") = True Then
                Dim dialog As New frmPassChange("Provide new Password.", userID, "new")
                dialog.Show()
                Me.Close()
            Else
                MsgBox("Invalid Password!", MsgBoxStyle.Critical)
                Me.Close()
            End If
        ElseIf mode = "new" Then
            If txtString.Text <> "" Then
                Dim sql As String = "update tblUsers set Password='" & MD5(txtString.Text) & "' where UserID='" & userID & "'"
                ExecuteSQLQuery(sql)
                MsgBox("Password successfully changed.", MsgBoxStyle.Information)
                Me.Close()
            Else
                MsgBox("Empty password is not allowed!", MsgBoxStyle.Exclamation)
                txtString.Focus()
            End If
        End If
    End Sub
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        doSubmit()
    End Sub

    Private Sub txtString_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtString.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            doSubmit()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class