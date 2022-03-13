<%@ Page Title="Products Page "  Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProductPageForm.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 52px;
        }
    </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 style="text-align:center;">Products Page</h1>
    <table style="width:100%">
        <tr>
            <th>DVD Title 1</th>
            <th>DVD Title 2</th>
            <th>DVD Title 3</th>
        </tr>
        <tr>
            <td>
                <img style="width:125px; height:125px;" src="" alt="Photo Product" />
            </td>
            <td>
                <img style="width:125px; height:125px;" src="" alt="Photo Product" />

            </td>
            <td>
                <img style="width:125px; height:125px;" src="" alt="Photo Product" /> 
            </td>
            
        </tr>
        <tr>
            <td>Title</td>
            <td>Title</td>
            <td>Title</td>
        </tr>
        <tr>
            <td class="auto-style1">Price</td>
            <td class="auto-style1">Price</td>
            <td class="auto-style1">Price</td>
        </tr>
        <tr>
            <td><button type="button" onclick="IndividualProductsPage.aspx">View Product</button></td>
            <td><button type="button "></button></td>
        </tr>

    </table>

</asp:Content>
