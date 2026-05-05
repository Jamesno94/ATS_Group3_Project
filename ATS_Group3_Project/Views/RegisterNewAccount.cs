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
    }
}
