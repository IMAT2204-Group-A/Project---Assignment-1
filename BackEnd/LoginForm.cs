using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BackEnd
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DMU Course\Year 2\Project management - Jai\Project\Project - Assignment 1\App_Data\DVDBook.mdf; Integrated Security=True;";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {

                lblLoginInfo.Text = "Please enter Login Details.";
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * From tblLogin where UserName=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)

                {
                    this.Hide();
                    MainMenuForm frm = new MainMenuForm();
                    frm.Show();
                }
                else
                {
                    lblLoginInfo.Text = "Login Unsucesfull, try checking if your details are correct!";
                }
                
            }
            catch (Exception ex)
            {
                lblLoginInfo.Text = (ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
