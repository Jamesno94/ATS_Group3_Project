using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using ATS_Group3_Project.Views;

namespace ATS_Group3_Project
{
    public partial class frmJobDetails : Form
    {
        private int _jobId;
        private string _loggedInStaffId;
        private string _staffRole;


        public frmJobDetails()
        {
            InitializeComponent();
        }

        public frmJobDetails(int jobId, string loggedInStaffId)
        {
            InitializeComponent();

            _jobId = jobId;
            _loggedInStaffId = loggedInStaffId;

            LoadLoggedInUserRole();
        }
        private void LoadLoggedInUserRole()
        {
            using (var db = new ATSContext())
            {
                var staff = db.Staff
                    .FirstOrDefault(s => s.StaffId == _loggedInStaffId);

                if (staff != null)
                {
                    _staffRole = staff.Role;
                }
            }
        }

        private void frmJobDetails_Load(object sender, EventArgs e)
        {
            LoadJobDetails();
            ApplyRolePermissions();
        }

        private void LoadJobDetails()
        {
            using (var db = new ATSContext())
            {
                var job = db.JobRecords
                    .Include(j => j.WindFarm)
                    .Include(j => j.Turbine)
                    .Include(j => j.Staff)
                    .FirstOrDefault(j => j.JobId == _jobId);

                if (job == null)
                {
                    MessageBox.Show("Job could not be found.");
                    Close();
                    return;
                }

                txtJobId.Text = job.JobId.ToString();
                txtJobDate.Text = job.JobDate.ToShortDateString();
                txtJobTime.Text = job.JobTime;
                txtJobType.Text = job.JobType;
                txtJobStatus.Text = job.JobComplete;

                txtWindFarmId.Text = job.WindFarmId;
                txtTurbineId.Text = job.TurbineId;

                txtAssignedEngineerId.Text = job.StaffId;
                txtAssignedEngineerName.Text = job.Staff != null
                    ? job.Staff.FirstName + " " + job.Staff.LastName
                    : "Unknown";

                txtFaultDescription.Text = string.IsNullOrWhiteSpace(job.FaultDescription)
                    ? "N/A"
                    : job.FaultDescription;

                chkMainGeneratorServiced.Checked = job.MainGeneratorServiced;
                chkMainGeneratorReplaced.Checked = job.MainGeneratorReplaced;

                chkGearboxServiced.Checked = job.GearboxServiced;
                chkGearboxReplaced.Checked = job.GearboxReplaced;

                chkYawMotorServiced.Checked = job.YawMotorServiced;
                chkYawMotorReplaced.Checked = job.YawMotorReplaced;

                chkLiftServiced.Checked = job.InternalPassengerLiftServiced;
                chkLiftReplaced.Checked = job.InternalPassengerLiftReplaced;
            }
        }

        private void ApplyRolePermissions()
        {
            bool isEngineer = _staffRole == "Engineer";

            txtJobId.ReadOnly = true;
            txtJobDate.ReadOnly = true;
            txtJobTime.ReadOnly = true;
            txtJobType.ReadOnly = true;
            txtJobStatus.ReadOnly = true;
            txtWindFarmId.ReadOnly = true;
            txtTurbineId.ReadOnly = true;
            txtAssignedEngineerId.ReadOnly = true;
            txtAssignedEngineerName.ReadOnly = true;
            txtFaultDescription.ReadOnly = true;

            chkMainGeneratorServiced.Enabled = isEngineer;
            chkMainGeneratorReplaced.Enabled = isEngineer;

            chkGearboxServiced.Enabled = isEngineer;
            chkGearboxReplaced.Enabled = isEngineer;

            chkYawMotorServiced.Enabled = isEngineer;
            chkYawMotorReplaced.Enabled = isEngineer;

            chkLiftServiced.Enabled = isEngineer;
            chkLiftReplaced.Enabled = isEngineer;

            btnUpdateJob.Enabled = isEngineer;
            btnUpdateJob.Visible = isEngineer;
        }

