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
    public partial class Admin_Panel : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=localhost;username=root;password=umapunkoz;database=bugtracker;");
        public Admin_Panel()
        {
            InitializeComponent();
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


                databaseConnection.Open();
                MySqlCommand cmd = databaseConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into project values(1,'" + txt_project_name.Text + "', '" + txt_assign_to.Text + "','" + date_assigned_date.Text + "','" + date_completion_date.Text + "','" + txt_assigned_by.Text + "','" + richtextbox_code.Text + "','" + txt_description.Text + "')";
                cmd.ExecuteNonQuery();

                // Calling display_data Method
                display_data();
                databaseConnection.Close();
                MessageBox.Show("Sucessfully Project Added !!");


            }

        
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
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
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        /*    databaseConnection.Open();
            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandType = "SELECT * from project";
            cmd.ExecuteNonQuery();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
          */  




        }

        int selectedRow;
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            txt_project_name.Text = row.Cells[0].Value.ToString();
            txt_assign_to.Text = row.Cells[1].Value.ToString();
            date_assigned_date.Text = row.Cells[2].Value.ToString();
            date_completion_date.Text = row.Cells[3].Value.ToString();
            txt_assigned_by.Text = row.Cells[4].Value.ToString();
            richtextbox_code.Text = row.Cells[5].Value.ToString();
            txt_description.Text = row.Cells[6].Value.ToString();

        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            display_data();
        }
        //To Display Inserted Data in GridView
        public void display_data()
        {
            databaseConnection.Open();
            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from project";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            databaseConnection.Close();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
           /* databaseConnection.Open();
            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            databaseConnection.Close();
            */
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            databaseConnection.Open();
            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from project";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            databaseConnection.Close();
        }
    }




}  
