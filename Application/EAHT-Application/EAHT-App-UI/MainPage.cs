using System;
using System.Windows.Forms;
using EAHT_Engine;

namespace EAHT_App_UI
{
    public partial class MainPage : Form
    {
        static Random rng = new Random();
        private Bay bay = new Bay(1);
        private System.Windows.Forms.GroupBox[] frames;
        private System.Windows.Forms.Label[][] monitorNameLabels;
        private System.Windows.Forms.Label[][] monitorValueLabels;
        private System.Windows.Forms.Button[] inspectBedButtons;

        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            //Create dynamic bed display
            // Create Arrays for controls
            int nBeds = bay.Beds.Length;
            frames = new GroupBox[nBeds];
            monitorNameLabels = new Label[nBeds][];
            monitorValueLabels = new Label[nBeds][];
            inspectBedButtons = new Button[nBeds];

            // for each bed add controls and configure

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
            MonitorPage monitorPage = new MonitorPage(bay.Beds[0]);
            monitorPage.Show();
        }

        private void Update_MainPage(object sender, EventArgs e)
        {
            //Update all text fields
            Bed bed = bay.Beds[0];
            B1M1_Name.Text = bed.Monitors[0].Name;
            B1M2_Name.Text = bed.Monitors[1].Name;
            B1M3_Name.Text = bed.Monitors[2].Name;
            B1M4_Name.Text = bed.Monitors[3].Name;
            B1M1_Reading.Text = bed.Monitors[0].Read();
            B1M2_Reading.Text = bed.Monitors[1].Read();
            B1M3_Reading.Text = bed.Monitors[2].Read();
            B1M4_Reading.Text = bed.Monitors[3].Read();
            Bed1_GroupBox.Text = "Bed " + bed.BedNumber.ToString();
            Bed bed2 = bay.Beds[1];
            B2M1_Name.Text = bed2.Monitors[0].Name;
            B2M2_Name.Text = bed2.Monitors[1].Name;
            B2M3_Name.Text = bed2.Monitors[2].Name;
            B2M4_Name.Text = bed2.Monitors[3].Name;
            B2M1_Reading.Text = bed2.Monitors[0].Read();
            B2M2_Reading.Text = bed2.Monitors[1].Read();
            B2M3_Reading.Text = bed2.Monitors[2].Read();
            B2M4_Reading.Text = bed2.Monitors[3].Read();
            Bed2_GroupBox.Text = "Bed " + bed2.BedNumber.ToString();
            Bed bed3 = bay.Beds[2];
            B3M1_Name.Text = bed3.Monitors[0].Name;
            B3M2_Name.Text = bed3.Monitors[1].Name;
            B3M3_Name.Text = bed3.Monitors[2].Name;
            B3M4_Name.Text = bed3.Monitors[3].Name;
            B3M1_Reading.Text = bed3.Monitors[0].Read();
            B3M2_Reading.Text = bed3.Monitors[1].Read();
            B3M3_Reading.Text = bed3.Monitors[2].Read();
            B3M4_Reading.Text = bed3.Monitors[3].Read();
            Bed3_GroupBox.Text = "Bed " + bed3.BedNumber.ToString();
            Bed bed4 = bay.Beds[3];
            B4M1_Name.Text = bed4.Monitors[0].Name;
            B4M2_Name.Text = bed4.Monitors[1].Name;
            B4M3_Name.Text = bed4.Monitors[2].Name;
            B4M4_Name.Text = bed4.Monitors[3].Name;
            B4M1_Reading.Text = bed4.Monitors[0].Read();
            B4M2_Reading.Text = bed4.Monitors[1].Read();
            B4M3_Reading.Text = bed4.Monitors[2].Read();
            B4M4_Reading.Text = bed4.Monitors[3].Read();
            Bed4_GroupBox.Text = "Bed " + bed4.BedNumber.ToString();
            Bed bed5 = bay.Beds[4];
            B5M1_Name.Text = bed5.Monitors[0].Name;
            B5M2_Name.Text = bed5.Monitors[1].Name;
            B5M3_Name.Text = bed5.Monitors[2].Name;
            B5M4_Name.Text = bed5.Monitors[3].Name;
            B5M1_Reading.Text = bed5.Monitors[0].Read();
            B5M2_Reading.Text = bed5.Monitors[1].Read();
            B5M3_Reading.Text = bed5.Monitors[2].Read();
            B5M4_Reading.Text = bed5.Monitors[3].Read();
            Bed5_GroupBox.Text = "Bed " + bed5.BedNumber.ToString();
            Bed bed6 = bay.Beds[5];
            B6M1_Name.Text = bed6.Monitors[0].Name;
            B6M2_Name.Text = bed6.Monitors[1].Name;
            B6M3_Name.Text = bed6.Monitors[2].Name;
            B6M4_Name.Text = bed6.Monitors[3].Name;
            B6M1_Reading.Text = bed6.Monitors[0].Read();
            B6M2_Reading.Text = bed6.Monitors[1].Read();
            B6M3_Reading.Text = bed6.Monitors[2].Read();
            B6M4_Reading.Text = bed6.Monitors[3].Read();
            Bed6_GroupBox.Text = "Bed " + bed6.BedNumber.ToString();
            Bed bed7 = bay.Beds[6];
            B7M1_Name.Text = bed7.Monitors[0].Name;
            B7M2_Name.Text = bed7.Monitors[1].Name;
            B7M3_Name.Text = bed7.Monitors[2].Name;
            B7M4_Name.Text = bed7.Monitors[3].Name;
            B7M1_Reading.Text = bed7.Monitors[0].Read();
            B7M2_Reading.Text = bed7.Monitors[1].Read();
            B7M3_Reading.Text = bed7.Monitors[2].Read();
            B7M4_Reading.Text = bed7.Monitors[3].Read();
            Bed7_GroupBox.Text = "Bed " + bed7.BedNumber.ToString();
            Bed bed8 = bay.Beds[7];
            B8M1_Name.Text = bed8.Monitors[0].Name;
            B8M2_Name.Text = bed8.Monitors[1].Name;
            B8M3_Name.Text = bed8.Monitors[2].Name;
            B8M4_Name.Text = bed8.Monitors[3].Name;
            B8M1_Reading.Text = bed8.Monitors[0].Read();
            B8M2_Reading.Text = bed8.Monitors[1].Read();
            B8M3_Reading.Text = bed8.Monitors[2].Read();
            B8M4_Reading.Text = bed8.Monitors[3].Read();
            Bed8_GroupBox.Text = "Bed " + bed8.BedNumber.ToString();
        }

