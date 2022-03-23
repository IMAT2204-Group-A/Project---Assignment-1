<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="pageDVDList.aspx.cs" Inherits="FrontEnd.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style1 {
            height: 861px;
        }
        .auto-style2 {
            position: absolute;
            top: 274px;
            left: 12px;
            z-index: 1;
            width: 1967px;
            height: 609px;
        }
        .auto-style3 {
            position: absolute;
            top: 230px;
            left: 20px;
            z-index: 1;
            width: 333px;
            height: 38px;
        }
        .auto-style4 {
            position: absolute;
            top: 253px;
            left: 1841px;
            z-index: 1;
            width: 136px;
            height: 33px;
        }
        .auto-style5 {
            position: absolute;
            top: 890px;
            left: 142px;
            z-index: 1;
            width: 100px;
            height: 47px;
        }
        .auto-style6 {
            position: absolute;
            top: 895px;
            left: 280px;
            z-index: 1;
            width: 1105px;
            height: 35px;
        }
        .auto-style7 {
            position: absolute;
            top: 254px;
            left: 1746px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 891px;
            left: 18px;
            z-index: 1;
            width: 98px;
            height: 44px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">

    <div class="auto-style1">

        <asp:ListBox ID="lstDVDs" runat="server" CssClass="auto-style2" Font-Size="23pt" OnSelectedIndexChanged="lstDVDs_SelectedIndexChanged"></asp:ListBox>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style3" Font-Size="30pt" Text="Product List"></asp:Label>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style6"></asp:Label>
        <asp:DropDownList ID="ddlGenresFilter" runat="server" CssClass="auto-style4" Font-Names="15pt" OnSelectedIndexChanged="ddlGenresFilter_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style7" Text="Genre Filter"></asp:Label>
        <asp:Button ID="btnViewProduct" runat="server" CssClass="auto-style5" OnClick="btnViewProduct_Click" Text="View Product" />
        <asp:Button ID="btnDisplayAll" runat="server" CssClass="auto-style8" OnClick="btnDisplayAll_Click" Text="Display All" />

    </div>
</asp:Content>

