using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATS_Group3_Project.Views
{
    public partial class frmEngineerDashboard : Form
    {
        public string FirstName { get; set; }
        public string Role { get; set; }

        private string StaffId;
        public frmEngineerDashboard(string StaffId, string firstName, string role)
        {
            InitializeComponent();
            this.StaffId = StaffId;
            this.FirstName = firstName;
            this.Role = role;

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
                frmLogin loginForm = new frmLogin(StaffId, FirstName, Role);
                loginForm.Show();

                this.Hide();
            }
        }

        private void btnViewAssignedJobs_Click(object sender, EventArgs e)
        {
            frmViewAssignedJobs viewAssignedJobsForm = new frmViewAssignedJobs(StaffId);
            viewAssignedJobsForm.Show(this);
            this.Hide();
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            Manage_Account frm = new Manage_Account(StaffId);
            frm.Show();
            this.Hide();

        }
    }
}