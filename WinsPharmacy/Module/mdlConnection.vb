Imports System
Imports System.Data
Imports System.Data.SqlClient
Module ConnectionModule
    Public conn As SqlConnection = New SqlConnection("Data Source=Thea;Initial Catalog=WinsPharmacy;Integrated Security=True")

    Public Function ExecuteQuery(ByVal Query As String) As DataTable
            Dim sqlCon As New SqlConnection(My.Settings.wins)
            Dim sqlDA As New SqlDataAdapter(Query, sqlCon)
            Dim sqlCB As New SqlCommandBuilder(sqlDA)
            Dim DT As New DataTable
            sqlDA.Fill(DT)
            Return DT
    End Function

End Module
