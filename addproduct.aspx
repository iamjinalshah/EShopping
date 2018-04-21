<%@ Page Title="" Language="VB" MasterPageFile="~/sitehome.master" AutoEventWireup="false" CodeFile="addproduct.aspx.vb" Inherits="addproduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>New Product</center> <br /> <br />
<form runat="server">
<table>
<tr>
    <td>
        <asp:Label ID="Label1" runat="server" Text="Mobile Name"></asp:Label>  
    </td>
    <td class="style1">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </td>
    <td>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </td>
    <td>
        <asp:Label ID="Label2" runat="server" Text="Company Name"></asp:Label>
    </td>
    <td>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        </asp:DropDownList>
    </td>
</tr>

<tr>
    <td>
        <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>  
    </td>
    <td class="style1">
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </td>
    <td>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </td>
    <td>
        <asp:Label ID="Label4" runat="server" Text="Warranty"></asp:Label>
    </td>
    <td>
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
            <asp:ListItem>6 Months</asp:ListItem>
            <asp:ListItem>12 Months</asp:ListItem>
            <asp:ListItem>18 Months</asp:ListItem>
            <asp:ListItem>24 Months</asp:ListItem>
            <asp:ListItem>30 Months</asp:ListItem>
            <asp:ListItem>36 Months</asp:ListItem>
        </asp:DropDownList>
    </td>
</tr>

<tr>
    <td>
        <asp:Label ID="Label5" runat="server" Text="Model No."></asp:Label>  
    </td>
    <td class="style1">
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </td>
    <td>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </td>
    <td>
        Image
    </td>
    <td>
        <asp:FileUpload ID="FileUpload1" runat="server" />
     &nbsp;
    </td>
</tr>

<tr>
    <td>
        <asp:Label ID="Label6" runat="server" Text="Announce Date"></asp:Label>  
    </td>
    <td class="style1">
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </td>
    <td>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </td>
    <td>
        <asp:Label ID="Label7" runat="server" Text="Platform"></asp:Label>
    </td>
    <td>
        <asp:DropDownList ID="DropDownList3" runat="server">
                    <asp:ListItem>Android</asp:ListItem>
                    <asp:ListItem>iOS</asp:ListItem>
                    <asp:ListItem>Windows OS</asp:ListItem>
                    <asp:ListItem>Blackberry OS</asp:ListItem>
                    <asp:ListItem>Cynogen</asp:ListItem>
                    <asp:ListItem>Fire OS</asp:ListItem>
        </asp:DropDownList>
    </td>
</tr>
</table>
<table>
<tr>
    <td class="style2" >
    Features
    </td>
</tr>
</table>
<table cellspacing="2">
<tr>
<td class="style2">
    <asp:Label ID="Label8" runat="server" Text="Primary Camera"></asp:Label>
</td>
<td class="style4">
        <asp:Label ID="Label9" runat="server" Text="Secondary Camera"></asp:Label>

</td>
<td class="style5">
        <asp:Label ID="Label10" runat="server" Text="Network"></asp:Label>
</td>
<td class="style6">
        <asp:Label ID="Label11" runat="server" Text="RAM"></asp:Label>

</td>
<td>
        <asp:Label ID="Label12" runat="server" Text="Wifi"></asp:Label>

</td>
</tr>
<tr>
<td class="style2">
    <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True">
    </asp:DropDownList>
</td>
<td class="style4">
    <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True">
    </asp:DropDownList>
</td>
<td class="style5">
    <asp:DropDownList ID="DropDownList6" runat="server" AutoPostBack="True">
    </asp:DropDownList>
</td>
<td class="style6">
    <asp:DropDownList ID="DropDownList7" runat="server" AutoPostBack="True">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="DropDownList8" runat="server" AutoPostBack="True">
    </asp:DropDownList>
</td>

</tr>
<tr>
<td colspan="5">
<br />
</td>
</tr>
</table>
<table>
<tr>
<td>
      <asp:Label ID="Label13" runat="server" Text="Bluetooth"></asp:Label>

