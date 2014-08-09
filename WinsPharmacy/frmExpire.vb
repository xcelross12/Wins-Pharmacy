Public Class frmExpire
    Dim sql As String = ""
    Dim blinkSign As Integer = 0

    Private Sub frmCritical_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
        CheckBox2.Checked = False
    End Sub
    Private Sub frmCritical_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loadExpire()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If blinkSign = 3 Then
            lblWarning.Visible = False
            blinkSign = 0
        Else
            lblWarning.Visible = True
            blinkSign += 1
        End If
    End Sub
    Public Sub loadExpire()
        Dim dt As DataTable = ExecuteQuery("Select * from tblProducts where ExpirationDate between '" & Today & "' and '" & Today.AddDays(30) & "' ")
        FillListView(dt, lvExpire)
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        ExecuteQuery("delete from tblProducts where ProductCode = '" & lvExpire.SelectedItems(0).SubItems(0).Text & "'")
        ExecuteQuery("delete from tblRunningInventory where ProductCode = '" & lvExpire.SelectedItems(0).SubItems(0).Text & "'")
        loadExpire()
    End Sub

    Private Sub frmExpire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadExpire()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            For i As Integer = 0 To lvExpire.Items.Count - 1
                lvExpire.Items(i).Checked = True
            Next
        Else
            For i As Integer = 0 To lvExpire.Items.Count - 1
                lvExpire.Items(i).Checked = False
            Next
        End If
    End Sub
End Class