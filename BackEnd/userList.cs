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
            btnRemoveUser.Enabled = false;
            btnEdit.Enabled = false;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnRemoveUser.Enabled = true;

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            userEntryForm Users = new userEntryForm();
            int UserID;
            if (lstUser.SelectedIndex != -1)
            {
                UserID = Convert.ToInt32(value: lstUser.SelectedValue);
                Users.MdiParent = this.MdiParent;
                Users.Show();
                Users.FindUser(UserID);
            }
            else
            {
                lblErrorMessage.Text = "Please Select an User from the list above.";
            }
        }
    }
}
