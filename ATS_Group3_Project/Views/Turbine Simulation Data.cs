using ATS_Group3_Project.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mime;
using System.Windows.Forms;

namespace ATS_Group3_Project
{
    public partial class frmTurbSimData : Form
    {
        private string StaffId;
        private string firstName;
        private string role;

        // Stores turbines currently shown in grid
        private List<Turbine> currentTurbines = new List<Turbine>();

        // Stores currently selected turbine
        private Turbine selectedTurbine;

        public frmTurbSimData(string staffId, string firstName, string role)
        {
            InitializeComponent();
            this.StaffId = staffId;
            this.firstName = firstName;
            this.role = role;
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
            frmLogin login = new frmLogin(StaffId, firstName, role);
            login.ShowDialog();

            this.Close();
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
                txtAutoJobService.Text = "Is Service Job Required: This turbine does not require a service.";

                dateTimeUpdated = DateTime.Now;
                selectedTurbine.LastRecorded = dateTimeUpdated;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCallHandler callHandler = new frmCallHandler(StaffId, firstName, role);
            callHandler.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddFaultJob addFaultJobForm = new frmAddFaultJob(StaffId, firstName, role, selectedTurbine.TurbineId, selectedTurbine.WindFarmId);
            addFaultJobForm.Show();
            this.Hide();
        }

        private void btnCreateJob_Click(object sender, EventArgs e)
        {
            if (selectedTurbine == null)
            {
                MessageBox.Show("Please select a turbine first.");
                return;
            }

            using (var db = new ATSContext())
            {
                var turbine = db.Turbines
                    .FirstOrDefault(t => t.TurbineId == selectedTurbine.TurbineId);

                if (turbine == null)
                {
                    MessageBox.Show("Turbine could not be found in the database.");
                    return;
                }

                if (turbine.RuntimeHours < 2000)
                {
                    MessageBox.Show("This turbine has not reached 2000 runtime hours yet.");
                    return;
                }
            }

            DispatchManager dispatchManager = new DispatchManager();

            JobRecord createdJob = dispatchManager.CreateScheduledServiceJob(
                selectedTurbine.TurbineId
            );

            if (createdJob == null)
            {
                MessageBox.Show("A service job already exists for this turbine, or no engineer could be assigned.");
                return;
            }

            MessageBox.Show("Service job created and engineer assigned.");

            frmJobDetails jobDetails = new frmJobDetails(createdJob.JobId);
            jobDetails.Show();

            this.Hide();
        }
    }// End class
}// End namespace