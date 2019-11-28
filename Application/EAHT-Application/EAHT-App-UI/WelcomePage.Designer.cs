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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.HospitalName = new System.Windows.Forms.Label();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.WardSelectorBox = new System.Windows.Forms.ComboBox();
            this.HospitalLogo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // HospitalName
            // 
            this.HospitalName.AutoSize = true;
            this.HospitalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HospitalName.Location = new System.Drawing.Point(302, 231);
            this.HospitalName.Name = "HospitalName";
            this.HospitalName.Size = new System.Drawing.Size(197, 62);
            this.HospitalName.TabIndex = 0;
            this.HospitalName.Text = "East Anglia\r\nHospital Trust";
            this.HospitalName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.Location = new System.Drawing.Point(305, 328);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(190, 13);
            this.WelcomeMessage.TabIndex = 1;
            this.WelcomeMessage.Text = "Welcome, please select a ward to load";
            // 
            // WardSelectorBox
            // 
            this.WardSelectorBox.FormattingEnabled = true;
            this.WardSelectorBox.Location = new System.Drawing.Point(340, 359);
            this.WardSelectorBox.Name = "WardSelectorBox";
            this.WardSelectorBox.Size = new System.Drawing.Size(121, 21);
            this.WardSelectorBox.TabIndex = 2;
            this.WardSelectorBox.SelectionChangeCommitted += new System.EventHandler(this.LoadWardMainPage);
            // 
            // HospitalLogo
            // 
            this.HospitalLogo.Enabled = false;
            this.HospitalLogo.Image = ((System.Drawing.Image)(resources.GetObject("HospitalLogo.Image")));
            this.HospitalLogo.Location = new System.Drawing.Point(325, 69);
            this.HospitalLogo.Name = "HospitalLogo";
            this.HospitalLogo.Size = new System.Drawing.Size(151, 144);
            this.HospitalLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HospitalLogo.TabIndex = 3;
            this.HospitalLogo.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(699, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "New Ward";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HospitalLogo);
            this.Controls.Add(this.WardSelectorBox);
            this.Controls.Add(this.WelcomeMessage);
            this.Controls.Add(this.HospitalName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomePage";
            this.Text = "WelcomePage";
            ((System.ComponentModel.ISupportInitialize)(this.HospitalLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HospitalName;
        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.ComboBox WardSelectorBox;
        private System.Windows.Forms.PictureBox HospitalLogo;
        private System.Windows.Forms.Button button1;
    }
}