using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATS_Group3_Project.Views
{
    public partial class frmManageAccount : Form
    {
        private string _staffId;
        private string StaffId;
        private string firstName;
        private string role;

        private StaffManager _staffManager = new StaffManager();
        private UserManager _userManager = new UserManager();

        public frmManageAccount(string staffId)
        {
            InitializeComponent();

            _staffId = staffId;
        }

        private void Manage_Account_Load(object sender, EventArgs e)
        {
            using (var db = new ATSContext())
            {
                var staff = db.Staff.FirstOrDefault(s => s.StaffId == _staffId);

                if (staff == null)
                {
                    MessageBox.Show("Your account details could not be found.");
                    this.Close();
                    return;
                }

                txtStaffId.Text = staff.StaffId;
                txtFirstName.Text = staff.FirstName;
                txtLastName.Text = staff.LastName;
                txtWorkMobile.Text = staff.WorkMobile;
                txtHomeMobile.Text = staff.HomeMobile;
                txtEmail.Text = staff.Email;
                txtAddress1.Text = staff.Address1;
                txtAddress2.Text = staff.Address2;
                txtCity.Text = staff.City;
                txtPostcode.Text = staff.Postcode;

                txtSalary.Text = staff.Salary.ToString();
                txtRole.Text = staff.Role;

                txtStaffId.ReadOnly = true;
                txtSalary.ReadOnly = true;
                txtRole.ReadOnly = true;
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
            string.IsNullOrWhiteSpace(txtLastName.Text) ||
            string.IsNullOrWhiteSpace(txtWorkMobile.Text) ||
            string.IsNullOrWhiteSpace(txtEmail.Text) ||
            string.IsNullOrWhiteSpace(txtAddress1.Text) ||
            string.IsNullOrWhiteSpace(txtCity.Text) ||
            string.IsNullOrWhiteSpace(txtPostcode.Text))
            {
                MessageBox.Show("Please complete all required fields.");
                return;
            }

            Staff updatedStaff = new Staff
            {
                StaffId = _staffId,
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                WorkMobile = txtWorkMobile.Text.Trim(),
                HomeMobile = txtHomeMobile.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address1 = txtAddress1.Text.Trim(),
                Address2 = txtAddress2.Text.Trim(),
                City = txtCity.Text.Trim(),
                Postcode = txtPostcode.Text.Trim(),
                Salary = decimal.Parse(txtSalary.Text),
                Role = txtRole.Text.Trim()
            };

            bool staffUpdated = _staffManager.UpdateStaff(updatedStaff);

            if (!staffUpdated)
            {
                MessageBox.Show("Your account details could not be updated.");
                return;
            }

            string newPassword = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (!string.IsNullOrWhiteSpace(newPassword) ||
                !string.IsNullOrWhiteSpace(confirmPassword))
            {
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }

                bool passwordChanged = _userManager.ChangePassword(_staffId, newPassword);

                if (!passwordChanged)
                {
                    MessageBox.Show("Details were updated, but the password could not be changed. Please check the password requirements.");
                    return;
                }
            }

            MessageBox.Show("Your account details have been updated successfully.");
            this.Close();
        }

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    // 1. Ask for confirmation
        //    DialogResult result = MessageBox.Show("Are you sure you want to go to the Admin Dashboard?",
        //        "Confirm Navigation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //    if (result == DialogResult.Yes)
        //    {
        //        // 2. Create the Admin Dashboard form instance
        //        Manage_Account frm = new Manage_Account();

        //        // 3. Show the dashboard
        //        frm.Show();

        //        // 4. Hide Register New Account Form
        //        this.Hide();
        //    }
        //}
    }
}
