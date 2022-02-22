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
            //with the form opening, the login button will be disabled
            btnLogin.Enabled = true;
        }
        //Create string of to the source of the database.
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\DMU Course\Year 2\Project management - Jai\Project\Project - Assignment 1\App_Data\DVDBook.mdf; Integrated Security=True;";
        string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DMU Course\Year 2\Project management - Jai\Project\Project - Assignment 1\App_Data\DVDBook.mdf; Integrated Security=True;";
        //D:\DMU Course\Year 2\Project management - Jai\Project\Project - Assignment 1\App_Data\DVDBook.mdf;
        //H:\DMU Course\Year 2\Project management - Jai\Project\Project - Assignment 1\App_Data\DVDBook.mdf;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //when user clicks the login button, it will check both textboxes.
            //iF the boxes are empty then the message below will be displayed.
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {

                lblLoginInfo.Text = "Please enter Login Details.";
                return;
            }
            //if the condition isnt true, then the sql connection is made.
            try
            {
                //Change the SQLCONNECTION(CN/CS) When changing Computer...
                SqlConnection con = new SqlConnection(cn);
                //sql command selects all rows and checks where the username and password entered in the text boxes are maching with the ones in the datbase.
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
                    //if the rows are correct and are the same as the details entered by the user then main menu will be displayed.
                {
                    this.Hide();
                    MainMenuForm frm = new MainMenuForm();
                    frm.Show();
                }
                //If those are not correct, then a message below will be displayed.
                else
                {
                    
                    lblLoginInfo.Text = "Login Unsucesfull, try checking if your details are correct!";
                }
                
            }
            // if any other error occurs, such as  missing database, then it will be dispalyed as a messag
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
            btnLogin.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
