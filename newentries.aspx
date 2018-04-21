<%@ Page Title="" Language="VB" MasterPageFile="~/sitehome.master" AutoEventWireup="false" CodeFile="newentries.aspx.vb" Inherits="newentries" %>

<%-- Add content controls here --%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="Form1" runat ="server">
    <center>
<%--      <asp:MultiView ID="MultiView1" runat="server">--%>
        
        <table border="0" cellpadding="0">
        <tr>
        <td>&nbsp;</td>
        
        <td>
        
         <table>
         <tr>
         <th colspan="2">Add New Entries Here<br />
             <br /> </th>
         </tr>
        
         
         <tr>
         <td>Company</td>
         <td>
             <asp:TextBox ID="TextBox2" runat="server" Width="150px" Height="25px"></asp:TextBox>
         </td>
         <td>
            <asp:Button ID="Button4" runat="server" Text="Add"/>
            </td>
         </tr>

         <tr>
         <td>Feature</td>
         <td>
             <asp:TextBox ID="TextBox4" runat="server" Width="150px" Height="25px"></asp:TextBox>
         </td>
         <td><asp:Button ID="Button5" runat="server" Text="Add" 
                 PostBackUrl="~/newentries.aspx"/></td>
         </td>
        </tr>

        <tr>
       
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
            </asp:DropDownList>
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>

        <td>
            <asp:Button ID="Button1" runat="server" Text="Add" Height="21px" Width="46px" />
        </td>
        </tr>
         </table>
        
        
        
        

       <%-- </asp:MultiView>--%>
        </center>
        </form>

</asp:Content>

