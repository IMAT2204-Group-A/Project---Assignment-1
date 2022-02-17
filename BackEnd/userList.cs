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
    public partial class userList : Form
    {
        public userList()
        {
            InitializeComponent();
        }

        private void userList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dVDBookDataSet.tblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.dVDBookDataSet.tblUser);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuForm Main = new MainMenuForm();
            Main.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            userEntryForm Entryform = new userEntryForm();
            Entryform.MdiParent = this.MdiParent;
            Entryform.Show();
            Entryform.AddNewUser();
        }
    }
}
