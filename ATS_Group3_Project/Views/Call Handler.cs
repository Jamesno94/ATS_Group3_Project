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
            InitializeComponent();

            this.StaffId = StaffId;

            lblGreetings.Text = $"Greetings, {firstName}";
            lblRole.Text = $"Role: {role}";
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
            frmTurbSimData simDataForm = new frmTurbSimData();
            simDataForm.Show();
            this.Hide();
        }
    }
}

