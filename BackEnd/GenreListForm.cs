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
            DisplayGenres();
        }

        private void GenreListForm_Load(object sender, EventArgs e)
        {

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

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DisplayGenres();
        }

        Int32 DisplayGenres()
        {
            clsGenreCollection GenreCollection = new clsGenreCollection();
            Int32 RecordCount;
            Int32 GenreID;
            string GenreName;
            Int32 Index = 0;
            lstGenres.Items.Clear();
            RecordCount = GenreCollection.Count;
            while (Index < RecordCount)
            {
                GenreID = Convert.ToInt32(GenreCollection.GenresList[Index].GenreID);
                GenreName = Convert.ToString(GenreCollection.GenresList[Index].GenreName);
                ListItem Newitem = new ListItem(GenreID + "   " + GenreName);
                lstGenres.Items.Add(Newitem);
                Index++;
            }
            return RecordCount;
        }
        
    }
}
