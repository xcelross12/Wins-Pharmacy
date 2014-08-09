#Region " Class "

#Region " Enums "

Public Enum CodeSetAllowed
    CodeA
    CodeB
    CodeAorB
End Enum

Public Enum CodeSet
    CodeA
    CodeB
End Enum

#End Region

Public Class Code128Content
    Private mCodeList As Integer()

    Public Sub New(ByVal AsciiData As String)
        mCodeList = StringToCode128(AsciiData)
    End Sub

    Public ReadOnly Property Codes() As Integer()
        Get
            Return mCodeList
        End Get
    End Property

    Private Function StringToCode128(ByVal AsciiData As String) As Integer()

        Dim asciiBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(AsciiData)

        Dim csa1 As CodeSetAllowed = If(asciiBytes.Length > 0, Code128Code.CodesetAllowedForChar(asciiBytes(0)), CodeSetAllowed.CodeAorB)
        Dim csa2 As CodeSetAllowed = If(asciiBytes.Length > 0, Code128Code.CodesetAllowedForChar(asciiBytes(1)), CodeSetAllowed.CodeAorB)
        Dim currcs As CodeSet = GetBestStartSet(csa1, csa2)

        Dim codes As New List(Of Integer)(asciiBytes.Length + 3)
        codes.Add(Code128Code.StartCodeForCodeSet(currcs))

        For i As Integer = 0 To asciiBytes.Length - 1
            Dim thischar As Integer = asciiBytes(i)
            Dim nextchar As Integer = If(asciiBytes.Length > (i + 1), asciiBytes(i + 1), -1)

            codes.AddRange(Code128Code.CodesForChar(thischar, nextchar, currcs))
        Next

        Dim checksum As Integer = CInt(codes(0))
        For i As Integer = 1 To codes.Count - 1
            checksum += i * CInt(codes(i))
        Next

        codes.Add(checksum Mod 103)
        codes.Add(Code128Code.StopCode())

        Return codes.ToArray
    End Function

    Private Function GetBestStartSet(ByVal csa1 As CodeSetAllowed, ByVal csa2 As CodeSetAllowed) As CodeSet
        Dim vote As Integer = 0

        vote += If((csa1 = CodeSetAllowed.CodeA), 1, 0)
        vote += If((csa1 = CodeSetAllowed.CodeB), -1, 0)
        vote += If((csa2 = CodeSetAllowed.CodeA), 1, 0)
        vote += If((csa2 = CodeSetAllowed.CodeB), -1, 0)

        Return If((vote > 0), CodeSet.CodeA, CodeSet.CodeB)
    End Function
End Class

Public NotInheritable Class Code128Code

#Region "Constants"

    Private Const cSHIFT As Integer = 98
    Private Const cCODEA As Integer = 101
    Private Const cCODEB As Integer = 100

    Private Const cSTARTA As Integer = 103
    Private Const cSTARTB As Integer = 104
    Private Const cSTOP As Integer = 106

#End Region

    Public Shared Function CodesForChar(ByVal CharAscii As Integer, ByVal LookAheadAscii As Integer, ByRef CurrCodeSet As CodeSet) As Integer()
        Dim result As Integer()
        Dim shifter As Integer = -1

        If Not CharCompatibleWithCodeset(CharAscii, CurrCodeSet) Then
            If (LookAheadAscii <> -1) AndAlso Not CharCompatibleWithCodeset(LookAheadAscii, CurrCodeSet) Then
                Select Case CurrCodeSet
                    Case CodeSet.CodeA
                        shifter = cCODEB
                        CurrCodeSet = CodeSet.CodeB
                        Exit Select
                    Case CodeSet.CodeB
                        shifter = cCODEA
                        CurrCodeSet = CodeSet.CodeA
                        Exit Select
                End Select
            Else
                shifter = cSHIFT
            End If
        End If

        If shifter <> -1 Then
            result = New Integer(1) {}
            result(0) = shifter
            result(1) = CodeValueForChar(CharAscii)
        Else
            result = New Integer(0) {}
            result(0) = CodeValueForChar(CharAscii)
        End If

        Return result
    End Function

    Public Shared Function CodesetAllowedForChar(ByVal CharAscii As Integer) As CodeSetAllowed
        If CharAscii >= 32 AndAlso CharAscii <= 95 Then
            Return CodeSetAllowed.CodeAorB
        Else
            Return If((CharAscii < 32), CodeSetAllowed.CodeA, CodeSetAllowed.CodeB)
        End If
    End Function

    Public Shared Function CharCompatibleWithCodeset(ByVal CharAscii As Integer, ByVal currcs As CodeSet) As Boolean
        Dim csa As CodeSetAllowed = CodesetAllowedForChar(CharAscii)
        Return csa = CodeSetAllowed.CodeAorB OrElse (csa = CodeSetAllowed.CodeA AndAlso currcs = CodeSet.CodeA) OrElse (csa = CodeSetAllowed.CodeB AndAlso currcs = CodeSet.CodeB)
    End Function

    Public Shared Function CodeValueForChar(ByVal CharAscii As Integer) As Integer
        Return If((CharAscii >= 32), CharAscii - 32, CharAscii + 64)
    End Function

    Public Shared Function StartCodeForCodeSet(ByVal cs As CodeSet) As Integer
        Return If(cs = CodeSet.CodeA, cSTARTA, cSTARTB)
    End Function

    Public Shared Function StopCode() As Integer
        Return cSTOP
    End Function

End Class

#End Region
