namespace PMS.View
{
    partial class CreateEditForm
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
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.lbl_reg_usertype = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_reg_email = new System.Windows.Forms.Label();
            this.tb_phn = new System.Windows.Forms.TextBox();
            this.lbl_reg_phn = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_fname = new System.Windows.Forms.TextBox();
            this.lbl_reg_fname = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_uname = new System.Windows.Forms.TextBox();
            this.lbl_reg_pass = new System.Windows.Forms.Label();
            this.lbl_reg_uname = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_role
            // 
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Items.AddRange(new object[] {
            "Admin",
            "Pharmacist",
            "Customer"});
            this.cb_role.Location = new System.Drawing.Point(73, 352);
            this.cb_role.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(232, 21);
            this.cb_role.TabIndex = 47;
            // 
            // lbl_reg_usertype
            // 
            this.lbl_reg_usertype.AutoSize = true;
            this.lbl_reg_usertype.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_usertype.Location = new System.Drawing.Point(68, 330);
            this.lbl_reg_usertype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_reg_usertype.Name = "lbl_reg_usertype";
            this.lbl_reg_usertype.Size = new System.Drawing.Size(84, 21);
            this.lbl_reg_usertype.TabIndex = 46;
            this.lbl_reg_usertype.Text = "User Type";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(73, 306);
            this.tb_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(233, 20);
            this.tb_email.TabIndex = 45;
            // 
            // lbl_reg_email
            // 
            this.lbl_reg_email.AutoSize = true;
            this.lbl_reg_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_email.Location = new System.Drawing.Point(69, 283);
            this.lbl_reg_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_reg_email.Name = "lbl_reg_email";
            this.lbl_reg_email.Size = new System.Drawing.Size(53, 21);
            this.lbl_reg_email.TabIndex = 44;
            this.lbl_reg_email.Text = "Email";
            // 
            // tb_phn
            // 
            this.tb_phn.Location = new System.Drawing.Point(73, 259);
            this.tb_phn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_phn.Name = "tb_phn";
            this.tb_phn.Size = new System.Drawing.Size(233, 20);
            this.tb_phn.TabIndex = 43;
            // 
            // lbl_reg_phn
            // 
            this.lbl_reg_phn.AutoSize = true;
            this.lbl_reg_phn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_phn.Location = new System.Drawing.Point(69, 236);
            this.lbl_reg_phn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_reg_phn.Name = "lbl_reg_phn";
            this.lbl_reg_phn.Size = new System.Drawing.Size(126, 21);
            this.lbl_reg_phn.TabIndex = 42;
            this.lbl_reg_phn.Text = "Phone Number";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(73, 90);
            this.tb_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(233, 20);
            this.tb_id.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "ID";
            // 
            // tb_fname
            // 
            this.tb_fname.Location = new System.Drawing.Point(74, 133);
            this.tb_fname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_fname.Name = "tb_fname";
            this.tb_fname.Size = new System.Drawing.Size(233, 20);
            this.tb_fname.TabIndex = 55;
            // 
            // lbl_reg_fname
            // 
            this.lbl_reg_fname.AutoSize = true;
            this.lbl_reg_fname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_fname.Location = new System.Drawing.Point(70, 109);
            this.lbl_reg_fname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_reg_fname.Name = "lbl_reg_fname";
            this.lbl_reg_fname.Size = new System.Drawing.Size(81, 21);
            this.lbl_reg_fname.TabIndex = 54;
            this.lbl_reg_fname.Text = "Fullname";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(74, 217);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(233, 20);
            this.tb_pass.TabIndex = 53;
            // 
            // tb_uname
            // 
            this.tb_uname.Location = new System.Drawing.Point(74, 176);
            this.tb_uname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_uname.Name = "tb_uname";
            this.tb_uname.Size = new System.Drawing.Size(233, 20);
            this.tb_uname.TabIndex = 52;
            // 
            // lbl_reg_pass
            // 
            this.lbl_reg_pass.AutoSize = true;
            this.lbl_reg_pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_pass.Location = new System.Drawing.Point(70, 194);
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
            this.lbl_reg_uname.Location = new System.Drawing.Point(70, 152);
            this.lbl_reg_uname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_reg_uname.Name = "lbl_reg_uname";
            this.lbl_reg_uname.Size = new System.Drawing.Size(87, 21);
            this.lbl_reg_uname.TabIndex = 50;
            this.lbl_reg_uname.Text = "Username";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_save.FlatAppearance.BorderSize = 5;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(72, 381);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(109, 36);
            this.btn_save.TabIndex = 56;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cancel.FlatAppearance.BorderSize = 5;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(197, 381);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(109, 36);
            this.btn_cancel.TabIndex = 57;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(124, 20);
            this.lbl_heading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(95, 24);
            this.lbl_heading.TabIndex = 58;
            this.lbl_heading.Text = "Edit User";
            this.lbl_heading.Click += new System.EventHandler(this.lbl_heading_Click);
            // 
            // CreateEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(381, 455);
            this.Controls.Add(this.lbl_heading);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_fname);
            this.Controls.Add(this.lbl_reg_fname);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_uname);
            this.Controls.Add(this.lbl_reg_pass);
            this.Controls.Add(this.lbl_reg_uname);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_role);
            this.Controls.Add(this.lbl_reg_usertype);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lbl_reg_email);
            this.Controls.Add(this.tb_phn);
            this.Controls.Add(this.lbl_reg_phn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Label lbl_reg_usertype;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl_reg_email;
        private System.Windows.Forms.TextBox tb_phn;
        private System.Windows.Forms.Label lbl_reg_phn;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_fname;
        private System.Windows.Forms.Label lbl_reg_fname;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_uname;
        private System.Windows.Forms.Label lbl_reg_pass;
        private System.Windows.Forms.Label lbl_reg_uname;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_heading;
    }
}