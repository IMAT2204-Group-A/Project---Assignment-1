<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="pageIndividualProduct.aspx.cs" Inherits="FrontEnd.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 759px;
        }
        .auto-style6 {
            position: absolute;
            top: 644px;
            left: 559px;
            z-index: 1;
            width: 119px;
            height: 38px;
        }
        .auto-style7 {
            position: absolute;
            top: 640px;
            left: 821px;
            z-index: 1;
            width: 113px;
            height: 38px;
        }
        .auto-style11 {
            position: absolute;
            top: 261px;
            left: 193px;
            z-index: 1;
            width: 294px;
            height: 332px;
        }
        .auto-style13 {
            position: absolute;
            top: 263px;
            left: 527px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 310px;
            left: 525px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: 496px;
            left: 522px;
            z-index: 1;
        }
        .auto-style16 {
            position: absolute;
            top: 571px;
            left: 521px;
            z-index: 1;
        }
        .auto-style17 {
            position: absolute;
            top: 529px;
            left: 522px;
            z-index: 1;
        }
        .auto-style19 {
            position: absolute;
            top: 259px;
            left: 632px;
            z-index: 1;
            height: 28px;
        }
        .auto-style20 {
            position: absolute;
            top: 309px;
            left: 632px;
            z-index: 1;
            height: 171px;
            width: 410px;
        }
        .auto-style21 {
            position: absolute;
            top: 492px;
            left: 637px;
            z-index: 1;
            width: 201px;
            height: 33px;
        }
        .auto-style22 {
            position: absolute;
            top: 528px;
            left: 639px;
            z-index: 1;
            height: 27px;
        }
        .auto-style23 {
            position: absolute;
            top: 566px;
            left: 640px;
            z-index: 1;
            height: 23px;
            width: 165px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">                          
    <div class="auto-style1">

        <asp:Label ID="lblDVDLenght" runat="server" CssClass="auto-style22" Font-Size="15pt"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" CssClass="auto-style23" Font-Size="15pt"></asp:Label>
        <asp:Label ID="Label5" runat="server" CssClass="auto-style17" Text="Lenght"></asp:Label>
        <asp:Label ID="Label4" runat="server" CssClass="auto-style16" Text="Price:"></asp:Label>
        <asp:Button ID="btnAddToBasket" runat="server" CssClass="auto-style6" OnClick="btnAddToBasket_Click" Text="Add to Basket" />
        <asp:Button ID="btnBack" runat="server" CssClass="auto-style7" OnClick="btnBack_Click" Text="Back" BackColor="#CCCCCC" />
        <asp:ImageMap ID="DVDImage" runat="server" CssClass="auto-style11" OnClick="DVDImage_Click">
        </asp:ImageMap>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style13" Text="Name"></asp:Label>
        <asp:Label ID="Label3" runat="server" CssClass="auto-style15" Text="Release Date"></asp:Label>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style14" Text="Description"></asp:Label>
        <asp:Label ID="lblDVDName" runat="server" CssClass="auto-style19" Font-Size="19pt"></asp:Label>
        <asp:Label ID="lblDVDDescription" runat="server" CssClass="auto-style20" Font-Size="16pt"></asp:Label>
        <asp:Label ID="lblDVDReleaseDate" runat="server" CssClass="auto-style21" Font-Size="15pt"></asp:Label>
    </div>
</asp:Content>