</td>
<td>
      <asp:Label ID="Label14" runat="server" Text="Display Protection"></asp:Label>

</td>
<td>
      <asp:Label ID="Label15" runat="server" Text="Cardslot"></asp:Label>

</td>
<td>
      <asp:Label ID="Label16" runat="server" Text="Memory"></asp:Label>

</td>
<td>
      <asp:Label ID="Label17" runat="server" Text="Flash"></asp:Label>
</td>
</tr>
<tr>
<td class="style2">
    <asp:DropDownList ID="DropDownList9" runat="server" AutoPostBack="True">
    </asp:DropDownList>
</td>
<td class="style3">
    <asp:DropDownList ID="DropDownList10" runat="server" AutoPostBack="True">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="DropDownList11" runat="server" AutoPostBack="True">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="DropDownList12" runat="server" AutoPostBack="True">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="DropDownList13" runat="server" AutoPostBack="True">
    </asp:DropDownList>
</td>

</tr>

<tr>
<td colspan="5">
<br />
</td>
</tr>
</table>
<table>
<tr>
<td>
      <asp:Label ID="Label18" runat="server" Text="NFC"></asp:Label>

</td>
<td>
      <asp:Label ID="Label19" runat="server" Text="USB"></asp:Label>

</td>
<td>
      <asp:Label ID="Label20" runat="server" Text="GPS"></asp:Label>

</td>
<td>
      <asp:Label ID="Label21" runat="server" Text="3.5 mm Jack"></asp:Label>

</td>
<td>
      <asp:Label ID="Label22" runat="server" Text="Vibration"></asp:Label>
</td>
</tr>
<tr>
<td class="style2">
    <asp:DropDownList ID="DropDownList14" runat="server" AutoPostBack="True">
    </asp:DropDownList>
</td>
<td class="style3">
    <asp:DropDownList ID="DropDownList15" runat="server" AutoPostBack="True">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="DropDownList16" runat="server" AutoPostBack="True">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="DropDownList17" runat="server" AutoPostBack="True">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="DropDownList18" runat="server" AutoPostBack="True">
    </asp:DropDownList>
</td>

</tr>
<tr>
<td colspan="5">
<br />
</td>
</tr>
</table>
<table>
<tr>
<td>
      <asp:Label ID="Label23" runat="server" Text="MP3 Player"></asp:Label>

</td>
<td>
      <asp:Label ID="Label24" runat="server" Text="Multi touch"></asp:Label>

</td>
<td>
      <asp:Label ID="Label25" runat="server" Text="Battery"></asp:Label>

</td>
<td>
      <asp:Label ID="Label26" runat="server" Text="Video Resolution"></asp:Label>

</td>
<td>
      <asp:Label ID="Label27" runat="server" Text="Size (inches)"></asp:Label>
</td>
</tr>
<tr>
<td class="style2">
    <asp:DropDownList ID="DropDownList19" runat="server" AutoPostBack="True">
    </asp:DropDownList>
</td>
<td class="style3">
    <asp:DropDownList ID="DropDownList20" runat="server" AutoPostBack="True">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="DropDownList21" runat="server" AutoPostBack="True">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="DropDownList22" runat="server" AutoPostBack="True">
    </asp:DropDownList>
</td>
<td>
    <asp:DropDownList ID="DropDownList23" runat="server" AutoPostBack="True">
    </asp:DropDownList>
</td>

</tr>
<tr>
<td colspan="5">
<br />
</td>
</tr>
</table>


<tr>
<td>
    <asp:Button ID="Button1" runat="server" Text="Add Product" />
</td>
<td>
</td>
</tr>
</table>
</form>
</asp:Content>
<%-- Add content controls here --%>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .style1
        {
            width: 125px;
        }
        .style2
        {
            width: 120px;
        }
        .style3
        {
            width: 138px;
        }
        .style4
        {
            width: 117px;
        }
        .style5
        {
            width: 96px;
        }
        .style6
        {
            width: 102px;
        }
    </style>
</asp:Content>

