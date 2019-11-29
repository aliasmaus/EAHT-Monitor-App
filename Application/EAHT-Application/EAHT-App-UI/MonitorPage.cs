using EAHT_Engine;
using System;
using System.Windows.Forms;

namespace EAHT_App_UI
{
    public partial class MonitorPage : Form
    {
        private readonly Bed bed;
        private System.Windows.Forms.GroupBox[] frames;
        private System.Windows.Forms.ComboBox[] dropdowns;
        private System.Windows.Forms.Label[] values;
        private System.Windows.Forms.Label[] minLabels;
        private System.Windows.Forms.Label[] maxLabels;
        private System.Windows.Forms.NumericUpDown[] minSelectors;
        private System.Windows.Forms.NumericUpDown[] maxSelectors;
        private System.Windows.Forms.Button[] silenceButtons;

        /// <summary>
        /// Creates the monitor display panels and configures them depending on the 
        /// bed chosen.
        /// </summary>
        /// <param name="bed">The bed to display/configure</param>
        public MonitorPage(Bed bed)
        {
            { 
            InitializeComponent();
                this.bed = bed;   
            }
        }
        // TODO: if active monitor, put the values in dropdown, min, max
        private void MonitorPage_Load(object sender, EventArgs e)
        {
            this.BedValue.Text = "BED " + (bed.BedNumber+1).ToString();
            this.Text = bed.WardRef.Name + "- " + this.Text;
            //initialize arrays
            int nMonitors = bed.Monitors.Length;
            frames = new GroupBox[nMonitors];
            dropdowns = new ComboBox[nMonitors];
            values = new Label[nMonitors];
            minLabels = new Label[nMonitors];
            maxLabels = new Label[nMonitors];
            minSelectors = new NumericUpDown[nMonitors];
            maxSelectors = new NumericUpDown[nMonitors];
            silenceButtons = new Button[nMonitors];
            // for each monitor
            for (int monitor = 0; monitor < nMonitors; monitor++)
            {
                // create design elements
                frames[monitor] = new GroupBox();
                dropdowns[monitor] = new ComboBox();
                values[monitor] = new Label();
                minLabels[monitor] = new Label();
                maxLabels[monitor] = new Label();
                minSelectors[monitor] = new NumericUpDown();
                maxSelectors[monitor] = new NumericUpDown();
                silenceButtons[monitor] = new Button();
                // hide and disable silence buttons
                silenceButtons[monitor].Enabled = false;
                silenceButtons[monitor].Visible = false;
                // add controls to their containers
                MonitorPageFlowPanel.Controls.Add(frames[monitor]);
                frames[monitor].Controls.Add(dropdowns[monitor]);
                frames[monitor].Controls.Add(values[monitor]);
                frames[monitor].Controls.Add(minLabels[monitor]);
                frames[monitor].Controls.Add(maxLabels[monitor]);
                frames[monitor].Controls.Add(minSelectors[monitor]);
                frames[monitor].Controls.Add(maxSelectors[monitor]);
                frames[monitor].Controls.Add(silenceButtons[monitor]);
                // set names
                dropdowns[monitor].Name = "Dropdown_" + monitor.ToString();
                minSelectors[monitor].Name = "MinSel_" + monitor.ToString();
                maxSelectors[monitor].Name = "MaxSel_" + monitor.ToString();
                silenceButtons[monitor].Name = "SilBut_" + monitor.ToString();
                // set static text
                values[monitor].Text = "###";
                minLabels[monitor].Text = "Alarms: Min";
                maxLabels[monitor].Text = "Max";
                silenceButtons[monitor].Text = "Silence Alarm";
                // add options to dropdowns
                dropdowns[monitor].Items.AddRange(bed.GetPossibleMonitors());
                // set positions
                dropdowns[monitor].Location = new System.Drawing.Point(70, 11);
                values[monitor].Location = new System.Drawing.Point(5, 35);
                minLabels[monitor].Location = new System.Drawing.Point(10, 100);
                maxLabels[monitor].Location = new System.Drawing.Point(128, 100);
                minSelectors[monitor].Location = new System.Drawing.Point(80, 98);
                maxSelectors[monitor].Location = new System.Drawing.Point(156, 98);
                silenceButtons[monitor].Location = new System.Drawing.Point(170,50);
                // set sizes
                frames[monitor].Size = new System.Drawing.Size(250, 130);
                minLabels[monitor].Size = new System.Drawing.Size(50, 13);
                maxLabels[monitor].Size = new System.Drawing.Size(30, 13);
                values[monitor].Size = new System.Drawing.Size(150, 55);
                values[monitor].AutoSize = false;
                minSelectors[monitor].Size = new System.Drawing.Size(50, 20);
                maxSelectors[monitor].Size = new System.Drawing.Size(50, 20);
                // set fonts
                values[monitor].Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                // set colours
                frames[monitor].BackColor = System.Drawing.Color.PowderBlue;
                // add events
                dropdowns[monitor].SelectedIndexChanged += new EventHandler(ChangeMonitor);
                minSelectors[monitor].ValueChanged += new EventHandler(MonitorMinChanged);
                maxSelectors[monitor].ValueChanged += new EventHandler(MonitorMaxChanged);
                silenceButtons[monitor].Click += new EventHandler(SilenceAlarm);

                // set initial values
                if(!(bed.Monitors[monitor] is null))
                {
                    dropdowns[monitor].Text = bed.Monitors[monitor].Name;
                    SetValuesForMonitors(monitor);
                }
                
            }
        }

