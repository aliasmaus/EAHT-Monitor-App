using Microsoft.VisualStudio.TestTools.UnitTesting;
using EAHT_Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAHT_Engine.Tests
{
    [TestClass()]
    public class MonitorSensor_Tests
    {
        [TestMethod()]
        public void TakeReadingTest()
        {
            // Arrange
            double initialVal = 50;
            double range = 0.5;
            MonitorSensor monitor = new MonitorSensor(1000,initialVal,range);

            //Act
            double result = monitor.TakeReading();
            
            // Assert
            Assert.IsTrue(result < (initialVal + range) && result > (initialVal - range), "Result was not within expected range " + result.ToString());
        }
    }
}