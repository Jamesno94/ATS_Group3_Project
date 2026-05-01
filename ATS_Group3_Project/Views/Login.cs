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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffId.Text.Trim();
            string password = txtPassword.Text;

            UserManager userManager = new UserManager();

            User user = userManager.Login(staffId, password);

            if (user == null)
            {
                MessageBox.Show("Invalid Staff ID or Password.");
                return;
            }

            MessageBox.Show("Login successful!");

            // Navigate based on role
            if (user.Staff.Role == "Engineer")
            {
                //EngineerDashboardForm form = new EngineerDashboardForm(user.StaffId);
                //form.Show();
                //this.Hide();
            }
            else if (user.Staff.Role == "Call Handler")
            {
                //CallHandlerDashboardForm form = new CallHandlerDashboardForm(user.StaffId);
                //form.Show();
                //this.Hide();
            }

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
