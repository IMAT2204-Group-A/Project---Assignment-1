using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace FrontEnd
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayDVD();
            }
        }


        Int32 DisplayDVD()
        {
            clsDVDCollection DVDShop = new clsDVDCollection();
            Int32 RecordCount;
            Int32 DVDID;
            string DVDName;
            Decimal DVDPrice;
            string DVDImage1;
            Int32 Index = 0;


            RecordCount = DVDShop.Count;
            while (Index < RecordCount)
            {
                DVDID = Convert.ToInt32(DVDShop.DVDs[Index].DVDID);
                DVDName = Convert.ToString(DVDShop.DVDs[Index].DVDName);
                DVDPrice = Convert.ToDecimal(DVDShop.DVDs[Index].DVDPrice);
                DVDImage1 = Convert.ToString(DVDShop.DVDs[Index].DVDImage);
                ListItem NewItem = new ListItem(DVDName + " " + DVDPrice + " " + DVDImage1);

                Index++;
            }
            return RecordCount;

        }

        Int32 DisplayDVD1(Int32 DVDID)
        {
            clsDVD MyDVDShop1 = new clsDVD();
            clsDVDCollection MyDVDShop = new clsDVDCollection();
            Int32 RecordCount;
            Int32 Index = 0;
            RecordCount = MyDVDShop.Count;
            while (Index < RecordCount)
            {
                MyDVDShop1.Find(DVDID);
                lblDVDName.Text = MyDVDShop1.DVDName;
                lblDVDPrice.Text = Convert.ToString(MyDVDShop1.DVDPrice);
                DVDImage.ImageUrl = MyDVDShop1.DVDImage;
                Index++;
            }
            return RecordCount;


        }
        protected void btnNextPage_Click(object sender, EventArgs e)
        {

        }

        protected void btnViewProduct1_Click(object sender, EventArgs e)
        {

        }

        protected void DVDImage_Click(object sender, ImageMapEventArgs e)
        {

        }
    }

}