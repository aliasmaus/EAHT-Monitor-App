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
            this.BedValue = new System.Windows.Forms.Label();
            this.pageUpdater = new System.Windows.Forms.Timer(this.components);
            this.MonitorPageFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AlarmMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BedValue
            // 
            this.BedValue.AutoSize = true;
            this.BedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedValue.Location = new System.Drawing.Point(251, 11);
            this.BedValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BedValue.Name = "BedValue";
            this.BedValue.Size = new System.Drawing.Size(98, 20);
            this.BedValue.TabIndex = 18;
            this.BedValue.Text = "Bed Number";
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
            this.MonitorPageFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MonitorPageFlowPanel.Location = new System.Drawing.Point(40, 33);
            this.MonitorPageFlowPanel.Name = "MonitorPageFlowPanel";
            this.MonitorPageFlowPanel.Size = new System.Drawing.Size(530, 280);
            this.MonitorPageFlowPanel.TabIndex = 30;
            // 
            // AlarmMessage
            // 
            this.AlarmMessage.Location = new System.Drawing.Point(40, 320);
            this.AlarmMessage.Multiline = true;
            this.AlarmMessage.Name = "AlarmMessage";
            this.AlarmMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AlarmMessage.Size = new System.Drawing.Size(530, 40);
            this.AlarmMessage.TabIndex = 31;
            // 
            // MonitorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.AlarmMessage);
            this.Controls.Add(this.MonitorPageFlowPanel);
            this.Controls.Add(this.BedValue);
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
    }
}

