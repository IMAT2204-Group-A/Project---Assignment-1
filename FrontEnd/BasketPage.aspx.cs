using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryCJMKLtd;


namespace FrontEnd
{
    public partial class Basket : System.Web.UI.Page
    {
        clsBasket MyBasket = new clsBasket();

        protected void Page_Load(object sender, EventArgs e)
        {
            //upon loading the page you need to read in the cart from the session object
            //MyBasket = (clsBasket)Session["MyBasket"];
            //display the cart contents
            DisplayBasket();
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //you must also save the cart every time the unload event takes place
            Session["MyBasket"] = MyBasket;
        }

        void DisplayBasket()
        {
            // Delete when merged
            clsBasketItem aItem = new clsBasketItem();
            aItem.DVDID = 2;
            aItem.Quantity = 4;

            clsBasketItem aItem2 = new clsBasketItem();
            aItem2.DVDID = 3;
            aItem2.Quantity = 2;

            MyBasket.Products.Add(aItem);
            MyBasket.Products.Add(aItem2);
            // end of delete when merge

            decimal OrderTotal = 0m;
            Int32 Index = 0;
            Int32 Count = MyBasket.Products.Count;
            Response.Write("<table border =\"1\">");
            Response.Write("<tr>");
            Response.Write("<td>");
            Response.Write("Product Id");
            Response.Write("</td>");
            Response.Write("<td>");
            Response.Write("Quantity");
            Response.Write("</td>");
            Response.Write("<td>");
            Response.Write("");
            Response.Write("</td>");
            Response.Write("</tr>");
            Response.Write("</tr>");
            while (Index < Count)
            {
                clsProducts aProduct = new clsProducts();
                aProduct.Find(MyBasket.Products[Index].DVDID);

                MyBasket.Products[Index].SubTotal = aProduct.Price * MyBasket.Products[Index].Quantity;
                OrderTotal += MyBasket.Products[Index].SubTotal;
                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(MyBasket.Products[Index].DVDID);
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(MyBasket.Products[Index].Quantity);
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(MyBasket.Products[Index].SubTotal);
                Response.Write("</td>");
                Response.Write("<td>");
                //Response.Write("<a href=\"RemoveOrderPage.aspx?Index=" + Index + "\">Remove</a>");
                Response.Write("<a href='RemoveOrderPage.aspx'>Remove</a>");
                Response.Write("</td>");
                Response.Write("</tr>");
                Index++;
            }
            MyBasket.TotalPrice = OrderTotal;

            Response.Write("<tr>");
            Response.Write("<td colspan='4'>");
            Response.Write(MyBasket.TotalPrice);

            Response.Write("<a href='CheckoutPage.aspx'>Checkout</a>");
            Response.Write("</td>");
            Response.Write("</tr>");
            Response.Write("</table>");
        }
    }
}