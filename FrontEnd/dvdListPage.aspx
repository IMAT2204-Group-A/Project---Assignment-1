<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="dvdListPage.aspx.cs" Inherits="FrontEnd.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 233px;
            left: 25px;
            z-index: 1;
            width: 2014px;
            height: 575px;
        }
        .auto-style2 {
            height: 746px;
        }
        .auto-style3 {
            position: absolute;
            top: 203px;
            left: 1944px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 204px;
            left: 1838px;
            right: 56px;
            z-index: 1;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style2">
        <asp:ListBox ID="lstDVDs" runat="server" CssClass="auto-style1" OnSelectedIndexChanged="lstDVDs_SelectedIndexChanged"></asp:ListBox>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style3" Font-Size="10pt">
        </asp:DropDownList>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style4" Text="Filter By Genre"></asp:Label>
    </p>
</asp:Content>
