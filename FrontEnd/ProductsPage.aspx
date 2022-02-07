<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProductsPage.aspx.cs" Inherits="FrontEnd.ProductsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        <tr>
            <th style="font-size: 25px;" class="auto-style4">Products</th>
            <th class="auto-style5">Product 2</th>
            <th class="auto-style5">Product 3</th>
        </tr>
        <tr>
            <td id="ProductPhoto">Photo </td>
            <td id="ProductPhoto">Photo </td>
            <td id="ProductPhoto">Photo </td>
        </tr>
        <tr>
            <td>Title</td>
            <td>Title</td>
            <td>Title</td>
        </tr>
        <tr>
            <td>Price</td>
            <td>Price</td>
            <td>Price</td>
        </tr>
        <tr style="align-content: center">
            <td>
                <button>View Product</button></td>
            <td>
                <button>View Product</button></td>
            <td>
                <button>View Product</button></td>
        </tr>

    </table>
</asp:Content>
