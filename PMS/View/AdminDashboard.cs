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
using PMS.Models;
using PMS.Services;


namespace PMS.View
{
    public partial class AdminDashboard : Form
    {

        // string s = @"Data Source=DESKTOP-L4K97ST\SQLEXPRESS;Initial Catalog=PharmacyDb;Integrated Security=True";
        string s = DbConfig.ConnectionString;

        CartServices cartservice = new CartServices();
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            TotalUsers();
            LoadUserCounts();


            lbl_username.Text = Session.CurrentUsername;
            int rev = cartservice.getRevenue();
            lbl_revenue.Text = rev.ToString() + " TK";
        }

        private void btn_login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_Tcount_Click(object sender, EventArgs e)
        {
        }


        // Total Users
        private void TotalUsers()
        {
            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM UserAccounts";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    int totalUsers = (int)cmd.ExecuteScalar();
                    lbl_count.Text = totalUsers.ToString();
                }
            }
        }

        private int GetUserCountByType(string userType)
        {
            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM UserAccounts WHERE Usertype = @Usertype";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Usertype", userType);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        private void LoadUserCounts()
        {
            lbl_admin_count.Text = GetUserCountByType("Admin").ToString();
            lbl_pharmacist_count.Text = GetUserCountByType("Pharmacist").ToString();
            lbl_cashier_count.Text = GetUserCountByType("Cashier").ToString();
        }

        

        

        private void btn_users_Click(object sender, EventArgs e)
        {
            AdminEditUser a = new AdminEditUser();
            a.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void btn_access_wallet_Click(object sender, EventArgs e)
        {

        }

        private void btn_viewmed_Click(object sender, EventArgs e)
        {
            AdminViewMedicines a = new AdminViewMedicines();
            a.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
