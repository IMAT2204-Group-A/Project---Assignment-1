<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CheckoutPage.aspx.cs" Inherits="FrontEnd.CheckoutPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 207px;
            left: 150px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 238px;
            left: 186px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 242px;
            left: 343px;
        z-index: 1;
    }
    .auto-style4 {
        position: absolute;
        top: 244px;
        left: 9px;
        z-index: 1;
        right: 912px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Credit Card Number<asp:TextBox ID="txtCardNo" runat="server" CssClass="auto-style1"></asp:TextBox>
    <br />
    <asp:Label ID="lblError" runat="server" CssClass="auto-style4"></asp:Label>
    <br />
    <asp:Button ID="btnCheckOut" runat="server" CssClass="auto-style2" OnClick="btnCheckOut_Click" Text="Check Out" />
<asp:Button ID="btnBack" runat="server" CssClass="auto-style3" OnClick="btnBack_Click" Text="Back" />
</asp:Content>
    