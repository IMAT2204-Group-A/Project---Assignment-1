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
    public partial class userEntryForm : Form
    {
        public userEntryForm()
        {
            InitializeComponent();
        }

        private void userEntryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dVDBookDataSet.tblLogin' table. You can move, or remove it, as needed.
            this.tblLoginTableAdapter.Fill(this.dVDBookDataSet.tblLogin);
            // TODO: This line of code loads data into the 'dVDBookDataSet.tblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.dVDBookDataSet.tblUser);
            this.Refresh();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.tblUserBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dVDBookDataSet);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void AddNewUser()
        {
            tblUserBindingSource.AddNew();
        }
        public void FindUser(int UserID)
        {
            tblUserBindingSource1.Filter = "UserID = " + Convert.ToString(UserID);
        }
        
    }
}
