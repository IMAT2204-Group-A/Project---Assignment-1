<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProductDetailsPage.aspx.cs" Inherits="FrontEnd.ProductDetailsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 188px;
            left: 91px;
        }
        .auto-style2 {
            position: absolute;
            top: 215px;
            left: 0px;
        }
        .auto-style3 {
            position: absolute;
            top: 264px;
            left: 0px;
            z-index: 1;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Qunatity<asp:TextBox ID="txtQuantity" runat="server" CssClass="auto-style1" style="z-index: 1"></asp:TextBox>
    <br />
    <asp:Button ID="btnAddToCart" runat="server" CssClass="auto-style2" OnClick="btnAddToCart_Click" style="z-index: 1" Text="Add to Cart" />
    <br />
    <br />
    <asp:Button ID="btnContinueShopping" runat="server" CssClass="auto-style3" OnClick="btnContinueShopping_Click" Text="Continue Shopping" />
&nbsp;
</asp:Content>
