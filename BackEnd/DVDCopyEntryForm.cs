using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using ClassLibraryCJMKLtd;

namespace BackEnd
{
    public partial class DVDCopyEntryForm : Form
    {
        Int32 DVDCopyID;
        public DVDCopyEntryForm(int id)
        {
            DVDCopyID = id;
            InitializeComponent();
        }
        private void DVDCopyEntryForm_Load(object sender, EventArgs e)
        {
            if (DVDCopyID != -1)
            {
                ShowDVDCopy(DVDCopyID);
            }
            ShowConditions();

            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            clsDVDCopyCollection DVDShop = new clsDVDCopyCollection();
            if (DVDCopyID == -1)
            {
                DVDShop.thisDVDCopy.DVDID = Convert.ToInt32(txtDVDID.Text);
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
        void ShowDVDCopy(Int32 DVDCopyID)
        {
            clsDVDCopyCollection MyDVDShop = new clsDVDCopyCollection();
            MyDVDShop.thisDVDCopy.Find(DVDCopyID);
            txtDVDID.Text = Convert.ToString(MyDVDShop.thisDVDCopy.DVDID);
            lstConditions.Text = Convert.ToString(MyDVDShop.thisDVDCopy.Condition1);
        }

        Int32 ShowConditions()
        {
            clsDVDCopyCollection Conditions = new clsDVDCopyCollection();

            Array conditions = (typeof(clsDVDCopy.Condition).GetEnumValues());

            foreach (object condition in conditions)
            {
                lstConditions.Items.Add(condition);
            }

            return conditions.Length;
             
        }

        public void FindDVDCopy(int DVDCopyID)
        {
            // .Find = "DVDCopyID =" + Convert.ToInt32(DVDCopyID);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DVDCopyForm form = new DVDCopyForm();
            form.Show();
            this.Close();
        }

        private void lstConditions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
