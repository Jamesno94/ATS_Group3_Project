namespace ATS_Group3_Project
{
    partial class frmDashboard
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
            this.btnAddFaultJob = new System.Windows.Forms.Button();
            this.btnViewAssignedJobs = new System.Windows.Forms.Button();
            this.btnAddTurbineSimulationData = new System.Windows.Forms.Button();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRegisterNewAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ATS_Group3_Project.Properties.Resources.Company_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(455, 172);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddFaultJob
            // 
            this.btnAddFaultJob.Location = new System.Drawing.Point(214, 172);
            this.btnAddFaultJob.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddFaultJob.Name = "btnAddFaultJob";
            this.btnAddFaultJob.Size = new System.Drawing.Size(205, 65);
            this.btnAddFaultJob.TabIndex = 1;
            this.btnAddFaultJob.Text = "Add Fault Jobs";
            this.btnAddFaultJob.UseVisualStyleBackColor = true;
            this.btnAddFaultJob.Click += new System.EventHandler(this.btnAddFaultJob_Click);
            // 
            // btnViewAssignedJobs
            // 
            this.btnViewAssignedJobs.Location = new System.Drawing.Point(214, 266);
            this.btnViewAssignedJobs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnViewAssignedJobs.Name = "btnViewAssignedJobs";
            this.btnViewAssignedJobs.Size = new System.Drawing.Size(205, 65);
            this.btnViewAssignedJobs.TabIndex = 2;
            this.btnViewAssignedJobs.Text = "View Assigned Jobs";
            this.btnViewAssignedJobs.UseVisualStyleBackColor = true;
            this.btnViewAssignedJobs.Click += new System.EventHandler(this.btnViewAssignedJobs_Click);
            // 
            // btnAddTurbineSimulationData
            // 
            this.btnAddTurbineSimulationData.Location = new System.Drawing.Point(214, 361);
            this.btnAddTurbineSimulationData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddTurbineSimulationData.Name = "btnAddTurbineSimulationData";
            this.btnAddTurbineSimulationData.Size = new System.Drawing.Size(205, 65);
            this.btnAddTurbineSimulationData.TabIndex = 3;
            this.btnAddTurbineSimulationData.Text = "Add Turbine Simulation Data";
            this.btnAddTurbineSimulationData.UseVisualStyleBackColor = true;
            this.btnAddTurbineSimulationData.Click += new System.EventHandler(this.btnAddTurbineSimulationData_Click);
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Location = new System.Drawing.Point(91, 39);
            this.lblGreetings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(55, 13);
            this.lblGreetings.TabIndex = 4;
            this.lblGreetings.Text = "Greetings ";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(91, 62);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(32, 13);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Role:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::ATS_Group3_Project.Properties.Resources.profile_icon;
            this.pictureBox2.Location = new System.Drawing.Point(9, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnRegisterNewAccount
            // 
            this.btnRegisterNewAccount.Location = new System.Drawing.Point(727, 266);
            this.btnRegisterNewAccount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRegisterNewAccount.Name = "btnRegisterNewAccount";
            this.btnRegisterNewAccount.Size = new System.Drawing.Size(205, 65);
            this.btnRegisterNewAccount.TabIndex = 7;
            this.btnRegisterNewAccount.Text = "Register New Account";
            this.btnRegisterNewAccount.UseVisualStyleBackColor = true;
            this.btnRegisterNewAccount.Click += new System.EventHandler(this.btnRegisterNewAccount_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATS_Group3_Project.Properties.Resources.ATS_Background1_jpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 614);
            this.Controls.Add(this.btnRegisterNewAccount);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.btnAddTurbineSimulationData);
            this.Controls.Add(this.btnViewAssignedJobs);
            this.Controls.Add(this.btnAddFaultJob);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddFaultJob;
        private System.Windows.Forms.Button btnViewAssignedJobs;
        private System.Windows.Forms.Button btnAddTurbineSimulationData;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRegisterNewAccount;
    }
}