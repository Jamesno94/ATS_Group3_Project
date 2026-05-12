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
    public partial class ManageWindFarms : Form
    {
        public ManageWindFarms()
        {
            InitializeComponent();
        }

        private void ManageWindFarms_Load(object sender, EventArgs e)
        {

        }

        private void btnViewWindFarms_Click(object sender, EventArgs e)
        {
            
            WindFarm viewPage = new WindFarm();
            viewPage.Show();

        }

        private void btnViewWindfarms_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            frmCallHandler dashboard = new frmCallHandler("ID001", "User", "Admin");

            dashboard.Show();
            this.Close();
        }
        private void PopulateGrid()
        {
          
            WindFarmManager manager = new WindFarmManager();

           
            var data = manager.GetAllWindFarms();

            
            dgWindFarms.DataSource = null;
            dgWindFarms.DataSource = data;
        }

        private void dgWindFarms1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
