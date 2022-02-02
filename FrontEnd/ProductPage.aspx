<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductPage.aspx.cs" Inherits="FrontEnd.ProductPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Page: DVD Shop</title>
    <link href="SyleSheets/StyleSheet.css" rel="stylesheet" />
    <style type="text/css">

        .auto-style1 {
            width: 67px;
            height: 47px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <div id="Logo">
                <img src="https://via.placeholder.com/150" />
            </div>
            <div id="Nav" >
                <ul style="width: max-content">
                    <li><a href="MasterPage.Master">Home Page</a></li>
                    <li><a href="#news">News</a></li>
                    <li><a href="#contact">Contact</a></li>
                    <li><a href="#about">About</a></li>
                    <li style="float: right"><a href="Find Store">Find Store</a></li>

                </ul>
                <ul style="float: right">
                    <li><a href="#Login">Login</a></li>
                    <li><a href="#SignIn">Sign In</a></li>
                </ul>
            </div>
            <div id="LocationImage">
                <img src="Images/Location%20Image.png" />
            </div>
        </header>


        <div id="MainContent">
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
                <tr style="align-content:center">
                    <td>
                        <button>View Product</button></td>
                    <td>
                        <button>View Product</button></td>
                    <td>
                        <button>View Product</button></td>
                </tr>

            </table>
        </div>

        <div id="footer">
            <table style="width: 100%">
                <tr>
                    <th>Sign Up For Emails</th>
                    <th>Useful Information</th>
                    <th>Careers</th>
                    
                </tr>
                <tr>
                    <td>
                        <input /> <button> Submit</button>
                    </td>
                    <td><button>Help Centre</button></td>
                    <td><button>Carrer.com</button> </td>
                    <td><img src="Images/Location Image.png"/></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
