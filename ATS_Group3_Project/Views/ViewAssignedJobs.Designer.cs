namespace ATS_Group3_Project
{
    partial class ViewAssignedJobs
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
            this.lstAvailableJobs = new System.Windows.Forms.ListBox();
            this.lblAvailableJobs = new System.Windows.Forms.Label();
            this.lblCompletedJobs = new System.Windows.Forms.Label();
            this.lstCompletedJobs = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAvailableJobs
            // 
            this.lstAvailableJobs.FormattingEnabled = true;
            this.lstAvailableJobs.ItemHeight = 16;
            this.lstAvailableJobs.Location = new System.Drawing.Point(126, 192);
            this.lstAvailableJobs.Name = "lstAvailableJobs";
            this.lstAvailableJobs.Size = new System.Drawing.Size(350, 340);
            this.lstAvailableJobs.TabIndex = 0;
            // 
            // lblAvailableJobs
            // 
            this.lblAvailableJobs.AutoSize = true;
            this.lblAvailableJobs.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableJobs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAvailableJobs.Location = new System.Drawing.Point(123, 163);
            this.lblAvailableJobs.Name = "lblAvailableJobs";
            this.lblAvailableJobs.Size = new System.Drawing.Size(97, 16);
            this.lblAvailableJobs.TabIndex = 1;
            this.lblAvailableJobs.Text = "Available Jobs";
            // 
            // lblCompletedJobs
            // 
            this.lblCompletedJobs.AutoSize = true;
            this.lblCompletedJobs.BackColor = System.Drawing.Color.Transparent;
            this.lblCompletedJobs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCompletedJobs.Location = new System.Drawing.Point(732, 163);
            this.lblCompletedJobs.Name = "lblCompletedJobs";
            this.lblCompletedJobs.Size = new System.Drawing.Size(106, 16);
            this.lblCompletedJobs.TabIndex = 2;
            this.lblCompletedJobs.Text = "Completed Jobs";
            // 
            // lstCompletedJobs
            // 
            this.lstCompletedJobs.FormattingEnabled = true;
            this.lstCompletedJobs.ItemHeight = 16;
            this.lstCompletedJobs.Location = new System.Drawing.Point(735, 192);
            this.lstCompletedJobs.Name = "lstCompletedJobs";
            this.lstCompletedJobs.Size = new System.Drawing.Size(350, 340);
            this.lstCompletedJobs.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Assign Engineer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ATS_Group3_Project.Properties.Resources.ATS_Logo_NoText;
            this.pictureBox2.Location = new System.Drawing.Point(1278, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(12, 12);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(216, 32);
            this.lblCompanyName.TabIndex = 7;
            this.lblCompanyName.Text = "WindSync ATS";
            // 
            // ViewAssignedJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATS_Group3_Project.Properties.Resources.ATS_Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1440, 753);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstCompletedJobs);
            this.Controls.Add(this.lblCompletedJobs);
            this.Controls.Add(this.lblAvailableJobs);
            this.Controls.Add(this.lstAvailableJobs);
            this.Name = "ViewAssignedJobs";
            this.Text = "ViewAssignedJobs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAvailableJobs;
        private System.Windows.Forms.Label lblAvailableJobs;
        private System.Windows.Forms.Label lblCompletedJobs;
        private System.Windows.Forms.ListBox lstCompletedJobs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCompanyName;
    }
}