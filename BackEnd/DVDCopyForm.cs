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
            DisplayDVDCopy();
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DisplayDVDCopy();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DVDCopyEntryForm newDVDCopy = new DVDCopyEntryForm(-1);
            newDVDCopy.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstDVDCopy.SelectedIndex != -1)
            {
             DVDCopyEntryForm entryform = new DVDCopyEntryForm(Convert.ToInt32(lstDVDCopy.SelectedValue));
                entryform.Show();
                this.Close();
            }
            else
            {
                lblError.Text = "Please select an item to edit.";
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsDVDCopyCollection dvdcopy = new clsDVDCopyCollection();
            Int32 DVDCopyID;
            Boolean Found;
            DialogResult Response;
            if (lstDVDCopy.SelectedIndex != -1)
            {
                DVDCopyID = Convert.ToInt32(lstDVDCopy.SelectedValue);
                Found = dvdcopy.thisDVDCopy.Find(DVDCopyID);
                Response = MessageBox.Show("Are you sure you want tot remove this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Response == DialogResult.Yes)
                {
                    if (Found)
                    {
                        dvdcopy.Delete();
                        DisplayDVDCopy();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenuForm Main = new MainMenuForm();
            this.Close();
            Main.Show();
        }



        Int32 DisplayDVDCopy()
        {
            List<KeyValuePair<int, string>> ListItems = new List<KeyValuePair<int, string>>();
            clsDVDCopyCollection DVDShop = new clsDVDCopyCollection();
            Int32 RecordCount;
            Int32 DVDCopyID;
            Int32 DVDID;
            string Condition;
            Int32 Index = 0;
            lstDVDCopy.DataSource = null;
            RecordCount = DVDShop.Count;
            while (Index < RecordCount)
            {
                DVDCopyID = Convert.ToInt32(DVDShop.DVDCopies[Index].DVDCopyID);
                DVDID = Convert.ToInt32(DVDShop.DVDCopies[Index].DVDID);
                Condition = Convert.ToString(DVDShop.DVDCopies[Index].Condition1);
                ListItems.Add( new KeyValuePair<int, string>(DVDCopyID, DVDID + " " + Condition));
                
                Index++;
            }
            lstDVDCopy.DataSource = ListItems;
            lstDVDCopy.ValueMember = "Key";
            lstDVDCopy.DisplayMember = "Value";
            return RecordCount;
        }

        private void lstDVDCopy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
