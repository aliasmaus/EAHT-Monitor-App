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
    public class Make_Your_Code_Classes_In_This_Project_Not_The_UI_Tests
    {
        [TestMethod()]
        public void TestMethodTest()
        {
            //arrange
            int num1 = 10;
            int num2 = 5;

            //act
            int result = EAHT_Engine.Make_Your_Code_Classes_In_This_Project_Not_The_UI.TestMethod(num1, num2);

            //assert
            Assert.AreEqual(result, 15);
        }
    }
}