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
            clsDVDGenre ThisDVDGenre = new clsDVDGenre();
            
            string ErrorMessage;
            ErrorMessage = ThisDVD.DVDValid(txtDVDName.Text,
                                             txtDVDDescription.Text,
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
                    DVDShop.ThisDVD.DVDDateOfRelease = Convert.ToDateTime(String.Format("dd/mm/yyyy", txtDVDDateOfRelease.Text));
                    DVDShop.ThisDVD.DVDLength = Convert.ToInt32(txtDVDLenght.Text);
                    DVDShop.ThisDVD.DVDPrice = Convert.ToDecimal(txtDVDPrice.Text);
                    DVDShop.ThisDVD.SupplierID = Convert.ToInt32(txtSupplierID.Text);
                    DVDShop.ThisDVD.DVDImage = Convert.ToString(txtDVDImage.Text);



                            Int32 DVDIDADD = DVDShop.Add();

                            clsDVDGenreCollection DVDGenreShop = new clsDVDGenreCollection();
                            DVDGenreShop.ThisDVDGenre.DVDID = DVDIDADD;
                            DVDGenreShop.ThisDVDGenre.GenreID = Convert.ToInt32(lstGenreList.SelectedValue);
                            DVDGenreShop.Add();


                        
                    
                }
                else
                {
                    // DVDShop.ThisDVD.DVDID = Convert.ToInt32(txtDVDID.Text);
                    DVDShop.ThisDVD.DVDName = txtDVDName.Text;
                    DVDShop.ThisDVD.DVDDescription = txtDVDDescription.Text;
                    DVDShop.ThisDVD.DVDDateOfRelease = Convert.ToDateTime(String.Format("dd/mm/yyyy", txtDVDDateOfRelease.Text);
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
            string fileName = MyDVDShop.ThisDVD.DVDImage;//.Split('\\')[1];
            txtDVDImage.Text = fileName;
        }

        Int32 ShowGenres()
        {
            List<KeyValuePair<int, string>> ListItems = new List<KeyValuePair<int, string>>();
            clsGenreCollection Genres = new clsGenreCollection();
            Int32 GenreID;
            string GenreName;
            Int32 Index = 0;
            lstGenreList.DataSource = null;
            while (Index < Genres.Count)
            {
                GenreID = Genres.GenresList[Index].GenreID;
                GenreName = Genres.GenresList[Index].GenreName;
                ListItems.Add(new KeyValuePair<int, string>(GenreID, GenreName));
                Index++;

            }
            lstGenreList.DataSource = ListItems;
            lstGenreList.ValueMember = "Key";
            lstGenreList.DisplayMember = "Value";
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
                        path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 17)) + "FrontEnd";
                        System.IO.File.Copy(openFileDialog1.FileName, path + "\\Images\\" + txtDVDImage.Text);
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
