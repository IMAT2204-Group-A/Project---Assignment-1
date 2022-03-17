using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Int32 DVDID;
        protected void Page_Load(object sender, EventArgs e)
        {
            DVDID = Convert.ToInt32(Request.QueryString["DVDID"]);
            if (IsPostBack != true)
            {
                if (DVDID != -1)
                {
                    DisplayDVD(DVDID);
                }
            }
        }

        protected void btnAddToBasket_Click(object sender, EventArgs e)
        {

        }



        void DisplayDVD(Int32 DVDID)
        {
            clsDVD MyDVDShop = new clsDVD();
            MyDVDShop.Find(DVDID);
            txtName.Text = MyDVDShop.DVDName;
            txtDVDDescription.Text = MyDVDShop.DVDDescription;
            txtDVDLenght.Text = Convert.ToString(MyDVDShop.DVDLength);
            txtDVDReleaseDate.Text = MyDVDShop.DVDDateOfRelease.ToString("dd/mm/yyyy");
            txtDVDPrice.Text = Convert.ToString(MyDVDShop.DVDPrice);
            
            DVDImage.ImageUrl = Convert.ToString(MyDVDShop.DVDImage);

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("pageDVDList.aspx");
        }

        protected void txtDVDDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}