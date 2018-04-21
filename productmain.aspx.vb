Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Partial Class productmain
    Inherits System.Web.UI.Page
    Dim conn As String = ConfigurationManager.ConnectionStrings("conn").ConnectionString
    Dim dbconnection As New SqlConnection(conn)

    Protected Sub Label1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.Click
        'If panel1.Visible = True Then
        '    panel1.Visible = False
        'Else
        '    panel1.Visible = True
        'End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If dbconnection.State = ConnectionState.Closed Then
            dbconnection.Open()
        End If

        If Not IsPostBack Then

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
            DropDownList1.Items.Insert(0, New ListItem("--select--"))
        End If





        'Dim str1 As String
        'Dim id As String = "Prod001"
        'str1 = "select * from imagemaster where prod_id='" & id & "'"
        'Dim cmd1 As New SqlCommand(str1, dbconnection)
        'Dim dr1 As SqlDataReader = cmd.ExecuteReader

        'While dr1.Read
        '    Dim filepath As String

        '    filepath = "~/" + dr.GetString(0)

        'End While


        'Do
        '    dr.Read()

        '    Label4.Text = dr.GetString(2)
        '    Label5.Text = dr.GetString(2)

        '    'i++
        'Loop
        'While (dr.NextResult)

        'End While

        ''Dim data(0 To 20) As String


        ''Dim j As Integer = dr.RecordsAffected
        ''While dr.Read()
        ''    For i As Integer = 0 To j Step 1
        ''        'MsgBox(j)
        ''        'Label4.Text = dr.GetValue(i)

        ''        data(i) = dr.GetString(2)
        ''    Next

        ''End While

        ''For i As Integer = 0 To 20 Step 1
        ''    MsgBox(data(i))
        ''    'Label4.Text = dr.GetValue(i)

        ''    ' data(i) = dr.GetString(2)
        ''Next
        '    Dim i As Integer
        '    Dim data(0 To 20) As String

        '    While dr.Read()
        '        'MsgBox(dr.GetString(2))
        '        data(i) = dr.GetString(2)
        '        i += 1
        '    End While
        '    dr.Close()
        '    ' For x As Integer = 0 To 20 Step 1
        '    'MsgBox(data(i))
        '    Label4.Text = data(0)
        '    Label5.Text = data(1)
        '    'Next
        '    'dynamic()
        '    try1()
        'End Sub
        'Public Sub dynamic()

        '    ' Total number of rows.
        '    Dim rowCnt As Integer
        '    ' Current row count
        '    Dim rowCtr As Integer
        '    ' Total number of cells (columns).
        '    Dim cellCtr As Integer
        '    ' Current cell counter.
        '    Dim cellCnt As Integer

        '    'rowCnt = CInt(TextBox1.Text)
        '    'cellCnt = CInt(TextBox2.Text)

        '    rowCnt = 1
        '    cellCnt = 1

        '    For rowCtr = 1 To rowCnt
        '        Dim tRow As New TableRow()
        '        For cellCtr = 1 To cellCnt


        '            Dim tCell As New TableCell()
        '            'Dim txtcountry = New TextBox()
        '            'txtcountry.ID = "DynamicTextBox"
        '            'txtcountry.Text = ""
        '            'Controls.Add(txtcountry)
        '            'PlaceHolder1.Controls.Add(txtcountry)

        '            Dim dbutton As New Button()
        '            dbutton.ID = "dynamicbutton" & cellCtr
        '            Controls.Add(dbutton)
        '            PlaceHolder1.Controls.Add(dbutton)

        '            AddHandler dbutton.Click, AddressOf dbutton_Click

        '            ' Dim path As String = "~/blank.gif"
        '            Dim img = New Image()
        '            img.ID = "dynaimg"
        '            img.ImageUrl = "/blank.gif"
        '            PlaceHolder1.Controls.Add(img)


        '            tCell.Controls.Add(img)
        '            tCell.Controls.Add(dbutton)
        '            'tCell.Text = "Row " & rowCtr & ", Cell " & cellCtr
        '            '     tCell.Controls.Add(txtcountry)
        '            ' Add new TableCell object to row.
        '            tRow.Cells.Add(tCell)
        '        Next
        '        ' Add new row to table.
        '        Table1.Rows.Add(tRow)
        '    Next

    End Sub


    Public Sub dbutton_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Response.Redirect("newentries.aspx")

    End Sub

  
    '' Public Sub try1()
    '     Dim str5 As String
    '     str5 = "select * from productmaster"
    '     Dim cmd5 As New SqlCommand(str5, dbconnection)
    '     Dim dr5 As SqlDataReader = cmd5.ExecuteReader
    '     ' Dim cellCnt As Integer
    '     While dr5.Read()
    '         Dim tRow As New TableRow()
    '         For cellCtr = 1 To dr5.RecordsAffected

    '             Dim tCell As New TableCell()
    '             'Dim txtcountry = New TextBox()
    '             'txtcountry.ID = "DynamicTextBox"
    '             'txtcountry.Text = ""
    '             'Controls.Add(txtcountry)
    '             'PlaceHolder1.Controls.Add(txtcountry)

    '             Dim dbutton As New Button()
    '             dbutton.ID = dr5.GetString(0)
    '             Controls.Add(dbutton)
    '             PlaceHolder1.Controls.Add(dbutton)
    '             AddHandler dbutton.Click, AddressOf dbutton_Click


    '             Dim imgstr As String
    '             imgstr = "select image from imagemaster where prod_id='" & dr5.GetString(0) & "'"
    '             Dim img = New Image()
    '             img.ID = "dynaimg"
    '             img.ImageUrl = "/blank.gif"
    '             PlaceHolder1.Controls.Add(img)


    '             tCell.Controls.Add(img)
    '             tCell.Controls.Add(dbutton)
    '             'tCell.Text = "Row " & rowCtr & ", Cell " & cellCtr
    '             '     tCell.Controls.Add(txtcountry)
    '             ' Add new TableCell object to row.
    '             tRow.Cells.Add(tCell)
    '         Next
    '         ' Add new row to table.
    '         Table1.Rows.Add(tRow)
    '     End While
    '     dr5.Close()
    ' End Sub

  

  
  

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        Dim str1 As String
        str1 = "select * from productmaster p,company c  where p.comp_id=c.comp_id and c.comp_name='" & DropDownList1.SelectedItem.Text & "'"
        Dim cmd1 As New SqlCommand(str1, dbconnection)
        Dim dapt1 As New SqlDataAdapter(cmd1)
        Dim ds2 As New DataSet
        dapt1.Fill(ds2)
        DropDownList2.DataSource = ds2.Tables(0)
        DropDownList2.DataTextField = "prod_name"
        DropDownList2.DataValueField = "prod_id"
        DropDownList2.DataBind()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Session("id") = DropDownList2.SelectedValue.ToString
        Dim pid As String = Session("id").ToString

        Response.Redirect("viewproduct.aspx")
        '  MsgBox(DataList1.FindControl("Name"))
        

    End Sub

    'Protected Sub datalist_itemcommand(ByVal sender As Object, ByVal e As System.EventArgs)
    '    DataList1.SelectedIndex = e.
    'End Sub
End Class
