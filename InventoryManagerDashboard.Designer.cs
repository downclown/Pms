namespace PMS.View
{
    partial class InventoryManagerDashboard
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
            this.btn_logout = new System.Windows.Forms.Button();
            this.btnStockValidity = new System.Windows.Forms.Button();
            this.btnStockManagement = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutOfStock = new System.Windows.Forms.Label();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.lblTotalMedicine = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_login_close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btnStockValidity);
            this.panel1.Controls.Add(this.btnStockManagement);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 464);
            this.panel1.TabIndex = 8;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Lavender;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(21, 416);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(114, 32);
            this.btn_logout.TabIndex = 43;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btnStockValidity
            // 
            this.btnStockValidity.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnStockValidity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockValidity.FlatAppearance.BorderSize = 0;
            this.btnStockValidity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStockValidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockValidity.ForeColor = System.Drawing.Color.Black;
            this.btnStockValidity.Location = new System.Drawing.Point(3, 244);
            this.btnStockValidity.Name = "btnStockValidity";
            this.btnStockValidity.Size = new System.Drawing.Size(155, 52);
            this.btnStockValidity.TabIndex = 2;
            this.btnStockValidity.Text = "Stock Validity";
            this.btnStockValidity.UseVisualStyleBackColor = false;
            this.btnStockValidity.Click += new System.EventHandler(this.btnStockValidity_Click);
            // 
            // btnStockManagement
            // 
            this.btnStockManagement.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnStockManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockManagement.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnStockManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStockManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockManagement.ForeColor = System.Drawing.Color.Black;
            this.btnStockManagement.Location = new System.Drawing.Point(3, 179);
            this.btnStockManagement.Name = "btnStockManagement";
            this.btnStockManagement.Size = new System.Drawing.Size(155, 52);
            this.btnStockManagement.TabIndex = 1;
            this.btnStockManagement.Text = "Stock Management";
            this.btnStockManagement.UseVisualStyleBackColor = false;
            this.btnStockManagement.Click += new System.EventHandler(this.btnStockManagement_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Out of Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Low Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Medicine in Inventory";
            // 
            // lblOutOfStock
            // 
            this.lblOutOfStock.AutoSize = true;
            this.lblOutOfStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutOfStock.Location = new System.Drawing.Point(258, 138);
            this.lblOutOfStock.Name = "lblOutOfStock";
            this.lblOutOfStock.Size = new System.Drawing.Size(18, 19);
            this.lblOutOfStock.TabIndex = 3;
            this.lblOutOfStock.Text = "0";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStock.Location = new System.Drawing.Point(258, 87);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(18, 19);
            this.lblLowStock.TabIndex = 2;
            this.lblLowStock.Text = "0";
            // 
            // lblTotalMedicine
            // 
            this.lblTotalMedicine.AutoSize = true;
            this.lblTotalMedicine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMedicine.Location = new System.Drawing.Point(258, 34);
            this.lblTotalMedicine.Name = "lblTotalMedicine";
            this.lblTotalMedicine.Size = new System.Drawing.Size(18, 19);
            this.lblTotalMedicine.TabIndex = 1;
            this.lblTotalMedicine.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Moccasin;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblOutOfStock);
            this.panel2.Controls.Add(this.lblLowStock);
            this.panel2.Controls.Add(this.lblTotalMedicine);
            this.panel2.Location = new System.Drawing.Point(277, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 201);
            this.panel2.TabIndex = 9;
            // 
            // btn_login_close
            // 
            this.btn_login_close.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_login_close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_login_close.FlatAppearance.BorderSize = 5;
            this.btn_login_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_close.Location = new System.Drawing.Point(676, 11);
            this.btn_login_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login_close.Name = "btn_login_close";
            this.btn_login_close.Size = new System.Drawing.Size(25, 26);
            this.btn_login_close.TabIndex = 43;
            this.btn_login_close.Text = "X";
            this.btn_login_close.UseVisualStyleBackColor = false;
            this.btn_login_close.Click += new System.EventHandler(this.btn_login_close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Inventory Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PMS.Properties.Resources.UserIcon;
            this.pictureBox1.Location = new System.Drawing.Point(11, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InventoryManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_login_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InventoryManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryManagerDashboard";
            this.Load += new System.EventHandler(this.InventoryManagerDashboard_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStockValidity;
        private System.Windows.Forms.Button btnStockManagement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOutOfStock;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Label lblTotalMedicine;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_login_close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}