using PMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.View
{
    public partial class CashierDashboard : Form
    {
        //string s = @"Data Source=DESKTOP-L4K97ST\SQLEXPRESS;Initial Catalog=PharmacyDb;Integrated Security=True";
        string s = DbConfig.ConnectionString;

        public CashierDashboard()
        {
            InitializeComponent();
        }

        public void loadList()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(s))
                {
                    con.Open();

                    string query = "SELECT mName FROM Medicine WHERE eDate >= GETDATE() AND quantity > 0";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    lb_med.DataSource = dt;
                    lb_med.DisplayMember = "mName"; // VERY IMPORTANT
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void CashierDashboard_Load(object sender, EventArgs e)
        {
            loadList();

            dataGridView1.AllowUserToAddRows = false;
            //dataGridView1.Columns.Add("MedID", "Medicine ID");
            //dataGridView1.Columns.Add("MedName", "Medicine Name");
            //dataGridView1.Columns.Add("PricePerUnit", "Price Per Unit");
            //dataGridView1.Columns.Add("NoOfUnits", "Quantity");
            //dataGridView1.Columns.Add("TotalPrice", "Total Price");
            //dataGridView1.Columns.Add("Customer Name");
        }

        private void tb_searchMed_TextChanged(object sender, EventArgs e)
        {


            try
            {

                using (SqlConnection con = new SqlConnection(s))
                {
                    con.Open();
                    string query = "SELECT mName FROM MEDICINE where mName LIKE @name AND eDate>=GETDATE() AND quantity>0";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", "%" + tb_searchMed.Text + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        lb_med.DataSource = dt;
                        lb_med.DisplayMember = "mName";

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void lb_med_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_noOfUnits.Clear();
            String name = lb_med.GetItemText(lb_med.SelectedItem);

            tb_medName.Text = name;

            try
            {
                using (SqlConnection con = new SqlConnection(s))
                {
                    con.Open();
                    string query = "SELECT mId, eDate, pricePerUnit FROM MEDICINE WHERE mName = @name";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            tb_medID.Text = reader["mId"].ToString();
                            //tb_eDate.Text = Convert.ToDateTime(reader["eDate"]).ToString("yyyy-MM-dd");
                            tb_eDate.Text = reader["eDate"].ToString();
                            // tb_noOfUnits.Text = reader["quantity"].ToString();
                            tb_pricePerUnit.Text = reader["pricePerUnit"].ToString();

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tb_noOfUnits_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tb_noOfUnits.Text, out int units))
            {
                tb_totalPrice.Clear();
                return;
            }

            if (!decimal.TryParse(tb_pricePerUnit.Text, out decimal price))
            {
                tb_totalPrice.Clear();
                return;
            }

            decimal total = units * price;
            tb_totalPrice.Text = total.ToString("0.00");
        }

        protected decimal totalAmount = 0;
        protected int n;
        protected Int64 quantity, newQuantity;


        // Print Receipt button click event
        


        // Add to Cart button click event
        private void btn_addToCart_Click(object sender, EventArgs e)
        { 
            if(tb_cusName.Text == "")
            {
                MessageBox.Show("Please enter customer name.");
                return;
            }
            if (tb_medID.Text != "")
            {
                using (SqlConnection con = new SqlConnection(s))
                {
                    con.Open();
                    string query = "SELECT quantity FROM MEDICINE WHERE mId = @mId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@mId", tb_medID.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            quantity = Convert.ToInt64(ds.Tables[0].Rows[0]["quantity"]);
                        }

                        newQuantity = quantity - Int64.Parse(tb_noOfUnits.Text);

                    }
                }

                // newQuantity = quantity - Convert.ToInt32(tb_noOfUnits.Text);
                if (newQuantity > 0)
                {
                    n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = tb_medID.Text;
                    dataGridView1.Rows[n].Cells[1].Value = tb_medName.Text;
                    dataGridView1.Rows[n].Cells[2].Value = tb_pricePerUnit.Text;
                    dataGridView1.Rows[n].Cells[3].Value = tb_noOfUnits.Text;
                    dataGridView1.Rows[n].Cells[4].Value = tb_totalPrice.Text;
                    dataGridView1.Rows[n].Cells[5].Value = tb_cusName.Text;

                    totalAmount += Convert.ToDecimal(tb_totalPrice.Text);
                    lbl_total.Text = totalAmount.ToString("0.00");

                    //Updating the quantity in the database
                    UpdateMed();
                }

                else
                {
                    MessageBox.Show("Medicine is out of Stock\n" + quantity + "left");
                }

            }
            else
            {
                MessageBox.Show("Please select a medicine from the list.");
                return;
            }
        }

        //Updating the quantity in the database
        public void UpdateMed()
        {
            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();
                string query = "UPDATE MEDICINE SET quantity = @newQuantity WHERE mId = @mId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@newQuantity", newQuantity);
                    cmd.Parameters.AddWithValue("@mId", tb_medID.Text);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Cell clicking event for deleting purpose from AddToCart

        decimal valueAmount;
        string valueId;
        protected Int64 noOfunit;




        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header clicks

            try
            {
                valueAmount = Convert.ToDecimal(
                    dataGridView1.Rows[e.RowIndex].Cells[4].Value
                );

                valueId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                noOfunit = Convert.ToInt64(
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Row selection error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //remove button code (removing items that are already added) 
        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(valueId))
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }

            try
            {
                // Remove row from grid
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows.RemoveAt(rowIndex);

                using (SqlConnection con = new SqlConnection(s))
                {
                    con.Open();

                    // Get current quantity
                    string selectQuery = "SELECT quantity FROM MEDICINE WHERE mId = @mId";
                    using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@mId", valueId);
                        quantity = Convert.ToInt64(cmd.ExecuteScalar());
                    }

                    newQuantity = quantity + noOfunit;

                    // Restore quantity
                    UpdateMed();
                }

                // Update total
                totalAmount -= valueAmount;
                lbl_total.Text = totalAmount.ToString("0.00");

                // Reset temp values
                valueId = "";
                valueAmount = 0;
                noOfunit = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        // print-receipt button code
        private void btn_PrintReceipt_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(tb_cusName.Text))
            //{
            //    MessageBox.Show("Please enter customer name.");
            //    return;
            //}

            //Sale sale = new Sale(tb_cusName.Text, totalAmount, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            //SaleRepo repo = new SaleRepo();
            ////retrieving saleId 
            //int sID = repo.Insert(sale);

            ////retrieving saleId 
            ////int sID= repo.GetSaleID(tb_cusName.Text);


            ////Sale Details

            //int medId = int.Parse(tb_medID.Text);
            //int quantity = int.Parse(tb_noOfUnits.Text);
            //decimal price = decimal.Parse(tb_pricePerUnit.Text);

            //SaleDetails details = new SaleDetails(sID, medId,  quantity, price);


            //SaleDetailsRepo detailsRepo = new SaleDetailsRepo();
            //detailsRepo.Insert(details);
            ////--------------------------------------------------------------------------------------

            //MessageBox.Show("Sale recorded successfully!");
            //dataGridView1.Rows.Clear();
            //clearAll();
            //lbl_total.Text = "0.00";
            //totalAmount = 0;



            Sale sale = new Sale(tb_cusName.Text, totalAmount, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            SaleRepo repo = new SaleRepo();

            // 1️⃣ Create sale and get saleId
            int sID = repo.Insert(sale);

            // 2️⃣ Insert EACH medicine from cart
            SaleDetailsRepo detailsRepo = new SaleDetailsRepo();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int medId = Convert.ToInt32(row.Cells[0].Value);       // mId
                int qty = Convert.ToInt32(row.Cells[3].Value);       // quantity
                decimal price = Convert.ToDecimal(row.Cells[2].Value); // pricePerUnit

                SaleDetails details = new SaleDetails(sID, medId, qty, price);
                detailsRepo.Insert(details);
            }
            MessageBox.Show("Sale recorded successfully!");
            dataGridView1.Rows.Clear();
            clearAll();
            lbl_total.Text = "0.00";
            totalAmount = 0;



        }




        //clear all
        public void clearAll()
        {
            tb_noOfUnits.Clear();
            tb_cusName.Clear();
           
        }
        //log out code
        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }



    }
}
