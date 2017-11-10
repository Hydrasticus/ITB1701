using NUnit.Framework;

namespace HW09 {
    [TestFixture]
    public class EmployeeDataTest {
        private EmployeeData eData;
        
        [SetUp]
        public void TestSetup() {
            eData = new EmployeeData();
        }

        [Test]
        public void TestSingleFirstAndLastName() {
            string email = "Mary.jones@contoso.com";
            string expected = "Mary Jones";
            
            Assert.AreEqual(eData.ParseName(email), expected);
        }

        [Test]
        public void TestDoubleFirstName() {
            string email = "Tim-allen.Touring@hm.rt";
            string expected = "Tim Allen Touring";
            
            Assert.AreEqual(eData.ParseName(email), expected);
        }

        [Test]
        public void TestDoubleLastName() {
            string email = "Jim.jhon_son@g.eu";
            string expected = "Jim Jhon-Son";
            
            Assert.AreEqual(eData.ParseName(email), expected);
        }

        [Test]
        public void TestShortFirstName() {
            string email = "t.ilves@eesti.eu";
            string expected = "Unknown Ilves";

            Assert.AreEqual(eData.ParseName(email), expected);
        }
    }
}