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
        private int bed;
        private int bay;
        private string assignee;
        private string attendee;
        private DateTime endTime;

        /// <summary>
        /// Create new alarm
        /// </summary>
        /// <param name="reason">The reason the alarm was triggered</param>
        /// <param name="bay">The bay in which the alarm was triggered</param>
        /// <param name="bed">The bed in which the alarm was triggered</param>
        public Alarm(string reason,int bay, int bed)
        {
            this.startTime = DateTime.Now;
            this.reason = reason;
            this.bed = bed;
            this.bay = bay;
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
            this.attendee = attendee;
            RecordAlarm();
        }
    }
}
