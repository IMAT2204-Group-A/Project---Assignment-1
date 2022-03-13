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
        public GenreEntryForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            DVDCopyForm Copyform = new DVDCopyForm();
            Copyform.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsGenreCollection DVDShop = new clsGenreCollection();
            if (GenreID == -1)
            {
                DVDShop.ThisGenre.GenreID = Convert.ToInt32(txtGenreID);
                DVDShop.ThisGenre.GenreName = Convert.ToString(txtGenreName);
                DVDShop.Add();
            }
        }

        private void GenreEntryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
