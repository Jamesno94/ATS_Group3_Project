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

            if (user.Staff.Role == "Engineer")
            {
                // new EngineerDashboardForm(user.StaffId).Show();
            }
            else if (user.Staff.Role == "Call Handler")
            {
                // new CallHandlerDashboardForm(user.StaffId).Show();
            }
            else if (user.Staff.Role == "Admin")
            {
                // new AdminDashboardForm(user.StaffId).Show();
            }

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Register register = new Register();
            //register.ShowDialog();
            //this.Close();
        }
    }
}