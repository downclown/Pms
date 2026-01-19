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
using System.Xml.Linq;

namespace PMS.View
{
    public partial class MedicineManagement : Form
    {
        Medicine medicine = new Medicine();
        MedicineRepo medicineRepo = new MedicineRepo();
        public MedicineManagement()
        {
            InitializeComponent();
        }

        private void LoadMedicines()
        {
            dataGridView1.DataSource = null;
            var medicines = medicineRepo.GetAllMedicines();
            dataGridView1.DataSource = medicines;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {


        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }
            try
            {
                Medicine m = new Medicine
                {
                    MId = int.Parse(tb_mid.Text),
                    MName = tb_mname.Text,
                    MCompanyName = tb_cmname.Text,
                    MDate = dateTimePicker1.Text,
                    EDate = dateTimePicker2.Text,
                    Quantity = int.Parse(tb_quantity.Text),
                    PricePerUnit = decimal.Parse(tb_price.Text)
                };
                medicineRepo.AddMedicine(m);
                MessageBox.Show("Medicine added successfully!");
                LoadMedicines();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            tb_mid.Clear();
            tb_mname.Clear();
            tb_cmname.Clear();
            tb_quantity.Clear();
            tb_price.Clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            try
            {
                Medicine m = new Medicine(
                    int.Parse(tb_mid.Text),
                    tb_mname.Text,
                    tb_cmname.Text,
                    dateTimePicker1.Text,
                    dateTimePicker2.Text,
                    int.Parse(tb_quantity.Text),
                    decimal.Parse(tb_price.Text)
                );

                medicineRepo.UpdateMedicine(m);
                MessageBox.Show("Medicine updaed successfully!");
                LoadMedicines();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_dlt_Click(object sender, EventArgs e)
        {
            try
            {
                //var medId = int.Parse((string)dataGridView1.SelectedRows[0].Cells["MId"].Value);
                var medId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MId"].Value);

                medicineRepo.DeleteMedicine(medId);
                MessageBox.Show("Medicine deleted successfully!");
                LoadMedicines();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            PharmacistDashboard pharmacistDashboard = new PharmacistDashboard();
            pharmacistDashboard.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tb_mid.Text = row.Cells["MId"].Value.ToString();
                tb_mname.Text = row.Cells["MName"].Value.ToString();
                tb_cmname.Text = row.Cells["MCompanyName"].Value.ToString();
                dateTimePicker1.Text = row.Cells["MDate"].Value.ToString();
                dateTimePicker2.Text = row.Cells["EDate"].Value.ToString();
                tb_quantity.Text = row.Cells["Quantity"].Value.ToString();
                tb_price.Text = row.Cells["PricePerUnit"].Value.ToString();
            }

        }

        private void MedicineManagement_Load(object sender, EventArgs e)
        {
            LoadMedicines();
        }


        private bool ValidateFields(bool isInsert = true)
        {
            // Check MId
            if (string.IsNullOrWhiteSpace(tb_mid.Text))
            {
                MessageBox.Show("Please enter a valid Medicine ID!");
                tb_mid.Focus();
                return false;
            }

            if (!int.TryParse(tb_mid.Text, out int mid))
            {
                MessageBox.Show("Medicine ID must be a number!");
                tb_mid.Focus();
                return false;
            }

            // Check Name
            if (string.IsNullOrWhiteSpace(tb_mname.Text))
            {
                MessageBox.Show("Please enter the Medicine Name!");
                tb_mname.Focus();
                return false;
            }

            // Check Company Name
            if (string.IsNullOrWhiteSpace(tb_cmname.Text))
            {
                MessageBox.Show("Please enter the Company Name!");
                tb_cmname.Focus();
                return false;
            }

            // Check Quantity
            if (!int.TryParse(tb_quantity.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Quantity must be a positive number!");
                tb_quantity.Focus();
                return false;
            }

            // Check Price
            if (!decimal.TryParse(tb_price.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Price must be a positive number!");
                tb_price.Focus();
                return false;
            }

            // Optional: check expiry date >= manufacture date
            if (DateTime.Parse(dateTimePicker2.Text) < DateTime.Parse(dateTimePicker1.Text))
            {
                MessageBox.Show("Expiry date cannot be earlier than Manufacture date!");
                dateTimePicker2.Focus();
                return false;
            }

            return true;
        }

        private void btn_login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click_2(object sender, EventArgs e)
        {
            PharmacistDashboard pharmacistDashboard = new PharmacistDashboard();
            pharmacistDashboard.Show();
            this.Hide();
        }




        //private void btn_search_Click(object sender, EventArgs e)
        //{
        //    string keyword = tb_search.Text.Trim();

        //    if (string.IsNullOrEmpty(keyword))
        //    {
        //        LoadMedicines();
        //        return;
        //    }

        //    var results = medicineRepo.GetMedicinesByName(keyword);

        //    if (results.Count > 0)
        //    {
        //        dataGridView1.DataSource = null;
        //        dataGridView1.DataSource = results;
        //    }
        //    else
        //    {
        //        MessageBox.Show("No medicine found with this name.");
        //        dataGridView1.DataSource = null;
        //    }
        //}

        //private void tb_search_TextChanged(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(tb_search.Text))
        //    {
        //        LoadMedicines(); // reload all medicines automatically when cleared
        //    }
        //}


        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = tb_search.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                // TextBox is empty → reload all medicines
                LoadMedicines();
                return;
            }

            // Partial match search
            var results = medicineRepo.GetMedicinesByName(keyword);

            if (results != null && results.Count > 0)
            {
                dataGridView1.DataSource = null;      // reset grid
                dataGridView1.DataSource = results;   // bind new list
            }
            else
            {
                MessageBox.Show("No medicine found with this name.");
                dataGridView1.DataSource = null;      // clear grid
            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_search.Text))
            {
                // Clear search → reload all medicines
                LoadMedicines();
            }
        }

       
    }
}


