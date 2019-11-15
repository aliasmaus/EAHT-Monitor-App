﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAHT_Engine
{
    /// <summary>
    /// Functionality related to beds
    /// </summary>
    public class Bed
    {
        private int bedNumber;
        private Monitor[] monitors;

        /// <summary>
        /// Initializes the bed
        /// </summary>
        /// <param name="ID">The bed number</param>
        public Bed(int ID)
        {
            this.bedNumber = ID;
            this.monitors = new Monitor[Options.MonitorSlotsPerBed];
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
        /// <para>1 - Blood Pressure, 2 - Temperature, 3 - Heart Rate, 4 - Breathing Rate</para>
        /// </summary>
        /// <param name="monitorType">Type of monitor to insert (see key above)</param>
        /// <param name="monitorNumber">Which monitor slot to attach the monitor to</param>
        /// <returns>Monitor if succesful</returns>
        public void InsertMonitor(int monitorType, int monitorNumber)
        {
            Monitor monitor;
            //create the monitor to insert
            monitor = new Monitor(monitorType);
            //insert the monitor
            monitors[monitorNumber - 1] = monitor;
        }
    }
}
