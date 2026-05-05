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
        public frmCallHandler(string StaffId)
        {
            InitializeComponent();
            this.StaffId = StaffId;
        }
    }
}
