<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CFDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Location" HeaderText="Location" SortExpression="Location" />
                    <asp:TemplateField HeaderText="Employees">
                        <ItemTemplate>
                            <asp:GridView ID="GridView2" runat="server" DataSource='<%# Eval("Employees") %>'>
                            </asp:GridView>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetDepartments" TypeName="CFDemo.EmployeeRepository"></asp:ObjectDataSource>
        </div>
        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetEmployees" TypeName="CFDemo.EmployeeRepository"></asp:ObjectDataSource>
        <br />
&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert New Department" style="margin-left: 8px" Width="144px" />
    </form>
</body>
</html>
