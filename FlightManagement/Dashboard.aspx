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
            <asp:ListItem Text="Choose" Selected="True" Value="Choose"></asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <br />
        <asp:Label ID="LabelFT" runat="server" Text="ForTo" CssClass="Text"></asp:Label>
        <br />
    
        <asp:DropDownList ID="DDFT" AutoPostBack="true" runat="server" OnSelectedIndexChanged="DDFT_Change" AppendDataBoundItems="true" CssClass="TextBox">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <asp:SqlDataSource ID="SqlDataSourceFT" runat="server" ConnectionString="<%$ ConnectionStrings:qt487ConnectionString %>" SelectCommand="SELECT *, Origin + '-' + Destination AS FT  FROM qt487.Flight_Travel"></asp:SqlDataSource>
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
        <asp:DropDownList ID="DDRow" runat="server" DataSourceID="SqlDataSourceRow" DataTextField="Full" DataValueField="Full" CssClass="TextBox">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourceRow" runat="server" ConnectionString="<%$ ConnectionStrings:qt487ConnectionString %>" SelectCommand="SELECT [RowID], [SeatID], CAST(RowID as NVARCHAR(2))+'-'+SeatID AS [Full] 
FROM [Flight_Sale] WHERE (([CustomerID] IS NULL) AND ([TravelID] = @TravelID))
select * from Flight_Travel">
            <SelectParameters>
                <asp:ControlParameter ControlID="DDFT" DefaultValue="" Name="TravelID" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />
    
        <asp:Button ID="ButtonGetValues" runat="server" OnClick="ButtonGetValues_Click" Text="Buy!" CssClass="Button" />
    
        <br />
        <br />
        <asp:Label ID="LabelResult" runat="server" CssClass="LabelResult"></asp:Label>
    
        <br />
    
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Code" DataSourceID="SqlDataSourceFT" EnableModelValidation="True" Visible="false">
            <Columns>
                <asp:BoundField DataField="Code" HeaderText="Code" InsertVisible="False" ReadOnly="True" SortExpression="Code" />
                <asp:BoundField DataField="Origin" HeaderText="Origin" SortExpression="Origin" />
                <asp:BoundField DataField="Destination" HeaderText="Destination" SortExpression="Destination" />
                <asp:BoundField DataField="Time_Departure" HeaderText="Time_Departure" SortExpression="Time_Departure" />
                <asp:BoundField DataField="Time_Arrived" HeaderText="Time_Arrived" SortExpression="Time_Arrived" />
                <asp:BoundField DataField="Duration" HeaderText="Duration" SortExpression="Duration" />
                <asp:BoundField DataField="MaxCapacity" HeaderText="MaxCapacity" SortExpression="MaxCapacity" />
                <asp:BoundField DataField="MaxRow" HeaderText="MaxRow" SortExpression="MaxRow" />
                <asp:BoundField DataField="MaxSeatsRow" HeaderText="MaxSeatsRow" SortExpression="MaxSeatsRow" />
                <asp:BoundField DataField="CompanyID" HeaderText="CompanyID" SortExpression="CompanyID" />
                <asp:CheckBoxField DataField="Status" HeaderText="Status" SortExpression="Status" />
                <asp:BoundField DataField="FT" HeaderText="FT" ReadOnly="True" SortExpression="FT" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
