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

        }

        protected void lstDVDs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }









        Int32 DisplayDVDs(string GenreFilter)
        {
            clsDVDCollection DVDShop = new clsDVDCollection();
            Int32 RecordCount;
            string DVDName;
            string DVDDescription;
            DateTime DVDDateOfRelease;
            Int32 DVDLength;
            Decimal DVDPrice;
            Int32 SupplierID;
            string DVDImage;
            Int32 Index = 0;
            lstDVDs.Items.Clear();

            clsGenreCollection genre = new clsGenreCollection();
            genre.FilterByGenreName(GenreFilter);
            if (genre.Count == 1)
            {
                int GenreID = genre.GenresList[0].GenreID;
                DVDShop.FilterByGenre(GenreID);
            }
            else
            {
                if (GenreFilter == "")
                {
                    DVDShop.GetAll();
                }
            }
            RecordCount = DVDShop.Count;
            while (Index < RecordCount)
            {
                DVDName = Convert.ToString(DVDShop.DVDs[Index].DVDName);
                DVDDescription = Convert.ToString(DVDShop.DVDs[Index].DVDDescription);
                DVDDateOfRelease = Convert.ToDateTime(DVDShop.DVDs[Index].DVDDateOfRelease);
                DVDLength = Convert.ToInt32(DVDShop.DVDs[Index].DVDLength);
                DVDPrice = Convert.ToDecimal(DVDShop.DVDs[Index].DVDPrice);
                SupplierID = Convert.ToInt32(DVDShop.DVDs[Index].SupplierID);
                DVDImage = Convert.ToString(DVDShop.DVDs[Index].DVDImage);
                ListItem NewItem = new ListItem(DVDName + "  |  " + DVDDescription + "  |  " + DVDDateOfRelease + "  |  " + DVDLength + "In Minutes" + DVDImage);
                lstDVDs.Items.Add(NewItem);

                Index++;
            }
            return RecordCount;
        }


    }
}