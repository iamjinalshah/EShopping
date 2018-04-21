Imports System.Data
Imports System.Data.SqlClient

Partial Class login
    Inherits System.Web.UI.Page


    Dim conn As String = ConfigurationManager.ConnectionStrings("conn").ConnectionString
    Dim DBConnection As New SqlConnection(conn)

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim name As String

        name = TextBox11.Text & " " & TextBox3.Text

        Dim cmd As New SqlCommand("insert_regi_data", DBConnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = name
        cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = TextBox4.Text
        cmd.Parameters.Add("@city", SqlDbType.NVarChar, 50).Value = DropDownList1.Text
        cmd.Parameters.Add("@state", SqlDbType.NVarChar, 50).Value = DropDownList2.Text
        cmd.Parameters.Add("@country", SqlDbType.Char, 8).Value = DropDownList3.Text
        cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = TextBox10.Text
        cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 50).Value = TextBox9.Text

        Dim str1 As String
        str1 = "insert into login(email,password)values ('" & TextBox10.Text & "','" & TextBox6.Text & "')"



        If cmd.ExecuteNonQuery() = 1 Then
            Dim cmdlogin As New SqlCommand(str1, DBConnection)
            If cmdlogin.ExecuteNonQuery() = 1 Then
                MsgBox("Registration Successful", MsgBoxStyle.Information, "Welcome to electronix")
            Else
                MsgBox("Couldn't Register", MsgBoxStyle.Critical, "Something Went Wrong")
            End If

        End If

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If DBConnection.State = ConnectionState.Closed Then
            DBConnection.Open()
        End If


        If Not IsPostBack Then

        
            Dim cmd As New SqlCommand("select * from country", DBConnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        dapt.Fill(ds)
        DropDownList1.DataSource = ds.Tables(0)
        DropDownList1.DataTextField = "count_name"
        DropDownList1.DataValueField = "count_name"
        DropDownList1.DataBind()

        End If
        If Not IsPostBack Then
            DropDownList1.Items.Insert(0, New ListItem("Select Country"))
        End If


    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        'If Not IsPostBack Then


        Dim cmd1 As New SqlCommand("select * from state s, country c where s.count_id=c.count_id and c.count_name='" & DropDownList1.Text & "'", DBConnection)

        Dim dapt As New SqlDataAdapter(cmd1)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList2.DataSource = ds1.Tables(0)
        DropDownList2.DataTextField = "state_name"
        DropDownList2.DataValueField = "state_name"
        DropDownList2.DataBind()

        ' End If
        'If Not IsPostBack Then
        DropDownList2.Items.Insert(0, New ListItem("Select State"))
        'End If

    End Sub

    Protected Sub DropDownList2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList2.SelectedIndexChanged



        Dim cmd2 As New SqlCommand("select * from city ct, state s where ct.st_id=s.st_id and s.state_name='" & DropDownList2.Text & "'", DBConnection)

        Dim dapt As New SqlDataAdapter(cmd2)
        Dim ds2 As New DataSet
        dapt.Fill(ds2)
        DropDownList3.DataSource = ds2.Tables(0)
        DropDownList3.DataTextField = "city_name"
        DropDownList3.DataValueField = "city_name"
        DropDownList3.DataBind()
    End Sub
End Class