        private void Open_Bed_2(object sender, EventArgs e)
        {
            MonitorPage monitorPage = new MonitorPage(bay.Beds[1]);
            monitorPage.Show();
        }

        private void Open_Bed_3(object sender, EventArgs e)
        {
            MonitorPage monitorPage = new MonitorPage(bay.Beds[2]);
            monitorPage.Show();
        }

        private void Open_Bed_4(object sender, EventArgs e)
        {
            MonitorPage monitorPage = new MonitorPage(bay.Beds[3]);
            monitorPage.Show();
        }

        private void Open_Bed_5(object sender, EventArgs e)
        {
            MonitorPage monitorPage = new MonitorPage(bay.Beds[4]);
            monitorPage.Show();
        }

        private void Open_Bed_6(object sender, EventArgs e)
        {
            MonitorPage monitorPage = new MonitorPage(bay.Beds[5]);
            monitorPage.Show();
        }

        private void Open_Bed_7(object sender, EventArgs e)
        {
            MonitorPage monitorPage = new MonitorPage(bay.Beds[6]);
            monitorPage.Show();
        }

        private void Open_Bed_8(object sender, EventArgs e)
        {
            MonitorPage monitorPage = new MonitorPage(bay.Beds[7]);
            monitorPage.Show();
        }
    }
}
