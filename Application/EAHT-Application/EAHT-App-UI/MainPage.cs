﻿using System;
using System.Windows.Forms;
using EAHT_Engine;
using System.Data;

namespace EAHT_App_UI
{
    public partial class MainPage : Form
    {
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
        private void Open_Bed(object sender, EventArgs e)
        {
            string[] info = (sender as Control).Name.Split( '_' );
            int bayIndex = Convert.ToInt32(info[0]);
            int bedIndex = Convert.ToInt32(info[1]);
            MonitorPage monitorPage = new MonitorPage(ward.Bays[bayIndex].Beds[bedIndex]);
            monitorPage.Show();
        }
        private void Update_MainPage(object sender, EventArgs e)
        {
            string messages = "";
            bool[][][] alarmLocations = ward.SearchForAlarms();
            //for each bay
            for (int bay = 0; bay < ward.Bays.Length; bay++)
            {
                //for each bed
                for (int bed = 0; bed < ward.Bays[bay].Beds.Length; bed++)
                {
                    bool colourBedRed = false;
                    //for each monitor
                    for (int monitor = 0; monitor < ward.Bays[bay].Beds[bed].Monitors.Length; monitor++)
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
                            messages += ward.Bays[bay].Beds[bed].Monitors[monitor].Name + " alarm is active at - Bay: " + (bay+1) + " Bed: " + (bed+1);
                            if(!ward.Bays[bay].Beds[bed].Monitors[monitor].Alarm.IsSilenced)
                            {
                                colourBedRed = true;
                            }
                            else
                            {
                                colourBedRed = false;
                                messages += " (This alarm has been silenced)";
                            }
                            messages += Environment.NewLine;
                        }
                    }
                    if (messages != AlarmMessages.Text)
                    {
                        AlarmMessages.Text = messages;
                    }
                    if(colourBedRed)
                    {
                        frames[bay][bed].BackColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        frames[bay][bed].BackColor = System.Drawing.Color.PowderBlue;
                    }

                }
            }

            //DebugLabel.Text = "Debug:" + Environment.NewLine;
            //DataSet data = SqlQueryExecutor.SelectAllFromTable("Monitors_In_Beds");
            //DataTableReader reader = data.CreateDataReader();
            //while(reader.Read())
            //{
            //    DebugLabel.Text += reader.GetValue(1).ToString() + " ";
            //    DebugLabel.Text += reader.GetValue(2).ToString() + " ";
            //    DebugLabel.Text += reader.GetValue(3).ToString() + " ";
            //    DebugLabel.Text += reader.GetValue(4).ToString() + " ";
            //    DebugLabel.Text += reader.GetValue(5).ToString() + " " + Environment.NewLine;
            //}

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
            bayFlowPanels[bay].AutoScroll = true;
            //add bays to tab control
            BayDisplayTabControl.Controls.Add(bayTabs[bay]);
            //add flow layout panels to tabs
            bayTabs[bay].Controls.Add(bayFlowPanels[bay]);
            //configure tabs
            bayTabs[bay].Text = "Bay " + (bay + 1).ToString();
            bayTabs[bay].BackColor = System.Drawing.Color.Wheat;
            //configure flow layout panels
            bayFlowPanels[bay].Size = bayTabs[bay].Size;
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
            inspectBedButtons[bay][bed].Name = bay.ToString() + "_" + bed.ToString();
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
            if ((monitor) % 2 == 1)
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

        //private void ResizeComponents(object sender, EventArgs e)
        //{
        //    int margin = this.Size.Height/20;
        //    LogOffButton.Location = new System.Drawing.Point();
        //}

        private void LogOff(object sender, EventArgs e)
        {
            //It goes to Login page
            LoginPage login = new LoginPage();
            login.ShowDialog();
            // Close this form
            this.Close();
        }

        private void OpenManagementPage(object sender, EventArgs e)
        {
            //By clicking on this button, moves to another form, in this case to Managemnet report
            Management_Report_Interface management_Report_Interface = new Management_Report_Interface(this);
            management_Report_Interface.Show();
            this.Hide();
        }
    }
}
