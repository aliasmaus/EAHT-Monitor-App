namespace ETAHDesign
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
            this.TemperatureText = new System.Windows.Forms.Label();
            this.BloodPressureText = new System.Windows.Forms.Label();
            this.PulseText = new System.Windows.Forms.Label();
            this.BreathingRateText = new System.Windows.Forms.Label();
            this.BreathingAlarm = new System.Windows.Forms.Label();
            this.PulseAlarm = new System.Windows.Forms.Label();
            this.TemperatureAlarm = new System.Windows.Forms.Label();
            this.BloodAlarm = new System.Windows.Forms.Label();
            this.PulseValue = new System.Windows.Forms.Label();
            this.BreathingValue = new System.Windows.Forms.Label();
            this.TemperatureValue = new System.Windows.Forms.Label();
            this.BloodValue = new System.Windows.Forms.Label();
            this.SaveBloodValue = new System.Windows.Forms.Button();
            this.SaveTemperatureValue = new System.Windows.Forms.Button();
            this.SavePulseValue = new System.Windows.Forms.Button();
            this.SaveBreathingValue = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.AlarmMessage = new System.Windows.Forms.Label();
            this.temperatureValues = new System.Windows.Forms.Timer(this.components);
            this.bloodpressureValues = new System.Windows.Forms.Timer(this.components);
            this.pulseValues = new System.Windows.Forms.Timer(this.components);
            this.breathingrateValues = new System.Windows.Forms.Timer(this.components);
            this.BedValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TemperatureText
            // 
            this.TemperatureText.AutoSize = true;
            this.TemperatureText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureText.Location = new System.Drawing.Point(38, 49);
            this.TemperatureText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TemperatureText.Name = "TemperatureText";
            this.TemperatureText.Size = new System.Drawing.Size(100, 20);
            this.TemperatureText.TabIndex = 0;
            this.TemperatureText.Text = "Temperature";
            // 
            // BloodPressureText
            // 
            this.BloodPressureText.AutoSize = true;
            this.BloodPressureText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodPressureText.Location = new System.Drawing.Point(398, 49);
            this.BloodPressureText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BloodPressureText.Name = "BloodPressureText";
            this.BloodPressureText.Size = new System.Drawing.Size(117, 20);
            this.BloodPressureText.TabIndex = 1;
            this.BloodPressureText.Text = "Blood Pressure";
            // 
            // PulseText
            // 
            this.PulseText.AutoSize = true;
            this.PulseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PulseText.Location = new System.Drawing.Point(38, 214);
            this.PulseText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PulseText.Name = "PulseText";
            this.PulseText.Size = new System.Drawing.Size(48, 20);
            this.PulseText.TabIndex = 2;
            this.PulseText.Text = "Pulse";
            // 
            // BreathingRateText
            // 
            this.BreathingRateText.AutoSize = true;
            this.BreathingRateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreathingRateText.Location = new System.Drawing.Point(398, 214);
            this.BreathingRateText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BreathingRateText.Name = "BreathingRateText";
            this.BreathingRateText.Size = new System.Drawing.Size(117, 20);
            this.BreathingRateText.TabIndex = 3;
            this.BreathingRateText.Text = "Breathing Rate";
            this.BreathingRateText.Click += new System.EventHandler(this.label4_Click);
            // 
            // BreathingAlarm
            // 
            this.BreathingAlarm.AutoSize = true;
            this.BreathingAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreathingAlarm.Location = new System.Drawing.Point(399, 235);
            this.BreathingAlarm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BreathingAlarm.Name = "BreathingAlarm";
            this.BreathingAlarm.Size = new System.Drawing.Size(82, 15);
            this.BreathingAlarm.TabIndex = 4;
            this.BreathingAlarm.Text = "Alarm System";
            // 
            // PulseAlarm
            // 
            this.PulseAlarm.AutoSize = true;
            this.PulseAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PulseAlarm.Location = new System.Drawing.Point(39, 235);
            this.PulseAlarm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PulseAlarm.Name = "PulseAlarm";
            this.PulseAlarm.Size = new System.Drawing.Size(82, 15);
            this.PulseAlarm.TabIndex = 5;
            this.PulseAlarm.Text = "Alarm System";
            // 
            // TemperatureAlarm
            // 
            this.TemperatureAlarm.AutoSize = true;
            this.TemperatureAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureAlarm.Location = new System.Drawing.Point(39, 69);
            this.TemperatureAlarm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TemperatureAlarm.Name = "TemperatureAlarm";
            this.TemperatureAlarm.Size = new System.Drawing.Size(82, 15);
            this.TemperatureAlarm.TabIndex = 6;
            this.TemperatureAlarm.Text = "Alarm System";
            // 
            // BloodAlarm
            // 
            this.BloodAlarm.AutoSize = true;
            this.BloodAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodAlarm.Location = new System.Drawing.Point(399, 69);
            this.BloodAlarm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BloodAlarm.Name = "BloodAlarm";
            this.BloodAlarm.Size = new System.Drawing.Size(82, 15);
            this.BloodAlarm.TabIndex = 7;
            this.BloodAlarm.Text = "Alarm System";
            // 
            // PulseValue
            // 
            this.PulseValue.AutoSize = true;
            this.PulseValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PulseValue.Location = new System.Drawing.Point(38, 260);
            this.PulseValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PulseValue.Name = "PulseValue";
            this.PulseValue.Size = new System.Drawing.Size(100, 17);
            this.PulseValue.TabIndex = 8;
            this.PulseValue.Text = "Value Variable";
            this.PulseValue.Click += new System.EventHandler(this.label9_Click);
            // 
            // BreathingValue
            // 
            this.BreathingValue.AutoSize = true;
            this.BreathingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreathingValue.Location = new System.Drawing.Point(398, 260);
            this.BreathingValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BreathingValue.Name = "BreathingValue";
            this.BreathingValue.Size = new System.Drawing.Size(100, 17);
            this.BreathingValue.TabIndex = 9;
            this.BreathingValue.Text = "Value Variable";
            // 
            // TemperatureValue
            // 
            this.TemperatureValue.AutoSize = true;
            this.TemperatureValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureValue.Location = new System.Drawing.Point(38, 96);
            this.TemperatureValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TemperatureValue.Name = "TemperatureValue";
            this.TemperatureValue.Size = new System.Drawing.Size(100, 17);
            this.TemperatureValue.TabIndex = 10;
            this.TemperatureValue.Text = "Value Variable";
            // 
            // BloodValue
            // 
            this.BloodValue.AutoSize = true;
            this.BloodValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodValue.Location = new System.Drawing.Point(398, 96);
            this.BloodValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BloodValue.Name = "BloodValue";
            this.BloodValue.Size = new System.Drawing.Size(100, 17);
            this.BloodValue.TabIndex = 11;
            this.BloodValue.Text = "Value Variable";
            // 
            // SaveBloodValue
            // 
            this.SaveBloodValue.Location = new System.Drawing.Point(410, 115);
            this.SaveBloodValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveBloodValue.Name = "SaveBloodValue";
            this.SaveBloodValue.Size = new System.Drawing.Size(56, 19);
            this.SaveBloodValue.TabIndex = 12;
            this.SaveBloodValue.Text = "Save Value";
            this.SaveBloodValue.UseVisualStyleBackColor = true;
            this.SaveBloodValue.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveTemperatureValue
            // 
            this.SaveTemperatureValue.Location = new System.Drawing.Point(51, 115);
            this.SaveTemperatureValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveTemperatureValue.Name = "SaveTemperatureValue";
            this.SaveTemperatureValue.Size = new System.Drawing.Size(56, 19);
            this.SaveTemperatureValue.TabIndex = 13;
            this.SaveTemperatureValue.Text = "Save Value";
            this.SaveTemperatureValue.UseVisualStyleBackColor = true;
            // 
            // SavePulseValue
            // 
            this.SavePulseValue.Location = new System.Drawing.Point(51, 279);
            this.SavePulseValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SavePulseValue.Name = "SavePulseValue";
            this.SavePulseValue.Size = new System.Drawing.Size(56, 19);
            this.SavePulseValue.TabIndex = 14;
            this.SavePulseValue.Text = "Save Value";
            this.SavePulseValue.UseVisualStyleBackColor = true;
            // 
            // SaveBreathingValue
            // 
            this.SaveBreathingValue.Location = new System.Drawing.Point(410, 279);
            this.SaveBreathingValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveBreathingValue.Name = "SaveBreathingValue";
            this.SaveBreathingValue.Size = new System.Drawing.Size(56, 19);
            this.SaveBreathingValue.TabIndex = 15;
            this.SaveBreathingValue.Text = "Save Value";
            this.SaveBreathingValue.UseVisualStyleBackColor = true;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(535, 10);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(56, 19);
            this.ReturnButton.TabIndex = 16;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
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
            this.BedValue.Location = new System.Drawing.Point(38, 10);
            this.BedValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BedValue.Name = "BedValue";
            this.BedValue.Size = new System.Drawing.Size(51, 20);
            this.BedValue.TabIndex = 18;
            this.BedValue.Text = "Bed 1";
            this.BedValue.Click += new System.EventHandler(this.BayValue_Click);
            // 
            // MonitorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 374);
            this.Controls.Add(this.BedValue);
            this.Controls.Add(this.AlarmMessage);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.SaveBreathingValue);
            this.Controls.Add(this.SavePulseValue);
            this.Controls.Add(this.SaveTemperatureValue);
            this.Controls.Add(this.SaveBloodValue);
            this.Controls.Add(this.BloodValue);
            this.Controls.Add(this.TemperatureValue);
            this.Controls.Add(this.BreathingValue);
            this.Controls.Add(this.PulseValue);
            this.Controls.Add(this.BloodAlarm);
            this.Controls.Add(this.TemperatureAlarm);
            this.Controls.Add(this.PulseAlarm);
            this.Controls.Add(this.BreathingAlarm);
            this.Controls.Add(this.BreathingRateText);
            this.Controls.Add(this.PulseText);
            this.Controls.Add(this.BloodPressureText);
            this.Controls.Add(this.TemperatureText);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MonitorPage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //Value of the bed being displayed
        private System.Windows.Forms.Label BedValue;

        //Temperature bay
        private System.Windows.Forms.Label TemperatureText;
        private System.Windows.Forms.Label TemperatureAlarm;
        private System.Windows.Forms.Label TemperatureValue;
        private System.Windows.Forms.Button SaveTemperatureValue;

        //Blood Pressure bay
        private System.Windows.Forms.Label BloodPressureText;
        private System.Windows.Forms.Label BloodAlarm;
        private System.Windows.Forms.Label BloodValue;
        private System.Windows.Forms.Button SaveBloodValue;
        
        //Pulse bay
        private System.Windows.Forms.Label PulseText;
        private System.Windows.Forms.Label PulseAlarm;
        private System.Windows.Forms.Label PulseValue;
        private System.Windows.Forms.Button SavePulseValue;

        //Breathing Rate bay
        private System.Windows.Forms.Label BreathingRateText;
        private System.Windows.Forms.Label BreathingAlarm;
        private System.Windows.Forms.Label BreathingValue;
        private System.Windows.Forms.Button SaveBreathingValue;

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

    }
}

