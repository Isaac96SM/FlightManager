<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="FlightManagement.Dashboard"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="Style.css"/>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelCustomer" runat="server" Text="Customer" CssClass="Text"></asp:Label>
        <br />
    
        <asp:DropDownList ID="DDCustomer" runat="server" AppendDataBoundItems="true" CssClass="TextBox">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <br />
        <asp:Label ID="LabelFT" runat="server" Text="ForTo" CssClass="Text"></asp:Label>
        <br />
    
        <asp:DropDownList ID="DDFT" AutoPostBack="true" runat="server" OnSelectedIndexChanged="DDFT_Change" AppendDataBoundItems="true" CssClass="TextBox">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <br />
        <asp:Label ID="LDeparture" runat="server" Text="Departure" CssClass="Text"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxDeparture" runat="server" CssClass="TextBox"></asp:TextBox>
        <br />
        <asp:Label ID="LArrived" runat="server" Text="Arrived" CssClass="Text"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxArrived" runat="server" CssClass="TextBox"></asp:TextBox>
        <br />
        <asp:Label ID="LCompany" runat="server" Text="Company" CssClass="Text"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxCompany" runat="server" CssClass="TextBox"></asp:TextBox>
        <br />
        <asp:DropDownList ID="DDRow" runat="server" CssClass="TextBox">
        </asp:DropDownList>
        <br />
        <br />
    
        <asp:Button ID="ButtonGetValues" runat="server" OnClick="ButtonGetValues_Click" Text="Buy!" CssClass="Button" />
    
        <br />
        <br />
        <asp:Label ID="LabelResult" runat="server" CssClass="LabelResult"></asp:Label>
    
        <br />
    
    </div>
    </form>
</body>
</html>
