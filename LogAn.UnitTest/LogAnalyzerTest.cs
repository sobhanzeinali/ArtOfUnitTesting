using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace LogAn.UnitTest
{
    public class LogAnalyzerTest
    {
        private LogAnalyzer MakeAnalyzer()
        {
            return new LogAnalyzer();
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

        [Test]
        public void IsValidFileName_EmptyString_ThrowsException()
        {
            // Arrange
            LogAnalyzer la = MakeAnalyzer();

            var ex = Assert.Catch<Exception>(() => la.IsValidLogFileName(""));

            StringAssert.Contains("filename has to be provided", ex.Message);
        }

        [TestCase("badfile.foo", false)]
        [TestCase("goodfile.slf", true)]
        public void IsValidFileName_WhenCalled_ChangeWasLastFileNameValid(string fileName, bool expected)
        {
            LogAnalyzer la = MakeAnalyzer();

            la.IsValidLogFileName(fileName);

            Assert.AreEqual(expected, la.WasLastFileNameValid);
        }
    }
}