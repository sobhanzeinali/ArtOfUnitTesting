using System.Runtime.InteropServices;
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
            //Arrange
            LogAnalyzer logAnalyzer = new LogAnalyzer();
            //Act
            bool result = logAnalyzer.IsValidLogFileName("filewiththebadextension.foo");
            //Assert
            Assert.False(result);
        }

        [TestCase("filewiththegoodextension.slf")]
        [TestCase("filewiththegoodextension.SLF")]
        public void IsValidFileName_ValidExtension_ReturnTrue(string fileName)
        {
            //Arrange
            LogAnalyzer logAnalyzer = new LogAnalyzer();
            //Act
            bool result = logAnalyzer.IsValidLogFileName(fileName);
            //Assert
            Assert.True(result);
        }
    }
}