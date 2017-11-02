using NUnit.Framework;

namespace PR09 {
    [TestFixture]
    public class CalculatorTest {
        Calculator calc;

        [SetUp]
        public void TestSetup() {
            calc = new Calculator();
        }

        [Test]
        public void ShouldSubtractTwoNumbers() {
            int expectedResult = calc.Subtract(9, 2);
            Assert.That(expectedResult, Is.EqualTo(7));
        }

        [Test]
        public void ShouldSubtractTwoDoubles() {
            double expectedResult = calc.Subtract(3.4, 1.0);
            double tolerance = 0.1;
            Assert.That(expectedResult, Is.EqualTo(2.4).Within(tolerance));
        }

        [Test]
        public void ShouldMultiplyTwoInts() {
            int expResult = calc.Multiply(3, 2);
            Assert.AreEqual(expResult, 6);
        }

        [Test]
        public void ShouldMultiplyTwoDoubles() {
            double expResult = calc.Multiply(1.1, 2.2);
            Assert.AreEqual(expResult, 2.42);
        }

        [Test]
        public void ShouldMultiplyThreeInts() {
            int expResult = calc.Multiply(1, 1, 2);
            Assert.AreEqual(expResult, 2);
        }

        [Test]
        public void ShouldMultiplyThreeDoubles() {
            double expResult = calc.Multiply(1.1, 2.2, 1.0);
            Assert.AreEqual(expResult, 2.42);
        }

        [Test]
        public void ShouldSquareInt() {
            int expResult = calc.Square(4);
            Assert.AreEqual(expResult, 16);
        }

        [Test]
        public void ShouldSquareDouble() {
            double expResult = calc.Square(1.2);
            Assert.AreEqual(expResult, 1.44);
        }
    }
}