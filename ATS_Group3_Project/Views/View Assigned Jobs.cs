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
    public partial class frmViewAssignedJobs : Form
    {
        private string StaffId;
        private string firstName;
        private string role;

        public frmViewAssignedJobs(string StaffId, string firstName, string role)
        {
            InitializeComponent();
            this.StaffId = StaffId;
            this.firstName = firstName;
            this.role = role;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // 1. Ask for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to go to the Dashboard?",
                "Confirm Navigation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. Create the Dashboard form instance
                frmEngineerDashboard dash = new frmEngineerDashboard(StaffId, firstName, role);

                // 3. Show the dashboard
                dash.Show();

                // 4. Hide View Assigned Jobs Form
                this.Hide();
            }
        }
    }
}
