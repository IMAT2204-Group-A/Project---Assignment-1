using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryCJMKLtd;

namespace FrontEnd
{
    public partial class WebForm1 : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayDVDs("");
                GenresDisplay();
            }
            
        }
        Int32 DisplayDVDs(string GenreFilter)
        {
            clsDVDCollection MyDVDShop = new clsDVDCollection();

            Int32 RecordCount;
            int DVDID;
            string DVDName;
            //string DVDDescription;
            DateTime DVDDAteOfRelease;
            Int32 DVDLenght;
            Decimal DVDPrice;
            Int32 Index = 0;
            lstDVDs.Items.Clear();

            clsGenreCollection genre = new clsGenreCollection();
            genre.FilterByGenreName(GenreFilter);
            if (genre.Count == 1)
            {
                int genreId = genre.GenresList[0].GenreID;
                MyDVDShop.FilterByGenre(genreId);
            }
            else
            {
                if (GenreFilter == "")
                {
                    MyDVDShop.GetAll();
                }
            }
            RecordCount = MyDVDShop.Count;
            while (Index < RecordCount)
            {
                DVDID = Convert.ToInt32(MyDVDShop.DVDs[Index].DVDID);
                DVDName = Convert.ToString(MyDVDShop.DVDs[Index].DVDName);
               // DVDDescription = Convert.ToString(MyDVDShop.DVDs[Index].DVDDescription;
                DVDDAteOfRelease = Convert.ToDateTime(MyDVDShop.DVDs[Index].DVDDateOfRelease);
                DVDLenght = Convert.ToInt32(MyDVDShop.DVDs[Index].DVDLength);
                DVDPrice = Convert.ToDecimal(MyDVDShop.DVDs[Index].DVDPrice);
                ListItem NewItem = new ListItem(DVDID + " " + DVDName + " | " + DVDDAteOfRelease + " | " + DVDLenght + "min |  £" + DVDPrice, DVDID.ToString());
                lstDVDs.Items.Add(NewItem);

                Index++;
            }
            return RecordCount;
        }

        Int32 GenresDisplay()
        {
            clsGenreCollection MyDVDShop = new clsGenreCollection();
            Int32 RecordCount;
            Int32 GenreID;
            string GenreName;
            Int32 Index = 0;
            RecordCount = MyDVDShop.Count;
            while (Index < RecordCount)
            {
                GenreID = Convert.ToInt32(MyDVDShop.GenresList[Index].GenreID);
                GenreName = Convert.ToString(MyDVDShop.GenresList[Index].GenreName);
                ListItem NewItem = new ListItem(GenreName);
                ddlGenresFilter.Items.Add(NewItem);
                Index++;
            }
            return RecordCount;

        }

        protected void ddlGenresFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayDVDs(ddlGenresFilter.SelectedItem.ToString());
        }

        protected void lstDVDs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DisplayDVDs("");
            GenresDisplay();

        }

        protected void btnViewProduct_Click(object sender, EventArgs e)
        {
            Int32 DVDID;
            if (lstDVDs.SelectedIndex != -1)
            {
                DVDID = Convert.ToInt32(lstDVDs.SelectedValue);
                Session["DVDID"] = DVDID;
                Response.Redirect("pageIndividualProduct.aspx?DVDID=" + DVDID);

            }
            else
            {
                lblError.Text = "You must select a DVD Before viewing it!";
            }

        }
    }
}