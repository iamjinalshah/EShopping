Imports System.Data
Imports System.Data.SqlClient

Partial Class viewproduct
    Inherits System.Web.UI.Page
    Dim conn As String = ConfigurationManager.ConnectionStrings("connectionstring").ConnectionString
    Dim DBConnection As New SqlConnection(conn)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' DBConnection.Open()
        Dim pid As String = Session("id").ToString

        'Dim cmd As New SqlCommand("StoredProcedure1", DBConnection)
        ' cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("@id", SqlDbType.Int).Value = pid
        'cmd.ExecuteNonQuery()

        'Dim param As Integer = New SqlParameter("@id", SqlDbType.VarChar, 50).Value = id

        'param.Direction = ParameterDirection.Input
        'param.DbType = DbType.String
        'Command.Parameters.Add(param)

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class
