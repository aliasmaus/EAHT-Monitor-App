using System;
using System.Windows.Forms;
using EAHT_Engine;

namespace EAHT_App_UI
{
    public partial class MainPage : Form
    {
        static readonly Random rng = new Random();
        private readonly Ward ward;
        private System.Windows.Forms.GroupBox[][] frames;
        private System.Windows.Forms.Label[][][] monitorNameLabels;
        private System.Windows.Forms.Label[][][] monitorValueLabels;
        private System.Windows.Forms.Button[][] inspectBedButtons;
        private System.Windows.Forms.TabPage[] bayTabs;
        private System.Windows.Forms.FlowLayoutPanel[] bayFlowPanels;

        public MainPage()
        {
            InitializeComponent();
            ward = new Ward(0);
        }
        public MainPage(Ward ward)
        {
            InitializeComponent();
            this.ward = ward;
            WardLabel.Text = ward.Name;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // Get ward info
            int nBays = ward.Bays.Length;
            int nBeds = ward.Bays[0].Beds.Length;
            int nMonitors = ward.Bays[0].Beds[0].Monitors.Length;
            // Load dynamic display elements
            InitializeDynamicControls(nBays, nBeds, nMonitors);
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
            int bedIndex = Convert.ToInt32((sender as Control).Name.Substring(7).Trim());
            MonitorPage monitorPage = new MonitorPage(ward.Bays[0].Beds[bedIndex]);
            monitorPage.Show();
        }

        private void Update_MainPage(object sender, EventArgs e)
        {
            bool[][][] alarmLocations = ward.SearchForAlarms();
            ward.UpdateAlarmArray(alarmLocations);
            //for each bay
            for (int bay = 0; bay < ward.Bays.Length; bay++)
            {
                //for each bed
                for (int bed = 0; bed < ward.Bays[0].Beds.Length; bed++)
                {
                    bool colourBedRed = false;
                    //for each monitor
                    for (int monitor = 0; monitor < ward.Bays[0].Beds[0].Monitors.Length; monitor++)
                    {
                        if (!(ward.Bays[bay].Beds[bed].Monitors[monitor] is null))
                        {
                            monitorNameLabels[bay][bed][monitor].Text = ward.Bays[bay].Beds[bed].Monitors[monitor].Name;
                            monitorValueLabels[bay][bed][monitor].Text = ward.Bays[bay].Beds[bed].Monitors[monitor].Read();
                        }
                        else
                        {
                            monitorNameLabels[bay][bed][monitor].Text = "Monitor " + (monitor + 1).ToString();
                            monitorValueLabels[bay][bed][monitor].Text = "inactive";
                        }
                        if(alarmLocations[bay][bed][monitor])
                        {
                            colourBedRed = true;
                        }
                    }
                    if(colourBedRed)
                    {
                        frames[bay][bed].BackColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        frames[bay][bed].BackColor = System.Drawing.Color.CadetBlue;
                    }

                }
            }
            
        }

        private void InitializeDynamicControls(int nBays, int nBeds, int nMonitors)
        {
            // Initialize arrays to hold controls
            InitializeControlArrays(nBays);

            // Initialize bays and controls
            for (int bay = 0; bay < nBays; bay++)
            {
                InitializeBays(bay, nBeds);   
                
                // Initialize each bed control group
                for (int bed = 0; bed < nBeds; bed++)
                {
                    InitializeBeds(bay, bed, nMonitors);
                    // Initialize each monitor control group
                    for (int monitor = 0; monitor < nMonitors; monitor++)
                    {
                        InitializeMonitors(bed, bay, monitor);
                    }
                }
            }
        }
        private void InitializeControlArrays(int nBays)
        {
            bayTabs = new TabPage[nBays];
            frames = new GroupBox[nBays][];
            monitorNameLabels = new Label[nBays][][];
            monitorValueLabels = new Label[nBays][][];
            inspectBedButtons = new Button[nBays][];
            bayFlowPanels = new FlowLayoutPanel[nBays];
        }

        private void InitializeBays(int bay, int nBeds)
        {
            //create tabs for bays
            bayTabs[bay] = new TabPage();
            bayFlowPanels[bay] = new FlowLayoutPanel();
            //add bays to tab control
            BayDisplayTabControl.Controls.Add(bayTabs[bay]);
            //add flow layout panels to tabs
            bayTabs[bay].Controls.Add(bayFlowPanels[bay]);
            //configure tabs
            bayTabs[bay].Text = "Bay " + (bay + 1).ToString();
            //configure flow layout panels
            bayFlowPanels[bay].Size = new System.Drawing.Size(650, 370);
            frames[bay] = new GroupBox[nBeds];
            monitorNameLabels[bay] = new Label[nBeds][];
            monitorValueLabels[bay] = new Label[nBeds][];
            inspectBedButtons[bay] = new Button[nBeds];
        }
        private void InitializeBeds(int bay, int bed, int nMonitors)
        {
            //add extra arrays
            monitorNameLabels[bay][bed] = new Label[nMonitors];
            monitorValueLabels[bay][bed] = new Label[nMonitors];
            //add controls for each bed
            frames[bay][bed] = new GroupBox();
            bayFlowPanels[bay].Controls.Add(frames[bay][bed]);
            inspectBedButtons[bay][bed] = new Button();
            //add controls to their containers
            frames[bay][bed].Controls.Add(inspectBedButtons[bay][bed]);
            //
            //configure controls for beds
            //names
            inspectBedButtons[bay][bed].Name = "Button_" + bed.ToString();
            //text
            frames[bay][bed].Text = "Bed " + (bed + 1).ToString();
            inspectBedButtons[bay][bed].Text = "Inspect";
            //size
            frames[bay][bed].Size = new System.Drawing.Size(150, 150);
            inspectBedButtons[bay][bed].Size = new System.Drawing.Size(60, 25);
            //position
            inspectBedButtons[bay][bed].Location = new System.Drawing.Point(50, 110);
            //click event
            this.inspectBedButtons[bay][bed].Click += new EventHandler(Open_Bed);
        }
        private void InitializeMonitors(int bed, int bay, int monitor)
        {
            // add controls for each monitor in each bed
            monitorNameLabels[bay][bed][monitor] = new Label();
            monitorValueLabels[bay][bed][monitor] = new Label();
            // add controls to containers
            frames[bay][bed].Controls.Add(monitorNameLabels[bay][bed][monitor]);
            frames[bay][bed].Controls.Add(monitorValueLabels[bay][bed][monitor]);
            //configure controls for monitors
            //text
            monitorNameLabels[bay][bed][monitor].Text = "Monitor " + monitor.ToString();
            monitorValueLabels[bay][bed][monitor].Text = "###";
            //size
            monitorNameLabels[bay][bed][monitor].Size = new System.Drawing.Size(60, 13);
            monitorValueLabels[bay][bed][monitor].Size = new System.Drawing.Size(60, 13);
            //position
            int x = 15;
            if ((monitor + 1) / 2 % 2 == 0)
            {
                x += 70;
            }
            int y1 = 25;
            int y2 = 40;
            if (monitor > 1)
            {
                y1 += 40;
                y2 += 40;
            }
            monitorNameLabels[bay][bed][monitor].Location = new System.Drawing.Point(x, y1);
            monitorValueLabels[bay][bed][monitor].Location = new System.Drawing.Point(x, y2);
        }
    }
}
