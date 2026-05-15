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
            this.btnAddWindFarm = new System.Windows.Forms.Button();
            this.btnAddShifts = new System.Windows.Forms.Button();
            this.btnViewAllJobs = new System.Windows.Forms.Button();
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ATS_Group3_Project.Properties.Resources.profile_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Location = new System.Drawing.Point(123, 48);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(71, 16);
            this.lblGreetings.TabIndex = 1;
            this.lblGreetings.Text = "Greetings, ";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(123, 78);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 16);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role:";
            // 
            // btnSimulationDashboard
            // 
            this.btnSimulationDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulationDashboard.Location = new System.Drawing.Point(25, 28);
            this.btnSimulationDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimulationDashboard.Name = "btnSimulationDashboard";
            this.btnSimulationDashboard.Size = new System.Drawing.Size(275, 80);
            this.btnSimulationDashboard.TabIndex = 4;
            this.btnSimulationDashboard.Text = "Simulation Dashboard";
            this.btnSimulationDashboard.UseVisualStyleBackColor = true;
            this.btnSimulationDashboard.Click += new System.EventHandler(this.btnSimulationDashboard_Click);
            // 
            // btnAddTurbine
            // 
            this.btnAddTurbine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTurbine.Location = new System.Drawing.Point(25, 230);
            this.btnAddTurbine.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTurbine.Name = "btnAddTurbine";
            this.btnAddTurbine.Size = new System.Drawing.Size(275, 80);
            this.btnAddTurbine.TabIndex = 5;
            this.btnAddTurbine.Text = "Add Turbine";
            this.btnAddTurbine.UseVisualStyleBackColor = true;
            // 
            // btnAddWindFarm
            // 
            this.btnAddWindFarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWindFarm.Location = new System.Drawing.Point(25, 130);
            this.btnAddWindFarm.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddWindFarm.Name = "btnAddWindFarm";
            this.btnAddWindFarm.Size = new System.Drawing.Size(275, 80);
            this.btnAddWindFarm.TabIndex = 6;
            this.btnAddWindFarm.Text = "Add Windfarm";
            this.btnAddWindFarm.UseVisualStyleBackColor = true;
            // 
            // btnAddShifts
            // 
            this.btnAddShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShifts.Location = new System.Drawing.Point(467, 130);
            this.btnAddShifts.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddShifts.Name = "btnAddShifts";
            this.btnAddShifts.Size = new System.Drawing.Size(275, 80);
            this.btnAddShifts.TabIndex = 8;
            this.btnAddShifts.Text = "Add Shifts";
            this.btnAddShifts.UseVisualStyleBackColor = true;
            // 
            // btnViewAllJobs
            // 
            this.btnViewAllJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllJobs.Location = new System.Drawing.Point(467, 28);
            this.btnViewAllJobs.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewAllJobs.Name = "btnViewAllJobs";
            this.btnViewAllJobs.Size = new System.Drawing.Size(275, 80);
            this.btnViewAllJobs.TabIndex = 9;
            this.btnViewAllJobs.Text = "View All Jobs";
            this.btnViewAllJobs.UseVisualStyleBackColor = true;
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAccount.Location = new System.Drawing.Point(467, 230);
            this.btnManageAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(275, 80);
            this.btnManageAccount.TabIndex = 10;
            this.btnManageAccount.Text = "Manage Account ";
            this.btnManageAccount.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogOut.Location = new System.Drawing.Point(1199, 692);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(100, 50);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnManageAccount);
            this.panel1.Controls.Add(this.btnAddShifts);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSimulationDashboard);
            this.panel1.Controls.Add(this.btnViewAllJobs);
            this.panel1.Controls.Add(this.btnAddWindFarm);
            this.panel1.Controls.Add(this.btnAddTurbine);
            this.panel1.Location = new System.Drawing.Point(252, 116);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 416);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(334, 346);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "LOG OUT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmCallHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATS_Group3_Project.Properties.Resources.ATS_Background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1252, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btnAddWindFarm;
        private System.Windows.Forms.Button btnAddShifts;
        private System.Windows.Forms.Button btnViewAllJobs;
        private System.Windows.Forms.Button btnManageAccount;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}