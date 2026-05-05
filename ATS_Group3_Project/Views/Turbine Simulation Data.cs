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
    public partial class frmTurbSimData : Form
    {
        private User _user;

        public frmTurbSimData()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string windFarm = txtWindFarm.Text;
            string trubineID = txtTurbine.Text;
            string currentRunHrs = txtCurrentHr.Text;
            string lastSimRecord = txtLastRecord.Text;
            string newRunHrs = txtNewHr.Text;
            DateTime date = dtpDateRecorded.Value;
        }
    }
}
