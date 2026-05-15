using ATS_Group3_Project.Views;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ATS_Group3_Project
{
    public partial class frmViewAssignedJobs : Form
    {
        private string StaffId;
        private string firstName;
        private string role;

        public frmViewAssignedJobs(string staffId, string firstName, string role)
        {
            InitializeComponent();

            this.StaffId = staffId;
            this.firstName = firstName;
            this.role = role;
        }
        private void frmViewAssignedJobs_Load(object sender, EventArgs e)
        {
            LoadJobs();
        }
        private void LoadJobs()
        {
            using (var db = new ATSContext())
            {
                var jobs = db.JobRecords
                    .Where(j => j.StaffId == StaffId)
                    .Select(j => new
                    {
                        StaffId = j.StaffId,
                        j.JobId,
                        j.WindFarmId,
                        j.TurbineId,
                        j.JobType,
                        j.JobDate,
                        j.JobTime,
                        Status = j.JobComplete
                    })
                    .ToList();

                DataGVJobs.DataSource = jobs;
            }

            DataGVJobs.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            DataGVJobs.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            DataGVJobs.ReadOnly = true;

            DataGVJobs.MultiSelect = false;
        }

        private void btnOpenJobDetails_Click(object sender, EventArgs e)
        {
            if (DataGVJobs.CurrentRow == null)
            {
                MessageBox.Show("Please select a job first.");
                return;
            }

            string jobId = DataGVJobs.CurrentRow.Cells["JobId"].Value.ToString();

            frmJobDetails jobDetailsForm =
                new frmJobDetails(jobId, StaffId);

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
                frmEngineerDashboard dash =
                    new frmEngineerDashboard(StaffId, firstName, role);

                dash.Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmEngineerDashboard dash =
                new frmEngineerDashboard(StaffId, firstName, role);

            dash.Show();
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}