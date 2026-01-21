namespace PMS.View
{
    partial class AdminEditUser
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_dlt = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_login_close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_add.Location = new System.Drawing.Point(56, 131);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 35);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_dlt
            // 
            this.btn_dlt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_dlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dlt.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_dlt.Location = new System.Drawing.Point(156, 131);
            this.btn_dlt.Name = "btn_dlt";
            this.btn_dlt.Size = new System.Drawing.Size(94, 35);
            this.btn_dlt.TabIndex = 1;
            this.btn_dlt.Text = "Delete";
            this.btn_dlt.UseVisualStyleBackColor = false;
            this.btn_dlt.Click += new System.EventHandler(this.btn_dlt_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_update.Location = new System.Drawing.Point(256, 131);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(94, 35);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Bisque;
            this.dataGridView1.Location = new System.Drawing.Point(56, 186);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(969, 502);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.ColumnHeadersDefaultCellStyleChanged += new System.EventHandler(this.dataGridView1_ColumnHeadersDefaultCellStyleChanged);
            // 
            // btn_login_close
            // 
            this.btn_login_close.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_login_close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_login_close.FlatAppearance.BorderSize = 5;
            this.btn_login_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_close.Location = new System.Drawing.Point(1028, 12);
            this.btn_login_close.Name = "btn_login_close";
            this.btn_login_close.Size = new System.Drawing.Size(38, 40);
            this.btn_login_close.TabIndex = 43;
            this.btn_login_close.Text = "X";
            this.btn_login_close.UseVisualStyleBackColor = false;
            this.btn_login_close.Click += new System.EventHandler(this.btn_login_close_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 40);
            this.button1.TabIndex = 44;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_search.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_search.Location = new System.Drawing.Point(980, 140);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(45, 40);
            this.btn_search.TabIndex = 45;
            this.btn_search.Text = "🔎";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(786, 146);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(169, 26);
            this.tb_search.TabIndex = 46;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // AdminEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1077, 715);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_login_close);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_dlt);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEditUser";
            this.Load += new System.EventHandler(this.AdminEditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_dlt;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_login_close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_search;
    }
}