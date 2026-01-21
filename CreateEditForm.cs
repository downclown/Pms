using PMS.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PMS.View
{
    public partial class CreateEditForm : Form
    {
        private int userId = 0;

        public CreateEditForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            tb_id.Enabled = false;
        }

        // Populate form for edit
        public void editUsers(User user)
        {
            tb_fname.Text = user.Fullname;
            tb_uname.Text = user.Username;
            tb_pass.Text = user.Password;
            tb_phn.Text = user.PhoneNumber;
            tb_email.Text = user.Email;
            cb_role.SelectedItem = user.Usertype;

            userId = user.Id;
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
            if (!Regex.IsMatch(tb_phn.Text.Trim(), @"^\d{11}$"))
            {
                MessageBox.Show("Phone number must be exactly 11 digits.");
                tb_phn.Focus();
                return false;
            }

            // Email
            if (!Regex.IsMatch(tb_email.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email address.");
                tb_email.Focus();
                return false;
            }

            // Role
            if (cb_role.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.");
                cb_role.Focus();
                return false;
            }

            return true;
        }

        // ================= SAVE =================
        private void btn_save_Click(object sender, EventArgs e)
        {
            // 🔐 Validate first
            if (!ValidateInputs())
                return;

            User user = new User
            {
                Fullname = tb_fname.Text.Trim(),
                Username = tb_uname.Text.Trim(),
                Password = tb_pass.Text,
                PhoneNumber = tb_phn.Text.Trim(),
                Email = tb_email.Text.Trim(),
                Usertype = cb_role.SelectedItem.ToString()
            };

            UserRepo userRepo = new UserRepo();

            if (userId == 0)
            {
                // ADD
                userRepo.AddUser(user);
            }
            else
            {
                // UPDATE
                user.Id = userId;
                userRepo.UpdateUser(user);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // ================= CANCEL =================
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lbl_heading_Click(object sender, EventArgs e)
        {
            lbl_heading.Text = "Create / Edit User";
        }
    }
}
