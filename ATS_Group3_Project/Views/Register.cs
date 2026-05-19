using ATS_Group3_Project.Views;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ATS_Group3_Project
{
 
    public partial class frmRegisterNewAccount : Form
    {
        private string StaffId;
        private string firstName;
        private string role;

        private string editingStaffId = null;

        // REQUIRED for WinForms Designer
        public frmRegisterNewAccount()
        {
            InitializeComponent();
        }

        // Constructor for NEW staff
        public frmRegisterNewAccount(string StaffId, string firstName, string role)
        {
            InitializeComponent();

            this.StaffId = StaffId;
            this.firstName = firstName;
            this.role = role;
        }

        // Constructor for EDITING existing staff
        public frmRegisterNewAccount(string StaffId,
                                     string firstName,
                                     string role,
                                     Staff staffToEdit)
        {
            InitializeComponent();

            this.StaffId = StaffId;
            this.firstName = firstName;
            this.role = role;

            editingStaffId = staffToEdit.StaffId;

            // Populate fields with existing staff data
            txtStaffId.Text = staffToEdit.StaffId;
            txtFirstName.Text = staffToEdit.FirstName;
            txtLastName.Text = staffToEdit.LastName;
            txtWorkNumber.Text = staffToEdit.WorkMobile;
            txtHomeNumber.Text = staffToEdit.HomeMobile;
            txtWorkEmail.Text = staffToEdit.Email;
            txtAddressLine1.Text = staffToEdit.Address1;
            txtAddressLine2.Text = staffToEdit.Address2;
            txtCity.Text = staffToEdit.City;
            txtPostcode.Text = staffToEdit.Postcode;
            txtSalary.Text = staffToEdit.Salary.ToString();
            cboRole.Text = staffToEdit.Role;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to go to the Dashboard?",
                "Confirm Navigation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmAdminDashboard dash =
                    new frmAdminDashboard(StaffId, firstName, role);

                dash.Show();
                this.Hide();
            }
        }

        private void btnRegisterNewAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Check for blank fields
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtWorkNumber.Text) ||
                string.IsNullOrWhiteSpace(txtWorkEmail.Text) ||
                string.IsNullOrWhiteSpace(txtAddressLine1.Text) ||
                string.IsNullOrWhiteSpace(txtCity.Text) ||
                string.IsNullOrWhiteSpace(txtPostcode.Text) ||
                string.IsNullOrWhiteSpace(txtSalary.Text) ||
                string.IsNullOrWhiteSpace(cboRole.Text))
            {
                MessageBox.Show("Please complete all required fields.");
                return;
            }

            // Validate salary
            decimal salary;

            if (!decimal.TryParse(txtSalary.Text, out salary))
            {
                MessageBox.Show("Please enter a valid salary.");
                return;
            }

            if (salary <= 0)
            {
                MessageBox.Show("Salary must be greater than 0.");
                return;
            }

            // Validate role
            if (cboRole.Text != "Engineer" &&
                cboRole.Text != "Call Handler" &&
                cboRole.Text != "Admin")
            {
                MessageBox.Show("Please select a valid role.");
                return;
            }

            string staffId;

            StaffManager manager = new StaffManager();

            // =========================
            // EDIT MODE
            // =========================
            if (editingStaffId != null)
            {
                staffId = editingStaffId;

                Staff updatedStaff = new Staff
                {
                    StaffId = staffId,
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    WorkMobile = txtWorkNumber.Text.Trim(),
                    HomeMobile = txtHomeNumber.Text.Trim(),
                    Email = txtWorkEmail.Text.Trim(),
                    Address1 = txtAddressLine1.Text.Trim(),
                    Address2 = txtAddressLine2.Text.Trim(),
                    City = txtCity.Text.Trim(),
                    Postcode = txtPostcode.Text.Trim(),
                    Salary = salary,
                    Role = cboRole.Text.Trim()
                };

                bool success = manager.UpdateStaff(updatedStaff);

                if (success)
                {
                    MessageBox.Show("Staff member updated successfully.");

                    frmAdminDashboard dash =
                        new frmAdminDashboard(StaffId, firstName, role);

                    dash.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Failed to update staff member.\n" +
                        "The email may already exist.");
                }

                return;
            }

            // =========================
            // CREATE NEW STAFF
            // =========================

            // Generate new Staff ID
            if (cboRole.Text == "Engineer")
            {
                staffId = manager.GenerateID("Engineer");
            }
            else if (cboRole.Text == "Call Handler")
            {
                staffId = manager.GenerateID("Call Handler");
            }
            else
            {
                staffId = manager.GenerateID("Admin");
            }

            txtStaffId.Text = staffId;

            // Default password
            txtPassword.Text = "Password1";

            // Validate password complexity
            if (txtPassword.Text.Length < 8 ||
                !txtPassword.Text.Any(char.IsUpper) ||
                !txtPassword.Text.Any(char.IsDigit))
            {
                MessageBox.Show(
                    "Password must be at least 8 characters long " +
                    "and contain at least 1 uppercase letter and 1 number.");

                return;
            }

            bool createSuccess = manager.RegisterStaffAccount(
                staffId,
                txtFirstName.Text.Trim(),
                txtLastName.Text.Trim(),
                txtWorkNumber.Text.Trim(),
                txtHomeNumber.Text.Trim(),
                txtWorkEmail.Text.Trim(),
                txtAddressLine1.Text.Trim(),
                txtAddressLine2.Text.Trim(),
                txtCity.Text.Trim(),
                txtPostcode.Text.Trim(),
                salary,
                cboRole.Text.Trim(),
                txtPassword.Text
            );

            if (createSuccess)
            {
                MessageBox.Show("Staff account created successfully.");

                // Clear form
                txtStaffId.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtWorkNumber.Clear();
                txtHomeNumber.Clear();
                txtWorkEmail.Clear();
                txtAddressLine1.Clear();
                txtAddressLine2.Clear();
                txtCity.Clear();
                txtPostcode.Clear();
                txtSalary.Clear();
                txtPassword.Clear();

                cboRole.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(
                    "Account could not be created.\n" +
                    "Staff ID or Email may already exist.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to go to the Dashboard?",
                "Confirm Navigation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmAdminDashboard dash =
                    new frmAdminDashboard(StaffId, firstName, role);

                dash.Show();
                this.Hide();
            }
        }
    }
}