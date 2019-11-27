using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAHT_Engine
{
    /// <summary>
    /// Beds contain a number of monitors
    /// </summary>
    public class Bed
    {
        private readonly int bedNumber;
        private readonly Monitor[] monitors;
        private readonly Ward wardRef;
        private int bayID;

        /// <summary>
        /// Initializes the bed
        /// </summary>
        /// <param name="ID">The bed number</param>
        /// <param name="nMonitors"></param>
        /// <param name="ward"></param>
        /// <param name="bay"></param>
        public Bed(int ID, int nMonitors, Ward ward, int bay)
        {
            this.bedNumber = ID;
            this.monitors = new Monitor[nMonitors];
            this.wardRef = ward;
            this.bayID = bay;
        }

        /// <summary>
        /// Get only, gets the bed's designated number
        /// </summary>
        public int BedNumber { get => bedNumber; }
        /// <summary>
        /// Gets the list of monitors for the bed
        /// </summary>
        public Monitor[] Monitors { get => monitors; }

        /// <summary>
        /// <para>Creates a new instance of a monitor of the chosen type and inserts it into the chosen slot</para>
        /// </summary>
        /// <param name="monitorType">Type of monitor to insert (see key above)</param>
        /// <param name="monitorNumber">Which monitor slot to attach the monitor to</param>
        public void InsertMonitor(int monitorType, int monitorNumber)
        {
            Monitor monitor;
            //create the monitor to insert
            monitor = new Monitor(monitorType, wardRef, bayID, bedNumber, monitorNumber);
            //insert the monitor
            monitors[monitorNumber] = monitor;
            UpdateMonitorsInBedsDatabase(monitorNumber,monitorType);
            
        }
        // TODO: If setting exists update it, otherwise insert new entry
        private void UpdateMonitorsInBedsDatabase(int monitorNumber, int newMonitorType)
        {
            SqlQueryExecutor.InsertIntoTable("Monitors_In_Beds", new string[5] { wardRef.Id.ToString(), bayID.ToString(), bedNumber.ToString(), monitorNumber.ToString(), monitorType.ToString() }, "(Ward, Bay, Bed, Monitor_Number, Monitor_Type)");
        }

        public string[] GetPossibleMonitors()
        {
            return SqlQueryExecutor.GetColumnValuesAsString("Monitors");
        }
        public bool[] GetMonitorAlarmStatuses()
        {
            bool[] statuses = new bool[monitors.Length];
            for (int monitor = 0; monitor < monitors.Length; monitor++)
            {
                if (!(Monitors[monitor] is null))
                {
                    statuses[monitor] = Monitors[monitor].CheckForAlarm();
                }
            }
            return statuses;
        }
    }
}
