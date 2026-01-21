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
    public partial class Login : Form
    {
        //string s = @"Data Source=DESKTOP-L4K97ST\SQLEXPRESS;Initial Catalog=PharmacyDb;Integrated Security=True";

        string s = DbConfig.ConnectionString;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void lbl_login_to_reg_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.Show();
            this.Hide();
        }

        private void btn_login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void btn_login_Click(object sender, EventArgs e)
        {
            lbl_error_uname.Text = "";
            lbl_error_pass.Text = "";

            // 1️⃣ Empty field validation
            if (string.IsNullOrWhiteSpace(tb_login_uname.Text))
            {
                lbl_error_uname.Text = "Username is required!";
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_login_pass.Text))
            {
                lbl_error_pass.Text = "Password is required!";
                return;
            }

            // 2️⃣ Role validation
            if (comboBox_login.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role!", "Error Message", MessageBoxButtons.OK,   MessageBoxIcon.Error);
                return;
            }

            // 3️⃣ Database check
            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();

                string query = @"SELECT usertype  FROM UserAccounts WHERE username = @usern AND password = @pass";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usern", tb_login_uname.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", tb_login_pass.Text.Trim());

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string dbUserType = reader["usertype"].ToString();
                        string selectedRole = comboBox_login.SelectedItem.ToString();

                        Session.CurrentUsername = tb_login_uname.Text.Trim();

                        // 4️⃣ Role match check
                        if (dbUserType != selectedRole)
                        {
                            MessageBox.Show("Selected role does not match your account!", "Role Mismatch", MessageBoxButtons.OK,  MessageBoxIcon.Warning);
                            return;
                        }

                        MessageBox.Show("Login Successful!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 5️⃣ Open dashboard
                        if (dbUserType == "Admin")
                        {
                            
                            new AdminDashboard().Show();
                        }
                        else if (dbUserType == "Pharmacist")
                        {
                            new PharmacistDashboard().Show();
                        }
                        else if(dbUserType == "Cashier")
                        {
                            new CashierDashboard().Show();
                        }
                        else if(dbUserType == "Inventory Manager")
                        {
                            new InventoryManagerDashboard().Show();
                        }
                        

                            this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void cb_login_CheckedChanged(object sender, EventArgs e)
        {
            tb_login_pass.PasswordChar = cb_login.Checked ? '\0' : '*';
        }

        private void comboBox_login_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
