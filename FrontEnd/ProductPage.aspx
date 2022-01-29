<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductPage.aspx.cs" Inherits="FrontEnd.ProductPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
    <title> Product Page: DVD Shop</title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <div id="Nav">
                <ul>
                    <li><a href="MasterPage.Master">Home Page</a></li>
                    <li><a href ="#news">News</a></li>
                    <li><a href="#contact">Contact</a></li>
                    <li><a href="#about">About</a></li>
                    <li style ="float: right"><a href="Find Store">Find Store</a></li>
                </ul>
            </div>
            <div id="LocationImage">
                <img src="Images/Location%20Image.png" />
            </div>
        </header>
    </form>
</body>
</html>
