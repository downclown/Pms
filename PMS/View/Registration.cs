using PMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.View
{
    public partial class Registration : Form
    {
        //string s = @"Data Source=DESKTOP-L4K97ST\SQLEXPRESS;Initial Catalog=PharmacyDb;Integrated Security=True";
        string s = DbConfig.ConnectionString;

        public Registration()
        {
            InitializeComponent();
        }

        private void btn_login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cb_reg_showbox_CheckedChanged(object sender, EventArgs e)
        {
            tb_reg_pass.PasswordChar = cb_reg_showbox.Checked ? '\0' : '*';
            tb_reg_conpass.PasswordChar = cb_reg_showbox.Checked ? '\0' : '*';
        }

        

        private void btn_reg_Click(object sender, EventArgs e)
        {
            bool isValidEmail = Regex.IsMatch(tb_reg_email.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            

            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();
                
                string checkUser = @"SELECT username, email FROM UserAccounts WHERE username = @usern OR email = @email";




                using (SqlCommand cmd = new SqlCommand(checkUser, con))
                {
                    cmd.Parameters.AddWithValue("@usern", tb_reg_uname.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", tb_reg_email.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            if (row["username"].ToString() == tb_reg_uname.Text.Trim())
                            {
                                MessageBox.Show("Username already exists! Please choose a different username.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if (row["email"].ToString() == tb_reg_email.Text.Trim())
                            {
                                MessageBox.Show("Email already exists! Please use a different email.","Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    if (string.IsNullOrWhiteSpace(tb_reg_fname.Text) || string.IsNullOrWhiteSpace(tb_reg_uname.Text) || string.IsNullOrWhiteSpace(tb_reg_pass.Text) || string.IsNullOrWhiteSpace(tb_reg_conpass.Text) || string.IsNullOrWhiteSpace(tb_reg_email.Text) || string.IsNullOrWhiteSpace(tb_reg_phn.Text) || comboBox1.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK,MessageBoxIcon.Warning);

                        return;
                    }

                    if (!isValidEmail)
                    {
                        MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK,  MessageBoxIcon.Warning);
                        return;
                    }
                    if (!tb_reg_phn.Text.All(char.IsDigit) || tb_reg_phn.Text.Length < 10)
                    {
                        MessageBox.Show("Please enter a valid phone number.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    if (tb_reg_pass.Text.Trim().Length < 8)
                    {
                        MessageBox.Show("Password must be at least 8 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (tb_reg_pass.Text.Trim() != tb_reg_conpass.Text.Trim())
                    {
                        MessageBox.Show("Passwords do not match. Please re-enter.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO UserAccounts (fullname, username, password, phonenumber, email, usertype) VALUES (@fullname, @username, @password, @phonenumber, @email, @usertype)";
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                        {
                            insertCmd.Parameters.AddWithValue("@fullname", tb_reg_fname.Text.Trim());
                            insertCmd.Parameters.AddWithValue("@username", tb_reg_uname.Text.Trim());
                            insertCmd.Parameters.AddWithValue("@password", tb_reg_pass.Text.Trim());
                            insertCmd.Parameters.AddWithValue("@phonenumber", tb_reg_phn.Text.Trim());
                            insertCmd.Parameters.AddWithValue("@email", tb_reg_email.Text.Trim());
                            insertCmd.Parameters.AddWithValue("@usertype", comboBox1.SelectedItem.ToString());
                            int rowsAffected = insertCmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                Login loginForm = new Login();
                                loginForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    

                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
