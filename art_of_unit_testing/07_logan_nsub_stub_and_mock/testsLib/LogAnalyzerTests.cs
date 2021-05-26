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
            var mockWebService = Substitute.For<IWebService>();
            var stubLogger = Substitute.For<ILogger>();

            stubLogger.When(logger => logger.LogError(Arg.Any<string>())).Do(
                info =>
                {
                    throw new Exception("fake exception");
                }
            );

            var analyzer = new LogAnalyzer(mockWebService, stubLogger);
            analyzer.MinFileNameLength = 6;
            analyzer.Analyze("a.txt");

            mockWebService.Received().Write(Arg.Is<string>(s => s.Contains("fake exception")));
        }


    }
}