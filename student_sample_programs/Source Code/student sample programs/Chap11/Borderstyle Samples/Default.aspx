<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" BorderStyle="Solid" BorderWidth="1px" Text="BorderStyle = Solid, BorderWidth = 1" style="text-align: center" Width="283px"></asp:Label>
        <p />
        <asp:Label ID="Label2" runat="server" BorderStyle="Dotted" BorderWidth="3px" Text="BorderStyle = Dotted, BorderWidth = 3" style="text-align: center" Width="277px"></asp:Label>
        <p />
        <asp:Label ID="Label3" runat="server" BorderStyle="Groove" BorderWidth="5px" Text="BorderStyle = Groove, BorderWidth = 5" style="text-align: center" Width="275px"></asp:Label>
        <p />
        <asp:Label ID="Label4" runat="server" BorderStyle="Outset" BorderWidth="8px" Text="BorderStyle = Outset, BorderWidth = 8" style="text-align: center" Width="265px"></asp:Label>
        <p />
    </form>
</body>
</html>
