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
            this.AlarmMessage = new System.Windows.Forms.Label();
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.monitor4_MaxValueSelect = new System.Windows.Forms.NumericUpDown();
            this.monitor4_MinValueSelect = new System.Windows.Forms.NumericUpDown();
            this.Monitor3_Background = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monitor3_MaxValueSelect = new System.Windows.Forms.NumericUpDown();
            this.monitor3_MinValueSelect = new System.Windows.Forms.NumericUpDown();
            this.Monitor1_Background = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monitor1_MaxValueSelect = new System.Windows.Forms.NumericUpDown();
            this.monitor1_MinValueSelect = new System.Windows.Forms.NumericUpDown();
            this.Monitor2_Background = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.monitor2_MaxValueSelect = new System.Windows.Forms.NumericUpDown();
            this.monitor2_MinValueSelect = new System.Windows.Forms.NumericUpDown();
            this.Monitor4_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitor4_MaxValueSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitor4_MinValueSelect)).BeginInit();
            this.Monitor3_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitor3_MaxValueSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitor3_MinValueSelect)).BeginInit();
            this.Monitor1_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitor1_MaxValueSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitor1_MinValueSelect)).BeginInit();
            this.Monitor2_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitor2_MaxValueSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitor2_MinValueSelect)).BeginInit();
            this.SuspendLayout();
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
            // 
            // Monitor1_CurrentReading
            // 
            this.Monitor1_CurrentReading.AutoSize = true;
            this.Monitor1_CurrentReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monitor1_CurrentReading.Location = new System.Drawing.Point(9, 42);
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
            this.Monitor3_CurrentReading.Location = new System.Drawing.Point(15, 40);
            this.Monitor3_CurrentReading.Name = "Monitor3_CurrentReading";
            this.Monitor3_CurrentReading.Size = new System.Drawing.Size(80, 55);
            this.Monitor3_CurrentReading.TabIndex = 20;
            this.Monitor3_CurrentReading.Text = "##";
            this.Monitor3_CurrentReading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Monitor2_CurrentReading
            // 
            this.Monitor2_CurrentReading.AutoSize = true;
            this.Monitor2_CurrentReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monitor2_CurrentReading.Location = new System.Drawing.Point(16, 42);
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
            this.Monitor4_CurrentReading.Location = new System.Drawing.Point(16, 40);
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
            this.Monitor1_Choice.Location = new System.Drawing.Point(25, 11);
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
            this.Monitor2_Choice.Location = new System.Drawing.Point(26, 11);
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
            this.Monitor3_Choice.Location = new System.Drawing.Point(25, 9);
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
            this.Monitor4_Choice.Location = new System.Drawing.Point(26, 9);
            this.Monitor4_Choice.Name = "Monitor4_Choice";
            this.Monitor4_Choice.Size = new System.Drawing.Size(174, 28);
            this.Monitor4_Choice.TabIndex = 26;
            this.Monitor4_Choice.SelectedIndexChanged += new System.EventHandler(this.ChangeMonitor4);
            // 
            // Monitor4_Background
            // 
            this.Monitor4_Background.BackColor = System.Drawing.Color.CadetBlue;
            this.Monitor4_Background.Controls.Add(this.label7);
            this.Monitor4_Background.Controls.Add(this.label8);
            this.Monitor4_Background.Controls.Add(this.monitor4_MaxValueSelect);
            this.Monitor4_Background.Controls.Add(this.monitor4_MinValueSelect);
            this.Monitor4_Background.Controls.Add(this.Monitor4_Choice);
            this.Monitor4_Background.Controls.Add(this.Monitor4_CurrentReading);
            this.Monitor4_Background.Location = new System.Drawing.Point(312, 176);
            this.Monitor4_Background.Name = "Monitor4_Background";
            this.Monitor4_Background.Size = new System.Drawing.Size(226, 124);
            this.Monitor4_Background.TabIndex = 27;
            this.Monitor4_Background.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Max";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Alarm Min";
            // 
            // monitor4_MaxValueSelect
            // 
            this.monitor4_MaxValueSelect.Location = new System.Drawing.Point(168, 98);
            this.monitor4_MaxValueSelect.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.monitor4_MaxValueSelect.Name = "monitor4_MaxValueSelect";
            this.monitor4_MaxValueSelect.Size = new System.Drawing.Size(52, 20);
            this.monitor4_MaxValueSelect.TabIndex = 36;
            this.monitor4_MaxValueSelect.ValueChanged += new System.EventHandler(this.Monitor4MaxChanged);
            // 
            // monitor4_MinValueSelect
            // 
            this.monitor4_MinValueSelect.Location = new System.Drawing.Point(74, 98);
            this.monitor4_MinValueSelect.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.monitor4_MinValueSelect.Name = "monitor4_MinValueSelect";
            this.monitor4_MinValueSelect.Size = new System.Drawing.Size(52, 20);
            this.monitor4_MinValueSelect.TabIndex = 35;
            this.monitor4_MinValueSelect.ValueChanged += new System.EventHandler(this.Monitor4MinChanged);
            // 
            // Monitor3_Background
            // 
            this.Monitor3_Background.BackColor = System.Drawing.Color.CadetBlue;
            this.Monitor3_Background.Controls.Add(this.label3);
            this.Monitor3_Background.Controls.Add(this.label4);
            this.Monitor3_Background.Controls.Add(this.monitor3_MaxValueSelect);
            this.Monitor3_Background.Controls.Add(this.monitor3_MinValueSelect);
            this.Monitor3_Background.Controls.Add(this.Monitor3_CurrentReading);
            this.Monitor3_Background.Controls.Add(this.Monitor3_Choice);
            this.Monitor3_Background.Location = new System.Drawing.Point(56, 176);
            this.Monitor3_Background.Name = "Monitor3_Background";
            this.Monitor3_Background.Size = new System.Drawing.Size(226, 124);
            this.Monitor3_Background.TabIndex = 28;
            this.Monitor3_Background.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Alarm Min";
            // 
            // monitor3_MaxValueSelect
            // 
            this.monitor3_MaxValueSelect.Location = new System.Drawing.Point(156, 98);
            this.monitor3_MaxValueSelect.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.monitor3_MaxValueSelect.Name = "monitor3_MaxValueSelect";
            this.monitor3_MaxValueSelect.Size = new System.Drawing.Size(52, 20);
            this.monitor3_MaxValueSelect.TabIndex = 34;
            this.monitor3_MaxValueSelect.ValueChanged += new System.EventHandler(this.Monitor3MaxChanged);
            // 
            // monitor3_MinValueSelect
            // 
            this.monitor3_MinValueSelect.Location = new System.Drawing.Point(69, 98);
            this.monitor3_MinValueSelect.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.monitor3_MinValueSelect.Name = "monitor3_MinValueSelect";
            this.monitor3_MinValueSelect.Size = new System.Drawing.Size(52, 20);
            this.monitor3_MinValueSelect.TabIndex = 33;
            this.monitor3_MinValueSelect.ValueChanged += new System.EventHandler(this.Monitor3MinChanged);
            // 
            // Monitor1_Background
            // 
            this.Monitor1_Background.BackColor = System.Drawing.Color.CadetBlue;
            this.Monitor1_Background.Controls.Add(this.label2);
            this.Monitor1_Background.Controls.Add(this.label1);
            this.Monitor1_Background.Controls.Add(this.monitor1_MaxValueSelect);
            this.Monitor1_Background.Controls.Add(this.monitor1_MinValueSelect);
            this.Monitor1_Background.Controls.Add(this.Monitor1_Choice);
            this.Monitor1_Background.Controls.Add(this.Monitor1_CurrentReading);
            this.Monitor1_Background.Location = new System.Drawing.Point(56, 37);
            this.Monitor1_Background.Name = "Monitor1_Background";
            this.Monitor1_Background.Size = new System.Drawing.Size(226, 124);
            this.Monitor1_Background.TabIndex = 29;
            this.Monitor1_Background.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Alarm Min";
            // 
            // monitor1_MaxValueSelect
            // 
            this.monitor1_MaxValueSelect.Location = new System.Drawing.Point(156, 98);
            this.monitor1_MaxValueSelect.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.monitor1_MaxValueSelect.Name = "monitor1_MaxValueSelect";
            this.monitor1_MaxValueSelect.Size = new System.Drawing.Size(52, 20);
            this.monitor1_MaxValueSelect.TabIndex = 25;
            this.monitor1_MaxValueSelect.ValueChanged += new System.EventHandler(this.Monitor1MaxChanged);
            // 
            // monitor1_MinValueSelect
            // 
            this.monitor1_MinValueSelect.Location = new System.Drawing.Point(69, 98);
            this.monitor1_MinValueSelect.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.monitor1_MinValueSelect.Name = "monitor1_MinValueSelect";
            this.monitor1_MinValueSelect.Size = new System.Drawing.Size(52, 20);
            this.monitor1_MinValueSelect.TabIndex = 24;
            this.monitor1_MinValueSelect.ValueChanged += new System.EventHandler(this.Monitor1MinChanged);
            // 
            // Monitor2_Background
            // 
            this.Monitor2_Background.BackColor = System.Drawing.Color.CadetBlue;
            this.Monitor2_Background.Controls.Add(this.label5);
            this.Monitor2_Background.Controls.Add(this.label6);
            this.Monitor2_Background.Controls.Add(this.monitor2_MaxValueSelect);
            this.Monitor2_Background.Controls.Add(this.monitor2_MinValueSelect);
            this.Monitor2_Background.Controls.Add(this.Monitor2_CurrentReading);
            this.Monitor2_Background.Controls.Add(this.Monitor2_Choice);
            this.Monitor2_Background.Location = new System.Drawing.Point(312, 37);
            this.Monitor2_Background.Name = "Monitor2_Background";
            this.Monitor2_Background.Size = new System.Drawing.Size(226, 124);
            this.Monitor2_Background.TabIndex = 30;
            this.Monitor2_Background.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Alarm Min";
            // 
            // monitor2_MaxValueSelect
            // 
            this.monitor2_MaxValueSelect.Location = new System.Drawing.Point(168, 98);
            this.monitor2_MaxValueSelect.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.monitor2_MaxValueSelect.Name = "monitor2_MaxValueSelect";
            this.monitor2_MaxValueSelect.Size = new System.Drawing.Size(52, 20);
            this.monitor2_MaxValueSelect.TabIndex = 32;
            this.monitor2_MaxValueSelect.ValueChanged += new System.EventHandler(this.Monitor1MaxChanged);
            // 
            // monitor2_MinValueSelect
            // 
            this.monitor2_MinValueSelect.Location = new System.Drawing.Point(74, 98);
            this.monitor2_MinValueSelect.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.monitor2_MinValueSelect.Name = "monitor2_MinValueSelect";
            this.monitor2_MinValueSelect.Size = new System.Drawing.Size(52, 20);
            this.monitor2_MinValueSelect.TabIndex = 31;
            this.monitor2_MinValueSelect.ValueChanged += new System.EventHandler(this.Monitor2MinChanged);
            // 
            // MonitorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BedValue);
            this.Controls.Add(this.AlarmMessage);
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
            ((System.ComponentModel.ISupportInitialize)(this.monitor4_MaxValueSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitor4_MinValueSelect)).EndInit();
            this.Monitor3_Background.ResumeLayout(false);
            this.Monitor3_Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitor3_MaxValueSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitor3_MinValueSelect)).EndInit();
            this.Monitor1_Background.ResumeLayout(false);
            this.Monitor1_Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitor1_MaxValueSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitor1_MinValueSelect)).EndInit();
            this.Monitor2_Background.ResumeLayout(false);
            this.Monitor2_Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitor2_MaxValueSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitor2_MinValueSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //Value of the bed being displayed
        private System.Windows.Forms.Label BedValue;
        
        //Alarm message
        private System.Windows.Forms.Label AlarmMessage;
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
        private System.Windows.Forms.NumericUpDown monitor1_MaxValueSelect;
        private System.Windows.Forms.NumericUpDown monitor1_MinValueSelect;
        private System.Windows.Forms.NumericUpDown monitor4_MaxValueSelect;
        private System.Windows.Forms.NumericUpDown monitor4_MinValueSelect;
        private System.Windows.Forms.NumericUpDown monitor3_MaxValueSelect;
        private System.Windows.Forms.NumericUpDown monitor3_MinValueSelect;
        private System.Windows.Forms.NumericUpDown monitor2_MaxValueSelect;
        private System.Windows.Forms.NumericUpDown monitor2_MinValueSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

