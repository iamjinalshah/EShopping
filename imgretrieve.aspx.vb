Imports System.Data
Imports System.IO
Imports System.Data.SqlClient

Partial Class imgretrieve
    Inherits System.Web.UI.Page
    Dim conn As String = ConfigurationManager.ConnectionStrings("connectionstring").ConnectionString
    Dim dbconnection As New SqlConnection(conn)

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        dbconnection.Open()
        Dim str As String
        Dim id As String = "Prod001"
        str = "select * from imagemaster where prod_id='" & id & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dr As SqlDataReader = cmd.ExecuteReader

        While dr.Read
            Dim filepath As String

            filepath = "~/" + dr.GetString(0)
            Image1.ImageUrl = filepath
        End While
    End Sub
End Class
