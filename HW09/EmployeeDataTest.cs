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
            
            Assert.AreEqual(expected, eData.ParseName(email));
        }

        [Test]
        public void TestDoubleFirstName() {
            string email = "Tim-allen.Touring@hm.rt";
            string expected = "Tim Allen Touring";
            
            Assert.AreEqual(expected, eData.ParseName(email));
        }

        [Test]
        public void TestDoubleLastName() {
            string email = "Jim.jhon_son@g.eu";
            string expected = "Jim Jhon-Son";
            
            Assert.AreEqual(expected, eData.ParseName(email));
        }

        [Test]
        public void TestShortFirstName() {
            string email = "t.ilves@eesti.eu";
            string expected = "Unknown Ilves";

            Assert.AreEqual(expected, eData.ParseName(email));
        }

        [Test]
        public void TestEmailOne() {
            string email = "andre.griffin@ou.eu";
            string expected = "Andre Griffin";
            
            Assert.AreEqual(expected, eData.ParseName(email));
        }

        [Test]
        public void TestEmailTwo() {
            string email = "jhon.snow@gt.eu";
            string expected = "Jhon Snow";
            
            Assert.AreEqual(expected, eData.ParseName(email));
        }

        [Test]
        public void TestEmailThree() {
            string email = "tim-allen.toomingas@eu.eu";
            string expected = "Tim Allen Toomingas";
            
            Assert.AreEqual(expected, eData.ParseName(email));
        }

        [Test]
        public void TestEmailFour() {
            string email = "hei-hoo.chee_choo@china.eu";
            string expected = "Hei Hoo Chee-Choo";
            
            Assert.AreEqual(expected, eData.ParseName(email));
        }

        [Test]
        public void TestEmailFive() {
            string email = "a.chin_chan@c.e";
            string expected = "Unknown Chin-Chan";
            
            Assert.AreEqual(expected, eData.ParseName(email));
        }

        [Test]
        public void TestShortFirstAndLastName() {
            string email = "y.y@yo.yo";
            string expected = "Unknown Unknown";
            
            Assert.AreEqual(expected, eData.ParseName(email));
        }
    }
}