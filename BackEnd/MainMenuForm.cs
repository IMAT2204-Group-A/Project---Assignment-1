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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            /*
            this.Close();
            LoginForm lgfm = new LoginForm();
            lgfm.Show();
            */
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            DVDListForm dvdlist = new DVDListForm();
            dvdlist.Show();
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {

        }
    }
}
