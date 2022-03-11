using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryCJMKLtd;


namespace FrontEnd
{
    public partial class Index : System.Web.UI.Page
    {
        clsBasket MyBasket = new clsBasket();

        protected void Page_Load(object sender, EventArgs e)
        {
            //upon loading the page you need to read in the cart from the session object
            MyBasket = (clsBasket)Session["MyBasket"];
            //if the cart is null then we need to initialise it
            if (MyBasket == null)
            {
                MyBasket = new clsBasket();
            }
            //then you can display how many items are in your cart
            lblCartCount.Text = MyBasket.Products.Count.ToString();
        }

        
    }
}