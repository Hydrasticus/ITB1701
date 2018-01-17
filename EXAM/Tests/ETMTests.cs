using EXAM;
using NUnit.Framework;

namespace EXAM.Tests {
    
    [TestFixture]
    public class ETMTests {
        EconomyTicketMachine etm;

        [SetUp]
        public void SetUp() {
            etm = new EconomyTicketMachine("EATLLTYO5", "2017-05-29");
        }

        [Test]
        public void OriginTest() {
            string expected = "Tokyo";
            Assert.AreEqual(etm._origin, expected);
        }
    }
}