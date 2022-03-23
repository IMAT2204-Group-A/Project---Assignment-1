using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ClassLibraryCJMKLtd;


namespace BackEnd
{


    public partial class DVDListForm : Form
    {

        public DVDListForm()
        {
            InitializeComponent();
            

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DisplayDVDs("");
            cbGenreFilter.ResetText();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuForm mainform = new MainMenuForm();
            mainform.Show();
        }



        private void DVDList_Load(object sender, EventArgs e)
        {
            DisplayDVDs("");
            GenresDisplay();
            cbGenreFilter.ResetText();

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DVDReportForm reportform = new DVDReportForm();
            reportform.Show();
        }

        private void BtnSaveToFile_Click(object sender, EventArgs e)
        {

        }

        private void btnFindDVD_Click(object sender, EventArgs e)
        {

        }


        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtDVDList_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstDVDs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        Int32 DisplayDVDs(string GenreFilter)
        {

            List<KeyValuePair<int, string>> ListItems = new List<KeyValuePair<int, string>>();
            clsDVDCollection DVDShop = new clsDVDCollection();
            Int32 RecordCount;
            Int32 DVDID;
            string DVDName;
            string DVDDescription;
            DateTime DVDDateOfRelease;
            Int32 DVDLength;
            Decimal DVDPrice;
            Int32 SupplierID;
            string DVDImage;
            Int32 Index = 0;
            lstDVDs.DataSource = null;

            clsGenreCollection genre = new clsGenreCollection();
            genre.FilterByGenreName(GenreFilter);
            if (genre.Count == 1)
            {
                int genreId = genre.GenresList[0].GenreID;
                DVDShop.FilterByGenre(genreId);
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
                DVDID = Convert.ToInt32(DVDShop.DVDs[Index].DVDID);
                DVDName = Convert.ToString(DVDShop.DVDs[Index].DVDName);
                DVDDescription = Convert.ToString(DVDShop.DVDs[Index].DVDDescription);
                DVDDateOfRelease = Convert.ToDateTime(DVDShop.DVDs[Index].DVDDateOfRelease);
                DVDLength = Convert.ToInt32(DVDShop.DVDs[Index].DVDLength);
                DVDPrice = Convert.ToDecimal(DVDShop.DVDs[Index].DVDPrice);
                SupplierID = Convert.ToInt32(DVDShop.DVDs[Index].SupplierID);
                DVDImage = Convert.ToString(DVDShop.DVDs[Index].DVDImage);

                ListItems.Add(new KeyValuePair<int, string>(DVDID, DVDID + " " + DVDName + "  | "  + DVDDateOfRelease + " |  " + DVDLength + " |  " + DVDPrice + "  | " + SupplierID + "  | " + DVDImage));

                Index++;
            }
            lstDVDs.DataSource = ListItems;
            lstDVDs.ValueMember = "Key";
            lstDVDs.DisplayMember = "Value";
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
                cbGenreFilter.Items.Add(NewItem);
                Index++;
            }
            return RecordCount;

        }



        
        private void btnAdd_Click(object sender, EventArgs e)
        {

            DVDEntryForm NewDVD = new DVDEntryForm(-1);
            NewDVD.Show();

            this.Close();


        }

        private void cbGenreFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayDVDs(cbGenreFilter.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (lstDVDs.SelectedIndex != -1)
            {
                DVDEntryForm entryform = new DVDEntryForm(Convert.ToInt32(lstDVDs.SelectedValue));
                entryform.Show();

                this.Close();
                //to be changed - DVDID to new form

            }
            else
            {
                lblError.Text = "Please select an item to edit!";
            }
        }



        //Before Deleting DVD, DVDCopy Used by the DVDID in this list.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsDVDCollection dvd = new clsDVDCollection();

            Int32 DVDID;
            Boolean Found;
            DialogResult Response;
            if (lstDVDs.SelectedIndex != -1)
            {
                DVDID = Convert.ToInt32(lstDVDs.SelectedValue);

                Found = dvd.ThisDVD.Find(DVDID);
                Response = MessageBox.Show("Are you sure you want to remove this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Response == DialogResult.Yes)
                {
                    if (Found)
                    {
                        dvd.Delete();
                        DisplayDVDs("");
                    }
                }
            }
        }
    }
}
