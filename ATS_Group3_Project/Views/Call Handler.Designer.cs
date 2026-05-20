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
            this.btnSimulationDashboard = new System.Windows.Forms.Button();
            this.btnAddTurbine = new System.Windows.Forms.Button();
            this.btnViewAllJobs = new System.Windows.Forms.Button();
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogO = new System.Windows.Forms.Button();
            this.btnBackToAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ATS_Group3_Project.Properties.Resources.profile_icon;
            this.pictureBox1.Location = new System.Drawing.Point(607, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Location = new System.Drawing.Point(690, 40);
            this.lblGreetings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(58, 13);
            this.lblGreetings.TabIndex = 1;
            this.lblGreetings.Text = "Greetings, ";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(690, 64);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(32, 13);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role:";
            // 
            // btnSimulationDashboard
            // 
            this.btnSimulationDashboard.BackColor = System.Drawing.Color.Azure;
            this.btnSimulationDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulationDashboard.Location = new System.Drawing.Point(32, 44);
            this.btnSimulationDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimulationDashboard.Name = "btnSimulationDashboard";
            this.btnSimulationDashboard.Size = new System.Drawing.Size(206, 65);
            this.btnSimulationDashboard.TabIndex = 4;
            this.btnSimulationDashboard.Text = "Simulation Dashboard";
            this.btnSimulationDashboard.UseVisualStyleBackColor = false;
            this.btnSimulationDashboard.Click += new System.EventHandler(this.btnSimulationDashboard_Click);
            // 
            // btnAddTurbine
            // 
            this.btnAddTurbine.BackColor = System.Drawing.Color.Azure;
            this.btnAddTurbine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTurbine.Location = new System.Drawing.Point(32, 140);
            this.btnAddTurbine.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTurbine.Name = "btnAddTurbine";
            this.btnAddTurbine.Size = new System.Drawing.Size(206, 65);
            this.btnAddTurbine.TabIndex = 5;
            this.btnAddTurbine.Text = "Manage Windfarms";
            this.btnAddTurbine.UseVisualStyleBackColor = false;
            // 
            // btnViewAllJobs
            // 
            this.btnViewAllJobs.BackColor = System.Drawing.Color.Azure;
            this.btnViewAllJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllJobs.Location = new System.Drawing.Point(250, 44);
            this.btnViewAllJobs.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewAllJobs.Name = "btnViewAllJobs";
            this.btnViewAllJobs.Size = new System.Drawing.Size(206, 65);
            this.btnViewAllJobs.TabIndex = 9;
            this.btnViewAllJobs.Text = "View All Jobs";
            this.btnViewAllJobs.UseVisualStyleBackColor = false;
            this.btnViewAllJobs.Click += new System.EventHandler(this.btnViewAllJobs_Click);
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.BackColor = System.Drawing.Color.Azure;
            this.btnManageAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAccount.Location = new System.Drawing.Point(250, 140);
            this.btnManageAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(206, 65);
            this.btnManageAccount.TabIndex = 10;
            this.btnManageAccount.Text = "Manage Account ";
            this.btnManageAccount.UseVisualStyleBackColor = false;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogOut.Location = new System.Drawing.Point(899, 562);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 41);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBackToAdmin);
            this.panel1.Controls.Add(this.btnManageAccount);
            this.panel1.Controls.Add(this.btnLogO);
            this.panel1.Controls.Add(this.btnSimulationDashboard);
            this.panel1.Controls.Add(this.btnViewAllJobs);
            this.panel1.Controls.Add(this.btnAddTurbine);
            this.panel1.Location = new System.Drawing.Point(145, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 307);
            this.panel1.TabIndex = 12;
            // 
            // btnLogO
            // 
            this.btnLogO.BackColor = System.Drawing.Color.Azure;
            this.btnLogO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogO.ForeColor = System.Drawing.Color.Black;
            this.btnLogO.Location = new System.Drawing.Point(209, 232);
            this.btnLogO.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogO.Name = "btnLogO";
            this.btnLogO.Size = new System.Drawing.Size(75, 41);
            this.btnLogO.TabIndex = 9;
            this.btnLogO.Text = "Log Out";
            this.btnLogO.UseVisualStyleBackColor = false;
            this.btnLogO.Click += new System.EventHandler(this.btnLogO_Click);
            // 
            // btnBackToAdmin
            // 
            this.btnBackToAdmin.BackColor = System.Drawing.Color.Azure;
            this.btnBackToAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnBackToAdmin.Location = new System.Drawing.Point(67, 232);
            this.btnBackToAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackToAdmin.Name = "btnBackToAdmin";
            this.btnBackToAdmin.Size = new System.Drawing.Size(116, 41);
            this.btnBackToAdmin.TabIndex = 11;
            this.btnBackToAdmin.Text = "Back to Admin Dashboard";
            this.btnBackToAdmin.UseVisualStyleBackColor = false;
            this.btnBackToAdmin.Click += new System.EventHandler(this.btnBackToAdmin_Click);
            // 
            // frmCallHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATS_Group3_Project.Properties.Resources.ATS_Background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCallHandler";
            this.Text = "Call Handler";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnSimulationDashboard;
        private System.Windows.Forms.Button btnAddTurbine;
        private System.Windows.Forms.Button btnViewAllJobs;
        private System.Windows.Forms.Button btnManageAccount;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogO;
        private System.Windows.Forms.Button btnBackToAdmin;
    }
}