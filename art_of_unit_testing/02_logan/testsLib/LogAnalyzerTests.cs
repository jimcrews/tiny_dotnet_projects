using System;
using lib;
using NUnit.Framework;

namespace testsLib
{
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidFileName_NameSupportedExtension_ReturnsTrue()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.willBeValid = true;

            LogAnalyzer log = new LogAnalyzer(myFakeManager); // send in stub

            bool result = log.IsValidLogFileName("fileName.txt");

            Assert.True(result);
        }

    }
}