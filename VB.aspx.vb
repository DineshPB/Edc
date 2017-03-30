Imports System.Data.SqlClient

Partial Class VB
    Inherits System.Web.UI.Page

    Protected Sub Submit(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Response.Write(("You selected " + ucDateSelector.SelectedDate.ToShortDateString))
        Dim a = ucDateSelector.SelectedDate
        Dim str As String
        str = "Data Source=.\SQLEXPRESS;AttachDbFilename=H:\datepicker\App_Data\Database.mdf;Integrated Security=True;User Instance=True"
        Dim cn As New SqlConnection(str)
        Dim q As String = "Insert into [Table1] (date) values ('" + ucDateSelector.SelectedDate + "')"
        Dim cmd As New SqlCommand(q, cn)
        cn.Open()
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        cn.Close()
    End Sub


    'Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    If Not IsPostBack Then
    '        ucDateSelector.SelectedDate = DateTime.Parse("05/10/2010")
    '    End If
    'End Sub
End Class
