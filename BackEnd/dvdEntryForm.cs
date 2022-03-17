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

namespace BackEnd
{
    public partial class DVDEntryForm : Form
    {
        Int32 DVDID;

        public DVDEntryForm(int id)
        {
            DVDID = id;


            InitializeComponent();


        }

        private void dvdEntryForm_Load(object sender, EventArgs e)
        {

            //this.tblGenreTableAdapter.Fill(this.dVDBookDataSet.tblGenre);
            if (DVDID != -1)
            {
                ShowDVDs(DVDID);
            }
            ShowGenres();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsDVD ThisDVD = new clsDVD();
            string ErrorMessage;
            ErrorMessage = ThisDVD.DVDValid(txtDVDName.Text,
                                             txtDVDDescription.Text,
                                             Convert.ToDateTime(txtDVDDateOfRelease.Text),
                                             Convert.ToInt32(txtDVDLenght.Text),
                                             Convert.ToDecimal(txtDVDPrice.Text));
            if (ErrorMessage == "")
            {

                clsDVDCollection DVDShop = new clsDVDCollection();
                if (DVDID == -1)
                {
                    // DVDShop.ThisDVD.DVDID = Convert.ToInt32(txtDVDID.Text);
                    DVDShop.ThisDVD.DVDName = txtDVDName.Text;
                    DVDShop.ThisDVD.DVDDescription = txtDVDDescription.Text;
                    DVDShop.ThisDVD.DVDDateOfRelease = Convert.ToDateTime(txtDVDDateOfRelease.Text);
                    DVDShop.ThisDVD.DVDLength = Convert.ToInt32(txtDVDLenght.Text);
                    DVDShop.ThisDVD.DVDPrice = Convert.ToDecimal(txtDVDPrice.Text);
                    DVDShop.ThisDVD.SupplierID = Convert.ToInt32(txtSupplierID.Text);
                    DVDShop.ThisDVD.DVDImage = Convert.ToString(txtDVDImage.Text);

                    try
                    {
                        clsDataConnection con = new clsDataConnection();
                        string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                        if (filename == null)
                        {
                            MessageBox.Show("Please select a valid image.");
                        }
                        else
                        {
                            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 17)) + "FrontEnd";
                            System.IO.File.Copy(openFileDialog1.FileName, path + "\\Images\\" + filename);
                            DVDShop.Add();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message,  "File Already Exists");
                    }
                }
                else
                {
                    // DVDShop.ThisDVD.DVDID = Convert.ToInt32(txtDVDID.Text);
                    DVDShop.ThisDVD.DVDName = txtDVDName.Text;
                    DVDShop.ThisDVD.DVDDescription = txtDVDDescription.Text;
                    DVDShop.ThisDVD.DVDDateOfRelease = Convert.ToDateTime(txtDVDDateOfRelease.Text);
                    DVDShop.ThisDVD.DVDLength = Convert.ToInt32(txtDVDLenght.Text);
                    DVDShop.ThisDVD.DVDDescription = Convert.ToString(txtDVDDescription);   
                    DVDShop.ThisDVD.DVDPrice = Convert.ToDecimal(txtDVDPrice.Text);
                    DVDShop.ThisDVD.SupplierID = Convert.ToInt32(txtSupplierID.Text);
                    DVDShop.ThisDVD.DVDImage = Convert.ToString("\\Images\\" + txtDVDImage.Text);
                    DVDShop.Update();
                }

                this.Close();
                DVDListForm dvdList = new DVDListForm();
                dvdList.Show();
            }
            else
            {
                lblError.Text = ErrorMessage;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void FindDVD(int DVDID)
        {

            // = "DVDID =" + Convert.ToString(DVDID);
        }
        void ShowDVDs(Int32 DVDID)
        {
            clsDVDCollection MyDVDShop = new clsDVDCollection();
            MyDVDShop.ThisDVD.Find(DVDID);
            txtDVDName.Text = MyDVDShop.ThisDVD.DVDName;
            txtDVDDescription.Text = MyDVDShop.ThisDVD.DVDDescription;
            txtDVDDateOfRelease.Text = MyDVDShop.ThisDVD.DVDDateOfRelease.ToString("dd/mm/yyyy");
            txtDVDLenght.Text = Convert.ToString(MyDVDShop.ThisDVD.DVDLength);
            txtDVDPrice.Text = Convert.ToString(MyDVDShop.ThisDVD.DVDPrice);
            txtSupplierID.Text = Convert.ToString(MyDVDShop.ThisDVD.SupplierID);
            string fileName = MyDVDShop.ThisDVD.DVDImage.Split('\\')[2];
            txtDVDImage.Text = fileName;
        }

        Int32 ShowGenres()
        {
            clsGenreCollection Genres = new clsGenreCollection();
            string GenreID;
            string GenreName;
            Int32 Index = 0;
            while (Index < Genres.Count)
            {
                GenreID = Convert.ToString(Genres.GenresList[Index].GenreID);
                GenreName = Genres.GenresList[Index].GenreName;
                ListItem newGenre = new ListItem(GenreName);
                lstGenreList.Items.Add(newGenre);
                Index++;

            }
            return Genres.Count;
        }

        private void lstGenreList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select Image to be uploaded";
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.bmp; *.png;)|*.jpg; *.jpeg; *.bmp; *.png";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFileName(openFileDialog1.FileName);
                        txtDVDImage.Text = path;

                    }
                }
                else
                {
                    MessageBox.Show("Please Upload Image.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
