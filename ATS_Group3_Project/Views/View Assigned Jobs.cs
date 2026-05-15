using System;
using System.Windows.Forms;
using ATS_Group3_Project.Views;

namespace ATS_Group3_Project
{
    public partial class frmViewAssignedJobs : Form
    {
        private string StaffId;

        public frmViewAssignedJobs()
        {
            InitializeComponent();
        }

        public frmViewAssignedJobs(string staffId)
        {
            InitializeComponent();

            StaffId = staffId;
        }

        private void btnOpenJobDetails_Click(object sender, EventArgs e)
        {
            if (DataGVJobs.CurrentRow == null)
            {
                MessageBox.Show("Please select a job first.");
                return;
            }

            frmJobDetails jobDetailsForm = new frmJobDetails(StaffId);
            jobDetailsForm.Show();

            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to go to the Dashboard?",
                "Confirm Navigation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                frmDashboard dash = new frmDashboard();
                dash.Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }

            this.Close();
        }
    }
}