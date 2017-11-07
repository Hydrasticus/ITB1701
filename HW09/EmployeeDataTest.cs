using Microsoft.SqlServer.Server;
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
        public void TestCorrectOutput() {
            string email = "Mary.jones@contoso.com";
            string expected = "Mary Jones";
            
            Assert.AreEqual(eData.ParseData(email), expected);
        }
    }
}