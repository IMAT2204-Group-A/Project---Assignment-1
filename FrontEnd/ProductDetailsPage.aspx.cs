using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryCJMKLtd;


namespace FrontEnd
{
    public partial class ProductDetailsPage : System.Web.UI.Page
    {

        clsBasket MyBasket = new clsBasket();
        Int32 DVDID;

        protected void Page_Load(object sender, EventArgs e)
        {
            //upon loading the page you need to read in the cart from the session object
            MyBasket = (clsBasket)Session["MyBasket"];
            //you also need to get the product id from the query string
            DVDID = Convert.ToInt32(Request.QueryString["DVDID"]);
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //you must also save the cart every time the unload event takes place
            Session["MyBasket"] = MyBasket;
        }

        protected void btnContinueShopping_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductsPage.aspx");
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            //create a new instance of clsCartItem
            clsBasketItem AnItem = new clsBasketItem();
            //set the product id
            AnItem.DVDID = DVDID;
            //set the quantity
            AnItem.Quantity = Convert.ToInt32(txtQuantity.Text);
            //add the item to the cart's products collection
            MyBasket.Products.Add(AnItem);
            //go back to shopping
            Response.Redirect("Index.aspx");
        }

        
    }
}