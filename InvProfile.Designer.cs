namespace PMS.View
{
    partial class InvProfile
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
            this.btn_update = new System.Windows.Forms.Button();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_reg_email = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.lbl_reg_phn = new System.Windows.Forms.Label();
            this.tb_fname = new System.Windows.Forms.TextBox();
            this.lbl_reg_fname = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_uname = new System.Windows.Forms.TextBox();
            this.lbl_reg_pass = new System.Windows.Forms.Label();
            this.lbl_reg_uname = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_login_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 60);
            this.panel1.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 39;
            this.label1.Text = "Profile details";
            // 
            // btn_login_close
            // 
            this.btn_login_close.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_login_close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_login_close.FlatAppearance.BorderSize = 5;
            this.btn_login_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_close.Location = new System.Drawing.Point(348, 8);
            this.btn_login_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login_close.Name = "btn_login_close";
            this.btn_login_close.Size = new System.Drawing.Size(25, 26);
            this.btn_login_close.TabIndex = 38;
            this.btn_login_close.Text = "X";
            this.btn_login_close.UseVisualStyleBackColor = false;
            this.btn_login_close.Click += new System.EventHandler(this.btn_login_close_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.LightCoral;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_update.FlatAppearance.BorderSize = 5;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(69, 372);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(231, 36);
            this.btn_update.TabIndex = 60;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(69, 338);
            this.tb_email.Margin = new System.Windows.Forms.Padding(2);
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = true;
            this.tb_email.Size = new System.Drawing.Size(233, 20);
            this.tb_email.TabIndex = 59;
            // 
            // lbl_reg_email
            // 
            this.lbl_reg_email.AutoSize = true;
            this.lbl_reg_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_email.Location = new System.Drawing.Point(65, 315);
            this.lbl_reg_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_reg_email.Name = "lbl_reg_email";
            this.lbl_reg_email.Size = new System.Drawing.Size(53, 21);
            this.lbl_reg_email.TabIndex = 58;
            this.lbl_reg_email.Text = "Email";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(69, 290);
            this.tb_phone.Margin = new System.Windows.Forms.Padding(2);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.ReadOnly = true;
            this.tb_phone.Size = new System.Drawing.Size(233, 20);
            this.tb_phone.TabIndex = 57;
            // 
            // lbl_reg_phn
            // 
            this.lbl_reg_phn.AutoSize = true;
            this.lbl_reg_phn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_phn.Location = new System.Drawing.Point(65, 268);
            this.lbl_reg_phn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_reg_phn.Name = "lbl_reg_phn";
            this.lbl_reg_phn.Size = new System.Drawing.Size(126, 21);
            this.lbl_reg_phn.TabIndex = 56;
            this.lbl_reg_phn.Text = "Phone Number";
            // 
            // tb_fname
            // 
            this.tb_fname.Location = new System.Drawing.Point(69, 148);
            this.tb_fname.Margin = new System.Windows.Forms.Padding(2);
            this.tb_fname.Name = "tb_fname";
            this.tb_fname.ReadOnly = true;
            this.tb_fname.Size = new System.Drawing.Size(233, 20);
            this.tb_fname.TabIndex = 55;
            // 
            // lbl_reg_fname
            // 
            this.lbl_reg_fname.AutoSize = true;
            this.lbl_reg_fname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_fname.Location = new System.Drawing.Point(65, 123);
            this.lbl_reg_fname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_reg_fname.Name = "lbl_reg_fname";
            this.lbl_reg_fname.Size = new System.Drawing.Size(81, 21);
            this.lbl_reg_fname.TabIndex = 54;
            this.lbl_reg_fname.Text = "Fullname";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(69, 242);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(2);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.ReadOnly = true;
            this.tb_pass.Size = new System.Drawing.Size(233, 20);
            this.tb_pass.TabIndex = 53;
            // 
            // tb_uname
            // 
            this.tb_uname.Location = new System.Drawing.Point(69, 196);
            this.tb_uname.Margin = new System.Windows.Forms.Padding(2);
            this.tb_uname.Name = "tb_uname";
            this.tb_uname.ReadOnly = true;
            this.tb_uname.Size = new System.Drawing.Size(233, 20);
            this.tb_uname.TabIndex = 52;
            // 
            // lbl_reg_pass
            // 
            this.lbl_reg_pass.AutoSize = true;
            this.lbl_reg_pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_pass.Location = new System.Drawing.Point(65, 219);
            this.lbl_reg_pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_reg_pass.Name = "lbl_reg_pass";
            this.lbl_reg_pass.Size = new System.Drawing.Size(82, 21);
            this.lbl_reg_pass.TabIndex = 51;
            this.lbl_reg_pass.Text = "Password";
            // 
            // lbl_reg_uname
            // 
            this.lbl_reg_uname.AutoSize = true;
            this.lbl_reg_uname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_uname.Location = new System.Drawing.Point(65, 173);
            this.lbl_reg_uname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_reg_uname.Name = "lbl_reg_uname";
            this.lbl_reg_uname.Size = new System.Drawing.Size(87, 21);
            this.lbl_reg_uname.TabIndex = 50;
            this.lbl_reg_uname.Text = "Username";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 61;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // InvProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.panel1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvProfile";
            this.Text = "InvProfile";
            this.Load += new System.EventHandler(this.InvProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login_close;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl_reg_email;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label lbl_reg_phn;
        private System.Windows.Forms.TextBox tb_fname;
        private System.Windows.Forms.Label lbl_reg_fname;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_uname;
        private System.Windows.Forms.Label lbl_reg_pass;
        private System.Windows.Forms.Label lbl_reg_uname;
        private System.Windows.Forms.Button btnBack;
    }
}