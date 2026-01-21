namespace PMS.View
{
    partial class AdminProfile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login_close = new System.Windows.Forms.Button();
            this.tb_fname = new System.Windows.Forms.TextBox();
            this.lbl_reg_fname = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_uname = new System.Windows.Forms.TextBox();
            this.lbl_reg_pass = new System.Windows.Forms.Label();
            this.lbl_reg_uname = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_reg_email = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.lbl_reg_phn = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_login_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 92);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 48);
            this.label1.TabIndex = 39;
            this.label1.Text = "Profile details";
            // 
            // btn_login_close
            // 
            this.btn_login_close.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_login_close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_login_close.FlatAppearance.BorderSize = 5;
            this.btn_login_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_close.Location = new System.Drawing.Point(522, 12);
            this.btn_login_close.Name = "btn_login_close";
            this.btn_login_close.Size = new System.Drawing.Size(37, 40);
            this.btn_login_close.TabIndex = 38;
            this.btn_login_close.Text = "X";
            this.btn_login_close.UseVisualStyleBackColor = false;
            this.btn_login_close.Click += new System.EventHandler(this.btn_login_close_Click);
            // 
            // tb_fname
            // 
            this.tb_fname.Location = new System.Drawing.Point(103, 163);
            this.tb_fname.Name = "tb_fname";
            this.tb_fname.Size = new System.Drawing.Size(347, 26);
            this.tb_fname.TabIndex = 43;
            // 
            // lbl_reg_fname
            // 
            this.lbl_reg_fname.AutoSize = true;
            this.lbl_reg_fname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_fname.Location = new System.Drawing.Point(97, 125);
            this.lbl_reg_fname.Name = "lbl_reg_fname";
            this.lbl_reg_fname.Size = new System.Drawing.Size(118, 32);
            this.lbl_reg_fname.TabIndex = 42;
            this.lbl_reg_fname.Text = "Fullname";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(103, 308);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(347, 26);
            this.tb_pass.TabIndex = 41;
            // 
            // tb_uname
            // 
            this.tb_uname.Location = new System.Drawing.Point(103, 237);
            this.tb_uname.Name = "tb_uname";
            this.tb_uname.Size = new System.Drawing.Size(347, 26);
            this.tb_uname.TabIndex = 40;
            // 
            // lbl_reg_pass
            // 
            this.lbl_reg_pass.AutoSize = true;
            this.lbl_reg_pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_pass.Location = new System.Drawing.Point(97, 273);
            this.lbl_reg_pass.Name = "lbl_reg_pass";
            this.lbl_reg_pass.Size = new System.Drawing.Size(122, 32);
            this.lbl_reg_pass.TabIndex = 39;
            this.lbl_reg_pass.Text = "Password";
            // 
            // lbl_reg_uname
            // 
            this.lbl_reg_uname.AutoSize = true;
            this.lbl_reg_uname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_uname.Location = new System.Drawing.Point(97, 201);
            this.lbl_reg_uname.Name = "lbl_reg_uname";
            this.lbl_reg_uname.Size = new System.Drawing.Size(128, 32);
            this.lbl_reg_uname.TabIndex = 38;
            this.lbl_reg_uname.Text = "Username";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(103, 455);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(347, 26);
            this.tb_email.TabIndex = 47;
            // 
            // lbl_reg_email
            // 
            this.lbl_reg_email.AutoSize = true;
            this.lbl_reg_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_email.Location = new System.Drawing.Point(97, 420);
            this.lbl_reg_email.Name = "lbl_reg_email";
            this.lbl_reg_email.Size = new System.Drawing.Size(76, 32);
            this.lbl_reg_email.TabIndex = 46;
            this.lbl_reg_email.Text = "Email";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(103, 382);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(347, 26);
            this.tb_phone.TabIndex = 45;
            // 
            // lbl_reg_phn
            // 
            this.lbl_reg_phn.AutoSize = true;
            this.lbl_reg_phn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_phn.Location = new System.Drawing.Point(97, 347);
            this.lbl_reg_phn.Name = "lbl_reg_phn";
            this.lbl_reg_phn.Size = new System.Drawing.Size(187, 32);
            this.lbl_reg_phn.TabIndex = 44;
            this.lbl_reg_phn.Text = "Phone Number";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_update.FlatAppearance.BorderSize = 5;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(103, 507);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(347, 55);
            this.btn_update.TabIndex = 48;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 40);
            this.button1.TabIndex = 40;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(571, 629);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lbl_reg_email);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.lbl_reg_phn);
            this.Controls.Add(this.tb_fname);
            this.Controls.Add(this.lbl_reg_fname);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_uname);
            this.Controls.Add(this.lbl_reg_pass);
            this.Controls.Add(this.lbl_reg_uname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminProfile";
            this.Load += new System.EventHandler(this.AdminProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_login_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_fname;
        private System.Windows.Forms.Label lbl_reg_fname;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_uname;
        private System.Windows.Forms.Label lbl_reg_pass;
        private System.Windows.Forms.Label lbl_reg_uname;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl_reg_email;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label lbl_reg_phn;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button button1;
    }
}