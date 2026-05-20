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
    public partial class ResetPassword : Form
    {
        private string _staffId;

        public ResetPassword(string staffId)
        {
            InitializeComponent();
            _staffId = staffId;
        }
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
           
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            UserManager manager = new UserManager();

            string message;

            bool success = manager.ResetPassword(
                _staffId,
                txtCode.Text.Trim(),
                txtNewPassword.Text,
                out message
            );

            MessageBox.Show(message);

            if (success)
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Close();
            }
        }
    
    }
}
