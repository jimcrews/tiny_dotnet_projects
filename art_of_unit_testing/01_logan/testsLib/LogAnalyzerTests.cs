using lib;
using NUnit.Framework;

namespace testsLib
{
    public class Tests
    {
        [Test]
        public void IsValidFileName_BadExtension_ReturnsFalse()
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");

            Assert.False(result);
        }
    }
}