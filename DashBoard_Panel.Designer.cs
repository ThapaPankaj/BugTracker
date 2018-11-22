namespace bugtracker
{
    partial class DashBoard_Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewCompleted = new System.Windows.Forms.ListView();
            this.btn_add_project = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_time = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_bug_details = new System.Windows.Forms.Button();
            this.btn_bug_fix = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_adduser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewCompleted
            // 
            this.listViewCompleted.Location = new System.Drawing.Point(15, 137);
            this.listViewCompleted.Name = "listViewCompleted";
            this.listViewCompleted.Size = new System.Drawing.Size(925, 227);
            this.listViewCompleted.TabIndex = 0;
            this.listViewCompleted.UseCompatibleStateImageBehavior = false;
            this.listViewCompleted.SelectedIndexChanged += new System.EventHandler(this.listViewCompleted_SelectedIndexChanged);
            // 
            // btn_add_project
            // 
            this.btn_add_project.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_add_project.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_project.ForeColor = System.Drawing.Color.White;
            this.btn_add_project.Location = new System.Drawing.Point(363, 415);
            this.btn_add_project.Name = "btn_add_project";
            this.btn_add_project.Size = new System.Drawing.Size(252, 39);
            this.btn_add_project.TabIndex = 44;
            this.btn_add_project.Text = "Add Project";
            this.btn_add_project.UseVisualStyleBackColor = false;
            this.btn_add_project.Click += new System.EventHandler(this.btn_add_project_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(291, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(355, 45);
            this.label14.TabIndex = 46;
            this.label14.Text = "Bug Tracking System";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(8, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(218, 39);
            this.label13.TabIndex = 45;
            this.label13.Text = "Completed Project";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_time
            // 
            this.txt_time.BackColor = System.Drawing.Color.CadetBlue;
            this.txt_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_time.ForeColor = System.Drawing.Color.White;
            this.txt_time.Location = new System.Drawing.Point(671, 101);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(267, 29);
            this.txt_time.TabIndex = 48;
            this.txt_time.TextChanged += new System.EventHandler(this.txt_time_TextChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(839, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(98, 34);
            this.btn_exit.TabIndex = 49;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_bug_details
            // 
            this.btn_bug_details.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_bug_details.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bug_details.ForeColor = System.Drawing.Color.White;
            this.btn_bug_details.Location = new System.Drawing.Point(363, 460);
            this.btn_bug_details.Name = "btn_bug_details";
            this.btn_bug_details.Size = new System.Drawing.Size(252, 39);
            this.btn_bug_details.TabIndex = 50;
            this.btn_bug_details.Text = "Bug Details";
            this.btn_bug_details.UseVisualStyleBackColor = false;
            this.btn_bug_details.Click += new System.EventHandler(this.btn_bug_details_Click);
            // 
            // btn_bug_fix
            // 
            this.btn_bug_fix.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_bug_fix.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bug_fix.ForeColor = System.Drawing.Color.White;
            this.btn_bug_fix.Location = new System.Drawing.Point(363, 505);
            this.btn_bug_fix.Name = "btn_bug_fix";
            this.btn_bug_fix.Size = new System.Drawing.Size(252, 39);
            this.btn_bug_fix.TabIndex = 51;
            this.btn_bug_fix.Text = "Bug Fix";
            this.btn_bug_fix.UseVisualStyleBackColor = false;
            this.btn_bug_fix.Click += new System.EventHandler(this.btn_bug_fix_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 39);
            this.button1.TabIndex = 52;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_logout.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(363, 550);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(252, 39);
            this.btn_logout.TabIndex = 53;
            this.btn_logout.Text = "LogOut";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_adduser
            // 
            this.btn_adduser.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_adduser.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adduser.ForeColor = System.Drawing.Color.White;
            this.btn_adduser.Location = new System.Drawing.Point(363, 375);
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Size = new System.Drawing.Size(252, 39);
            this.btn_adduser.TabIndex = 54;
            this.btn_adduser.Text = "Add User";
            this.btn_adduser.UseVisualStyleBackColor = false;
            this.btn_adduser.Click += new System.EventHandler(this.btn_adduser_Click);
            // 
            // DashBoard_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(949, 601);
            this.Controls.Add(this.btn_adduser);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_bug_fix);
            this.Controls.Add(this.btn_bug_details);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_add_project);
            this.Controls.Add(this.listViewCompleted);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "DashBoard_Panel";
            this.Text = "DashBoard_Panel";
            this.Load += new System.EventHandler(this.DashBoard_Panel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCompleted;
        private System.Windows.Forms.Button btn_add_project;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_bug_details;
        private System.Windows.Forms.Button btn_bug_fix;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_adduser;
    }
}