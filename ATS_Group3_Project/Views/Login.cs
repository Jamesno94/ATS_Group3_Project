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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

            //using (var context = new ATSContext())
            //{
            //    var user = context.Users.FirstOrDefault(u => u.username == username && u.PasswordHash == password);
            //    if (user != null)
            //    {
            //        MessageBox.Show("Login successful!");
            //        // Open the main form or dashboard here
            //        this.Hide();
            //        MainMenu mainMenu = new MainMenu();
            //        mainMenu.ShowDialog();
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid username or password. Please try again.");
            //    }
            //}
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Register register = new Register();
            //register.ShowDialog();
            //this.Close();
        }
    }
}
