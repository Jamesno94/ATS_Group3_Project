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
    public partial class frmAddFaultJob : Form
    {
        public frmAddFaultJob()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to leave this page?",
            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 secondForm = new Form1();
                secondForm.Show();
                this.Hide();
            }
        }

        private void DashboardLogoClick_Click(object sender, EventArgs e)
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

                // 4. Hide Add Fault Job Form
                this.Hide();

            }
        }
    }
}
