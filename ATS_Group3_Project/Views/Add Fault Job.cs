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
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to leave this page?",
            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmTurbineHistory secondForm = new frmTurbineHistory(StaffId, firstName, role);
                secondForm.Show();
                this.Hide();
            }
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
            //var jobType = "Fault";
            //var faultDescription = txtFaultDescription.Text?.Trim();

            //if (string.IsNullOrEmpty(faultDescription))
            //{
            //    MessageBox.Show("Please enter a fault description.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //if (cboWindFarmId.SelectedItem == null || cboTurbineId.SelectedItem == null)
            //{
            //    MessageBox.Show("Please select a wind farm and a turbine.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //var turbineId = cboTurbineId.SelectedItem.ToString();
            //var windFarmId = cboWindFarmId.SelectedItem.ToString();
            //var faultDateTime = DateTime.Now;
            //var jobTime = faultDateTime.Hour < 12 ? "Early" : "Late";

            //try
            //{
            //    var createJob = new DispatchManager();
            //    createJob.CreateFaultJob(new JobRecord
            //    {
            //        JobType = jobType,
            //        FaultDescription = faultDescription,
            //        TurbineId = turbineId,
            //        WindFarmId = windFarmId,
            //        JobDate = faultDateTime,
            //        JobTime = jobTime,
            //        StaffId = StaffId,

            //        MainGeneratorServiced = false,
            //        GearboxServiced = false,
            //        YawMotorServiced = false,
            //        InternalPassengerLiftServiced = false,
            //        MainGeneratorReplaced = false,
            //        GearboxReplaced = false,
            //        YawMotorReplaced = false,
            //        InternalPassengerLiftReplaced = false,
            //        JobComplete = "Awaiting Engineer"
            //    });

            //    MessageBox.Show("Fault job created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    // Optionally clear/reset form or navigate away
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error creating job: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

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

                JobRecord job = new JobRecord
                {
                    JobType = "Fault",
                    FaultDescription = faultDescription,
                    TurbineId = turbineId,
                    WindFarmId = windFarmId,
                    JobDate = faultDateTime,
                    JobTime = faultDateTime.Hour < 12 ? "Early" : "Late",
                    StaffId = StaffId,

                    MainGeneratorServiced = false,
                    GearboxServiced = false,
                    YawMotorServiced = false,
                    InternalPassengerLiftServiced = false,

                    MainGeneratorReplaced = false,
                    GearboxReplaced = false,
                    YawMotorReplaced = false,
                    InternalPassengerLiftReplaced = false,

                    JobComplete = "Awaiting Engineer"
                };

                //DispatchManager manager = new DispatchManager();

                //bool success = manager.CreateFaultJob(
                //    turbineId,
                //    faultDescription,
                //    faultDateTime
                //);

                MessageBox.Show(
                    "Fault job created successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtFaultDescription.Clear();
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

    }
}
