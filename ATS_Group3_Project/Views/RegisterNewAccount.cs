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
            StaffManager manager = new StaffManager();

            bool success = manager.RegisterStaffAccount(
                txtStaffId.Text, 
                txtFirstName.Text,
                txtLastName.Text,
                txtWorkNumber.Text,
                txtHomeNumber.Text,
                txtWorkEmail.Text,
                txtAddressLine1.Text,
                txtAddressLine2.Text,
                txtCity.Text,
                txtPostcode.Text,
                decimal.Parse(txtSalary.Text),
                cboRole.Text,
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
                MessageBox.Show("Account could not be created. Check all details and make sure the Staff ID is unique.");
            }
        }
    }
}