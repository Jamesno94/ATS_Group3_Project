using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using ATS_Group3_Project.Views;

namespace ATS_Group3_Project
{
    public partial class frmJobDetails : Form
    {
        private string _jobId;
        private string _loggedInStaffId;
        private string _staffRole;

        // Fault flags (source of truth)
        private bool _mainGeneratorFault;
        private bool _gearboxFault;
        private bool _yawMotorFault;
        private bool _liftFault;

        public frmJobDetails()
        {
            InitializeComponent();
        }

        public frmJobDetails(string jobId, string loggedInStaffId)
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

                txtJobId.Text = job.JobId;
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

                // Store fault flags (IMPORTANT)
                _mainGeneratorFault = job.MainGeneratorFault;
                _gearboxFault = job.GearboxFault;
                _yawMotorFault = job.YawMotorFault;
                _liftFault = job.InternalPassengerLiftFault;

                // Load checkbox states
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

            // Lock text fields
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

            // Fault-based access control
            chkMainGeneratorServiced.Enabled = isEngineer && _mainGeneratorFault;
            chkMainGeneratorReplaced.Enabled = isEngineer && _mainGeneratorFault;

            chkGearboxServiced.Enabled = isEngineer && _gearboxFault;
            chkGearboxReplaced.Enabled = isEngineer && _gearboxFault;

            chkYawMotorServiced.Enabled = isEngineer && _yawMotorFault;
            chkYawMotorReplaced.Enabled = isEngineer && _yawMotorFault;

            chkLiftServiced.Enabled = isEngineer && _liftFault;
            chkLiftReplaced.Enabled = isEngineer && _liftFault;

            btnUpdateJob.Enabled = isEngineer;
            btnUpdateJob.Visible = isEngineer;
        }

        private bool ValidateComponentSelections()
        {
            if (_mainGeneratorFault)
            {
                if (chkMainGeneratorServiced.Checked == chkMainGeneratorReplaced.Checked)
                    return ShowError("Main Generator must be serviced OR replaced.");
            }

            if (_gearboxFault)
            {
                if (chkGearboxServiced.Checked == chkGearboxReplaced.Checked)
                    return ShowError("Gearbox must be serviced OR replaced.");
            }

            if (_yawMotorFault)
            {
                if (chkYawMotorServiced.Checked == chkYawMotorReplaced.Checked)
                    return ShowError("Yaw Motor must be serviced OR replaced.");
            }

            if (_liftFault)
            {
                if (chkLiftServiced.Checked == chkLiftReplaced.Checked)
                    return ShowError("Internal Passenger Lift must be serviced OR replaced.");
            }

            return true;
        }

        private bool ShowError(string message)
        {
            MessageBox.Show(message, "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void btnUpdateJob_Click(object sender, EventArgs e)
        {
            if (_staffRole != "Engineer")
            {
                MessageBox.Show("Only engineers can complete jobs.");
                return;
            }

            if (!ValidateComponentSelections())
                return;

            JobRecordManager manager = new JobRecordManager();

            bool success = manager.MarkJobComplete(
                _jobId,

                _mainGeneratorFault ? chkMainGeneratorServiced.Checked : false,
                _gearboxFault ? chkGearboxServiced.Checked : false,
                _yawMotorFault ? chkYawMotorServiced.Checked : false,
                _liftFault ? chkLiftServiced.Checked : false,

                _mainGeneratorFault ? chkMainGeneratorReplaced.Checked : false,
                _gearboxFault ? chkGearboxReplaced.Checked : false,
                _yawMotorFault ? chkYawMotorReplaced.Checked : false,
                _liftFault ? chkLiftReplaced.Checked : false
            );

            if (success)
            {
                MessageBox.Show("Job marked as complete.");

                using (var db = new ATSContext())
                {
                    var staff = db.Staff
                        .FirstOrDefault(s => s.StaffId == _loggedInStaffId);

                    if (staff != null)
                    {
                        new frmEngineerDashboard(
                            staff.StaffId,
                            staff.FirstName,
                            staff.Role
                        ).Show();

                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Job could not be updated.");
            }
        }

        // Checkbox exclusivity rules
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
                var staff = db.Staff.FirstOrDefault(s => s.StaffId == _loggedInStaffId);

                Form dashboard;

                if (staff.Role == "Engineer")
                    dashboard = new frmEngineerDashboard(staff.StaffId, staff.FirstName, staff.Role);
                else if (staff.Role == "Call Handler")
                    dashboard = new frmCallHandler(staff.StaffId, staff.FirstName, staff.Role);
                else
                    dashboard = new frmAdminDashboard(staff.StaffId, staff.FirstName, staff.Role);

                dashboard.Show();
                this.Close();
            }
        }
    }
}