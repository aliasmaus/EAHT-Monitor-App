using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace EAHT_Engine
{
    /// <summary>
    /// Class is an abstraction of a monitor sensor that takes a single reading at a given interval and updates it's current value within a given range
    /// </summary>
    public class MonitorSensor
    {
        private double readFrequency; // (milliseconds)
        private double startValue; // initial reading value
        private double readRange; // range that each reading can vary from the last (either above or below)
        private Timer readTimer; // timer to generate read event
        private Random random; // random to get random difference
        private double currentValue; // the current value of the sensor
        private double currentUpper; // the upper limit for acceptable readings (value greater than this will trigger alarm)
        private double currentLower; // the lower limit for acceptable readings (value lower than this will trigger alarm)
        private bool isAlarmed;

        /// <summary>
        /// Get the most recent reading from the sensor
        /// </summary>
        public double CurrentValue { get => currentValue; }
        /// <summary>
        /// Upper limit, value beyond which an alarm is triggered
        /// </summary>
        public double CurrentUpper { get => currentUpper; set => currentUpper = value; }
        /// <summary>
        /// Lower limit, value below which an alarm is triggered
        /// </summary>
        public double CurrentLower { get => currentLower; set => currentLower = value; }
        public bool IsAlarmed { get => isAlarmed; set => isAlarmed = value; }

        /// <summary>
        /// Initializes the monitor sensor
        /// </summary>
        /// <param name="freq">Read frequency in milliseconds for the sensor</param>
        /// <param name="start">An initial reading to base the subsequent readings on</param>
        /// <param name="rng">The range that subsequent readings may vary above or below the current reading</param>
        /// <param name="upper">Upper limit for this sensor</param>
        /// <param name="lower">Lower limit for this sensor</param>
        public MonitorSensor(double freq, double start, double rng, double upper, double lower)
        {
            this.readFrequency = freq;
            this.startValue = start;
            this.currentValue = start;
            this.readTimer = new Timer(freq);
            this.random = new Random();
            this.readRange = rng;
            this.currentLower = lower;
            this.currentUpper = upper;

            readTimer.Elapsed += ReadTimer_Elapsed;
            readTimer.Start();
        }

        private void ReadTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            UpdateSelf();
            isAlarmed = CheckForAlarms();
        }

        /// <summary>
        /// Takes the current value and returns a new one within the read range
        /// </summary>
        /// <returns>Returns a double in the range of currentValue +/- readRange</returns>
        public double TakeReading() => (random.NextDouble() - 0.5) * readRange + currentValue;

        private void UpdateSelf() => currentValue = TakeReading();

        private bool CheckForAlarms()
        {
            if(currentValue>=currentUpper || currentValue<=currentLower)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }    
}
