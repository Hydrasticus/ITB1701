using NUnit.Framework;

namespace HW09 {
    [TestFixture]
    public class ExercisesTest {
        Exercises exercises;

        [SetUp]
        public void TestSetup() {
            exercises = new Exercises();
        }

        [Test]
        public void TestAddTwoEmptyStrings() {
            string a = "";
            string b = "";
            
            Assert.AreEqual(exercises.JoinTwoStrings(a, b), "");
        }

        [Test]
        public void TestAddTwoSpaces() {
            string a = " ";
            string b = " ";
            
            Assert.AreEqual(exercises.JoinTwoStrings(a, b), "  ");
        }

        [Test]
        public void TestAddStringWithEmptyString() {
            string a = "Test";
            string b = "";
            
            Assert.AreEqual(exercises.JoinTwoStrings(a, b), "Test");
        }

        [Test]
        public void TestAddTwoStrings() {
            string a = "Testing";
            string b = "Test";
            
            Assert.AreEqual(exercises.JoinTwoStrings(a, b), "TestingTest");
        }

        [Test]
        public void TestArrayLengthIsSix() {
            int[] array = exercises.ReturnArray();
            
            Assert.AreEqual(array.Length, 6);
        }

        [Test]
        public void TestNoMemberLessThanZero() {
            int[] array = exercises.ReturnArray();
            
            Assert.That(array, Has.None.LessThan(0));
        }

        [Test]
        public void TestNoMemberLargerThan200() {
            int[] array = exercises.ReturnArray();
            
            Assert.That(array, Has.None.GreaterThan(200));
        }

        [Test]
        public void TestArrayHasNoNullMembers() {
            int[] array = exercises.ReturnArray();
            
            Assert.That(array, Has.None.Null);
        }

        [Test]
        public void TestCalculateUnderweightBMI() {
            double weight = 50;
            double height = 1.88;
            
            Assert.AreEqual(exercises.CalculateBMI(weight, height), "Underweight");
        }

        [Test]
        public void TestCalculateNormalBMI() {
            double weight = 62;
            double height = 1.653;

            Assert.AreEqual(exercises.CalculateBMI(weight, height), "Normal");
        }

        [Test]
        public void TestCalculateOverweightBMI() {
            double weight = 68;
            double height = 1.60;
            
            Assert.AreEqual(exercises.CalculateBMI(weight, height), "Overweight");
        }

        [Test]
        public void TestCalculateObeseBMI() {
            double weight = 92;
            double height = 1.75;
            
            Assert.AreEqual(exercises.CalculateBMI(weight, height), "Obese");
        }

        [Test]
        public void TestReplaceSpaces() {
            string s = "A suh dude";
            
            Assert.AreEqual(exercises.ReplaceSpaces(s), "A*suh*dude");
        }

        [Test]
        public void TestReplaceMultipleSpaces() {
            string s = "Somebody     once   told    me";
            
            Assert.AreEqual(exercises.ReplaceSpaces(s), "Somebody*once*told*me");
        }

        [Test]
        public void TestOutputDoesNotContainSpaces() {
            string s = "Welcome to the rice fields";
            
            Assert.IsFalse(exercises.ReplaceSpaces(s).Contains(" "));
        }

        [Test]
        public void TestStringIsUnchanged() {
            string s = "Chewbacca";
            
            Assert.AreEqual(exercises.ReplaceSpaces(s), s);
        }
    }
}