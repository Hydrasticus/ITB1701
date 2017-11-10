using System;
using NUnit.Framework;

namespace HW09 {
    [TestFixture]
    public class TimeCalculatorTest {
        private TimeCalculator timeCalc;
        
        [SetUp]
        public void TestSetup() {
            timeCalc = new TimeCalculator();
        }

        [Test]
        public void TestFindTimeNegativeInput() {
            double input = -1;
            DateTime output = new DateTime(1999, 12, 31, 23, 0, 0);
            
            Assert.AreEqual(timeCalc.FindTime(input), output);
        }

        [Test]
        public void TestFindTimeZero() {
            double input = 0;
            DateTime output = new DateTime(2000, 1, 1, 0, 0, 0);
            
            Assert.AreEqual(timeCalc.FindTime(input), output);
        }
        
        [Test]
        public void TestFindTimePositiveInput() {
            double input = +2;
            DateTime output = new DateTime(2000, 1, 1, 2, 0, 0);
            
            Assert.AreEqual(timeCalc.FindTime(input), output);
        }
        
        [Test]
        public void TestFindTimeDouble() {
            double input = 25.5;
            DateTime output = new DateTime(2000, 1, 2, 1, 30, 0);
            
            Assert.AreEqual(timeCalc.FindTime(input), output);
        }
        
        [Test]
        public void TestAddDayNegativeInput() {
            double input = -2;
            DateTime output = new DateTime(2000, 1, 3);
            
            Assert.AreEqual(timeCalc.AddDay(input), output);
        }

        [Test]
        public void TestAddDayZero() {
            double input = 0;
            DateTime output = new DateTime(2000, 1, 1);
            
            Assert.AreEqual(timeCalc.AddDay(input), output);
        }

        [Test]
        public void TestAddDayPositiveInput() {
            double input = 5;
            DateTime output = new DateTime(2000, 1, 6);
            
            Assert.AreEqual(timeCalc.AddDay(input), output);
        }

        [Test]
        public void TestAddDayDouble() {
            double input = 0.5;
            DateTime output = new DateTime(2000, 1, 1, 12, 0, 0);
            
            Assert.AreEqual(timeCalc.AddDay(input), output);            
        }

        [Test]
        public void TestSubtractDayNegativeInput() {
            double input = -5;
            DateTime output = new DateTime(1999, 12, 27);
            
            Assert.AreEqual(timeCalc.SubtractDay(input), output);
        }

        [Test]
        public void TestSubtractDayZero() {
            double input = 0;
            DateTime output = new DateTime(2000, 1, 1);
            
            Assert.AreEqual(timeCalc.SubtractDay(input), output);
        }

        [Test]
        public void TestSubtractDayPositiveInput() {
            double input = 10;
            DateTime output = new DateTime(1999, 12, 22);
            
            Assert.AreEqual(timeCalc.SubtractDay(input), output);
        }

        [Test]
        public void TestSubtractDayDouble() {
            double input = 2.5;
            DateTime output = new DateTime(1999, 12, 29, 12, 0, 0);
            
            Assert.AreEqual(timeCalc.SubtractDay(input), output);
        }
    }
}