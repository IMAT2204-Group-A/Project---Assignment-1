using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryCJMKLtd;

namespace BackEnd
{
    public partial class GenreEntryForm : Form
    {
        Int32 GenreID;
        public GenreEntryForm(int id)
        {
            GenreID = id;


            InitializeComponent();
        }

        private void GenreEntryForm_Load(object sender, EventArgs e)
        {
            if (GenreID != -1)
            {
                ShowGenres(GenreID);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsGenre ThisGenre = new clsGenre();
            string ErrorMessage;
            ErrorMessage = ThisGenre.GenreValid(txtGenreName.Text);

            if (ErrorMessage == "")
            {
                clsGenreCollection DVDShop = new clsGenreCollection();
                if (GenreID == -1)
                {
                    DVDShop.ThisGenre.GenreID = Convert.ToInt32(txtGenreID.Text);
                    DVDShop.ThisGenre.GenreName = Convert.ToString(txtGenreName.Text);
                    DVDShop.Add();
                }
                else
                {
                    DVDShop.ThisGenre.GenreID = Convert.ToInt32(txtGenreID.Text);
                    DVDShop.ThisGenre.GenreName = Convert.ToString(txtGenreName.Text);
                    DVDShop.Update();
                }
                this.Close();
                GenreListForm genrelist = new GenreListForm();
                genrelist.Show();
            }
            else
            {
                lblError.Text = ErrorMessage; 
            }

        }


        void ShowGenres(Int32 GenreID)
        {
            clsGenreCollection MyDVDShop = new clsGenreCollection();
            MyDVDShop.ThisGenre.Find(GenreID);
            txtGenreID.Text = Convert.ToString(MyDVDShop.ThisGenre.GenreID);
            txtGenreName.Text = MyDVDShop.ThisGenre.GenreName;



        }
        public void FindGenre(int GenreID)
        {
            // "GenreID =" + Convert.ToInt32(GenreID);
        }

    }
}
