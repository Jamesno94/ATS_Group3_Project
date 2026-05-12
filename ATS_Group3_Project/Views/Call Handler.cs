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
    public partial class frmCallHandler : Form
    {
        private string StaffId;
        public frmCallHandler(string StaffId, string firstName, string role)
        {
            lblGreetings.Text = $"Greetings, {firstName}";
            lblRole.Text = $"Role: {role}";

            InitializeComponent();
            this.StaffId = StaffId;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Do you wish to log out?",
            "Logout Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

            if (result == DialogResult.Yes)
            {
                frmLogin loginForm = new frmLogin();
                loginForm.Show();

                this.Hide();
            }
        }

        private void btnSimulationDashboard_Click(object sender, EventArgs e)
        {
            frmTurbSimData form = new frmTurbSimData();
            form.Show();
        }

        private void btnLogFaultJob_Click(object sender, EventArgs e)
        {
            frmAddFaultJob form = new frmAddFaultJob();
            form.Show();
        }

        private void btnAddWindFarm_Click(object sender, EventArgs e)
        {
            WindFarm form = new WindFarm();
            form.Show();

            //One has to be a different button

            //ManageWindFarms manageView = new ManageWindFarms();


            //manageView.Show();


            //this.Hide();
        }
    }
}

