Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class userDAL
    Public Function userInset(ByVal user As userBAL) As Int32
        Dim i As Int32
        i = 0
        Dim cmd As New SqlCommand()
        cmd.Connection = New DBConn().ConnOpen()
        cmd.CommandText = ""
        Return i
    End Function
End Class
