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
        private string StaffId;
        private string firstName;
        private string role;

        public frmLogin(string StaffId, string firstName, string role)
        {
            InitializeComponent();
            this.StaffId = StaffId;
            this.firstName = firstName;
            this.role = role;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffId.Text.Trim().ToUpper();
            string password = txtPassword.Text.Trim();

            UserManager manager = new UserManager();

            User user = manager.Login(staffId, password);

            if (user == null)
            {
                using (var db = new ATSContext())
                {
                    var existingUser = db.Users
                        .FirstOrDefault(u => u.StaffId == staffId);

                    if (existingUser != null && existingUser.IsLocked)
                    {
                        MessageBox.Show("Your account is locked. Contact administrator.");
                    }
                    else
                    {
                        MessageBox.Show("Invalid login details.");
                    }
                }

                return;
            }

            MessageBox.Show("Login successful. Role: " + user.Staff.Role);

            if (user.Staff.Role == "Engineer")
            {
                new frmEngineerDashboard(
                    user.Staff.StaffId,
                    user.Staff.FirstName,
                    user.Staff.Role
                ).Show();
            }
            else if (user.Staff.Role == "Call Handler")
            {
                new frmCallHandler(
                    user.Staff.StaffId,
                    user.Staff.FirstName,
                    user.Staff.Role
                ).Show();
            }
            else if (user.Staff.Role == "Admin")
            {
                new frmAdminDashboard(
                    user.Staff.StaffId,
                    user.Staff.FirstName,
                    user.Staff.Role
                ).Show();
            }

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
            frmRegisterNewAccount register = new frmRegisterNewAccount(StaffId, firstName, role);
            register.Show();
            this.Close();
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}