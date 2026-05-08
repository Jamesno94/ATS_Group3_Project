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
            this.pictureBox1.Image = global::ATS_Group3_Project.Properties.Resources.profile_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Location = new System.Drawing.Point(122, 48);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(71, 16);
            this.lblGreetings.TabIndex = 1;
            this.lblGreetings.Text = "Greetings, ";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(122, 77);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 16);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ATS_Group3_Project.Properties.Resources.Company_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(606, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(330, 320);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnViewAllStaff
            // 
            this.btnViewAllStaff.Location = new System.Drawing.Point(278, 211);
            this.btnViewAllStaff.Name = "btnViewAllStaff";
            this.btnViewAllStaff.Size = new System.Drawing.Size(274, 80);
            this.btnViewAllStaff.TabIndex = 4;
            this.btnViewAllStaff.Text = "View All Staff";
            this.btnViewAllStaff.UseVisualStyleBackColor = true;
            // 
            // btnCreateNewStaff
            // 
            this.btnCreateNewStaff.Location = new System.Drawing.Point(278, 451);
            this.btnCreateNewStaff.Name = "btnCreateNewStaff";
            this.btnCreateNewStaff.Size = new System.Drawing.Size(274, 80);
            this.btnCreateNewStaff.TabIndex = 5;
            this.btnCreateNewStaff.Text = "Create Staff";
            this.btnCreateNewStaff.UseVisualStyleBackColor = true;
            // 
            // btnEditAllStaff
            // 
            this.btnEditAllStaff.Location = new System.Drawing.Point(278, 333);
            this.btnEditAllStaff.Name = "btnEditAllStaff";
            this.btnEditAllStaff.Size = new System.Drawing.Size(274, 80);
            this.btnEditAllStaff.TabIndex = 6;
            this.btnEditAllStaff.Text = "Edit All Staff";
            this.btnEditAllStaff.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Location = new System.Drawing.Point(981, 211);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(274, 80);
            this.btnDeleteStaff.TabIndex = 7;
            this.btnDeleteStaff.Text = "Delete Staff";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            // 
            // btnUnlockAccount
            // 
            this.btnUnlockAccount.Location = new System.Drawing.Point(981, 333);
            this.btnUnlockAccount.Name = "btnUnlockAccount";
            this.btnUnlockAccount.Size = new System.Drawing.Size(274, 80);
            this.btnUnlockAccount.TabIndex = 8;
            this.btnUnlockAccount.Text = "Unlock Account";
            this.btnUnlockAccount.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogOut.Location = new System.Drawing.Point(1370, 891);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(100, 50);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATS_Group3_Project.Properties.Resources.ATS_Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 953);
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