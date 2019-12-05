﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
        private readonly int bayID;

        /// <summary>
        /// Initializes the bed
        /// </summary>
        /// <param name="ID">The bed number</param>
        /// <param name="nMonitors"></param>
        /// <param name="ward"></param>
        /// <param name="bay"></param>
        public Bed(int ID, int nMonitors, Ward ward, int bay)
        {
            // Initialise fields
            this.bedNumber = ID;
            this.monitors = new Monitor[nMonitors];
            wardRef = ward;
            bayID = bay;

            // Load any existing monitors
            LoadMonitorConfigurationFromDatabase();
        }

        private void LoadMonitorConfigurationFromDatabase()
        {
            int[] monitorConfig = GetMonitorConfigurationFromDatabase();
            for (int monitor = 0; monitor < monitors.Length; monitor++)
            {
                if(monitorConfig[monitor]>=0)
                {
                    monitors[monitor] = new Monitor(monitorConfig[monitor],wardRef,BayID,bedNumber,monitor);
                }
            }
        }

        private int[] GetMonitorConfigurationFromDatabase()
        {
            string AND = ") AND ";
            DataSet monitorData = SqlQueryExecutor.SelectColumnsFromTable(new string[2] { "Monitor_Number", "Monitor_Type" }, "Monitors_In_Beds", "(Ward=" + wardRef.Id + AND + "(Bay=" + BayID + AND + "(Bed=" + bedNumber + AND + "(Monitor_Number<" + monitors.Length + ")");
            DataTableReader reader = monitorData.CreateDataReader();
            int[] types = new int[monitors.Length];
            for (int monitor = 0;  monitor < types.Length; monitor++)
            {
                types[monitor] = -1;
            }
            while (reader.Read())
            {
                types[reader.GetInt32(0)] = reader.GetInt32(1);
            }
            return types;
        }

        /// <summary>
        /// Get only, gets the bed's designated number
        /// </summary>
        public int BedNumber { get => bedNumber; }
        /// <summary>
        /// Gets the list of monitors for the bed
        /// </summary>
        public Monitor[] Monitors { get => monitors; }

        public Ward WardRef => wardRef;

        public int BayID { get => bayID;  }

        /// <summary>
        /// <para>Creates a new instance of a monitor of the chosen type and inserts it into the chosen slot</para>
        /// </summary>
        /// <param name="monitorType">Type of monitor to insert (see key above)</param>
        /// <param name="monitorNumber">Which monitor slot to attach the monitor to</param>
        public void InsertMonitor(int monitorType, int monitorNumber)
        {
            Monitor monitor;
            //create the monitor to insert
            monitor = new Monitor(monitorType, wardRef, BayID, bedNumber, monitorNumber);
            //insert the monitor
            monitors[monitorNumber] = monitor;
            UpdateMonitorsInBedsDatabase(monitorNumber,monitorType);
            
        }
        // TODO: If setting exists update it, otherwise insert new entry
        private void UpdateMonitorsInBedsDatabase(int monitorNumber, int monitorType)
        {
            string whereClause = "(Ward=" + wardRef.Id + ") AND (Bay=" + BayID + ") AND (Bed=" + bedNumber + ") AND (Monitor_Number=" + monitorNumber + ")";
            DataSet data = SqlQueryExecutor.SelectAllFromTable("Monitors_In_Beds", whereClause);
            DataTableReader reader = data.CreateDataReader();
            if(reader.Read())
            {
                SqlQueryExecutor.UpdateTable("Monitors_In_Beds", "Monitor_Type=" + monitorType, whereClause);
            }
            else
            {
                SqlQueryExecutor.InsertIntoTable("Monitors_In_Beds", new string[5] { wardRef.Id.ToString(), BayID.ToString(), bedNumber.ToString(), monitorNumber.ToString(), monitorType.ToString() }, "(Ward, Bay, Bed, Monitor_Number, Monitor_Type)");
            }
            
        }

        /// <summary>
        /// Get the names of possible monitors
        /// </summary>
        /// <returns>monitor names as array of strings</returns>
        public string[] GetPossibleMonitors()
        {
            return SqlQueryExecutor.GetColumnValuesAsString("Monitors");
        }
        /// <summary>
        /// Get bools for if monitors are alarmed
        /// </summary>
        /// <returns>alarm statuses (true/false)</returns>
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

        public void RegisterStaffForNotifications(int type)
        {
            string staffID = SqlQueryExecutor.GetColumnValuesAsString("Staff", 0, "First_Name=\'" + LoginBackEnd.user + "\'")[0];
            string[] data = new string[5] {staffID, wardRef.Id.ToString(), BayID.ToString(), bedNumber.ToString(), type.ToString()};
            string columns = "(Staff_Id, Ward_Id, Bay_Number, Bed_Number, Notification_Type)";
            SqlQueryExecutor.InsertIntoTable("Staff_To_Notify_About_Beds",data, columns);
        }

        public void DeregisterStaffForNotifications()
        {
            string staffid = SqlQueryExecutor.GetColumnValuesAsString("Staff", 0, "First_Name=\'" + LoginBackEnd.user + "\'")[0];
            SqlQueryExecutor.DeleteRowsFromTable("Staff_To_Notify_About_Beds", "(Ward_Id=" + WardRef.Id + ") AND (Bay_Number=" + BayID + ") AND (Bed_Number=" + BedNumber + ") AND (Staff_Id=\'" + staffid + "\')");
        }
    }
}
