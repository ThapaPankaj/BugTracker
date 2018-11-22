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
    public partial class DashBoard_Panel : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=localhost;username=root;password=umapunkoz;database=bugtracker;");

        String username, userRole;

        public DashBoard_Panel(String username, String userRole)
        {
            InitializeComponent();
            display_bugfix_data();
            this.username = username;
            this.userRole = userRole;
            if (userRole == "Developer")
            {
                btn_adduser.Visible = false;
                btn_add_project.Visible = false;

            }
            if (userRole == "Tester")
            {
                btn_adduser.Visible = false;
                btn_add_project.Visible = false;
                btn_bug_fix.Visible = false;

            }
        }

        public void display_bugfix_data()
        {
            listViewCompleted.Clear();
            String query = "select * from bugfix where bugfix_status = 'Completed'";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                string bug = dt.Rows[0].Field<String>("resolve_code");

                foreach (DataColumn column in dt.Columns)
                {
                    listViewCompleted.Columns.Add(column.ColumnName, -2, HorizontalAlignment.Left);
                }
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());

                    }
                    listViewCompleted.Items.Add(item);
                    listViewCompleted.View = View.Details;
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txt_time_TextChanged(object sender, EventArgs e)
        {

        }

        private void DashBoard_Panel_Load(object sender, EventArgs e)
        {
            txt_time.Text = DateTime.Now.ToLongDateString();
           


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_add_project_Click(object sender, EventArgs e)
        {
            new Project_Panel(this.username, this.userRole).Show();
            
            this.Hide();
        }

        private void btn_bug_details_Click(object sender, EventArgs e)
        {
           new Bug_Panel(this.username, this.userRole).Show();
            
            this.Hide();
        }

        private void btn_bug_fix_Click(object sender, EventArgs e)
        {
           new BugFix_Panel(this.username, this.userRole).Show();
            
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login_Panel login = new Login_Panel();
            login.Show();
            this.Hide();
        }

        private void listViewCompleted_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            display_bugfix_data();   
        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {
            new User_registration_Panel(this.username, this.userRole).Show();
            
            this.Hide();
        }
    }
}
