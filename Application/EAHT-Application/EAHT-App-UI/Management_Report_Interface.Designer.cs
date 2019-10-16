namespace EAHT_App_UI
{
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
            this.label1 = new System.Windows.Forms.Label();
            this.MgmtHome_MedicalRecordsButton = new System.Windows.Forms.Button();
            this.MgmtHome_AlarmReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MgmtHome_LogstreamButton
            // 
            this.MgmtHome_LogstreamButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MgmtHome_LogstreamButton.BackColor = System.Drawing.Color.CadetBlue;
            this.MgmtHome_LogstreamButton.Location = new System.Drawing.Point(168, 156);
            this.MgmtHome_LogstreamButton.Name = "MgmtHome_LogstreamButton";
            this.MgmtHome_LogstreamButton.Size = new System.Drawing.Size(200, 60);
            this.MgmtHome_LogstreamButton.TabIndex = 0;
            this.MgmtHome_LogstreamButton.Text = "View Alarm Log Stream";
            this.MgmtHome_LogstreamButton.UseVisualStyleBackColor = false;
            this.MgmtHome_LogstreamButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MgmtHome_StaffReportButton
            // 
            this.MgmtHome_StaffReportButton.BackColor = System.Drawing.Color.CadetBlue;
            this.MgmtHome_StaffReportButton.Location = new System.Drawing.Point(475, 156);
            this.MgmtHome_StaffReportButton.Name = "MgmtHome_StaffReportButton";
            this.MgmtHome_StaffReportButton.Size = new System.Drawing.Size(200, 60);
            this.MgmtHome_StaffReportButton.TabIndex = 1;
            this.MgmtHome_StaffReportButton.Text = "View Staff Sign In/Out Reports";
            this.MgmtHome_StaffReportButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "East Anglia Hospital Trust\r\nManagement Interface";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MgmtHome_MedicalRecordsButton
            // 
            this.MgmtHome_MedicalRecordsButton.BackColor = System.Drawing.Color.CadetBlue;
            this.MgmtHome_MedicalRecordsButton.Location = new System.Drawing.Point(168, 293);
            this.MgmtHome_MedicalRecordsButton.Name = "MgmtHome_MedicalRecordsButton";
            this.MgmtHome_MedicalRecordsButton.Size = new System.Drawing.Size(200, 60);
            this.MgmtHome_MedicalRecordsButton.TabIndex = 3;
            this.MgmtHome_MedicalRecordsButton.Text = "View Patient Medical Records";
            this.MgmtHome_MedicalRecordsButton.UseVisualStyleBackColor = false;
            // 
            // MgmtHome_AlarmReportButton
            // 
            this.MgmtHome_AlarmReportButton.BackColor = System.Drawing.Color.CadetBlue;
            this.MgmtHome_AlarmReportButton.Location = new System.Drawing.Point(475, 293);
            this.MgmtHome_AlarmReportButton.Name = "MgmtHome_AlarmReportButton";
            this.MgmtHome_AlarmReportButton.Size = new System.Drawing.Size(200, 60);
            this.MgmtHome_AlarmReportButton.TabIndex = 4;
            this.MgmtHome_AlarmReportButton.Text = "View Alarm Reports";
            this.MgmtHome_AlarmReportButton.UseVisualStyleBackColor = false;
            // 
            // Management_Report_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 509);
            this.Controls.Add(this.MgmtHome_AlarmReportButton);
            this.Controls.Add(this.MgmtHome_MedicalRecordsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MgmtHome_StaffReportButton);
            this.Controls.Add(this.MgmtHome_LogstreamButton);
            this.Name = "Management_Report_Interface";
            this.Text = "Management_Report_Interface";
            this.Load += new System.EventHandler(this.Management_Report_Interface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MgmtHome_LogstreamButton;
        private System.Windows.Forms.Button MgmtHome_StaffReportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MgmtHome_MedicalRecordsButton;
        private System.Windows.Forms.Button MgmtHome_AlarmReportButton;
    }
}