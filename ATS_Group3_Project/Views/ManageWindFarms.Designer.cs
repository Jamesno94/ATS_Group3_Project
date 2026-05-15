namespace ATS_Group3_Project.Views
{
    partial class ManageWindFarms
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnViewWindfarms = new System.Windows.Forms.Button();
            this.btnTurbines = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgWindFarms = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWindFarms)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ATS_Group3_Project.Properties.Resources.ATS_Logo_NoText;
            this.pictureBox2.Location = new System.Drawing.Point(937, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 188);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(52, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Manage WindFarms";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1044, 483);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 35);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(583, 483);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 32);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnViewWindfarms
            // 
            this.btnViewWindfarms.Location = new System.Drawing.Point(88, 474);
            this.btnViewWindfarms.Name = "btnViewWindfarms";
            this.btnViewWindfarms.Size = new System.Drawing.Size(148, 44);
            this.btnViewWindfarms.TabIndex = 20;
            this.btnViewWindfarms.Text = "Add Wind Farms";
            this.btnViewWindfarms.UseVisualStyleBackColor = true;
            this.btnViewWindfarms.Click += new System.EventHandler(this.btnViewWindfarms_Click);
            // 
            // btnTurbines
            // 
            this.btnTurbines.Location = new System.Drawing.Point(283, 474);
            this.btnTurbines.Name = "btnTurbines";
            this.btnTurbines.Size = new System.Drawing.Size(127, 44);
            this.btnTurbines.TabIndex = 21;
            this.btnTurbines.Text = "Manage Turbines";
            this.btnTurbines.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(734, 485);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 30);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgWindFarms
            // 
            this.dgWindFarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWindFarms.Location = new System.Drawing.Point(46, 92);
            this.dgWindFarms.Name = "dgWindFarms";
            this.dgWindFarms.RowHeadersWidth = 51;
            this.dgWindFarms.RowTemplate.Height = 24;
            this.dgWindFarms.Size = new System.Drawing.Size(832, 360);
            this.dgWindFarms.TabIndex = 23;
            this.dgWindFarms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgWindFarms1_CellContentClick);
            // 
            // ManageWindFarms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATS_Group3_Project.Properties.Resources.ATS_Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1228, 560);
            this.Controls.Add(this.dgWindFarms);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTurbines);
            this.Controls.Add(this.btnViewWindfarms);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ManageWindFarms";
            this.Load += new System.EventHandler(this.ManageWindFarms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWindFarms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnViewWindfarms;
        private System.Windows.Forms.Button btnTurbines;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgWindFarms;
    }
}