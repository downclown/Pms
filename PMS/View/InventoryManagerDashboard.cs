using PMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.View
{
    public partial class InventoryManagerDashboard : Form
    {
        public InventoryManagerDashboard()
        {
            InitializeComponent();
        }
        private StockRepo stockRepo = new StockRepo();

        private void InventoryManagerDashboard_Load(object sender, EventArgs e)
        {
            LoadStockSummary();
        }

        //private void btnStockManagement_Click(object sender, EventArgs e)
        ////{
        //MessageBox.Show("Navigating to Stock Management");
        //    StockManagement stockManagement = new StockManagement();
        //stockManagement.Show();
        //    this.Hide();
        //}

        private void btnStockValidity_Click(object sender, EventArgs e)
        {
            StockValidity stockValidity = new StockValidity();
            stockValidity.Show();
            this.Hide();
        }
        private void LoadStockSummary()
        {
            lblTotalMedicine.Text = stockRepo.GetTotalMedicineCount().ToString();
            lblLowStock.Text = stockRepo.GetLowStockCount().ToString();
            lblOutOfStock.Text = stockRepo.GetOutOfStockCount().ToString();
        }

        private void btn_StockManagement_Click(object sender, EventArgs e)
        {
            StockManagement stockManagement = new StockManagement();
            stockManagement.Show();
            this.Hide();
        }
    }
}
