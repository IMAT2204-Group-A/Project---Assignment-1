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
    public partial class dvdStockForm : Form
    {
        public dvdStockForm()
        {
            InitializeComponent();
        }

        private void dvdStockForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dVDBookDataSet.tblDVD' table. You can move, or remove it, as needed.
            this.tblDVDTableAdapter.Fill(this.dVDBookDataSet.tblDVD);

        }

        private void btnAddDVD_Click(object sender, EventArgs e)
        {
            dvdEntryForm entryForm = new dvdEntryForm();
            entryForm.MdiParent = this.MdiParent;
            entryForm.Show();
            entryForm.addNewDVD();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuForm main = new MainMenuForm();
            main.Show();
        }

        private void btnEditDVD_Click(object sender, EventArgs e)
        {
            dvdEntryForm DVDEntry = new dvdEntryForm();
            int DVDID;
            if (lstDVDs.SelectedIndex != -1)
            {
                DVDID = Convert.ToInt32(value: lstDVDs.SelectedValue);
                DVDEntry.MdiParent = this.MdiParent;
                DVDEntry.Show();
                DVDEntry.FindDVD(DVDID);
            }
            else
            {
                lblErrorMessage.Text = "Please Select an Item from the list above.";
            }
        }
    }
}
