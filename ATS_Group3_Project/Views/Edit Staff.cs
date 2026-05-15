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
    public partial class frmEditStaff : Form
    {
        private string _staffId;
        private string StaffId;
        private string firstName;
        private string role;

        private StaffManager _staffManager = new StaffManager();

        public frmEditStaff(string StaffId)
        {
            this.StaffId = StaffId;
            _staffId = StaffId;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // 1. Ask for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to return to the Admin Dashboard?",
                "Confirm Navigation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. Create the Dashboard form instance
                frmAdminDashboard frmAdminDashboard = new frmAdminDashboard(StaffId, firstName, role);

                // 3. Show the dashboard
                frmAdminDashboard.Show();

                // 4. Hide This
                this.Hide();
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
                string.IsNullOrWhiteSpace(txtPostcode.Text) ||
                string.IsNullOrWhiteSpace(txtSalary.Text) ||
                string.IsNullOrWhiteSpace(cboRole.Text))
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

            Staff updatedStaff = new Staff
            {
                StaffId = txtStaffId.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                WorkMobile = txtWorkMobile.Text.Trim(),
                HomeMobile = txtHomeMobile.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address1 = txtAddress1.Text.Trim(),
                Address2 = txtAddress2.Text.Trim(),
                City = txtCity.Text.Trim(),
                Postcode = txtPostcode.Text.Trim(),
                Salary = salary,
                Role = cboRole.Text.Trim()
            };

            StaffManager manager = new StaffManager();

            bool success = manager.UpdateStaff(updatedStaff);

            if (success)
            {
                MessageBox.Show("Staff details updated successfully.");

                frmManageStaff manageStaff = new frmManageStaff();
                manageStaff.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Staff details could not be updated.");
            }
        }

        private void frmEditStaff_Load(object sender, EventArgs e)
        {
            using (var db = new ATSContext())
            {
                var staff = db.Staff.FirstOrDefault(s => s.StaffId == _staffId);

                if (staff == null)
                {
                    MessageBox.Show("Staff member could not be found.");
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
                cboRole.Text = staff.Role;

                txtStaffId.ReadOnly = true;
            }
        }
    }
}
