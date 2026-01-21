namespace PMS.View
{
    partial class Registration
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
            this.btn_login_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_reg_showbox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_reg_usertype = new System.Windows.Forms.Label();
            this.tb_reg_email = new System.Windows.Forms.TextBox();
            this.lbl_reg_email = new System.Windows.Forms.Label();
            this.tb_reg_phn = new System.Windows.Forms.TextBox();
            this.lbl_reg_phn = new System.Windows.Forms.Label();
            this.tb_reg_conpass = new System.Windows.Forms.TextBox();
            this.tb_reg_pass = new System.Windows.Forms.TextBox();
            this.tb_reg_uname = new System.Windows.Forms.TextBox();
            this.lbl_reg_conpass = new System.Windows.Forms.Label();
            this.lbl_reg_pass = new System.Windows.Forms.Label();
            this.lbl_reg_uname = new System.Windows.Forms.Label();
            this.btn_reg = new System.Windows.Forms.Button();
            this.tb_reg_fname = new System.Windows.Forms.TextBox();
            this.lbl_reg_fname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.btn_login_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 92);
            this.panel1.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(156, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(150, 700);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Already have an account? Sign In here.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cb_reg_showbox
            // 
            this.cb_reg_showbox.AutoSize = true;
            this.cb_reg_showbox.Location = new System.Drawing.Point(113, 374);
            this.cb_reg_showbox.Name = "cb_reg_showbox";
            this.cb_reg_showbox.Size = new System.Drawing.Size(148, 24);
            this.cb_reg_showbox.TabIndex = 33;
            this.cb_reg_showbox.Text = "Show Password";
            this.cb_reg_showbox.UseVisualStyleBackColor = true;
            this.cb_reg_showbox.CheckedChanged += new System.EventHandler(this.cb_reg_showbox_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Pharmacist",
            "Customer",
            "Cashier",
            "Inventory Manager"});
            this.comboBox1.Location = new System.Drawing.Point(113, 580);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(346, 28);
            this.comboBox1.TabIndex = 32;
            // 
            // lbl_reg_usertype
            // 
            this.lbl_reg_usertype.AutoSize = true;
            this.lbl_reg_usertype.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_usertype.Location = new System.Drawing.Point(106, 545);
            this.lbl_reg_usertype.Name = "lbl_reg_usertype";
            this.lbl_reg_usertype.Size = new System.Drawing.Size(126, 32);
            this.lbl_reg_usertype.TabIndex = 31;
            this.lbl_reg_usertype.Text = "User Type";
            // 
            // tb_reg_email
            // 
            this.tb_reg_email.Location = new System.Drawing.Point(114, 509);
            this.tb_reg_email.Name = "tb_reg_email";
            this.tb_reg_email.Size = new System.Drawing.Size(347, 26);
            this.tb_reg_email.TabIndex = 30;
            // 
            // lbl_reg_email
            // 
            this.lbl_reg_email.AutoSize = true;
            this.lbl_reg_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_email.Location = new System.Drawing.Point(108, 474);
            this.lbl_reg_email.Name = "lbl_reg_email";
            this.lbl_reg_email.Size = new System.Drawing.Size(76, 32);
            this.lbl_reg_email.TabIndex = 29;
            this.lbl_reg_email.Text = "Email";
            // 
            // tb_reg_phn
            // 
            this.tb_reg_phn.Location = new System.Drawing.Point(114, 436);
            this.tb_reg_phn.Name = "tb_reg_phn";
            this.tb_reg_phn.Size = new System.Drawing.Size(347, 26);
            this.tb_reg_phn.TabIndex = 28;
            // 
            // lbl_reg_phn
            // 
            this.lbl_reg_phn.AutoSize = true;
            this.lbl_reg_phn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_phn.Location = new System.Drawing.Point(108, 401);
            this.lbl_reg_phn.Name = "lbl_reg_phn";
            this.lbl_reg_phn.Size = new System.Drawing.Size(187, 32);
            this.lbl_reg_phn.TabIndex = 27;
            this.lbl_reg_phn.Text = "Phone Number";
            // 
            // tb_reg_conpass
            // 
            this.tb_reg_conpass.Location = new System.Drawing.Point(114, 341);
            this.tb_reg_conpass.Name = "tb_reg_conpass";
            this.tb_reg_conpass.PasswordChar = '*';
            this.tb_reg_conpass.Size = new System.Drawing.Size(347, 26);
            this.tb_reg_conpass.TabIndex = 26;
            // 
            // tb_reg_pass
            // 
            this.tb_reg_pass.Location = new System.Drawing.Point(114, 277);
            this.tb_reg_pass.Name = "tb_reg_pass";
            this.tb_reg_pass.PasswordChar = '*';
            this.tb_reg_pass.Size = new System.Drawing.Size(347, 26);
            this.tb_reg_pass.TabIndex = 25;
            // 
            // tb_reg_uname
            // 
            this.tb_reg_uname.Location = new System.Drawing.Point(114, 213);
            this.tb_reg_uname.Name = "tb_reg_uname";
            this.tb_reg_uname.Size = new System.Drawing.Size(347, 26);
            this.tb_reg_uname.TabIndex = 24;
            // 
            // lbl_reg_conpass
            // 
            this.lbl_reg_conpass.AutoSize = true;
            this.lbl_reg_conpass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_conpass.Location = new System.Drawing.Point(108, 306);
            this.lbl_reg_conpass.Name = "lbl_reg_conpass";
            this.lbl_reg_conpass.Size = new System.Drawing.Size(222, 32);
            this.lbl_reg_conpass.TabIndex = 23;
            this.lbl_reg_conpass.Text = "Confirm Password";
            // 
            // lbl_reg_pass
            // 
            this.lbl_reg_pass.AutoSize = true;
            this.lbl_reg_pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_pass.Location = new System.Drawing.Point(108, 242);
            this.lbl_reg_pass.Name = "lbl_reg_pass";
            this.lbl_reg_pass.Size = new System.Drawing.Size(122, 32);
            this.lbl_reg_pass.TabIndex = 22;
            this.lbl_reg_pass.Text = "Password";
            // 
            // lbl_reg_uname
            // 
            this.lbl_reg_uname.AutoSize = true;
            this.lbl_reg_uname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_uname.Location = new System.Drawing.Point(108, 177);
            this.lbl_reg_uname.Name = "lbl_reg_uname";
            this.lbl_reg_uname.Size = new System.Drawing.Size(128, 32);
            this.lbl_reg_uname.TabIndex = 21;
            this.lbl_reg_uname.Text = "Username";
            // 
            // btn_reg
            // 
            this.btn_reg.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_reg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_reg.FlatAppearance.BorderSize = 5;
            this.btn_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reg.Location = new System.Drawing.Point(112, 630);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(347, 55);
            this.btn_reg.TabIndex = 35;
            this.btn_reg.Text = "Register";
            this.btn_reg.UseVisualStyleBackColor = false;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // tb_reg_fname
            // 
            this.tb_reg_fname.Location = new System.Drawing.Point(114, 148);
            this.tb_reg_fname.Name = "tb_reg_fname";
            this.tb_reg_fname.Size = new System.Drawing.Size(347, 26);
            this.tb_reg_fname.TabIndex = 37;
            // 
            // lbl_reg_fname
            // 
            this.lbl_reg_fname.AutoSize = true;
            this.lbl_reg_fname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_fname.Location = new System.Drawing.Point(108, 110);
            this.lbl_reg_fname.Name = "lbl_reg_fname";
            this.lbl_reg_fname.Size = new System.Drawing.Size(118, 32);
            this.lbl_reg_fname.TabIndex = 36;
            this.lbl_reg_fname.Text = "Fullname";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(571, 769);
            this.Controls.Add(this.tb_reg_fname);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.lbl_reg_fname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_reg_showbox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_reg_usertype);
            this.Controls.Add(this.tb_reg_email);
            this.Controls.Add(this.lbl_reg_email);
            this.Controls.Add(this.tb_reg_phn);
            this.Controls.Add(this.lbl_reg_phn);
            this.Controls.Add(this.tb_reg_conpass);
            this.Controls.Add(this.tb_reg_pass);
            this.Controls.Add(this.tb_reg_uname);
            this.Controls.Add(this.lbl_reg_conpass);
            this.Controls.Add(this.lbl_reg_pass);
            this.Controls.Add(this.lbl_reg_uname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_reg_showbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_reg_usertype;
        private System.Windows.Forms.TextBox tb_reg_email;
        private System.Windows.Forms.Label lbl_reg_email;
        private System.Windows.Forms.TextBox tb_reg_phn;
        private System.Windows.Forms.Label lbl_reg_phn;
        private System.Windows.Forms.TextBox tb_reg_conpass;
        private System.Windows.Forms.TextBox tb_reg_pass;
        private System.Windows.Forms.TextBox tb_reg_uname;
        private System.Windows.Forms.Label lbl_reg_conpass;
        private System.Windows.Forms.Label lbl_reg_pass;
        private System.Windows.Forms.Label lbl_reg_uname;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.TextBox tb_reg_fname;
        private System.Windows.Forms.Label lbl_reg_fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login_close;
    }
}