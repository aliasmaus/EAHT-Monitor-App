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
        private void MonitorPage_Load(object sender, EventArgs e)
        {
            this.BedValue.Text = "BED " + (bed.BedNumber+1).ToString();
            //initialize arrays
            int nMonitors = bed.Monitors.Length;
            frames = new GroupBox[nMonitors];
            dropdowns = new ComboBox[nMonitors];
            values = new Label[nMonitors];
            minLabels = new Label[nMonitors];
            maxLabels = new Label[nMonitors];
            minSelectors = new NumericUpDown[nMonitors];
            maxSelectors = new NumericUpDown[nMonitors];
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
                // add controls to their containers
                MonitorPageFlowPanel.Controls.Add(frames[monitor]);
                frames[monitor].Controls.Add(dropdowns[monitor]);
                frames[monitor].Controls.Add(values[monitor]);
                frames[monitor].Controls.Add(minLabels[monitor]);
                frames[monitor].Controls.Add(maxLabels[monitor]);
                frames[monitor].Controls.Add(minSelectors[monitor]);
                frames[monitor].Controls.Add(maxSelectors[monitor]);
                // set names
                dropdowns[monitor].Name = "Dropdown_" + monitor.ToString();
                minSelectors[monitor].Name = "MinSel_" + monitor.ToString();
                maxSelectors[monitor].Name = "MaxSel_" + monitor.ToString();
                // set static text
                values[monitor].Text = "loading";
                minLabels[monitor].Text = "Alarms: Min";
                maxLabels[monitor].Text = "Max";
                // add options to dropdowns
                dropdowns[monitor].Items.AddRange(bed.GetPossibleMonitors());
                // set positions
                dropdowns[monitor].Location = new System.Drawing.Point(70, 11);
                values[monitor].Location = new System.Drawing.Point(10, 35);
                minLabels[monitor].Location = new System.Drawing.Point(10, 100);
                maxLabels[monitor].Location = new System.Drawing.Point(128, 100);
                minSelectors[monitor].Location = new System.Drawing.Point(69, 98);
                maxSelectors[monitor].Location = new System.Drawing.Point(156, 98);
                // set sizes
                frames[monitor].Size = new System.Drawing.Size(250, 130);
                minLabels[monitor].Size = new System.Drawing.Size(50, 13);
                maxLabels[monitor].Size = new System.Drawing.Size(30, 13);
                values[monitor].Size = new System.Drawing.Size(200, 55);
                minSelectors[monitor].Size = new System.Drawing.Size(50, 20);
                maxSelectors[monitor].Size = new System.Drawing.Size(50, 20);
                // set fonts
                values[monitor].Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                // set colours
                frames[monitor].BackColor = System.Drawing.Color.CadetBlue;
                // add events
                dropdowns[monitor].SelectedIndexChanged += new EventHandler(ChangeMonitor);
                minSelectors[monitor].ValueChanged += new EventHandler(MonitorMinChanged);
                maxSelectors[monitor].ValueChanged += new EventHandler(MonitorMaxChanged);
            }
        }


        private void PageUpdate(object sender, EventArgs e)
        {
            bool[] alarmStatuses = bed.GetMonitorAlarmStatuses();
            for (int monitor =0; monitor < bed.Monitors.Length; monitor ++)
            {
                if (!(bed.Monitors[monitor] is null))
                {
                    values[monitor].Text = bed.Monitors[monitor].Read();
                    if(alarmStatuses[monitor])
                    {
                        frames[monitor].BackColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        frames[monitor].BackColor = System.Drawing.Color.CadetBlue;
                    }
                }
            }

        }

        private void ChangeMonitor(object sender, EventArgs e)
        {
            int monitor = Convert.ToInt32((sender as Control).Name.Substring(9));
            int monitorType = (sender as ComboBox).SelectedIndex;
            bed.Monitors[monitor] = new Monitor(monitorType);
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
    }

}
