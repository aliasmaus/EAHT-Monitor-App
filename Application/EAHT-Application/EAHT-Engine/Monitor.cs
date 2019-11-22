using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EAHT_Engine
{
    /// <summary>
    /// Monitors can be attached to a slot in a bed.  They contain sensors which produce readings.
    /// </summary>
    public class Monitor
    {
        private readonly MonitorSensor sensor;
        private readonly int round; //The number of decimal places to round readings to.
        private readonly string name;
        private readonly List<string> sensorTypes = new List<string>();
        private readonly List<double> defaultValues = new List<double>();
        private readonly List<double> defaultMinValues = new List<double>();
        private readonly List<double> defaultMaxValues = new List<double>();
        private readonly List<double> readRanges = new List<double>();
        private readonly List<int> readFrequencies = new List<int>();
        private readonly List<int> readRounds = new List<int>();

        /// <summary>
        /// Constructs a monitor for use in a bed
        /// </summary>
        /// <param name="monitorType">The type of monitor to create</param>
        public Monitor(int monitorType)
        {
            DataSet monitorTypeInfo = SqlQueryExecutor.SelectAllFromTable("Monitors");
            DataTableReader reader = monitorTypeInfo.CreateDataReader();
            while(reader.Read())
            {
                sensorTypes.Add(reader.GetString(1));
                defaultValues.Add(reader.GetDouble(5));
                defaultMinValues.Add(reader.GetDouble(3));
                defaultMaxValues.Add(reader.GetDouble(4));
                readRanges.Add(reader.GetDouble(6));
                readFrequencies.Add(reader.GetInt32(2));
                readRounds.Add(2);
            }
            this.name = sensorTypes[monitorType];
            sensor = new MonitorSensor(readFrequencies[monitorType], defaultValues[monitorType], readRanges[monitorType], defaultMaxValues[monitorType], defaultMinValues[monitorType]);
            round = readRounds[monitorType];
        }

        /// <summary>
        /// Gets the name property of the sensor.
        /// </summary>
        public string Name { get => name; }
        /// <summary>
        /// Gets the sensor currently attached to the monitor
        /// </summary>
        public MonitorSensor Sensor { get => sensor; }
        /// <summary>
        /// Get a string representing the current reading from the sensor(s) in the monitor, rounded appropriately.
        /// </summary>
        /// <returns>Current value of the most recent sensor(s) read.</returns>
        public string Read()
        {
             return Math.Round(sensor.CurrentValue, round).ToString();
        }
        /// <summary>
        /// Set the minimum acceptable level for the alarm.
        /// </summary>
        /// <param name="value">alarm level lower</param>
        public void SetMin(double value)
        {
            //if sensor exists, adjust value
            if (!(sensor is null))
            {
                sensor.CurrentLower = value;
            }

        }
        /// <summary>
        /// set the maximum acceptable level for the alarm.
        /// </summary>
        /// <param name="value">alarm level higher</param>
        public void SetMax(double value)
        {
            //if sensor exists, adjust value
            if (!(sensor is null))
            {
                sensor.CurrentUpper = value;
            }
                    
        }
        public string[] SensorTypes { get => sensorTypes.ToArray(); }
    }
}
