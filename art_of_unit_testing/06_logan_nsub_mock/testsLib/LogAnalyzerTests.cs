using System;
using lib;
using NSubstitute;
using NUnit.Framework;

namespace testsLib
{
    public class LogAnalyzerTests
    {

        [Test]
        public void Analyze_TooShortFileName_CallLogger()
        {
            ILogger logger = Substitute.For<ILogger>();
            LogAnalyzer analyzer = new LogAnalyzer(logger);

            analyzer.MinNameLength = 6;
            analyzer.Analyze("a.txt");

            logger.Received().LogError("Filename too short:a.txt");
        }


    }
}