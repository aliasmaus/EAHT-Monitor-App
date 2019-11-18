﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAHT_Engine;
using System.Timers;

namespace EAHT_App_UI
{
    public partial class Management_Report_Interface : Form
    {
        /// <summary>
        /// Initializer for Interface
        /// </summary>
        public Management_Report_Interface()
        {
            InitializeComponent();
        }

        private void Management_Report_Interface_Load(object sender, EventArgs e)
        {
            
        }
        //Event handlers for management interface buttons

        /// <summary>
        /// Toggles panels (different screens) on the user interface on/off
        /// </summary>
        /// <param name="page">The Panel to show/hide </param>
        /// <param name="onoff">true = Visible + Enabled, false = Invisible + Disabled</param>
        private void TogglePage(Panel page, bool onoff)
            // 
        {
            page.Enabled = onoff;
            page.Visible = onoff;
        }

        //Home page events
        private void MgmtHome_StaffReportButton_Click(object sender, EventArgs e)
        {
            TogglePage(MgmtStaffReports_BackPanel, true);
        }

        private void MgmtHome_MedicalRecordsButton_Click(object sender, EventArgs e)
        {
            TogglePage(MgmtMedicalRecords_BackPanel, true);
        }

        private void MgmtHome_AlarmReportButton_Click(object sender, EventArgs e)
        {
            TogglePage(MgmtAlarmReports_BackPanel, true);
        }

        private void MgmtHome_LogstreamButton_Click(object sender, EventArgs e)
        {
            TogglePage(MgmtAlarmLog_BackPanel, true) ;
        }

        //Back Buttons
        private void MgmtAlarmLog_BackButton_Click(object sender, EventArgs e)
        {
            TogglePage(MgmtAlarmLog_BackPanel, false);
        }

        private void MgmtStaffReports_BackButton_Click(object sender, EventArgs e)
        {
            TogglePage(MgmtStaffReports_BackPanel, false);
        }

        private void MgmtMedicalRecords_BackButton_Click(object sender, EventArgs e)
        {
            TogglePage(MgmtMedicalRecords_BackPanel, false);
        }

        private void MgmtAlarmReports_BackButton_Click(object sender, EventArgs e)
        {
            TogglePage(MgmtAlarmReports_BackPanel, false);
        }
       
    }
}
