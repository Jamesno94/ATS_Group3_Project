namespace ATS_Group3_Project
{
    partial class Dashboard
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
            this.pictureBox1.Image = global::ATS_Group3_Project.Properties.Resources.Company_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(606, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddFaultJob
            // 
            this.btnAddFaultJob.Location = new System.Drawing.Point(285, 211);
            this.btnAddFaultJob.Name = "btnAddFaultJob";
            this.btnAddFaultJob.Size = new System.Drawing.Size(274, 80);
            this.btnAddFaultJob.TabIndex = 1;
            this.btnAddFaultJob.Text = "Add Fault Jobs";
            this.btnAddFaultJob.UseVisualStyleBackColor = true;
            this.btnAddFaultJob.Click += new System.EventHandler(this.btnAddFaultJob_Click);
            // 
            // btnViewAssignedJobs
            // 
            this.btnViewAssignedJobs.Location = new System.Drawing.Point(285, 328);
            this.btnViewAssignedJobs.Name = "btnViewAssignedJobs";
            this.btnViewAssignedJobs.Size = new System.Drawing.Size(274, 80);
            this.btnViewAssignedJobs.TabIndex = 2;
            this.btnViewAssignedJobs.Text = "View Assigned Jobs";
            this.btnViewAssignedJobs.UseVisualStyleBackColor = true;
            this.btnViewAssignedJobs.Click += new System.EventHandler(this.btnViewAssignedJobs_Click);
            // 
            // btnAddTurbineSimulationData
            // 
            this.btnAddTurbineSimulationData.Location = new System.Drawing.Point(285, 445);
            this.btnAddTurbineSimulationData.Name = "btnAddTurbineSimulationData";
            this.btnAddTurbineSimulationData.Size = new System.Drawing.Size(274, 80);
            this.btnAddTurbineSimulationData.TabIndex = 3;
            this.btnAddTurbineSimulationData.Text = "Add Turbine Simulation Data";
            this.btnAddTurbineSimulationData.UseVisualStyleBackColor = true;
            this.btnAddTurbineSimulationData.Click += new System.EventHandler(this.btnAddTurbineSimulationData_Click);
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Location = new System.Drawing.Point(122, 48);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(71, 16);
            this.lblGreetings.TabIndex = 4;
            this.lblGreetings.Text = "Greetings, ";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(122, 77);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(42, 16);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Role: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ATS_Group3_Project.Properties.Resources.profile_icon;
            this.pictureBox2.Location = new System.Drawing.Point(12, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnRegisterNewAccount
            // 
            this.btnRegisterNewAccount.Location = new System.Drawing.Point(969, 328);
            this.btnRegisterNewAccount.Name = "btnRegisterNewAccount";
            this.btnRegisterNewAccount.Size = new System.Drawing.Size(274, 80);
            this.btnRegisterNewAccount.TabIndex = 7;
            this.btnRegisterNewAccount.Text = "Register New Account";
            this.btnRegisterNewAccount.UseVisualStyleBackColor = true;
            this.btnRegisterNewAccount.Click += new System.EventHandler(this.btnRegisterNewAccount_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATS_Group3_Project.Properties.Resources.ATS_Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.btnRegisterNewAccount);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.btnAddTurbineSimulationData);
            this.Controls.Add(this.btnViewAssignedJobs);
            this.Controls.Add(this.btnAddFaultJob);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dashboard";
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