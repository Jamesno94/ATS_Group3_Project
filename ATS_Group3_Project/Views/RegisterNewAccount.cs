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
    public partial class frmRegisterNewAccount : Form
    {
        public frmRegisterNewAccount()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // 1. Ask for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to go to the Dashboard?",
                "Confirm Navigation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. Create the Dashboard form instance
                frmDashboard dash = new frmDashboard();

                // 3. Show the dashboard
                dash.Show();

                // 4. Hide Register New Account Form
                this.Hide();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
   private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStaffId.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtWorkMobile.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtAddress1.Text) ||
                string.IsNullOrWhiteSpace(txtCity.Text) ||
                string.IsNullOrWhiteSpace(txtPostcode.Text) ||
                string.IsNullOrWhiteSpace(txtSalary.Text) ||
                string.IsNullOrWhiteSpace(cboRole.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please complete all required fields.");
                return;
            }

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

            if (cboRole.Text != "Engineer" &&
                cboRole.Text != "Call Handler" &&
                cboRole.Text != "Admin")
            {
                MessageBox.Show("Please select a valid role.");
                return;
            }

            if (txtPassword.Text.Length < 8 ||
                !txtPassword.Text.Any(char.IsUpper) ||
                !txtPassword.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Password must be at least 8 characters long and contain at least 1 uppercase letter and 1 number.");
                return;
            }

            StaffManager manager = new StaffManager();

            bool success = manager.RegisterStaffAccount(
                txtStaffId.Text.Trim(),
                txtFirstName.Text.Trim(),
                txtLastName.Text.Trim(),
                txtWorkMobile.Text.Trim(),
                txtHomeMobile.Text.Trim(),
                txtEmail.Text.Trim(),
                txtAddress1.Text.Trim(),
                txtAddress2.Text.Trim(),
                txtCity.Text.Trim(),
                txtPostcode.Text.Trim(),
                salary,
                cboRole.Text.Trim(),
                txtPassword.Text
            );

            
            if (success)
            {
                MessageBox.Show("Staff account created successfully.");

                // Optionally, clear the form fields after successful registration
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
                cboRole.SelectedIndex = -1;
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Account could not be created. Check all details and make sure the Staff ID and Email are unique.");
            }
        }
    }
}