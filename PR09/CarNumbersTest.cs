using System.Collections.Generic;
using NUnit.Framework;

namespace PR09 {
    [TestFixture]
    public class CarNumbersTest {
        CarRegCodes carNumbers;

        [SetUp]
        public void TestSetup() {
            carNumbers = new CarRegCodes();
        }

        [Test]
        public void TestStringCode() {
            string value = "MLU";
            List<string> codes = carNumbers.GenerateFourCodes(value);
            
            Assert.That(codes.Count, Is.EqualTo(4));
        }

        [Test]
        public void Test2() {
            string value = "MLU";
            List<string> codes = carNumbers.GenerateFourCodes(value);
            Assert.That(codes, Has.All.Contains(value));
        }

        [Test]
        public void Test3() {
            string value = "MLU";
            List<string> codes = carNumbers.GenerateFourCodes(value);
            Assert.That(codes, Is.Unique);
        }
    }
}