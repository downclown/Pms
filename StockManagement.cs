using PMS.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PMS.View
{
    public partial class StockManagement : Form
    {
        public StockManagement()
        {
            InitializeComponent();
        }

        private StockRepo stockRepo = new StockRepo();

        private void StockManagement_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStock.Rows[e.RowIndex];

                txtStockId.Text = row.Cells["stockId"].Value.ToString();
                txtMedicineId.Text = row.Cells["mId"].Value.ToString();
                txtQuantity.Text = row.Cells["quantity"].Value.ToString();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock(
                Convert.ToInt32(txtMedicineId.Text),
                Convert.ToInt32(txtQuantity.Text)
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
                MessageBox.Show(
                    "Please select a stock record to delete.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
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
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStockId.Text) ||
                string.IsNullOrWhiteSpace(txtMedicineId.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please select a stock item and enter transfer quantity.",
                                "Missing Data",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int transferQty))
            {
                MessageBox.Show("Transfer quantity must be a valid number.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (transferQty <= 0)
            {
                MessageBox.Show("Transfer quantity must be greater than zero.",
                                "Invalid Quantity",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int stockId = Convert.ToInt32(txtStockId.Text);
            int medicineId = Convert.ToInt32(txtMedicineId.Text);

            // 🔒 Optional UI-level stock check
            int availableStock = Convert.ToInt32(
                dgvStock.CurrentRow.Cells["quantity"].Value
            );

            if (transferQty > availableStock)
            {
                MessageBox.Show("Transfer quantity exceeds available stock.",
                                "Insufficient Stock",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                stockRepo.TransferStockToMedicine(stockId, medicineId, transferQty);

                MessageBox.Show("Stock transferred successfully.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                RefreshGrid();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message,
                                "Transfer Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btn_login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
