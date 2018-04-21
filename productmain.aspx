<%@ Page Language="VB" MasterPageFile="~/sitehome.master" AutoEventWireup="false" CodeFile="productmain.aspx.vb" Inherits="productmain" title="Untitled Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">
function toggleshowhide()
{
 var c= document.getElementById("<%=panel1.ClientID %>");
 if(c.style.display=="none"){c.style.display="block";}
 else
 {c.style.display="none";}
 return false;
 }
 function toggleshowhide2()
{
 var c= document.getElementById("<%=panel2.ClientID %>");
 if(c.style.display=="none"){c.style.display="block";}
 else
 {c.style.display="none";}
 return false;
 }
 function toggleshowhide3()
{
 var c= document.getElementById("<%=panel3.ClientID %>");
 if(c.style.display=="none"){c.style.display="block";}
 else
 {c.style.display="none";}
 return false;
 }

   
  </script>
   <style type="text/css">
        .style1
        {
            width: 60px;
        }
          </style>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%-- <td>-</td>--%>
    <form runat="server">
<div class="left_content">
      <div class="title_box">Filters</div>
      <ul class="left_menu">
          <asp:LinkButton ID="Label1" runat="server" Text="Catagory" OnClientClick="return toggleshowhide()" ></asp:LinkButton>
          <hr />
          <asp:Panel ID="panel1" runat="server" Visible="true"  >
              <asp:CheckBox ID="CheckBox1" runat="server" Text="Mobile" />
              <br />
              <asp:CheckBox ID="CheckBox2" runat="server" Text="Laptop" />
              <br />              
              <asp:CheckBox ID="CheckBox3" runat="server" Text="Television" />              
          </asp:Panel>
          <br />
           <asp:LinkButton ID="LinkButton1" runat="server" Text="Brands" OnClientClick="return toggleshowhide2()" ></asp:LinkButton>
           <hr />
          <asp:Panel ID="panel2" runat="server" Visible="true"  >
              <asp:CheckBox ID="CheckBox4" runat="server" Text="Apple" />
              <br />
              <asp:CheckBox ID="CheckBox5" runat="server" Text="Asus" />
              <br />              
              <asp:CheckBox ID="CheckBox6" runat="server" Text="Blackberry" />
              <br />
              <asp:CheckBox ID="CheckBox7" runat="server" Text="htc" />
                            
          </asp:Panel>
          <br />
          
          <asp:LinkButton ID="LinkButton2" runat="server" Text="Price" OnClientClick="return toggleshowhide3()" ></asp:LinkButton>
           <hr />
          <asp:Panel ID="panel3" runat="server" Visible="true"  >
          <table>
          <tr> 
          <td><asp:Label ID="Label2" runat="server" Text="From"></asp:Label></td>
          <td class="style1"><asp:TextBox ID="TextBox1" runat="server" Width="69px" ></asp:TextBox></td>  
         <%-- <td>-</td>--%>
               <td><asp:Label ID="Label3" runat="server" Text="To"></asp:Label></td>
              <td><asp:TextBox ID="TextBox2" runat="server" Width="70px" ></asp:TextBox></td>
              </tr>
              </table>
          </asp:Panel>
      </ul>
   </div>
   <br /><br />
   <table>
   <tr>
   <td>
   <div>
            <asp:DataList ID="DataList1" runat="server" CellPadding="4" 
                DataSourceID="SqlDataSource1" ForeColor="#333333" HorizontalAlign="Center" 
                RepeatDirection="Horizontal" RepeatLayout="Flow">
                <AlternatingItemStyle BackColor="White" />
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <ItemTemplate>
                    <table>
                    <tr>
                    <td>
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("image") %>' Height="150px" Width="150px" />
                    </td>
                    <td>
                    <table>
                    <tr>
                    <td><asp:Label ID="Name" runat="server" Text='<%# Eval("prod_name") %>' /> </td>
                    <tr>
                    <td><asp:Label ID="Company" runat="server" Text='<%# Eval("comp_name") %>' /> </td>
                    </tr>
                    <tr>
                    <td><asp:Label ID="Price" runat="server" Text='<%# Eval("price") %>' /></td>
                
                    </tr>
                    </table>
                    </td>
                    
                    </tr>
                   
                    </table>
                    <hr />
                </ItemTemplate>
                <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            </asp:DataList>


            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:conn %>" 
                SelectCommand="select p.prod_name, c.comp_name, p.price, i.image from productmaster p, company c, imagemaster i where c.comp_id=p.comp_id and i.prod_id=p.prod_id;">
            </asp:SqlDataSource>
   </div>
   </td>

   </tr>
   </table>
   <center> 
   <table>
   
    <tr>
   <td>
       <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
       </asp:DropDownList>
   </td>
      <td>
       <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
       </asp:DropDownList>
   </td>
   </tr>
   <tr>
      <td>
          <asp:Button ID="Button1" runat="server" Text="Button" />
   </td>
   </tr>
   </table>
   </center>
   </form>
    </asp:Content>