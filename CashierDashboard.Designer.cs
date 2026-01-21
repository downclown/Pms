namespace PMS.View
{
    partial class CashierDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_searchMed = new System.Windows.Forms.TextBox();
            this.lb_med = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_medID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_medName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_eDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_pricePerUnit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_noOfUnits = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_totalPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_cusName = new System.Windows.Forms.TextBox();
            this.btn_addToCart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_PrintReceipt = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtp = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sell Medicines";
            // 
            // tb_searchMed
            // 
            this.tb_searchMed.Location = new System.Drawing.Point(31, 75);
            this.tb_searchMed.Margin = new System.Windows.Forms.Padding(2);
            this.tb_searchMed.Name = "tb_searchMed";
            this.tb_searchMed.Size = new System.Drawing.Size(121, 20);
            this.tb_searchMed.TabIndex = 1;
            this.tb_searchMed.TextChanged += new System.EventHandler(this.tb_searchMed_TextChanged);
            // 
            // lb_med
            // 
            this.lb_med.FormattingEnabled = true;
            this.lb_med.Location = new System.Drawing.Point(31, 112);
            this.lb_med.Margin = new System.Windows.Forms.Padding(2);
            this.lb_med.Name = "lb_med";
            this.lb_med.Size = new System.Drawing.Size(121, 290);
            this.lb_med.TabIndex = 2;
            this.lb_med.SelectedIndexChanged += new System.EventHandler(this.lb_med_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search";
            // 
            // tb_medID
            // 
            this.tb_medID.Location = new System.Drawing.Point(199, 75);
            this.tb_medID.Margin = new System.Windows.Forms.Padding(2);
            this.tb_medID.Name = "tb_medID";
            this.tb_medID.ReadOnly = true;
            this.tb_medID.Size = new System.Drawing.Size(169, 20);
            this.tb_medID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medicine ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Medicine Name";
            // 
            // tb_medName
            // 
            this.tb_medName.Location = new System.Drawing.Point(199, 118);
            this.tb_medName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_medName.Name = "tb_medName";
            this.tb_medName.ReadOnly = true;
            this.tb_medName.Size = new System.Drawing.Size(169, 20);
            this.tb_medName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Expire Date";
            // 
            // tb_eDate
            // 
            this.tb_eDate.Location = new System.Drawing.Point(199, 161);
            this.tb_eDate.Margin = new System.Windows.Forms.Padding(2);
            this.tb_eDate.Name = "tb_eDate";
            this.tb_eDate.ReadOnly = true;
            this.tb_eDate.Size = new System.Drawing.Size(169, 20);
            this.tb_eDate.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price Per Unit";
            // 
            // tb_pricePerUnit
            // 
            this.tb_pricePerUnit.Location = new System.Drawing.Point(199, 205);
            this.tb_pricePerUnit.Margin = new System.Windows.Forms.Padding(2);
            this.tb_pricePerUnit.Name = "tb_pricePerUnit";
            this.tb_pricePerUnit.ReadOnly = true;
            this.tb_pricePerUnit.Size = new System.Drawing.Size(169, 20);
            this.tb_pricePerUnit.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(481, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "No of units";
            // 
            // tb_noOfUnits
            // 
            this.tb_noOfUnits.Location = new System.Drawing.Point(484, 75);
            this.tb_noOfUnits.Margin = new System.Windows.Forms.Padding(2);
            this.tb_noOfUnits.Name = "tb_noOfUnits";
            this.tb_noOfUnits.Size = new System.Drawing.Size(169, 20);
            this.tb_noOfUnits.TabIndex = 12;
            this.tb_noOfUnits.TextChanged += new System.EventHandler(this.tb_noOfUnits_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(481, 99);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total Price";
            // 
            // tb_totalPrice
            // 
            this.tb_totalPrice.Location = new System.Drawing.Point(484, 118);
            this.tb_totalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tb_totalPrice.Name = "tb_totalPrice";
            this.tb_totalPrice.ReadOnly = true;
            this.tb_totalPrice.Size = new System.Drawing.Size(169, 20);
            this.tb_totalPrice.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(481, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Customer Name";
            // 
            // tb_cusName
            // 
            this.tb_cusName.Location = new System.Drawing.Point(484, 161);
            this.tb_cusName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_cusName.Name = "tb_cusName";
            this.tb_cusName.Size = new System.Drawing.Size(169, 20);
            this.tb_cusName.TabIndex = 16;
            // 
            // btn_addToCart
            // 
            this.btn_addToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addToCart.Location = new System.Drawing.Point(550, 240);
            this.btn_addToCart.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addToCart.Name = "btn_addToCart";
            this.btn_addToCart.Size = new System.Drawing.Size(101, 23);
            this.btn_addToCart.TabIndex = 20;
            this.btn_addToCart.Text = "Add To Cart";
            this.btn_addToCart.UseVisualStyleBackColor = true;
            this.btn_addToCart.Click += new System.EventHandler(this.btn_addToCart_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(199, 278);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(453, 124);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Med ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Med Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total Price";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Customer Name";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Date";
            this.Column7.Name = "Column7";
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(199, 418);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(78, 23);
            this.btn_remove.TabIndex = 22;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_PrintReceipt
            // 
            this.btn_PrintReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintReceipt.Location = new System.Drawing.Point(550, 418);
            this.btn_PrintReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PrintReceipt.Name = "btn_PrintReceipt";
            this.btn_PrintReceipt.Size = new System.Drawing.Size(101, 23);
            this.btn_PrintReceipt.TabIndex = 23;
            this.btn_PrintReceipt.Text = "Print Receipt";
            this.btn_PrintReceipt.UseVisualStyleBackColor = true;
            this.btn_PrintReceipt.Click += new System.EventHandler(this.btn_PrintReceipt_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Gray;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(380, 418);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(56, 24);
            this.lbl_total.TabIndex = 24;
            this.lbl_total.Text = "Total ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(482, 205);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // dtp
            // 
            this.dtp.AutoSize = true;
            this.dtp.Location = new System.Drawing.Point(481, 189);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(30, 13);
            this.dtp.TabIndex = 26;
            this.dtp.Text = "Date";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Lavender;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(44, 414);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(96, 30);
            this.btn_logout.TabIndex = 43;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PMS.Properties.Resources.UserIcon;
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CashierDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(693, 455);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_PrintReceipt);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_addToCart);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_cusName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_totalPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_noOfUnits);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_pricePerUnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_eDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_medName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_medID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_med);
            this.Controls.Add(this.tb_searchMed);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CashierDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierDashboard";
            this.Load += new System.EventHandler(this.CashierDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_searchMed;
        private System.Windows.Forms.ListBox lb_med;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_medID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_medName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_eDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_pricePerUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_noOfUnits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_totalPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_cusName;
        private System.Windows.Forms.Button btn_addToCart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_PrintReceipt;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dtp;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}