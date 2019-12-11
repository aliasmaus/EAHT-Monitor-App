namespace EAHT_App_UI
{
    partial class WardConfigPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WardConfigPage));
            this.BackButton = new System.Windows.Forms.Button();
            this.WardConfigTabs = new System.Windows.Forms.TabControl();
            this.EditTab = new System.Windows.Forms.TabPage();
            this.EditWardFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SelectWardBox = new System.Windows.Forms.GroupBox();
            this.EditSelectWardDropdown = new System.Windows.Forms.ComboBox();
            this.SelectBayBox = new System.Windows.Forms.GroupBox();
            this.SelectBayBackButton = new System.Windows.Forms.Button();
            this.SelectBayDropdown = new System.Windows.Forms.ComboBox();
            this.ConfigureDefaultsBox = new System.Windows.Forms.GroupBox();
            this.EditDefaultsUpdateButton = new System.Windows.Forms.Button();
            this.MonitorsPerBedLabel = new System.Windows.Forms.Label();
            this.EditDefaultMonitorsPerBedSelect = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.EditDefaultBedsPerBaySelect = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.EditDefaultNumberOfBaysSelect = new System.Windows.Forms.NumericUpDown();
            this.ConfigureBedsInBaysBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddTab = new System.Windows.Forms.TabPage();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeleteWardSelectLabel = new System.Windows.Forms.Label();
            this.DeleteWardSelectBox = new System.Windows.Forms.ComboBox();
            this.DeleteWardLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddWardButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddDefaultBaysLabel = new System.Windows.Forms.Label();
            this.AddWardDefaultBedsNumber = new System.Windows.Forms.NumericUpDown();
            this.AddWardDefaultMonitorsNumber = new System.Windows.Forms.NumericUpDown();
            this.AddWardDefaultBayNumber = new System.Windows.Forms.NumericUpDown();
            this.AddWardNameText = new System.Windows.Forms.TextBox();
            this.AddWardNameLabel = new System.Windows.Forms.Label();
            this.viewTab = new System.Windows.Forms.TabPage();
            this.WardDataGridView = new System.Windows.Forms.DataGridView();
            this.WardConfigTabs.SuspendLayout();
            this.EditTab.SuspendLayout();
            this.EditWardFlowPanel.SuspendLayout();
            this.SelectWardBox.SuspendLayout();
            this.SelectBayBox.SuspendLayout();
            this.ConfigureDefaultsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditDefaultMonitorsPerBedSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditDefaultBedsPerBaySelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditDefaultNumberOfBaysSelect)).BeginInit();
            this.ConfigureBedsInBaysBox.SuspendLayout();
            this.AddTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddWardDefaultBedsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddWardDefaultMonitorsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddWardDefaultBayNumber)).BeginInit();
            this.viewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WardDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackButton.Location = new System.Drawing.Point(699, 25);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 35);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.OpenWelcomePage);
            // 
            // WardConfigTabs
            // 
            this.WardConfigTabs.Controls.Add(this.EditTab);
            this.WardConfigTabs.Controls.Add(this.AddTab);
            this.WardConfigTabs.Controls.Add(this.viewTab);
            this.WardConfigTabs.Location = new System.Drawing.Point(31, 66);
            this.WardConfigTabs.Name = "WardConfigTabs";
            this.WardConfigTabs.SelectedIndex = 0;
            this.WardConfigTabs.Size = new System.Drawing.Size(747, 356);
            this.WardConfigTabs.TabIndex = 1;
            // 
            // EditTab
            // 
            this.EditTab.BackColor = System.Drawing.Color.Wheat;
            this.EditTab.Controls.Add(this.EditWardFlowPanel);
            this.EditTab.Location = new System.Drawing.Point(4, 22);
            this.EditTab.Name = "EditTab";
            this.EditTab.Padding = new System.Windows.Forms.Padding(3);
            this.EditTab.Size = new System.Drawing.Size(739, 330);
            this.EditTab.TabIndex = 0;
            this.EditTab.Text = "Edit ward";
            // 
            // EditWardFlowPanel
            // 
            this.EditWardFlowPanel.AutoScroll = true;
            this.EditWardFlowPanel.Controls.Add(this.SelectWardBox);
            this.EditWardFlowPanel.Controls.Add(this.SelectBayBox);
            this.EditWardFlowPanel.Controls.Add(this.ConfigureDefaultsBox);
            this.EditWardFlowPanel.Controls.Add(this.ConfigureBedsInBaysBox);
            this.EditWardFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.EditWardFlowPanel.Location = new System.Drawing.Point(7, 7);
            this.EditWardFlowPanel.Name = "EditWardFlowPanel";
            this.EditWardFlowPanel.Size = new System.Drawing.Size(726, 320);
            this.EditWardFlowPanel.TabIndex = 0;
            // 
            // SelectWardBox
            // 
            this.SelectWardBox.Controls.Add(this.EditSelectWardDropdown);
            this.SelectWardBox.Location = new System.Drawing.Point(3, 3);
            this.SelectWardBox.Name = "SelectWardBox";
            this.SelectWardBox.Size = new System.Drawing.Size(355, 70);
            this.SelectWardBox.TabIndex = 0;
            this.SelectWardBox.TabStop = false;
            this.SelectWardBox.Text = "Select ward";
            // 
            // EditSelectWardDropdown
            // 
            this.EditSelectWardDropdown.FormattingEnabled = true;
            this.EditSelectWardDropdown.Location = new System.Drawing.Point(16, 29);
            this.EditSelectWardDropdown.Name = "EditSelectWardDropdown";
            this.EditSelectWardDropdown.Size = new System.Drawing.Size(143, 21);
            this.EditSelectWardDropdown.TabIndex = 0;
            this.EditSelectWardDropdown.SelectionChangeCommitted += new System.EventHandler(this.EditWardSelected);
            // 
            // SelectBayBox
            // 
            this.SelectBayBox.Controls.Add(this.SelectBayBackButton);
            this.SelectBayBox.Controls.Add(this.SelectBayDropdown);
            this.SelectBayBox.Enabled = false;
            this.SelectBayBox.Location = new System.Drawing.Point(3, 79);
            this.SelectBayBox.Name = "SelectBayBox";
            this.SelectBayBox.Size = new System.Drawing.Size(355, 70);
            this.SelectBayBox.TabIndex = 1;
            this.SelectBayBox.TabStop = false;
            this.SelectBayBox.Text = "Select bay";
            this.SelectBayBox.Visible = false;
            // 
            // SelectBayBackButton
            // 
            this.SelectBayBackButton.Enabled = false;
            this.SelectBayBackButton.Location = new System.Drawing.Point(205, 29);
            this.SelectBayBackButton.Name = "SelectBayBackButton";
            this.SelectBayBackButton.Size = new System.Drawing.Size(75, 23);
            this.SelectBayBackButton.TabIndex = 1;
            this.SelectBayBackButton.Text = "Back";
            this.SelectBayBackButton.UseVisualStyleBackColor = true;
            this.SelectBayBackButton.Visible = false;
            this.SelectBayBackButton.Click += new System.EventHandler(this.BackToConfigureWard);
            // 
            // SelectBayDropdown
            // 
            this.SelectBayDropdown.FormattingEnabled = true;
            this.SelectBayDropdown.Location = new System.Drawing.Point(16, 29);
            this.SelectBayDropdown.Name = "SelectBayDropdown";
            this.SelectBayDropdown.Size = new System.Drawing.Size(143, 21);
            this.SelectBayDropdown.TabIndex = 0;
            this.SelectBayDropdown.SelectionChangeCommitted += new System.EventHandler(this.ShowBedsInBaysConfig);
            // 
            // ConfigureDefaultsBox
            // 
            this.ConfigureDefaultsBox.Controls.Add(this.EditDefaultsUpdateButton);
            this.ConfigureDefaultsBox.Controls.Add(this.MonitorsPerBedLabel);
            this.ConfigureDefaultsBox.Controls.Add(this.EditDefaultMonitorsPerBedSelect);
            this.ConfigureDefaultsBox.Controls.Add(this.label2);
            this.ConfigureDefaultsBox.Controls.Add(this.EditDefaultBedsPerBaySelect);
            this.ConfigureDefaultsBox.Controls.Add(this.label1);
            this.ConfigureDefaultsBox.Controls.Add(this.EditDefaultNumberOfBaysSelect);
            this.ConfigureDefaultsBox.Enabled = false;
            this.ConfigureDefaultsBox.Location = new System.Drawing.Point(364, 3);
            this.ConfigureDefaultsBox.Name = "ConfigureDefaultsBox";
            this.ConfigureDefaultsBox.Size = new System.Drawing.Size(355, 238);
            this.ConfigureDefaultsBox.TabIndex = 1;
            this.ConfigureDefaultsBox.TabStop = false;
            this.ConfigureDefaultsBox.Text = "Configure defaults";
            this.ConfigureDefaultsBox.Visible = false;
            // 
            // EditDefaultsUpdateButton
            // 
            this.EditDefaultsUpdateButton.Location = new System.Drawing.Point(138, 175);
            this.EditDefaultsUpdateButton.Name = "EditDefaultsUpdateButton";
            this.EditDefaultsUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.EditDefaultsUpdateButton.TabIndex = 6;
            this.EditDefaultsUpdateButton.Text = "Update";
            this.EditDefaultsUpdateButton.UseVisualStyleBackColor = true;
            this.EditDefaultsUpdateButton.Click += new System.EventHandler(this.EditDefaultsUpdateButton_Click);
            // 
            // MonitorsPerBedLabel
            // 
            this.MonitorsPerBedLabel.AutoSize = true;
            this.MonitorsPerBedLabel.Location = new System.Drawing.Point(32, 125);
            this.MonitorsPerBedLabel.Name = "MonitorsPerBedLabel";
            this.MonitorsPerBedLabel.Size = new System.Drawing.Size(172, 13);
            this.MonitorsPerBedLabel.TabIndex = 5;
            this.MonitorsPerBedLabel.Text = "Default number of monitors per bed";
            // 
            // EditDefaultMonitorsPerBedSelect
            // 
            this.EditDefaultMonitorsPerBedSelect.Location = new System.Drawing.Point(206, 123);
            this.EditDefaultMonitorsPerBedSelect.Name = "EditDefaultMonitorsPerBedSelect";
            this.EditDefaultMonitorsPerBedSelect.Size = new System.Drawing.Size(120, 20);
            this.EditDefaultMonitorsPerBedSelect.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Default number of beds per bay";
            // 
            // EditDefaultBedsPerBaySelect
            // 
            this.EditDefaultBedsPerBaySelect.Location = new System.Drawing.Point(206, 75);
            this.EditDefaultBedsPerBaySelect.Name = "EditDefaultBedsPerBaySelect";
            this.EditDefaultBedsPerBaySelect.Size = new System.Drawing.Size(120, 20);
            this.EditDefaultBedsPerBaySelect.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of bays";
            // 
            // EditDefaultNumberOfBaysSelect
            // 
            this.EditDefaultNumberOfBaysSelect.Location = new System.Drawing.Point(206, 30);
            this.EditDefaultNumberOfBaysSelect.Name = "EditDefaultNumberOfBaysSelect";
            this.EditDefaultNumberOfBaysSelect.Size = new System.Drawing.Size(120, 20);
            this.EditDefaultNumberOfBaysSelect.TabIndex = 0;
            // 
            // ConfigureBedsInBaysBox
            // 
            this.ConfigureBedsInBaysBox.Controls.Add(this.flowLayoutPanel1);
            this.ConfigureBedsInBaysBox.Enabled = false;
            this.ConfigureBedsInBaysBox.Location = new System.Drawing.Point(725, 3);
            this.ConfigureBedsInBaysBox.Name = "ConfigureBedsInBaysBox";
            this.ConfigureBedsInBaysBox.Size = new System.Drawing.Size(355, 295);
            this.ConfigureBedsInBaysBox.TabIndex = 6;
            this.ConfigureBedsInBaysBox.TabStop = false;
            this.ConfigureBedsInBaysBox.Text = "Configure custom number of beds in bay";
            this.ConfigureBedsInBaysBox.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(342, 269);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // AddTab
            // 
            this.AddTab.BackColor = System.Drawing.Color.Wheat;
            this.AddTab.Controls.Add(this.DeleteButton);
            this.AddTab.Controls.Add(this.DeleteWardSelectLabel);
            this.AddTab.Controls.Add(this.DeleteWardSelectBox);
            this.AddTab.Controls.Add(this.DeleteWardLabel);
            this.AddTab.Controls.Add(this.label5);
            this.AddTab.Controls.Add(this.AddWardButton);
            this.AddTab.Controls.Add(this.label3);
            this.AddTab.Controls.Add(this.label4);
            this.AddTab.Controls.Add(this.AddDefaultBaysLabel);
            this.AddTab.Controls.Add(this.AddWardDefaultBedsNumber);
            this.AddTab.Controls.Add(this.AddWardDefaultMonitorsNumber);
            this.AddTab.Controls.Add(this.AddWardDefaultBayNumber);
            this.AddTab.Controls.Add(this.AddWardNameText);
            this.AddTab.Controls.Add(this.AddWardNameLabel);
            this.AddTab.Location = new System.Drawing.Point(4, 22);
            this.AddTab.Name = "AddTab";
            this.AddTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddTab.Size = new System.Drawing.Size(739, 330);
            this.AddTab.TabIndex = 1;
            this.AddTab.Text = "Add/delete ward";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.DeleteButton.Location = new System.Drawing.Point(530, 108);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 35);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteWardSelectLabel
            // 
            this.DeleteWardSelectLabel.AutoSize = true;
            this.DeleteWardSelectLabel.Location = new System.Drawing.Point(453, 64);
            this.DeleteWardSelectLabel.Name = "DeleteWardSelectLabel";
            this.DeleteWardSelectLabel.Size = new System.Drawing.Size(62, 13);
            this.DeleteWardSelectLabel.TabIndex = 12;
            this.DeleteWardSelectLabel.Text = "Ward name";
            // 
            // DeleteWardSelectBox
            // 
            this.DeleteWardSelectBox.FormattingEnabled = true;
            this.DeleteWardSelectBox.Location = new System.Drawing.Point(555, 61);
            this.DeleteWardSelectBox.Name = "DeleteWardSelectBox";
            this.DeleteWardSelectBox.Size = new System.Drawing.Size(121, 21);
            this.DeleteWardSelectBox.TabIndex = 11;
            // 
            // DeleteWardLabel
            // 
            this.DeleteWardLabel.AutoSize = true;
            this.DeleteWardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteWardLabel.Location = new System.Drawing.Point(514, 23);
            this.DeleteWardLabel.Name = "DeleteWardLabel";
            this.DeleteWardLabel.Size = new System.Drawing.Size(91, 16);
            this.DeleteWardLabel.TabIndex = 10;
            this.DeleteWardLabel.Text = "Delete ward";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Add ward";
            // 
            // AddWardButton
            // 
            this.AddWardButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.AddWardButton.Location = new System.Drawing.Point(141, 250);
            this.AddWardButton.Name = "AddWardButton";
            this.AddWardButton.Size = new System.Drawing.Size(75, 35);
            this.AddWardButton.TabIndex = 8;
            this.AddWardButton.Text = "Add";
            this.AddWardButton.UseVisualStyleBackColor = false;
            this.AddWardButton.Click += new System.EventHandler(this.AddWardButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Default number of monitors per bed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Default number of beds per bay";
            // 
            // AddDefaultBaysLabel
            // 
            this.AddDefaultBaysLabel.AutoSize = true;
            this.AddDefaultBaysLabel.Location = new System.Drawing.Point(44, 108);
            this.AddDefaultBaysLabel.Name = "AddDefaultBaysLabel";
            this.AddDefaultBaysLabel.Size = new System.Drawing.Size(116, 13);
            this.AddDefaultBaysLabel.TabIndex = 5;
            this.AddDefaultBaysLabel.Text = "Default number of bays";
            // 
            // AddWardDefaultBedsNumber
            // 
            this.AddWardDefaultBedsNumber.Location = new System.Drawing.Point(245, 151);
            this.AddWardDefaultBedsNumber.Name = "AddWardDefaultBedsNumber";
            this.AddWardDefaultBedsNumber.Size = new System.Drawing.Size(73, 20);
            this.AddWardDefaultBedsNumber.TabIndex = 4;
            // 
            // AddWardDefaultMonitorsNumber
            // 
            this.AddWardDefaultMonitorsNumber.Location = new System.Drawing.Point(245, 195);
            this.AddWardDefaultMonitorsNumber.Name = "AddWardDefaultMonitorsNumber";
            this.AddWardDefaultMonitorsNumber.Size = new System.Drawing.Size(73, 20);
            this.AddWardDefaultMonitorsNumber.TabIndex = 3;
            // 
            // AddWardDefaultBayNumber
            // 
            this.AddWardDefaultBayNumber.Location = new System.Drawing.Point(245, 106);
            this.AddWardDefaultBayNumber.Name = "AddWardDefaultBayNumber";
            this.AddWardDefaultBayNumber.Size = new System.Drawing.Size(73, 20);
            this.AddWardDefaultBayNumber.TabIndex = 2;
            // 
            // AddWardNameText
            // 
            this.AddWardNameText.Location = new System.Drawing.Point(188, 64);
            this.AddWardNameText.Name = "AddWardNameText";
            this.AddWardNameText.Size = new System.Drawing.Size(130, 20);
            this.AddWardNameText.TabIndex = 1;
            // 
            // AddWardNameLabel
            // 
            this.AddWardNameLabel.AutoSize = true;
            this.AddWardNameLabel.Location = new System.Drawing.Point(44, 64);
            this.AddWardNameLabel.Name = "AddWardNameLabel";
            this.AddWardNameLabel.Size = new System.Drawing.Size(62, 13);
            this.AddWardNameLabel.TabIndex = 0;
            this.AddWardNameLabel.Text = "Ward name";
            // 
            // viewTab
            // 
            this.viewTab.BackColor = System.Drawing.Color.Wheat;
            this.viewTab.Controls.Add(this.WardDataGridView);
            this.viewTab.Location = new System.Drawing.Point(4, 22);
            this.viewTab.Name = "viewTab";
            this.viewTab.Size = new System.Drawing.Size(739, 330);
            this.viewTab.TabIndex = 2;
            this.viewTab.Text = "View wards";
            // 
            // WardDataGridView
            // 
            this.WardDataGridView.AllowUserToAddRows = false;
            this.WardDataGridView.AllowUserToDeleteRows = false;
            this.WardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WardDataGridView.Location = new System.Drawing.Point(26, 26);
            this.WardDataGridView.Name = "WardDataGridView";
            this.WardDataGridView.ReadOnly = true;
            this.WardDataGridView.Size = new System.Drawing.Size(684, 278);
            this.WardDataGridView.TabIndex = 0;
            // 
            // WardConfigPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WardConfigTabs);
            this.Controls.Add(this.BackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WardConfigPage";
            this.Text = "Configure wards";
            this.WardConfigTabs.ResumeLayout(false);
            this.EditTab.ResumeLayout(false);
            this.EditWardFlowPanel.ResumeLayout(false);
            this.SelectWardBox.ResumeLayout(false);
            this.SelectBayBox.ResumeLayout(false);
            this.ConfigureDefaultsBox.ResumeLayout(false);
            this.ConfigureDefaultsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditDefaultMonitorsPerBedSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditDefaultBedsPerBaySelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditDefaultNumberOfBaysSelect)).EndInit();
            this.ConfigureBedsInBaysBox.ResumeLayout(false);
            this.AddTab.ResumeLayout(false);
            this.AddTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddWardDefaultBedsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddWardDefaultMonitorsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddWardDefaultBayNumber)).EndInit();
            this.viewTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WardDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TabControl WardConfigTabs;
        private System.Windows.Forms.TabPage EditTab;
        private System.Windows.Forms.FlowLayoutPanel EditWardFlowPanel;
        private System.Windows.Forms.GroupBox SelectWardBox;
        private System.Windows.Forms.ComboBox EditSelectWardDropdown;
        private System.Windows.Forms.GroupBox SelectBayBox;
        private System.Windows.Forms.ComboBox SelectBayDropdown;
        private System.Windows.Forms.GroupBox ConfigureDefaultsBox;
        private System.Windows.Forms.Label MonitorsPerBedLabel;
        private System.Windows.Forms.NumericUpDown EditDefaultMonitorsPerBedSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown EditDefaultBedsPerBaySelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown EditDefaultNumberOfBaysSelect;
        private System.Windows.Forms.GroupBox ConfigureBedsInBaysBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage AddTab;
        private System.Windows.Forms.Button EditDefaultsUpdateButton;
        private System.Windows.Forms.Button SelectBayBackButton;
        private System.Windows.Forms.Button AddWardButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AddDefaultBaysLabel;
        private System.Windows.Forms.NumericUpDown AddWardDefaultBedsNumber;
        private System.Windows.Forms.NumericUpDown AddWardDefaultMonitorsNumber;
        private System.Windows.Forms.NumericUpDown AddWardDefaultBayNumber;
        private System.Windows.Forms.TextBox AddWardNameText;
        private System.Windows.Forms.Label AddWardNameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label DeleteWardSelectLabel;
        private System.Windows.Forms.ComboBox DeleteWardSelectBox;
        private System.Windows.Forms.Label DeleteWardLabel;
        private System.Windows.Forms.TabPage viewTab;
        private System.Windows.Forms.DataGridView WardDataGridView;
    }
}