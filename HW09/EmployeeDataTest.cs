using Microsoft.SqlServer.Server;
using NUnit.Framework;

namespace HW09 {
    [TestFixture]
    public class EmployeeDataTest {
        [SetUp]
        public void TestSetup() {
            
        }

        [Test]
        public void TestCorrectOutput() {
            string email = "Mary.jones@contoso.com";
            string expected = "Mary Jones";
            
            Assert.AreEqual(email, expected);
        }
    }
}