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
            UserManager manager = new UserManager();

            var user = manager.Login(txtStaffId.Text, txtPassword.Text);

            if (user == null)
            {
                MessageBox.Show("Invalid login.");
                return;
            }

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
            else if (user.Staff.Role == "Admin")
            {
                //AdminDashboardForm form = new AdminDashboardForm(user.StaffId);
                //form.Show();
                //this.Hide();
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
