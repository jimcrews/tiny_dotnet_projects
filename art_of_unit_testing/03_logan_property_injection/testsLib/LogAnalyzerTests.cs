using System;
using lib;
using NUnit.Framework;

namespace testsLib
{
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidFileName_SupportedExtension_ReturnsTrue()
        {
            var fakeExtensionManager = new FakeExtensionManager();
            fakeExtensionManager.willBeValid = true;

            LogAnalyzer log = new LogAnalyzer();
            log.ExtensionManager = fakeExtensionManager; // inject stub here

            bool result = log.IsValidLogFileName("fileName.txt");

            Assert.True(result);
        }

    }
}