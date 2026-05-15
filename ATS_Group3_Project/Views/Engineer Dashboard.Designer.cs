namespace ATS_Group3_Project.Views
{
    partial class frmEngineerDashboard
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
            this.lblGreetings = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnViewAssignedJobs = new System.Windows.Forms.Button();
            this.btnCompleteJob = new System.Windows.Forms.Button();
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.lnklblLogout = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Location = new System.Drawing.Point(92, 39);
            this.lblGreetings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(0, 13);
            this.lblGreetings.TabIndex = 1;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(92, 63);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(0, 13);
            this.lblRole.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ATS_Group3_Project.Properties.Resources.Company_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(9, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnViewAssignedJobs
            // 
            this.btnViewAssignedJobs.Location = new System.Drawing.Point(404, 293);
            this.btnViewAssignedJobs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewAssignedJobs.Name = "btnViewAssignedJobs";
            this.btnViewAssignedJobs.Size = new System.Drawing.Size(206, 65);
            this.btnViewAssignedJobs.TabIndex = 5;
            this.btnViewAssignedJobs.Text = "View Assigned Jobs";
            this.btnViewAssignedJobs.UseVisualStyleBackColor = true;
            this.btnViewAssignedJobs.Click += new System.EventHandler(this.btnViewAssignedJobs_Click);
            // 
            // btnCompleteJob
            // 
            this.btnCompleteJob.Location = new System.Drawing.Point(404, 379);
            this.btnCompleteJob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCompleteJob.Name = "btnCompleteJob";
            this.btnCompleteJob.Size = new System.Drawing.Size(206, 65);
            this.btnCompleteJob.TabIndex = 6;
            this.btnCompleteJob.Text = "Complete Job";
            this.btnCompleteJob.UseVisualStyleBackColor = true;
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.Location = new System.Drawing.Point(404, 210);
            this.btnManageAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(206, 65);
            this.btnManageAccount.TabIndex = 7;
            this.btnManageAccount.Text = "Manage Account ";
            this.btnManageAccount.UseVisualStyleBackColor = true;
            // 
            // lnklblLogout
            // 
            this.lnklblLogout.AutoSize = true;
            this.lnklblLogout.BackColor = System.Drawing.Color.Transparent;
            this.lnklblLogout.LinkColor = System.Drawing.Color.Black;
            this.lnklblLogout.Location = new System.Drawing.Point(942, 9);
            this.lnklblLogout.Name = "lnklblLogout";
            this.lnklblLogout.Size = new System.Drawing.Size(40, 13);
            this.lnklblLogout.TabIndex = 8;
            this.lnklblLogout.TabStop = true;
            this.lnklblLogout.Text = "Logout";
            // 
            // frmEngineerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATS_Group3_Project.Properties.Resources.ATS_Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 614);
            this.Controls.Add(this.lnklblLogout);
            this.Controls.Add(this.btnManageAccount);
            this.Controls.Add(this.btnCompleteJob);
            this.Controls.Add(this.btnViewAssignedJobs);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblGreetings);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEngineerDashboard";
            this.Text = "Engineer Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnViewAssignedJobs;
        private System.Windows.Forms.Button btnCompleteJob;
        private System.Windows.Forms.Button btnManageAccount;
        private System.Windows.Forms.LinkLabel lnklblLogout;
    }
}