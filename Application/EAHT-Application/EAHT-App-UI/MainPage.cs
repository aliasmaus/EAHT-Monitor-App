using System;
using System.Windows.Forms;
using EAHT_Engine;

namespace EAHT_App_UI
{
    public partial class MainPage : Form
    {
        static Random rng = new Random();
        private Bay bay = new Bay(1);

        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            Console.WriteLine("Insert your credentials");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //By clicking on this button, moves to another form, in this case to Managemnet report
            Management_Report_Interface management_Report_Interface = new Management_Report_Interface();
            management_Report_Interface.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //It goes to Login page
            Login login = new Login();
            login.ShowDialog();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            B1M1_Name.Text = "Temp.:" + rng.Next(35, 40) + "Celcius";
            B1M2_Name.Text = "Breath Rate" + rng.Next(10, 25) + "bpm";
            B1M4_Name.Text = "Pulse" + rng.Next(0, 100);
            B1M3_Name.Text = "L:" + rng.Next(1, 10) + "H:" + rng.Next(10, 20);

        }

        private void Open_Bed_1(object sender, EventArgs e)
        {
            MonitorPage monitorPage = new MonitorPage(bay.GetBedByID(1));
            monitorPage.Show();

        }

        private void Update_MainPage(object sender, EventArgs e)
        {
            //Update all text fields
            Bed bed = bay.GetBedByID(1);
            B1M1_Name.Text = bed.GetMonitor1Text();
            B1M2_Name.Text = bed.GetMonitor2Text();
            B1M3_Name.Text = bed.GetMonitor3Text();
            B1M4_Name.Text = bed.GetMonitor4Text();
            B1M1_Reading.Text = bed.GetMonitor1Read();
            B1M2_Reading.Text = bed.GetMonitor2Read();
            B1M3_Reading.Text = bed.GetMonitor3Read();
            B1M4_Reading.Text = bed.GetMonitor4Read();
            Bed1_GroupBox.Text = "Bed " + bed.BedNumber.ToString();
            Bed bed2 = bay.GetBedByID(2);
            B2M1_Name.Text = bed2.GetMonitor1Text();
            B2M2_Name.Text = bed2.GetMonitor2Text();
            B2M3_Name.Text = bed2.GetMonitor3Text();
            B2M4_Name.Text = bed2.GetMonitor4Text();
            B2M1_Reading.Text = bed2.GetMonitor1Read();
            B2M2_Reading.Text = bed2.GetMonitor2Read();
            B2M3_Reading.Text = bed2.GetMonitor3Read();
            B2M4_Reading.Text = bed2.GetMonitor4Read();
            Bed2_GroupBox.Text = "Bed " + bed2.BedNumber.ToString();
            Bed bed3 = bay.GetBedByID(3);
            B3M1_Name.Text = bed3.GetMonitor1Text();
            B3M2_Name.Text = bed3.GetMonitor2Text();
            B3M3_Name.Text = bed3.GetMonitor3Text();
            B3M4_Name.Text = bed3.GetMonitor4Text();
            B3M1_Reading.Text = bed3.GetMonitor1Read();
            B3M2_Reading.Text = bed3.GetMonitor2Read();
            B3M3_Reading.Text = bed3.GetMonitor3Read();
            B3M4_Reading.Text = bed3.GetMonitor4Read();
            Bed3_GroupBox.Text = "Bed " + bed3.BedNumber.ToString();
            Bed bed4 = bay.GetBedByID(4);
            B4M1_Name.Text = bed4.GetMonitor1Text();
            B4M2_Name.Text = bed4.GetMonitor2Text();
            B4M3_Name.Text = bed4.GetMonitor3Text();
            B4M4_Name.Text = bed4.GetMonitor4Text();
            B4M1_Reading.Text = bed4.GetMonitor1Read();
            B4M2_Reading.Text = bed4.GetMonitor2Read();
            B4M3_Reading.Text = bed4.GetMonitor3Read();
            B4M4_Reading.Text = bed4.GetMonitor4Read();
            Bed4_GroupBox.Text = "Bed " + bed4.BedNumber.ToString();
            Bed bed5 = bay.GetBedByID(5);
            B5M1_Name.Text = bed5.GetMonitor1Text();
            B5M2_Name.Text = bed5.GetMonitor2Text();
            B5M3_Name.Text = bed5.GetMonitor3Text();
            B5M4_Name.Text = bed5.GetMonitor4Text();
            B5M1_Reading.Text = bed5.GetMonitor1Read();
            B5M2_Reading.Text = bed5.GetMonitor2Read();
            B5M3_Reading.Text = bed5.GetMonitor3Read();
            B5M4_Reading.Text = bed5.GetMonitor4Read();
            Bed5_GroupBox.Text = "Bed " + bed5.BedNumber.ToString();
            Bed bed6 = bay.GetBedByID(6);
            B6M1_Name.Text = bed6.GetMonitor1Text();
            B6M2_Name.Text = bed6.GetMonitor2Text();
            B6M3_Name.Text = bed6.GetMonitor3Text();
            B6M4_Name.Text = bed6.GetMonitor4Text();
            B6M1_Reading.Text = bed6.GetMonitor1Read();
            B6M2_Reading.Text = bed6.GetMonitor2Read();
            B6M3_Reading.Text = bed6.GetMonitor3Read();
            B6M4_Reading.Text = bed6.GetMonitor4Read();
            Bed6_GroupBox.Text = "Bed " + bed6.BedNumber.ToString();
            Bed bed7 = bay.GetBedByID(7);
            B7M1_Name.Text = bed7.GetMonitor1Text();
            B7M2_Name.Text = bed7.GetMonitor2Text();
            B7M3_Name.Text = bed7.GetMonitor3Text();
            B7M4_Name.Text = bed7.GetMonitor4Text();
            B7M1_Reading.Text = bed7.GetMonitor1Read();
            B7M2_Reading.Text = bed7.GetMonitor2Read();
            B7M3_Reading.Text = bed7.GetMonitor3Read();
            B7M4_Reading.Text = bed7.GetMonitor4Read();
            Bed7_GroupBox.Text = "Bed " + bed7.BedNumber.ToString();
            Bed bed8 = bay.GetBedByID(8);
            B8M1_Name.Text = bed8.GetMonitor1Text();
            B8M2_Name.Text = bed8.GetMonitor2Text();
            B8M3_Name.Text = bed8.GetMonitor3Text();
            B8M4_Name.Text = bed8.GetMonitor4Text();
            B8M1_Reading.Text = bed8.GetMonitor1Read();
            B8M2_Reading.Text = bed8.GetMonitor2Read();
            B8M3_Reading.Text = bed8.GetMonitor3Read();
            B8M4_Reading.Text = bed8.GetMonitor4Read();
            Bed8_GroupBox.Text = "Bed " + bed8.BedNumber.ToString();

            //Update bed background colours
            // Red if alarm active
            // Blue if no alarms
            bool[] alarms = bay.FindAlarms();
            GroupBox[] bedBackgrounds = new GroupBox[8] {Bed1_GroupBox,Bed2_GroupBox,Bed3_GroupBox,Bed4_GroupBox,Bed5_GroupBox,Bed6_GroupBox,Bed7_GroupBox,Bed8_GroupBox};
            for (int i=0; i<8; i++)
            {
                if(alarms[i])
                {
                    bedBackgrounds[i].BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    bedBackgrounds[i].BackColor = System.Drawing.Color.CadetBlue;
                }
            }
        }

