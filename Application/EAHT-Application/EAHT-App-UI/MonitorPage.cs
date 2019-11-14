using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAHT_Engine;

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void BayValue_Click(object sender, EventArgs e)
        {

        }

        private void MonitorPage_Load(object sender, EventArgs e)
        {
            this.BedValue.Text = "BED " + bed.BedNumber.ToString();
        }

        private void pulseVariable_TextChanged(object sender, EventArgs e)
        {
            // Code used within the text box
            // Random number generator for the pulse text box
            //Random randomPulse = new Random();
            //randomPulse.Next(60, 100);
            //Console.WriteLine("{0}", randomPulse);
        }

        private void tempVariable_TextChanged(object sender, EventArgs e)
        {
            // Code used within the text box
            // Random number generator for the temperature text box
            //Random randomTemp = new Random();
            //randomTemp.Next(36, 38);
            //Console.WriteLine("{0}", randomTemp);

        }

        private void bloodVariable_TextChanged(object sender, EventArgs e)
        {
            // Code used within the text box
            // Random number generator for the blood text box
            //Random randomBlood = new Random();
            //randomBlood.Next(60, 90);
            //Console.WriteLine("{0}", randomBlood);
        }

        private void breatingVariable_TextChanged(object sender, EventArgs e)
        {
            // Code used within the text box
            // Random number generator for the breating text box
            //Random randomBreathing = new Random();
            //randomBreathing.Next(12, 16);
            //Console.WriteLine("{0}", randomBreathing);
        }

        private void SaveTemperatureValue_Click(object sender, EventArgs e)
        {
            // Save the temeperature value button
            //MonitorPage obj = new MonitorPage();
            //obj.temperatureValue = txtTemperatureValue.text; // Variable needs to be made

            //MonitorPage monitorPage = new MonitorPage();
            //monitorPage.Show();
        }

        private void SavePulseValue_Click(object sender, EventArgs e)
        {
            // Save the pulse rate value button
            //MonitorPage obj = new MonitorPage();
            //obj.pulseValue = txtPulseValue.text; // Variable needs to be made

            //MonitorPage monitorPage = new MonitorPage();
            //monitorPage.Show();
        }

        private void SaveBreathingValue_Click(object sender, EventArgs e)
        {
            // Save the breathing rate value button
            //MonitorPage obj = new MonitorPage();
            //obj.breathingValue = txtBreathingValue.text; // Variable needs to be made

            //MonitorPage monitorPage = new MonitorPage();
            //monitorPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Save the blood pressure value button
            //MonitorPage obj = new MonitorPage();
            //obj.bloodValue = txtBloodValue.txt // Variable need to be made

            //MonitorPage monitorPage = new MonitorPage();
            //monitorPage.Show();
        }


        private void ReturnButton_Click(object sender, EventArgs e)
        {
            // Button to return to the previous page
            MainPage mainPage = new MainPage();
            mainPage.Show();
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

        }

        private void ChangeMonitor2(object sender, EventArgs e)
        {
            bed.InsertMonitor(Monitor2_Choice.SelectedIndex + 1, 2);
        }

        private void ChangeMonitor3(object sender, EventArgs e)
        {
            bed.InsertMonitor(Monitor3_Choice.SelectedIndex + 1, 3);
        }

        private void ChangeMonitor4(object sender, EventArgs e)
        {
            bed.InsertMonitor(Monitor4_Choice.SelectedIndex + 1, 4);
        }

        private void Monitor3_CurrentReading_Click(object sender, EventArgs e)
        {

        }
    }
}
