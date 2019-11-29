﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Data;

namespace EAHT_Engine
{
    /// <summary>
    /// An alarm is created when a reading goes outside of acceptable levels.  
    /// Alarm is cleared when readings fall back within the acceptable range.  
    /// If an alarm is silenced it will still continue to update until levels fall within acceptable range
    /// </summary>

    public class Alarm
    {
        private readonly DateTime startTime;
        private DateTime endTime;
        private bool isActive = false;
        private bool notificationsSent = false;
        private readonly Ward wardRef;
        private readonly int bayNumber;
        private readonly int bedNumber;
        private readonly int monitorNumber;
        private readonly MonitorSensor sensor;
        private readonly string monitorName;
        private string notes;
        private readonly Timer updater;
        private bool isSilenced;
        private DateTime silencedTime;
        public string[] notified;

        /// <summary>
        /// Indicates wether or not a staff member has intervened and silenced the alarm
        /// </summary>
        public bool IsSilenced { get => isSilenced; }

        /// <summary>
        /// Create new alarm
        /// </summary>
        public Alarm(Ward ward, int bay, int bed, int monitor)
        {
            this.startTime = DateTime.Now;
            this.isActive = true;
            this.wardRef = ward;
            this.sensor = ward.Bays[bay].Beds[bed].Monitors[monitor].Sensor;
            this.monitorName = ward.Bays[bay].Beds[bed].Monitors[monitor].Name;
            this.bedNumber = bed;
            this.bayNumber = bay;
            this.monitorNumber = monitor;
            updater = new Timer(1000);
            updater.Elapsed += Updater_Elapsed;
            updater.Start();
            notified = SendNotifications();
        }

        private void Updater_Elapsed(object sender, ElapsedEventArgs e)
        {
            CheckStatus();
        }
        /// <summary>
        /// Record alarm data in to database
        /// </summary>
        private void RecordAlarm()
        {
            string[] values;
            string datacolumnstring;
            if (isSilenced)
            {
                values = new string[10];
                datacolumnstring = "(Ward, Bay, Bed, Monitor, Monitor_Type, Start_Time, End_Time, Notes, Intervening_Staff_Member, Time_Silenced)";
                // NEED TO IMPLEMENT STAFF ID HERE
                values[8] = "\'" + LoginBackEnd.user + "\'";
                values[9] = "\'" + silencedTime.ToString() + "\'";
            }
            else
            {
                values = new string[9];
                values[8] = "\'none\'";
                datacolumnstring = "(Ward, Bay, Bed, Monitor, Monitor_Type, Start_Time, End_Time, Notes, Intervening_Staff_Member)";
            }
            
            values[0] = "\'" + wardRef.Name + "\'";
            values[1] = bayNumber.ToString();
            values[2] = bedNumber.ToString();
            values[4] = "\'" + monitorName + "\'";
            values[3] = monitorNumber.ToString();
            values[5] = "\'" + startTime.Year + "-" + startTime.Month .ToString() + "-" + startTime.Day + " " + startTime.Hour + ":" + startTime.Minute + ":" + startTime.Second + "\'";
            values[6] = "\'" + endTime.Year + "-" + endTime.Month.ToString() + "-" + endTime.Day + " " + endTime.Hour + ":" + endTime.Minute + ":" + endTime.Second + "\'";
            values[7] = "\'" + notes + "\'";
            SqlQueryExecutor.InsertIntoTable("Alarm_Records", values, datacolumnstring);
        }
        
        /// <summary>
        /// Called when the alarm ends (because vital signs fall within accepted levels again)
        /// </summary>
        private void EndAlarm()
        {
            endTime = DateTime.Now;
            RecordAlarm();
            isActive = false;
        }
        private void CheckStatus()
        {
            if (sensor.CurrentValue <= sensor.CurrentLower || sensor.CurrentValue >= sensor.CurrentUpper)
            {

            }
            else
            {
                if (isSilenced)
                {
                    updater.Stop();
                    notes = "Silenced by staff member";
                    EndAlarm();
                }
                else
                {
                    updater.Stop();
                    notes = "Alarm ended due to readings returning to normal range.";
                    EndAlarm();
                }
            }
        }
         
        private string[] SendNotifications()
        {
            DataSet data = SqlQueryExecutor.SelectColumnsFromTable(new string[2] { "Staff_Id", "Notification_Type"},"Staff_To_Notify_About_Beds", "(Ward_Id=" + wardRef.Id + ") AND (Bay_Number=" + bayNumber + ") AND (Bed_Number=" + bedNumber + ")");
            DataTableReader reader = data.CreateDataReader();
            List<string> StaffNames = new List<string>();
            while(reader.Read())
            {
                // Here would add code to send emails/pager alerts to staff
                // Instead making a list of staff names so that other feedback
                // can be given
                string id = reader.GetInt32(0).ToString();
                StaffNames.Add(SqlQueryExecutor.GetColumnValuesAsString("Staff", 1, "ID_Number=" + id)[0]);
            }
            
            return StaffNames.ToArray();

        }
        
        public void SilenceAlarm()
        {
            isSilenced = true;
            silencedTime = DateTime.Now;
            //staffMemberThatSilenced = login.staffID;
        }
    }
}
