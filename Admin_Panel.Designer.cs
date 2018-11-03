namespace bugtracker
{
    partial class AdminPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_project_name = new System.Windows.Forms.TextBox();
            this.txt_assign_to = new System.Windows.Forms.TextBox();
            this.date_assigned_date = new System.Windows.Forms.DateTimePicker();
            this.date_completion_date = new System.Windows.Forms.DateTimePicker();
            this.txt_assigned_by = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.richtextbox_code = new System.Windows.Forms.RichTextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project  Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Assign To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Assigned Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Completion Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Assigned By";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            // 
            // txt_project_name
            // 
            this.txt_project_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_project_name.Location = new System.Drawing.Point(196, 81);
            this.txt_project_name.Name = "txt_project_name";
            this.txt_project_name.Size = new System.Drawing.Size(218, 23);
            this.txt_project_name.TabIndex = 9;
            this.txt_project_name.TextChanged += new System.EventHandler(this.txt_project_name_TextChanged);
            // 
            // txt_assign_to
            // 
            this.txt_assign_to.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_assign_to.Location = new System.Drawing.Point(196, 108);
            this.txt_assign_to.Name = "txt_assign_to";
            this.txt_assign_to.Size = new System.Drawing.Size(218, 23);
            this.txt_assign_to.TabIndex = 10;
            this.txt_assign_to.TextChanged += new System.EventHandler(this.txt_assign_to_TextChanged);
            // 
            // date_assigned_date
            // 
            this.date_assigned_date.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_assigned_date.Location = new System.Drawing.Point(196, 135);
            this.date_assigned_date.Name = "date_assigned_date";
            this.date_assigned_date.Size = new System.Drawing.Size(218, 23);
            this.date_assigned_date.TabIndex = 11;
            this.date_assigned_date.ValueChanged += new System.EventHandler(this.date_assigned_date_ValueChanged);
            // 
            // date_completion_date
            // 
            this.date_completion_date.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_completion_date.Location = new System.Drawing.Point(197, 163);
            this.date_completion_date.Name = "date_completion_date";
            this.date_completion_date.Size = new System.Drawing.Size(217, 23);
            this.date_completion_date.TabIndex = 12;
            this.date_completion_date.ValueChanged += new System.EventHandler(this.date_completion_date_ValueChanged);
            // 
            // txt_assigned_by
            // 
            this.txt_assigned_by.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_assigned_by.Location = new System.Drawing.Point(197, 191);
            this.txt_assigned_by.Name = "txt_assigned_by";
            this.txt_assigned_by.Size = new System.Drawing.Size(217, 23);
            this.txt_assigned_by.TabIndex = 13;
            this.txt_assigned_by.TextChanged += new System.EventHandler(this.txt_assigned_by_TextChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(97, 417);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(142, 31);
            this.btn_submit.TabIndex = 14;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(251, 417);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(162, 31);
            this.btn_clear.TabIndex = 15;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(504, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // richtextbox_code
            // 
            this.richtextbox_code.Location = new System.Drawing.Point(197, 222);
            this.richtextbox_code.Name = "richtextbox_code";
            this.richtextbox_code.Size = new System.Drawing.Size(217, 123);
            this.richtextbox_code.TabIndex = 18;
            this.richtextbox_code.Text = "";
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.Location = new System.Drawing.Point(197, 359);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(216, 23);
            this.txt_description.TabIndex = 19;
            this.txt_description.TextChanged += new System.EventHandler(this.txt_description_TextChanged);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 467);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.richtextbox_code);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_assigned_by);
            this.Controls.Add(this.date_completion_date);
            this.Controls.Add(this.date_assigned_date);
            this.Controls.Add(this.txt_assign_to);
            this.Controls.Add(this.txt_project_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminPanel";
            this.Text = "Admin_Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_project_name;
        private System.Windows.Forms.TextBox txt_assign_to;
        private System.Windows.Forms.DateTimePicker date_assigned_date;
        private System.Windows.Forms.DateTimePicker date_completion_date;
        private System.Windows.Forms.TextBox txt_assigned_by;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox richtextbox_code;
        private System.Windows.Forms.TextBox txt_description;
    }
}