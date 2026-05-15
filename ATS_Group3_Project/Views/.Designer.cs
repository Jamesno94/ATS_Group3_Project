namespace ATS_Group3_Project.Views
{
    partial class frmJobDetails
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
            this.dataGVComponentChecklist = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtJobReference = new System.Windows.Forms.TextBox();
            this.txtJobType = new System.Windows.Forms.TextBox();
            this.txtWindfarm = new System.Windows.Forms.TextBox();
            this.txtTurbine = new System.Windows.Forms.TextBox();
            this.txtAssignedEngineer = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.datetimeFault = new System.Windows.Forms.DateTimePicker();
            this.comboxPriority = new System.Windows.Forms.ComboBox();
            this.comboxStatus = new System.Windows.Forms.ComboBox();
            this.rtxtFaultDescription = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rtxtEngineerNotes = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVComponentChecklist)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVComponentChecklist
            // 
            this.dataGVComponentChecklist.BackgroundColor = System.Drawing.Color.White;
            this.dataGVComponentChecklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVComponentChecklist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGVComponentChecklist.Location = new System.Drawing.Point(578, 372);
            this.dataGVComponentChecklist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGVComponentChecklist.Name = "dataGVComponentChecklist";
            this.dataGVComponentChecklist.RowHeadersWidth = 62;
            this.dataGVComponentChecklist.RowTemplate.Height = 28;
            this.dataGVComponentChecklist.Size = new System.Drawing.Size(725, 282);
            this.dataGVComponentChecklist.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Component";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Issue Found";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Action Required";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Status";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Notes";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job Reference:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Job Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Windfarm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(60, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Turbine:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(400, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Assigned Engineer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(400, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Priority:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(400, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Status:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(400, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fault Date/Time:";
            // 
            // txtJobReference
            // 
            this.txtJobReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobReference.Location = new System.Drawing.Point(209, 118);
            this.txtJobReference.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJobReference.Name = "txtJobReference";
            this.txtJobReference.Size = new System.Drawing.Size(145, 27);
            this.txtJobReference.TabIndex = 9;
            // 
            // txtJobType
            // 
            this.txtJobType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobType.Location = new System.Drawing.Point(209, 168);
            this.txtJobType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJobType.Name = "txtJobType";
            this.txtJobType.Size = new System.Drawing.Size(145, 27);
            this.txtJobType.TabIndex = 10;
            // 
            // txtWindfarm
            // 
            this.txtWindfarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWindfarm.Location = new System.Drawing.Point(209, 211);
            this.txtWindfarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWindfarm.Name = "txtWindfarm";
            this.txtWindfarm.Size = new System.Drawing.Size(145, 27);
            this.txtWindfarm.TabIndex = 11;
            // 
            // txtTurbine
            // 
            this.txtTurbine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurbine.Location = new System.Drawing.Point(209, 263);
            this.txtTurbine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTurbine.Name = "txtTurbine";
            this.txtTurbine.Size = new System.Drawing.Size(145, 27);
            this.txtTurbine.TabIndex = 12;
            // 
            // txtAssignedEngineer
            // 
            this.txtAssignedEngineer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignedEngineer.Location = new System.Drawing.Point(590, 125);
            this.txtAssignedEngineer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAssignedEngineer.Name = "txtAssignedEngineer";
            this.txtAssignedEngineer.Size = new System.Drawing.Size(179, 27);
            this.txtAssignedEngineer.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 710);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 37);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Back";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(1171, 710);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(132, 38);
            this.btnSaveChanges.TabIndex = 18;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // datetimeFault
            // 
            this.datetimeFault.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeFault.Location = new System.Drawing.Point(590, 285);
            this.datetimeFault.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datetimeFault.Name = "datetimeFault";
            this.datetimeFault.Size = new System.Drawing.Size(223, 27);
            this.datetimeFault.TabIndex = 19;
            // 
            // comboxPriority
            // 
            this.comboxPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxPriority.FormattingEnabled = true;
            this.comboxPriority.Location = new System.Drawing.Point(590, 175);
            this.comboxPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboxPriority.Name = "comboxPriority";
            this.comboxPriority.Size = new System.Drawing.Size(179, 28);
            this.comboxPriority.TabIndex = 20;
            // 
            // comboxStatus
            // 
            this.comboxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxStatus.FormattingEnabled = true;
            this.comboxStatus.Location = new System.Drawing.Point(590, 230);
            this.comboxStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboxStatus.Name = "comboxStatus";
            this.comboxStatus.Size = new System.Drawing.Size(179, 28);
            this.comboxStatus.TabIndex = 21;
            // 
            // rtxtFaultDescription
            // 
            this.rtxtFaultDescription.Location = new System.Drawing.Point(828, 98);
            this.rtxtFaultDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtFaultDescription.Name = "rtxtFaultDescription";
            this.rtxtFaultDescription.Size = new System.Drawing.Size(460, 193);
            this.rtxtFaultDescription.TabIndex = 22;
            this.rtxtFaultDescription.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(824, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Fault Description:";
            // 
            // rtxtEngineerNotes
            // 
            this.rtxtEngineerNotes.Location = new System.Drawing.Point(64, 390);
            this.rtxtEngineerNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtEngineerNotes.Name = "rtxtEngineerNotes";
            this.rtxtEngineerNotes.Size = new System.Drawing.Size(460, 265);
            this.rtxtEngineerNotes.TabIndex = 24;
            this.rtxtEngineerNotes.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(69, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Engineer Notes:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(574, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Component Checklist";
            // 
            // frmJobDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATS_Group3_Project.Properties.Resources.ATS_Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1312, 759);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rtxtEngineerNotes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rtxtFaultDescription);
            this.Controls.Add(this.comboxStatus);
            this.Controls.Add(this.comboxPriority);
            this.Controls.Add(this.datetimeFault);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtAssignedEngineer);
            this.Controls.Add(this.txtTurbine);
            this.Controls.Add(this.txtWindfarm);
            this.Controls.Add(this.txtJobType);
            this.Controls.Add(this.txtJobReference);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGVComponentChecklist);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmJobDetails";
            this.Text = "Job Details";
            this.Load += new System.EventHandler(this.frmJobDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVComponentChecklist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVComponentChecklist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtJobReference;
        private System.Windows.Forms.TextBox txtJobType;
        private System.Windows.Forms.TextBox txtWindfarm;
        private System.Windows.Forms.TextBox txtTurbine;
        private System.Windows.Forms.TextBox txtAssignedEngineer;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.DateTimePicker datetimeFault;
        private System.Windows.Forms.ComboBox comboxPriority;
        private System.Windows.Forms.ComboBox comboxStatus;
        private System.Windows.Forms.RichTextBox rtxtFaultDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtxtEngineerNotes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}