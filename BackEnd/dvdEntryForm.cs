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

namespace BackEnd
{
    public partial class DVDEntryForm : Form
    {
        Int32 DVDID;
        public DVDEntryForm()
        {
            InitializeComponent();
        }

        private void dvdEntryForm_Load(object sender, EventArgs e)
        {



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsDVD ThisDVD = new clsDVD();
            string ErrorMessage;
            ErrorMessage = ThisDVD.FilmValid(txtDVDName.Text,
                                             txtDVDDescription.Text,
                                             Convert.ToDateTime(txtDVDDateOfRelease.Text),
                                             Convert.ToInt32(txtDVDLenght.Text),
                                            Convert.ToDecimal(txtDVDPrice.Text),
                                            Convert.ToInt32(txtSupplierID.Text),
                                             txtDVDImage.Text);
            if (ErrorMessage == "")
            {
                clsDVDCollection DVDShop = new clsDVDCollection();
                if (DVDID == -1)
                {
                    DVDShop.ThisDVD.DVDID = Convert.ToInt32(txtDVDID);
                    DVDShop.ThisDVD.DVDName = txtDVDName.Text;
                    DVDShop.ThisDVD.DVDDescription = txtDVDDescription.Text;
                    DVDShop.ThisDVD.DVDDateOfRelease = Convert.ToDateTime(txtDVDDateOfRelease.Text);
                    DVDShop.ThisDVD.DVDLength = Convert.ToInt32(txtDVDLenght.Text);
                    DVDShop.ThisDVD.DVDPrice = Convert.ToDecimal(txtDVDPrice.Text);
                    DVDShop.ThisDVD.SupplierID = Convert.ToInt32(txtSupplierID.Text);
                    DVDShop.ThisDVD.DVDImage = Convert.ToString(txtDVDImage.Text);
                    DVDShop.Add();
                }
                else
                {
                    DVDShop.ThisDVD.DVDID = Convert.ToInt32(txtDVDID);
                    DVDShop.ThisDVD.DVDName = txtDVDName.Text;
                    DVDShop.ThisDVD.DVDDescription = txtDVDDescription.Text;
                    DVDShop.ThisDVD.DVDDateOfRelease = Convert.ToDateTime(txtDVDDateOfRelease.Text);
                    DVDShop.ThisDVD.DVDLength = Convert.ToInt32(txtDVDLenght.Text);
                    DVDShop.ThisDVD.DVDPrice = Convert.ToDecimal(txtDVDPrice.Text);
                    DVDShop.ThisDVD.SupplierID = Convert.ToInt32(txtSupplierID.Text);
                    DVDShop.ThisDVD.DVDImage = Convert.ToString(txtDVDImage.Text);
                    DVDShop.Update();
                }
                this.Close();
                DVDListForm dvdList = new DVDListForm();
                dvdList.Show();
            }
            else
            {
                lblError.Text = ErrorMessage;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            DVDListForm dvdList = new DVDListForm();
            dvdList.Show();

        }
        public void FindDVD(int DVDID)
        {
        }




        void ShowDVDs()
        {
            clsDVDCollection MyDVDShop = new clsDVDCollection();
            MyDVDShop.ThisDVD.Find(DVDID);
            txtDVDName.Text = MyDVDShop.ThisDVD.DVDName;
            txtDVDDescription.Text = MyDVDShop.ThisDVD.DVDDescription;
            txtDVDDateOfRelease.Text = MyDVDShop.ThisDVD.DVDDateOfRelease.ToString("dd/mm/yyyy");
            txtDVDLenght.Text = Convert.ToString(MyDVDShop.ThisDVD.DVDLength);
            txtDVDPrice.Text = Convert.ToString(MyDVDShop.ThisDVD.DVDPrice);
            txtSupplierID.Text = Convert.ToString(MyDVDShop.ThisDVD.SupplierID);
            txtDVDImage.Text = MyDVDShop.ThisDVD.DVDImage;
        }

        Int32 ShowGenres()
        {
            clsGenreCollection Genres = new clsGenreCollection();
            string GenreID;
            string GenreName;
            Int32 Index = 0;
            while (Index < Genres.Count)
            {
                GenreID = Convert.ToString(Genres.GenresList[Index].GenreID);
                GenreName = Genres.GenresList[Index].GenreName;
                ListItem newGenre = new ListItem(GenreID, GenreName);
                lstGenreList.Items.Add(newGenre);
                Index++;

            }
            return Genres.Count;
        }

        private void lstGenreList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
