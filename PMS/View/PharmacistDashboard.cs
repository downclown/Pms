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
    public partial class PharmacistDashboard : Form

    {
        //string s = @"Data Source=DESKTOP-L4K97ST\SQLEXPRESS;Initial Catalog=PharmacyDb;Integrated Security=True";
        string s = DbConfig.ConnectionString;

        public PharmacistDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_medMng_Click(object sender, EventArgs e)
        {
            MedicineManagement mng = new MedicineManagement();
            mng.Show();
            this.Hide();
        }

        private void med_valid_Click(object sender, EventArgs e)
        {
            MedValidity medValidity = new MedValidity();
            medValidity.Show();
            this.Hide();
        }

        private void btn_login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        //load chart
        int count = 0;
        public void LoadChart()
        {
            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();
                string query = "SELECT COUNT(mName) FROM Medicine WHERE eDate >= GETDATE()";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                    this.chart1.Series["Valid Medicines"].Points.AddXY("Medicine Validity Chart", count);
                }

                string query2 = "SELECT COUNT(mName) FROM Medicine WHERE eDate < GETDATE()";
                using (SqlCommand cmdd = new SqlCommand(query2, con))
                {
                    count = Convert.ToInt32(cmdd.ExecuteScalar());
                    this.chart1.Series["Expired Medicines"].Points.AddXY("Medicine Validity Chart", count);
                }
            }
        }
        // count medicines

        int countMed = 0;
         public void countMedicine()
        {
            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();
                string query = "SELECT COUNT(mName) FROM Medicine";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                    label3.Text = count.ToString();
                    
                }

            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void PharmacistDashboard_Load(object sender, EventArgs e)
        {
            LoadChart();
            countMedicine();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
