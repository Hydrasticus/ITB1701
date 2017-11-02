using NUnit.Framework;

namespace PR09 {
    [TestFixture]
    public class BusTest {
        Bus bus;

        [SetUp]
        public void TestSetup() {
            bus = new Bus();
        }

        [Test]
        public void Test60People() {
            bus.FindNumbers(60, 40);
            Assert.AreEqual(bus.ReturnBuses(), 2);
            Assert.AreEqual(bus.ReturnNrOfPeople(), 20);
        }

        [Test]
        public void Test80People() {
            bus.FindNumbers(80, 40);
            Assert.AreEqual(bus.ReturnBuses(), 2);
            Assert.AreEqual(bus.ReturnNrOfPeople(), 40);
        }
        
        [Test]
        public void Test20People() {
            bus.FindNumbers(20, 40);
            Assert.AreEqual(bus.ReturnBuses(), 1);
            Assert.AreEqual(bus.ReturnNrOfPeople(), 20);
        }

        [Test]
        public void Test40People() {
            bus.FindNumbers(40, 40);
            Assert.AreEqual(bus.ReturnBuses(), 1);
            Assert.AreEqual(bus.ReturnNrOfPeople(), 40);
        }
    }
}