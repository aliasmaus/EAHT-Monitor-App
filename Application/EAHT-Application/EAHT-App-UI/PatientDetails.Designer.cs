namespace EAHT_App_UI
{
    partial class PatientDetails
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
            this.patientNameList = new System.Windows.Forms.TextBox();
            this.patientDetailList = new System.Windows.Forms.TextBox();
            this.deleteActivityButton = new System.Windows.Forms.Button();
            this.previousPageButton = new System.Windows.Forms.Button();
            this.mainPageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patientNameList
            // 
            this.patientNameList.Location = new System.Drawing.Point(12, 118);
            this.patientNameList.Multiline = true;
            this.patientNameList.Name = "patientNameList";
            this.patientNameList.Size = new System.Drawing.Size(343, 352);
            this.patientNameList.TabIndex = 0;
            this.patientNameList.TextChanged += new System.EventHandler(this.patientNameList_TextChanged);
            // 
            // patientDetailList
            // 
            this.patientDetailList.Location = new System.Drawing.Point(365, 12);
            this.patientDetailList.Multiline = true;
            this.patientDetailList.Name = "patientDetailList";
            this.patientDetailList.Size = new System.Drawing.Size(645, 458);
            this.patientDetailList.TabIndex = 1;
            // 
            // deleteActivityButton
            // 
            this.deleteActivityButton.Location = new System.Drawing.Point(214, 511);
            this.deleteActivityButton.Name = "deleteActivityButton";
            this.deleteActivityButton.Size = new System.Drawing.Size(141, 30);
            this.deleteActivityButton.TabIndex = 2;
            this.deleteActivityButton.Text = "Delete Activity";
            this.deleteActivityButton.UseVisualStyleBackColor = true;
            this.deleteActivityButton.Click += new System.EventHandler(this.deleteActivityButton_Click);
            // 
            // previousPageButton
            // 
            this.previousPageButton.Location = new System.Drawing.Point(432, 511);
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.Size = new System.Drawing.Size(141, 30);
            this.previousPageButton.TabIndex = 3;
            this.previousPageButton.Text = "Previous Page";
            this.previousPageButton.UseVisualStyleBackColor = true;
            this.previousPageButton.Click += new System.EventHandler(this.previousPageButton_Click);
            // 
            // mainPageButton
            // 
            this.mainPageButton.Location = new System.Drawing.Point(653, 511);
            this.mainPageButton.Name = "mainPageButton";
            this.mainPageButton.Size = new System.Drawing.Size(141, 30);
            this.mainPageButton.TabIndex = 4;
            this.mainPageButton.Text = "Back To Main";
            this.mainPageButton.UseVisualStyleBackColor = true;
            this.mainPageButton.Click += new System.EventHandler(this.mainPageButton_Click);
            // 
            // PatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1022, 578);
            this.Controls.Add(this.mainPageButton);
            this.Controls.Add(this.previousPageButton);
            this.Controls.Add(this.deleteActivityButton);
            this.Controls.Add(this.patientDetailList);
            this.Controls.Add(this.patientNameList);
            this.Name = "PatientDetails";
            this.Text = "PatientDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox patientNameList;
        private System.Windows.Forms.TextBox patientDetailList;
        private System.Windows.Forms.Button deleteActivityButton;
        private System.Windows.Forms.Button previousPageButton;
        private System.Windows.Forms.Button mainPageButton;
    }
}