using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bugtracker
{
    public partial class User_registration_Panel : Form
    {
        String username, userRole;

        public User_registration_Panel(String username, String userRole)
        {
 
            InitializeComponent();
            this.username = username;
            this.userRole = userRole;
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void combo_usertype_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string firstname, lastname, username, password, email, usertype;
            firstname = txt_firstname.Text;
            lastname = txt_lastname.Text;
            username = txt_username.Text;
            password = txt_password.Text;
            email = txt_email.Text;
            usertype = combo_usertype.Text;

            if (string.IsNullOrEmpty(firstname))
            {
                MessageBox.Show("First name cannot be empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_firstname.Focus();

            }
            else if (string.IsNullOrEmpty(lastname))
            {
                MessageBox.Show("Last name cannot be empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_lastname.Focus();

            }
            else if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_username.Focus();

            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_password.Focus();

            }
            else if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email Address cannot be empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_password.Focus();

            }
            else
            {
                MySqlConnection databaseConnection = new MySqlConnection("datasource=localhost;username=root;password=umapunkoz;database=bugtracker;");
                databaseConnection.Open();
                MySqlCommand cmd = databaseConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into user_registration values('1','" + txt_firstname.Text + "'," +
                "'" + txt_lastname.Text + "','" + txt_username.Text + "','" + txt_password.Text + "','" + txt_email.Text + "','" + combo_usertype.Text + "')";
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
                MessageBox.Show("Sucessfully Registered !!");
            }
        }
    
  

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_firstname.Clear();
            txt_lastname.Clear();
            txt_username.Clear();
            txt_password.Clear();
            txt_email.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new DashBoard_Panel(this.username, this.userRole).Show();

           
            this.Hide();
        }
    }
}
