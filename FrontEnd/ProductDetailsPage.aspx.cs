using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class ProductDetailsPage : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnContinueShopping_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductsPage.aspx");
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            
        }
    }
}