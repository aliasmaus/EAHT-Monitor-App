using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace EAHT_Engine
{
    /// <summary>
    /// An alarm is created when a reading goes outside of acceptable levels.  
    /// Alarm is cleared when readings fall back within the acceptable range.  
    /// If an alarm is silenced it will still continue to update until levels fall within acceptable range
    /// </summary>
    // TODO: add columns to database for time silenced.

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
            SendNotification();
        }

        private void Updater_Elapsed(object sender, ElapsedEventArgs e)
        {
            CheckStatus();
        }

        // TODO: update record alarm function to account for silenced alarms
        /// <summary>
        /// Record alarm data in to database
        /// </summary>
        private void RecordAlarm()
        {
            string[] values = new string[9];
            values[0] = "\'" + wardRef.Name + "\'";
            values[1] = bayNumber.ToString();
            values[2] = bedNumber.ToString();
            values[4] = "\'" + monitorName + "\'";
            values[3] = monitorNumber.ToString();
            values[5] = "\'" + startTime.ToString() + "\'";
            values[6] = "\'" + endTime.ToString() + "\'";
            values[7] = "\'" + notes + "\'";
            values[8] = "\'none\'";
            string datacolumnstring = "(Ward, Bay, Bed, Monitor, Monitor_Type, Start_Time, End_Time, Notes, Intervening_Staff_Member)";

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
                    RecordAlarm();
                }
                else
                {
                    updater.Stop();
                    notes = "Alarm ended due to readings returning to normal range.";
                    EndAlarm();
                }
            }
        }
        // TODO: properly implement alarm notification 
        private void SendNotification()
        {
            notificationsSent = true;
        }
        // TODO: when login class completed alarm needs to record person that silenced the alarm.
        public void SilenceAlarm()
        {
            isSilenced = true;
            silencedTime = DateTime.Now;
            //staffMemberThatSilenced = login.staffID;
        }
    }
}
