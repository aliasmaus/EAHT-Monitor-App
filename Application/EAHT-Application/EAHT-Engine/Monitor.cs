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
        public Alarm alarm;
        private int bay;
        private int bed;

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
                    sensor1 = new MonitorSensor(1000, 80, 1,85,75);
                    sensor2 = new MonitorSensor(1000, 120, 1,150,100);
                    break;
                case "Temperature":
                    sensor1 = new MonitorSensor(1000, 37.5, 0.05,37.7,37.4);
                    break;
                case "Heart Rate":
                    sensor1 = new MonitorSensor(1000, 70, 1,140,50);
                    break;
                case "Breathing Rate":
                    sensor1 = new MonitorSensor(1000, 16, 0.05,20,12);
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
        public bool GetAlarms()
        {
            switch(name)
            {
                case "Blood Pressure":
                    bool alarmStatus = false;
                    if (sensor1.IsAlarmed || sensor2.IsAlarmed)
                    {
                        alarmStatus = true;
                        CreateAlarmIfNoneExist();
                    }
                    else
                    {
                        ClearAlarmIfExists("TESTID");
                    }
                    return alarmStatus;
                default:
                    if (sensor1.IsAlarmed)
                    {
                        CreateAlarmIfNoneExist();
                    }
                    else
                    {
                        ClearAlarmIfExists("TESTID");
                    }
                    return sensor1.IsAlarmed;
            }
        }
        private void TriggerAlarm()
        {
            alarm = new Alarm(name + "Alarm", bay, bed);
        }
        public void CreateAlarmIfNoneExist()
        {
            if(alarm is null)
            {
                TriggerAlarm();
            }
        }
        private void TerminateAlarm(string whoTerminated)
        {
            alarm.EndAlarm(whoTerminated);
            alarm.RecordAlarm();
            alarm = null;
        }
        public void ClearAlarmIfExists(string whoTerminated)
        {
            if (!(alarm is null))
            {
                TerminateAlarm(whoTerminated);
            }
        }
        public double[] Min()
        {
            switch (name)
            {
                case "Blood Pressure":
                    return new double[2] { sensor1.CurrentLower, sensor2.CurrentLower };
                default:
                    return new double[1] { sensor1.CurrentLower };
            }
        }
        public double[] Max()
        {
            switch (name)
            {
                case "Blood Pressure":
                    return new double[2] { sensor1.CurrentUpper, sensor2.CurrentUpper };
                default:
                    return new double[1] { sensor1.CurrentUpper };
            }
        }

        public void SetMin(double value, int sensor)
        {
            switch(sensor)
            {
                case 1:
                    if (!(sensor1 is null))
                    {
                        sensor1.CurrentLower = value;
                    }
                    break;
                case 2:
                    if (!(sensor2 is null))
                    {
                        sensor2.CurrentLower = value;
                    }
                    break;
            }
        }
        public void SetMax(double value, int sensor)
        {
            switch(sensor)
            {
                case 1:
                    if (!(sensor1 is null))
                    {
                        sensor1.CurrentUpper = value;
                    }
                    break;
                case 2:
                    if (!(sensor2 is null))
                    {
                        sensor2.CurrentUpper = value;
                    }
                    break;
            }
        }

    }
}
