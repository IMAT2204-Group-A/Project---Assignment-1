<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProductListExample.aspx.cs" Inherits="FrontEnd.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        height: 744px;
    }
    .auto-style2 {
        position: absolute;
        top: 356px;
        left: 187px;
        z-index: 1;
        width: 216px;
        height: 273px;
    }
    .auto-style3 {
        position: absolute;
        top: 623px;
        left: 938px;
        z-index: 1;
        width: 156px;
        height: 28px;
    }
    .auto-style4 {
        position: absolute;
        top: 665px;
        left: 199px;
        z-index: 1;
    }
    .auto-style6 {
        position: absolute;
        top: 692px;
        left: 243px;
        z-index: 1;
        width: 117px;
        height: 36px;
    }
    .auto-style7 {
        position: absolute;
        top: 348px;
        left: 556px;
        z-index: 1;
        width: 216px;
        height: 273px;
    }
    .auto-style8 {
        position: absolute;
        top: 637px;
        left: 192px;
        z-index: 1;
        width: 160px;
    }
    .auto-style9 {
        position: absolute;
        top: 650px;
        left: 944px;
        z-index: 1;
    }
    .auto-style10 {
        position: absolute;
        top: 690px;
        left: 594px;
        z-index: 1;
        width: 117px;
        height: 36px;
    }
    .auto-style11 {
        position: absolute;
        top: 689px;
        left: 973px;
        z-index: 1;
        width: 117px;
        height: 36px;
    }
    .auto-style12 {
        position: absolute;
        top: 657px;
        left: 561px;
        z-index: 1;
        height: 23px;
    }
    .auto-style13 {
        position: absolute;
        top: 628px;
        left: 557px;
        z-index: 1;
        width: 156px;
        height: 33px;
    }
    .auto-style14 {
        position: absolute;
        top: 346px;
        left: 937px;
        z-index: 1;
        width: 216px;
        height: 273px;
    }
    .auto-style15 {
        position: absolute;
        top: 621px;
        left: 1328px;
        z-index: 1;
        width: 156px;
        height: 33px;
    }
    .auto-style16 {
        position: absolute;
        top: 686px;
        left: 1364px;
        z-index: 1;
        width: 116px;
        height: 36px;
    }
    .auto-style17 {
        position: absolute;
        top: 650px;
        left: 1340px;
        z-index: 1;
    }
    .auto-style18 {
        position: absolute;
        top: 346px;
        left: 1320px;
        z-index: 1;
        width: 216px;
        height: 273px;
    }
    .auto-style19 {
        position: absolute;
        top: 800px;
        left: 1817px;
        z-index: 1;
        width: 146px;
        height: 64px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style1">

        <asp:Label ID="lblDVDName" runat="server" CssClass="auto-style8"></asp:Label>
        <asp:Label ID="lblDVDPrice" runat="server" CssClass="auto-style4"></asp:Label>
        <asp:Button ID="btnViewProduct" runat="server" CssClass="auto-style6" Text="View" />
        <asp:Label ID="lblDVDName1" runat="server" CssClass="auto-style3"></asp:Label>
        <asp:Label ID="lblDVDPrice1" runat="server" CssClass="auto-style9"></asp:Label>
        <asp:Button ID="btnViewProduct1" runat="server" CssClass="auto-style11" Text="View" />
        <asp:ImageMap ID="DVDImage1" runat="server" CssClass="auto-style14">
        </asp:ImageMap>
        <asp:Label ID="lblDVDName2" runat="server" CssClass="auto-style15"></asp:Label>
        <asp:Label ID="lblDVDPrice2" runat="server" CssClass="auto-style17"></asp:Label>
        <asp:Button ID="btnViewProduct2" runat="server" CssClass="auto-style16" Text="View" />
        <asp:ImageMap ID="DVDImage2" runat="server" CssClass="auto-style18">
        </asp:ImageMap>
        <asp:Label ID="lblDVDName0" runat="server" CssClass="auto-style13"></asp:Label>
        <asp:Label ID="lblDVDPrice0" runat="server" CssClass="auto-style12"></asp:Label>
        <asp:Button ID="btnViewProduct0" runat="server" CssClass="auto-style10" Text="View" />
        <asp:ImageMap ID="DVDImage0" runat="server" CssClass="auto-style7">
        </asp:ImageMap>
        <asp:ImageMap ID="DVDImage" runat="server" CssClass="auto-style2">
        </asp:ImageMap>
        <asp:Button ID="btnNextPage" runat="server" CssClass="auto-style19" Text="Next" />

    </div>
</asp:Content>
