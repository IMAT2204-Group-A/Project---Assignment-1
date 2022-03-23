<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="BasketPage.aspx.cs" Inherits="FrontEnd.Basket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Basket Page</h3>
    <input class="SearchBar" type="text" placeholder="Search.."/>
    <asp:Literal ID="LiteralBasket" runat="server"></asp:Literal>
    <br /><br />

</asp:Content>
