using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAHT_Engine
{
    /// <summary>
    /// Monitors can be attached to a slot in a bed.  They contain sensors which produce readings.
    /// </summary>
    public class Monitor
    {
        private string name;
        private MonitorSensor sensor1;
        private MonitorSensor sensor2;

        /// <summary>
        /// Constructs a monitor for use in a bed
        /// </summary>
        /// <param name="monitorType">The type of monitor to create</param>
        public Monitor(string monitorType)
        {
            this.name = monitorType;
            switch(monitorType)
            {
                case "Blood Pressure":
                    sensor1 = new MonitorSensor(1000, 80, 1);
                    sensor2 = new MonitorSensor(1000, 120, 1);
                    break;
                case "Temperature":
                    sensor1 = new MonitorSensor(1000, 37.5, 0.05);
                    break;
                case "Heart Rate":
                    sensor1 = new MonitorSensor(1000, 70, 1);
                    break;
                case "Breathing Rate":
                    sensor1 = new MonitorSensor(1000, 16, 0.05);
                    break;
            }
        }

        /// <summary>
        /// Gets the name property of the sensor.
        /// </summary>
        public string Name { get => name; }

        /// <summary>
        /// Get a string representing the current reading from the sensor(s) in the monitor, rounded appropriately.
        /// </summary>
        /// <returns>Current value of the most recent sensor(s) read.</returns>
        public string Read()
        {
            switch (name)
            {
                case "Blood Pressure":
                    return Math.Round(sensor1.CurrentValue).ToString() + " / " + Math.Round(sensor2.CurrentValue).ToString();
                default:
                    return Math.Round(sensor1.CurrentValue, 2).ToString();
            }
        }
    }
}
