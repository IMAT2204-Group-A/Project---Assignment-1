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
    public partial class DVDCopyEntryForm : Form
    {
        Int32 DVDCopyID;
        public DVDCopyEntryForm()
        {
            InitializeComponent();
        }
        private void DVDCopyEntryForm_Load(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            clsDVDCopyCollection DVDShop = new clsDVDCopyCollection();
            if (DVDCopyID == -1)
            {
                DVDShop.thisDVDCopy.DVDCopyID = Convert.ToInt32(txtDVDCopyID);
                DVDShop.thisDVDCopy.DVDID = Convert.ToInt32(txtDVDID);
                string condition_name = lstConditions.SelectedItem.ToString();
                if (condition_name == Convert.ToString(clsDVDCopy.Condition.poor))
                {
                    DVDShop.thisDVDCopy.Condition1 = clsDVDCopy.Condition.poor;
                }
                else if (condition_name == Convert.ToString(clsDVDCopy.Condition.fair))
                {
                    DVDShop.thisDVDCopy.Condition1 = clsDVDCopy.Condition.fair;
                } 
                else if (condition_name == Convert.ToString(clsDVDCopy.Condition.good))
                {
                    DVDShop.thisDVDCopy.Condition1 = clsDVDCopy.Condition.good;
                }
                else if (condition_name == Convert.ToString(clsDVDCopy.Condition.mint))
                {
                    DVDShop.thisDVDCopy.Condition1 = clsDVDCopy.Condition.mint;
                }
                    DVDShop.Add();

            }
            else
            {
                DVDShop.thisDVDCopy.DVDCopyID = Convert.ToInt32(txtDVDCopyID);
                DVDShop.thisDVDCopy.DVDID = Convert.ToInt32(txtDVDID);
                //Converto?
                string condition_name = lstConditions.SelectedItem.ToString();
                if (condition_name == Convert.ToString(clsDVDCopy.Condition.poor))
                {
                    DVDShop.thisDVDCopy.Condition1 = clsDVDCopy.Condition.poor;
                }
                else if (condition_name == Convert.ToString(clsDVDCopy.Condition.fair))
                {
                    DVDShop.thisDVDCopy.Condition1 = clsDVDCopy.Condition.fair;
                }
                else if (condition_name == Convert.ToString(clsDVDCopy.Condition.good))
                {
                    DVDShop.thisDVDCopy.Condition1 = clsDVDCopy.Condition.good;
                }
                else if (condition_name == Convert.ToString(clsDVDCopy.Condition.mint))
                {
                    DVDShop.thisDVDCopy.Condition1 = clsDVDCopy.Condition.mint;
                }
                    DVDShop.Update();

            }
            this.Close();
            DVDCopyForm dvdcopylist = new DVDCopyForm();
            dvdcopylist.Show();

        }
        void ShowDVDCopy()
        {
            clsDVDCopyCollection MyDVDShop = new clsDVDCopyCollection();
            txtDVDCopyID.Text = Convert.ToString(MyDVDShop.thisDVDCopy.DVDCopyID);
            txtDVDID.Text = Convert.ToString(MyDVDShop.thisDVDCopy.DVDID);
            lstConditions.Text = Convert.ToString(MyDVDShop.thisDVDCopy.Condition1);



        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DVDCopyForm form = new DVDCopyForm();
            form.Show();
            this.Close();
        }


    }
}
