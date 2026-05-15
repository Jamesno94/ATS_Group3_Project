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
            this.DataGVJobs = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenJobDetails
            // 
            this.btnOpenJobDetails.Location = new System.Drawing.Point(972, 574);
            this.btnOpenJobDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenJobDetails.Name = "btnOpenJobDetails";
            this.btnOpenJobDetails.Size = new System.Drawing.Size(99, 41);
            this.btnOpenJobDetails.TabIndex = 4;
            this.btnOpenJobDetails.Text = "Open Job Details";
            this.btnOpenJobDetails.UseVisualStyleBackColor = true;
            this.btnOpenJobDetails.Click += new System.EventHandler(this.btnOpenJobDetails_Click);
            this.lstAvailableJobs.FormattingEnabled = true;
            this.lstAvailableJobs.Location = new System.Drawing.Point(95, 156);
            this.lstAvailableJobs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstAvailableJobs.Name = "lstAvailableJobs";
            this.lstAvailableJobs.Size = new System.Drawing.Size(263, 277);
            this.lstAvailableJobs.TabIndex = 0;
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
            this.lblAvailableJobs.AutoSize = true;
            this.lblAvailableJobs.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableJobs.ForeColor = System.Drawing.Color.Black;
            this.lblAvailableJobs.Location = new System.Drawing.Point(92, 133);
            this.lblAvailableJobs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailableJobs.Name = "lblAvailableJobs";
            this.lblAvailableJobs.Size = new System.Drawing.Size(75, 13);
            this.lblAvailableJobs.TabIndex = 1;
            this.lblAvailableJobs.Text = "Available Jobs";
            // 
            // DataGVJobs
            // 
            this.DataGVJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DataGVJobs.Location = new System.Drawing.Point(130, 98);
            this.DataGVJobs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGVJobs.Name = "DataGVJobs";
            this.DataGVJobs.RowHeadersWidth = 51;
            this.DataGVJobs.RowTemplate.Height = 24;
            this.DataGVJobs.Size = new System.Drawing.Size(821, 272);
            this.DataGVJobs.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Job ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Turbine";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Wind Farm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Type";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 125;
            this.lblCompletedJobs.AutoSize = true;
            this.lblCompletedJobs.BackColor = System.Drawing.Color.Transparent;
            this.lblCompletedJobs.ForeColor = System.Drawing.Color.Black;
            this.lblCompletedJobs.Location = new System.Drawing.Point(549, 133);
            this.lblCompletedJobs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompletedJobs.Name = "lblCompletedJobs";
            this.lblCompletedJobs.Size = new System.Drawing.Size(82, 13);
            this.lblCompletedJobs.TabIndex = 2;
            this.lblCompletedJobs.Text = "Completed Jobs";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Description";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            this.lstCompletedJobs.FormattingEnabled = true;
            this.lstCompletedJobs.Location = new System.Drawing.Point(551, 156);
            this.lstCompletedJobs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstCompletedJobs.Name = "lstCompletedJobs";
            this.lstCompletedJobs.Size = new System.Drawing.Size(263, 277);
            this.lstCompletedJobs.TabIndex = 3;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Status";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            this.button1.Location = new System.Drawing.Point(95, 458);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Assign Engineer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(9, 591);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 24);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ATS_Group3_Project.Properties.Resources.ATS_Logo_NoText;
            this.pictureBox2.Location = new System.Drawing.Point(874, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(500, 427);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 37);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
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
            // frmViewAssignedJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATS_Group3_Project.Properties.Resources.ATS_Background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 625);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.DataGVJobs);
            this.ClientSize = new System.Drawing.Size(985, 614);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.btnOpenJobDetails);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstCompletedJobs);
            this.Controls.Add(this.lblCompletedJobs);
            this.Controls.Add(this.lblAvailableJobs);
            this.Controls.Add(this.lstAvailableJobs);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmViewAssignedJobs";
            this.Text = "View Assigned Jobs";
            ((System.ComponentModel.ISupportInitialize)(this.DataGVJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpenJobDetails;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.DataGridView DataGVJobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefresh;
    }
}