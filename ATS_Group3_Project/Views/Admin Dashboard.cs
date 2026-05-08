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
        public string FirstName { get; set; }
        public string Role { get; set; }

        private string StaffId;
        public frmAdminDashboard(string StaffId, string firstName, string role)
        {
            InitializeComponent();

            this.StaffId = StaffId;

            lblGreetings.Text = $"Greetings, {firstName}";
            lblRole.Text = $"Role: {role}";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
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
    }
}
