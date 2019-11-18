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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BayDisplayTabControl = new System.Windows.Forms.TabControl();
            this.button3 = new System.Windows.Forms.Button();
            this.Updater = new System.Windows.Forms.Timer(this.components);
            this.WardLabel = new System.Windows.Forms.Label();
            this.AlarmDbTestLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Patient Record";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(712, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Management Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(303, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "East Anglia Hospital Trust";
            // 
            // BayDisplayTabControl
            // 
            this.BayDisplayTabControl.Location = new System.Drawing.Point(91, 80);
            this.BayDisplayTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.BayDisplayTabControl.Name = "BayDisplayTabControl";
            this.BayDisplayTabControl.SelectedIndex = 0;
            this.BayDisplayTabControl.Size = new System.Drawing.Size(661, 379);
            this.BayDisplayTabControl.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 13);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "Log off";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.WardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WardLabel.Location = new System.Drawing.Point(375, 42);
            this.WardLabel.Name = "WardLabel";
            this.WardLabel.Size = new System.Drawing.Size(93, 20);
            this.WardLabel.TabIndex = 6;
            this.WardLabel.Text = "Ward Name";
            // 
            // AlarmDbTestLabel
            // 
            this.AlarmDbTestLabel.AutoSize = true;
            this.AlarmDbTestLabel.Location = new System.Drawing.Point(178, 477);
            this.AlarmDbTestLabel.Name = "AlarmDbTestLabel";
            this.AlarmDbTestLabel.Size = new System.Drawing.Size(94, 13);
            this.AlarmDbTestLabel.TabIndex = 7;
            this.AlarmDbTestLabel.Text = "AlarmDbTestLabel";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(842, 509);
            this.Controls.Add(this.AlarmDbTestLabel);
            this.Controls.Add(this.WardLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BayDisplayTabControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl BayDisplayTabControl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer Updater;
        private System.Windows.Forms.Label WardLabel;
        private System.Windows.Forms.Label AlarmDbTestLabel;
    }
}