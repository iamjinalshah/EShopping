<%@ Page Title="" Language="VB" MasterPageFile="~/sitehome.master" AutoEventWireup="false" CodeFile="addnew.aspx.vb" Inherits="addnew" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>


<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>


<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>



<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server" name="f1">
<center>
    
<table>

<tr>
<td>
    <asp:Button ID="Button1" runat="server" Text="Add Country" cssclass="button"/>
</td>

<td>
    <asp:Button ID="Button2" runat="server" Text="Add State" cssclass="button" />
</td>

<td>
    <asp:Button ID="Button3" runat="server" Text="Add City" cssclass="button" />
</td>
</tr>

</table>

<table>
<tr>
    <td>
        <asp:Panel ID="Panel1" runat="server" Height="40px" Width="217px">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> 
            <asp:TextBoxWatermarkExtender ID="TextBox1_TextBoxWatermarkExtender" 
                runat="server" Enabled="True" TargetControlID="TextBox1" WatermarkText="Country Name" WatermarkCssClass="textbox">
            </asp:TextBoxWatermarkExtender>
            <br />
        <asp:Button ID="Button4" runat="server" Text="Add" cssclass="button" /> 
        
    <br />
    </asp:Panel>

    </td>
        
    <td>
    <asp:Panel ID="Panel2" runat="server" Height="40px" Width="217px">
     <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <asp:UpdatePanel runat="server" id="UpdatePanel" updatemode="Conditional">
        <Triggers>
            <asp:AsyncPostBackTrigger controlid="DropDownList4" eventname="SelectedIndexChanged" />
        </Triggers>
            <ContentTemplate>

        <asp:DropDownList ID="DropDownList4" runat="server">
        </asp:DropDownList>
                    </ContentTemplate>
        </asp:UpdatePanel>

        <br />

        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:TextBoxWatermarkExtender ID="TextBox2_TextBoxWatermarkExtender" 
            runat="server" Enabled="True" TargetControlID="TextBox2" WatermarkText="State Name" WatermarkCssClass="textbox">
        </asp:TextBoxWatermarkExtender>
        <br />
        <asp:Button ID="Button5" runat="server" Text="Add" cssclass="button"/>
        <br />
    </asp:Panel>
    </td>

    <td>

    
   <%--  <asp:ScriptManagerProxy runat="server" />
        <asp:UpdatePanel runat="server" id="UpdatePanel2" updatemode="Conditional" ChildrenAsTriggers="true">
        <Triggers>
            <asp:AsyncPostBackTrigger  controlid="DropDownList2" />
        </Triggers>
            <ContentTemplate>
--%>
        <asp:DropDownList ID="DropDownList2" runat="server" style="height: 22px" 
            AutoPostBack="True" >
        </asp:DropDownList>
        <br />

        

<%--        </ContentTemplate>
        </asp:UpdatePanel>
--%>
        <asp:DropDownList ID="DropDownList3" runat="server">
        </asp:DropDownList>

        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox> 
        <asp:TextBoxWatermarkExtender ID="TextBox3_TextBoxWatermarkExtender" 
            runat="server" Enabled="True" TargetControlID="TextBox3" WatermarkText="City Name" WatermarkCssClass="textbox">
        </asp:TextBoxWatermarkExtender>
        <br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox> 
        <asp:TextBoxWatermarkExtender ID="TextBox4_TextBoxWatermarkExtender" 
            runat="server" Enabled="True" TargetControlID="TextBox4" WatermarkText="Pincode" WatermarkCssClass="textbox">
        </asp:TextBoxWatermarkExtender>
        <br />
        <asp:Button ID="Button6" runat="server" Text="Add" cssclass="button" />
        <br />
   
    
    </td>
</tr>
</table>

</center>
</form>
<br />
</asp:Content>