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
using System.Data.SqlClient;

namespace PMS.View
{
    public partial class StockManagement : Form
    {
        public StockManagement()
        {
            InitializeComponent();
        }
        string connectionString = DbConfig.ConnectionString;

        private StockRepo stockRepo = new StockRepo();

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStock.Rows[e.RowIndex];

                txtStockId.Text = row.Cells["stockId"].Value.ToString();
                txtMedicineId.Text = row.Cells["mId"].Value.ToString();
                txtQuantity.Text = row.Cells["quantity"].Value.ToString();
                txtReorderLevel.Text = row.Cells["reorderLevel"].Value.ToString();

            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock(
                Convert.ToInt32(txtMedicineId.Text),
                Convert.ToInt32(txtQuantity.Text),
                Convert.ToInt32(txtReorderLevel.Text)
            );

            stockRepo.InsertStock(stock);
            RefreshGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int medicineId = Convert.ToInt32(txtMedicineId.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);

            stockRepo.UpdateStockQuantity(medicineId, quantity);
            RefreshGrid();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStockId.Text))
            {
                MessageBox.Show("Please select a stock record to delete.",
                                "No Selection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this stock record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                int stockId = Convert.ToInt32(txtStockId.Text);
                stockRepo.DeleteStock(stockId);
                RefreshGrid();
            }
        }


        private void RefreshGrid()
        {
            dgvStock.DataSource = stockRepo.GetStockForManagement();
            dgvStock.ClearSelection();
            ClearFields();
        }


        private void ClearFields()
        {
            txtStockId.Clear();
            txtMedicineId.Clear();
            txtQuantity.Clear();
            txtReorderLevel.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            dgvStock.ClearSelection();
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            InventoryManagerDashboard dashboard = new InventoryManagerDashboard();
            dashboard.Show();
            this.Close();
        }

        private void StockManagement_Load(object sender, EventArgs e)
        {
            dgvStock.DataSource = stockRepo.GetStockForManagement();

        }
    }
}
