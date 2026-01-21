using PMS.Models;
using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PMS.View
{
    public partial class InvUpdateProfile : Form
    {
        public InvUpdateProfile()
        {
            InitializeComponent();
        }

        private void InvUpdateProfile_Load(object sender, EventArgs e)
        {
            LoadProfileData();
        }

        // ================= LOAD PROFILE =================
        private void LoadProfileData()
        {
            string uname = Session.CurrentUsername;

            try
            {
                using (SqlConnection con = new SqlConnection(DbConfig.ConnectionString))
                {
                    con.Open();

                    string query = "SELECT * FROM UserAccounts WHERE username = @uname";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@uname", uname);

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

        // ================= VALIDATION =================
        private bool ValidateInputs()
        {
            // Full name
            if (string.IsNullOrWhiteSpace(tb_fname.Text))
            {
                MessageBox.Show("Full name is required.");
                tb_fname.Focus();
                return false;
            }

            // Username
            if (string.IsNullOrWhiteSpace(tb_uname.Text))
            {
                MessageBox.Show("Username is required.");
                tb_uname.Focus();
                return false;
            }

            // Password (min 8 chars)
            if (string.IsNullOrWhiteSpace(tb_pass.Text) || tb_pass.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters.");
                tb_pass.Focus();
                return false;
            }

            // Phone (exactly 11 digits)
            if (!Regex.IsMatch(tb_phone.Text.Trim(), @"^\d{11}$"))
            {
                MessageBox.Show("Phone number must be exactly 11 digits.");
                tb_phone.Focus();
                return false;
            }

            // Email
            if (!Regex.IsMatch(tb_email.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email address.");
                tb_email.Focus();
                return false;
            }

            return true;
        }

        // ================= UPDATE PROFILE =================
        private void ProfileUpdate()
        {
            // 🔐 VALIDATE FIRST
            if (!ValidateInputs())
                return;

            string newFullname = tb_fname.Text.Trim();
            string newUsername = tb_uname.Text.Trim();
            string newPassword = tb_pass.Text;
            string newPhone = tb_phone.Text.Trim();
            string newEmail = tb_email.Text.Trim();

            string originalUsername = Session.CurrentUsername;

            try
            {
                using (SqlConnection con = new SqlConnection(DbConfig.ConnectionString))
                {
                    con.Open();

                    string updateQuery = @"
                        UPDATE UserAccounts 
                        SET Fullname = @Fullname,
                            Username = @NewUsername,
                            Password = @Password,
                            PhoneNumber = @PhoneNumber,
                            Email = @Email
                        WHERE Username = @OriginalUsername";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Fullname", newFullname);
                        cmd.Parameters.AddWithValue("@NewUsername", newUsername);
                        cmd.Parameters.AddWithValue("@Password", newPassword);
                        cmd.Parameters.AddWithValue("@PhoneNumber", newPhone);
                        cmd.Parameters.AddWithValue("@Email", newEmail);
                        cmd.Parameters.AddWithValue("@OriginalUsername", originalUsername);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Profile updated successfully!");
                            Session.CurrentUsername = newUsername;
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Username not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ================= BUTTONS =================
        private void btn_confirm_Click_1(object sender, EventArgs e)
        {
            ProfileUpdate();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InvProfile q = new InvProfile();
            q.Show();
            this.Hide();
        }
    }
}
