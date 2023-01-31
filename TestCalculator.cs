using Math;
using NUnit.Framework;

namespace TestCalculator.NUnit
{
    [TestFixture]
    public class TestCalculator
    {
        Calculator calculator;
        [OneTimeSetUp]
        public void SetUp()
        {
            calculator = new Calculator(100, 200);
        }
        [Test]
        [Category("testing time limit")]
        [Timeout(15)]
        public void testaddition()
        {

            float desiredresult = calculator.Addition(100, 200);
            Assert.AreEqual(300, desiredresult);
        }

        [Test]
        [Timeout(15)]
        public void TestMultiplication()
        {
            Calculator calculator = new Calculator(-150, 1200);
            float DesiredResult = calculator.Multiplication(-150, 1200);
            Assert.AreEqual(-180000, DesiredResult);
        }

        [Test]
        [Timeout(15)]
        public void TestSubtraction()
        {
            Calculator calculator = new Calculator(-800, 1600);
            float DesiredResult = calculator.Subtraction(-800, 1600);
            Assert.AreEqual(-2400, DesiredResult);
        }

        [Test]
        [Timeout(15)]
        public void TestDivision()
        {
            Calculator calculator = new Calculator(-800, 200);
            float DesiredResult = calculator.Division(-800, 200);
            Assert.AreEqual(-4, DesiredResult);
        }
    }
}