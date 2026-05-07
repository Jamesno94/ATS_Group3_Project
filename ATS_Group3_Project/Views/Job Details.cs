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
        private string _staffId;

        public frmJobDetails(string staffId)
        {
            InitializeComponent();
            _staffId = staffId;
        }
        private void frmTest_Load(object sender, EventArgs e)
        {
            // You can leave this empty for now
        }
    }
}
