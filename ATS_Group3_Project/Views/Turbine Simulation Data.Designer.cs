namespace ATS_Group3_Project
{
    partial class frmTurbSimData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurbSimData));
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurrentHr = new System.Windows.Forms.TextBox();
            this.txtNewHr = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboWIndFarms = new System.Windows.Forms.ComboBox();
            this.dataGVTrubinStats = new System.Windows.Forms.DataGridView();
            this.turbineIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runtimeHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastRecorded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windFarmIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turbinesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aTS_WindSyncDBDataSet1 = new ATS_Group3_Project.ATS_WindSyncDBDataSet1();
            this.aTS_WindSyncDBDataSet = new ATS_Group3_Project.ATS_WindSyncDBDataSet();
            this.turbinesTableAdapter = new ATS_Group3_Project.ATS_WindSyncDBDataSetTableAdapters.TurbinesTableAdapter();
            this.aTSWindSyncDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAutoJobService = new System.Windows.Forms.Label();
            this.turbinesTableAdapter1 = new ATS_Group3_Project.ATS_WindSyncDBDataSet1TableAdapters.TurbinesTableAdapter();
            this.btnLogAFault = new System.Windows.Forms.Button();
            this.btnCreateJob = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTrubinStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbinesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTS_WindSyncDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTS_WindSyncDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTSWindSyncDBDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "WindSync ATS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(977, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Azure;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(127, 317);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 41);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Cancel";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Windfarm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current Run Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "New Runtime Value (Hours)";
            // 
            // txtCurrentHr
            // 
            this.txtCurrentHr.BackColor = System.Drawing.Color.Azure;
            this.txtCurrentHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentHr.Location = new System.Drawing.Point(7, 153);
            this.txtCurrentHr.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrentHr.Name = "txtCurrentHr";
            this.txtCurrentHr.Size = new System.Drawing.Size(134, 32);
            this.txtCurrentHr.TabIndex = 20;
            // 
            // txtNewHr
            // 
            this.txtNewHr.BackColor = System.Drawing.Color.Azure;
            this.txtNewHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewHr.Location = new System.Drawing.Point(7, 249);
            this.txtNewHr.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewHr.Name = "txtNewHr";
            this.txtNewHr.Size = new System.Drawing.Size(134, 32);
            this.txtNewHr.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Azure;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(7, 317);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 41);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboWIndFarms
            // 
            this.cboWIndFarms.BackColor = System.Drawing.Color.Azure;
            this.cboWIndFarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cboWIndFarms.FormattingEnabled = true;
            this.cboWIndFarms.Items.AddRange(new object[] {
            "All",
            "Whitelee",
            "Beinn an Tuirc",
            "Clyde"});
            this.cboWIndFarms.Location = new System.Drawing.Point(5, 42);
            this.cboWIndFarms.Name = "cboWIndFarms";
            this.cboWIndFarms.Size = new System.Drawing.Size(167, 33);
            this.cboWIndFarms.TabIndex = 31;
            this.cboWIndFarms.SelectedIndexChanged += new System.EventHandler(this.cboWIndFarms_SelectedIndexChanged);
            // 
            // dataGVTrubinStats
            // 
            this.dataGVTrubinStats.AllowUserToAddRows = false;
            this.dataGVTrubinStats.AllowUserToDeleteRows = false;
            this.dataGVTrubinStats.AutoGenerateColumns = false;
            this.dataGVTrubinStats.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGVTrubinStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVTrubinStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turbineIdColumn,
            this.makeDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.runtimeHoursDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.LastRecorded,
            this.windFarmIdDataGridViewTextBoxColumn});
            this.dataGVTrubinStats.DataSource = this.turbinesBindingSource1;
            this.dataGVTrubinStats.Location = new System.Drawing.Point(287, 56);
            this.dataGVTrubinStats.Name = "dataGVTrubinStats";
            this.dataGVTrubinStats.ReadOnly = true;
            this.dataGVTrubinStats.Size = new System.Drawing.Size(732, 316);
            this.dataGVTrubinStats.TabIndex = 33;
            this.dataGVTrubinStats.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVTrubinStats_CellClick);
            // 
            // turbineIdColumn
            // 
            this.turbineIdColumn.DataPropertyName = "TurbineId";
            this.turbineIdColumn.HeaderText = "Turbine Id";
            this.turbineIdColumn.Name = "turbineIdColumn";
            this.turbineIdColumn.ReadOnly = true;
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            this.makeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // runtimeHoursDataGridViewTextBoxColumn
            // 
            this.runtimeHoursDataGridViewTextBoxColumn.DataPropertyName = "RuntimeHours";
            this.runtimeHoursDataGridViewTextBoxColumn.HeaderText = "Runtime Hours";
            this.runtimeHoursDataGridViewTextBoxColumn.Name = "runtimeHoursDataGridViewTextBoxColumn";
            this.runtimeHoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LastRecorded
            // 
            this.LastRecorded.DataPropertyName = "LastRecorded";
            this.LastRecorded.HeaderText = "Last Hours Recorded";
            this.LastRecorded.Name = "LastRecorded";
            this.LastRecorded.ReadOnly = true;
            // 
            // windFarmIdDataGridViewTextBoxColumn
            // 
            this.windFarmIdDataGridViewTextBoxColumn.DataPropertyName = "WindFarmId";
            this.windFarmIdDataGridViewTextBoxColumn.HeaderText = "Windfarm Id";
            this.windFarmIdDataGridViewTextBoxColumn.Name = "windFarmIdDataGridViewTextBoxColumn";
            this.windFarmIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // turbinesBindingSource1
            // 
            this.turbinesBindingSource1.DataMember = "Turbines";
            this.turbinesBindingSource1.DataSource = this.aTS_WindSyncDBDataSet1;
            // 
            // aTS_WindSyncDBDataSet1
            // 
            this.aTS_WindSyncDBDataSet1.DataSetName = "ATS_WindSyncDBDataSet1";
            this.aTS_WindSyncDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aTS_WindSyncDBDataSet
            // 
            this.aTS_WindSyncDBDataSet.DataSetName = "ATS_WindSyncDBDataSet";
            this.aTS_WindSyncDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // turbinesTableAdapter
            // 
            this.turbinesTableAdapter.ClearBeforeFill = true;
            // 
            // aTSWindSyncDBDataSetBindingSource
            // 
            this.aTSWindSyncDBDataSetBindingSource.DataSource = this.aTS_WindSyncDBDataSet;
            this.aTSWindSyncDBDataSetBindingSource.Position = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCreateJob);
            this.panel1.Controls.Add(this.btnLogAFault);
            this.panel1.Controls.Add(this.txtNewHr);
            this.panel1.Controls.Add(this.txtCurrentHr);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cboWIndFarms);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 431);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtAutoJobService);
            this.panel2.Location = new System.Drawing.Point(287, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 62);
            this.panel2.TabIndex = 35;
            // 
            // txtAutoJobService
            // 
            this.txtAutoJobService.AutoSize = true;
            this.txtAutoJobService.BackColor = System.Drawing.Color.Transparent;
            this.txtAutoJobService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoJobService.ForeColor = System.Drawing.Color.Black;
            this.txtAutoJobService.Location = new System.Drawing.Point(2, 16);
            this.txtAutoJobService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAutoJobService.Name = "txtAutoJobService";
            this.txtAutoJobService.Size = new System.Drawing.Size(181, 20);
            this.txtAutoJobService.TabIndex = 18;
            this.txtAutoJobService.Text = "Is Service Job Required:";
            // 
            // turbinesTableAdapter1
            // 
            this.turbinesTableAdapter1.ClearBeforeFill = true;
            // 
            // btnLogAFault
            // 
            this.btnLogAFault.BackColor = System.Drawing.Color.Azure;
            this.btnLogAFault.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogAFault.Location = new System.Drawing.Point(7, 378);
            this.btnLogAFault.Name = "btnLogAFault";
            this.btnLogAFault.Size = new System.Drawing.Size(116, 41);
            this.btnLogAFault.TabIndex = 32;
            this.btnLogAFault.Text = "Log a Fault";
            this.btnLogAFault.UseVisualStyleBackColor = false;
            this.btnLogAFault.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreateJob
            // 
            this.btnCreateJob.BackColor = System.Drawing.Color.Azure;
            this.btnCreateJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateJob.Location = new System.Drawing.Point(127, 378);
            this.btnCreateJob.Name = "btnCreateJob";
            this.btnCreateJob.Size = new System.Drawing.Size(116, 41);
            this.btnCreateJob.TabIndex = 33;
            this.btnCreateJob.Text = "Create a Service";
            this.btnCreateJob.UseVisualStyleBackColor = false;
            this.btnCreateJob.Click += new System.EventHandler(this.btnCreateJob_Click);
            // 
            // btnCreateJob
            // 
            this.btnCreateJob.Location = new System.Drawing.Point(469, 562);
            this.btnCreateJob.Name = "btnCreateJob";
            this.btnCreateJob.Size = new System.Drawing.Size(122, 39);
            this.btnCreateJob.TabIndex = 35;
            this.btnCreateJob.Text = "Create Job";
            this.btnCreateJob.UseVisualStyleBackColor = true;
            this.btnCreateJob.Click += new System.EventHandler(this.btnCreateJob_Click);
            // 
            // frmTurbSimData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::ATS_Group3_Project.Properties.Resources.ATS_Background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 598);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGVTrubinStats);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTurbSimData";
            this.Text = "Turbine Simulation Data";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.frmTurbSimData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTrubinStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbinesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTS_WindSyncDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTS_WindSyncDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTSWindSyncDBDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCurrentHr;
        private System.Windows.Forms.TextBox txtNewHr;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboWIndFarms;
        private System.Windows.Forms.DataGridView dataGVTrubinStats;
        private ATS_WindSyncDBDataSet aTS_WindSyncDBDataSet;
        private ATS_WindSyncDBDataSetTableAdapters.TurbinesTableAdapter turbinesTableAdapter;
        private System.Windows.Forms.BindingSource aTSWindSyncDBDataSetBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtAutoJobService;
        private ATS_WindSyncDBDataSet1 aTS_WindSyncDBDataSet1;
        private System.Windows.Forms.BindingSource turbinesBindingSource1;
        private ATS_WindSyncDBDataSet1TableAdapters.TurbinesTableAdapter turbinesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn turbineIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runtimeHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastRecorded;
        private System.Windows.Forms.DataGridViewTextBoxColumn windFarmIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLogAFault;
        private System.Windows.Forms.Button btnCreateJob;
    }
}