        private void SilenceAlarm(object sender, EventArgs e)
        {
            bed.Monitors[Convert.ToInt32((sender as Button).Name.Substring(7))].Alarm.SilenceAlarm();
            (sender as Control).Enabled = false;
            (sender as Control).Visible = false;
        }

        private void PageUpdate(object sender, EventArgs e)
        {
            string message = "";
            for (int monitor =0; monitor < bed.Monitors.Length; monitor ++)
            {
                if (!(bed.Monitors[monitor] is null))
                {
                    values[monitor].Text = bed.Monitors[monitor].Read();
                    // If there is an alarm
                    if(bed.Monitors[monitor].CheckForAlarm())
                    {
                        // Generate the alarm message text
                        message += bed.Monitors[monitor].Name;
                        if(bed.Monitors[monitor].Sensor.CurrentValue <= bed.Monitors[monitor].Sensor.CurrentLower)
                        {
                            message += " below acceptable value" + Environment.NewLine;
                        }
                        else
                        {
                            message += " above acceptable value" + Environment.NewLine;
                        }

                        // If the alarm isn't silenced, make the background red, show the silence button, 
                        if (!(bed.Monitors[monitor].Alarm.IsSilenced))
                        {
                            frames[monitor].BackColor = System.Drawing.Color.Red;
                            silenceButtons[monitor].Visible = true;
                            silenceButtons[monitor].Enabled = true;
                            
                        }
                        // If it is silenced, hide the silence button and make the background normal
                        // indicate the alarm is silenced in the message box
                        else
                        {
                            frames[monitor].BackColor = System.Drawing.Color.PowderBlue;
                            silenceButtons[monitor].Visible = false;
                            silenceButtons[monitor].Enabled = false;
                            message += bed.Monitors[monitor].Name + " alarm has been silenced (monitor " + (monitor + 1).ToString() + ")"  + Environment.NewLine;
                        }
                    }
                    // If there's no alarm make the display normal
                    else
                    {
                        frames[monitor].BackColor = System.Drawing.Color.PowderBlue;
                        silenceButtons[monitor].Visible = false;
                        silenceButtons[monitor].Enabled = false;
                    }
                }
            }
            // Update the alarm message if it has changed
            if(message != AlarmMessage.Text)
            {
                AlarmMessage.Text = message;
            }

        }

        private void ChangeMonitor(object sender, EventArgs e)
        {
            int monitor = Convert.ToInt32((sender as Control).Name.Substring(9));
            int monitorType = (sender as ComboBox).SelectedIndex;
            bed.InsertMonitor(monitorType, monitor);
            SetValuesForMonitors(monitor);
        }

        private void SetValuesForMonitors(int monitor)
        {
            double low = bed.Monitors[monitor].Sensor.CurrentLower;
            double high = bed.Monitors[monitor].Sensor.CurrentUpper;
            double range = low / 2;
            minSelectors[monitor].Minimum = (decimal)(low - range);
            minSelectors[monitor].Maximum = (decimal)(low + range);
            maxSelectors[monitor].Minimum = (decimal)(high - range);
            maxSelectors[monitor].Maximum = (decimal)(high + range);
            minSelectors[monitor].Value = (decimal)low;
            maxSelectors[monitor].Value = (decimal)high;
        }

        private void MonitorMinChanged(object sender, EventArgs e)
        {
            //if monitor exists update its min value
            int monitor = Convert.ToInt32((sender as Control).Name.Substring(7));
            if (!(bed.Monitors[monitor] is null))
            {
                double value = (double)minSelectors[monitor].Value;
                bed.Monitors[monitor].SetMin(value);
            }
        }
        private void MonitorMaxChanged(object sender, EventArgs e)
        {
            // If monitor exists, update its max value
            int monitor = Convert.ToInt32((sender as Control).Name.Substring(7));
            if (!(bed.Monitors[monitor] is null))
            {
                double value = (double)maxSelectors[monitor].Value;
                bed.Monitors[monitor].SetMax(value);
            }
        }

        private void RegisterStaffForNotifications(object sender, EventArgs e)
        {
            bed.RegisterStaffForNotifications();
        }

        private void DeregisterStaffForNotifications(object sender, EventArgs e)
        {
            bed.DeregisterStaffForNotifications();
        }

        private void AlarmMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
