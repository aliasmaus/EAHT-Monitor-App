using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAHT_Engine
{
    class Options
    {
        // A list of options that define the configuration of the system.
        //
        // Base Configuration Settings
        //
        internal static readonly int MonitorSlotsPerBed = 4;
        internal static readonly int BedsPerBay = 8;
        internal static readonly int BaysInOperation = 2;

        //
        // Sensor Configuration Settings
        //
        internal static readonly string[] MonitorTypes = new string[5] { "Blood Pressure (Sys)","Blood Pressure (Dia)","Temperature","Heart Rate","Breathing Rate"};
        // Blood Pressure (Sys)
        internal static readonly double BloodPressureSys_DefaultValue = 120;
        internal static readonly double BloodPressureSys_DefaultUpper = 130;
        internal static readonly double BloodPressureSys_DefaultLower = 100;
        internal static readonly double BloodPressureSys_DefaultReadFrequency = 5000;
        internal static readonly double BloodPressureSys_DefaultReadRange = 1;
        internal static readonly int BloodPressureSys_ReadRound = 0;
        // Blood Pressure (Dia)
        internal static readonly double BloodPressureDia_DefaultValue = 80;
        internal static readonly double BloodPressureDia_DefaultUpper = 90;
        internal static readonly double BloodPressureDia_DefaultLower = 60;
        internal static readonly double BloodPressureDia_DefaultReadFrequency = 5000;
        internal static readonly double BloodPressureDia_DefaultReadRange = 1;
        internal static readonly int BloodPressureDia_ReadRound = 0;
        // Temperature
        internal static readonly double Temperature_DefaultValue = 37.5;
        internal static readonly double Temperature_DefaultUpper = 37.8;
        internal static readonly double Temperature_DefaultLower = 37.3;
        internal static readonly double Temperature_DefaultReadFrequency = 5000;
        internal static readonly double Temperature_DefaultReadRange = 0.05;
        internal static readonly int Temperature_ReadRound = 2;
        // Heart Rate
        internal static readonly double HeartRate_DefaultValue = 70;
        internal static readonly double HeartRate_DefaultUpper = 90;
        internal static readonly double HeartRate_DefaultLower = 50;
        internal static readonly double HeartRate_DefaultReadFrequency = 1000;
        internal static readonly double HeartRate_DefaultReadRange = 1;
        internal static readonly int HeartRate_ReadRound = 0;
        // Breathing Rate
        internal static readonly double BreathingRate_DefaultValue = 16;
        internal static readonly double BreathingRate_DefaultUpper = 20;
        internal static readonly double BreathingRate_DefaultLower = 10;
        internal static readonly double BreathingRate_DefaultReadFrequency = 1000;
        internal static readonly double BreathingRate_DefaultReadRange = 1;
        internal static readonly int BreathingRate_ReadRound = 2;
    }
}
