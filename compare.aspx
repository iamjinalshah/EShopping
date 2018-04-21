<%@ Page Title="" Language="VB" MasterPageFile="~/sitehome.master" AutoEventWireup="false" CodeFile="compare.aspx.vb" Inherits="compare" %>

<%-- Add content controls here --%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1"  Runat="Server">
<form runat="server">
<center>
Compare Products
</center>
<center>
<table>
<tr>
<td class="style2">
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
    <asp:Button ID="Button1" runat="server" Text="Compare" />
</td>
</tr>
<tr>
<td>
    <asp:Image ID="Image1" runat="server" />
</td>
<td>
    <asp:Image ID="Image2" runat="server" />
</td>
</tr>
</table>

<table>
<tr>
<td>
Name:
</td>
<td>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
Name:
</td>
<td>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
</td>

</tr>
<tr>
<td>
    Company
</td>
<td>
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
    Company
</td>
<td>
    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
</td>
<tr>
<td>
    Price
</td>
<td>
    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
    Price
</td>
<td>
    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
Warranty
</td>
<td>
    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
Warranty
</td>
<td>
    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
Announce Date
</td>
<td>
    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
Announce Date
</td>
<td>
    <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
Platform
</td>
<td>
    <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
Platform
</td>
<td>
<asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
</td>
</tr>

<tr>
<td>
Model NO
</td>
<td>
    <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
Model NO
</td>
<td>
    <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>

</td>
</tr>
<tr>
<td colspan="5">
Features</td>
</tr>
<tr>
<td>

</td>
</tr>
<tr>
<td>
Primary Camera
</td>
<td>
    <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
Primary Camera
</td>
<td>
    <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
Seconday Camera
</td>
<td>
    <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
Seconday Camera
</td>
<td>
    <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
Network
</td>
<td>
    <asp:Label ID="Label19" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
Network
</td>
<td>
    <asp:Label ID="Label54" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
RAM
</td>
<td>
    <asp:Label ID="Label20" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
RAM
</td>
<td>
    <asp:Label ID="Label21" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
Wifi
</td>
<td>
    <asp:Label ID="Label22" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
Wifi
</td>
<td>
    <asp:Label ID="Label23" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
Bluetooth
</td>
<td>
    <asp:Label ID="Label24" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
Bluetooth
</td>
<td>
    <asp:Label ID="Label25" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
Protection
</td>
<td>
    <asp:Label ID="Label26" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
Protection
</td>
<td>
    <asp:Label ID="Label27" runat="server" Text="Label"></asp:Label>
</td>

</tr>
<tr>
<td>
Card Slot
</td>
<td>
    <asp:Label ID="Label28" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
Card Slot
</td>
<td>
    <asp:Label ID="Label29" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
Memory
</td>
<td>
    <asp:Label ID="Label30" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
Memory
</td>
<td>
    <asp:Label ID="Label31" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
Flash
</td>
<td>
    <asp:Label ID="Label32" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
Flash
</td>
<td>
    <asp:Label ID="Label33" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
NFC
</td>
<td>
    <asp:Label ID="Label34" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
NFC
</td>
<td>
    <asp:Label ID="Label35" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
USB
</td>
<td>
    <asp:Label ID="Label36" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
USB
</td>
<td>
    <asp:Label ID="Label37" runat="server" Text="Label"></asp:Label>
</td>

</tr>
<tr>
<td>
GPS
</td>
<td>
    <asp:Label ID="Label38" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
GPS
</td>
<td>
    <asp:Label ID="Label39" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
3.5 MM Jack
</td>
<td>
    <asp:Label ID="Label40" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
3.5 MM Jack
</td>
<td>
    <asp:Label ID="Label41" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
Vibration
</td>
<td>
    <asp:Label ID="Label42" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
Vibration
</td>
<td>
    <asp:Label ID="Label43" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
MP3 Player
</td>
<td>
    <asp:Label ID="Label44" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
MP3 Player
</td>
<td>
    <asp:Label ID="Label45" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
Multitouch
</td>
<td>
    <asp:Label ID="Label46" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
Multitouch
</td>
<td>
    <asp:Label ID="Label47" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
Battery
</td>
<td>
    <asp:Label ID="Label48" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
Battery
</td>
<td>
    <asp:Label ID="Label49" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
Resolution
</td>
<td>
    <asp:Label ID="Label50" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
Resolution
</td>
<td>
    <asp:Label ID="Label51" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
Size
</td>
<td>
    <asp:Label ID="Label52" runat="server" Text="Label"></asp:Label>
</td>
<td>

</td>
<td>
Size
</td>
<td>
    <asp:Label ID="Label53" runat="server" Text="Label"></asp:Label>
</td>
</tr>

<tr>
<td>

</td>
<td>

</td>
</tr>
</table>
</center>
</form>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .style2
        {
            width: 222px;
        }
    </style>
</asp:Content>
