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
    public partial class frmJobDetails : Form
    {
        private int _jobId;
        public frmJobDetails()
        {
            InitializeComponent();
        }

        public frmJobDetails(int jobId)
        {
            InitializeComponent();

            _jobId = jobId;
        }

        private void frmJobDetails_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Loaded Job ID: " + _jobId);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
