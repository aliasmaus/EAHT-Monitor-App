﻿using System;
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
        public Bed(int ID, int nMonitors, Ward ward)
        {
            this.bedNumber = ID;
            this.monitors = new Monitor[nMonitors];
            this.wardRef = ward;
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
