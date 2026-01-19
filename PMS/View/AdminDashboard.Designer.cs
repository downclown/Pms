namespace PMS.View
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_viewmed = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_cashier_count = new System.Windows.Forms.Label();
            this.lbl_pharmacist_count = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_admin_count = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login_close = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_revenue = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_viewmed);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_users);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 709);
            this.panel1.TabIndex = 39;
            // 
            // btn_viewmed
            // 
            this.btn_viewmed.BackColor = System.Drawing.Color.Lavender;
            this.btn_viewmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewmed.Location = new System.Drawing.Point(0, 378);
            this.btn_viewmed.Name = "btn_viewmed";
            this.btn_viewmed.Size = new System.Drawing.Size(256, 60);
            this.btn_viewmed.TabIndex = 50;
            this.btn_viewmed.Text = "View Medicines";
            this.btn_viewmed.UseVisualStyleBackColor = false;
            this.btn_viewmed.Click += new System.EventHandler(this.btn_viewmed_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Lavender;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(38, 649);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(171, 49);
            this.btn_logout.TabIndex = 42;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_users
            // 
            this.btn_users.BackColor = System.Drawing.Color.Lavender;
            this.btn_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.Location = new System.Drawing.Point(0, 309);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(256, 60);
            this.btn_users.TabIndex = 40;
            this.btn_users.Text = "User Management";
            this.btn_users.UseVisualStyleBackColor = false;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_cashier_count);
            this.panel2.Controls.Add(this.lbl_pharmacist_count);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbl_admin_count);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_count);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(603, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 280);
            this.panel2.TabIndex = 40;
            // 
            // lbl_cashier_count
            // 
            this.lbl_cashier_count.AutoSize = true;
            this.lbl_cashier_count.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_cashier_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_cashier_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cashier_count.Location = new System.Drawing.Point(327, 188);
            this.lbl_cashier_count.Name = "lbl_cashier_count";
            this.lbl_cashier_count.Size = new System.Drawing.Size(41, 31);
            this.lbl_cashier_count.TabIndex = 7;
            this.lbl_cashier_count.Text = "59";
            // 
            // lbl_pharmacist_count
            // 
            this.lbl_pharmacist_count.AutoSize = true;
            this.lbl_pharmacist_count.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_pharmacist_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_pharmacist_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pharmacist_count.Location = new System.Drawing.Point(180, 188);
            this.lbl_pharmacist_count.Name = "lbl_pharmacist_count";
            this.lbl_pharmacist_count.Size = new System.Drawing.Size(41, 31);
            this.lbl_pharmacist_count.TabIndex = 6;
            this.lbl_pharmacist_count.Text = "59";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cashier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pharmacist";
            // 
            // lbl_admin_count
            // 
            this.lbl_admin_count.AutoSize = true;
            this.lbl_admin_count.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_admin_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_admin_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin_count.Location = new System.Drawing.Point(48, 188);
            this.lbl_admin_count.Name = "lbl_admin_count";
            this.lbl_admin_count.Size = new System.Drawing.Size(41, 31);
            this.lbl_admin_count.TabIndex = 3;
            this.lbl_admin_count.Text = "59";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Admin ";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.Location = new System.Drawing.Point(171, 74);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(59, 42);
            this.lbl_count.TabIndex = 1;
            this.lbl_count.Text = "59";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total No. of User:";
            // 
            // btn_login_close
            // 
            this.btn_login_close.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_login_close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_login_close.FlatAppearance.BorderSize = 5;
            this.btn_login_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_close.Location = new System.Drawing.Point(1018, 12);
            this.btn_login_close.Name = "btn_login_close";
            this.btn_login_close.Size = new System.Drawing.Size(38, 40);
            this.btn_login_close.TabIndex = 42;
            this.btn_login_close.Text = "X";
            this.btn_login_close.UseVisualStyleBackColor = false;
            this.btn_login_close.Click += new System.EventHandler(this.btn_login_close_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_revenue);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(276, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 557);
            this.panel3.TabIndex = 43;
            // 
            // lbl_revenue
            // 
            this.lbl_revenue.AutoSize = true;
            this.lbl_revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_revenue.Location = new System.Drawing.Point(126, 342);
            this.lbl_revenue.Name = "lbl_revenue";
            this.lbl_revenue.Size = new System.Drawing.Size(34, 29);
            this.lbl_revenue.TabIndex = 10;
            this.lbl_revenue.Text = "l  ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(62, 63);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 177);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Revenue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(490, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 47);
            this.label6.TabIndex = 51;
            this.label6.Text = "Dashboard";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(62, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 29);
            this.label7.TabIndex = 51;
            this.label7.Text = "Welcome";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_username.Location = new System.Drawing.Point(62, 186);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(122, 29);
            this.lbl_username.TabIndex = 52;
            this.lbl_username.Text = "Welcome";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1068, 709);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_login_close);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_login_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_admin_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_cashier_count;
        private System.Windows.Forms.Label lbl_pharmacist_count;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_revenue;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_viewmed;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label label7;
    }
}