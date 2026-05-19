using System;
using System.Linq;
using System.Windows.Forms;

namespace ATS_Group3_Project.Views
{
    public partial class frmManageStaff : Form
    {
        private string StaffId;
        private string firstName;
        private string role;

        private ATSContext _context = new ATSContext();

        // Constructor with logged-in user details
        public frmManageStaff(string staffId, string firstName, string role)
        {
            InitializeComponent();

            this.StaffId = staffId;
            this.firstName = firstName;
            this.role = role;
        }

        private void frmManageStaff_Load(object sender, EventArgs e)
        {
            LoadStaff();
        }

        private void LoadStaff()
        {
            var staffList = _context.Staff
                .Select(s => new
                {
                    s.StaffId,
                    s.FirstName,
                    s.LastName,
                    s.WorkMobile,
                    s.HomeMobile,
                    s.Email,
                    s.Address1,
                    s.Address2,
                    s.City,
                    s.Postcode,
                    s.Salary,
                    s.Role
                })
                .ToList();

            dgStaff.DataSource = staffList;

            dgStaff.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgStaff.ReadOnly = true;

            dgStaff.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgStaff.MultiSelect = false;
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            if (dgStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a staff member first.");
                return;
            }

            string selectedStaffId = dgStaff.SelectedRows[0]
                .Cells["StaffId"]
                .Value
                .ToString();

            StaffManager manager = new StaffManager();

            Staff selectedStaff = manager.GetStaffById(selectedStaffId);

            if (selectedStaff == null)
            {
                MessageBox.Show("Staff member could not be found.");
                return;
            }

            frmRegisterNewAccount registerForm =
                new frmRegisterNewAccount(
                    StaffId,
                    firstName,
                    role,
                    selectedStaff
                );

            registerForm.Show();

            this.Close();
        }

        private void btnCreateStaff_Click(object sender, EventArgs e)
        {
            frmRegisterNewAccount registerForm =
                new frmRegisterNewAccount(
                    StaffId,
                    firstName,
                    role
                );

            registerForm.Show();

            this.Close();
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (dgStaff.CurrentRow == null)
            {
                MessageBox.Show("Please select a staff member.");
                return;
            }

            string selectedStaffId = dgStaff.CurrentRow
                .Cells["StaffId"]
                .Value
                .ToString();

            if (string.IsNullOrWhiteSpace(selectedStaffId))
            {
                MessageBox.Show("No staff member selected.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this staff member?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            StaffManager manager = new StaffManager();

            bool success = manager.DeleteStaff(selectedStaffId);

            if (success)
            {
                MessageBox.Show("Staff member deleted successfully.");

                // Reload the grid instead of reopening form
                LoadStaff();
            }
            else
            {
                MessageBox.Show("Staff member could not be deleted.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to return to the Admin Dashboard?",
                "Confirm Navigation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                frmAdminDashboard dashboard =
                    new frmAdminDashboard(
                        StaffId,
                        firstName,
                        role
                    );

                dashboard.Show();

                this.Close();
            }
        }

        private void btnUnlockAccount_Click(object sender, EventArgs e)
        {
          
            // Check if a row is selected
            if (dgStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a staff member first.");
                return;
            }

            // Get selected Staff ID
            string selectedStaffId = dgStaff.SelectedRows[0]
                .Cells["StaffId"]
                .Value
                .ToString();

            UserManager manager = new UserManager();

            // Check if account is locked
            bool isLocked = manager.IsUserLocked(selectedStaffId);

            if (!isLocked)
            {
                MessageBox.Show("This account is not locked.");
                return;
            }

            // Confirm unlock
            DialogResult result = MessageBox.Show(
                "Are you sure you want to unlock this account?",
                "Confirm Unlock",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            // Unlock account
            bool success = manager.UnlockUser(selectedStaffId);

            if (success)
            {
                MessageBox.Show("Account unlocked successfully.");
            }
            else
            {
                MessageBox.Show("Account could not be unlocked.");
            }
        }
    }
}