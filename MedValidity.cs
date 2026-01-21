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

    public partial class MedValidity : Form
    {
        // string s = @"Data Source=DESKTOP-L4K97ST\SQLEXPRESS;Initial Catalog=PharmacyDb;Integrated Security=True";
        string s = DbConfig.ConnectionString;


        public MedValidity()
        {
            InitializeComponent();
        }

        private void lbl_chk_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbl_chk.SelectedIndex == 0)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(s))
                    {
                        con.Open();
                        string query ="SELECT * FROM Medicine WHERE eDate >= GETDATE()";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                            
                            label1.Text = "Valid Medicines";
                            label1.ForeColor = Color.Red;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (lbl_chk.SelectedIndex == 1)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(s))
                    {
                        con.Open();
                        string query = "SELECT * FROM Medicine WHERE eDate < GETDATE()";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;

                            label1.Text = "Expired Medicines";
                            label1.ForeColor = Color.Red;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (lbl_chk.SelectedIndex == 2)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(s))
                    {
                        con.Open();
                        string query = "SELECT * FROM Medicine ";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;

                            label1.Text = "All Medicines";
                            label1.ForeColor = Color.Red;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void MedValidity_Load(object sender, EventArgs e)
        {
            dataGridView1.ForeColor = Color.Black; // ⭐ THIS WAS MISSING
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;

            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void btn_login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PharmacistDashboard p = new PharmacistDashboard();
            p.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PharmacistDashboard p = new PharmacistDashboard();
            p.Show();
            this.Hide();
        }
    }
}
