namespace bugtracker
{
    partial class Admin_Dashboard_Panel
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
            this.Panel_Drop_navigator = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_add_new_project = new System.Windows.Forms.Button();
            this.grid_view_completed_project = new System.Windows.Forms.DataGridView();
            this.grid_view_pending_project = new System.Windows.Forms.DataGridView();
            this.btn_delete_pending_project = new System.Windows.Forms.Button();
            this.btn_refresh_pending_project = new System.Windows.Forms.Button();
            this.btn_refresh_completed_project = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Panel_Drop_navigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_completed_project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_pending_project)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Drop_navigator
            // 
            this.Panel_Drop_navigator.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Drop_navigator.Controls.Add(this.btn_exit);
            this.Panel_Drop_navigator.Controls.Add(this.btn_logout);
            this.Panel_Drop_navigator.Controls.Add(this.btn_add_new_project);
            this.Panel_Drop_navigator.Location = new System.Drawing.Point(5, 6);
            this.Panel_Drop_navigator.Name = "Panel_Drop_navigator";
            this.Panel_Drop_navigator.Size = new System.Drawing.Size(160, 560);
            this.Panel_Drop_navigator.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_exit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_exit.Location = new System.Drawing.Point(-1, 339);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(160, 43);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_logout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_logout.Location = new System.Drawing.Point(1, 286);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(159, 47);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_add_new_project
            // 
            this.btn_add_new_project.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_add_new_project.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_new_project.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_add_new_project.Location = new System.Drawing.Point(0, 234);
            this.btn_add_new_project.Name = "btn_add_new_project";
            this.btn_add_new_project.Size = new System.Drawing.Size(160, 43);
            this.btn_add_new_project.TabIndex = 1;
            this.btn_add_new_project.Text = "New Project";
            this.btn_add_new_project.UseVisualStyleBackColor = false;
            this.btn_add_new_project.Click += new System.EventHandler(this.btn_add_new_project_Click);
            // 
            // grid_view_completed_project
            // 
            this.grid_view_completed_project.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_view_completed_project.Location = new System.Drawing.Point(169, 85);
            this.grid_view_completed_project.Name = "grid_view_completed_project";
            this.grid_view_completed_project.Size = new System.Drawing.Size(670, 200);
            this.grid_view_completed_project.TabIndex = 1;
            // 
            // grid_view_pending_project
            // 
            this.grid_view_pending_project.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_view_pending_project.Location = new System.Drawing.Point(170, 344);
            this.grid_view_pending_project.Name = "grid_view_pending_project";
            this.grid_view_pending_project.Size = new System.Drawing.Size(667, 180);
            this.grid_view_pending_project.TabIndex = 2;
            // 
            // btn_delete_pending_project
            // 
            this.btn_delete_pending_project.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_delete_pending_project.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_pending_project.ForeColor = System.Drawing.Color.White;
            this.btn_delete_pending_project.Location = new System.Drawing.Point(378, 528);
            this.btn_delete_pending_project.Name = "btn_delete_pending_project";
            this.btn_delete_pending_project.Size = new System.Drawing.Size(102, 34);
            this.btn_delete_pending_project.TabIndex = 3;
            this.btn_delete_pending_project.Text = "Delete";
            this.btn_delete_pending_project.UseVisualStyleBackColor = false;
            this.btn_delete_pending_project.Click += new System.EventHandler(this.btn_delete_pending_project_Click);
            // 
            // btn_refresh_pending_project
            // 
            this.btn_refresh_pending_project.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_refresh_pending_project.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh_pending_project.ForeColor = System.Drawing.Color.White;
            this.btn_refresh_pending_project.Location = new System.Drawing.Point(486, 528);
            this.btn_refresh_pending_project.Name = "btn_refresh_pending_project";
            this.btn_refresh_pending_project.Size = new System.Drawing.Size(112, 34);
            this.btn_refresh_pending_project.TabIndex = 4;
            this.btn_refresh_pending_project.Text = "Refresh";
            this.btn_refresh_pending_project.UseVisualStyleBackColor = false;
            this.btn_refresh_pending_project.Click += new System.EventHandler(this.btn_refresh_pending_project_Click);
            // 
            // btn_refresh_completed_project
            // 
            this.btn_refresh_completed_project.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_refresh_completed_project.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh_completed_project.ForeColor = System.Drawing.Color.White;
            this.btn_refresh_completed_project.Location = new System.Drawing.Point(437, 286);
            this.btn_refresh_completed_project.Name = "btn_refresh_completed_project";
            this.btn_refresh_completed_project.Size = new System.Drawing.Size(112, 34);
            this.btn_refresh_completed_project.TabIndex = 6;
            this.btn_refresh_completed_project.Text = "Refresh";
            this.btn_refresh_completed_project.UseVisualStyleBackColor = false;
            this.btn_refresh_completed_project.Click += new System.EventHandler(this.btn_refresh_completed_project_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(164, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pending Projects";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(167, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Completed Projects";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(377, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bug Tracking System";
            // 
            // Admin_Dashboard_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 566);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_refresh_completed_project);
            this.Controls.Add(this.btn_refresh_pending_project);
            this.Controls.Add(this.btn_delete_pending_project);
            this.Controls.Add(this.grid_view_pending_project);
            this.Controls.Add(this.grid_view_completed_project);
            this.Controls.Add(this.Panel_Drop_navigator);
            this.Name = "Admin_Dashboard_Panel";
            this.Text = "Admin_Dashboard_Panel";
            this.Panel_Drop_navigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_completed_project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_pending_project)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Drop_navigator;
        private System.Windows.Forms.Button btn_add_new_project;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridView grid_view_completed_project;
        private System.Windows.Forms.DataGridView grid_view_pending_project;
        private System.Windows.Forms.Button btn_delete_pending_project;
        private System.Windows.Forms.Button btn_refresh_pending_project;
        private System.Windows.Forms.Button btn_refresh_completed_project;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}