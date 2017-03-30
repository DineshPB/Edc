Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
'Imports System.Configuration


Public Class DBConn
    'Create SqlConnection object
    Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("edoccreatorDB").ToString())

    Public Function ConnOpen() As SqlConnection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return con
    End Function

    Public Function ConnClose() As SqlConnection
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return con
    End Function
End Class
