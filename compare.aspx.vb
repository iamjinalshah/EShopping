Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Partial Class compare
    Inherits System.Web.UI.Page
    Dim conn As String = ConfigurationManager.ConnectionStrings("connectionstring").ConnectionString
    Dim DBConnection As New SqlConnection(conn)
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        If DropDownList1.Text = DropDownList2.Text Then
            MsgBox("You Can't Compare Same Products")
        Else

            If DBConnection.State = ConnectionState.Closed Then
                DBConnection.Open()
            End If

            Dim str2 As String
            str2 = "select * from productmaster where prod_id='" & DropDownList1.SelectedValue.ToString & "'"
            Dim cmd2 As New SqlCommand(str2, DBConnection)
            Dim dr2 As SqlDataReader = cmd2.ExecuteReader
            While dr2.Read
                Label1.Text = dr2.GetString(1)
                Label5.Text = dr2.GetString(4)
                Label7.Text = dr2.GetString(5)
                Label9.Text = dr2.GetString(6)
                Label11.Text = dr2.GetString(7)
                Label13.Text = dr2.GetString(8)

            End While
            dr2.Close()


            Dim str3 As String
            str3 = "select c.comp_name from company c, productmaster p where c.comp_id=p.comp_id and p.prod_id='" & DropDownList1.SelectedValue.ToString & "' "
            Dim cmd3 As New SqlCommand(str3, DBConnection)
            Dim dr3 As SqlDataReader = cmd3.ExecuteReader
            While dr3.Read
                Label13.Text = dr3.GetString(0)
            End While
            dr3.Close()

            Dim str5 As String
            str5 = "select * from productmaster where prod_id='" & DropDownList2.SelectedValue.ToString & "'"
            Dim cmd5 As New SqlCommand(str5, DBConnection)
            Dim dr5 As SqlDataReader = cmd5.ExecuteReader
            While dr5.Read
                Label2.Text = dr5.GetString(1)

                Label6.Text = dr5.GetString(4)
                Label8.Text = dr5.GetString(5)
                Label10.Text = dr5.GetString(6)
                Label12.Text = dr5.GetString(7)
                Label14.Text = dr5.GetString(8)


            End While
            dr5.Close()


            Dim str4 As String
            str4 = "select c.comp_name from company c, productmaster p where c.comp_id=p.comp_id and p.prod_id='" & DropDownList2.SelectedValue.ToString & "' "
            Dim cmd4 As New SqlCommand(str4, DBConnection)
            Dim dr4 As SqlDataReader = cmd4.ExecuteReader
            While dr4.Read
                Label14.Text = dr4.GetString(0)
            End While
            dr4.Close()

            'dropdown1

            Dim str As String
            'Dim x As String = "Prod001"
            str = "select f.feat_type from featuredetail f, productdetail p where f.feat_did=p.feat_did and p.prod_id= '" & DropDownList1.SelectedValue.ToString & "' "


            Dim cmd As New SqlCommand(str, DBConnection)
            Dim dr As SqlDataReader = cmd.ExecuteReader

            Dim j As String = dr.RecordsAffected
            Dim data(0 To 20) As String


            MsgBox(dr.RecordsAffected)
            While dr.Read
                For i As Integer = 0 To j Step 1
                    data(i) = dr.GetString(0)
                    'MsgBox(dr.GetString(0))
                Next

            End While


            Label15.Text = data(0)
            Label17.Text = data(1)
            Label19.Text = data(2)
            Label20.Text = data(3)
            Label22.Text = data(4)
            Label24.Text = data(5)
            Label26.Text = data(6)
            Label28.Text = data(7)
            Label30.Text = data(8)

            Label32.Text = data(9)
            Label34.Text = data(10)
            Label36.Text = data(11)
            Label38.Text = data(12)

            Label40.Text = data(13)
            Label42.Text = data(14)
            Label44.Text = data(15)
            Label46.Text = data(16)
            Label48.Text = data(17)
            Label50.Text = data(18)
            Label52.Text = data(19)

            dr.Close()

            'dropdown2

            Dim str1 As String
            str1 = "select f.feat_type from featuredetail f, productdetail p where f.feat_did=p.feat_did and p.prod_id= '" & DropDownList2.SelectedValue.ToString & "' "


            Dim cmd1 As New SqlCommand(str1, DBConnection)
            Dim dr1 As SqlDataReader = cmd.ExecuteReader

            Dim data1(0 To 20) As String

            Dim j1 As String = dr.RecordsAffected
            'MsgBox(dr.RecordsAffected)
            While dr1.Read
                For i1 As Integer = 0 To j1 Step 1
                    data1(i1) = dr1.GetString(0)
                Next

            End While


            Label16.Text = data1(0)
            Label18.Text = data1(1)
            Label54.Text = data1(2)
            Label21.Text = data1(3)
            Label23.Text = data1(4)
            Label25.Text = data1(5)
            Label27.Text = data1(6)
            Label29.Text = data1(7)
            Label31.Text = data1(8)
            Label33.Text = data1(9)
            Label35.Text = data1(10)
            Label37.Text = data1(11)
            Label39.Text = data1(12)
            Label41.Text = data1(13)
            Label43.Text = data1(14)
            Label45.Text = data1(15)
            Label47.Text = data1(16)
            Label49.Text = data1(17)
            Label51.Text = data1(18)
            Label53.Text = data1(19)

            dr1.Close()


            Dim str7 As String
            'Dim id As String = "Prod001"
            str7 = "select * from imagemaster where prod_id='" & DropDownList1.SelectedValue.ToString & "'"
            Dim cmd7 As New SqlCommand(str7, DBConnection)
            Dim dr7 As SqlDataReader = cmd7.ExecuteReader

            While dr7.Read
                Dim filepath As String

                filepath = "~/" + dr7.GetString(0)
                Image1.ImageUrl = filepath
            End While
            dr7.Close()


            Dim str8 As String
            'Dim id As String = "Prod001"
            str8 = "select * from imagemaster where prod_id='" & DropDownList2.SelectedValue.ToString & "'"
            Dim cmd8 As New SqlCommand(str8, DBConnection)
            Dim dr8 As SqlDataReader = cmd8.ExecuteReader

            While dr8.Read
                Dim filepath2 As String

                filepath2 = "~/" + dr8.GetString(0)
                Image2.ImageUrl = filepath2
                'MsgBox(filepath2)
            End While
            dr8.Close()




        End If



        
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If DBConnection.State = ConnectionState.Closed Then
            DBConnection.Open()
        End If

        If Not IsPostBack Then


            Dim str As String
            str = "select * from productmaster"
            Dim cmd As New SqlCommand(str, DBConnection)
            Dim dapt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet

            dapt.Fill(ds)
            DropDownList1.DataSource = ds.Tables(0)
            DropDownList1.DataTextField = "prod_name"
            DropDownList1.DataValueField = "prod_id"
            DropDownList1.DataBind()
            DropDownList1.Items.Insert(0, New ListItem("Select Product"))

            DropDownList2.DataSource = ds.Tables(0)
            DropDownList2.DataTextField = "prod_name"
            DropDownList2.DataValueField = "prod_id"
            DropDownList2.DataBind()
            DropDownList2.Items.Insert(0, New ListItem("Select Product"))

        End If


    End Sub
End Class
