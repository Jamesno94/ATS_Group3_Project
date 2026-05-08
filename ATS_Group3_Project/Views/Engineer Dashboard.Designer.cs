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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnViewJobs = new System.Windows.Forms.Button();
            this.btnJobDiary = new System.Windows.Forms.Button();
            this.btnCompleteJob = new System.Windows.Forms.Button();
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATS_Group3_Project.Properties.Resources.profile_icon;
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.pictureBox2.Location = new System.Drawing.Point(454, 171);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(248, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnViewJobs
            // 
            this.btnViewJobs.Location = new System.Drawing.Point(208, 266);
            this.btnViewJobs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewJobs.Name = "btnViewJobs";
            this.btnViewJobs.Size = new System.Drawing.Size(206, 65);
            this.btnViewJobs.TabIndex = 4;
            this.btnViewJobs.Text = "View Jobs";
            this.btnViewJobs.UseVisualStyleBackColor = true;
            // 
            // btnJobDiary
            // 
            this.btnJobDiary.Location = new System.Drawing.Point(208, 171);
            this.btnJobDiary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJobDiary.Name = "btnJobDiary";
            this.btnJobDiary.Size = new System.Drawing.Size(206, 65);
            this.btnJobDiary.TabIndex = 5;
            this.btnJobDiary.Text = "View Job Diary";
            this.btnJobDiary.UseVisualStyleBackColor = true;
            // 
            // btnCompleteJob
            // 
            this.btnCompleteJob.Location = new System.Drawing.Point(208, 366);
            this.btnCompleteJob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCompleteJob.Name = "btnCompleteJob";
            this.btnCompleteJob.Size = new System.Drawing.Size(206, 65);
            this.btnCompleteJob.TabIndex = 6;
            this.btnCompleteJob.Text = "Complete Job";
            this.btnCompleteJob.UseVisualStyleBackColor = true;
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.Location = new System.Drawing.Point(737, 171);
            this.btnManageAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(206, 65);
            this.btnManageAccount.TabIndex = 7;
            this.btnManageAccount.Text = "Manage Account ";
            this.btnManageAccount.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogOut.Location = new System.Drawing.Point(899, 562);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 41);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmEngineerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATS_Group3_Project.Properties.Resources.ATS_Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 614);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnManageAccount);
            this.Controls.Add(this.btnCompleteJob);
            this.Controls.Add(this.btnJobDiary);
            this.Controls.Add(this.btnViewJobs);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEngineerDashboard";
            this.Text = "EngineerDashboard";
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
        private System.Windows.Forms.Button btnViewJobs;
        private System.Windows.Forms.Button btnJobDiary;
        private System.Windows.Forms.Button btnCompleteJob;
        private System.Windows.Forms.Button btnManageAccount;
        private System.Windows.Forms.Button btnLogOut;
    }
}