<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjectLab.View.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Login</h1>
    <asp:Label ID="UserLabel" runat="server" Text="Username"></asp:Label>
    <br />
    <asp:TextBox ID="UserTextBox" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
    <br />
    <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
    <br />
    <asp:CheckBox ID="RememberMeCheckBox" runat="server" Text="Remember Me"/>
    <br />
    <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click"/>
    <br />
    </asp:Content>
