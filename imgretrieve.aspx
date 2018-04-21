<%@ Page Title="" Language="VB" MasterPageFile="~/sitehome.master" AutoEventWireup="false" CodeFile="imgretrieve.aspx.vb" Inherits="imgretrieve" %>

<%-- Add content controls here --%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form runat="server" >

    <asp:Image ID="Image1" runat="server" />
    <asp:Button ID="Button1" runat="server" Text="Load" />
    </form>
</asp:Content>