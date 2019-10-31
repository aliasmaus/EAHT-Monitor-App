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
            this.TemperatureText.Location = new System.Drawing.Point(50, 60);
            this.TemperatureText.Name = "TemperatureText";
            this.TemperatureText.Size = new System.Drawing.Size(124, 25);
            this.TemperatureText.TabIndex = 0;
            this.TemperatureText.Text = "Temperature";
            // 
            // BloodPressureText
            // 
            this.BloodPressureText.AutoSize = true;
            this.BloodPressureText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodPressureText.Location = new System.Drawing.Point(530, 60);
            this.BloodPressureText.Name = "BloodPressureText";
            this.BloodPressureText.Size = new System.Drawing.Size(145, 25);
            this.BloodPressureText.TabIndex = 1;
            this.BloodPressureText.Text = "Blood Pressure";
            // 
            // PulseText
            // 
            this.PulseText.AutoSize = true;
            this.PulseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PulseText.Location = new System.Drawing.Point(50, 264);
            this.PulseText.Name = "PulseText";
            this.PulseText.Size = new System.Drawing.Size(61, 25);
            this.PulseText.TabIndex = 2;
            this.PulseText.Text = "Pulse";
            // 
            // BreathingRateText
            // 
            this.BreathingRateText.AutoSize = true;
            this.BreathingRateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreathingRateText.Location = new System.Drawing.Point(530, 264);
            this.BreathingRateText.Name = "BreathingRateText";
            this.BreathingRateText.Size = new System.Drawing.Size(140, 25);
            this.BreathingRateText.TabIndex = 3;
            this.BreathingRateText.Text = "Breathing Rate";
            this.BreathingRateText.Click += new System.EventHandler(this.label4_Click);
            // 
            // BreathingAlarm
            // 
            this.BreathingAlarm.AutoSize = true;
            this.BreathingAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreathingAlarm.Location = new System.Drawing.Point(532, 289);
            this.BreathingAlarm.Name = "BreathingAlarm";
            this.BreathingAlarm.Size = new System.Drawing.Size(100, 18);
            this.BreathingAlarm.TabIndex = 4;
            this.BreathingAlarm.Text = "Alarm System";
            // 
            // PulseAlarm
            // 
            this.PulseAlarm.AutoSize = true;
            this.PulseAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PulseAlarm.Location = new System.Drawing.Point(52, 289);
            this.PulseAlarm.Name = "PulseAlarm";
            this.PulseAlarm.Size = new System.Drawing.Size(100, 18);
            this.PulseAlarm.TabIndex = 5;
            this.PulseAlarm.Text = "Alarm System";
            // 
            // TemperatureAlarm
            // 
            this.TemperatureAlarm.AutoSize = true;
            this.TemperatureAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureAlarm.Location = new System.Drawing.Point(52, 85);
            this.TemperatureAlarm.Name = "TemperatureAlarm";
            this.TemperatureAlarm.Size = new System.Drawing.Size(100, 18);
            this.TemperatureAlarm.TabIndex = 6;
            this.TemperatureAlarm.Text = "Alarm System";
            // 
            // BloodAlarm
            // 
            this.BloodAlarm.AutoSize = true;
            this.BloodAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodAlarm.Location = new System.Drawing.Point(532, 85);
            this.BloodAlarm.Name = "BloodAlarm";
            this.BloodAlarm.Size = new System.Drawing.Size(100, 18);
            this.BloodAlarm.TabIndex = 7;
            this.BloodAlarm.Text = "Alarm System";
            // 
            // PulseValue
            // 
            this.PulseValue.AutoSize = true;
            this.PulseValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PulseValue.Location = new System.Drawing.Point(51, 320);
            this.PulseValue.Name = "PulseValue";
            this.PulseValue.Size = new System.Drawing.Size(117, 20);
            this.PulseValue.TabIndex = 8;
            this.PulseValue.Text = "Value Variable";
            this.PulseValue.Click += new System.EventHandler(this.label9_Click);
            // 
            // BreathingValue
            // 
            this.BreathingValue.AutoSize = true;
            this.BreathingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreathingValue.Location = new System.Drawing.Point(531, 320);
            this.BreathingValue.Name = "BreathingValue";
            this.BreathingValue.Size = new System.Drawing.Size(117, 20);
            this.BreathingValue.TabIndex = 9;
            this.BreathingValue.Text = "Value Variable";
            // 
            // TemperatureValue
            // 
            this.TemperatureValue.AutoSize = true;
            this.TemperatureValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureValue.Location = new System.Drawing.Point(51, 118);
            this.TemperatureValue.Name = "TemperatureValue";
            this.TemperatureValue.Size = new System.Drawing.Size(117, 20);
            this.TemperatureValue.TabIndex = 10;
            this.TemperatureValue.Text = "Value Variable";
            // 
            // BloodValue
            // 
            this.BloodValue.AutoSize = true;
            this.BloodValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodValue.Location = new System.Drawing.Point(531, 118);
            this.BloodValue.Name = "BloodValue";
            this.BloodValue.Size = new System.Drawing.Size(117, 20);
            this.BloodValue.TabIndex = 11;
            this.BloodValue.Text = "Value Variable";
            // 
            // SaveBloodValue
            // 
            this.SaveBloodValue.Location = new System.Drawing.Point(546, 141);
            this.SaveBloodValue.Name = "SaveBloodValue";
            this.SaveBloodValue.Size = new System.Drawing.Size(75, 23);
            this.SaveBloodValue.TabIndex = 12;
            this.SaveBloodValue.Text = "Save Value";
            this.SaveBloodValue.UseVisualStyleBackColor = true;
            this.SaveBloodValue.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveTemperatureValue
            // 
            this.SaveTemperatureValue.Location = new System.Drawing.Point(68, 141);
            this.SaveTemperatureValue.Name = "SaveTemperatureValue";
            this.SaveTemperatureValue.Size = new System.Drawing.Size(75, 23);
            this.SaveTemperatureValue.TabIndex = 13;
            this.SaveTemperatureValue.Text = "Save Value";
            this.SaveTemperatureValue.UseVisualStyleBackColor = true;
            // 
            // SavePulseValue
            // 
            this.SavePulseValue.Location = new System.Drawing.Point(68, 343);
            this.SavePulseValue.Name = "SavePulseValue";
            this.SavePulseValue.Size = new System.Drawing.Size(75, 23);
            this.SavePulseValue.TabIndex = 14;
            this.SavePulseValue.Text = "Save Value";
            this.SavePulseValue.UseVisualStyleBackColor = true;
            // 
            // SaveBreathingValue
            // 
            this.SaveBreathingValue.Location = new System.Drawing.Point(546, 343);
            this.SaveBreathingValue.Name = "SaveBreathingValue";
            this.SaveBreathingValue.Size = new System.Drawing.Size(75, 23);
            this.SaveBreathingValue.TabIndex = 15;
            this.SaveBreathingValue.Text = "Save Value";
            this.SaveBreathingValue.UseVisualStyleBackColor = true;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(713, 12);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 16;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            // 
            // AlarmMessage
            // 
            this.AlarmMessage.AutoSize = true;
            this.AlarmMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmMessage.Location = new System.Drawing.Point(244, 394);
            this.AlarmMessage.Name = "AlarmMessage";
            this.AlarmMessage.Size = new System.Drawing.Size(257, 25);
            this.AlarmMessage.TabIndex = 17;
            this.AlarmMessage.Text = "Alarm Preset Message Here";
            this.AlarmMessage.Click += new System.EventHandler(this.label13_Click);
            // 
            // BedValue
            // 
            this.BedValue.AutoSize = true;
            this.BedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedValue.Location = new System.Drawing.Point(50, 12);
            this.BedValue.Name = "BedValue";
            this.BedValue.Size = new System.Drawing.Size(63, 25);
            this.BedValue.TabIndex = 18;
            this.BedValue.Text = "Bed 1";
            this.BedValue.Click += new System.EventHandler(this.BayValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
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

