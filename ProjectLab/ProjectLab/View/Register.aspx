<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ProjectLab.View.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Register</h1>
    <br />
    <asp:Label ID="EmailLabel" runat="server" Text="Email"></asp:Label>
    <br />
    <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
    <asp:CustomValidator ID="CustomValidatorEmail" runat="server" ErrorMessage="CustomValidator" ControlToValidate="EmailTextBox" OnServerValidate="CustomValidatorEmail_ServerValidate"></asp:CustomValidator>
    <br />
    <asp:Label ID="UserRegisterLabel" runat="server" Text="Username"></asp:Label>
    <br />
    <asp:TextBox ID="UserRegisterTextBox" runat="server"></asp:TextBox>
    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator" ControlToValidate="UserRegisterTextBox" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
    <br />
    <asp:Label ID="GenderLabel" runat="server" Text="Gender"></asp:Label>
    <br />
    <asp:DropDownList ID="GenderDropDownList" runat="server"></asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="GenderDropDownList"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="PasswordRegisterLabel" runat="server" Text="Password"></asp:Label>
    <br />
    <asp:TextBox ID="PasswordRegisterTextBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="PasswordRegisterTextBox" ValidationGroup="password_validate"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="ConfirmPasswordLabel" runat="server" Text="Confirm Password"></asp:Label>
    <br />
    <asp:TextBox ID="ConfirmPasswordTextBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="ConfirmPasswordTextBox" ValidationGroup="password_validate"></asp:RequiredFieldValidator>
    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator" ControlToValidate="ConfirmPasswordTextBox" ValidationGroup="password_validate" ValueToCompare="PasswordRegisterLabel"></asp:CompareValidator>
    <br />
    <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click"/>
</asp:Content>
