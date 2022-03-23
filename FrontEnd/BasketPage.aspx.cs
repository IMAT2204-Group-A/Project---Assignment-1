using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            //display the cart contents
            DisplayBasket();
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            Session["MyBasket"] = MyBasket;
        }

        void DisplayBasket()
        {
            StringBuilder sb = new StringBuilder();
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
            sb.Append("<table border =\"1\">");
            sb.Append("<tr>");
            sb.Append("<td>");
            sb.Append("Product Id");
            sb.Append("</td>");
            sb.Append("<td>");
            sb.Append("Quantity");
            sb.Append("</td>");
            sb.Append("<td>");
            sb.Append("");
            sb.Append("</td>");
            sb.Append("</tr>");
            sb.Append("</tr>");
            while (Index < Count)
            {
                clsProducts aProduct = new clsProducts();
                aProduct.Find(MyBasket.Products[Index].DVDID);

                MyBasket.Products[Index].SubTotal = aProduct.Price * MyBasket.Products[Index].Quantity;
                OrderTotal += MyBasket.Products[Index].SubTotal;
                sb.Append("<tr>");
                sb.Append("<td>");
                sb.Append(MyBasket.Products[Index].DVDID);
                sb.Append("</td>");
                sb.Append("<td>");
                sb.Append(MyBasket.Products[Index].Quantity);
                sb.Append("</td>");
                sb.Append("<td>");
                sb.Append(MyBasket.Products[Index].SubTotal);
                sb.Append("</td>");
                sb.Append("<td>");
                sb.Append("<a href=\"RemoveOrderPage.aspx?Index=" + Index + "\">Remove</a>");
                sb.Append("</td>");
                sb.Append("</tr>");
                Index++;
            }
            MyBasket.TotalPrice = OrderTotal;

            sb.Append("<tr>");
            sb.Append("<td colspan='4'>");
            sb.Append(MyBasket.TotalPrice);

            sb.Append("<a href='CheckoutPage.aspx'>Checkout</a>");
            sb.Append("</td>");
            sb.Append("</tr>");
            sb.Append("</table>");

            LiteralBasket.Text = sb.ToString();
        }
    }
}