using System;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorPage));
            this.BedValue = new System.Windows.Forms.Label();
            this.pageUpdater = new System.Windows.Forms.Timer(this.components);
            this.MonitorPageFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AlarmMessage = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AlarmNotificationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BedValue
            // 
            this.BedValue.AutoSize = true;
            this.BedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedValue.Location = new System.Drawing.Point(243, 17);
            this.BedValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BedValue.Name = "BedValue";
            this.BedValue.Size = new System.Drawing.Size(105, 31);
            this.BedValue.TabIndex = 18;
            this.BedValue.Text = "Bed ##";
            // 
            // pageUpdater
            // 
            this.pageUpdater.Enabled = true;
            this.pageUpdater.Interval = 1000;
            this.pageUpdater.Tick += new System.EventHandler(this.PageUpdate);
            // 
            // MonitorPageFlowPanel
            // 
            this.MonitorPageFlowPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MonitorPageFlowPanel.AutoScroll = true;
            this.MonitorPageFlowPanel.Location = new System.Drawing.Point(28, 59);
            this.MonitorPageFlowPanel.Name = "MonitorPageFlowPanel";
            this.MonitorPageFlowPanel.Size = new System.Drawing.Size(530, 280);
            this.MonitorPageFlowPanel.TabIndex = 30;
            // 
            // AlarmMessage
            // 
            this.AlarmMessage.Location = new System.Drawing.Point(28, 368);
            this.AlarmMessage.Multiline = true;
            this.AlarmMessage.Name = "AlarmMessage";
            this.AlarmMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AlarmMessage.Size = new System.Drawing.Size(530, 40);
            this.AlarmMessage.TabIndex = 31;
            this.AlarmMessage.TextChanged += new System.EventHandler(this.AlarmMessage_TextChanged);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(28, 423);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(170, 37);
            this.RegisterButton.TabIndex = 32;
            this.RegisterButton.Text = "Register for Notifications";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterStaffForNotifications);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(381, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 37);
            this.button1.TabIndex = 33;
            this.button1.Text = "Deregister for Notifications";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.DeregisterStaffForNotifications);
            // 
            // AlarmNotificationLabel
            // 
            this.AlarmNotificationLabel.AutoSize = true;
            this.AlarmNotificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmNotificationLabel.Location = new System.Drawing.Point(25, 349);
            this.AlarmNotificationLabel.Name = "AlarmNotificationLabel";
            this.AlarmNotificationLabel.Size = new System.Drawing.Size(145, 16);
            this.AlarmNotificationLabel.TabIndex = 34;
            this.AlarmNotificationLabel.Text = "Current alarm status";
            // 
            // MonitorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(593, 487);
            this.Controls.Add(this.AlarmNotificationLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.AlarmMessage);
            this.Controls.Add(this.MonitorPageFlowPanel);
            this.Controls.Add(this.BedValue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MonitorPage";
            this.Text = "Monitor Detailed View";
            this.Load += new System.EventHandler(this.MonitorPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //Value of the bed being displayed
        private System.Windows.Forms.Label BedValue;
        private System.Windows.Forms.Timer pageUpdater;
        private System.Windows.Forms.FlowLayoutPanel MonitorPageFlowPanel;
        private System.Windows.Forms.TextBox AlarmMessage;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label AlarmNotificationLabel;
    }
}

