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
    public partial class DVDCopyForm : Form
    {

        public DVDCopyForm()
        {
            InitializeComponent();
        }

        private void DVDCopyForm_Load(object sender, EventArgs e)
        {
            lstDVDCopy.Refresh();
            DisplayDVDCopy();
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DisplayDVDCopy();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenuForm Main = new MainMenuForm();
            this.Close();
            Main.Show();
        }



        Int32 DisplayDVDCopy()
        {
            clsDVDCopyCollection DVDShop = new clsDVDCopyCollection();
            Int32 RecordCount;
            Int32 DVDCopyID;
            Int32 DVDID;
            string Condition;
            Int32 Index = 0;
            lstDVDCopy.Items.Clear();
            RecordCount = DVDShop.Count;
            while (Index < RecordCount)
            {
                DVDCopyID = Convert.ToInt32(DVDShop.DVDCopies[Index].DVDCopyID);
                DVDID = Convert.ToInt32(DVDShop.DVDCopies[Index].DVDID);
                Condition = Convert.ToString(DVDShop.DVDCopies[Index].Condition1);
                ListItem NewItem = new ListItem(DVDCopyID + " " + DVDID + " " + Condition);
                lstDVDCopy.Items.Add(NewItem);

                Index++;
            }
            return RecordCount;
        }
    }
}
