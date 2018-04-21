Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Partial Class addproduct
    Inherits System.Web.UI.Page

    Dim conn As String = ConfigurationManager.ConnectionStrings("conn").ConnectionString
    Dim dbconnection As New SqlConnection(conn)
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim img As FileUpload = CType(FileUpload1, FileUpload)
        'Dim imgByte As Byte() = Nothing
        'If img.HasFile AndAlso Not img.PostedFile Is Nothing Then
        '    'To create a PostedFile
        '    Dim File As HttpPostedFile = FileUpload1.PostedFile
        '    'Create byte Array with file len
        '    imgByte = New Byte(File.ContentLength - 1) {}
        '    'force the control to load data in array
        '    File.InputStream.Read(imgByte, 0, File.ContentLength)
        'End If


        'cmd.Parameters.AddWithValue("@Empid", EmpNumber.Text.Trim())
        'cmd.Parameters.AddWithValue("@Empname", txtEName.Text.Trim())
        'cmd.Parameters.AddWithValue("@Empimage", imgByte)
        'Dim id As String = Convert.ToInt32(cmd.ExecuteScalar())
        'lblResult.Text = String.Format("Employee ID is {0}", id)


        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        'Dim str As String
        'str = "insert into imagemaster(image) values (imgByte)"
        'Dim cmd As New SqlCommand(str, dbconnection)
        ''cmd.CommandType = CommandType.StoredProcedure
        ''cmd.Parameters.Add("@count_name", SqlDbType.VarChar, 50).Value = TextBox1.Text
        ''cmd.ExecuteNonQuery()
        'If cmd.ExecuteNonQuery() = 1 Then
        '    MsgBox("Country Added", MsgBoxStyle.Information, "Welcome to electronix")
        'End If

        Dim pathname As String = "upload/" + Path.GetFileName(FileUpload1.PostedFile.FileName)
        'Dim str As String
        'str = "insert into image(image) values ('" & pathname & "')"
        'Dim cmd1 As New SqlCommand(str, dbconnection)
        ''cmd1.ExecuteNonQuery()
        FileUpload1.SaveAs(Server.MapPath("~/upload/" + FileUpload1.FileName))


        Dim catid As String = "CAT001"
        Dim cmd As New SqlCommand("product_add", dbconnection)
        cmd.CommandType = CommandType.StoredProcedure
        Dim path1 As String = "~/"

        cmd.Parameters.Add("@prod_name", SqlDbType.VarChar, 50).Value = TextBox1.Text
        cmd.Parameters.Add("@cat_id", SqlDbType.VarChar, 50).Value = catid
        cmd.Parameters.Add("@comp_id", SqlDbType.VarChar, 50).Value = DropDownList1.SelectedValue.ToString
        cmd.Parameters.Add("@price", SqlDbType.VarChar, 50).Value = TextBox2.Text
        cmd.Parameters.Add("@warranty", SqlDbType.VarChar, 50).Value = DropDownList2.SelectedValue.ToString
        cmd.Parameters.Add("@adate", SqlDbType.VarChar, 50).Value = TextBox4.Text
        cmd.Parameters.Add("@platform", SqlDbType.VarChar, 50).Value = DropDownList3.SelectedValue.ToString
        cmd.Parameters.Add("@mno", SqlDbType.VarChar, 50).Value = TextBox1.Text

        cmd.Parameters.Add("@pcamera", SqlDbType.VarChar, 50).Value = DropDownList4.SelectedValue.ToString
        cmd.Parameters.Add("@scamera", SqlDbType.VarChar, 50).Value = DropDownList5.SelectedValue.ToString
        cmd.Parameters.Add("@network", SqlDbType.VarChar, 50).Value = DropDownList6.SelectedValue.ToString
        cmd.Parameters.Add("@ram", SqlDbType.VarChar, 50).Value = DropDownList7.SelectedValue.ToString
        cmd.Parameters.Add("@wifi", SqlDbType.VarChar, 50).Value = DropDownList8.SelectedValue.ToString
        cmd.Parameters.Add("@bluetooth", SqlDbType.VarChar, 50).Value = DropDownList9.SelectedValue.ToString
        cmd.Parameters.Add("@protection", SqlDbType.VarChar, 50).Value = DropDownList10.SelectedValue.ToString
        cmd.Parameters.Add("@card", SqlDbType.VarChar, 50).Value = DropDownList11.SelectedValue.ToString
        cmd.Parameters.Add("@memory", SqlDbType.VarChar, 50).Value = DropDownList12.SelectedValue.ToString
        cmd.Parameters.Add("@flash", SqlDbType.VarChar, 50).Value = DropDownList13.SelectedValue.ToString
        cmd.Parameters.Add("@nfc", SqlDbType.VarChar, 50).Value = DropDownList14.SelectedValue.ToString
        cmd.Parameters.Add("@usb", SqlDbType.VarChar, 50).Value = DropDownList15.SelectedValue.ToString
        cmd.Parameters.Add("@gps", SqlDbType.VarChar, 50).Value = DropDownList16.SelectedValue.ToString
        cmd.Parameters.Add("@jack", SqlDbType.VarChar, 50).Value = DropDownList17.SelectedValue.ToString
        cmd.Parameters.Add("@vibration", SqlDbType.VarChar, 50).Value = DropDownList18.SelectedValue.ToString
        cmd.Parameters.Add("@mp3", SqlDbType.VarChar, 50).Value = DropDownList19.SelectedValue.ToString
        cmd.Parameters.Add("@mtouch", SqlDbType.VarChar, 50).Value = DropDownList20.SelectedValue.ToString
        cmd.Parameters.Add("@battery", SqlDbType.VarChar, 50).Value = DropDownList21.SelectedValue.ToString
        cmd.Parameters.Add("@resolution", SqlDbType.VarChar, 50).Value = DropDownList22.SelectedValue.ToString
        cmd.Parameters.Add("@size", SqlDbType.VarChar, 50).Value = DropDownList23.SelectedValue.ToString

        cmd.Parameters.Add("@imgpath", SqlDbType.VarChar, 50).Value = path1 + pathname


        If cmd.ExecuteNonQuery() > 1 Then
            MsgBox("Registered", MsgBoxStyle.Critical, "Something Went Wrong")

            '    Label28.Visible = True
        Else
            MsgBox("Couldn't Register", MsgBoxStyle.Critical, "Something Went Wrong")
        End If

    End Sub

    Public Sub pcamera()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim feat As String = "Feat001"
        Dim str As String
        str = "select * from featuredetail where feat_id='" & feat & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList4.DataSource = ds1.Tables(0)
        DropDownList4.DataTextField = "feat_type"
        DropDownList4.DataValueField = "feat_did"
        DropDownList4.DataBind()
    End Sub


    Public Sub scamera()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim feat As String = "Feat010"
        Dim str As String
        str = "select * from featuredetail where feat_id='" & feat & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList5.DataSource = ds1.Tables(0)
        DropDownList5.DataTextField = "feat_type"
        DropDownList5.DataValueField = "feat_did"
        DropDownList5.DataBind()

    End Sub
    Public Sub network()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim feat As String = "Feat011"
        Dim str As String
        str = "select * from featuredetail where feat_id='" & feat & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList6.DataSource = ds1.Tables(0)
        DropDownList6.DataTextField = "feat_type"
        DropDownList6.DataValueField = "feat_did"
        DropDownList6.DataBind()

    End Sub
    Public Sub ram()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim feat As String = "Feat002"
        Dim str As String
        str = "select * from featuredetail where feat_id='" & feat & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList7.DataSource = ds1.Tables(0)
        DropDownList7.DataTextField = "feat_type"
        DropDownList7.DataValueField = "feat_did"
        DropDownList7.DataBind()

    End Sub
    Public Sub wifi()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim feat As String = "Feat013"
        Dim str As String
        str = "select * from featuredetail where feat_id='" & feat & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList8.DataSource = ds1.Tables(0)
        DropDownList8.DataTextField = "feat_type"
        DropDownList8.DataValueField = "feat_did"
        DropDownList8.DataBind()

    End Sub
    Public Sub btooth()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim feat As String = "Feat014"
        Dim str As String
        str = "select * from featuredetail where feat_id='" & feat & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList9.DataSource = ds1.Tables(0)
        DropDownList9.DataTextField = "feat_type"
        DropDownList9.DataValueField = "feat_did"
        DropDownList9.DataBind()

    End Sub
    Public Sub protection()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim feat As String = "Feat028"
        Dim str As String
        str = "select * from featuredetail where feat_id='" & feat & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList10.DataSource = ds1.Tables(0)
        DropDownList10.DataTextField = "feat_type"
        DropDownList10.DataValueField = "feat_did"
        DropDownList10.DataBind()

    End Sub
    Public Sub cslot()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim feat As String = "Feat016"
        Dim str As String
        str = "select * from featuredetail where feat_id='" & feat & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList11.DataSource = ds1.Tables(0)
        DropDownList11.DataTextField = "feat_type"
        DropDownList11.DataValueField = "feat_did"
        DropDownList11.DataBind()

    End Sub
    Public Sub memory()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim feat As String = "Feat009"
        Dim str As String
        str = "select * from featuredetail where feat_id='" & feat & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList12.DataSource = ds1.Tables(0)
        DropDownList12.DataTextField = "feat_type"
        DropDownList12.DataValueField = "feat_did"
        DropDownList12.DataBind()

    End Sub
    Public Sub flash()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim feat As String = "Feat017"
        Dim str As String
        str = "select * from featuredetail where feat_id='" & feat & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList13.DataSource = ds1.Tables(0)
        DropDownList13.DataTextField = "feat_type"
        DropDownList13.DataValueField = "feat_did"
        DropDownList13.DataBind()

    End Sub
    Public Sub nfc()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim feat As String = "Feat019"
        Dim str As String
        str = "select * from featuredetail where feat_id='" & feat & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList14.DataSource = ds1.Tables(0)
        DropDownList14.DataTextField = "feat_type"
        DropDownList14.DataValueField = "feat_did"
        DropDownList14.DataBind()

    End Sub
    Public Sub company()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If

        Dim str As String
        str = "select * from company "
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList1.DataSource = ds1.Tables(0)
        DropDownList1.DataTextField = "comp_name"
        DropDownList1.DataValueField = "comp_id"
        DropDownList1.DataBind()

    End Sub
    Public Sub usb()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim feat As String = "Feat018"
        Dim str As String
        str = "select * from featuredetail where feat_id='" & feat & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList15.DataSource = ds1.Tables(0)
        DropDownList15.DataTextField = "feat_type"
        DropDownList15.DataValueField = "feat_did"
        DropDownList15.DataBind()

    End Sub

    Public Sub gps()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim feat As String = "Feat020"
        Dim str As String
        str = "select * from featuredetail where feat_id='" & feat & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList16.DataSource = ds1.Tables(0)
        DropDownList16.DataTextField = "feat_type"
        DropDownList16.DataValueField = "feat_did"
        DropDownList16.DataBind()

    End Sub
    Public Sub jack()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim feat As String = "Feat021"
        Dim str As String
        str = "select * from featuredetail where feat_id='" & feat & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList17.DataSource = ds1.Tables(0)
        DropDownList17.DataTextField = "feat_type"
        DropDownList17.DataValueField = "feat_did"
        DropDownList17.DataBind()

    End Sub

    Public Sub vibration()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim feat As String = "Feat022"
        Dim str As String
        str = "select * from featuredetail where feat_id='" & feat & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList18.DataSource = ds1.Tables(0)
        DropDownList18.DataTextField = "feat_type"
        DropDownList18.DataValueField = "feat_did"
        DropDownList18.DataBind()

    End Sub
    Public Sub multi()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim feat As String = "Feat007"
        Dim str As String
        str = "select * from featuredetail where feat_id='" & feat & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList20.DataSource = ds1.Tables(0)
        DropDownList20.DataTextField = "feat_type"
        DropDownList20.DataValueField = "feat_did"
        DropDownList20.DataBind()

    End Sub
    Public Sub battery()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim feat As String = "Feat025"
        Dim str As String
        str = "select * from featuredetail where feat_id='" & feat & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList21.DataSource = ds1.Tables(0)
        DropDownList21.DataTextField = "feat_type"
        DropDownList21.DataValueField = "feat_did"
        DropDownList21.DataBind()

    End Sub
    Public Sub mp3()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim feat As String = "Feat023"
        Dim str As String
        str = "select * from featuredetail where feat_id='" & feat & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList19.DataSource = ds1.Tables(0)
        DropDownList19.DataTextField = "feat_type"
        DropDownList19.DataValueField = "feat_did"
        DropDownList19.DataBind()

    End Sub
    Public Sub size()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim feat As String = "Feat027"
        Dim str As String
        str = "select * from featuredetail where feat_id='" & feat & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList23.DataSource = ds1.Tables(0)
        DropDownList23.DataTextField = "feat_type"
        DropDownList23.DataValueField = "feat_did"
        DropDownList23.DataBind()

    End Sub
    Public Sub vresolution()

        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If
        Dim feat As String = "Feat026"
        Dim str As String
        str = "select * from featuredetail where feat_id='" & feat & "'"
        Dim cmd As New SqlCommand(str, dbconnection)
        Dim dapt As New SqlDataAdapter(cmd)
        Dim ds1 As New DataSet
        dapt.Fill(ds1)
        DropDownList22.DataSource = ds1.Tables(0)
        DropDownList22.DataTextField = "feat_type"
        DropDownList22.DataValueField = "feat_did"
        DropDownList22.DataBind()

    End Sub
   
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            '   Label28.Visible = False
            company()
            pcamera()
            scamera()
            network()
            ram()
            wifi()
            btooth()
            protection()
            cslot()
            memory()
            nfc()
            usb()
            flash()
            gps()
            jack()
            multi()
            mp3()
            battery()
            vibration()
            size()
            vresolution()

        End If
    End Sub


End Class
