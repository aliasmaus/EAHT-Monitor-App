namespace EAHT_App_UI
{
    partial class MonitorPage
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
            this.components = new System.ComponentModel.Container();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.AlarmMessage = new System.Windows.Forms.Label();
            this.temperatureValues = new System.Windows.Forms.Timer(this.components);
            this.bloodpressureValues = new System.Windows.Forms.Timer(this.components);
            this.pulseValues = new System.Windows.Forms.Timer(this.components);
            this.breathingrateValues = new System.Windows.Forms.Timer(this.components);
            this.BedValue = new System.Windows.Forms.Label();
            this.Monitor1_CurrentReading = new System.Windows.Forms.Label();
            this.Monitor3_CurrentReading = new System.Windows.Forms.Label();
            this.Monitor2_CurrentReading = new System.Windows.Forms.Label();
            this.Monitor4_CurrentReading = new System.Windows.Forms.Label();
            this.pageUpdater = new System.Windows.Forms.Timer(this.components);
            this.Monitor1_Choice = new System.Windows.Forms.ComboBox();
            this.Monitor2_Choice = new System.Windows.Forms.ComboBox();
            this.Monitor3_Choice = new System.Windows.Forms.ComboBox();
            this.Monitor4_Choice = new System.Windows.Forms.ComboBox();
            this.Monitor4_Background = new System.Windows.Forms.GroupBox();
            this.Monitor3_Background = new System.Windows.Forms.GroupBox();
            this.Monitor1_Background = new System.Windows.Forms.GroupBox();
            this.Monitor2_Background = new System.Windows.Forms.GroupBox();
            this.Monitor4_Background.SuspendLayout();
            this.Monitor3_Background.SuspendLayout();
            this.Monitor1_Background.SuspendLayout();
            this.Monitor2_Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(535, 10);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(56, 19);
            this.ReturnButton.TabIndex = 16;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // AlarmMessage
            // 
            this.AlarmMessage.AutoSize = true;
            this.AlarmMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmMessage.Location = new System.Drawing.Point(183, 320);
            this.AlarmMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AlarmMessage.Name = "AlarmMessage";
            this.AlarmMessage.Size = new System.Drawing.Size(208, 20);
            this.AlarmMessage.TabIndex = 17;
            this.AlarmMessage.Text = "Alarm Preset Message Here";
            this.AlarmMessage.Click += new System.EventHandler(this.label13_Click);
            // 
            // BedValue
            // 
            this.BedValue.AutoSize = true;
            this.BedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedValue.Location = new System.Drawing.Point(11, 10);
            this.BedValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BedValue.Name = "BedValue";
            this.BedValue.Size = new System.Drawing.Size(98, 20);
            this.BedValue.TabIndex = 18;
            this.BedValue.Text = "Bed Number";
            this.BedValue.Click += new System.EventHandler(this.BayValue_Click);
            // 
            // Monitor1_CurrentReading
            // 
            this.Monitor1_CurrentReading.AutoSize = true;
            this.Monitor1_CurrentReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monitor1_CurrentReading.Location = new System.Drawing.Point(15, 57);
            this.Monitor1_CurrentReading.Name = "Monitor1_CurrentReading";
            this.Monitor1_CurrentReading.Size = new System.Drawing.Size(80, 55);
            this.Monitor1_CurrentReading.TabIndex = 19;
            this.Monitor1_CurrentReading.Text = "##";
            this.Monitor1_CurrentReading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Monitor3_CurrentReading
            // 
            this.Monitor3_CurrentReading.AutoSize = true;
            this.Monitor3_CurrentReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monitor3_CurrentReading.Location = new System.Drawing.Point(15, 53);
            this.Monitor3_CurrentReading.Name = "Monitor3_CurrentReading";
            this.Monitor3_CurrentReading.Size = new System.Drawing.Size(80, 55);
            this.Monitor3_CurrentReading.TabIndex = 20;
            this.Monitor3_CurrentReading.Text = "##";
            this.Monitor3_CurrentReading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Monitor3_CurrentReading.Click += new System.EventHandler(this.Monitor3_CurrentReading_Click);
            // 
            // Monitor2_CurrentReading
            // 
            this.Monitor2_CurrentReading.AutoSize = true;
            this.Monitor2_CurrentReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monitor2_CurrentReading.Location = new System.Drawing.Point(16, 57);
            this.Monitor2_CurrentReading.Name = "Monitor2_CurrentReading";
            this.Monitor2_CurrentReading.Size = new System.Drawing.Size(80, 55);
            this.Monitor2_CurrentReading.TabIndex = 21;
            this.Monitor2_CurrentReading.Text = "##";
            this.Monitor2_CurrentReading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Monitor4_CurrentReading
            // 
            this.Monitor4_CurrentReading.AutoSize = true;
            this.Monitor4_CurrentReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monitor4_CurrentReading.Location = new System.Drawing.Point(16, 53);
            this.Monitor4_CurrentReading.Name = "Monitor4_CurrentReading";
            this.Monitor4_CurrentReading.Size = new System.Drawing.Size(80, 55);
            this.Monitor4_CurrentReading.TabIndex = 22;
            this.Monitor4_CurrentReading.Text = "##";
            this.Monitor4_CurrentReading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pageUpdater
            // 
            this.pageUpdater.Enabled = true;
            this.pageUpdater.Interval = 1000;
            this.pageUpdater.Tick += new System.EventHandler(this.PageUpdate);
            // 
            // Monitor1_Choice
            // 
            this.Monitor1_Choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monitor1_Choice.FormattingEnabled = true;
            this.Monitor1_Choice.Items.AddRange(new object[] {
            "Blood Pressure",
            "Temperature",
            "Heart Rate",
            "Breathing Rate"});
            this.Monitor1_Choice.Location = new System.Drawing.Point(25, 19);
            this.Monitor1_Choice.Name = "Monitor1_Choice";
            this.Monitor1_Choice.Size = new System.Drawing.Size(174, 28);
            this.Monitor1_Choice.TabIndex = 23;
            this.Monitor1_Choice.SelectedIndexChanged += new System.EventHandler(this.ChangeMonitor1);
            this.Monitor1_Choice.SelectedValueChanged += new System.EventHandler(this.ChangeMonitor1);
            // 
            // Monitor2_Choice
            // 
            this.Monitor2_Choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monitor2_Choice.FormattingEnabled = true;
            this.Monitor2_Choice.Items.AddRange(new object[] {
            "Blood Pressure",
            "Temperature",
            "Heart Rate",
            "Breathing Rate"});
            this.Monitor2_Choice.Location = new System.Drawing.Point(26, 19);
            this.Monitor2_Choice.Name = "Monitor2_Choice";
            this.Monitor2_Choice.Size = new System.Drawing.Size(174, 28);
            this.Monitor2_Choice.TabIndex = 24;
            this.Monitor2_Choice.SelectedIndexChanged += new System.EventHandler(this.ChangeMonitor2);
            // 
            // Monitor3_Choice
            // 
            this.Monitor3_Choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monitor3_Choice.FormattingEnabled = true;
            this.Monitor3_Choice.Items.AddRange(new object[] {
            "Blood Pressure",
            "Temperature",
            "Heart Rate",
            "Breathing Rate"});
            this.Monitor3_Choice.Location = new System.Drawing.Point(25, 19);
            this.Monitor3_Choice.Name = "Monitor3_Choice";
            this.Monitor3_Choice.Size = new System.Drawing.Size(174, 28);
            this.Monitor3_Choice.TabIndex = 25;
            this.Monitor3_Choice.SelectedIndexChanged += new System.EventHandler(this.ChangeMonitor3);
            // 
            // Monitor4_Choice
            // 
            this.Monitor4_Choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monitor4_Choice.FormattingEnabled = true;
            this.Monitor4_Choice.Items.AddRange(new object[] {
            "Blood Pressure",
            "Temperature",
            "Heart Rate",
            "Breathing Rate"});
            this.Monitor4_Choice.Location = new System.Drawing.Point(26, 22);
            this.Monitor4_Choice.Name = "Monitor4_Choice";
            this.Monitor4_Choice.Size = new System.Drawing.Size(174, 28);
            this.Monitor4_Choice.TabIndex = 26;
            this.Monitor4_Choice.SelectedIndexChanged += new System.EventHandler(this.ChangeMonitor4);
            // 
            // Monitor4_Background
            // 
            this.Monitor4_Background.BackColor = System.Drawing.Color.CadetBlue;
            this.Monitor4_Background.Controls.Add(this.Monitor4_Choice);
            this.Monitor4_Background.Controls.Add(this.Monitor4_CurrentReading);
            this.Monitor4_Background.Location = new System.Drawing.Point(312, 176);
            this.Monitor4_Background.Name = "Monitor4_Background";
            this.Monitor4_Background.Size = new System.Drawing.Size(226, 124);
            this.Monitor4_Background.TabIndex = 27;
            this.Monitor4_Background.TabStop = false;
            // 
            // Monitor3_Background
            // 
            this.Monitor3_Background.BackColor = System.Drawing.Color.CadetBlue;
            this.Monitor3_Background.Controls.Add(this.Monitor3_CurrentReading);
            this.Monitor3_Background.Controls.Add(this.Monitor3_Choice);
            this.Monitor3_Background.Location = new System.Drawing.Point(56, 176);
            this.Monitor3_Background.Name = "Monitor3_Background";
            this.Monitor3_Background.Size = new System.Drawing.Size(226, 124);
            this.Monitor3_Background.TabIndex = 28;
            this.Monitor3_Background.TabStop = false;
            // 
            // Monitor1_Background
            // 
            this.Monitor1_Background.BackColor = System.Drawing.Color.CadetBlue;
            this.Monitor1_Background.Controls.Add(this.Monitor1_Choice);
            this.Monitor1_Background.Controls.Add(this.Monitor1_CurrentReading);
            this.Monitor1_Background.Location = new System.Drawing.Point(56, 37);
            this.Monitor1_Background.Name = "Monitor1_Background";
            this.Monitor1_Background.Size = new System.Drawing.Size(226, 124);
            this.Monitor1_Background.TabIndex = 29;
            this.Monitor1_Background.TabStop = false;
            // 
            // Monitor2_Background
            // 
            this.Monitor2_Background.BackColor = System.Drawing.Color.CadetBlue;
            this.Monitor2_Background.Controls.Add(this.Monitor2_CurrentReading);
            this.Monitor2_Background.Controls.Add(this.Monitor2_Choice);
            this.Monitor2_Background.Location = new System.Drawing.Point(312, 37);
            this.Monitor2_Background.Name = "Monitor2_Background";
            this.Monitor2_Background.Size = new System.Drawing.Size(226, 124);
            this.Monitor2_Background.TabIndex = 30;
            this.Monitor2_Background.TabStop = false;
            // 
            // MonitorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BedValue);
            this.Controls.Add(this.AlarmMessage);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.Monitor4_Background);
            this.Controls.Add(this.Monitor3_Background);
            this.Controls.Add(this.Monitor1_Background);
            this.Controls.Add(this.Monitor2_Background);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MonitorPage";
            this.Text = "Monitor Detailed View";
            this.Load += new System.EventHandler(this.MonitorPage_Load);
            this.Monitor4_Background.ResumeLayout(false);
            this.Monitor4_Background.PerformLayout();
            this.Monitor3_Background.ResumeLayout(false);
            this.Monitor3_Background.PerformLayout();
            this.Monitor1_Background.ResumeLayout(false);
            this.Monitor1_Background.PerformLayout();
            this.Monitor2_Background.ResumeLayout(false);
            this.Monitor2_Background.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //Value of the bed being displayed
        private System.Windows.Forms.Label BedValue;

        //Return button to go back to selection of bays
        private System.Windows.Forms.Button ReturnButton;
        
        //Alarm message
        private System.Windows.Forms.Label AlarmMessage;
       
        //timer for the values to be inputted
        //temperature timer
        private System.Windows.Forms.Timer temperatureValues;
        
        //blood pressure timer
        private System.Windows.Forms.Timer bloodpressureValues;
        
        //pulse timer
        private System.Windows.Forms.Timer pulseValues;
        
        //breathing timer
        private System.Windows.Forms.Timer breathingrateValues;
        private System.Windows.Forms.Label Monitor1_CurrentReading;
        private System.Windows.Forms.Label Monitor3_CurrentReading;
        private System.Windows.Forms.Label Monitor2_CurrentReading;
        private System.Windows.Forms.Label Monitor4_CurrentReading;
        private System.Windows.Forms.Timer pageUpdater;
        private System.Windows.Forms.ComboBox Monitor1_Choice;
        private System.Windows.Forms.ComboBox Monitor2_Choice;
        private System.Windows.Forms.ComboBox Monitor3_Choice;
        private System.Windows.Forms.ComboBox Monitor4_Choice;
        private System.Windows.Forms.GroupBox Monitor4_Background;
        private System.Windows.Forms.GroupBox Monitor3_Background;
        private System.Windows.Forms.GroupBox Monitor1_Background;
        private System.Windows.Forms.GroupBox Monitor2_Background;
    }
}

