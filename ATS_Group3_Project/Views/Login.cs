using ATS_Group3_Project.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATS_Group3_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffId.Text.Trim();
            string password = txtPassword.Text;

            UserManager manager = new UserManager();

            User user = manager.Login(staffId, password);

            MessageBox.Show("Users in DB: " + manager.CountUsers());

            if (user == null)
            {
                MessageBox.Show("Invalid login.");
                return;
            }

            MessageBox.Show("Login successful. Role: " + user.Staff.Role);

            Form dashboard = null;

            if (user.Staff.Role == "Engineer")
            {
                dashboard = new frmEngineerDashboard(
                    user.Staff.StaffId,
                    user.Staff.FirstName,
                    user.Staff.Role);
            }
            else if (user.Staff.Role == "Call Handler")
            {
                dashboard = new frmCallHandler(
                    user.Staff.StaffId,
                    user.Staff.FirstName,
                    user.Staff.Role);
            }
            else if (user.Staff.Role == "Admin")
            {
                dashboard = new frmAdminDashboard(
                    user.Staff.StaffId,
                    user.Staff.FirstName,
                    user.Staff.Role);
            }
            else
            {
                MessageBox.Show("Unknown role.");
                return;
            }

            dashboard.Show();

            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            frmRegisterNewAccount register = new frmRegisterNewAccount();
            register.Show();
            this.Close();
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}