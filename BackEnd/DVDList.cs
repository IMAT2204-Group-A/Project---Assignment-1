using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackEnd
{
    public partial class DVDList : Form
    {
        public DVDList()
        {
            InitializeComponent();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //Opens new form, with the list of all DVDs In the database...
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuForm mainform = new MainMenuForm();
            mainform.Show();
        }

        private void DVDList_Load(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void BtnSaveToFile_Click(object sender, EventArgs e)
        {

        }

        private void btnFindDVD_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewDVD_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
