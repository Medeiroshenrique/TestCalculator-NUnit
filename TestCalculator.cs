using Math;
using NUnit.Framework;

namespace TestCalculator.NUnit
{
    [TestFixture]
    public class TestCalculator
    {
        [Test]
        public void TestAddition() {
            Calculator calculator = new Calculator(100, 200);
            float DesiredResult = calculator.Addition(100,200);
            Assert.AreEqual(300,DesiredResult);
        }

        [Test]
        public void TestMultiplication()
        {
            Calculator calculator = new Calculator(-150, 1200);
            float DesiredResult = calculator.Multiplication(-150, 1200);
            Assert.AreEqual(-180000, DesiredResult);
        }

        [Test]
        public void TestSubtraction()
        {
            Calculator calculator = new Calculator(-800, 1600);
            float DesiredResult = calculator.Subtraction(-800, 1600);
            Assert.AreEqual(-2400, DesiredResult);
        }

        [Test]
        public void TestDivision()
        {
            Calculator calculator = new Calculator(-800, 200);
            float DesiredResult = calculator.Division(-800, 200);
            Assert.AreEqual(-8, DesiredResult);
        }
    }
}