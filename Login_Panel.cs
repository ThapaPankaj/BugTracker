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
    public partial class Login_Panel : Form
    {
       
      
        public Login_Panel()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
          
            
            string username, password, usertype;
            username = txt_username.Text;
            password = txt_password.Text;
            usertype = combo_usertype.Text;


            //Data validiation
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please Enter Your Username!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if ((string.IsNullOrEmpty(password)))
            {
                MessageBox.Show("Please Enter Your Password!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

              //making connection with mysql workbech database
                MySqlConnection databaseConnection = new MySqlConnection("datasource=localhost;username=root;password=umapunkoz;database=bugtracker;");
                
                //for checking if the respective username exists or not inorder to login into admin dashboard
                databaseConnection.Open();
                MySqlCommand cmd = databaseConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from user_registration where username ='" + txt_username.Text + "' and password = '" + txt_password.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                usertype = combo_usertype.SelectedItem.ToString();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["User_type"].ToString() == usertype)
                        {
                            MessageBox.Show("Sucessfully login" +"_" + " Admin " +"_" +dt.Rows[i][2]);
                            if (combo_usertype.SelectedIndex == 0)
                            {
                                Admin_Panel adminpanel = new Admin_Panel();
                             //   Admin_Dashboard_Panel adminpanel = new Admin_Dashboard_Panel();
                                adminpanel.Show();
                                this.Hide();
                            }
                            else if (combo_usertype.SelectedIndex == 1)
                            {

                            }
                            else
                            {

                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Username and Password");

                }


            }
        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            User_registration_Panel userregistration = new User_registration_Panel();
            userregistration.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void combo_usertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
