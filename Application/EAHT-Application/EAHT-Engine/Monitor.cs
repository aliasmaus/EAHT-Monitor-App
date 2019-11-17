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
        private MonitorSensor sensor;
        private int round; //The number of decimal places to round readings to.
        private string name;
        private string[] sensorTypes;
        private double[] defaultValues;
        private double[] defaultMinValues;
        private double[] defaultMaxValues;
        private double[] readRanges;
        private int[] readFrequencies;

        /// <summary>
        /// Constructs a monitor for use in a bed
        /// </summary>
        /// <param name="monitorType">The type of monitor to create</param>
        public Monitor(int monitorType)
        {
            DataSet monitorTypeInfo;
            DbConnection connection = new DbConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EAHT-Database.mdf;Integrated Security=True;Connect Timeout=30");
            connection.openConnection();
            monitorTypeInfo = connection.getDataSet("SELECT * from Monitors;");
            connection.closeConnection();
            DataTableReader reader = monitorTypeInfo.CreateDataReader();
            reader.Read();
            while(true)
            {
                int i = 0;
                try
                {
                    sensorTypes[i] = reader.GetString(1);
                    defaultValues[i] = reader.GetDouble(5);
                    defaultMinValues[i] = reader.GetDouble(3);
                    defaultMaxValues[i] = reader.GetDouble(4);
                    readRanges[i] = reader.GetDouble(6);
                    readFrequencies[i] = reader.GetInt32(2);
                    reader.Read();
                    i++;
                }
                catch
                {
                    break;
                }
            }
            this.name = Options.MonitorTypes[monitorType];
            switch(Name)
            {
                case "Blood Pressure (Sys)":
                    sensor = new MonitorSensor(Options.BloodPressureSys_DefaultReadFrequency, Options.BloodPressureSys_DefaultValue, Options.BloodPressureSys_DefaultReadRange,Options.BloodPressureSys_DefaultUpper,Options.BloodPressureSys_DefaultLower);
                    round = Options.BloodPressureSys_ReadRound;
                    break;
                case "Blood Pressure (Dia)":
                    sensor = new MonitorSensor(Options.BloodPressureDia_DefaultReadFrequency, Options.BloodPressureDia_DefaultValue, Options.BloodPressureDia_DefaultReadRange, Options.BloodPressureDia_DefaultUpper, Options.BloodPressureDia_DefaultLower);
                    round = Options.BloodPressureDia_ReadRound;
                    break;
                case "Temperature":
                    sensor = new MonitorSensor(Options.Temperature_DefaultReadFrequency, Options.Temperature_DefaultValue, Options.Temperature_DefaultReadRange, Options.Temperature_DefaultUpper, Options.Temperature_DefaultLower);
                    round = Options.Temperature_ReadRound;
                    break;
                case "Heart Rate":
                    sensor = new MonitorSensor(Options.HeartRate_DefaultReadFrequency, Options.HeartRate_DefaultValue, Options.HeartRate_DefaultReadRange, Options.HeartRate_DefaultUpper, Options.HeartRate_DefaultLower);
                    round = Options.HeartRate_ReadRound;
                    break;
                case "Breathing Rate":
                    sensor = new MonitorSensor(Options.BreathingRate_DefaultReadFrequency, Options.BreathingRate_DefaultValue, Options.BreathingRate_DefaultReadRange, Options.BreathingRate_DefaultUpper, Options.BreathingRate_DefaultLower);
                    round = Options.BreathingRate_ReadRound;
                    break;
            }
        }

        /// <summary>
        /// Gets the name property of the sensor.
        /// </summary>
        public string Name { get => name; }
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

    }
}
