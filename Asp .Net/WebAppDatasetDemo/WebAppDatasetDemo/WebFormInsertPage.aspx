<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="WebFormInsertPage.aspx.cs" Inherits="WebAppDatasetDemo.WebFormInsertPage" %>

<asp:Content ID="in123" ContentPlaceHolderID="MainContent" runat="server">
    <br/><br/>
    <asp:Label ID="Label1" runat="server" Text="Student No:"></asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
    <br /><br/>
    <asp:Label ID="Label2" runat="server" Text="Student Name:"></asp:Label>&nbsp&nbsp<asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
    <br /><br/>
    <asp:Label ID="Label3" runat="server" Text="Course:"></asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
    <br /><br/>
    <asp:Label ID="Label4" runat="server" Text="Course Fee:"></asp:Label>&nbsp&nbsp&nbsp&nbsp&nbsp; <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox>
    <br /><br/>
    <asp:Label ID="Label5" runat="server" Text="Age:"></asp:Label>&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp<asp:TextBox ID="TextBox5" runat="server" ></asp:TextBox>
    <br /><br/>
    <asp:Label ID="Label6" runat="server" Text="Gender:"></asp:Label>&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp<asp:TextBox ID="TextBox6" runat="server" ></asp:TextBox>
    <br /><br/>
    <asp:Button runat="server" Text="Insert" OnClick="Button_Click"/>
    &nbsp &nbsp 
    <asp:Button runat="server" Text="Update" OnClick="Update_Button" />
    &nbsp &nbsp
    <asp:Button runat="server" Text="Delete" OnClick="Delete_Button" />
    &nbsp &nbsp
    <asp:Button ID="Button1" runat="server" Text="Show" OnClick="Show_Button"/>

</asp:Content>
