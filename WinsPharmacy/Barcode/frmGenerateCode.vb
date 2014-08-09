Public Class frmGenerateCode

    Dim printfont As New Font("Calibri", 12)
    Dim lineHeightSingle As Single = printfont.GetHeight + 2
    Dim horizontalPrintLocationSingle As Single
    Dim verticalPrintLocationSingle As Single
    Dim printLineString As String
    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        If btnGenerate.Text = "Generate" Then
            Dim dt As DataTable = ExecuteSQLQuery("select max(BarcodeNumber) from tblBarcode")
            Dim myChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
            Dim myID As String = Nothing '// used to add random char. until the preset ID length.
            Dim idLength As Integer = 8 '// allow a 8 char. Alphanumeric ID.
            Dim rnd As New Random '// for randomizing char.s.
            For i As Integer = 1 To idLength '// each loop adds 1 random char.
                myID &= myChars(rnd.Next(0, myChars.Length)) '// add random char. to String. ex: myChars(2) ='s "C".
            Next

            pbBarcode.Image = Code128Rendering.MakeBarcodeImage(myID, BarWeight:=1, AddQuietZone:=True)
            Label1.Text = myID
            btnGenerate.Text = "Use"
        ElseIf btnGenerate.Text = "Use" Then
            frmProducts.txtCode.Text = Label1.Text
            Me.Dispose()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        horizontalPrintLocationSingle = e.MarginBounds.Left
        verticalPrintLocationSingle = e.MarginBounds.Top
        horizontalPrintLocationSingle = 50
        Dim singlespacing As Single = 20
        Dim z As Integer
        z = 0

        verticalPrintLocationSingle = 60
        verticalPrintLocationSingle += z
        e.Graphics.DrawString(Label1.Text, printfont, Brushes.Black, horizontalPrintLocationSingle, verticalPrintLocationSingle)
        verticalPrintLocationSingle += singlespacing + 2
        e.Graphics.DrawImage(pbBarcode.Image, horizontalPrintLocationSingle, verticalPrintLocationSingle)
        verticalPrintLocationSingle += singlespacing + 2
        z += 100

    End Sub

    Private Sub frmGenerateCode_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class