Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Partial Class login
    Inherits System.Web.UI.Page

    Dim conn As String = ConfigurationManager.ConnectionStrings("conn").ConnectionString
    Dim DBConnection As New SqlConnection(conn)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If DBConnection.State = ConnectionState.Closed Then
            DBConnection.Open()
        End If

       
        'Label1.Text = Session("user").ToString

    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim str As String
        str = "select * from login where email='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'"
        Dim cmd As New SqlCommand(str, DBConnection)
        Dim dr As SqlDataReader = cmd.ExecuteReader

        While dr.Read
            If TextBox1.Text = dr.GetString(0) And TextBox2.Text = dr.GetString(1) Then

                Response.Redirect("productmain.aspx")
            Else
                MessageBox.Show("Incorrect Details")
            End If
        End While

    End Sub


End Class
