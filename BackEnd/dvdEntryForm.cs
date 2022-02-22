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
        public dvdEntryForm()
        {
            InitializeComponent();
        }

        private void tblDVDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblDVDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dVDBookDataSet);

        }

        private void dvdEntryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dVDBookDataSet.tblDVDGenre' table. You can move, or remove it, as needed.
            this.tblDVDGenreTableAdapter.Fill(this.dVDBookDataSet.tblDVDGenre);
            // TODO: This line of code loads data into the 'dVDBookDataSet.tblDVDGenre' table. You can move, or remove it, as needed.
            this.tblDVDGenreTableAdapter.Fill(this.dVDBookDataSet.tblDVDGenre);
            // TODO: This line of code loads data into the 'dVDBookDataSet.tblDVD' table. You can move, or remove it, as needed.
            this.tblDVDTableAdapter.Fill(this.dVDBookDataSet.tblDVD);

        }
        public void addNewDVD()
        {
            tblDVDBindingSource.AddNew();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.tblDVDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dVDBookDataSet);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public void FindDVD(int DVDID)
        {
            tblDVDBindingSource.Filter = "DVDID =" + Convert.ToString(DVDID);
        }
    }
}
