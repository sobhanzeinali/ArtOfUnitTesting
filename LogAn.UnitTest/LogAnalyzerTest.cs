using NUnit.Framework;

namespace LogAn.UnitTest
{
    public class LogAnalyzerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsValidFileName_BadExtension_ReturnFalse()
        {
            Assert.Pass();
        }
    }
}