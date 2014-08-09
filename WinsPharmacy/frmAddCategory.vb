Public Class frmAddCategory

    Dim DT As New DataTable

    Public Sub refreshlist()
        sql = "select * from tblCategory"
        DT = ExecuteSQLQuery(sql)
        FillListView(DT, lvCategory)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        DT = ExecuteSQLQuery("DELETE FROM tblCategory WHERE Category='" & lvCategory.SelectedItems(0).Text & "'")
        MessageBox.Show("Record Deleted!")
        lvCategory.SelectedItems(0).Remove()
        refreshlist()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim newCat As String = InputBox("Enter new Category for products.", "New Category")
        If newCat.Trim <> "" Then
            newCat = newCat.Replace("'", "`")
            If checkExistence("select * from tblCategory where Category='" & newCat & "'") = False Then
                sql = "insert into tblCategory values('" & newCat & "')"
                ExecuteSQLQuery(sql)
                MsgBox("Category successfully added.", MsgBoxStyle.Information)
                fillItems2("select Category from tblCategory", frmProducts.cbCategory)
                refreshlist()
                Me.Close()
            Else
                MsgBox("Category already exist", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub lvCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvCategory.SelectedIndexChanged
        With lvCategory.SelectedItems
            If .Count = 1 Then

                btnDelete.Enabled = True
            ElseIf .Count = 0 Then

                btnDelete.Enabled = False
            ElseIf .Count > 1 Then

                btnDelete.Enabled = True
            End If
        End With
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        FillListView("SELECT * from tblCategory where Category LIKE '%" & txtSearch.Text & "%'", lvCategory)
    End Sub

    Private Sub frmAddCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshlist()
    End Sub
End Class