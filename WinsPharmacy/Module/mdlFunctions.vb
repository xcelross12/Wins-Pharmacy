Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Threading
Imports System
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.Exception

Module mdlFunctions
    Public conn As SqlConnection = New SqlConnection(My.Settings.wins)
    Public sql As String = ""
    Public username As String = ""
    Public Const VAT_RATE As Double = 0.12
    Public selectedProduct As String = ""
    Public productForPricing As String = ""
    Public productForSupplier As String = ""
    Public productForSales As String = ""
    Public productForStackView As String = ""
    Public signalForChangeSupp As String = ""
    Public purchaseIDForConfirmation As String = ""
    Public purchaseIDForPrintingPO As String = ""
    Public lvChoose As String = ""
    Public prevSellingPriceAndCode As String = ""

    Public Const InventoryValuation As String = "FIFO"

    Public Class RegexUtilities
        Dim invalid As Boolean = False

        Public Function IsValidEmail(ByVal strIn As String) As Boolean
            invalid = False
            If String.IsNullOrEmpty(strIn) Then Return False

            ' Use IdnMapping class to convert Unicode domain names.
            strIn = Regex.Replace(strIn, "(@)(.+)$", AddressOf Me.DomainMapper)
            If invalid Then Return False

            ' Return true if strIn is in valid e-mail format. 
            Return Regex.IsMatch(strIn, _
                   "^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + _
                   "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$",
                   RegexOptions.IgnoreCase)
        End Function

        Private Function DomainMapper(ByVal match As Match) As String
            Dim idn As New IdnMapping()

            Dim domainName As String = match.Groups(2).Value
            Try
                domainName = idn.GetAscii(domainName)
            Catch e As ArgumentException
                invalid = True
            End Try
            Return match.Groups(1).Value + domainName
        End Function
    End Class
    Public Sub setupProductPrice()
        If InventoryValuation = "FIFO" Then
            Dim dt As DataTable = ExecuteSQLQuery("select * from tblProducts")
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim pCode As String = dt.Rows(i)("ProductCode").ToString
                Dim dt2 As DataTable = ExecuteSQLQuery("select * from tblPriceStack where ProductCode='" & pCode & "' and Quantity<>0 order by DateReceived")
                If dt2.Rows.Count >= 1 Then
                    Dim currPrice As Double = Val(dt2.Rows(0)("SupplierPrice").ToString)
                    Dim profit As Double = putSingleNumber("select Profit from tblPriceProfit where ProductCode='" & pCode & "'")
                    Dim currSellingPrice As Double = Format((currPrice * profit) + (currPrice), "####.00")
                    ExecuteSQLQuery("update tblProducts set UnitPrice=" & currSellingPrice & " where ProductCode='" & pCode & "'")
                End If
            Next
        End If
    End Sub
    Public Function getCountOfCurrentStack(ByVal code As String) As Double
        Dim count As Double = 0.0
        Dim dt2 As DataTable = ExecuteSQLQuery("select * from tblPriceStack where ProductCode='" & code & "' and Quantity<>0 order by DateReceived")
        If dt2.Rows.Count >= 1 Then
            count = Val(dt2.Rows(0)("Quantity").ToString)
        End If
        Return count
    End Function
    Public Function getIDOfCurrentStack(ByVal code As String) As Integer
        Dim id As Integer = 0
        Dim dt As DataTable = ExecuteSQLQuery("select * from tblPriceStack where ProductCode='" & code & "' and Quantity<>0 order by DateReceived")
        If dt.Rows.Count >= 1 Then
            id = Val(dt.Rows(0)(0).ToString)
        End If
        Return id
    End Function
    Public Sub updateSingleSellingPrice(ByVal code As String)
        Dim dt2 As DataTable = ExecuteSQLQuery("select * from tblPriceStack where ProductCode='" & code & "' and Quantity<>0 order by DateReceived")
        If dt2.Rows.Count >= 1 Then
            Dim currPrice As Double = Val(dt2.Rows(0)("SupplierPrice").ToString)
            Dim profit As Double = putSingleNumber("select Profit from tblPriceProfit where ProductCode='" & code & "'")
            Dim currSellingPrice As Double = Format((currPrice * profit + (currPrice)), "####.00")
            ExecuteSQLQuery("update tblProducts set UnitPrice=" & currSellingPrice & " where ProductCode='" & code & "'")
        End If
    End Sub
    Public Sub decreaseStock(ByVal code As String, ByVal qty As Double)
        Dim dt2 As DataTable = ExecuteSQLQuery("select * from tblPriceStack where ProductCode='" & code & "' and Quantity<>0 order by DateReceived")
        If dt2.Rows.Count >= 1 Then
            ExecuteSQLQuery("update tblPriceStack set Quantity=Quantity - " & qty & " where ProductCode='" & code & "' and RecordID=" & getIDOfCurrentStack(code) & "")
        End If
    End Sub
    Public Function checkProductExistence(ByVal code As String) As Boolean
        checkProductExistence = checkExistence("select * from tblProducts where ProductCode='" & code & "'")
    End Function

    Public Function getSupplierPricePreferred(ByVal code As String) As Double
        Dim price As Double = 0.0
        Dim dt As DataTable = ExecuteSQLQuery("select * from tblProductSupplier where ProductCode='" & code & "'")
        If dt.Rows.Count = 1 Then
            For i As Integer = 1 To dt.Columns.Count - 1
                If dt.Rows(0)(i).ToString <> "" Then
                    Dim detail() As String = dt.Rows(0)(i).ToString.Split("|")
                    If detail(2) = "True" Then
                        price = Format(Val(detail(1)), "####.00")
                        Exit For
                    End If
                End If
            Next
        End If
        Return price
    End Function
    Public Function getSupplierPrice(ByVal code As String, ByVal suppID As String) As Double
        Dim price As Double = 0.0
        Dim dt As DataTable = ExecuteSQLQuery("select * from tblProductSupplier where ProductCode='" & code & "'")
        If dt.Rows.Count = 1 Then
            For i As Integer = 1 To dt.Columns.Count - 1
                If dt.Rows(0)(i).ToString <> "" Then
                    Dim detail() As String = dt.Rows(0)(i).ToString.Split("|")
                    If detail(0) = suppID Then
                        price = Format(Val(detail(1)), "####.00")
                        Exit For
                    End If
                End If
            Next
        End If
        Return price
    End Function
    Public Sub adjustInventory()
        If checkExistence("select * from tblRunningInventory") Then
            Dim invDate As Date = CDate(putSingleValue("select top 1 Date from tblRunningInventory"))
            If invDate <> Today Then
                If Date.Compare(Today, invDate) > 0 Then
                    sql = "update tblRunningInventory set BegInv=BegInv, Delivery=Delivery, Sales=Sales, SalesReturns=SalesReturns, Date='" & Today & "'"
                    ExecuteSQLQuery(sql)
                    updateInventory()
                End If
            End If
            If Date.Today.Day = "1" Then
                sql = "update tblRunningInventory set BegInv=EndInv, Delivery=0, Sales=0, SalesReturns=0, Date='" & Today & "'"
                ExecuteSQLQuery(sql)
                updateInventory()
            End If
        End If

    End Sub
    Public Sub updateInventory()
        sql = "update tblRunningInventory set EndInv = BegInv + Delivery - Sales - SalesReturns"
        ExecuteSQLQuery(sql)
        Dim dt As New DataTable
        dt = ExecuteSQLQuery("select * from tblRunningInventory")
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim endInv As Double = Val(dt.Rows(i)("EndInv").ToString)
        Next
    End Sub
    Public Function getDataTable(ByVal sql As String, ByVal tbl As String) As DataTable
        Dim dt As New DataTable
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
                conn.Open()
            Else
                conn.Open()
            End If
            Dim da As SqlDataAdapter = New SqlDataAdapter(sql, conn)
            Dim ds As New DataSet
            da.Fill(ds, tbl)
            dt = ds.Tables(tbl)
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        Finally
            conn.Close()
        End Try
        Return dt
    End Function
    Public Function ExecuteSQLQuery(ByVal SQLQuery As String) As DataTable
        Dim sqlDT As New DataTable
        Try
            Dim sqlCon As New SqlConnection(My.Settings.wins)
            Dim sqlDA As New SqlDataAdapter(SQLQuery, sqlCon)
            Dim sqlCB As New SqlCommandBuilder(sqlDA)
            sqlDA.Fill(sqlDT)
        Catch ex As Exception
            MsgBox("Program Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
        Return sqlDT
    End Function
    Public Sub FillListView(ByVal sqlData As DataTable, ByVal lvList As ListView)
        lvList.Items.Clear()
        lvList.Columns.Clear()
        Dim i As Integer
        Dim j As Integer
        For i = 0 To sqlData.Columns.Count - 1
            lvList.Columns.Add(sqlData.Columns(i).ColumnName)
        Next i
        For i = 0 To sqlData.Rows.Count - 1
            lvList.Items.Add(sqlData.Rows(i).Item(0))
            For j = 1 To sqlData.Columns.Count - 1
                If Not IsDBNull(sqlData.Rows(i).Item(j)) Then
                    lvList.Items(i).SubItems.Add(sqlData.Rows(i).Item(j))
                Else
                    lvList.Items(i).SubItems.Add("")
                End If

            Next j
        Next i
        For i = 0 To sqlData.Columns.Count - 1
            lvList.Columns(i).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
        Next i
    End Sub
    Public Function doNonQuery(ByVal sql As String, Optional ByVal process As String = "") As Boolean
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
                conn.Open()
            Else
                conn.Open()
            End If
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            doNonQuery = True
        Catch ex As Exception
            doNonQuery = False
        Finally
            conn.Close()
        End Try
    End Function
    Public Function checkExistence(ByVal sql As String) As Boolean
        Dim ans As Boolean = False
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
                conn.Open()
            Else
                conn.Open()
            End If
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            If rdr.Read Then
                ans = True
            End If
        Catch ex As Exception
            MsgBox("Error on(checkExistence): " & ex.ToString)
        Finally
            conn.Close()
        End Try
        Return ans
    End Function
    Public Function putSingleValue(ByVal sql As String, Optional ByVal tbl As String = "") As String
        Dim result As String = ""
        Try
            If tbl <> "" Then
                Dim dt As DataTable = getDataTable(sql, tbl)
                If dt.Rows.Count <> 0 Then
                    If Not IsDBNull(dt.Rows(0)(0)) Then
                        result = dt.Rows(dt.Rows.Count - 1)(0)
                    End If
                End If
            Else
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                    conn.Open()
                Else
                    conn.Open()
                End If
                Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                Dim rdr As SqlDataReader = cmd.ExecuteReader
                If rdr.Read Then
                    If Not IsDBNull(rdr(0)) Then
                        result = rdr(0)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error 1: " & ex.ToString)
            result = ""
        Finally
            conn.Close()
        End Try
        Return result
    End Function
    Public Function putSingleNumber(ByVal sql As String, Optional ByVal tbl As String = "") As Double
        Dim result As Double = 0
        Try
            If tbl <> "" Then
                Dim dt As DataTable = getDataTable(sql, tbl)
                If dt.Rows.Count <> 0 Then
                    If Not IsDBNull(dt.Rows(0)(0)) Then
                        result = Val(dt.Rows(dt.Rows.Count - 1)(0))
                    End If
                End If
            Else
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                    conn.Open()
                Else
                    conn.Open()
                End If
                Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                Dim rdr As SqlDataReader = cmd.ExecuteReader
                If rdr.Read Then
                    If Not IsDBNull(rdr(0)) Then
                        result = Val(rdr(0))
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Error 1: " & ex.ToString)
        Finally
            conn.Close()
        End Try
        Return result
    End Function

    Public Sub fillComboBox(ByVal dt As DataTable, ByVal cb As ComboBox)
        cb.Items.Clear()
        For row As Integer = 0 To dt.Rows.Count - 1
            cb.Items.Add(dt.Rows(row)(0))
        Next
    End Sub
    Public Sub fillItems(ByVal colName As String, ByVal cb As ComboBox)
        Dim sql As String = "select " & colName & " from tblProducts"
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
                conn.Open()
            Else
                conn.Open()
            End If
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            While rdr.Read
                cb.Items.Add(rdr(0).ToString)
            End While
            rdr.Close()
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub fillListview(ByVal sql As String, ByVal lv As ListView)
        Dim dt As New DataTable
        lv.Items.Clear()
        lv.Columns.Clear()
        dt = ExecuteSQLQuery(sql)
        For x As Integer = 0 To dt.Columns.Count - 1
            lv.Columns.Add(dt.Columns.Item(x).ColumnName)
        Next
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                lv.Items.Add(dt.Rows(i).Item(0).ToString)
                For j = 1 To dt.Columns.Count - 1
                    lv.Items(i).SubItems.Add(dt.Rows(i).Item(j).ToString)
                Next j
            Next i
        End If
    End Sub
    Public Sub fillItems2(ByVal sql As String, ByVal cb As ComboBox)
        Dim dt As DataTable = ExecuteSQLQuery(sql)
        cb.Items.Clear()
        For i As Integer = 0 To dt.Rows.Count - 1
            cb.Items.Add(dt.Rows(i)(0).ToString)
        Next
    End Sub
    Public Sub fillAutoCompleteSource(ByVal colName As String, ByVal cb As ComboBox)
        Dim sql As String = "select " & colName & " from tblProducts"
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
                conn.Open()
            Else
                conn.Open()
            End If
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            While rdr.Read
                cb.AutoCompleteCustomSource.Add(rdr(0).ToString)
            End While
            rdr.Close()
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Function check(ByVal info As String, ByVal field As String, ByVal tbl As String, Optional ByVal cndxn As String = "") As Boolean
        Dim answer As Boolean

        answer = False
        Dim sql As String
        sql = "select * from " & tbl & " where " & field & " = '" & info & "' " & cndxn
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
                conn.Open()
            Else
                conn.Open()
            End If
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            If rdr.Read Then
                answer = True
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString)
        Finally
            conn.Close()
        End Try

        Return answer
    End Function
    Public Sub AcceptNumbersKeyPress(ByVal objEvent As System.Windows.Forms.KeyPressEventArgs)
        If Not (Char.IsNumber(Convert.ToChar(objEvent.KeyChar)) Or objEvent.KeyChar = vbBack) Then
            objEvent.Handled = True
        End If
    End Sub
    Public Sub AcceptNumbersPeriodKeyPress(ByVal objEvent As System.Windows.Forms.KeyPressEventArgs)
        If Not (Char.IsNumber(Convert.ToChar(objEvent.KeyChar)) Or objEvent.KeyChar = "." Or objEvent.KeyChar = vbBack) Then
            objEvent.Handled = True
        End If
    End Sub
    Public Sub AcceptLettersKeyPress(ByVal objEvent As System.Windows.Forms.KeyPressEventArgs)
        If Not (Char.IsLetter(Convert.ToChar(objEvent.KeyChar)) Or objEvent.KeyChar = vbBack Or _
                Char.IsWhiteSpace(Convert.ToChar(objEvent.KeyChar)) Or objEvent.KeyChar = "-" Or objEvent.KeyChar = ".") Then
            objEvent.Handled = True
        End If
    End Sub
    Public Sub AcceptAlphaNumericKeyPress(ByVal objEvent As System.Windows.Forms.KeyPressEventArgs)
        If Not (Char.IsLetter(Convert.ToChar(objEvent.KeyChar)) Or objEvent.KeyChar = vbBack Or _
                Char.IsWhiteSpace(Convert.ToChar(objEvent.KeyChar)) Or objEvent.KeyChar = "-" Or _
                objEvent.KeyChar = "(" Or objEvent.KeyChar = ")" Or objEvent.KeyChar = "." Or objEvent.KeyChar = "," Or Char.IsNumber(Convert.ToChar(objEvent.KeyChar))) Then
            objEvent.Handled = True
        End If
    End Sub
    Public Sub AcceptNumbersPeriodKeyPressControlled(ByVal objEvent As System.Windows.Forms.KeyPressEventArgs, ByVal txt As System.Windows.Forms.TextBox)
        If Not (Char.IsNumber(Convert.ToChar(objEvent.KeyChar)) Or objEvent.KeyChar = "." Or objEvent.KeyChar = vbBack) Then
            objEvent.Handled = True
        Else
            If objEvent.KeyChar = "." Then
                If txt.Text.Contains(".") Then
                    objEvent.Handled = True
                End If
            ElseIf Char.IsNumber(Convert.ToChar(objEvent.KeyChar)) Then
                If txt.Text.Contains(".") Then
                    Dim strArray As String() = txt.Text.Split(".")
                    If strArray(1).Length = 2 Then
                        objEvent.Handled = True
                    End If
                End If
            End If
        End If
    End Sub
    Public Sub fillComboWithFields(ByVal sql As String, ByVal cb As ComboBox)
        Dim dt As DataTable = ExecuteSQLQuery(sql)
        cb.Items.Clear()
        For i As Integer = 0 To dt.Columns.Count - 1
            cb.Items.Add(dt.Columns(i).ColumnName)
        Next
    End Sub
    Public Function MD5(ByVal strToHash As String) As String
        Dim md5Obj As New Security.Cryptography.MD5CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = md5Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function
    Public Function putImage(ByVal sql As String) As Bitmap
        Dim finalPic As Bitmap = Nothing
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
                conn.Open()
            Else
                conn.Open()
            End If
            Dim cmd As SqlCommand = New SqlCommand(sql, conn)
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            If rdr.Read Then
                Dim imageBytes() As Byte = Nothing
                If Not IsDBNull(rdr(0)) Then
                    imageBytes = CType(rdr(0), Byte())
                    Dim ms As MemoryStream = New MemoryStream(imageBytes)
                    Dim bmap As Bitmap = New Bitmap(ms)
                    finalPic = bmap
                End If
            End If
        Catch ex As Exception
            MsgBox("Put Image Error: " & ex.Message)
        End Try
        Return finalPic
    End Function
    Public Function generateSalesID() As String
        Dim id As String = ""
        For i As Integer = 1 To 99999
            id = Format(Today, "MMddyy") & Format(i, "00000")
            If checkExistence("select * from tblSalesMaster where SalesID='" & id & "'") = False Then
                Exit For
            End If
        Next
        Return id
    End Function
    Public Function generatePurchaseID() As String
        Dim id As String = ""
        For i As Integer = 1 To 9999
            id = Format(Today, "MMddyy") & Format(i, "0000")
            If checkExistence("select * from tblPurchases where PurchaseID='" & id & "'") = False Then
                Exit For
            End If
        Next
        Return id
    End Function
    Public Sub resetBG()
        frmMain.BackgroundImage = putImage("select UserImage from BGimages where UserID=1")
    End Sub
    Public Sub selectAndAdjustSellingPrice(ByVal qtyToBeSold As Double, ByVal pCode As String)
        prevSellingPriceAndCode = putSingleNumber("select UnitPrice from tblProducts where ProductCode='" & pCode & "'") & "|" & pCode
        Dim dt As DataTable = ExecuteSQLQuery("select * from tblPriceStack where ProductCode='" & pCode & "' and Quantity<>0")
        Dim sum As Double = 0.0
        Dim highestPrice As Double = 0.0
        For i As Integer = 0 To dt.Rows.Count - 1
            sum += Val(dt.Rows(i)("Quantity").ToString)
            If Val(dt.Rows(i)("SupplierPrice").ToString) >= highestPrice Then
                highestPrice = Val(dt.Rows(i)("SupplierPrice").ToString)
            End If
            If sum >= qtyToBeSold Then
                Exit For
            End If
        Next
        Dim newUnitPrice As Double = putSingleNumber("select Profit from tblPriceProfit where ProductCode='" & pCode & "'") + highestPrice
        sql = "update tblProducts set UnitPrice=" & newUnitPrice & " where ProductCode='" & pCode & "'"
        ExecuteSQLQuery(sql)
    End Sub
End Module

