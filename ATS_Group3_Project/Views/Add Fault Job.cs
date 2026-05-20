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
    public partial class frmAddFaultJob : Form
    {
        private string StaffId;
        private string firstName;
        private string role;
        private string turbineId;
        private string windFarmId;

        public frmAddFaultJob(string staffId, string firstName, string role, string turbineId, string windFarmId)
        {
            InitializeComponent();

            this.StaffId = staffId;
            this.firstName = firstName;
            this.role = role;
            this.turbineId = turbineId;
            this.windFarmId = windFarmId;

            txtTurbineId.Text = turbineId;
            txtWindFarmId.Text = windFarmId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
         
        }

        private void DashboardLogoClick_Click(object sender, EventArgs e)
        {

            // 1. Ask for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to go to the Dashboard?",
                "Confirm Navigation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. Create the Dashboard form instance
                frmCallHandler dash = new frmCallHandler(StaffId, firstName, role);

                // 3. Show the dashboard
                dash.Show();

                // 4. Hide Add Fault Job Form
                this.Hide();

            }
        }

        private void btnCreateJob_Click(object sender, EventArgs e)
        {
            bool componentSelected =
                chkMainGenerator.Checked ||
                chkGearbox.Checked ||
                chkYawMotor.Checked ||
                chkLift.Checked;

            if (!componentSelected)
            {
                MessageBox.Show(
                    "Please select at least one faulty component.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string faultDescription = txtFaultDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(faultDescription))
            {
                MessageBox.Show(
                    "Please enter a fault description.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            txtTurbineId.Text = turbineId;
            txtWindFarmId.Text = windFarmId;

            try
            {
                DateTime faultDateTime = DateTime.Now;

                DispatchManager manager = new DispatchManager();

                JobRecord createdJob = manager.CreateFaultJob(
                    turbineId,
                    faultDescription,
                    faultDateTime,
                    chkMainGenerator.Checked,
                    chkGearbox.Checked,
                    chkYawMotor.Checked,
                    chkLift.Checked
                );

                if (createdJob == null)
                {
                    MessageBox.Show(
                        "Unable to assign engineer.",
                        "Dispatch Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                MessageBox.Show(
                    "Fault job created successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtFaultDescription.Clear();

                frmTurbSimData frmTurbSimData = new frmTurbSimData(StaffId, firstName, role);
                frmTurbSimData.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error creating job: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmTurbSimData frmTurbSimData = new frmTurbSimData(StaffId, firstName, role);
            frmTurbSimData.Show();
            this.Close();
        }

        
    }
}
