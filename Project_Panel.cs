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
    public partial class Project_Panel : Form
    {
        String username, userRole;
        MySqlConnection databaseConnection = new MySqlConnection("datasource=localhost;username=root;password=umapunkoz;database=bugtracker;");
        public Project_Panel(String username, String userRole)
        {
            InitializeComponent();
            //Calling Method To Display Inserted Project From Database
            display_data();
            this.username = username;
            this.userRole = userRole;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_project_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_assign_to_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_assigned_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void date_completion_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_assigned_by_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)


        {

            string projectname, assignto, assigneddate, completiondate, assignedby, code, description;
            
    
            projectname = txt_project_name.Text;
            assignto = txt_assign_to.Text;
            assigneddate = date_assigned_date.Text;
            completiondate = date_completion_date.Text;
            assignedby = txt_assigned_by.Text;
            code = richtextbox_code.Text;
            description = txt_description.Text;

            if (string.IsNullOrEmpty(projectname))
            {
                MessageBox.Show("Project Name Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_project_name.Focus();

            }
            else if (string.IsNullOrEmpty(assignto))
            {
                MessageBox.Show("Assign To Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_assign_to.Focus();
            }
            else if (string.IsNullOrEmpty(assigneddate))
            {
                MessageBox.Show("Assigned Date Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                date_assigned_date.Focus();

            }
            else if (string.IsNullOrEmpty(completiondate))
            {
                MessageBox.Show("Completion Date Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                date_completion_date.Focus();

            }
            else if (string.IsNullOrEmpty(assignedby))
            {
                MessageBox.Show("Assigned By Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_assigned_by.Focus();

            }
            else if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Code Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richtextbox_code.Focus();

            }
            else if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Description Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_description.Focus();

            }
            else
            {


                MySqlCommand cmd = databaseConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into project values('1','" + txt_project_name.Text + "', '" + txt_assign_to.Text + "','" + date_assigned_date.Text + "','" + date_completion_date.Text + "','" + txt_assigned_by.Text + "','" + richtextbox_code.Text + "','" + txt_description.Text + "')";
                cmd.ExecuteNonQuery();               
                databaseConnection.Close();
                MessageBox.Show("Project Has Been Sucessfully Added !!");

                listProjects.Clear();
                // Calling display_data Method
                display_data();
                

            }


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_project_id.Clear();
            txt_project_name.Clear();
            txt_assigned_by.Clear();
            txt_assign_to.Clear();
            txt_description.Clear();
            richtextbox_code.Clear();
        }

        private void txt_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
             new Admin_DashBoard_Panel(this.username, this.userRole).Show();
            //  dashboard.Show();

            this.Hide();
        }


        private void Admin_Panel_Load(object sender, EventArgs e)
        {
        }
        //To Display Inserted Project Data listview
        public void display_data()
        {
            listProjects.Clear();
            String query = "select * from project";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
               string project = dt.Rows[0].Field<String>("project_name");

                foreach (DataColumn column in dt.Columns)
                {
                    listProjects.Columns.Add(column.ColumnName, -2, HorizontalAlignment.Left);
                }
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                       
                    }
                    listProjects.Items.Add(item);
                    listProjects.View = View.Details;
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)

        {
           

            databaseConnection.Open();
            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " delete from project where project_id ='" +txt_project_id.Text+ "'";
            cmd.ExecuteNonQuery();
            databaseConnection.Close();
            MessageBox.Show("Selected Project Has Been Sucessfully Deleted !!!");
            listProjects.Clear();
            display_data();


        }
    

        private void btn_update_Click(object sender, EventArgs e)
        {
            databaseConnection.Open();
            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update project set project_name='" + txt_project_name.Text + "', assign_to ='" + txt_assign_to.Text + "',assigned_date='" + date_assigned_date.Text + "', completion_date='" + date_completion_date.Text + "',assigned_by='" + txt_assigned_by.Text + "',code='" + richtextbox_code.Text + "',description='" + txt_description.Text + "' where project_id ='" + txt_project_id.Text+ "'";

            Console.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
           
       
            databaseConnection.Close();
            MessageBox.Show("Selected Project Has Been Sucessfully Updated !!!");
            listProjects.Clear();
             display_data();
        }

        private void listProjects_DoubleClick(object sender, EventArgs e)
        {
            int projectID = Convert.ToInt32(listProjects.FocusedItem.SubItems[0].Text);
            
            databaseConnection.Open();
            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from project where project_id = "+projectID;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            int project_ID = dt.Rows[0].Field<int>("project_id");
            txt_project_id.Text = project_ID.ToString();
            string project = dt.Rows[0].Field<String>("project_name");
            txt_project_name.Text = project;
            string assignto = dt.Rows[0].Field<string>("assign_to");
            txt_assign_to.Text = assignto;
            DateTime assigneddate = dt.Rows[0].Field<DateTime>("assigned_date");
            date_assigned_date.Text = assigneddate.ToString();
            DateTime completiondate = dt.Rows[0].Field<DateTime>("completion_date");
            date_completion_date.Text =completiondate.ToString();
            string assignedby = dt.Rows[0].Field<string>("assigned_by");
            txt_assigned_by.Text = assignedby;
            string code = dt.Rows[0].Field<string>("code");
            richtextbox_code.Text = code;
            string description = dt.Rows[0].Field<string>("description");
            txt_description.Text = description;


            databaseConnection.Close();
        }

        private void listProjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
    }
