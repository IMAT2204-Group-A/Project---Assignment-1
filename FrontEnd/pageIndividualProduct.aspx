<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="pageIndividualProduct.aspx.cs" Inherits="FrontEnd.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 759px;
        }
        .auto-style3 {
            position: absolute;
            top: 259px;
            left: 411px;
            z-index: 1;
            width: 305px;
            height: 30px;
        }
        .auto-style4 {
            position: absolute;
            top: 308px;
            left: 411px;
            z-index: 1;
            height: 160px;
            width: 387px;
        }
        .auto-style5 {
            position: absolute;
            top: 508px;
            left: 416px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 569px;
            left: 439px;
            z-index: 1;
            width: 119px;
            height: 38px;
        }
        .auto-style7 {
            position: absolute;
            top: 569px;
            left: 614px;
            z-index: 1;
            width: 113px;
            height: 38px;
        }
        .auto-style8 {
            position: absolute;
            top: 476px;
            left: 680px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 474px;
            left: 411px;
            z-index: 1;
            width: 61px;
            height: 18px;
        }
        .auto-style11 {
            position: absolute;
            top: 252px;
            left: 120px;
            z-index: 1;
            width: 202px;
            height: 234px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">                          
    <div class="auto-style1">

        <asp:TextBox ID="txtName" runat="server" CssClass="auto-style3" Enabled="False"></asp:TextBox>
        <asp:TextBox ID="txtDVDDescription" runat="server" CssClass="auto-style4" Enabled="False" OnTextChanged="txtDVDDescription_TextChanged" TextMode="MultiLine"></asp:TextBox>
        <asp:TextBox ID="txtDVDPrice" runat="server" CssClass="auto-style5" Enabled="False"></asp:TextBox>
        <asp:Button ID="btnAddToBasket" runat="server" CssClass="auto-style6" OnClick="btnAddToBasket_Click" Text="Add to Basket" />
        <asp:Button ID="btnBack" runat="server" CssClass="auto-style7" OnClick="btnBack_Click" Text="Back" />
        <asp:TextBox ID="txtDVDReleaseDate" runat="server" CssClass="auto-style8" Enabled="False"></asp:TextBox>
        <asp:TextBox ID="txtDVDLenght" runat="server" CssClass="auto-style9" Enabled="False"></asp:TextBox>
        <asp:ImageMap ID="DVDImage" runat="server" CssClass="auto-style11">
        </asp:ImageMap>
    </div>
</asp:Content>
