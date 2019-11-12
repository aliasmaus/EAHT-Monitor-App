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
            this.TemperatureText = new System.Windows.Forms.Label();
            this.BloodPressureText = new System.Windows.Forms.Label();
            this.PulseText = new System.Windows.Forms.Label();
            this.BreathingRateText = new System.Windows.Forms.Label();
            this.BreathingAlarm = new System.Windows.Forms.Label();
            this.PulseAlarm = new System.Windows.Forms.Label();
            this.TemperatureAlarm = new System.Windows.Forms.Label();
            this.BloodAlarm = new System.Windows.Forms.Label();
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
            this.tempVariable = new System.Windows.Forms.TextBox();
            this.bloodVariable = new System.Windows.Forms.TextBox();
            this.pulseVariable = new System.Windows.Forms.TextBox();
            this.breatingVariable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TemperatureText
            // 
            this.TemperatureText.AutoSize = true;
            this.TemperatureText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureText.Location = new System.Drawing.Point(51, 60);
            this.TemperatureText.Name = "TemperatureText";
            this.TemperatureText.Size = new System.Drawing.Size(124, 25);
            this.TemperatureText.TabIndex = 0;
            this.TemperatureText.Text = "Temperature";
            // 
            // BloodPressureText
            // 
            this.BloodPressureText.AutoSize = true;
            this.BloodPressureText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodPressureText.Location = new System.Drawing.Point(531, 60);
            this.BloodPressureText.Name = "BloodPressureText";
            this.BloodPressureText.Size = new System.Drawing.Size(145, 25);
            this.BloodPressureText.TabIndex = 1;
            this.BloodPressureText.Text = "Blood Pressure";
            // 
            // PulseText
            // 
            this.PulseText.AutoSize = true;
            this.PulseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PulseText.Location = new System.Drawing.Point(51, 263);
            this.PulseText.Name = "PulseText";
            this.PulseText.Size = new System.Drawing.Size(61, 25);
            this.PulseText.TabIndex = 2;
            this.PulseText.Text = "Pulse";
            // 
            // BreathingRateText
            // 
            this.BreathingRateText.AutoSize = true;
            this.BreathingRateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreathingRateText.Location = new System.Drawing.Point(531, 263);
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
            // SaveBloodValue
            // 
            this.SaveBloodValue.Location = new System.Drawing.Point(547, 142);
            this.SaveBloodValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveBloodValue.Name = "SaveBloodValue";
            this.SaveBloodValue.Size = new System.Drawing.Size(75, 23);
            this.SaveBloodValue.TabIndex = 12;
            this.SaveBloodValue.Text = "Save Value";
            this.SaveBloodValue.UseVisualStyleBackColor = true;
            this.SaveBloodValue.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveTemperatureValue
            // 
            this.SaveTemperatureValue.Location = new System.Drawing.Point(68, 142);
            this.SaveTemperatureValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveTemperatureValue.Name = "SaveTemperatureValue";
            this.SaveTemperatureValue.Size = new System.Drawing.Size(75, 23);
            this.SaveTemperatureValue.TabIndex = 13;
            this.SaveTemperatureValue.Text = "Save Value";
            this.SaveTemperatureValue.UseVisualStyleBackColor = true;
            // 
            // SavePulseValue
            // 
            this.SavePulseValue.Location = new System.Drawing.Point(68, 343);
            this.SavePulseValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SavePulseValue.Name = "SavePulseValue";
            this.SavePulseValue.Size = new System.Drawing.Size(75, 23);
            this.SavePulseValue.TabIndex = 14;
            this.SavePulseValue.Text = "Save Value";
            this.SavePulseValue.UseVisualStyleBackColor = true;
            // 
            // SaveBreathingValue
            // 
            this.SaveBreathingValue.Location = new System.Drawing.Point(547, 343);
            this.SaveBreathingValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveBreathingValue.Name = "SaveBreathingValue";
            this.SaveBreathingValue.Size = new System.Drawing.Size(75, 23);
            this.SaveBreathingValue.TabIndex = 15;
            this.SaveBreathingValue.Text = "Save Value";
            this.SaveBreathingValue.UseVisualStyleBackColor = true;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(713, 12);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.BedValue.Location = new System.Drawing.Point(51, 12);
            this.BedValue.Name = "BedValue";
            this.BedValue.Size = new System.Drawing.Size(63, 25);
            this.BedValue.TabIndex = 18;
            this.BedValue.Text = "Bed 1";
            this.BedValue.Click += new System.EventHandler(this.BayValue_Click);
            // 
            // tempVariable
            // 
            this.tempVariable.Location = new System.Drawing.Point(55, 115);
            this.tempVariable.Name = "tempVariable";
            this.tempVariable.Size = new System.Drawing.Size(120, 22);
            this.tempVariable.TabIndex = 19;
            // 
            // bloodVariable
            // 
            this.bloodVariable.Location = new System.Drawing.Point(535, 115);
            this.bloodVariable.Name = "bloodVariable";
            this.bloodVariable.Size = new System.Drawing.Size(120, 22);
            this.bloodVariable.TabIndex = 20;
            // 
            // pulseVariable
            // 
            this.pulseVariable.Location = new System.Drawing.Point(56, 316);
            this.pulseVariable.Name = "pulseVariable";
            this.pulseVariable.Size = new System.Drawing.Size(120, 22);
            this.pulseVariable.TabIndex = 21;
            this.pulseVariable.TextChanged += new System.EventHandler(this.pulseVariable_TextChanged);
            // 
            // breatingVariable
            // 
            this.breatingVariable.Location = new System.Drawing.Point(535, 316);
            this.breatingVariable.Name = "breatingVariable";
            this.breatingVariable.Size = new System.Drawing.Size(120, 22);
            this.breatingVariable.TabIndex = 22;
            // 
            // MonitorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.breatingVariable);
            this.Controls.Add(this.pulseVariable);
            this.Controls.Add(this.bloodVariable);
            this.Controls.Add(this.tempVariable);
            this.Controls.Add(this.BedValue);
            this.Controls.Add(this.AlarmMessage);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.SaveBreathingValue);
            this.Controls.Add(this.SavePulseValue);
            this.Controls.Add(this.SaveTemperatureValue);
            this.Controls.Add(this.SaveBloodValue);
            this.Controls.Add(this.BloodAlarm);
            this.Controls.Add(this.TemperatureAlarm);
            this.Controls.Add(this.PulseAlarm);
            this.Controls.Add(this.BreathingAlarm);
            this.Controls.Add(this.BreathingRateText);
            this.Controls.Add(this.PulseText);
            this.Controls.Add(this.BloodPressureText);
            this.Controls.Add(this.TemperatureText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MonitorPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MonitorPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //Value of the bed being displayed
        private System.Windows.Forms.Label BedValue;

        //Temperature bay
        private System.Windows.Forms.Label TemperatureText;
        private System.Windows.Forms.Label TemperatureAlarm;
        private System.Windows.Forms.Button SaveTemperatureValue;
        private System.Windows.Forms.TextBox tempVariable;

        //Blood Pressure bay
        private System.Windows.Forms.Label BloodPressureText;
        private System.Windows.Forms.Label BloodAlarm;
        private System.Windows.Forms.Button SaveBloodValue;
        private System.Windows.Forms.TextBox bloodVariable;

        //Pulse bay
        private System.Windows.Forms.Label PulseText;
        private System.Windows.Forms.Label PulseAlarm;
        private System.Windows.Forms.Button SavePulseValue;
        private System.Windows.Forms.TextBox pulseVariable;

        //Breathing Rate bay
        private System.Windows.Forms.Label BreathingRateText;
        private System.Windows.Forms.Label BreathingAlarm;
        private System.Windows.Forms.Button SaveBreathingValue;
        private System.Windows.Forms.TextBox breatingVariable;

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

