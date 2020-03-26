<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="WebForm.Demo" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 507px">
            &nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Select Country: "></asp:Label>&nbsp;&nbsp;&nbsp; &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="UK">UK</asp:ListItem>
                <asp:ListItem Value="USA">USA</asp:ListItem>
                <asp:ListItem Value="Germany">Germany</asp:ListItem>
                <asp:ListItem Value="Mexico">Mexico</asp:ListItem>
                <asp:ListItem Value="Sweden">Sweden</asp:ListItem>
                <asp:ListItem Value="France">France</asp:ListItem>
                <asp:ListItem Value="Spain">Spain</asp:ListItem>
                <asp:ListItem Value="Canada">Canada</asp:ListItem>
                <asp:ListItem Value="Argentina">Argentina</asp:ListItem>
                <asp:ListItem Value="Brazil">Brazil</asp:ListItem>
                <asp:ListItem Value="Austria">Austria</asp:ListItem>
                <asp:ListItem Value="Italy">Italy</asp:ListItem>
                <asp:ListItem Value="Portugal">Portugal</asp:ListItem>
            </asp:DropDownList>
            <asp:GridView ID="GridView1" runat="server" style="margin-left: 10px" Width="191px"></asp:GridView>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" style="margin-left: 55px" Width="70px" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Select Product:"></asp:Label>
            &nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server" Height="20px" OnSelectedIndexChanged="DropDownList2_vaibhav" AutoPostBack="true">
                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; New Price:&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Price:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
            <br/>
            <br/>
        </div>
    </form>
</body>
</html>
