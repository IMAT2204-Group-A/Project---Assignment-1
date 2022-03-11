using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryCJMKLtd;

namespace FrontEnd
{
    public partial class CheckoutPage : System.Web.UI.Page
    {

        clsBasket MyBasket = new clsBasket();

        protected void Page_Load(object sender, EventArgs e)
        {
            //upon loading the page you need to read in the cart from the session object
            MyBasket = (clsBasket)Session["MyBasket"];
            MyBasket.UserID = 1;

            //if we don't know who the user is we need them to log in
            if (MyBasket.UserID == 0)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //you must also save the cart every time the unload event takes place
            Session["MyBasket"] = MyBasket;
        }

        protected void btnCheckOut_Click(object sender, EventArgs e)
        {
            //test to see that card details are entered
            if (txtCardNo.Text != "")
            {
                //save the card no
                MyBasket.CardNo = txtCardNo.Text;
                MyBasket.Checkout();
                Response.Redirect("ConfirmOrderPage.aspx");
            }
            else
            {
                lblError.Text = "Payment details not valid";
            }
        }
    }
}