<%@ Page Language="VB" MasterPageFile="~/sitehome.master" AutoEventWireup="false" CodeFile="registration.aspx.vb" Inherits="login" title="Untitled Page" %>

<%-- Add content controls here --%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
    <script type="text/javascript">

 
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="Form1" runat ="server">
    <center>
    
        <table border="0" cellpadding="0">
        <tr>
        <td>&nbsp;</td>
        <td>
        
         <table>
         <tr>
         <th colspan="2">Register Here:<br />
             <br />
                                                    </th>
         </tr>
        
         <tr>
         <td>First Name</td>
         <td>
             <asp:TextBox ID="TextBox11" runat="server" Height="25px" Width="150px"></asp:TextBox>
                                                    </td>
         <td>
             &nbsp;</td>
         </tr>
         
         <tr>
         <td>Last Name</td>
         <td><asp:TextBox ID="TextBox3" runat="server" Width="150px" Height="25px"></asp:TextBox></td>
         <td>
             &nbsp;</td>
         
         </tr>
         <tr>
         <td>Address</td>
         <td><asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine" Width="147px" 
                 Height="40px"></asp:TextBox></td>
         <td>
             &nbsp;</td>
         
         </tr>
         <tr>
         <td>Country</td>
         <td>
             <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                 Width="153px" Height="25px">
             </asp:DropDownList>
         </td>
         <td>
             &nbsp;</td>
         
         </tr>
         <tr>
         <td>State</td>
         <td>
             <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                 Height="25px" Width="153px">
             </asp:DropDownList>
         </td>
         <td>
             &nbsp;</td>
         
         </tr>
         <tr>
         <td>City</td>
         <td>
             <asp:DropDownList ID="DropDownList3" runat="server" Width="153px" Height="25px">
             </asp:DropDownList>
         </td>
         <td>
             &nbsp;</td>
         
         </tr>
         <tr>
         <td>Contact No</td>
         <td><asp:TextBox ID="TextBox9" runat="server" MaxLength="10" Height="25px" 
                 Width="150px"></asp:TextBox></td>
         </tr>
         <tr>
         <td>Email Address</td>
         <td><asp:TextBox ID="TextBox10" runat="server" Height="25px" Width="150px"></asp:TextBox></td>
         <td>
             &nbsp;</td>
         </tr>
          <tr>
         <td>Password</td>
         <td><asp:TextBox ID="TextBox6" runat="server" TextMode="Password" Height="25px" 
                 Width="150px"></asp:TextBox></td>
         <td>
             &nbsp;</td>
         </tr>
           <tr>
         <td>Re-Enter Password</td>
         <td><asp:TextBox ID="TextBox7" runat="server" TextMode="Password" Height="25px" 
                 Width="150px"></asp:TextBox></td>
         <td>
             &nbsp;</td>
               <asp:CompareValidator ID="CompareValidator1" runat="server" 
                   ControlToCompare="TextBox6" ControlToValidate="TextBox7" ErrorMessage="Password Didn't Match"></asp:CompareValidator>
         </tr>
         <tr>
            <td>
            &nbsp;
            </td>
         </tr>
         <tr>
         <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
             <asp:Button ID="Button1" runat="server" Text="Sign Up With electronix" 
                 Width="160px" BackColor="#666666" Font-Names="Browallia New" 
                 Font-Size="Large" ForeColor="White"  />
             &nbsp;&nbsp;
         </td>
         </tr>
         </table>
        
        </td>
        
        </tr>
        </table>
        </center>
        </form>
    <br />
</asp:Content>

