namespace ATS_Group3_Project.Views
{
    partial class frmCallHandler
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSimulationDashboard = new System.Windows.Forms.Button();
            this.btnAddTurbine = new System.Windows.Forms.Button();
            this.btnAddWindFarm = new System.Windows.Forms.Button();
            this.btnLogFaultJob = new System.Windows.Forms.Button();
            this.btnAddShifts = new System.Windows.Forms.Button();
            this.btnViewAllJobs = new System.Windows.Forms.Button();
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATS_Group3_Project.Properties.Resources.profile_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Location = new System.Drawing.Point(122, 48);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(71, 16);
            this.lblGreetings.TabIndex = 1;
            this.lblGreetings.Text = "Greetings, ";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(122, 77);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 16);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ATS_Group3_Project.Properties.Resources.Company_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(606, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(330, 320);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnSimulationDashboard
            // 
            this.btnSimulationDashboard.Location = new System.Drawing.Point(283, 211);
            this.btnSimulationDashboard.Name = "btnSimulationDashboard";
            this.btnSimulationDashboard.Size = new System.Drawing.Size(274, 80);
            this.btnSimulationDashboard.TabIndex = 4;
            this.btnSimulationDashboard.Text = "Simulation Dashboard";
            this.btnSimulationDashboard.UseVisualStyleBackColor = true;
            this.btnSimulationDashboard.Click += new System.EventHandler(this.btnSimulationDashboard_Click);
            // 
            // btnAddTurbine
            // 
            this.btnAddTurbine.Location = new System.Drawing.Point(283, 451);
            this.btnAddTurbine.Name = "btnAddTurbine";
            this.btnAddTurbine.Size = new System.Drawing.Size(274, 80);
            this.btnAddTurbine.TabIndex = 5;
            this.btnAddTurbine.Text = "Add Turbine";
            this.btnAddTurbine.UseVisualStyleBackColor = true;
            // 
            // btnAddWindFarm
            // 
            this.btnAddWindFarm.Location = new System.Drawing.Point(283, 326);
            this.btnAddWindFarm.Name = "btnAddWindFarm";
            this.btnAddWindFarm.Size = new System.Drawing.Size(274, 80);
            this.btnAddWindFarm.TabIndex = 6;
            this.btnAddWindFarm.Text = "Add Windfarm";
            this.btnAddWindFarm.UseVisualStyleBackColor = true;
            this.btnAddWindFarm.Click += new System.EventHandler(this.btnAddWindFarm_Click);
            // 
            // btnLogFaultJob
            // 
            this.btnLogFaultJob.Location = new System.Drawing.Point(982, 211);
            this.btnLogFaultJob.Name = "btnLogFaultJob";
            this.btnLogFaultJob.Size = new System.Drawing.Size(274, 80);
            this.btnLogFaultJob.TabIndex = 7;
            this.btnLogFaultJob.Text = "Log Fault Job";
            this.btnLogFaultJob.UseVisualStyleBackColor = true;
            this.btnLogFaultJob.Click += new System.EventHandler(this.btnLogFaultJob_Click);
            // 
            // btnAddShifts
            // 
            this.btnAddShifts.Location = new System.Drawing.Point(982, 326);
            this.btnAddShifts.Name = "btnAddShifts";
            this.btnAddShifts.Size = new System.Drawing.Size(274, 80);
            this.btnAddShifts.TabIndex = 8;
            this.btnAddShifts.Text = "Add Shifts";
            this.btnAddShifts.UseVisualStyleBackColor = true;
            // 
            // btnViewAllJobs
            // 
            this.btnViewAllJobs.Location = new System.Drawing.Point(982, 451);
            this.btnViewAllJobs.Name = "btnViewAllJobs";
            this.btnViewAllJobs.Size = new System.Drawing.Size(274, 80);
            this.btnViewAllJobs.TabIndex = 9;
            this.btnViewAllJobs.Text = "View All Jobs";
            this.btnViewAllJobs.UseVisualStyleBackColor = true;
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.Location = new System.Drawing.Point(635, 568);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(274, 80);
            this.btnManageAccount.TabIndex = 10;
            this.btnManageAccount.Text = "Manage Account ";
            this.btnManageAccount.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogOut.Location = new System.Drawing.Point(1370, 891);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(100, 50);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmCallHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATS_Group3_Project.Properties.Resources.ATS_Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnManageAccount);
            this.Controls.Add(this.btnViewAllJobs);
            this.Controls.Add(this.btnAddShifts);
            this.Controls.Add(this.btnLogFaultJob);
            this.Controls.Add(this.btnAddWindFarm);
            this.Controls.Add(this.btnAddTurbine);
            this.Controls.Add(this.btnSimulationDashboard);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCallHandler";
            this.Text = "frmCallHandler";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSimulationDashboard;
        private System.Windows.Forms.Button btnAddTurbine;
        private System.Windows.Forms.Button btnAddWindFarm;
        private System.Windows.Forms.Button btnLogFaultJob;
        private System.Windows.Forms.Button btnAddShifts;
        private System.Windows.Forms.Button btnViewAllJobs;
        private System.Windows.Forms.Button btnManageAccount;
        private System.Windows.Forms.Button btnLogOut;
    }
}