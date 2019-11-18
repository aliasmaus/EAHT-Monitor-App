namespace EAHT_App_UI
{
    partial class WelcomePage
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
            this.HospitalName = new System.Windows.Forms.Label();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.WardSelectorBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // HospitalName
            // 
            this.HospitalName.AutoSize = true;
            this.HospitalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HospitalName.Location = new System.Drawing.Point(328, 129);
            this.HospitalName.Name = "HospitalName";
            this.HospitalName.Size = new System.Drawing.Size(145, 50);
            this.HospitalName.TabIndex = 0;
            this.HospitalName.Text = "East Anglia\r\nHospital Trust";
            this.HospitalName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.Location = new System.Drawing.Point(305, 253);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(190, 13);
            this.WelcomeMessage.TabIndex = 1;
            this.WelcomeMessage.Text = "Welcome, please select a ward to load";
            // 
            // WardSelectorBox
            // 
            this.WardSelectorBox.FormattingEnabled = true;
            this.WardSelectorBox.Location = new System.Drawing.Point(340, 300);
            this.WardSelectorBox.Name = "WardSelectorBox";
            this.WardSelectorBox.Size = new System.Drawing.Size(121, 21);
            this.WardSelectorBox.TabIndex = 2;
            this.WardSelectorBox.SelectionChangeCommitted += new System.EventHandler(this.LoadWardMainPage);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WardSelectorBox);
            this.Controls.Add(this.WelcomeMessage);
            this.Controls.Add(this.HospitalName);
            this.Name = "WelcomePage";
            this.Text = "WelcomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HospitalName;
        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.ComboBox WardSelectorBox;
    }
}