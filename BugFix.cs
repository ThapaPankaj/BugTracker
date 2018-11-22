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
    public partial class BugFix : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=localhost;username=root;password=umapunkoz;database=bugtracker;");
        public BugFix()
        {
            InitializeComponent();
            fillcombo();
            display_bugFixed_details();
        }

        private void txt_assigned_by_TextChanged(object sender, EventArgs e)
        {

        }

        private void combobox_bug_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fillcombo();
            /* string query = "select * from bug where bug_id ='"+combobox_bug_id.Text+"'";
             MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
             MySqlDataReader dr;        
             while(dr.Read())
             {
                 string resolvecode = (string)dr["source_code"].ToString();
                 richtextbox_resolve_code.Text = resolvecode;


             }
             databaseConnection.Close();


         } */
          
            String query = "select * from bug where bug_id = '" +combobox_bug_id.SelectedItem.ToString()+ "'";
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                richtextbox_resolve_code.Text = dr["source_code"].ToString();
                txt_project_name.Text = dr["project_name"].ToString();
            }

            databaseConnection.Close();
        }
            //Method For Filling Combobox
            void fillcombo()
        {
           
            String query = "select * from bug";
            MySqlCommand cmd= new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            MySqlDataReader myreader;
            try
            {
                databaseConnection.Open();
                myreader = cmd.ExecuteReader();
                while(myreader.Read())
                {
                    String bugid = myreader.GetString(0);
                    combobox_bug_id.Items.Add(bugid);
                   
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            databaseConnection.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_bugfix_id.Clear();
            txt_project_name.Clear();
            txt_resolve_by.Clear();
            richtextbox_resolve_code.Clear();

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string resolvecode, projectname, resolveby,resolvedate, bugfixstatus;
           // int bugfixid, bugid;
           // bugfixid = Convert.ToInt32(txt_bugfix_id.Text);
           // bugid = Convert.ToInt32(combobox_bug_id.Text);
            resolvecode = richtextbox_resolve_code.Text;
            projectname = txt_project_name.Text;
            resolveby = txt_resolve_by.Text;
            resolvedate = date_resolve_date.Text;
            bugfixstatus = combobox_bugfixstatus.Text;
            if (string.IsNullOrEmpty(resolvecode))
            {
                MessageBox.Show("Resolve Code Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richtextbox_resolve_code.Focus();

            }
            else if (string.IsNullOrEmpty(projectname))
            {
                MessageBox.Show("Project Name Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_project_name.Focus();
            }
            else if (string.IsNullOrEmpty(resolveby))
            {
                MessageBox.Show("Resolve By Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_resolve_by.Focus();

            }
            else if (string.IsNullOrEmpty(bugfixstatus))
            {
                MessageBox.Show("BugFix Status Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                combobox_bugfixstatus.Focus();

            }
            else if (string.IsNullOrEmpty(resolvedate))
            {
                MessageBox.Show("Resolve Date Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                date_resolve_date.Focus();
            
            }
            else
            {
              databaseConnection.Open();
                MySqlCommand cmd = databaseConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into bugfix values(1,'" + Convert.ToInt32(combobox_bug_id.Text) + "', '" + richtextbox_resolve_code.Text + "','" + txt_project_name.Text + "','" + txt_resolve_by.Text + "','" + date_resolve_date.Text + "','" +combobox_bugfixstatus.Text +"')";
                cmd.ExecuteNonQuery();

                // Calling display_data Method
             //   display_data();
                databaseConnection.Close();
                MessageBox.Show("BugFix Details Has Been Sucessfully Added !!");
                bugfixView.Clear();
                display_bugFixed_details();


            }

        }

        public void display_bugFixed_details()
        {
            bugfixView.Clear();
            String query = "select * from bugfix";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                string bugfix = dt.Rows[0].Field<String>("resolve_code");

                foreach (DataColumn column in dt.Columns)
                {
                    bugfixView.Columns.Add(column.ColumnName, -2, HorizontalAlignment.Left);
                }
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());

                    }
                    bugfixView.Items.Add(item);
                    bugfixView.View = View.Details;
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void BugFix_Load(object sender, EventArgs e)
        {
            display_bugFixed_details();
        }

        private void bugfixView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bugfixView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int bugfixID = Convert.ToInt32(bugfixView.FocusedItem.SubItems[0].Text);
            int bugid = Convert.ToInt32(bugfixView.FocusedItem.SubItems[0].Text);

            databaseConnection.Open();
            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from bugfix where bugfix_id = " + bugfixID;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            int bugfix_ID = dt.Rows[0].Field<int>("bugfix_id");
            txt_bugfix_id.Text = bugfix_ID.ToString();

            int bug_ID = dt.Rows[0].Field<int>("bug_id");
            combobox_bug_id.Text = bug_ID.ToString();

            string resolvecode = dt.Rows[0].Field<string>("resolve_code");
            richtextbox_resolve_code.Text = resolvecode;

            string projectname = dt.Rows[0].Field<string>("project_name");
            txt_project_name.Text = projectname;

            string resolveby = dt.Rows[0].Field<string>("resolve_by");
            txt_resolve_by.Text = resolveby;

            DateTime resolvedate = dt.Rows[0].Field<DateTime>("resolve_date");
            date_resolve_date.Text = resolvedate.ToString();

            databaseConnection.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            databaseConnection.Open();
            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " delete from bugfix where bugfix_id ='" + Convert.ToInt32(txt_bugfix_id.Text) + "'";
            cmd.ExecuteNonQuery();
            databaseConnection.Close();
            MessageBox.Show("Selected BugFix Details Has Been Sucessfully Deleted !!!");
            bugfixView.Clear();
            display_bugFixed_details();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            databaseConnection.Open();
            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update bugfix set bug_id='" +combobox_bug_id.Text+ "', resolve_code ='" + richtextbox_resolve_code.Text + "',project_name='" + txt_project_name.Text + "',resolve_by='" + txt_resolve_by.Text + "',resolve_date='" + date_resolve_date.Text + "',bugfix_status='" +combobox_bugfixstatus.Text +"' where bugfix_id ='" + txt_bugfix_id.Text + "'";

            Console.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();


            databaseConnection.Close();
            MessageBox.Show("Selected BugFix Details Has Been Sucessfully Updated !!!");
            bugfixView.Clear();
            display_bugFixed_details();
        }
    }
}
