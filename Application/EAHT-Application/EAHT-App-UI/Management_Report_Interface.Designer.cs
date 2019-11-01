namespace EAHT_App_UI
{
    /// <summary>
    /// UI Class for Management section of UI
    /// </summary>
    partial class Management_Report_Interface
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
            this.MgmtHome_LogstreamButton = new System.Windows.Forms.Button();
            this.MgmtHome_StaffReportButton = new System.Windows.Forms.Button();
            this.Mgmt_TitleText = new System.Windows.Forms.Label();
            this.MgmtHome_MedicalRecordsButton = new System.Windows.Forms.Button();
            this.MgmtHome_AlarmReportButton = new System.Windows.Forms.Button();
            this.MgmtHome_BackPanel = new System.Windows.Forms.Panel();
            this.MgmtAlarmLog_BackPanel = new System.Windows.Forms.Panel();
            this.MgmtAlarmLog_BackButton = new System.Windows.Forms.Button();
            this.MgmtAlarmLog_TitleText = new System.Windows.Forms.Label();
            this.MgmtAlarmLog_LogDataTable = new System.Windows.Forms.DataGridView();
            this.MgmtStaffReports_BackPanel = new System.Windows.Forms.Panel();
            this.MgmtStaffReport_BackButton = new System.Windows.Forms.Button();
            this.MgmtStaffReport_TitleText = new System.Windows.Forms.Label();
            this.MgmtMedicalRecords_BackPanel = new System.Windows.Forms.Panel();
            this.MgmtMedicalRecords_BackButton = new System.Windows.Forms.Button();
            this.MgmtMedicalRecords_TitleText = new System.Windows.Forms.Label();
            this.MgmtAlarmReports_BackPanel = new System.Windows.Forms.Panel();
            this.MgmtAlarmReports_BackButton = new System.Windows.Forms.Button();
            this.MgmtAlarmReports_TitleText = new System.Windows.Forms.Label();
            this.MgmtHome_BackPanel.SuspendLayout();
            this.MgmtAlarmLog_BackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MgmtAlarmLog_LogDataTable)).BeginInit();
            this.MgmtStaffReports_BackPanel.SuspendLayout();
            this.MgmtMedicalRecords_BackPanel.SuspendLayout();
            this.MgmtAlarmReports_BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MgmtHome_LogstreamButton
            // 
            this.MgmtHome_LogstreamButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MgmtHome_LogstreamButton.BackColor = System.Drawing.Color.CadetBlue;
            this.MgmtHome_LogstreamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MgmtHome_LogstreamButton.Location = new System.Drawing.Point(33, 32);
            this.MgmtHome_LogstreamButton.Name = "MgmtHome_LogstreamButton";
            this.MgmtHome_LogstreamButton.Size = new System.Drawing.Size(200, 150);
            this.MgmtHome_LogstreamButton.TabIndex = 0;
            this.MgmtHome_LogstreamButton.Text = "View Alarm Log Stream";
            this.MgmtHome_LogstreamButton.UseVisualStyleBackColor = false;
            this.MgmtHome_LogstreamButton.Click += new System.EventHandler(this.MgmtHome_LogstreamButton_Click);
            // 
            // MgmtHome_StaffReportButton
            // 
            this.MgmtHome_StaffReportButton.BackColor = System.Drawing.Color.CadetBlue;
            this.MgmtHome_StaffReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MgmtHome_StaffReportButton.Location = new System.Drawing.Point(299, 32);
            this.MgmtHome_StaffReportButton.Name = "MgmtHome_StaffReportButton";
            this.MgmtHome_StaffReportButton.Size = new System.Drawing.Size(200, 150);
            this.MgmtHome_StaffReportButton.TabIndex = 1;
            this.MgmtHome_StaffReportButton.Text = "View Staff Sign In/Out \r\nReports";
            this.MgmtHome_StaffReportButton.UseVisualStyleBackColor = false;
            this.MgmtHome_StaffReportButton.Click += new System.EventHandler(this.MgmtHome_StaffReportButton_Click);
            // 
            // Mgmt_TitleText
            // 
            this.Mgmt_TitleText.AutoSize = true;
            this.Mgmt_TitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mgmt_TitleText.Location = new System.Drawing.Point(245, 16);
            this.Mgmt_TitleText.Name = "Mgmt_TitleText";
            this.Mgmt_TitleText.Size = new System.Drawing.Size(353, 62);
            this.Mgmt_TitleText.TabIndex = 2;
            this.Mgmt_TitleText.Text = "East Anglia Hospital Trust\r\nManagement Interface";
            this.Mgmt_TitleText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MgmtHome_MedicalRecordsButton
            // 
            this.MgmtHome_MedicalRecordsButton.BackColor = System.Drawing.Color.CadetBlue;
            this.MgmtHome_MedicalRecordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MgmtHome_MedicalRecordsButton.Location = new System.Drawing.Point(33, 242);
            this.MgmtHome_MedicalRecordsButton.Name = "MgmtHome_MedicalRecordsButton";
            this.MgmtHome_MedicalRecordsButton.Size = new System.Drawing.Size(200, 150);
            this.MgmtHome_MedicalRecordsButton.TabIndex = 3;
            this.MgmtHome_MedicalRecordsButton.Text = "View Patient Medical \r\nRecords";
            this.MgmtHome_MedicalRecordsButton.UseVisualStyleBackColor = false;
            this.MgmtHome_MedicalRecordsButton.Click += new System.EventHandler(this.MgmtHome_MedicalRecordsButton_Click);
            // 
            // MgmtHome_AlarmReportButton
            // 
            this.MgmtHome_AlarmReportButton.BackColor = System.Drawing.Color.CadetBlue;
            this.MgmtHome_AlarmReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MgmtHome_AlarmReportButton.Location = new System.Drawing.Point(299, 242);
            this.MgmtHome_AlarmReportButton.Name = "MgmtHome_AlarmReportButton";
            this.MgmtHome_AlarmReportButton.Size = new System.Drawing.Size(200, 150);
            this.MgmtHome_AlarmReportButton.TabIndex = 4;
            this.MgmtHome_AlarmReportButton.Text = "View Alarm Reports";
            this.MgmtHome_AlarmReportButton.UseVisualStyleBackColor = false;
            this.MgmtHome_AlarmReportButton.Click += new System.EventHandler(this.MgmtHome_AlarmReportButton_Click);
            // 
            // MgmtHome_BackPanel
            // 
            this.MgmtHome_BackPanel.Controls.Add(this.MgmtHome_LogstreamButton);
            this.MgmtHome_BackPanel.Controls.Add(this.MgmtHome_MedicalRecordsButton);
            this.MgmtHome_BackPanel.Controls.Add(this.MgmtHome_AlarmReportButton);
            this.MgmtHome_BackPanel.Controls.Add(this.MgmtHome_StaffReportButton);
            this.MgmtHome_BackPanel.Location = new System.Drawing.Point(178, 81);
            this.MgmtHome_BackPanel.Name = "MgmtHome_BackPanel";
            this.MgmtHome_BackPanel.Size = new System.Drawing.Size(533, 416);
            this.MgmtHome_BackPanel.TabIndex = 5;
            // 
            // MgmtAlarmLog_BackPanel
            // 
            this.MgmtAlarmLog_BackPanel.Controls.Add(this.MgmtAlarmLog_BackButton);
            this.MgmtAlarmLog_BackPanel.Controls.Add(this.MgmtAlarmLog_TitleText);
            this.MgmtAlarmLog_BackPanel.Controls.Add(this.MgmtAlarmLog_LogDataTable);
            this.MgmtAlarmLog_BackPanel.Enabled = false;
            this.MgmtAlarmLog_BackPanel.Location = new System.Drawing.Point(21, 81);
            this.MgmtAlarmLog_BackPanel.Name = "MgmtAlarmLog_BackPanel";
            this.MgmtAlarmLog_BackPanel.Size = new System.Drawing.Size(800, 400);
            this.MgmtAlarmLog_BackPanel.TabIndex = 6;
            this.MgmtAlarmLog_BackPanel.Visible = false;
            // 
            // MgmtAlarmLog_BackButton
            // 
            this.MgmtAlarmLog_BackButton.BackColor = System.Drawing.SystemColors.Control;
            this.MgmtAlarmLog_BackButton.Location = new System.Drawing.Point(716, 21);
            this.MgmtAlarmLog_BackButton.Name = "MgmtAlarmLog_BackButton";
            this.MgmtAlarmLog_BackButton.Size = new System.Drawing.Size(75, 23);
            this.MgmtAlarmLog_BackButton.TabIndex = 2;
            this.MgmtAlarmLog_BackButton.Text = "Back";
            this.MgmtAlarmLog_BackButton.UseVisualStyleBackColor = false;
            this.MgmtAlarmLog_BackButton.Click += new System.EventHandler(this.MgmtAlarmLog_BackButton_Click);
            // 
            // MgmtAlarmLog_TitleText
            // 
            this.MgmtAlarmLog_TitleText.AutoSize = true;
            this.MgmtAlarmLog_TitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MgmtAlarmLog_TitleText.Location = new System.Drawing.Point(14, 18);
            this.MgmtAlarmLog_TitleText.Name = "MgmtAlarmLog_TitleText";
            this.MgmtAlarmLog_TitleText.Size = new System.Drawing.Size(224, 24);
            this.MgmtAlarmLog_TitleText.TabIndex = 1;
            this.MgmtAlarmLog_TitleText.Text = "Bed Monitor Alarm Log";
            // 
            // MgmtAlarmLog_LogDataTable
            // 
            this.MgmtAlarmLog_LogDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MgmtAlarmLog_LogDataTable.Location = new System.Drawing.Point(18, 63);
            this.MgmtAlarmLog_LogDataTable.Name = "MgmtAlarmLog_LogDataTable";
            this.MgmtAlarmLog_LogDataTable.Size = new System.Drawing.Size(773, 329);
            this.MgmtAlarmLog_LogDataTable.TabIndex = 0;
            // 
            // MgmtStaffReports_BackPanel
            // 
            this.MgmtStaffReports_BackPanel.Controls.Add(this.MgmtStaffReport_BackButton);
            this.MgmtStaffReports_BackPanel.Controls.Add(this.MgmtStaffReport_TitleText);
            this.MgmtStaffReports_BackPanel.Enabled = false;
            this.MgmtStaffReports_BackPanel.Location = new System.Drawing.Point(21, 83);
            this.MgmtStaffReports_BackPanel.Name = "MgmtStaffReports_BackPanel";
            this.MgmtStaffReports_BackPanel.Size = new System.Drawing.Size(800, 400);
            this.MgmtStaffReports_BackPanel.TabIndex = 6;
            this.MgmtStaffReports_BackPanel.Visible = false;
            // 
            // MgmtStaffReport_BackButton
            // 
            this.MgmtStaffReport_BackButton.Location = new System.Drawing.Point(716, 21);
            this.MgmtStaffReport_BackButton.Name = "MgmtStaffReport_BackButton";
            this.MgmtStaffReport_BackButton.Size = new System.Drawing.Size(75, 23);
            this.MgmtStaffReport_BackButton.TabIndex = 1;
            this.MgmtStaffReport_BackButton.Text = "Back";
            this.MgmtStaffReport_BackButton.UseVisualStyleBackColor = true;
            this.MgmtStaffReport_BackButton.Click += new System.EventHandler(this.MgmtStaffReports_BackButton_Click);
            // 
            // MgmtStaffReport_TitleText
            // 
            this.MgmtStaffReport_TitleText.AutoSize = true;
            this.MgmtStaffReport_TitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MgmtStaffReport_TitleText.Location = new System.Drawing.Point(18, 18);
            this.MgmtStaffReport_TitleText.Name = "MgmtStaffReport_TitleText";
            this.MgmtStaffReport_TitleText.Size = new System.Drawing.Size(237, 24);
            this.MgmtStaffReport_TitleText.TabIndex = 0;
            this.MgmtStaffReport_TitleText.Text = "Staff Sign In/Out Reports";
            // 
            // MgmtMedicalRecords_BackPanel
            // 
            this.MgmtMedicalRecords_BackPanel.Controls.Add(this.MgmtMedicalRecords_BackButton);
            this.MgmtMedicalRecords_BackPanel.Controls.Add(this.MgmtMedicalRecords_TitleText);
            this.MgmtMedicalRecords_BackPanel.Enabled = false;
            this.MgmtMedicalRecords_BackPanel.Location = new System.Drawing.Point(21, 83);
            this.MgmtMedicalRecords_BackPanel.Name = "MgmtMedicalRecords_BackPanel";
            this.MgmtMedicalRecords_BackPanel.Size = new System.Drawing.Size(800, 400);
            this.MgmtMedicalRecords_BackPanel.TabIndex = 3;
            this.MgmtMedicalRecords_BackPanel.Visible = false;
            // 
            // MgmtMedicalRecords_BackButton
            // 
            this.MgmtMedicalRecords_BackButton.Location = new System.Drawing.Point(716, 21);
            this.MgmtMedicalRecords_BackButton.Name = "MgmtMedicalRecords_BackButton";
            this.MgmtMedicalRecords_BackButton.Size = new System.Drawing.Size(75, 23);
            this.MgmtMedicalRecords_BackButton.TabIndex = 1;
            this.MgmtMedicalRecords_BackButton.Text = "Back";
            this.MgmtMedicalRecords_BackButton.UseVisualStyleBackColor = true;
            this.MgmtMedicalRecords_BackButton.Click += new System.EventHandler(this.MgmtMedicalRecords_BackButton_Click);
            // 
            // MgmtMedicalRecords_TitleText
            // 
            this.MgmtMedicalRecords_TitleText.AutoSize = true;
            this.MgmtMedicalRecords_TitleText.Enabled = false;
            this.MgmtMedicalRecords_TitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MgmtMedicalRecords_TitleText.Location = new System.Drawing.Point(18, 18);
            this.MgmtMedicalRecords_TitleText.Name = "MgmtMedicalRecords_TitleText";
            this.MgmtMedicalRecords_TitleText.Size = new System.Drawing.Size(236, 24);
            this.MgmtMedicalRecords_TitleText.TabIndex = 0;
            this.MgmtMedicalRecords_TitleText.Text = "Patient Medical Records";
            // 
            // MgmtAlarmReports_BackPanel
            // 
            this.MgmtAlarmReports_BackPanel.Controls.Add(this.MgmtAlarmReports_BackButton);
            this.MgmtAlarmReports_BackPanel.Controls.Add(this.MgmtAlarmReports_TitleText);
            this.MgmtAlarmReports_BackPanel.Enabled = false;
            this.MgmtAlarmReports_BackPanel.Location = new System.Drawing.Point(20, 84);
            this.MgmtAlarmReports_BackPanel.Name = "MgmtAlarmReports_BackPanel";
            this.MgmtAlarmReports_BackPanel.Size = new System.Drawing.Size(800, 400);
            this.MgmtAlarmReports_BackPanel.TabIndex = 7;
            this.MgmtAlarmReports_BackPanel.Visible = false;
            // 
            // MgmtAlarmReports_BackButton
            // 
            this.MgmtAlarmReports_BackButton.Location = new System.Drawing.Point(697, 16);
            this.MgmtAlarmReports_BackButton.Name = "MgmtAlarmReports_BackButton";
            this.MgmtAlarmReports_BackButton.Size = new System.Drawing.Size(75, 23);
            this.MgmtAlarmReports_BackButton.TabIndex = 1;
            this.MgmtAlarmReports_BackButton.Text = "Back";
            this.MgmtAlarmReports_BackButton.UseVisualStyleBackColor = true;
            this.MgmtAlarmReports_BackButton.Click += new System.EventHandler(this.MgmtAlarmReports_BackButton_Click);
            // 
            // MgmtAlarmReports_TitleText
            // 
            this.MgmtAlarmReports_TitleText.AutoSize = true;
            this.MgmtAlarmReports_TitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MgmtAlarmReports_TitleText.Location = new System.Drawing.Point(19, 15);
            this.MgmtAlarmReports_TitleText.Name = "MgmtAlarmReports_TitleText";
            this.MgmtAlarmReports_TitleText.Size = new System.Drawing.Size(161, 25);
            this.MgmtAlarmReports_TitleText.TabIndex = 0;
            this.MgmtAlarmReports_TitleText.Text = "Alarm Reports";
            // 
            // Management_Report_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(842, 509);
            this.Controls.Add(this.MgmtStaffReports_BackPanel);
            this.Controls.Add(this.MgmtAlarmReports_BackPanel);
            this.Controls.Add(this.MgmtMedicalRecords_BackPanel);
            this.Controls.Add(this.MgmtAlarmLog_BackPanel);
            this.Controls.Add(this.MgmtHome_BackPanel);
            this.Controls.Add(this.Mgmt_TitleText);
            this.Name = "Management_Report_Interface";
            this.Text = "Management Report Interface";
            this.Load += new System.EventHandler(this.Management_Report_Interface_Load);
            this.MgmtHome_BackPanel.ResumeLayout(false);
            this.MgmtAlarmLog_BackPanel.ResumeLayout(false);
            this.MgmtAlarmLog_BackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MgmtAlarmLog_LogDataTable)).EndInit();
            this.MgmtStaffReports_BackPanel.ResumeLayout(false);
            this.MgmtStaffReports_BackPanel.PerformLayout();
            this.MgmtMedicalRecords_BackPanel.ResumeLayout(false);
            this.MgmtMedicalRecords_BackPanel.PerformLayout();
            this.MgmtAlarmReports_BackPanel.ResumeLayout(false);
            this.MgmtAlarmReports_BackPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MgmtHome_LogstreamButton;
        private System.Windows.Forms.Button MgmtHome_StaffReportButton;
        private System.Windows.Forms.Label Mgmt_TitleText;
        private System.Windows.Forms.Button MgmtHome_MedicalRecordsButton;
        private System.Windows.Forms.Button MgmtHome_AlarmReportButton;
        private System.Windows.Forms.Panel MgmtHome_BackPanel;
        private System.Windows.Forms.Panel MgmtAlarmLog_BackPanel;
        private System.Windows.Forms.Label MgmtAlarmLog_TitleText;
        private System.Windows.Forms.DataGridView MgmtAlarmLog_LogDataTable;
        private System.Windows.Forms.Button MgmtAlarmLog_BackButton;
        private System.Windows.Forms.Panel MgmtMedicalRecords_BackPanel;
        private System.Windows.Forms.Label MgmtMedicalRecords_TitleText;
        private System.Windows.Forms.Button MgmtMedicalRecords_BackButton;
        private System.Windows.Forms.Panel MgmtStaffReports_BackPanel;
        private System.Windows.Forms.Button MgmtStaffReport_BackButton;
        private System.Windows.Forms.Label MgmtStaffReport_TitleText;
        private System.Windows.Forms.Panel MgmtAlarmReports_BackPanel;
        private System.Windows.Forms.Label MgmtAlarmReports_TitleText;
        private System.Windows.Forms.Button MgmtAlarmReports_BackButton;
    }
}