Public Class frmSalesReturn
    Private Sub txtSalesID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSalesID.TextChanged
        If checkExistence("select * from tblSalesMaster where SalesID='" & txtSalesID.Text & "'") Then
            loadSales(txtSalesID.Text)
        Else
            lvDeffective.Items.Clear()
            lvDetails.Items.Clear()
            lvItems.Items.Clear()
            countDeffective()
            countTotal()
        End If
    End Sub
    Public Sub loadSales(ByVal id As String)
        Dim dt As DataTable = ExecuteSQLQuery("select TransDate as [Trans Date], Subtotal, CashAmount as [Cash], Change, Fullname, UserID from tblSalesMaster where SalesID='" & id & "'")
        If dt.Rows.Count = 1 Then
            lvDetails.Items.Clear()
            For i As Integer = 0 To 4
                Dim item As New ListViewItem
                item.Text = dt.Columns(i).ColumnName

                Dim value As String = ""
                Select Case i
                    Case 0
                        value = FormatDateTime(CDate(dt.Rows(0)(i).ToString), DateFormat.ShortDate)
                    Case 4
                        value = dt.Rows(0)(i).ToString & "  [ID=" & dt.Rows(0)(i + 1).ToString & "]"
                    Case Else
                        value = FormatNumber(Val(dt.Rows(0)(i).ToString), 2, TriState.True)
                End Select
                item.SubItems.Add(":  " & value)
                lvDetails.Items.Add(item)
            Next
            loadPurchaseRecord(id)
            loadDeffective(id)

            Dim transDate As Date = CDate(dt.Rows(0)("Trans Date"))
            If DateDiff(DateInterval.Day, transDate, Today) > 3 Then    'replace only
                MessageBox.Show("Warranty is already finish!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                lvDeffective.Clear()
                lvDetails.Clear()
                lvItems.Clear()
            Else    'replace or repair
                lblMode.Text = "REPLACE"
            End If
        End If
    End Sub
    Public Sub loadPurchaseRecord(ByVal SalesID As String)
        lvItems.Items.Clear()
        Dim dt As New DataTable
        dt = ExecuteSQLQuery("select * from tblSalesDetails where SalesID='" & SalesID & "'")
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
        countTotal()
    End Sub
    Public Sub loadDeffective(ByVal SalesID As String)
        lvDeffective.Items.Clear()
        Dim dt As New DataTable
        dt = ExecuteSQLQuery("select * from tblSalesReturns where SalesID='" & SalesID & "'")
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim lItem As New ListViewItem
            Dim code As String = dt.Rows(i)("ProductCode").ToString
            lItem.Text = code
            lItem.SubItems.Add(dt.Rows(i)("ProductName").ToString)
            lItem.SubItems.Add(dt.Rows(i)("Quantity").ToString)
            'lItem.SubItems.Add(putSingleNumber("select UnitPrice from tblProducts where ProductCode='" & code & "'"))
            lItem.SubItems.Add(dt.Rows(i)("Price").ToString)
            lItem.SubItems.Add(dt.Rows(i)("Total").ToString)
            lvDeffective.Items.Add(lItem)
        Next
        countDeffective()
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
    Public Sub countDeffective()
        Dim total As Double = 0.0
        For i As Integer = 0 To lvDeffective.Items.Count - 1
            total += Val(lvDeffective.Items(i).SubItems(4).Text)
        Next
        If total = 0.0 Then
            lblDeffTotal.Text = "0.00"
        Else
            lblDeffTotal.Text = Format(total, "####.00")
        End If

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        For i As Integer = 0 To lvItems.SelectedItems.Count - 1
            Dim item As New ListViewItem
            item = lvItems.SelectedItems(i).Clone

            If isThere(item.Text) = False Then
                Dim prevCount As Double = Val(item.SubItems(2).Text)
                Dim count As String = InputBox("Product: " & item.SubItems(1).Text & vbCrLf & "No. of sold items: " & prevCount & vbCrLf & vbCrLf & "How many items are deffective?", "Deffective Items", prevCount)
                Try
                    If count <> "" Then
                        Dim newCount As Double = Double.Parse(count)
                        If newCount >= 1 And newCount <= prevCount Then
                            item.SubItems(2).Text = newCount
                            Dim newTotal As Double = newCount * Val(item.SubItems(3).Text)
                            item.SubItems(4).Text = newTotal
                            lvDeffective.Items.Add(item)
                        Else
                            MsgBox("You provided incorrect number of items.", MsgBoxStyle.Exclamation)
                        End If
                    End If
                Catch ex As Exception
                    MsgBox("Invalid input!", MsgBoxStyle.Critical)
                End Try
            Else
                MsgBox(item.SubItems(1).Text & " already exists in the deffective list.", MsgBoxStyle.Exclamation)
            End If
        Next
        countDeffective()
    End Sub
    Public Function isThere(ByVal code As String) As Boolean
        Dim ans As Boolean = False
        For i As Integer = 0 To lvDeffective.Items.Count - 1
            If lvDeffective.Items(i).Text = code Then
                ans = True
                Exit For
            End If
        Next
        Return ans
    End Function

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If MsgBox("You are about to remove " & lvDeffective.SelectedItems.Count & " record, proceed?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm remove") = MsgBoxResult.Yes Then
            Dim list As New ArrayList
            For i As Integer = 0 To lvDeffective.Items.Count - 1
                list.Add(lvDeffective.Items(i))
            Next
            For i As Integer = 0 To lvDeffective.SelectedItems.Count - 1
                list.Remove(lvDeffective.SelectedItems(i))
            Next
            lvDeffective.Items.Clear()
            For i As Integer = 0 To list.Count - 1
                Dim item As New ListViewItem
                item = list.Item(i)
                lvDeffective.Items.Add(item)
            Next
            countDeffective()
        End If
    End Sub

    Private Sub btnFinalize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalize.Click
        If MsgBox("Do you really want to save the changes?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm details") = MsgBoxResult.Yes Then
            For i As Integer = 0 To lvDeffective.Items.Count - 1
                With lvDeffective.Items(i)
                    Dim id As String = txtSalesID.Text
                    Dim code As String = .Text
                    Dim name As String = .SubItems(1).Text
                    Dim qty As Double = Val(.SubItems(2).Text)
                    Dim price As Double = Val(.SubItems(3).Text)
                    Dim total As Double = Val(.SubItems(4).Text)
                    Dim supplier As String = putSingleValue("select Supplier from tblProducts where ProductCode='" & code & "'")
                    Try
                        Dim itemCount As Double
                        Dim DailyInventory As Double = putSingleValue("select EndInv from tblRunningInventory where ProductCode = '" & lvItems.SelectedItems(0).Text & "'")
                        Dim EndInv As Double = putSingleValue("select EndInv from tblRunningInventory where ProductCode = '" & code & "'")

                        If Val(qty) >= Val(EndInv) Then
                            MsgBox("Item " + name + " is Out of Stock", MsgBoxStyle.Critical)

                        ElseIf Val(qty) > Val(EndInv) Then
                            sql = "insert into tblSalesReturns values('" & id & "', '" & code & "', '" & name & "', " & itemCount & ", " & price & ", " & total & ", '" & supplier & "', '" & FormatDateTime(Now, DateFormat.GeneralDate) & "', 'REPLACE')"
                            ExecuteSQLQuery(sql)
                            decreaseStock(code, itemCount)
                            updateSingleSellingPrice(code)
                            price = putSingleNumber("select UnitPrice from tblProducts where ProductCode='" & code & "'")
                            sql = "insert into tblSalesReturns values('" & id & "', '" & code & "', '" & name & "', " & (qty - itemCount) & ", " & price & ", " & total & ", '" & supplier & "', '" & FormatDateTime(Now, DateFormat.GeneralDate) & "', 'REPLACE')"
                            ExecuteSQLQuery(sql)
                            decreaseStock(code, (qty - itemCount))
                            sql = "update tblRunningInventory set EndInv=EndInv - " & qty & " where ProductCode = '" & code & "'"

                            sql = "update tblRunningInventory set SalesReturns=SalesReturns + " & qty & " where ProductCode = '" & code & "'"
                            ExecuteSQLQuery(sql)
                        Else
                            sql = "insert into tblSalesReturns values('" & id & "', '" & code & "', '" & name & "', " & qty & ", " & price & ", " & total & ", '" & supplier & "', '" & FormatDateTime(Now, DateFormat.GeneralDate) & "', 'REPLACE')"
                            ExecuteSQLQuery(sql)
                            sql = "update tblRunningInventory set SalesReturns=SalesReturns + " & qty & " where ProductCode = '" & code & "'"
                            ExecuteSQLQuery(sql)
                            decreaseStock(code, qty)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Cannot Save! Saved Deffective Products Must not Removed!")
                    End Try
                End With
            Next
            ExecuteSQLQuery("update tblUpdateCommand set UpdateCommand = UpdateCommand +1")
            MsgBox("Changes were successfully saved!", MsgBoxStyle.Information)
            txtSalesID.Text = ""
        End If
    
    End Sub

    Private Sub frmSalesReturn_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmSalesReturnsLogs.ShowDialog()
    End Sub
End Class