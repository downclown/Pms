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
    

    public partial class InvProfile : Form
    {
        string s = DbConfig.ConnectionString;
        public InvProfile()
        {
            InitializeComponent();
        }

        

        private void LoadProfileData()
        {
            string uname = Session.CurrentUsername;

            //if (string.IsNullOrEmpty(uname))
            //{
            //    MessageBox.Show("Current username is empty!");
            //    return;
            //}

            try
            {
                using (SqlConnection con = new SqlConnection(DbConfig.ConnectionString))
                {
                    con.Open();

                    string query = "SELECT * FROM UserAccounts WHERE username = @uname";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@uname", uname); // must match @uname in query

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tb_fname.Text = reader["fullname"].ToString();
                                tb_uname.Text = reader["username"].ToString();
                                tb_pass.Text = reader["password"].ToString();
                                tb_phone.Text = reader["phoneNumber"].ToString();
                                tb_email.Text = reader["email"].ToString();

                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void InvProfile_Load(object sender, EventArgs e)
        {
            LoadProfileData();
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            InvUpdateProfile a = new InvUpdateProfile();
            a.Show();
            this.Hide();
        }

        private void btn_login_close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            InventoryManagerDashboard a = new InventoryManagerDashboard();
            a.Show();
            this.Hide();
        }
    }
}
