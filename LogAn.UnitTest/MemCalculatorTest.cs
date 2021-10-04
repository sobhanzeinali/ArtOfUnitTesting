using NUnit.Framework;

namespace LogAn.UnitTest
{
    public class MemCalculatorTest
    {
        private MemCalculator MakeCalculator()
        {
            return new MemCalculator();
        }

        [Test]
        public void Sum_ByDefault_ReturnZero()
        {
            MemCalculator mc = MakeCalculator();

            int lastSum = mc.Sum();

            Assert.AreEqual(0, lastSum);
        }

        [Test]
        public void Add_WhenCalled_ChangeSum()
        {
            MemCalculator mc = MakeCalculator();

            mc.Add(1);

            Assert.AreEqual(1, mc.Sum());
        }
    }
}