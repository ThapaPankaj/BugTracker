using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace bugtracker
{
    public partial class Bug_Panel : Form
    {
        String username, userRole;
        MySqlConnection databaseConnection = new MySqlConnection("datasource=localhost;username=root;password=umapunkoz;database=bugtracker;");
        public Bug_Panel(String username, String userRole)
        {
            InitializeComponent();
            display_bug_data();
            this.username = username;
            this.userRole = userRole;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            display_bug_data();
        }

        private void Bug_Load(object sender, EventArgs e)
        {

        }
        public void display_bug_data()
        {
            bugView.Clear();
            String query = "select * from bug";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                string bug = dt.Rows[0].Field<String>("bug_title");

                foreach (DataColumn column in dt.Columns)
                {
                    bugView.Columns.Add(column.ColumnName, -2, HorizontalAlignment.Left);
                }
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());

                    }
                    bugView.Items.Add(item);
                    bugView.View = View.Details;
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
            
        {
           string bugtitle1, projectname1, method1,class1,notes1,sourcecode1,screenshot1,priority1,reportdate1,reportedby1,bugstatus1;
           
            bugtitle1 = txt_bug_title.Text;
            projectname1 = txt_project_name.Text;
            method1 = txt_method.Text;
            class1 = txt_class.Text;
            notes1 = richtextbox_notes.Text;
            sourcecode1 = richtextbox_notes.Text;
            screenshot1 = txt_ScreenshotPath.Text;
            priority1 = txt_line.Text;
            reportdate1 = date_Report_date.Text;
            reportedby1 = txt_reported_by.Text;
            bugstatus1 = combobox_bugstaus.Text;

           // bugid = Convert.ToInt32(txt_bug_id.Text);
            // line = Convert.ToInt32(txt_line.Text);
            //Validating Fields
            if (string.IsNullOrEmpty(projectname1))
            {
                MessageBox.Show("Project Name Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_project_name.Focus();

            }
            else if (string.IsNullOrEmpty(bugtitle1))
            {
                MessageBox.Show("Bug Title Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_bug_title.Focus();
            }
            else if (string.IsNullOrEmpty(method1))
            {
                MessageBox.Show("Method Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_method.Focus();

            }
            else if (string.IsNullOrEmpty(class1))
            {
                MessageBox.Show("Class Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_class.Focus();

            }
            else if (string.IsNullOrEmpty(notes1))
            {
                MessageBox.Show("Noted Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richtextbox_notes.Focus();

            }
            else if (string.IsNullOrEmpty(sourcecode1))
            {
                MessageBox.Show("Source Code Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richtextbox_source_code.Focus();

            }
            else if (string.IsNullOrEmpty(priority1))
            {
                MessageBox.Show("Priority Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_priority.Focus();

            }

            if (string.IsNullOrEmpty(reportdate1))
            {
                MessageBox.Show("Report Date Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                date_Report_date.Focus();

            }
            else if (string.IsNullOrEmpty(reportedby1))
            {
                MessageBox.Show("Reported By Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_reported_by.Focus();
            }
            else if (string.IsNullOrEmpty(bugstatus1))
            {
                MessageBox.Show("Bug Status Field Cannot Be Empty!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                combobox_bugstatus.Focus();

            }else{
                try
                {
                    byte[] imagebt = null;
                    FileStream fstream = new FileStream(this.txt_ScreenshotPath.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fstream);
                    imagebt = br.ReadBytes((int)fstream.Length);

                    //databaseConnection.Open();
                    MySqlCommand cmd = databaseConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into  bug values('1','" + txt_bug_title.Text + "','" + txt_project_name.Text + "','" + Convert.ToInt32(txt_line.Text) + "','" + txt_method.Text + "','" + txt_class.Text + "','" + richtextbox_notes.Text + "','" + richtextbox_source_code.Text + "','" + txt_ScreenshotPath.Text + "','" + txt_priority.Text + "','" + date_Report_date.Text + "','" + txt_reported_by.Text + "','" + combobox_bugstaus.Text + "')";
                    cmd.ExecuteNonQuery();
                    databaseConnection.Close();
                    MessageBox.Show("Bug Details Has Been Added Sucessfully !!!");
                    bugView.Clear();
                    //Calling display bug data method
                    display_bug_data();
                }catch(Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                }
            } 
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_bug_id.Clear();
            txt_bug_title.Clear();
            txt_project_name.Clear();
            txt_line.Clear();
            txt_method.Clear();
            txt_class.Clear();
            txt_ScreenshotPath.Clear();
            richtextbox_notes.Clear();
            richtextbox_source_code.Clear();
            txt_priority.Clear();
            txt_reported_by.Clear();
           

        }

     
      
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_screenshot_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if(dlg.ShowDialog()== DialogResult.OK)
            {
                //Providing The Path Of The Image And Loading Image to PictureBox
                string picPath = dlg.FileName.ToString();
                //Inserting Selected Path To TextField
                txt_ScreenshotPath.Text = picPath;
                pictureBox1.ImageLocation = picPath;
            }

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int bugID = Convert.ToInt32(bugView.FocusedItem.SubItems[0].Text);
            int line = Convert.ToInt32(bugView.FocusedItem.SubItems[0].Text);

            databaseConnection.Open();
            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from bug where bug_id = " + bugID;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            int bug_ID = dt.Rows[0].Field<int>("bug_id");
            txt_bug_id.Text = bug_ID.ToString();
            string bugtitle = dt.Rows[0].Field<String>("bug_title");
            txt_bug_title.Text = bugtitle;
            string projectname = dt.Rows[0].Field<String>("project_name");
            txt_project_name.Text = projectname;
            int line1 = dt.Rows[0].Field<int>("line");
            txt_line.Text = line1.ToString();
            string method = dt.Rows[0].Field<String>("method");
            txt_method.Text = method;
            string class1 = dt.Rows[0].Field<String>("class");
            txt_class.Text = class1;
            string notes = dt.Rows[0].Field<string>("notes");
            richtextbox_notes.Text = notes;
            string sourcecode = dt.Rows[0].Field<string>("source_code");
            richtextbox_source_code.Text = sourcecode;
           // string screenshot = dt.Rows[0].Field<string>("screenshot"); 
           // txt_ScreenshotPath.Text = screenshot.ToString();
            string priority = dt.Rows[0].Field<string>("priority");
            txt_priority.Text = priority;
            DateTime reportdate = dt.Rows[0].Field<DateTime>("report_date");
            date_Report_date.Text = reportdate.ToString();
            string reportedby = dt.Rows[0].Field<string>("reported_by");
            txt_reported_by.Text = reportedby;
            string bugstatus = dt.Rows[0].Field<string>("bug_status");
            combobox_bugstatus.Text = bugstatus;


            databaseConnection.Close();
        }

        private void combobox_bugstaus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            databaseConnection.Open();
            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " delete from bug where bug_id ='" + txt_bug_id.Text + "'";
            cmd.ExecuteNonQuery();
            databaseConnection.Close();
            MessageBox.Show("Selected Bug Details Has Been Sucessfully Deleted !!!");
            bugView.Clear();
            display_bug_data();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            databaseConnection.Open();
            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update bug set bug_title='" + txt_bug_title.Text + "', project_name ='" + txt_project_name.Text + "',line='" + Convert.ToInt32(txt_line.Text) + "', method='" + txt_method.Text + "',class='" + txt_class.Text + "',notes='" + richtextbox_notes.Text + "',source_code='" + richtextbox_source_code.Text + "',screenshot='" + txt_ScreenshotPath.Text + "',report_date='" + date_Report_date.Text + "',reported_by='" + txt_reported_by.Text + "',bug_status='" + combobox_bugstaus.Text + "' where bug_id ='" +txt_bug_id.Text + "'";
            cmd.ExecuteNonQuery();
            databaseConnection.Close();
            MessageBox.Show("Selected Bug Details Sucessfully Updated !!!");
            bugView.Clear();
            display_bug_data();
        }

        private void txt_bug_id_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new DashBoard_Panel(this.username, this.userRole).Show();
            // dashboard.Show();
            this.Hide();
        }
    }
}
