using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ATS_Group3_Project
{
    public partial class frmTurbSimData : Form
    {
        private User _user;
        private WindFarmManager _windFarmManager = new WindFarmManager();

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
            //Whitelee
            //Beinn an Tuirc
            //Clyde
            
        }
        private void LoadTurbinesList(List<Turbine> turbines)
        {
            dataGVTrubinStats.DataSource = null;
            dataGVTrubinStats.DataSource = turbines;
        }

        private void cboWIndFarms_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTurbine.Items.Clear();

            string selectedFarm = cboWIndFarms.SelectedItem.ToString();

            List<Turbine> turbines;

            if (selectedFarm == "All")
            {
                //Get ALL turbines (no filter)
                turbines = new TurbineManager().GetAllTurbines();
            }
            else
            {
                string windFarmId = "";

                switch (selectedFarm)
                {
                    case "Whitelee":
                        windFarmId = "WL-FARM";
                        break;

                    case "Black Tower":
                        windFarmId = "BT-FARM";
                        break;

                    case "Clyde":
                        windFarmId = "CL-FARM";
                        break;

                    default:
                        return;
                }

                turbines = new TurbineManager().GetTurbinesByFarmId(windFarmId);
            }

            LoadTurbinesList(turbines);

            cboTurbine.Items.AddRange(
                turbines.Select(t => t.TurbineId).ToArray());
        }

        private void frmTurbSimData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aTS_WindSyncDBDataSet.Turbines' table. You can move, or remove it, as needed.
            this.turbinesTableAdapter.Fill(this.aTS_WindSyncDBDataSet.Turbines);

        }
    }
}
