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
    public partial class GenreListForm : Form
    {
        public GenreListForm()
        {
            InitializeComponent();
        }

        private void GenreListForm_Load(object sender, EventArgs e)
        {
            DisplayGenres();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GenreEntryForm EntryGenre = new GenreEntryForm(-1);
            
            EntryGenre.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstGenres.SelectedIndex != -1)
            {
                GenreEntryForm entryform = new GenreEntryForm(Convert.ToInt32(lstGenres.SelectedValue));
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
            clsGenreCollection genre = new clsGenreCollection();

            Int32 GenreID;
            Boolean Found;
            DialogResult Response;
            if (lstGenres.SelectedIndex != -1)
            {
                GenreID = Convert.ToInt32(lstGenres.SelectedValue);
                Found = genre.ThisGenre.Find(GenreID);
                Response = MessageBox.Show("Are you sure you want to remove this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Response == DialogResult.Yes)
                {
                    if (Found)
                    {
                        genre.Delete();
                        DisplayGenres();
                    }
                }
            }
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DisplayGenres();
        }

        Int32 DisplayGenres()
        {
            List<KeyValuePair<int, string>> ListItems = new List<KeyValuePair<int, string>>();
            clsGenreCollection GenreCollection = new clsGenreCollection();
            Int32 RecordCount;
            Int32 GenreID;
            string GenreName;
            Int32 Index = 0;
            lstGenres.DataSource = null;
            RecordCount = GenreCollection.Count;
            while (Index < RecordCount)
            {
                GenreID = Convert.ToInt32(GenreCollection.GenresList[Index].GenreID);
                GenreName = Convert.ToString(GenreCollection.GenresList[Index].GenreName);
                ListItems.Add(new KeyValuePair<int, string>(GenreID, GenreID + "   " + GenreName));
                
                Index++;
            }
            lstGenres.DataSource = ListItems;
            lstGenres.ValueMember = "Key";
            lstGenres.DisplayMember = "Value";
            return RecordCount;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        private void lstGenres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
