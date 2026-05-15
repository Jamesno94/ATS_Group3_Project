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

    public partial class frmManageStaff : Form
    {
        private string _staffId;
        private string StaffId;
        private string firstName;
        private string role;

        private ATSContext _context = new ATSContext();

        public frmManageStaff()
        {
            InitializeComponent();
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
                    s.Role,

                })
                .ToList();

            dgStaff.DataSource = staffList;

            dgStaff.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgStaff.ReadOnly = true;

            dgStaff.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

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

            frmEditStaff editForm = new frmEditStaff(selectedStaffId);
            editForm.Show();

            this.Hide();
        }

        private void btnCreateStaff_Click(object sender, EventArgs e)
        {
            // 1. Ask for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to go to the Create Staff Page?",
                "Confirm Navigation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. Create the Create Staff Form instance
                frmRegisterNewAccount frmRegisterNewAccount = new frmRegisterNewAccount(StaffId, firstName, role);

                // 3. Show the Create Staff Form
                frmRegisterNewAccount.Show();

                // 4. Hide Dashoard
                this.Close();


            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (dgStaff.CurrentRow == null)
            {
                MessageBox.Show("Please select a staff member.");
                return;
            }

            string staffId = dgStaff.CurrentRow
                .Cells["StaffId"]
                .Value
                .ToString();

            if (string.IsNullOrWhiteSpace(staffId))
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

            bool success = manager.DeleteStaff(staffId);

            if (success)
            {
                MessageBox.Show("Staff member deleted successfully.");

                frmManageStaff manageStaff = new frmManageStaff();
                manageStaff.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Staff member could not be deleted.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // 1. Ask for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to return to the Admin Dashboard?",
                "Confirm Navigation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. Create the Admin Dashboard form instance
                frmAdminDashboard frmAdminDashboard = new frmAdminDashboard(StaffId, firstName, role);

                // 3. Show the dashboard
                frmAdminDashboard.Show();

                // 4. Hide This
                this.Hide();
            }
        }
    }
}
