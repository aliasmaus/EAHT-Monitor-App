using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EAHT_Engine
{
    /// <summary>
    /// A ward in the hospital, wards have names.  A ward has a set number of bays, beds per bay and monitors per bed.
    /// </summary>
    public class Ward
    {
        private readonly string name;
        private readonly Bay[] bays;
        private readonly string infoString;
        private Alarm[][][] alarms;
        /// <summary>
        /// Initializes the ward by retrieving ward data from the database
        /// </summary>
        /// <param name="ID"></param>
        public Ward(int ID)
        {
            //Load info from database
            DataSet wardInfo;
            wardInfo = SqlQueryExecutor.SelectAllFromTable("Ward_Settings","Id = "+ID.ToString());
            DataTableReader reader = wardInfo.CreateDataReader();
            reader.Read();
            //Load data from reader
            name = reader.GetString(1);
            int nBays = reader.GetInt32(2);
            int nBeds = reader.GetInt32(3);
            int nMonitors = reader.GetInt32(4);
            infoString = name + "-\nBays: " + nBays.ToString() + "\nBeds: " + nBeds.ToString() + "\nMonitors: " + nMonitors.ToString();
            //Load bays
            bays = new Bay[nBays];
            for(int bay = 0; bay<nBays; bay++)
            {
                bays[bay] = new Bay(bay, nBeds, nMonitors);
            }
            //load alarm arrays
            alarms = new Alarm[nBays][][];
            for (int bay = 0; bay < nBays; bay++)
            {
                alarms[bay] = new Alarm[nBeds][];
                for (int bed = 0; bed < nBeds; bed++)
                {
                    alarms[bay][bed] = new Alarm[nMonitors];
                }
            }

        }

        public Bay[] Bays { get => bays; }
        public string Name { get => name; }
        public string InfoString { get => infoString; }
        /// <summary>
        /// Get an array of bools representing required alarm locations
        /// true 
        /// </summary>
        /// <returns>3d array [bays][beds][monitors] true for alarmed, false for unalarmed</returns>
        public bool[][][] SearchForAlarms()
        {
            bool[][][] alarmLocations = new bool[bays.Length][][];
            for (int bay = 0; bay < bays.Length; bay++)
            {
                alarmLocations[bay] = new bool[bays[bay].Beds.Length][];
                for(int bed = 0; bed< bays[bay].Beds.Length; bed++)
                {
                    alarmLocations[bay][bed] = new bool[bays[bay].Beds[bed].Monitors.Length];
                    for(int monitor = 0; monitor < bays[bay].Beds[bed].Monitors.Length; monitor++)
                    {
                        if (!(bays[bay].Beds[bed].Monitors[monitor] is null))
                        {
                            double high = bays[bay].Beds[bed].Monitors[monitor].Sensor.CurrentUpper;
                            double low = bays[bay].Beds[bed].Monitors[monitor].Sensor.CurrentLower;
                            double value = bays[bay].Beds[bed].Monitors[monitor].Sensor.CurrentValue;
                            if (value <= low || value >= high)
                            {
                                alarmLocations[bay][bed][monitor] = true;
                            }
                            else
                            {
                                alarmLocations[bay][bed][monitor] = false;
                            }
                        }
                        
                    }
                }
            }
            return alarmLocations;
        }
        /// <summary>
        /// Creates new alarms in locations marked as true if no alarm exists, removes alarms in locations marked false if alarm exists.
        /// </summary>
        /// <param name="locations">3d array [bays][beds][monitors] true for alarmed, false for unalarmed</param>
        public void UpdateAlarmArray(bool[][][] locations)
        {
            for (int bay = 0; bay < alarms.Length; bay++)
            {
                for(int bed = 0; bed < alarms[bay].Length; bed++)
                {
                    for (int monitor = 0; monitor < alarms[bay][bed].Length; monitor ++)
                    {
                        if(locations[bay][bed][monitor])
                        {
                            if(alarms[bay][bed][monitor] is null)
                            {
                                alarms[bay][bed][monitor] = new Alarm(this,bay,bed,monitor);
                            }
                        }
                        else
                        {
                            if(!(alarms[bay][bed][monitor] is null))
                            {
                                alarms[bay][bed][monitor] = null;
                            }
                        }
                    }
                }
            }
        }
    }
}