        private bool ValidateComponentSelections()
        {
            if (chkMainGeneratorServiced.Checked == chkMainGeneratorReplaced.Checked)
            {
                MessageBox.Show("Main Generator must be either serviced OR replaced.");
                return false;
            }

            if (chkGearboxServiced.Checked == chkGearboxReplaced.Checked)
            {
                MessageBox.Show("Gearbox must be either serviced OR replaced.");
                return false;
            }

            if (chkYawMotorServiced.Checked == chkYawMotorReplaced.Checked)
            {
                MessageBox.Show("Yaw Motor must be either serviced OR replaced.");
                return false;
            }

            if (chkLiftServiced.Checked == chkLiftReplaced.Checked)
            {
                MessageBox.Show("Internal Passenger Lift must be either serviced OR replaced.");
                return false;
            }

            return true;
        }

        private void btnUpdateJob_Click(object sender, EventArgs e)
        {
            if (_staffRole != "Engineer")
            {
                MessageBox.Show("Only engineers can complete jobs.");
                return;
            }

            if (!ValidateComponentSelections())
            {
                return;
            }

            JobRecordManager manager = new JobRecordManager();

            bool success = manager.MarkJobComplete(
                _jobId,
                chkMainGeneratorServiced.Checked,
                chkGearboxServiced.Checked,
                chkYawMotorServiced.Checked,
                chkLiftServiced.Checked,
                chkMainGeneratorReplaced.Checked,
                chkGearboxReplaced.Checked,
                chkYawMotorReplaced.Checked,
                chkLiftReplaced.Checked
            );

            if (success)
            {
                DialogResult result = MessageBox.Show(
                    "Job marked as complete.",
                    "Job Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (result == DialogResult.OK)
                {
                    using (var db = new ATSContext())
                    {
                        var staff = db.Staff
                            .FirstOrDefault(s => s.StaffId == _loggedInStaffId);

                        if (staff != null)
                        {
                            frmEngineerDashboard engineerDashboard =
                                new frmEngineerDashboard(
                                    staff.StaffId,
                                    staff.FirstName,
                                    staff.Role
                                );

                            engineerDashboard.Show();
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Job could not be updated.");
            }
        }

        private void chkMainGeneratorServiced_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMainGeneratorServiced.Checked)
                chkMainGeneratorReplaced.Checked = false;
        }

        private void chkMainGeneratorReplaced_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMainGeneratorReplaced.Checked)
                chkMainGeneratorServiced.Checked = false;
        }

        private void chkGearboxServiced_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGearboxServiced.Checked)
                chkGearboxReplaced.Checked = false;
        }

        private void chkGearboxReplaced_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGearboxReplaced.Checked)
                chkGearboxServiced.Checked = false;
        }

        private void chkYawMotorServiced_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYawMotorServiced.Checked)
                chkYawMotorReplaced.Checked = false;
        }

        private void chkYawMotorReplaced_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYawMotorReplaced.Checked)
                chkYawMotorServiced.Checked = false;
        }

        private void chkLiftServiced_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLiftServiced.Checked)
                chkLiftReplaced.Checked = false;
        }

        private void chkLiftReplaced_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLiftReplaced.Checked)
                chkLiftServiced.Checked = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            using (var db = new ATSContext())
            {
                var staff = db.Staff
                    .FirstOrDefault(s => s.StaffId == _loggedInStaffId);

                if (staff == null)
                {
                    MessageBox.Show("User could not be found.");
                    return;
                }

                if (staff.Role == "Engineer")
                {
                    frmEngineerDashboard engineerDashboard =
                        new frmEngineerDashboard(
                            staff.StaffId,
                            staff.FirstName,
                            staff.Role
                        );

                    engineerDashboard.Show();
                }
                else if (staff.Role == "Call Handler")
                {
                    frmCallHandler callHandlerDashboard =
                        new frmCallHandler(
                            staff.StaffId,
                            staff.FirstName,
                            staff.Role
                        );

                    callHandlerDashboard.Show();
                }
                else if (staff.Role == "Admin")
                {
                    frmAdminDashboard adminDashboard =
                        new frmAdminDashboard(
                            staff.StaffId,
                            staff.FirstName,
                            staff.Role
                        );

                    adminDashboard.Show();
                }

                this.Close();
            }
        }
    }
}