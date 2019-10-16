using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAHT_App_UI
{
    public partial class Management_Report_Interface : Form
    {
        public Management_Report_Interface()
        {
            InitializeComponent();
        }

        private void Management_Report_Interface_Load(object sender, EventArgs e)
        {

        }

        private void MgmtHome_StaffReportButton_Click(object sender, EventArgs e)
        {
            MgmtStaffReports_BackPanel.Enabled = true;
            MgmtStaffReports_BackPanel.Visible = true;
        }

        private void MgmtHome_MedicalRecordsButton_Click(object sender, EventArgs e)
        {
            MgmtMedicalRecords_BackPanel.Enabled = true;
            MgmtMedicalRecords_BackPanel.Visible = true;
        }

        private void MgmtHome_AlarmReportButton_Click(object sender, EventArgs e)
        {

        }

        private void MgmtAlarmLog_BackButton_Click(object sender, EventArgs e)
        {
            MgmtAlarmLog_BackPanel.Enabled = false;
            MgmtAlarmLog_BackPanel.Visible = false;
        }

        private void MgmtHome_LogstreamButton_Click(object sender, EventArgs e)
        {
            MgmtAlarmLog_BackPanel.Enabled = true;
            MgmtAlarmLog_BackPanel.Visible = true;
        }

        private void MgmtStaffReports_BackButton_Click(object sender, EventArgs e)
        {
            MgmtStaffReports_BackPanel.Enabled = false;
            MgmtStaffReports_BackPanel.Visible = false;
        }

        private void MgmtMedicalRecords_BackButton_Click(object sender, EventArgs e)
        {
            MgmtMedicalRecords_BackPanel.Visible = false;
            MgmtMedicalRecords_BackPanel.Enabled = false;
        }
    }
}
