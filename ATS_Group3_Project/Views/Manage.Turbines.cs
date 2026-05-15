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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnManageWinFarms_Click(object sender, EventArgs e)
        {
            ManageWindFarms manageForm = new ManageWindFarms();
            manageForm.Show();
            this.Close();
        }

        private void btbBack_Click(object sender, EventArgs e)
        {

        }

        
        private void LoadTurbines()
        {
            try
            {
            
                TurbineManager manager = new TurbineManager();
                var turbineList = manager.GetAllTurbines();

            
                dgTurbine.DataSource = null;
                dgTurbine.DataSource = turbineList;

                
                if (dgTurbine.Columns["WindFarm"] != null)
                    dgTurbine.Columns["WindFarm"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading turbines: " + ex.Message);
            }
        }
        private void Manage_Load(object sender, EventArgs e)
        {
            LoadTurbines();
        }



        private void dgTurbine1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Turbines addForm = new Turbines();

           
            addForm.ShowDialog();

            LoadTurbines();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
