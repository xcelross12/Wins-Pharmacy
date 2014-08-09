Imports System.Drawing
Imports System.Diagnostics

Public NotInheritable Class Code128Rendering

#Region "Code patterns"
    Private Shared ReadOnly cPatterns As Integer(,) = {{2, 1, 2, 2, 2, 2, _
     0, 0}, {2, 2, 2, 1, 2, 2, _
     0, 0}, {2, 2, 2, 2, 2, 1, _
     0, 0}, {1, 2, 1, 2, 2, 3, _
     0, 0}, {1, 2, 1, 3, 2, 2, _
     0, 0}, {1, 3, 1, 2, 2, 2, _
     0, 0}, _
     {1, 2, 2, 2, 1, 3, _
     0, 0}, {1, 2, 2, 3, 1, 2, _
     0, 0}, {1, 3, 2, 2, 1, 2, _
     0, 0}, {2, 2, 1, 2, 1, 3, _
     0, 0}, {2, 2, 1, 3, 1, 2, _
     0, 0}, {2, 3, 1, 2, 1, 2, _
     0, 0}, _
     {1, 1, 2, 2, 3, 2, _
     0, 0}, {1, 2, 2, 1, 3, 2, _
     0, 0}, {1, 2, 2, 2, 3, 1, _
     0, 0}, {1, 1, 3, 2, 2, 2, _
     0, 0}, {1, 2, 3, 1, 2, 2, _
     0, 0}, {1, 2, 3, 2, 2, 1, _
     0, 0}, _
     {2, 2, 3, 2, 1, 1, _
     0, 0}, {2, 2, 1, 1, 3, 2, _
     0, 0}, {2, 2, 1, 2, 3, 1, _
     0, 0}, {2, 1, 3, 2, 1, 2, _
     0, 0}, {2, 2, 3, 1, 1, 2, _
     0, 0}, {3, 1, 2, 1, 3, 1, _
     0, 0}, _
     {3, 1, 1, 2, 2, 2, _
     0, 0}, {3, 2, 1, 1, 2, 2, _
     0, 0}, {3, 2, 1, 2, 2, 1, _
     0, 0}, {3, 1, 2, 2, 1, 2, _
     0, 0}, {3, 2, 2, 1, 1, 2, _
     0, 0}, {3, 2, 2, 2, 1, 1, _
     0, 0}, _
     {2, 1, 2, 1, 2, 3, _
     0, 0}, {2, 1, 2, 3, 2, 1, _
     0, 0}, {2, 3, 2, 1, 2, 1, _
     0, 0}, {1, 1, 1, 3, 2, 3, _
     0, 0}, {1, 3, 1, 1, 2, 3, _
     0, 0}, {1, 3, 1, 3, 2, 1, _
     0, 0}, _
     {1, 1, 2, 3, 1, 3, _
     0, 0}, {1, 3, 2, 1, 1, 3, _
     0, 0}, {1, 3, 2, 3, 1, 1, _
     0, 0}, {2, 1, 1, 3, 1, 3, _
     0, 0}, {2, 3, 1, 1, 1, 3, _
     0, 0}, {2, 3, 1, 3, 1, 1, _
     0, 0}, _
     {1, 1, 2, 1, 3, 3, _
     0, 0}, {1, 1, 2, 3, 3, 1, _
     0, 0}, {1, 3, 2, 1, 3, 1, _
     0, 0}, {1, 1, 3, 1, 2, 3, _
     0, 0}, {1, 1, 3, 3, 2, 1, _
     0, 0}, {1, 3, 3, 1, 2, 1, _
     0, 0}, _
     {3, 1, 3, 1, 2, 1, _
     0, 0}, {2, 1, 1, 3, 3, 1, _
     0, 0}, {2, 3, 1, 1, 3, 1, _
     0, 0}, {2, 1, 3, 1, 1, 3, _
     0, 0}, {2, 1, 3, 3, 1, 1, _
     0, 0}, {2, 1, 3, 1, 3, 1, _
     0, 0}, _
     {3, 1, 1, 1, 2, 3, _
     0, 0}, {3, 1, 1, 3, 2, 1, _
     0, 0}, {3, 3, 1, 1, 2, 1, _
     0, 0}, {3, 1, 2, 1, 1, 3, _
     0, 0}, {3, 1, 2, 3, 1, 1, _
     0, 0}, {3, 3, 2, 1, 1, 1, _
     0, 0}, _
     {3, 1, 4, 1, 1, 1, _
     0, 0}, {2, 2, 1, 4, 1, 1, _
     0, 0}, {4, 3, 1, 1, 1, 1, _
     0, 0}, {1, 1, 1, 2, 2, 4, _
     0, 0}, {1, 1, 1, 4, 2, 2, _
     0, 0}, {1, 2, 1, 1, 2, 4, _
     0, 0}, _
     {1, 2, 1, 4, 2, 1, _
     0, 0}, {1, 4, 1, 1, 2, 2, _
     0, 0}, {1, 4, 1, 2, 2, 1, _
     0, 0}, {1, 1, 2, 2, 1, 4, _
     0, 0}, {1, 1, 2, 4, 1, 2, _
     0, 0}, {1, 2, 2, 1, 1, 4, _
     0, 0}, _
     {1, 2, 2, 4, 1, 1, _
     0, 0}, {1, 4, 2, 1, 1, 2, _
     0, 0}, {1, 4, 2, 2, 1, 1, _
     0, 0}, {2, 4, 1, 2, 1, 1, _
     0, 0}, {2, 2, 1, 1, 1, 4, _
     0, 0}, {4, 1, 3, 1, 1, 1, _
     0, 0}, _
     {2, 4, 1, 1, 1, 2, _
     0, 0}, {1, 3, 4, 1, 1, 1, _
     0, 0}, {1, 1, 1, 2, 4, 2, _
     0, 0}, {1, 2, 1, 1, 4, 2, _
     0, 0}, {1, 2, 1, 2, 4, 1, _
     0, 0}, {1, 1, 4, 2, 1, 2, _
     0, 0}, _
     {1, 2, 4, 1, 1, 2, _
     0, 0}, {1, 2, 4, 2, 1, 1, _
     0, 0}, {4, 1, 1, 2, 1, 2, _
     0, 0}, {4, 2, 1, 1, 1, 2, _
     0, 0}, {4, 2, 1, 2, 1, 1, _
     0, 0}, {2, 1, 2, 1, 4, 1, _
     0, 0}, _
     {2, 1, 4, 1, 2, 1, _
     0, 0}, {4, 1, 2, 1, 2, 1, _
     0, 0}, {1, 1, 1, 1, 4, 3, _
     0, 0}, {1, 1, 1, 3, 4, 1, _
     0, 0}, {1, 3, 1, 1, 4, 1, _
     0, 0}, {1, 1, 4, 1, 1, 3, _
     0, 0}, _
     {1, 1, 4, 3, 1, 1, _
     0, 0}, {4, 1, 1, 1, 1, 3, _
     0, 0}, {4, 1, 1, 3, 1, 1, _
     0, 0}, {1, 1, 3, 1, 4, 1, _
     0, 0}, {1, 1, 4, 1, 3, 1, _
     0, 0}, {3, 1, 1, 1, 4, 1, _
     0, 0}, _
     {4, 1, 1, 1, 3, 1, _
     0, 0}, {2, 1, 1, 4, 1, 2, _
     0, 0}, {2, 1, 1, 2, 1, 4, _
     0, 0}, {2, 1, 1, 2, 3, 2, _
     0, 0}, {2, 3, 3, 1, 1, 1, _
     2, 0}}

