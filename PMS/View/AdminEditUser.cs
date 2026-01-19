using PMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.View
{
    public partial class AdminEditUser : Form
    {
        private DataTable usersTable;

        public AdminEditUser()
        {
            InitializeComponent();

            // Make column headers bold
            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridView1.Font, FontStyle.Bold);
        }

        private void btn_login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        //public void ReadUsers()
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("ID", typeof(int));
        //    dt.Columns.Add("Fullname");
        //    dt.Columns.Add("Username");
        //    dt.Columns.Add("Password");
        //    dt.Columns.Add("Phone Number");
        //    dt.Columns.Add("Email");
        //    dt.Columns.Add("User Type");

        //    var userRepo = new UserRepo();
        //    var users = userRepo.GetAllUsers();

        //    foreach (var user in users)
        //    {
        //        var row = dt.NewRow();

        //        row["ID"] = user.Id;
        //        row["Fullname"] = user.Fullname;
        //        row["Username"] = user.Username;
        //        row["Password"] = user.Password;
        //        row["Phone Number"] = user.PhoneNumber;
        //        row["Email"] = user.Email;
        //        row["User Type"] = user.Usertype;

        //        dt.Rows.Add(row);
        //    }

        //    dataGridView1.DataSource = dt;

        //}

        public void ReadUsers()
        {
            usersTable = new DataTable();

            usersTable.Columns.Add("ID", typeof(int));
            usersTable.Columns.Add("Fullname");
            usersTable.Columns.Add("Username");
            usersTable.Columns.Add("Password");
            usersTable.Columns.Add("Phone Number");
            usersTable.Columns.Add("Email");
            usersTable.Columns.Add("User Type");

            var userRepo = new UserRepo();
            var users = userRepo.GetAllUsers();

            foreach (var user in users)
            {
                var row = usersTable.NewRow();

                row["ID"] = user.Id;
                row["Fullname"] = user.Fullname;
                row["Username"] = user.Username;
                row["Password"] = user.Password;
                row["Phone Number"] = user.PhoneNumber;
                row["Email"] = user.Email;
                row["User Type"] = user.Usertype;

                usersTable.Rows.Add(row);
            }

            dataGridView1.DataSource = usersTable;
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            CreateEditForm createEditForm = new CreateEditForm();

            if (createEditForm.ShowDialog() == DialogResult.OK)
            {
                ReadUsers();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            int userId = Convert.ToInt32(
                dataGridView1.SelectedRows[0].Cells["ID"].Value
            );

            var repo = new UserRepo();
            var user = repo.GetUserByID(userId);

            if (user == null)
            {
                MessageBox.Show("User not found.");
                return;
            }

            CreateEditForm form = new CreateEditForm();
            form.editUsers(user);

            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadUsers();
            }

        }

        //private void btn_dlt_Click(object sender, EventArgs e)
        //{
        //    var userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
        //    var repo = new UserRepo();
        //    repo.DeleteUser(userId);
        //    ReadUsers();

        //}

        private void btn_dlt_Click(object sender, EventArgs e)
        {
             // Debugging line
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            string selectedUsername = dataGridView1.SelectedRows[0].Cells["Username"].Value.ToString();

            // ✅ Prevent self-deletion
            if (selectedUsername.Equals(Session.CurrentUsername, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("You cannot delete yourself!");
                return;
            }

            int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            var repo = new UserRepo();
            repo.DeleteUser(userId);
            ReadUsers();
        }



        private void AdminEditUser_Load(object sender, EventArgs e)
        {
            ReadUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();

        }



        private void btn_search_Click(object sender, EventArgs e)
        {
            
            if (usersTable == null)
                return;

            string searchText = tb_search.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                dataGridView1.DataSource = usersTable;
                return;
            }

            DataView dv = new DataView(usersTable);

            dv.RowFilter =
                // $"Fullname LIKE '%{searchText}%' OR " +
                $"Username LIKE '%{searchText}%'  ";
               // $"[Phone Number] LIKE '%{searchText}%' OR " +
               // $"Email LIKE '%{searchText}%' OR " +
                //$"[User Type] LIKE '%{searchText}%'";

            dataGridView1.DataSource = dv;
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            btn_search.PerformClick();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Session.CurrentUsername);
        }

        private void dataGridView1_ColumnHeadersDefaultCellStyleChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
            new Font(dataGridView1.Font, FontStyle.Bold);
        }
    }
}
