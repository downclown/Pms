namespace PMS.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_login_uname = new System.Windows.Forms.Label();
            this.tb_login_uname = new System.Windows.Forms.TextBox();
            this.lbl_error_uname = new System.Windows.Forms.Label();
            this.lbl_login_pass = new System.Windows.Forms.Label();
            this.tb_login_pass = new System.Windows.Forms.TextBox();
            this.lbl_error_pass = new System.Windows.Forms.Label();
            this.cb_login = new System.Windows.Forms.CheckBox();
            this.lbl_login_to_reg = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_login_close = new System.Windows.Forms.Button();
            this.comboBox_login = new System.Windows.Forms.ComboBox();
            this.lbl_reg_usertype = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 357);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pharmacy Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_login_uname
            // 
            this.lbl_login_uname.AutoSize = true;
            this.lbl_login_uname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_uname.Location = new System.Drawing.Point(324, 85);
            this.lbl_login_uname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login_uname.Name = "lbl_login_uname";
            this.lbl_login_uname.Size = new System.Drawing.Size(91, 21);
            this.lbl_login_uname.TabIndex = 12;
            this.lbl_login_uname.Text = "Username ";
            // 
            // tb_login_uname
            // 
            this.tb_login_uname.Location = new System.Drawing.Point(328, 108);
            this.tb_login_uname.Margin = new System.Windows.Forms.Padding(2);
            this.tb_login_uname.Name = "tb_login_uname";
            this.tb_login_uname.Size = new System.Drawing.Size(176, 20);
            this.tb_login_uname.TabIndex = 13;
            // 
            // lbl_error_uname
            // 
            this.lbl_error_uname.AutoSize = true;
            this.lbl_error_uname.Location = new System.Drawing.Point(325, 133);
            this.lbl_error_uname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_error_uname.Name = "lbl_error_uname";
            this.lbl_error_uname.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_uname.TabIndex = 14;
            // 
            // lbl_login_pass
            // 
            this.lbl_login_pass.AutoSize = true;
            this.lbl_login_pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_pass.Location = new System.Drawing.Point(324, 152);
            this.lbl_login_pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login_pass.Name = "lbl_login_pass";
            this.lbl_login_pass.Size = new System.Drawing.Size(82, 21);
            this.lbl_login_pass.TabIndex = 15;
            this.lbl_login_pass.Text = "Password";
            // 
            // tb_login_pass
            // 
            this.tb_login_pass.Location = new System.Drawing.Point(328, 175);
            this.tb_login_pass.Margin = new System.Windows.Forms.Padding(2);
            this.tb_login_pass.Name = "tb_login_pass";
            this.tb_login_pass.PasswordChar = '*';
            this.tb_login_pass.Size = new System.Drawing.Size(176, 20);
            this.tb_login_pass.TabIndex = 16;
            // 
            // lbl_error_pass
            // 
            this.lbl_error_pass.AutoSize = true;
            this.lbl_error_pass.Location = new System.Drawing.Point(325, 200);
            this.lbl_error_pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_error_pass.Name = "lbl_error_pass";
            this.lbl_error_pass.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_pass.TabIndex = 17;
            // 
            // cb_login
            // 
            this.cb_login.AutoSize = true;
            this.cb_login.Location = new System.Drawing.Point(328, 222);
            this.cb_login.Margin = new System.Windows.Forms.Padding(2);
            this.cb_login.Name = "cb_login";
            this.cb_login.Size = new System.Drawing.Size(102, 17);
            this.cb_login.TabIndex = 18;
            this.cb_login.Text = "Show Password";
            this.cb_login.UseVisualStyleBackColor = true;
            this.cb_login.CheckedChanged += new System.EventHandler(this.cb_login_CheckedChanged);
            // 
            // lbl_login_to_reg
            // 
            this.lbl_login_to_reg.AutoSize = true;
            this.lbl_login_to_reg.Location = new System.Drawing.Point(339, 307);
            this.lbl_login_to_reg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login_to_reg.Name = "lbl_login_to_reg";
            this.lbl_login_to_reg.Size = new System.Drawing.Size(155, 13);
            this.lbl_login_to_reg.TabIndex = 20;
            this.lbl_login_to_reg.Text = "No account yet? Register here.";
            this.lbl_login_to_reg.Click += new System.EventHandler(this.lbl_login_to_reg_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_login.FlatAppearance.BorderSize = 5;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(328, 265);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(175, 32);
            this.btn_login.TabIndex = 36;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_login_close
            // 
            this.btn_login_close.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_login_close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_login_close.FlatAppearance.BorderSize = 5;
            this.btn_login_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_close.Location = new System.Drawing.Point(501, 8);
            this.btn_login_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login_close.Name = "btn_login_close";
            this.btn_login_close.Size = new System.Drawing.Size(25, 26);
            this.btn_login_close.TabIndex = 37;
            this.btn_login_close.Text = "X";
            this.btn_login_close.UseVisualStyleBackColor = false;
            this.btn_login_close.Click += new System.EventHandler(this.btn_login_close_Click);
            // 
            // comboBox_login
            // 
            this.comboBox_login.FormattingEnabled = true;
            this.comboBox_login.Items.AddRange(new object[] {
            "Admin",
            "Pharmacist",
            "Customer",
            "Cashier",
            "Inventory Manager"});
            this.comboBox_login.Location = new System.Drawing.Point(329, 66);
            this.comboBox_login.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_login.Name = "comboBox_login";
            this.comboBox_login.Size = new System.Drawing.Size(176, 21);
            this.comboBox_login.TabIndex = 39;
            // 
            // lbl_reg_usertype
            // 
            this.lbl_reg_usertype.AutoSize = true;
            this.lbl_reg_usertype.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_usertype.Location = new System.Drawing.Point(324, 43);
            this.lbl_reg_usertype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_reg_usertype.Name = "lbl_reg_usertype";
            this.lbl_reg_usertype.Size = new System.Drawing.Size(84, 21);
            this.lbl_reg_usertype.TabIndex = 38;
            this.lbl_reg_usertype.Text = "User Type";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 357);
            this.Controls.Add(this.comboBox_login);
            this.Controls.Add(this.lbl_reg_usertype);
            this.Controls.Add(this.btn_login_close);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_login_to_reg);
            this.Controls.Add(this.cb_login);
            this.Controls.Add(this.lbl_error_pass);
            this.Controls.Add(this.tb_login_pass);
            this.Controls.Add(this.lbl_login_pass);
            this.Controls.Add(this.lbl_error_uname);
            this.Controls.Add(this.tb_login_uname);
            this.Controls.Add(this.lbl_login_uname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_login_uname;
        private System.Windows.Forms.TextBox tb_login_uname;
        private System.Windows.Forms.Label lbl_error_uname;
        private System.Windows.Forms.Label lbl_login_pass;
        private System.Windows.Forms.TextBox tb_login_pass;
        private System.Windows.Forms.Label lbl_error_pass;
        private System.Windows.Forms.CheckBox cb_login;
        private System.Windows.Forms.Label lbl_login_to_reg;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_login_close;
        private System.Windows.Forms.ComboBox comboBox_login;
        private System.Windows.Forms.Label lbl_reg_usertype;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}