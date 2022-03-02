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
    public partial class dvdEntryForm : Form
    {
        Int32 DVDID;
        public dvdEntryForm()
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
                                             Convert.ToDateTime(DTPDVDDateOfRelease.Text),
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
                    DVDShop.ThisDVD.DVDDateOfRelease = Convert.ToDateTime(DTPDVDDateOfRelease.Text);
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
                    DVDShop.ThisDVD.DVDDateOfRelease = Convert.ToDateTime(DTPDVDDateOfRelease.Text);
                    DVDShop.ThisDVD.DVDLength = Convert.ToInt32(txtDVDLenght.Text);
                    DVDShop.ThisDVD.DVDPrice = Convert.ToDecimal(txtDVDPrice.Text);
                    DVDShop.ThisDVD.SupplierID = Convert.ToInt32(txtSupplierID.Text);
                    DVDShop.ThisDVD.DVDImage = Convert.ToString(txtDVDImage.Text);
                    DVDShop.Update();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public void FindDVD(int DVDID)
        {
        }
    }
}
