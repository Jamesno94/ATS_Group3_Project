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

            // Automatically select "All"
            cboWIndFarms.SelectedItem = "All";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();

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

            // Validate runtime values
            bool currentValid = int.TryParse(txtCurrentHr.Text, out int currentRunTime);
            bool newValid = int.TryParse(txtNewHr.Text, out int newRunTime);

            if (!currentValid || !newValid)
            {
                MessageBox.Show("Please enter valid runtime values.");
                return;
            }

            // Prevent lower runtime values
            if (newRunTime < currentRunTime)
            {
                MessageBox.Show(
                    "New runtime must be greater than or equal to current runtime.");
                return;
            }

            // Update turbine values
            selectedTurbine.RuntimeHours = newRunTime;
            selectedTurbine.LastRecorded = DateTime.Now;

            bool requiresService = newRunTime >= 2000;

            if (requiresService)
            {
                selectedTurbine.Status = "Requires Service";

                txtAutoJobService.Text =
                    "Is Service Job Required: Service Required, Job Created";
            }
            else
            {
                selectedTurbine.Status = "Active";

                txtAutoJobService.Text =
                    "Is Service Job Required: This turbine does not require a service.";
            }

            // Save turbine update first
            bool updated = new TurbineManager().UpdateTurbine(selectedTurbine);

            if (!updated)
            {
                MessageBox.Show("Database update failed.");
                return;
            }

            // Create service job if needed
            if (requiresService)
            {
                DispatchManager dispatchManager = new DispatchManager();

                JobRecord createdJob =
                    dispatchManager.CreateScheduledServiceJob(
                        selectedTurbine.TurbineId);

                if (createdJob == null)
                {
                    MessageBox.Show(
                        "A service job already exists for this turbine, or no engineer could be assigned.");
                }
                else
                {
                    MessageBox.Show(
                        "Service job created and engineer assigned.");

                    frmJobDetails jobDetails =
                        new frmJobDetails(createdJob.JobId);

                    jobDetails.Show();

                    this.Hide();
                }
            }

            // Update UI
            txtCurrentHr.Text = newRunTime.ToString();
            txtNewHr.Clear();

            // Refresh grid display
            dataGVTrubinStats.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCallHandler callHandler = new frmCallHandler(StaffId, firstName, role);
            callHandler.Show();
            this.Close();
        }

        private void btnLogAFault_Click(object sender, EventArgs e)
        {
            // Ensure turbine selected
            if (selectedTurbine == null)
            {
                MessageBox.Show("Please select a turbine first.");
                return;
            }

            using (var db = new ATSContext())
            {
                var turbine = db.Turbines
                    .FirstOrDefault(t => t.TurbineId == selectedTurbine.TurbineId);

                // Ensure turbine exists
                if (turbine == null)
                {
                    MessageBox.Show(
                        "Turbine could not be found in the database.");

                    return;
                }

                // Prevent duplicate open fault jobs
                bool existingFaultJob = db.JobRecords.Any(j =>
                    j.TurbineId == turbine.TurbineId &&
                    j.JobType == "Fault" &&
                    j.JobComplete == "Awaiting Engineer");

                if (existingFaultJob)
                {
                    MessageBox.Show(
                        "An active fault job already exists for this turbine.");

                    return;
                }

                // Optional:
                // Prevent fault logging if turbine already faulted
                if (turbine.Status == "Fault")
                {
                    MessageBox.Show(
                        "This turbine is already marked as Fault.");

                    return;
                }
            }

            // Open Add Fault Job form
            frmAddFaultJob addFaultJobForm =
                new frmAddFaultJob(
                    StaffId,
                    firstName,
                    role,
                    selectedTurbine.TurbineId,
                    selectedTurbine.WindFarmId
                );

            addFaultJobForm.Show();

            this.Hide();
        }

        private void btnCreateSJob_Click(object sender, EventArgs e)
        {
         
        }

    }// End class
}// End namespace