        private void Open_Bed_2(object sender, EventArgs e)
        {
            MonitorPage monitorPage = new MonitorPage(bay.GetBedByID(2));
            monitorPage.Show();
        }

        private void Open_Bed_3(object sender, EventArgs e)
        {
            MonitorPage monitorPage = new MonitorPage(bay.GetBedByID(3));
            monitorPage.Show();
        }

        private void Open_Bed_4(object sender, EventArgs e)
        {
            MonitorPage monitorPage = new MonitorPage(bay.GetBedByID(4));
            monitorPage.Show();
        }

        private void Open_Bed_5(object sender, EventArgs e)
        {
            MonitorPage monitorPage = new MonitorPage(bay.GetBedByID(5));
            monitorPage.Show();
        }

        private void Open_Bed_6(object sender, EventArgs e)
        {
            MonitorPage monitorPage = new MonitorPage(bay.GetBedByID(6));
            monitorPage.Show();
        }

        private void Open_Bed_7(object sender, EventArgs e)
        {
            MonitorPage monitorPage = new MonitorPage(bay.GetBedByID(7));
            monitorPage.Show();
        }

        private void Open_Bed_8(object sender, EventArgs e)
        {
            MonitorPage monitorPage = new MonitorPage(bay.GetBedByID(8));
            monitorPage.Show();
        }
    }
}
