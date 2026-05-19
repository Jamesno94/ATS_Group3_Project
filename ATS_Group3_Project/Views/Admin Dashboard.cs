using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATS_Group3_Project.Views
{
    public partial class frmAdminDashboard : Form
    {
        private string firstName;

        private string role;

        private string StaffId;
        public frmAdminDashboard(string StaffId, string firstName, string role)
        {
            InitializeComponent();

            this.StaffId = StaffId;
            this.firstName = firstName;
            this.role = role;

            lblGreetings.Text = $"Greetings, {firstName}";
            lblRole.Text = $"Role: {role}";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCreateNewStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Do you wish to log out?",
            "Logout Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                frmLogin loginForm = new frmLogin();
                loginForm.Show();

                this.Hide();
            }
        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {

        }
    }
}
