Imports System.Data
Imports System.Data.SqlClient
Partial Class addnew
    Inherits System.Web.UI.Page
    Dim conn As String = ConfigurationManager.ConnectionStrings("conn").ConnectionString
    Dim DBConnection As New SqlConnection(conn)
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel1.Visible = True

        Panel2.Visible = False
        'Panel3.Visible = False

        DropDownList2.Visible = False
        DropDownList3.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        Button6.Visible = False

    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        Panel1.Visible = False
        Panel2.Visible = False
        'Panel3.Visible = False
        'DropDownList2.Visible = False
        'DropDownList3.Visible = False
        'TextBox3.Visible = False
        'Button6.Visible = False

        If Not IsPostBack Then
            Dim ds As New DataSet
            Dim cmd As New SqlCommand("select * from country", DBConnection)
            Dim dapt As New SqlDataAdapter(cmd)

            dapt.Fill(ds)
            DropDownList2.DataSource = ds.Tables(0)
            DropDownList2.DataTextField = "count_name"
            DropDownList2.DataValueField = "count_name"
            DropDownList2.DataBind()
            DropDownList2.Items.Insert(0, New ListItem("Select Country"))

            DropDownList4.DataSource = ds.Tables(0)
            DropDownList4.DataTextField = "count_name"
            DropDownList4.DataValueField = "count_name"
            DropDownList4.DataBind()
            DropDownList4.Items.Insert(0, New ListItem("Select Country"))



        End If

        If Not IsPostBack Then
            DropDownList3.Items.Insert(0, New ListItem("Select State"))
        End If


    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        If IsPostBack Then


            Panel2.Visible = True
            Panel1.Visible = False
            ' Panel3.Visible = False

            DropDownList2.Visible = False
            DropDownList3.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            Button6.Visible = False
        End If
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Panel2.Visible = False
        Panel1.Visible = False
        'Panel3.Visible = True

        DropDownList2.Visible = True
        DropDownList3.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True

        Button6.Visible = True
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        If DBConnection.State = ConnectionState.Closed Then
            DBConnection.Open()
        End If
        Dim cmd As New SqlCommand("country_add", DBConnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@count_name", SqlDbType.VarChar, 50).Value = TextBox1.Text
        If cmd.ExecuteNonQuery() = 1 Then
            MsgBox("Country Added", MsgBoxStyle.Information, "Welcome to electronix")
        End If
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        If DBConnection.State = ConnectionState.Closed Then
            DBConnection.Open()
        End If

        Dim cmd As New SqlCommand("state_add", DBConnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@count_name", SqlDbType.VarChar, 50).Value = DropDownList4.Text
        cmd.Parameters.Add("@state_name", SqlDbType.VarChar, 50).Value = TextBox2.Text
        If cmd.ExecuteNonQuery() = 1 Then
            MsgBox("State Added", MsgBoxStyle.Information, "Welcome to electronix")
        End If
    End Sub


    Protected Sub DropDownList2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList2.SelectedIndexChanged
        If IsPostBack Then


            Dim cmd1 As New SqlCommand("select * from state s, country c where s.count_id=c.count_id and c.count_name='" & DropDownList2.Text & "'", DBConnection)

            Dim dapt As New SqlDataAdapter(cmd1)
            Dim ds1 As New DataSet
            dapt.Fill(ds1)
            DropDownList3.DataSource = ds1.Tables(0)
            DropDownList3.DataTextField = "state_name"
            DropDownList3.DataValueField = "state_name"
            DropDownList3.DataBind()

            ' End If
            
        End If
        
    End Sub

    Protected Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.Click
        If DBConnection.State = ConnectionState.Closed Then
            DBConnection.Open()
        End If

        Dim cmd As New SqlCommand("city_add", DBConnection)
        cmd.CommandType = CommandType.StoredProcedure
        ' cmd.Parameters.Add("@count_name", SqlDbType.VarChar, 50).Value = DropDownList2.Text
        cmd.Parameters.Add("@state_name", SqlDbType.VarChar, 50).Value = DropDownList3.Text
        cmd.Parameters.Add("@city_name", SqlDbType.VarChar, 50).Value = TextBox3.Text
        cmd.Parameters.Add("@pincode", SqlDbType.VarChar, 50).Value = TextBox4.Text


        If cmd.ExecuteNonQuery() = 1 Then
            MsgBox("City Added", MsgBoxStyle.Information, "Welcome to electronix")
        End If
    End Sub
End Class
