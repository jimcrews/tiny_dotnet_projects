using System;
using lib;
using NUnit.Framework;

namespace testsLib
{
    public class Tests
    {
        [TestCase("filewithgoodextension.SLF", true)]
        [TestCase("filewithgoodextension.slf", true)]
        [TestCase("filewithbadextension.foo", false)]
        public void IsValidFileName_VariousExtensions_ChecksThem(string file, bool expected)
        {
            // arrange
            LogAnalyzer analyzer = new LogAnalyzer();

            // act
            bool result = analyzer.IsValidLogFileName(file);

            // assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsValidFileName_EmptyFileName_Throws()
        {
            // arrange
            LogAnalyzer analyzer = new LogAnalyzer();

            // returns the instance of the exception object that was thrown inside the lambda
            var ex = Assert.Catch<Exception>(() => analyzer.IsValidLogFileName(""));

            // assert
            StringAssert.Contains("filename has to be provided", ex.Message);
        }

    }
}