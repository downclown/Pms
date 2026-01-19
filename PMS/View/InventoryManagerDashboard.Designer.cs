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
            this.btn_StockManagement = new System.Windows.Forms.Button();
            this.btnStockValidity = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutOfStock = new System.Windows.Forms.Label();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.lblTotalMedicine = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_StockManagement);
            this.panel1.Controls.Add(this.btnStockValidity);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 446);
            this.panel1.TabIndex = 8;
            // 
            // btn_StockManagement
            // 
            this.btn_StockManagement.BackColor = System.Drawing.Color.Black;
            this.btn_StockManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StockManagement.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_StockManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_StockManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StockManagement.ForeColor = System.Drawing.Color.Cyan;
            this.btn_StockManagement.Location = new System.Drawing.Point(3, 135);
            this.btn_StockManagement.Name = "btn_StockManagement";
            this.btn_StockManagement.Size = new System.Drawing.Size(155, 52);
            this.btn_StockManagement.TabIndex = 3;
            this.btn_StockManagement.Text = "Stock Management";
            this.btn_StockManagement.UseVisualStyleBackColor = false;
            this.btn_StockManagement.Click += new System.EventHandler(this.btn_StockManagement_Click);
            // 
            // btnStockValidity
            // 
            this.btnStockValidity.BackColor = System.Drawing.Color.Black;
            this.btnStockValidity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockValidity.FlatAppearance.BorderSize = 0;
            this.btnStockValidity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStockValidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockValidity.ForeColor = System.Drawing.Color.Cyan;
            this.btnStockValidity.Location = new System.Drawing.Point(3, 244);
            this.btnStockValidity.Name = "btnStockValidity";
            this.btnStockValidity.Size = new System.Drawing.Size(155, 52);
            this.btnStockValidity.TabIndex = 2;
            this.btnStockValidity.Text = "Stock Validity";
            this.btnStockValidity.UseVisualStyleBackColor = false;
            this.btnStockValidity.Click += new System.EventHandler(this.btnStockValidity_Click);
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
            this.panel2.Location = new System.Drawing.Point(396, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 201);
            this.panel2.TabIndex = 9;
            // 
            // InventoryManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "InventoryManagerDashboard";
            this.Text = "Inventory Manager Dashboard";
            this.Load += new System.EventHandler(this.InventoryManagerDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStockValidity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOutOfStock;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Label lblTotalMedicine;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_StockManagement;
    }
}