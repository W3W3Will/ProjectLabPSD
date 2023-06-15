<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ProjectLab.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="EmailLabelHome" runat="server" Text="Your Email: "></asp:Label>
    <br />
    <br />
    <asp:ListBox ID="UserListBox" runat="server"></asp:ListBox>
    <br />
    <asp:Label ID="OnlineUserCountLabel" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Button ID="LofOutHome" runat="server" Text="LogOut" OnClick="LofOutHome_Click" />
    
</asp:Content>
