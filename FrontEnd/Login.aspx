<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FrontEnd.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <p>
&nbsp;Email<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    </p>
    <p>
        Password
        <input id="password" type="password" /></p>
    <p>
        <asp:Button ID="btnLogin" runat="server" Text="Login" />
    </p>


</asp:Content>
