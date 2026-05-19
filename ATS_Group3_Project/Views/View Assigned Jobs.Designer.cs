namespace ATS_Group3_Project
{
    partial class frmViewAssignedJobs
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
            this.btnOpenJobDetails = new System.Windows.Forms.Button();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.DataGVJobs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenJobDetails
            // 
            this.btnOpenJobDetails.Location = new System.Drawing.Point(952, 462);
            this.btnOpenJobDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenJobDetails.Name = "btnOpenJobDetails";
            this.btnOpenJobDetails.Size = new System.Drawing.Size(99, 41);
            this.btnOpenJobDetails.TabIndex = 4;
            this.btnOpenJobDetails.Text = "Open Job Details";
            this.btnOpenJobDetails.UseVisualStyleBackColor = true;
            this.btnOpenJobDetails.Click += new System.EventHandler(this.btnOpenJobDetails_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(9, 10);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(171, 26);
            this.lblCompanyName.TabIndex = 7;
            this.lblCompanyName.Text = "WindSync ATS";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(71, 462);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 41);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DataGVJobs
            // 
            this.DataGVJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVJobs.Location = new System.Drawing.Point(71, 94);
            this.DataGVJobs.Name = "DataGVJobs";
            this.DataGVJobs.Size = new System.Drawing.Size(980, 328);
            this.DataGVJobs.TabIndex = 11;
            // 
            // frmViewAssignedJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATS_Group3_Project.Properties.Resources.ATS_Background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 541);
            this.Controls.Add(this.DataGVJobs);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.btnOpenJobDetails);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmViewAssignedJobs";
            this.Text = "View Assigned Jobs";
            this.Load += new System.EventHandler(this.frmViewAssignedJobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpenJobDetails;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView DataGVJobs;
    }
}