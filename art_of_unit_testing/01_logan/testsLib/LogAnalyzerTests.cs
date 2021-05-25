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
        public void alwaysPass()
        {
            Assert.IsTrue(1 == 1);
        }

    }
}