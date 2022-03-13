﻿using System;
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
   

    public partial class DVDListForm : Form
    {
        public DVDListForm()
        {
            InitializeComponent();
            DisplayDVDs("");
            cbGenreFilter.ResetText();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DisplayDVDs("");
            cbGenreFilter.ResetText();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuForm mainform = new MainMenuForm();
            mainform.Show();
        }



        private void DVDList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dVDBookDataSet.tblGenre' table. You can move, or remove it, as needed.
            this.tblGenreTableAdapter.Fill(this.dVDBookDataSet.tblGenre);

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DVDReportForm reportform = new DVDReportForm();
            reportform.Show();
        }

        private void BtnSaveToFile_Click(object sender, EventArgs e)
        {

        }

        private void btnFindDVD_Click(object sender, EventArgs e)
        {

        }


        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtDVDList_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstDVDs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        Int32 DisplayDVDs(string GenreFilter)
        {
            

            clsDVDCollection DVDShop = new clsDVDCollection();
            Int32 RecordCount;
            string DVDName;
            string DVDDescription;
            DateTime DVDDateOfRelease;
            Int32 DVDLength;
            Decimal DVDPrice;
            Int32 SupplierID;
            string DVDImage;
            Int32 Index = 0;
            lstDVDs.Items.Clear();

            clsGenreCollection genre = new clsGenreCollection();
            genre.FilterByGenreName(GenreFilter);
            if (genre.Count == 1)
            {
                int genreId = genre.GenresList[0].GenreID;
                DVDShop.FilterByGenre(genreId);
            }
            else
            {
                if (GenreFilter == "")
                {
                    DVDShop.GetAll();
                }
            }
            RecordCount = DVDShop.Count;
            while (Index < RecordCount)
            {
                DVDName = Convert.ToString(DVDShop.DVDs[Index].DVDName);
                DVDDescription = Convert.ToString(DVDShop.DVDs[Index].DVDDescription);
                DVDDateOfRelease = Convert.ToDateTime(DVDShop.DVDs[Index].DVDDateOfRelease);
                DVDLength = Convert.ToInt32(DVDShop.DVDs[Index].DVDLength);
                DVDPrice = Convert.ToDecimal(DVDShop.DVDs[Index].DVDPrice);
                SupplierID = Convert.ToInt32(DVDShop.DVDs[Index].SupplierID);
                DVDImage = Convert.ToString(DVDShop.DVDs[Index].DVDImage);
                ListItem NewItem = new ListItem(DVDName + "  | " + DVDDescription + " |  " + DVDDateOfRelease + " |  " + DVDLength + " |  " + DVDPrice + "  | " + SupplierID + "  | " + DVDImage);
                lstDVDs.Items.Add(NewItem);

                Index++;
            }
            return RecordCount;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            DVDEntryForm NewDVD = new DVDEntryForm();
            NewDVD.Show();
            
            this.Close();
        }

        private void cbGenreFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayDVDs(cbGenreFilter.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Int32 DVDID;
            if (lstDVDs.SelectedIndex != -1)
            {
                DVDEntryForm entryform = new DVDEntryForm();
                DVDID = Convert.ToInt32(lstDVDs.SelectedValue);
                //to be changed - DVDID to new form
                entryform.FindDVD(DVDID);
                entryform.Show();
            }
            else
            {
                lblError.Text = "Please select an item to edit!";
            }
        }
    }
}
