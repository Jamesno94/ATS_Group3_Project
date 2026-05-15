namespace ATS_Group3_Project.Views
{
    partial class frmAdminDashboard
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
            this.btnViewAllStaff = new System.Windows.Forms.Button();
            this.btnCreateNewStaff = new System.Windows.Forms.Button();
            this.btnEditAllStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnUnlockAccount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ATS_Group3_Project.Properties.Resources.admin_icon;
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.BackColor = System.Drawing.Color.Azure;
            this.lblGreetings.Location = new System.Drawing.Point(113, 41);
            this.lblGreetings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(71, 16);
            this.lblGreetings.TabIndex = 1;
            this.lblGreetings.Text = "Greetings, ";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Azure;
            this.lblRole.Location = new System.Drawing.Point(113, 65);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 16);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role:";
            // 
            // btnViewAllStaff
            // 
            this.btnViewAllStaff.Location = new System.Drawing.Point(556, 34);
            this.btnViewAllStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewAllStaff.Name = "btnViewAllStaff";
            this.btnViewAllStaff.Size = new System.Drawing.Size(275, 80);
            this.btnViewAllStaff.TabIndex = 4;
            this.btnViewAllStaff.Text = "View All Staff";
            this.btnViewAllStaff.UseVisualStyleBackColor = true;
            // 
            // btnCreateNewStaff
            // 
            this.btnCreateNewStaff.Location = new System.Drawing.Point(31, 155);
            this.btnCreateNewStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateNewStaff.Name = "btnCreateNewStaff";
            this.btnCreateNewStaff.Size = new System.Drawing.Size(275, 80);
            this.btnCreateNewStaff.TabIndex = 5;
            this.btnCreateNewStaff.Text = "Create Staff";
            this.btnCreateNewStaff.UseVisualStyleBackColor = true;
            this.btnCreateNewStaff.Click += new System.EventHandler(this.btnCreateNewStaff_Click);
            // 
            // btnEditAllStaff
            // 
            this.btnEditAllStaff.Location = new System.Drawing.Point(31, 284);
            this.btnEditAllStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditAllStaff.Name = "btnEditAllStaff";
            this.btnEditAllStaff.Size = new System.Drawing.Size(275, 80);
            this.btnEditAllStaff.TabIndex = 6;
            this.btnEditAllStaff.Text = "Edit All Staff";
            this.btnEditAllStaff.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Location = new System.Drawing.Point(31, 34);
            this.btnDeleteStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(275, 80);
            this.btnDeleteStaff.TabIndex = 7;
            this.btnDeleteStaff.Text = "Delete Staff";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            // 
            // btnUnlockAccount
            // 
            this.btnUnlockAccount.Location = new System.Drawing.Point(556, 155);
            this.btnUnlockAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnlockAccount.Name = "btnUnlockAccount";
            this.btnUnlockAccount.Size = new System.Drawing.Size(275, 80);
            this.btnUnlockAccount.TabIndex = 8;
            this.btnUnlockAccount.Text = "Unlock Account";
            this.btnUnlockAccount.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnUnlockAccount);
            this.panel2.Controls.Add(this.btnDeleteStaff);
            this.panel2.Controls.Add(this.btnCreateNewStaff);
            this.panel2.Controls.Add(this.btnViewAllStaff);
            this.panel2.Controls.Add(this.btnEditAllStaff);
            this.panel2.Location = new System.Drawing.Point(194, 133);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 416);
            this.panel2.TabIndex = 10;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Azure;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Red;
            this.btnLogOut.Location = new System.Drawing.Point(648, 298);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(100, 50);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATS_Group3_Project.Properties.Resources.ATS_Background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1312, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdminDashboard";
            this.Text = "Admin Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnViewAllStaff;
        private System.Windows.Forms.Button btnCreateNewStaff;
        private System.Windows.Forms.Button btnEditAllStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnUnlockAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogOut;
    }
}