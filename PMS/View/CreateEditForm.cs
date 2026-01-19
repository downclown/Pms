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
    public partial class CreateEditForm : Form
    {
        public CreateEditForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            tb_id.Enabled = false;
        }

        private int userId = 0;

        public void editUsers(User user)
        {
            this.tb_fname.Text = user.Fullname;
            this.tb_uname.Text = user.Username;
            this.tb_pass.Text = user.Password;
            this.tb_phn.Text = user.PhoneNumber;
            this.tb_email.Text = user.Email;
            this.cb_role.SelectedItem = user.Usertype;

            this.userId = user.Id;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Fullname = tb_fname.Text;
            user.Username = tb_uname.Text;
            user.Password = tb_pass.Text;
            user.PhoneNumber = tb_phn.Text;
            user.Email = tb_email.Text;
            user.Usertype = cb_role.SelectedItem.ToString();

            UserRepo userRepo = new UserRepo();

            if(userId == 0)
            {
                userRepo.AddUser(user);
                tb_id.Enabled = false;
            }
            else
            {
                user.Id = this.userId;
                
                userRepo.UpdateUser(user);
                tb_id.Enabled = true;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void lbl_heading_Click(object sender, EventArgs e)
        {
            lbl_heading.Text = "Create / Edit User";
        }
    }
}
