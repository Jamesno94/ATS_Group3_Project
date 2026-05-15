namespace ATS_Group3_Project
{
    partial class frmAddFaultJob
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
            this.lblJobType = new System.Windows.Forms.Label();
            this.lblWindfarm = new System.Windows.Forms.Label();
            this.lblTurbine = new System.Windows.Forms.Label();
            this.lblFaultDescription = new System.Windows.Forms.Label();
            this.txtJobType = new System.Windows.Forms.TextBox();
            this.txtFaultDescription = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewAllJobs = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTurbineId = new System.Windows.Forms.TextBox();
            this.txtWindFarmId = new System.Windows.Forms.TextBox();
            this.btnCreateJob = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
           // ((System.ComponentModel.ISupportInitialize)(this.DashboardLogoClick)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJobType
            // 
            this.lblJobType.AutoSize = true;
            this.lblJobType.BackColor = System.Drawing.Color.Transparent;
            this.lblJobType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobType.ForeColor = System.Drawing.Color.Black;
            this.lblJobType.Location = new System.Drawing.Point(16, 73);
            this.lblJobType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJobType.Name = "lblJobType";
            this.lblJobType.Size = new System.Drawing.Size(94, 24);
            this.lblJobType.TabIndex = 0;
            this.lblJobType.Text = "Job Type:";
            // 
            // lblWindfarm
            // 
            this.lblWindfarm.AutoSize = true;
            this.lblWindfarm.BackColor = System.Drawing.Color.Transparent;
            this.lblWindfarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindfarm.ForeColor = System.Drawing.Color.Black;
            this.lblWindfarm.Location = new System.Drawing.Point(16, 108);
            this.lblWindfarm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWindfarm.Name = "lblWindfarm";
            this.lblWindfarm.Size = new System.Drawing.Size(128, 24);
            this.lblWindfarm.TabIndex = 1;
            this.lblWindfarm.Text = "Wind Farm Id:";
            // 
            // lblTurbine
            // 
            this.lblTurbine.AutoSize = true;
            this.lblTurbine.BackColor = System.Drawing.Color.Transparent;
            this.lblTurbine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurbine.ForeColor = System.Drawing.Color.Black;
            this.lblTurbine.Location = new System.Drawing.Point(18, 143);
            this.lblTurbine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurbine.Name = "lblTurbine";
            this.lblTurbine.Size = new System.Drawing.Size(101, 24);
            this.lblTurbine.TabIndex = 2;
            this.lblTurbine.Text = "Turbine Id:";
            // 
            // lblFaultDescription
            // 
            this.lblFaultDescription.AutoSize = true;
            this.lblFaultDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblFaultDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaultDescription.ForeColor = System.Drawing.Color.Black;
            this.lblFaultDescription.Location = new System.Drawing.Point(16, 189);
            this.lblFaultDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFaultDescription.Name = "lblFaultDescription";
            this.lblFaultDescription.Size = new System.Drawing.Size(155, 24);
            this.lblFaultDescription.TabIndex = 5;
            this.lblFaultDescription.Text = "Fault Description:";
            // 
            // txtJobType
            // 
            this.txtJobType.BackColor = System.Drawing.Color.Azure;
            this.txtJobType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobType.Location = new System.Drawing.Point(143, 70);
            this.txtJobType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtJobType.Name = "txtJobType";
            this.txtJobType.ReadOnly = true;
            this.txtJobType.Size = new System.Drawing.Size(148, 29);
            this.txtJobType.TabIndex = 9;
            this.txtJobType.Text = "Fault";
            // 
            // txtFaultDescription
            // 
            this.txtFaultDescription.BackColor = System.Drawing.Color.Azure;
            this.txtFaultDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaultDescription.Location = new System.Drawing.Point(20, 216);
            this.txtFaultDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFaultDescription.Multiline = true;
            this.txtFaultDescription.Name = "txtFaultDescription";
            this.txtFaultDescription.Size = new System.Drawing.Size(387, 162);
            this.txtFaultDescription.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ATS_Group3_Project.Properties.Resources.Company_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(635, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.Lime;
            this.btnSaveChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveChanges.Location = new System.Drawing.Point(1013, 807);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(90, 40);
            this.btnSaveChanges.TabIndex = 19;
            this.btnSaveChanges.Text = "SAVE CHANGES";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(9, 399);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(0, 0);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DashboardLogoClick
            // 
            //this.DashboardLogoClick.BackColor = System.Drawing.Color.Transparent;
            //this.DashboardLogoClick.Image = global::ATS_Group3_Project.Properties.Resources.ATS_Logo_NoText;
            //this.DashboardLogoClick.Location = new System.Drawing.Point(990, 10);
            //this.DashboardLogoClick.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            //this.DashboardLogoClick.Name = "DashboardLogoClick";
            //this.DashboardLogoClick.Size = new System.Drawing.Size(113, 122);
            //this.DashboardLogoClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            //this.DashboardLogoClick.TabIndex = 21;
            //this.DashboardLogoClick.TabStop = false;
            //this.DashboardLogoClick.Click += new System.EventHandler(this.DashboardLogoClick_Click);
            //// 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(9, 10);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(171, 26);
            this.lblCompanyName.TabIndex = 22;
            this.lblCompanyName.Text = "WindSync ATS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnViewAllJobs);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTurbineId);
            this.panel1.Controls.Add(this.txtWindFarmId);
            this.panel1.Controls.Add(this.btnCreateJob);
            this.panel1.Controls.Add(this.txtFaultDescription);
            this.panel1.Controls.Add(this.txtJobType);
            this.panel1.Controls.Add(this.lblFaultDescription);
            this.panel1.Controls.Add(this.lblTurbine);
            this.panel1.Controls.Add(this.lblWindfarm);
            this.panel1.Controls.Add(this.lblJobType);
            this.panel1.Location = new System.Drawing.Point(60, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 457);
            this.panel1.TabIndex = 23;
            // 
            // btnViewAllJobs
            // 
            this.btnViewAllJobs.BackColor = System.Drawing.Color.Azure;
            this.btnViewAllJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllJobs.Location = new System.Drawing.Point(171, 393);
            this.btnViewAllJobs.Name = "btnViewAllJobs";
            this.btnViewAllJobs.Size = new System.Drawing.Size(99, 43);
            this.btnViewAllJobs.TabIndex = 26;
            this.btnViewAllJobs.Text = "View All Jobs";
            this.btnViewAllJobs.UseVisualStyleBackColor = false;
            this.btnViewAllJobs.Click += new System.EventHandler(this.btnViewAllJobs_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Azure;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(295, 393);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 43);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Logging a Fault";
            // 
            // txtTurbineId
            // 
            this.txtTurbineId.BackColor = System.Drawing.Color.Azure;
            this.txtTurbineId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurbineId.Location = new System.Drawing.Point(143, 140);
            this.txtTurbineId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTurbineId.Name = "txtTurbineId";
            this.txtTurbineId.ReadOnly = true;
            this.txtTurbineId.Size = new System.Drawing.Size(148, 29);
            this.txtTurbineId.TabIndex = 23;
            // 
            // txtWindFarmId
            // 
            this.txtWindFarmId.BackColor = System.Drawing.Color.Azure;
            this.txtWindFarmId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWindFarmId.Location = new System.Drawing.Point(143, 105);
            this.txtWindFarmId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtWindFarmId.Name = "txtWindFarmId";
            this.txtWindFarmId.ReadOnly = true;
            this.txtWindFarmId.Size = new System.Drawing.Size(148, 29);
            this.txtWindFarmId.TabIndex = 22;
            // 
            // btnCreateJob
            // 
            this.btnCreateJob.BackColor = System.Drawing.Color.Azure;
            this.btnCreateJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateJob.Location = new System.Drawing.Point(45, 393);
            this.btnCreateJob.Name = "btnCreateJob";
            this.btnCreateJob.Size = new System.Drawing.Size(99, 43);
            this.btnCreateJob.TabIndex = 19;
            this.btnCreateJob.Text = "Create Job";
            this.btnCreateJob.UseVisualStyleBackColor = false;
            this.btnCreateJob.Click += new System.EventHandler(this.btnCreateJob_Click);
            // 
            // frmAddFaultJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATS_Group3_Project.Properties.Resources.ATS_Background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddFaultJob";
            this.Text = "Add Fault Job";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.DashboardLogoClick)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJobType;
        private System.Windows.Forms.Label lblWindfarm;
        private System.Windows.Forms.Label lblTurbine;
        private System.Windows.Forms.Label lblFaultDescription;
        private System.Windows.Forms.TextBox txtJobType;
        private System.Windows.Forms.TextBox txtFaultDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateJob;
        private System.Windows.Forms.TextBox txtTurbineId;
        private System.Windows.Forms.TextBox txtWindFarmId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewAllJobs;
        private System.Windows.Forms.Button btnBack;
    }
}