#End Region

    Private Const cQuietWidth As Integer = 10

    Public Shared Function MakeBarcodeImage(ByVal InputData As String, ByVal BarWeight As Integer, ByVal AddQuietZone As Boolean) As Image

        Dim content As New Code128Content(InputData)
        Dim codes As Integer() = content.Codes
        Dim width As Integer, height As Integer
        width = ((codes.Length - 3) * 11 + 35) * BarWeight
        height = Convert.ToInt32(System.Math.Ceiling(Convert.ToSingle(width) * 0.15F))

        If AddQuietZone Then
            width += 2 * cQuietWidth * BarWeight
        End If

        Dim myimg As Image = New System.Drawing.Bitmap(width, height)
        Using gr As Graphics = Graphics.FromImage(myimg)

            gr.FillRectangle(System.Drawing.Brushes.White, 0, 0, width, height)

            Dim cursor As Integer = If(AddQuietZone, cQuietWidth * BarWeight, 0)

            For codeidx As Integer = 0 To codes.Length - 1
                Dim code As Integer = codes(codeidx)

                For bar As Integer = 0 To 7 Step 2
                    Dim barwidth As Integer = cPatterns(code, bar) * BarWeight
                    Dim spcwidth As Integer = cPatterns(code, bar + 1) * BarWeight

                    If barwidth > 0 Then
                        gr.FillRectangle(System.Drawing.Brushes.Black, cursor, 0, barwidth, height)
                    End If

                    cursor += (barwidth + spcwidth)
                Next
            Next
        End Using

        Return myimg

    End Function

End Class