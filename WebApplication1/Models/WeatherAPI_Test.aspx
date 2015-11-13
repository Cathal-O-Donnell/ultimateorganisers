<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeatherAPI_Test.aspx.cs" Inherits="WebApplication1.Models.WeatherAPI_Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter Location eg. los angeles"></asp:Label>
&nbsp;<asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblConditions" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblTempF" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblTempC" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblHumidity" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblWind" runat="server"></asp:Label>
    </form>
</body>
</html>
