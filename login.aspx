
<%@ Page Language="VB" MasterPageFile="~/sitehome.master" AutoEventWireup="false" CodeFile="login.aspx.vb" Inherits="login" title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<%-- Add content controls here --%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="Form1" runat="server">
   <center>    <asp:Panel ID="Panel1" runat="server">
  
    <h4>Login Here</h4>
    <br /><div>
    <table>
    <tr>
    <td>
    <asp:Label ID="Label2" runat="server" Text="Email" Font-Size="Small"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="150px"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="Label3" runat="server" Text="Password" Font-Size="Small"></asp:Label>
    </td>
    <td>
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Height="25px" 
            Width="150px"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td>
     &nbsp;
    </td>
    </tr>
    
    <tr>
    <td colspan="2">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" BackColor="#666666" 
            Font-Names="Browallia New" Font-Size="Large" ForeColor="White" Text="Login" 
            Width="160px" />
        &nbsp;&nbsp;&nbsp;&nbsp;
    </td>
    </tr>
    </table>
    </div>
      </asp:Panel>
</center>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </form>
</asp:Content>

