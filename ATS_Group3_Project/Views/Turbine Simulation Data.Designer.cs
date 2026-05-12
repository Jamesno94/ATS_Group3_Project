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
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCurrentHr = new System.Windows.Forms.TextBox();
            this.txtNewHr = new System.Windows.Forms.TextBox();
            this.txtAutoJobService = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDateRecorded = new System.Windows.Forms.DateTimePicker();
            this.cboWIndFarms = new System.Windows.Forms.ComboBox();
            this.dataGVTrubinStats = new System.Windows.Forms.DataGridView();
            this.turbineIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runtimeHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windFarmIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turbinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTS_WindSyncDBDataSet = new ATS_Group3_Project.ATS_WindSyncDBDataSet();
            this.turbinesTableAdapter = new ATS_Group3_Project.ATS_WindSyncDBDataSetTableAdapters.TurbinesTableAdapter();
            this.aTSWindSyncDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTrubinStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTS_WindSyncDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTSWindSyncDBDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(935, 6);
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
            this.btnBack.BackColor = System.Drawing.Color.LightYellow;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(885, 582);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 24);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Cancel";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
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
            this.label2.BackColor = System.Drawing.Color.MintCream;
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
            this.label5.BackColor = System.Drawing.Color.MintCream;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "New Runtime Value (Hours)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MintCream;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 324);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date Recorded ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MintCream;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(770, 484);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Is Service Job Requierd:";
            // 
            // txtCurrentHr
            // 
            this.txtCurrentHr.BackColor = System.Drawing.Color.Azure;
            this.txtCurrentHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentHr.Location = new System.Drawing.Point(2, 153);
            this.txtCurrentHr.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrentHr.Name = "txtCurrentHr";
            this.txtCurrentHr.Size = new System.Drawing.Size(134, 32);
            this.txtCurrentHr.TabIndex = 20;
            // 
            // txtNewHr
            // 
            this.txtNewHr.BackColor = System.Drawing.Color.Azure;
            this.txtNewHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewHr.Location = new System.Drawing.Point(2, 249);
            this.txtNewHr.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewHr.Name = "txtNewHr";
            this.txtNewHr.Size = new System.Drawing.Size(134, 32);
            this.txtNewHr.TabIndex = 22;
            // 
            // txtAutoJobService
            // 
            this.txtAutoJobService.BackColor = System.Drawing.Color.Azure;
            this.txtAutoJobService.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoJobService.Location = new System.Drawing.Point(772, 505);
            this.txtAutoJobService.Margin = new System.Windows.Forms.Padding(2);
            this.txtAutoJobService.Name = "txtAutoJobService";
            this.txtAutoJobService.ReadOnly = true;
            this.txtAutoJobService.Size = new System.Drawing.Size(179, 32);
            this.txtAutoJobService.TabIndex = 26;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Honeydew;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(14, 582);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 24);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDateRecorded
            // 
            this.dtpDateRecorded.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.dtpDateRecorded.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateRecorded.Location = new System.Drawing.Point(2, 346);
            this.dtpDateRecorded.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateRecorded.Name = "dtpDateRecorded";
            this.dtpDateRecorded.Size = new System.Drawing.Size(187, 29);
            this.dtpDateRecorded.TabIndex = 29;
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
            this.dataGVTrubinStats.AutoGenerateColumns = false;
            this.dataGVTrubinStats.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGVTrubinStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVTrubinStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turbineIdColumn,
            this.makeDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.runtimeHoursDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.windFarmIdDataGridViewTextBoxColumn});
            this.dataGVTrubinStats.DataSource = this.turbinesBindingSource;
            this.dataGVTrubinStats.Location = new System.Drawing.Point(264, 62);
            this.dataGVTrubinStats.Name = "dataGVTrubinStats";
            this.dataGVTrubinStats.Size = new System.Drawing.Size(628, 252);
            this.dataGVTrubinStats.TabIndex = 33;
            this.dataGVTrubinStats.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVTrubinStats_CellClick);
            // 
            // turbineIdColumn
            // 
            this.turbineIdColumn.DataPropertyName = "TurbineId";
            this.turbineIdColumn.HeaderText = "TurbineId";
            this.turbineIdColumn.Name = "turbineIdColumn";
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // runtimeHoursDataGridViewTextBoxColumn
            // 
            this.runtimeHoursDataGridViewTextBoxColumn.DataPropertyName = "RuntimeHours";
            this.runtimeHoursDataGridViewTextBoxColumn.HeaderText = "RuntimeHours";
            this.runtimeHoursDataGridViewTextBoxColumn.Name = "runtimeHoursDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // windFarmIdDataGridViewTextBoxColumn
            // 
            this.windFarmIdDataGridViewTextBoxColumn.DataPropertyName = "WindFarmId";
            this.windFarmIdDataGridViewTextBoxColumn.HeaderText = "WindFarmId";
            this.windFarmIdDataGridViewTextBoxColumn.Name = "windFarmIdDataGridViewTextBoxColumn";
            // 
            // turbinesBindingSource
            // 
            this.turbinesBindingSource.DataMember = "Turbines";
            this.turbinesBindingSource.DataSource = this.aTS_WindSyncDBDataSet;
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
            this.panel1.Controls.Add(this.dtpDateRecorded);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNewHr);
            this.panel1.Controls.Add(this.txtCurrentHr);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboWIndFarms);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 413);
            this.panel1.TabIndex = 34;
            // 
            // frmTurbSimData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::ATS_Group3_Project.Properties.Resources.ATS_Background1_jpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(986, 613);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGVTrubinStats);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAutoJobService);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTurbSimData";
            this.Text = "Turbine Simulation Data";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.frmTurbSimData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTrubinStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTS_WindSyncDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTSWindSyncDBDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCurrentHr;
        private System.Windows.Forms.TextBox txtNewHr;
        private System.Windows.Forms.TextBox txtAutoJobService;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDateRecorded;
        private System.Windows.Forms.ComboBox cboWIndFarms;
        private System.Windows.Forms.DataGridView dataGVTrubinStats;
        private ATS_WindSyncDBDataSet aTS_WindSyncDBDataSet;
        private System.Windows.Forms.BindingSource turbinesBindingSource;
        private ATS_WindSyncDBDataSetTableAdapters.TurbinesTableAdapter turbinesTableAdapter;
        private System.Windows.Forms.BindingSource aTSWindSyncDBDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn turbineIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runtimeHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windFarmIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}