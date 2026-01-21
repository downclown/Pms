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
    public partial class AdminViewReport : Form
    {
        string s= DbConfig.ConnectionString;
        public AdminViewReport()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_ColumnHeadersDefaultCellStyleChanged(object sender, EventArgs e)
        {

        }

        private void AdminViewReport_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
            new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView2.ColumnHeadersDefaultCellStyle.Font =
            new Font(dataGridView1.Font, FontStyle.Bold);

            loadReport1();
            loadReport2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard a = new AdminDashboard();
            a.Show();
            this.Hide();
        }

        private void btn_login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void loadReport1()
        {
            // Code to load report data into dataGridView1
            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();
                string query = @"
                SELECT
                    s.saleId       AS 'Sale ID',
                    s.customerName AS 'Customer Name',
                    s.saleDate     AS 'Sale Date',
                    sd.mId         AS 'Medicine ID',
                    sd.quantity    AS 'Quantity',
                    sd.pricePerUnit AS 'Price Per Unit',
                    (sd.quantity * sd.pricePerUnit) AS 'Item Total'
                FROM Sale s
                JOIN SaleDetails sd
                    ON s.saleId = sd.saleId
                ORDER BY s.saleId;
                ";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                }
            }
        }

        private void loadReport2()
        {
            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();
                string query = @"
                SELECT
                s.customerName AS 'Customer Name',
                SUM(sd.quantity * sd.pricePerUnit) AS 'Total Revenue'
                FROM Sale s
                JOIN SaleDetails sd
                ON s.saleId = sd.saleId
                GROUP BY
                s.customerName
                ORDER BY
                [Total Revenue] DESC;
                ";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView2.DataSource = dt;

                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
