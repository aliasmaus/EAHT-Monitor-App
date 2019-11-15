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
            this.Monitor1_CurrentReading.Text = bed.GetMonitor1Read();
            this.Monitor2_CurrentReading.Text = bed.GetMonitor2Read();
            this.Monitor3_CurrentReading.Text = bed.GetMonitor3Read();
            this.Monitor4_CurrentReading.Text = bed.GetMonitor4Read();
            bool[] alarms = bed.GetAlarms();
            if (alarms[0])
            {
                this.Monitor1_Background.BackColor = System.Drawing.Color.Red;
                string[] messages = bed.GetAlarmMessages();
                string messageText = "";
                for(int i=0; i<4; i++)
                {
                    if (!(messages[i]==""))
                    {
                        messageText += messages[i] + "\n";
                    }
                }
                AlarmMessage.Text = messageText;
            }
            else
            {
                this.Monitor1_Background.BackColor = System.Drawing.Color.CadetBlue;
            }
            if (alarms[1])
            {
                this.Monitor2_Background.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                this.Monitor2_Background.BackColor = System.Drawing.Color.CadetBlue;
            }
            if (alarms[2])
            {
                this.Monitor3_Background.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                this.Monitor3_Background.BackColor = System.Drawing.Color.CadetBlue;
            }
            if (alarms[3])
            {
                this.Monitor4_Background.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                this.Monitor4_Background.BackColor = System.Drawing.Color.CadetBlue;
            }
        }

        private void ChangeMonitor1(object sender, EventArgs e)
        {
            bed.InsertMonitor(Monitor1_Choice.SelectedIndex + 1, 1);
            double[][] minmax = bed.GetMonitorMinMax(1);
            monitor1_MinValueSelect.Value = (decimal)minmax[0][0];
            monitor1_MaxValueSelect.Value = (decimal)minmax[1][0];
        }

        private void ChangeMonitor2(object sender, EventArgs e)
        {
            bed.InsertMonitor(Monitor2_Choice.SelectedIndex + 1, 2);
            double[][] minmax = bed.GetMonitorMinMax(2);
            monitor2_MinValueSelect.Value = (decimal)minmax[0][0];
            monitor2_MaxValueSelect.Value = (decimal)minmax[1][0];
        }

        private void ChangeMonitor3(object sender, EventArgs e)
        {
            bed.InsertMonitor(Monitor3_Choice.SelectedIndex + 1, 3);
            double[][] minmax = bed.GetMonitorMinMax(3);
            monitor3_MinValueSelect.Value = (decimal)minmax[0][0];
            monitor3_MaxValueSelect.Value = (decimal)minmax[1][0];
        }

        private void ChangeMonitor4(object sender, EventArgs e)
        {
            bed.InsertMonitor(Monitor4_Choice.SelectedIndex + 1, 4);
            double[][] minmax = bed.GetMonitorMinMax(4);
            monitor4_MinValueSelect.Value = (decimal)minmax[0][0];
            monitor4_MaxValueSelect.Value = (decimal)minmax[1][0];
        }

        private void Monitor3_CurrentReading_Click(object sender, EventArgs e)
        {

        }

        private void Monitor1_CurrentReading_Click(object sender, EventArgs e)
        {

        }

        private void Monitor1MinChanged(object sender, EventArgs e)
        {
            bed.SetMonitor1Min((double)monitor1_MinValueSelect.Value,false);
        }

        private void Monitor1MaxChanged(object sender, EventArgs e)
        {
            bed.SetMonitor1Max((double)monitor1_MaxValueSelect.Value, false);
        }
        private void Monitor2MinChanged(object sender, EventArgs e)
        {
            bed.SetMonitor2Min((double)monitor2_MinValueSelect.Value, false);
        }

        private void Monitor2MaxChanged(object sender, EventArgs e)
        {
            bed.SetMonitor2Max((double)monitor2_MaxValueSelect.Value, false);
        }
        private void Monitor3MinChanged(object sender, EventArgs e)
        {
            bed.SetMonitor3Min((double)monitor3_MinValueSelect.Value, false);
        }

        private void Monitor3MaxChanged(object sender, EventArgs e)
        {
            bed.SetMonitor3Max((double)monitor3_MaxValueSelect.Value, false);
        }
        private void Monitor4MinChanged(object sender, EventArgs e)
        {
            bed.SetMonitor4Min((double)monitor4_MinValueSelect.Value, false);
        }

        private void Monitor4MaxChanged(object sender, EventArgs e)
        {
            bed.SetMonitor4Max((double)monitor4_MaxValueSelect.Value, false);
        }
    }

}
