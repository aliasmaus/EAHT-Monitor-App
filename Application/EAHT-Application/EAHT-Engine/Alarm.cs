using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAHT_Engine
{
    /// <summary>
    /// An alarm is created when a reading goes outside of acceptable levels
    /// </summary>
    public class Alarm
    {
        private DateTime startTime;
        private string reason;
        private int[] locationIndex = new int[3];
        private string assignee;
        private string attendee;
        private DateTime endTime;
        private bool isActive;
        private bool notificationsSent;

        /// <summary>
        /// Create new alarm
        /// </summary>
        /// <param name="reason">The reason the alarm was triggered</param>
        /// <param name="bayNum">Index (not number) of bay</param>
        /// <param name="bedNum">Index of bed</param>
        /// <param name="monitorNum">Index of monitor</param>
        public Alarm(string reason,int bayNum, int bedNum, int monitorNum)
        {
            this.startTime = DateTime.Now;
            this.reason = reason;
            this.locationIndex[1] = bedNum;
            this.locationIndex[0] = bayNum;
            this.locationIndex[2] = monitorNum;
            this.isActive = true;
        }

        /// <summary>
        /// Record alarm data in to database
        /// </summary>
        public void RecordAlarm()
        {

        }

        /// <summary>
        /// Called when the alarm ends (either because it is shut off or vital signs fall within accepted levels again)
        /// </summary>
        /// <param name="attendee"></param>
        public void EndAlarm(string attendee)
        {
            endTime = DateTime.Now;
            isActive = false;
            this.attendee = attendee;
            RecordAlarm();
        }
        /// <summary>
        /// Get the alarm summary message
        /// </summary>
        /// <returns>summary message with reason for alarm</returns>
        public string GetMessage()
        {
            return reason;
        }
    }
}
