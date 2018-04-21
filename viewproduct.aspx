<%@ Page Title="" Language="VB" MasterPageFile="~/sitehome.master" AutoEventWireup="false" CodeFile="viewproduct.aspx.vb" Inherits="viewproduct" %>

<%-- Add content controls here --%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form id="form1" runat="server">
    <br />
    <br />
    <table>
    <tr>
    <td width="200px">
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("image") %>' Height="150px" Width="150px" />
                <br />
            <br />
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:conn %>" 
            SelectCommand="StoredProcedure1" SelectCommandType="StoredProcedure">
        </asp:SqlDataSource>

        </td>
        <td width="200px">
            <asp:DataList ID="DataList2" runat="server" DataSourceID="SqlDataSource3">
                <ItemTemplate>
                    Name
                    <asp:Label ID="prod_nameLabel" runat="server" Text='<%# Eval("prod_name") %>' />
                    <br /><br /><hr />
                    Price
                    <asp:Label ID="priceLabel" runat="server" Text='<%# Eval("price") %>' />
                    <br /><br /><hr />
                    Warranty
                    <asp:Label ID="warrantyLabel" runat="server" Text='<%# Eval("warranty") %>' />
                    <br /><br /><hr />
                    Announced On
                    <asp:Label ID="annoucedateLabel" runat="server" 
                        Text='<%# Eval("annoucedate") %>' />
                    <br /><br /><hr />
                    Model No
                    <asp:Label ID="modelnoLabel" runat="server" Text='<%# Eval("modelno") %>' />
                    <br /><br /><hr />
                    Company
                    <asp:Label ID="comp_nameLabel" runat="server" Text='<%# Eval("comp_name") %>' />
                    <br /><br />
                </ItemTemplate>
            </asp:DataList>
            
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                ConnectionString="<%$ ConnectionStrings:conn %>" SelectCommand="product" 
                SelectCommandType="StoredProcedure"></asp:SqlDataSource>

        </td>
        </tr>
        </table>
        
        <table>
        
        <tr>
        <td>
        <hr />
        <asp:DataList ID="DataList3" runat="server" DataSourceID="SqlDataSource2">
            <ItemTemplate>
            <table>
            <tr>
            <td width="200px">
            
                <asp:Label ID="featureLabel" runat="server" Text='<%# Eval("feature") %>' />
                <br />
                </td>
                <td width="200px">
                <asp:Label ID="feat_typeLabel" runat="server" Text='<%# Eval("feat_type") %>' />
                <br />
                </td> 
                <hr />
            </tr>
       </table>     
            </ItemTemplate>
        </asp:DataList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                ConnectionString="<%$ ConnectionStrings:conn %>" SelectCommand="detail" 
                SelectCommandType="StoredProcedure"></asp:SqlDataSource>

        </td>
        </tr>
        </table>
        <hr />
    <asp:Button ID="Button1" runat="server" Text="Add To Cart" />
    
    </form>

</asp:Content> 