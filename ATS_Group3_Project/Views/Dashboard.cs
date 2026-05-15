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
    public partial class frmDashboard : Form
    {
        private string StaffId;
        private string firstName;
        private string role;

        public frmDashboard(string staffId, string firstName, string role)
        {
            InitializeComponent();

            this.StaffId = staffId;
            this.firstName = firstName;
            this.role = role;

            lblGreetings.Text = $"Greetings, {firstName}";
            lblRole.Text = $"Role: {role}";
        }

        private void btnAddFaultJob_Click(object sender, EventArgs e)
        {
            // 1. Ask for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to go to the Add Fault Job Page?",
                "Confirm Navigation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. Create the Add Fault Job Form instance
                frmAddFaultJob addFaultJob = new frmAddFaultJob(StaffId, firstName, role);

                // 3. Show the Add Fault Job Form
                addFaultJob.Show();

                // 4. Hide Dashoard
                this.Close();


            }
        }

        private void btnRegisterNewAccount_Click(object sender, EventArgs e)
        {
            // 1. Ask for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to go to the Register New Account Page?",
                "Confirm Navigation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. Create the Register New Account Form instance
                frmRegisterNewAccount registerNewAccount = new frmRegisterNewAccount(StaffId, firstName, role);

                // 3. Show the Register New Account Form
                registerNewAccount.Show();

                // 4. Hide Dashboard
                this.Close();

            }
        }

        private void btnViewAssignedJobs_Click(object sender, EventArgs e)
        {
            // 1. Ask for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to go to the View Assigned Jobs Page?",
                "Confirm Navigation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                // 2. Create the View Assigned Jobs Form instance
                frmViewAssignedJobs viewAssignedJobs = new frmViewAssignedJobs(StaffId, firstName, role);

                // 3. Show the View Assigned Jobs Form
                viewAssignedJobs.Show();

                //4. Hide Dashboard
                this.Close();
            }
        }

        private void btnAddTurbineSimulationData_Click(object sender, EventArgs e)
        {
            // 1. Ask for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to go to the Turbine Simulation Data Page?",
                "Confirm Navigation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. Create the Turbine Simulation Data Form instance
                frmTurbSimData turbine_Simulation_Data = new frmTurbSimData(StaffId, firstName, role);

                // 3. Show the Turbine Simulation Data Form
                turbine_Simulation_Data.Show();

                //4. Hide Dashboard
                this.Close();
            }
        }

    }
    
}
