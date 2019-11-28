namespace EAHT_App_UI
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.ManagementButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BayDisplayTabControl = new System.Windows.Forms.TabControl();
            this.LogOffButton = new System.Windows.Forms.Button();
            this.Updater = new System.Windows.Forms.Timer(this.components);
            this.WardLabel = new System.Windows.Forms.Label();
            this.AlarmMessages = new System.Windows.Forms.TextBox();
            this.AlarmBoxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ManagementButton
            // 
            this.ManagementButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ManagementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagementButton.ForeColor = System.Drawing.Color.Maroon;
            this.ManagementButton.Location = new System.Drawing.Point(565, 17);
            this.ManagementButton.Margin = new System.Windows.Forms.Padding(2);
            this.ManagementButton.Name = "ManagementButton";
            this.ManagementButton.Size = new System.Drawing.Size(102, 47);
            this.ManagementButton.TabIndex = 1;
            this.ManagementButton.Text = "Management";
            this.ManagementButton.UseVisualStyleBackColor = false;
            this.ManagementButton.Click += new System.EventHandler(this.OpenManagementPage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(228, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "East Anglia Hospital Trust";
            // 
            // BayDisplayTabControl
            // 
            this.BayDisplayTabControl.Location = new System.Drawing.Point(17, 81);
            this.BayDisplayTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.BayDisplayTabControl.Name = "BayDisplayTabControl";
            this.BayDisplayTabControl.SelectedIndex = 0;
            this.BayDisplayTabControl.Size = new System.Drawing.Size(650, 330);
            this.BayDisplayTabControl.TabIndex = 4;
            // 
            // LogOffButton
            // 
            this.LogOffButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.LogOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOffButton.Location = new System.Drawing.Point(17, 19);
            this.LogOffButton.Margin = new System.Windows.Forms.Padding(2);
            this.LogOffButton.Name = "LogOffButton";
            this.LogOffButton.Size = new System.Drawing.Size(76, 45);
            this.LogOffButton.TabIndex = 5;
            this.LogOffButton.Text = "Log off";
            this.LogOffButton.UseVisualStyleBackColor = false;
            this.LogOffButton.Click += new System.EventHandler(this.LogOff);
            // 
            // Updater
            // 
            this.Updater.Enabled = true;
            this.Updater.Interval = 1000;
            this.Updater.Tick += new System.EventHandler(this.Update_MainPage);
            // 
            // WardLabel
            // 
            this.WardLabel.AutoSize = true;
            this.WardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WardLabel.Location = new System.Drawing.Point(295, 55);
            this.WardLabel.Name = "WardLabel";
            this.WardLabel.Size = new System.Drawing.Size(102, 20);
            this.WardLabel.TabIndex = 6;
            this.WardLabel.Text = "Ward Name";
            // 
            // AlarmMessages
            // 
            this.AlarmMessages.Location = new System.Drawing.Point(17, 432);
            this.AlarmMessages.Multiline = true;
            this.AlarmMessages.Name = "AlarmMessages";
            this.AlarmMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AlarmMessages.Size = new System.Drawing.Size(650, 58);
            this.AlarmMessages.TabIndex = 7;
            // 
            // AlarmBoxLabel
            // 
            this.AlarmBoxLabel.AutoSize = true;
            this.AlarmBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmBoxLabel.Location = new System.Drawing.Point(12, 413);
            this.AlarmBoxLabel.Name = "AlarmBoxLabel";
            this.AlarmBoxLabel.Size = new System.Drawing.Size(95, 16);
            this.AlarmBoxLabel.TabIndex = 8;
            this.AlarmBoxLabel.Text = "Current Alarms";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.AlarmBoxLabel);
            this.Controls.Add(this.AlarmMessages);
            this.Controls.Add(this.WardLabel);
            this.Controls.Add(this.LogOffButton);
            this.Controls.Add(this.BayDisplayTabControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManagementButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ManagementButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl BayDisplayTabControl;
        private System.Windows.Forms.Button LogOffButton;
        private System.Windows.Forms.Timer Updater;
        private System.Windows.Forms.Label WardLabel;
        private System.Windows.Forms.TextBox AlarmMessages;
        private System.Windows.Forms.Label AlarmBoxLabel;
    }
}