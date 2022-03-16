<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CheckoutPage.aspx.cs" Inherits="FrontEnd.CheckoutPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 209px;
            left: 199px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 241px;
            left: 167px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 242px;
            left: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Credit Card Number<asp:TextBox ID="txtCardNo" runat="server" CssClass="auto-style1"></asp:TextBox>
    <br />
    <asp:Label ID="lblError" runat="server" CssClass="auto-style3" style="z-index: 1"></asp:Label>
    <br />
    <asp:Button ID="btnCheckOut" runat="server" CssClass="auto-style2" OnClick="btnCheckOut_Click" Text="Check Out" />
</asp:Content>
    