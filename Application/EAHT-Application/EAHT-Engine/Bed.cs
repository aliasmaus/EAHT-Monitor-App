using System;
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
        private Monitor monitor1;
        private Monitor monitor2;
        private Monitor monitor3;
        private Monitor monitor4;

        /// <summary>
        /// Initializes the bed
        /// </summary>
        /// <param name="ID">The bed number</param>
        public Bed(int ID)
        {
            this.bedNumber = ID;
        }

        /// <summary>
        /// Get only, gets the bed's designated number
        /// </summary>
        public int BedNumber { get => bedNumber; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Gets the current monitor1 name</returns>
        public string GetMonitor1Text()
        {
            if (monitor1 is null)
            {
                return "Unassigned";
            }
            else
            {
                return monitor1.Name;
            }
        }

        public string GetMonitor2Text()
        {
            if (monitor2 is null)
            {
                return "Unassigned";
            }
            else
            {
                return monitor2.Name;
            }
        }
        public string GetMonitor3Text()
        {
            if (monitor3 is null)
            {
                return "Unassigned";
            }
            else
            {
                return monitor3.Name;
            }
        }
        public string GetMonitor4Text()
        {
            if (monitor4 is null)
            {
                return "Unassigned";
            }
            else
            {
                return monitor4.Name;
            }
        }
        public string GetMonitor1Read()
        {
            if (monitor1 is null)
            {
                return "#####";
            }
            else
            {
                return monitor1.Read();
            }
        }

        public string GetMonitor2Read()
        {
            if (monitor2 is null)
            {
                return "#####";
            }
            else
            {
                return monitor2.Read();
            }
        }
        public string GetMonitor3Read()
        {
            if (monitor3 is null)
            {
                return "#####";
            }
            else
            {
                return monitor3.Read();
            }
        }
        public string GetMonitor4Read()
        {
            if (monitor4 is null)
            {
                return "#####";
            }
            else
            {
                return monitor4.Read();
            }
        }
        public bool[] GetAlarms()
        {
            bool[] alarms = new bool[4] { false,false,false,false};
            if (!(monitor1 is null))
            {
                if (monitor1.GetAlarms())
                {
                    alarms[0] = true;
                }
            }
            if (!(monitor2 is null))
            {
                if (monitor2.GetAlarms())
                {
                    alarms[1] = true;
                }
            }
            if (!(monitor3 is null))
            {
                if (monitor3.GetAlarms())
                {
                    alarms[2] = true;
                }
            }
            if (!(monitor4 is null))
            {
                if (monitor4.GetAlarms())
                {
                    alarms[3] = true;
                }
            }

            return alarms;
        }

        /// <summary>
        /// <para>Creates a new instance of a monitor of the chosen type and inserts it into the chosen slot</para>
        /// <para>1 - Blood Pressure, 2 - Temperature, 3 - Heart Rate, 4 - Breathing Rate</para>
        /// </summary>
        /// <param name="monitorType">Type of monitor to insert (see key above)</param>
        /// <param name="monitorNumber">Which monitor slot to attach the monitor to</param>
        /// <returns>Monitor if succesful</returns>
        public Monitor InsertMonitor(int monitorType, int monitorNumber)
        {
            Monitor monitor;
            //create the monitor to insert
            switch(monitorType)
            {
                case 1:
                    monitor = new Monitor("Blood Pressure");
                    break;
                case 2:
                    monitor = new Monitor("Temperature");
                    break;
                case 3:
                    monitor = new Monitor("Heart Rate");
                    break;
                case 4:
                    monitor = new Monitor("Breathing Rate");
                    break;
                default:
                    throw new Exception("Invalid Monitor Type");
            }
            //insert the monitor
            switch(monitorNumber)
            {
                case 1:
                    monitor1 = monitor;
                    break;
                case 2:
                    monitor2 = monitor;
                    break;
                case 3:
                    monitor3 = monitor;
                    break;
                case 4:
                    monitor4 = monitor;
                    break;
                default:
                    throw new Exception("Invalid Monitor Slot");
            }
            return monitor;
        }

    }
}
