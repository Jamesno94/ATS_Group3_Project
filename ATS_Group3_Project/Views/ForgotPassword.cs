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
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            UserManager manager = new UserManager();

            string message;

            bool result = manager.GeneratePasswordResetCode(
                txtStaffId.Text.Trim(),
                out message
            );

            MessageBox.Show(message);

            if (result)
            {
                ResetPassword resetForm = new ResetPassword(txtStaffId.Text.Trim());
                resetForm.Show();
                this.Hide();
            }
        }
    }
}
