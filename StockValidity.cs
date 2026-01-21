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
    public partial class StockValidity : Form
    {
        public StockValidity()
        {
            InitializeComponent();
        }

        private StockRepo stockRepo = new StockRepo();

        private void cmbStockFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStockFilter.SelectedItem.ToString() == "All Stock")
            {
                dgvStock.DataSource = stockRepo.GetAllStockView();
            }
            else if (cmbStockFilter.SelectedItem.ToString() == "Low Stock")
            {
                dgvStock.DataSource = stockRepo.GetLowStockView();
            }
            else if (cmbStockFilter.SelectedItem.ToString() == "Out of Stock")
            {
                dgvStock.DataSource = stockRepo.GetOutOfStockView();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            InventoryManagerDashboard dashboard = new InventoryManagerDashboard();
            dashboard.Show();
            this.Close();
        }

        private void StockValidity_Load_1(object sender, EventArgs e)
        {
            cmbStockFilter.SelectedIndex = 0;

        }

        private void btn_login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
