using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Windows.Forms;

namespace ATS_Group3_Project
{
    public partial class frmTurbSimData : Form
    {
        // Stores turbines currently shown in grid
        private List<Turbine> currentTurbines = new List<Turbine>();

        // Stores currently selected turbine
        private Turbine selectedTurbine;

        public frmTurbSimData()
        {
            InitializeComponent();
        }

        private void frmTurbSimData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aTS_WindSyncDBDataSet1.Turbines' table. You can move, or remove it, as needed.
            this.turbinesTableAdapter1.Fill(this.aTS_WindSyncDBDataSet1.Turbines);
            // Optional initial load
            this.turbinesTableAdapter.Fill(this.aTS_WindSyncDBDataSet.Turbines);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();

            this.Hide();
        }

        // Load turbines into DataGridView
        private void LoadTurbinesList(List<Turbine> turbines)
        {
            dataGVTrubinStats.DataSource = null;
            dataGVTrubinStats.DataSource = turbines;
        }

        // ComboBox Wind Farm Selection
        private void cboWIndFarms_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Prevent null crash
            if (cboWIndFarms.SelectedItem == null)
                return;

            string selectedFarm = cboWIndFarms.SelectedItem.ToString();

            string windFarmId;

            // ALL turbines
            if (selectedFarm == "All")
            {
                currentTurbines =
                    new TurbineManager().GetAllTurbines();
            }
            else
            {
                switch (selectedFarm)
                {
                    case "Whitelee":
                        windFarmId = "WL-FARM";
                        break;

                    case "Beinn an Tuirc":
                        windFarmId = "BT-FARM";
                        break;

                    case "Clyde":
                        windFarmId = "CL-FARM";
                        break;

                    default:
                        return;
                }

                currentTurbines =
                    new TurbineManager().GetTurbinesByFarmId(windFarmId);
            }

            // Display turbines
            LoadTurbinesList(currentTurbines);
        }

        // Select turbine from DataGridView
        private void dataGVTrubinStats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Prevent header row crash
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dataGVTrubinStats.Rows[e.RowIndex];

            // Get turbine ID from grid
            string turbineId =
                row.Cells["turbineIdColumn"].Value.ToString();

            // Find turbine object
            selectedTurbine = currentTurbines
                .FirstOrDefault(t => t.TurbineId == turbineId);

            // Display current runtime
            if (selectedTurbine != null)
            {
                txtCurrentHr.Text =
                    selectedTurbine.RuntimeHours.ToString();

                txtNewHr.Text = "";
            }
        }

        // Save runtime update
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Ensure turbine selected
            if (selectedTurbine == null)
            {
                MessageBox.Show("Please select a turbine.");
                return;
            }

            int currentRunTime;
            int newRunTime;
            DateTime dateTimeUpdated;

            // Validate numbers
            bool currentValid =
                int.TryParse(txtCurrentHr.Text, out currentRunTime);

            bool newValid =
                int.TryParse(txtNewHr.Text, out newRunTime);

            if (!currentValid || !newValid)
            {
                MessageBox.Show("Please enter valid runtime values.");
                return;
            }

            // Prevent lower values
            if (newRunTime < currentRunTime)
            {
                MessageBox.Show(
                    "New runtime must be greater than or equal to current runtime.");

                return;
            }

            // Update turbine runtime
            selectedTurbine.RuntimeHours = newRunTime;

            // Service trigger
            if (newRunTime >= 2000)
            {
                selectedTurbine.Status =
                    "Requires Service";

                txtAutoJobService.Text =
                    "Is Service Job Required: This turbine requires a service.";
                
                dateTimeUpdated = DateTime.Now;
                selectedTurbine.LastRecorded = dateTimeUpdated;

                //DispatchManager dispatchManager = new DispatchManager();
                //bool jobCreated =
                //    dispatchManager.CreateScheduledServiceJob(selectedTurbine.TurbineId);
            }
            else
            {
                selectedTurbine.Status = "Active";
                txtAutoJobService.Text = "";
            }

            txtCurrentHr.Clear();
            txtNewHr.Clear();

            // Save to database
            bool updated =
                new TurbineManager().UpdateTurbine(selectedTurbine);

            if (!updated)
            {
                MessageBox.Show("Database update failed.");
                return;
            }

            // Refresh grid
            dataGVTrubinStats.Refresh();

            MessageBox.Show("Runtime updated successfully.");


        }// End btnSave_Click
    }// End class
}// End namespace