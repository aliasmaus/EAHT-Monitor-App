using EAHT_Engine;
using System;
using System.Windows.Forms;

namespace EAHT_App_UI
{
    public partial class MonitorPage : Form
    {
        private Bed bed;

        /// <summary>
        /// Initializes a monitor page
        /// </summary>
        /// <param name="bed">The bed to display/configure</param>
        public MonitorPage(Bed bed)
        {
            InitializeComponent();
            this.bed = bed;
        }
        private void MonitorPage_Load(object sender, EventArgs e)
        {
            this.BedValue.Text = "BED " + bed.BedNumber.ToString();
        }


        private void PageUpdate(object sender, EventArgs e)
        {
            this.Monitor1_CurrentReading.Text = bed.Monitors[0].Read();
            this.Monitor2_CurrentReading.Text = bed.Monitors[1].Read();
            this.Monitor3_CurrentReading.Text = bed.Monitors[2].Read();
            this.Monitor4_CurrentReading.Text = bed.Monitors[3].Read();
        }

        private void ChangeMonitor1(object sender, EventArgs e)
        {
            bed.InsertMonitor(Monitor1_Choice.SelectedIndex + 1, 1);
            monitor1_MinValueSelect.Value = (decimal)bed.Monitors[0].Sensor.CurrentLower;
            monitor1_MaxValueSelect.Value = (decimal)bed.Monitors[0].Sensor.CurrentUpper;
        }

        private void ChangeMonitor2(object sender, EventArgs e)
        {
            bed.InsertMonitor(Monitor2_Choice.SelectedIndex + 1, 2);
            monitor1_MinValueSelect.Value = (decimal)bed.Monitors[1].Sensor.CurrentLower;
            monitor1_MaxValueSelect.Value = (decimal)bed.Monitors[1].Sensor.CurrentUpper;
        }

        private void ChangeMonitor3(object sender, EventArgs e)
        {
            bed.InsertMonitor(Monitor3_Choice.SelectedIndex + 1, 3);
            monitor1_MinValueSelect.Value = (decimal)bed.Monitors[2].Sensor.CurrentLower;
            monitor1_MaxValueSelect.Value = (decimal)bed.Monitors[2].Sensor.CurrentUpper;
        }

        private void ChangeMonitor4(object sender, EventArgs e)
        {
            bed.InsertMonitor(Monitor4_Choice.SelectedIndex + 1, 4);
            monitor1_MinValueSelect.Value = (decimal)bed.Monitors[3].Sensor.CurrentLower;
            monitor1_MaxValueSelect.Value = (decimal)bed.Monitors[3].Sensor.CurrentUpper;
        }


        private void Monitor1MinChanged(object sender, EventArgs e)
        {
            bed.Monitors[0].SetMin((double)monitor1_MinValueSelect.Value);
        }

        private void Monitor1MaxChanged(object sender, EventArgs e)
        {
            bed.Monitors[0].SetMax((double)monitor1_MaxValueSelect.Value);
        }
        private void Monitor2MinChanged(object sender, EventArgs e)
        {
            bed.Monitors[1].SetMin((double)monitor2_MinValueSelect.Value);
        }

        private void Monitor2MaxChanged(object sender, EventArgs e)
        {
            bed.Monitors[1].SetMax((double)monitor1_MaxValueSelect.Value);
        }
        private void Monitor3MinChanged(object sender, EventArgs e)
        {
            bed.Monitors[2].SetMin((double)monitor3_MinValueSelect.Value);
        }

        private void Monitor3MaxChanged(object sender, EventArgs e)
        {
            bed.Monitors[2].SetMax((double)monitor1_MaxValueSelect.Value);
        }
        private void Monitor4MinChanged(object sender, EventArgs e)
        {
            bed.Monitors[3].SetMin((double)monitor4_MinValueSelect.Value);
        }

        private void Monitor4MaxChanged(object sender, EventArgs e)
        {
            bed.Monitors[3].SetMax((double)monitor1_MaxValueSelect.Value);
        }
    }

}
