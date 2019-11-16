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
            int nMonitors = bay.Beds[0].Monitors.Length;
            frames = new GroupBox[nBeds];
            monitorNameLabels = new Label[nBeds][];
            monitorValueLabels = new Label[nBeds][];
            inspectBedButtons = new Button[nBeds];

            // for each bed add controls and configure
            for(int i=0; i<nBeds; i++)
            {
                //add extra arrays
                monitorNameLabels[i] = new Label[nMonitors];
                monitorValueLabels[i] = new Label[nMonitors];
                //add controls for each bed
                frames[i] = new GroupBox();
                inspectBedButtons[i] = new Button();
                //add controls to their containers
                BayPanel.Controls.Add(frames[i]);
                frames[i].Controls.Add(inspectBedButtons[i]);
                //
                //configure controls for beds
                //text
                frames[i].Text = "Bed " + (i+1).ToString();
                inspectBedButtons[i].Text = "Inspect";
                //size
                frames[i].Size = new System.Drawing.Size(150, 150);
                inspectBedButtons[i].Size = new System.Drawing.Size(60, 25);
                //position
                inspectBedButtons[i].Location = new System.Drawing.Point(50, 110);
                //click event
                this.inspectBedButtons[i].Click += new EventHandler(Open_Bed);

                for (int j=0; j<nMonitors;j++)
                {
                    // add controls for each monitor in each bed
                    monitorNameLabels[i][j] = new Label();
                    monitorValueLabels[i][j] = new Label();
                    // add controls to containers
                    frames[i].Controls.Add(monitorNameLabels[i][j]);
                    frames[i].Controls.Add(monitorValueLabels[i][j]);
                    //configure controls for monitors
                    //text
                    monitorNameLabels[i][j].Text = "Monitor " + j.ToString();
                    monitorValueLabels[i][j].Text = "###";
                    //size
                    monitorNameLabels[i][j].Size = new System.Drawing.Size(60,20);
                    monitorValueLabels[i][j].Size = new System.Drawing.Size(60,20);
                    //position
                    int x = 15;
                    if((j + 1) / 2 % 2 == 0)
                    {
                        x += 70;
                    }
                    int y1 = 25;
                    int y2 = 40;
                    if (j>1)
                    {
                        y1 += 40;
                        y2 += 40;
                    }
                    monitorNameLabels[i][j].Location = new System.Drawing.Point(x,y1);
                    monitorValueLabels[i][j].Location = new System.Drawing.Point(x,y2);
                }
            }
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

        private void Open_Bed(object sender, EventArgs e)
        {
            int bedIndex = 0;
            MonitorPage monitorPage = new MonitorPage(bay.Beds[bedIndex]);
            monitorPage.Show();
        }

        private void Update_MainPage(object sender, EventArgs e)
        {
            //for each bed
            for (int bed = 0; bed<bay.Beds.Length; bed++)
            {
                //for each monitor
                for( int monitor=0; monitor<bay.Beds[0].Monitors.Length; monitor++)
                {
                    if (!(bay.Beds[bed].Monitors[monitor] is null))
                    {
                        monitorNameLabels[bed][monitor].Text = bay.Beds[bed].Monitors[monitor].Name;
                        monitorValueLabels[bed][monitor].Text = bay.Beds[bed].Monitors[monitor].Read();
                    }
                    else
                    {
                        monitorNameLabels[bed][monitor].Text = "Monitor " + (monitor+1).ToString();
                        monitorValueLabels[bed][monitor].Text = "inactive";
                    }
                }

            }
            
        }
    }
}
