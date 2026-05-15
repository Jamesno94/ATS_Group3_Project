using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATS_Group3_Project.Views
{
    public partial class frmJobDetails : Form
    {
        private string _staffId;

        public frmJobDetails() : this("")
        {
        }

        public frmJobDetails(string staffId)
        {
            InitializeComponent();

            _staffId = staffId;

            btnSaveChanges.Click -= btnSaveChanges_Click;
            btnSaveChanges.Click += btnSaveChanges_Click;

            btnCancel.Click -= btnCancel_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void frmJobDetails_Load(object sender, EventArgs e)
        {
            SetupComboBoxes();
            SetupReadOnlyFields();
            SetupComponentChecklist();
            LoadExampleJobDetails();
            LoadExampleChecklist();
        }

        private void SetupComboBoxes()
        {
            comboxPriority.Items.Clear();
            comboxPriority.Items.AddRange(new object[]
            {
                "Low",
                "Medium",
                "High",
                "Critical"
            });

            comboxStatus.Items.Clear();
            comboxStatus.Items.AddRange(new object[]
            {
                "Open",
                "In Progress",
                "Completed",
                "Cancelled"
            });

            comboxPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            comboxStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            comboxPriority.SelectedItem = "High";
            comboxStatus.SelectedItem = "Open";
        }

        private void SetupReadOnlyFields()
        {
            // Job information should be viewed, not edited, on this screen.
            txtJobReference.ReadOnly = true;
            txtJobType.ReadOnly = true;
            txtWindfarm.ReadOnly = true;
            txtTurbine.ReadOnly = true;
            txtAssignedEngineer.ReadOnly = true;
            rtxtFaultDescription.ReadOnly = true;
            datetimeFault.Enabled = false;

            // Engineer can update these.
            comboxStatus.Enabled = true;
            rtxtEngineerNotes.ReadOnly = false;
            dataGVComponentChecklist.ReadOnly = false;

            // Makes labels visible on dark/background image.
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label11.ForeColor = Color.White;
        }

        private void SetupComponentChecklist()
        {
            dataGVComponentChecklist.AllowUserToAddRows = false;
            dataGVComponentChecklist.AllowUserToDeleteRows = false;
            dataGVComponentChecklist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGVComponentChecklist.EditMode = DataGridViewEditMode.EditOnEnter;

            // Component name stays locked.
            Column1.ReadOnly = true;

            // Engineer can edit these columns.
            Column2.ReadOnly = false;
            Column3.ReadOnly = false;
            Column4.ReadOnly = false;
            Column5.ReadOnly = false;

            Column3.Items.Clear();
            Column3.Items.AddRange(new object[]
            {
                "Inspect",
                "Repair",
                "Replace",
                "Test",
                "No Action"
            });

            Column4.Items.Clear();
            Column4.Items.AddRange(new object[]
            {
                "Pending",
                "In Progress",
                "Completed",
                "Not Required"
            });
        }

        private void LoadExampleJobDetails()
        {
            txtJobReference.Text = "JOB-1001";
            txtJobType.Text = "Fault Repair";
            txtWindfarm.Text = "North Sea Windfarm";
            txtTurbine.Text = "Turbine T-04";

            if (string.IsNullOrWhiteSpace(_staffId))
            {
                txtAssignedEngineer.Text = "Engineer A";
            }
            else
            {
                txtAssignedEngineer.Text = _staffId;
            }

            datetimeFault.Value = DateTime.Now.AddHours(-3);

            rtxtFaultDescription.Text =
                "Turbine reported reduced output and vibration warning. Engineer must inspect the turbine components and update the checklist.";

            rtxtEngineerNotes.Text = "";
        }

        private void LoadExampleChecklist()
        {
            dataGVComponentChecklist.Rows.Clear();

            dataGVComponentChecklist.Rows.Add("Blades", false, "Inspect", "Pending", "");
            dataGVComponentChecklist.Rows.Add("Gearbox", false, "Inspect", "Pending", "");
            dataGVComponentChecklist.Rows.Add("Generator", false, "Test", "Pending", "");
            dataGVComponentChecklist.Rows.Add("Braking System", false, "Inspect", "Pending", "");
            dataGVComponentChecklist.Rows.Add("Control Panel", false, "Test", "Pending", "");
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            dataGVComponentChecklist.EndEdit();

            if (comboxStatus.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a job status before saving.",
                    "Missing Status",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (comboxStatus.Text == "Completed" && string.IsNullOrWhiteSpace(rtxtEngineerNotes.Text))
            {
                MessageBox.Show(
                    "Please enter engineer notes before marking this job as completed.",
                    "Engineer Notes Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (comboxStatus.Text == "Completed" && ChecklistStillHasPendingItems())
            {
                DialogResult result = MessageBox.Show(
                    "Some checklist items are still pending. Do you still want to save this job as completed?",
                    "Pending Checklist Items",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            string saveSummary = BuildSaveSummary();

            MessageBox.Show(
                saveSummary,
                "Job Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private bool ChecklistStillHasPendingItems()
        {
            foreach (DataGridViewRow row in dataGVComponentChecklist.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                object statusValue = row.Cells[3].Value;

                if (statusValue == null)
                {
                    return true;
                }

                string status = statusValue.ToString();

                if (status == "Pending" || status == "In Progress")
                {
                    return true;
                }
            }

            return false;
        }

        private string BuildSaveSummary()
        {
            StringBuilder summary = new StringBuilder();

            summary.AppendLine("Job details have been saved successfully.");
            summary.AppendLine();
            summary.AppendLine("Job Reference: " + txtJobReference.Text);
            summary.AppendLine("Turbine: " + txtTurbine.Text);
            summary.AppendLine("Priority: " + comboxPriority.Text);
            summary.AppendLine("Status: " + comboxStatus.Text);
            summary.AppendLine();
            summary.AppendLine("Engineer Notes:");
            summary.AppendLine(string.IsNullOrWhiteSpace(rtxtEngineerNotes.Text)
                ? "No notes entered."
                : rtxtEngineerNotes.Text);

            return summary.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to close this job details screen?",
                "Close Job Details",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        // Keep this in case the old Designer file still calls frmTest_Load.
        private void frmTest_Load(object sender, EventArgs e)
        {
            frmJobDetails_Load(sender, e);
        }
    }
}