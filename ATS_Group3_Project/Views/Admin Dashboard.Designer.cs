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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnViewAllStaff = new System.Windows.Forms.Button();
            this.btnCreateNewStaff = new System.Windows.Forms.Button();
            this.btnEditAllStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnUnlockAccount = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ATS_Group3_Project.Properties.Resources.profile_icon;
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.BackColor = System.Drawing.Color.Azure;
            this.lblGreetings.Location = new System.Drawing.Point(92, 39);
            this.lblGreetings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(58, 13);
            this.lblGreetings.TabIndex = 1;
            this.lblGreetings.Text = "Greetings, ";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Azure;
            this.lblRole.Location = new System.Drawing.Point(92, 63);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(32, 13);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ATS_Group3_Project.Properties.Resources.Company_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(454, 171);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(248, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnViewAllStaff
            // 
            this.btnViewAllStaff.Location = new System.Drawing.Point(208, 171);
            this.btnViewAllStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewAllStaff.Name = "btnViewAllStaff";
            this.btnViewAllStaff.Size = new System.Drawing.Size(206, 65);
            this.btnViewAllStaff.TabIndex = 4;
            this.btnViewAllStaff.Text = "View All Staff";
            this.btnViewAllStaff.UseVisualStyleBackColor = true;
            // 
            // btnCreateNewStaff
            // 
            this.btnCreateNewStaff.Location = new System.Drawing.Point(208, 366);
            this.btnCreateNewStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateNewStaff.Name = "btnCreateNewStaff";
            this.btnCreateNewStaff.Size = new System.Drawing.Size(206, 65);
            this.btnCreateNewStaff.TabIndex = 5;
            this.btnCreateNewStaff.Text = "Create Staff";
            this.btnCreateNewStaff.UseVisualStyleBackColor = true;
            // 
            // btnEditAllStaff
            // 
            this.btnEditAllStaff.Location = new System.Drawing.Point(208, 271);
            this.btnEditAllStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditAllStaff.Name = "btnEditAllStaff";
            this.btnEditAllStaff.Size = new System.Drawing.Size(206, 65);
            this.btnEditAllStaff.TabIndex = 6;
            this.btnEditAllStaff.Text = "Edit All Staff";
            this.btnEditAllStaff.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Location = new System.Drawing.Point(736, 171);
            this.btnDeleteStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(206, 65);
            this.btnDeleteStaff.TabIndex = 7;
            this.btnDeleteStaff.Text = "Delete Staff";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            // 
            // btnUnlockAccount
            // 
            this.btnUnlockAccount.Location = new System.Drawing.Point(736, 271);
            this.btnUnlockAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnlockAccount.Name = "btnUnlockAccount";
            this.btnUnlockAccount.Size = new System.Drawing.Size(206, 65);
            this.btnUnlockAccount.TabIndex = 8;
            this.btnUnlockAccount.Text = "Unlock Account";
            this.btnUnlockAccount.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogOut.Location = new System.Drawing.Point(899, 562);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 41);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATS_Group3_Project.Properties.Resources.ATS_Background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 614);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnUnlockAccount);
            this.Controls.Add(this.btnDeleteStaff);
            this.Controls.Add(this.btnEditAllStaff);
            this.Controls.Add(this.btnCreateNewStaff);
            this.Controls.Add(this.btnViewAllStaff);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdminDashboard";
            this.Text = "frmAdminDashboard";
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
        private System.Windows.Forms.Button btnViewAllStaff;
        private System.Windows.Forms.Button btnCreateNewStaff;
        private System.Windows.Forms.Button btnEditAllStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnUnlockAccount;
        private System.Windows.Forms.Button btnLogOut;
    }
}