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
            UserManager manager = new UserManager();

            var user = manager.Login(txtStaffId.Text, txtPassword.Text);

            if (user == null)
            {
                MessageBox.Show("Invalid login.");
                return;
            }

            if (user.Staff.Role == "Engineer")
            {
                new EngineerDashboardForm(user.StaffId).Show();
            }
            else
            {
                new CallHandlerDashboardForm().Show();
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
