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
        private Random random;
        private double currentValue;

        /// <summary>
        /// Initializes the monitor sensor
        /// </summary>
        /// <param name="freq">Read frequency in milliseconds for the sensor</param>
        /// <param name="start">An initial reading to base the subsequent readings on</param>
        /// <param name="rng">The range that subsequent readings may vary above or below the current reading</param>
        public MonitorSensor(double freq, double start, double rng)
        {
            this.readFrequency = freq;
            this.startValue = start;
            this.currentValue = start;
            this.readTimer = new Timer(freq);
            this.random = new Random();
            this.readRange = rng;

            readTimer.Elapsed += ReadTimer_Elapsed;
            readTimer.Start();
        }

        private void ReadTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            UpdateSelf();
        }

        /// <summary>
        /// Takes the current value and returns a new one within the read range
        /// </summary>
        /// <returns>Returns a double in the range of currentValue +/- readRange</returns>
        public double TakeReading() => (random.NextDouble() - 0.5) * readRange + currentValue;

        private void UpdateSelf() => currentValue = TakeReading();

    }    
}
