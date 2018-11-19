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
    public partial class Admin_Dashboard_Panel : Form
    {
        public Admin_Dashboard_Panel()
        {
            InitializeComponent();
        }

        private void btn_add_new_project_Click(object sender, EventArgs e)
        {
            Admin_Panel adminpanel = new Admin_Panel();
            adminpanel.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login_Panel loginpanel = new Login_Panel();
            loginpanel.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_refresh_completed_project_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_pending_project_Click(object sender, EventArgs e)
        {

        }

        private void btn_refresh_pending_project_Click(object sender, EventArgs e)
        {

        }
    }
}
