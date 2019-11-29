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
        private int id;
        /// <summary>
        /// Initializes the ward by retrieving ward data from the database
        /// </summary>
        /// <param name="ID"></param>
        public Ward(int ID)
        {
            this.id = ID;
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
            //Load bays
            bays = new Bay[nBays];
            for(int bay = 0; bay<nBays; bay++)
            {
                bays[bay] = new Bay(bay, nBeds, nMonitors, this);
            }

        }
        /// <summary>
        /// The bays on the ward
        /// </summary>
        public Bay[] Bays { get => bays; }
        /// <summary>
        /// The ward's name
        /// </summary>
        public string Name { get => name; }
        /// <summary>
        /// The database Id of the ward
        /// </summary>
        public int Id { get => id; }

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
                            alarmLocations[bay][bed][monitor] = bays[bay].Beds[bed].Monitors[monitor].CheckForAlarm();
                        }
                        
                    }
                }
            }
            return alarmLocations;
        }
    }
}
