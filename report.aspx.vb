Imports System.Data
Imports System.Data.SqlClient
Partial Class report
    Inherits System.Web.UI.Page
    Dim conn As String = ConfigurationManager.ConnectionStrings("conn").ConnectionString
    Dim dbconnection As New SqlConnection(conn)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dbconnection.Open()

        Dim str As String
        str = "select * from productmaster"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        dapt.Fill(ds)
    End Sub
End Class
