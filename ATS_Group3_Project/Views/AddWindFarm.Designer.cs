namespace ATS_Group3_Project.Views
{
    partial class frmAddWindFarm
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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblWindFarmName = new System.Windows.Forms.Label();
            this.txtWindFarmName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAddress1 = new System.Windows.Forms.TextBox();
            this.TxtAddress2 = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtPostcode = new System.Windows.Forms.TextBox();
            this.TxtRegion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveDetails = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(-136, -61);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(171, 26);
            this.lblCompanyName.TabIndex = 14;
            this.lblCompanyName.Text = "WindSync ATS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ATS_Group3_Project.Properties.Resources.ATS_Logo_NoText;
            this.pictureBox2.Location = new System.Drawing.Point(748, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(43, 388);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 38);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // lblWindFarmName
            // 
            this.lblWindFarmName.AutoSize = true;
            this.lblWindFarmName.BackColor = System.Drawing.Color.Transparent;
            this.lblWindFarmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblWindFarmName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWindFarmName.Location = new System.Drawing.Point(437, 120);
            this.lblWindFarmName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWindFarmName.Name = "lblWindFarmName";
            this.lblWindFarmName.Size = new System.Drawing.Size(154, 24);
            this.lblWindFarmName.TabIndex = 17;
            this.lblWindFarmName.Text = "WindFarm Name";
            this.lblWindFarmName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtWindFarmName
            // 
            this.txtWindFarmName.Location = new System.Drawing.Point(424, 161);
            this.txtWindFarmName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWindFarmName.Name = "txtWindFarmName";
            this.txtWindFarmName.Size = new System.Drawing.Size(169, 20);
            this.txtWindFarmName.TabIndex = 18;
            this.txtWindFarmName.TextChanged += new System.EventHandler(this.txtWindFarmName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(479, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Location";
            // 
            // TxtAddress1
            // 
            this.TxtAddress1.Location = new System.Drawing.Point(362, 219);
            this.TxtAddress1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtAddress1.Name = "TxtAddress1";
            this.TxtAddress1.Size = new System.Drawing.Size(84, 20);
            this.TxtAddress1.TabIndex = 25;
            this.TxtAddress1.TextChanged += new System.EventHandler(this.TxtAddress1_TextChanged);
            // 
            // TxtAddress2
            // 
            this.TxtAddress2.Location = new System.Drawing.Point(565, 219);
            this.TxtAddress2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtAddress2.Name = "TxtAddress2";
            this.TxtAddress2.Size = new System.Drawing.Size(84, 20);
            this.TxtAddress2.TabIndex = 26;
            this.TxtAddress2.TextChanged += new System.EventHandler(this.TxtAddress2_TextChanged_1);
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(362, 280);
            this.TxtCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(87, 20);
            this.TxtCity.TabIndex = 27;
            this.TxtCity.TextChanged += new System.EventHandler(this.TxtCity_TextChanged);
            // 
            // TxtPostcode
            // 
            this.TxtPostcode.Location = new System.Drawing.Point(565, 280);
            this.TxtPostcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtPostcode.Name = "TxtPostcode";
            this.TxtPostcode.Size = new System.Drawing.Size(84, 20);
            this.TxtPostcode.TabIndex = 28;
            // 
            // TxtRegion
            // 
            this.TxtRegion.Location = new System.Drawing.Point(469, 315);
            this.TxtRegion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtRegion.Name = "TxtRegion";
            this.TxtRegion.Size = new System.Drawing.Size(76, 20);
            this.TxtRegion.TabIndex = 29;
            this.TxtRegion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(580, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Address2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(392, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(490, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Region";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(383, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Address1";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(580, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Post Code";
            // 
            // btnSaveDetails
            // 
            this.btnSaveDetails.Location = new System.Drawing.Point(552, 363);
            this.btnSaveDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveDetails.Name = "btnSaveDetails";
            this.btnSaveDetails.Size = new System.Drawing.Size(81, 35);
            this.btnSaveDetails.TabIndex = 36;
            this.btnSaveDetails.Text = "Save";
            this.btnSaveDetails.UseVisualStyleBackColor = true;
            this.btnSaveDetails.Click += new System.EventHandler(this.btnSaveDetails_Click_3);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 19);
            this.btnDelete.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 363);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 35);
            this.button1.TabIndex = 38;
            this.button1.Text = "Clear Fields";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnclear_Click_3);
            // 
            // frmAddWindFarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATS_Group3_Project.Properties.Resources.ATS_Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(977, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveDetails);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtRegion);
            this.Controls.Add(this.TxtPostcode);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.TxtAddress2);
            this.Controls.Add(this.TxtAddress1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWindFarmName);
            this.Controls.Add(this.lblWindFarmName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAddWindFarm";
            this.Text = "WindFarm";
            this.Load += new System.EventHandler(this.WindFarm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblWindFarmName;
        private System.Windows.Forms.TextBox txtWindFarmName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAddress1;
        private System.Windows.Forms.TextBox TxtAddress2;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtPostcode;
        private System.Windows.Forms.TextBox TxtRegion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveDetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
    }
}