<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="FlightManagement.Dashboard"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DDCustomer" runat="server" DataSourceID="SqlDataSourceCustomers" DataTextField="Customer" DataValueField="Code" AppendDataBoundItems="true">
            <asp:ListItem Text="Choose" Selected="True" Value="Choose"></asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="LabelCustomer" runat="server" Text="Customer"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <asp:SqlDataSource ID="SqlDataSourceCustomers" runat="server" ConnectionString="<%$ ConnectionStrings:qt487ConnectionString %>" SelectCommand="select *, Surname +'-'+dni AS Customer from Flight_Customers"></asp:SqlDataSource>
        <br />
    
        <asp:DropDownList ID="DDFT" runat="server" DataSourceID="SqlDataSourceFT" DataTextField="FT" DataValueField="Code" AppendDataBoundItems="true">
            <asp:ListItem Text="Choose" Selected="True" Value="Choose"></asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="LabelFT" runat="server" Text="ForTo"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <asp:Button ID="ButtonGetValues" runat="server" OnClick="ButtonGetValues_Click" Text="Get Travel Data" />
    
        <asp:SqlDataSource ID="SqlDataSourceFT" runat="server" ConnectionString="<%$ ConnectionStrings:qt487ConnectionString %>" SelectCommand="SELECT *, Origin + '-' + Destination AS FT  FROM qt487.Flight_Travel"></asp:SqlDataSource>
        <br />
        <asp:TextBox ID="TextBoxDeparture" runat="server"></asp:TextBox>
        <asp:Label ID="LDeparture" runat="server" Text="Departure"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxArrived" runat="server"></asp:TextBox>
        <asp:Label ID="LArrived" runat="server" Text="Arrived"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxCompany" runat="server"></asp:TextBox>
        <asp:Label ID="LCompany" runat="server" Text="Company"></asp:Label>
        <br />
        <asp:DropDownList ID="DDRow" runat="server" DataSourceID="SqlDataSourceRow" DataTextField="Row" DataValueField="Row">
        </asp:DropDownList>
        <asp:DropDownList ID="DDColumn" runat="server" DataSourceID="SqlDataSourceColumn" DataTextField="Seat" DataValueField="Seat">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourceRow" runat="server" ConnectionString="<%$ ConnectionStrings:qt487ConnectionString %>" SelectCommand="SELECT Row FROM Flight_Seat GROUP BY Row"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSourceColumn" runat="server" ConnectionString="<%$ ConnectionStrings:qt487ConnectionString %>" SelectCommand="select Seat from qt487.Flight_Seat GROUP BY Seat"></asp:SqlDataSource>
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
