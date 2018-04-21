Imports System.Data
Imports System.Data.SqlClient
Partial Class newentries
    Inherits System.Web.UI.Page
    Dim conn As String = ConfigurationManager.ConnectionStrings("conn").ConnectionString
    Dim dbconnection As New SqlConnection(conn)

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim cmd As New SqlCommand("company_add", dbconnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@comp_name", SqlDbType.VarChar, 50).Value = TextBox2.Text
        If cmd.ExecuteNonQuery() = 1 Then
            MsgBox("Company Added", MsgBoxStyle.Information, "Welcome to electronix")
        End If
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click


        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim cmd As New SqlCommand("feature_add", dbconnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@feature_name", SqlDbType.VarChar, 50).Value = TextBox4.Text
        If cmd.ExecuteNonQuery() = 1 Then
            MsgBox("Feature Added", MsgBoxStyle.Information, "Welcome to electronix")
        End If
        filldata()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If dbconnection.State = ConnectionState.Closed Then
                dbconnection.Open()
            End If

            filldata()
            

        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim cmd As New SqlCommand("featuredetail_add", dbconnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@feature_detail_name", SqlDbType.VarChar, 50).Value = TextBox1.Text
        cmd.Parameters.Add("@feature_name", SqlDbType.VarChar, 50).Value = DropDownList1.Text

        If cmd.ExecuteNonQuery() = 1 Then
            MsgBox("Feature Added", MsgBoxStyle.Information, "Welcome to electronix")
            
        End If
    End Sub

    Public Sub filldata()
        Dim cmd1 As New SqlCommand("select distinct feature from featuremaster", dbconnection)
        Dim dapt As New SqlDataAdapter(cmd1)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList1.DataSource = ds1.Tables(0)
        DropDownList1.DataTextField = "feature"
        DropDownList1.DataValueField = "feature"
        DropDownList1.DataBind()
    End Sub

End Class
