using System;
using lib;
using NUnit.Framework;

namespace testsLib
{
    public class LogAnalyzerTests
    {
        [Test]
        public void Analyse_TooShortFileName_CallsWebService()
        {
            FakeWebService mockService = new FakeWebService();
            LogAnalyzer log = new LogAnalyzer(mockService);

            string tooShortFilename = "abc.txt";

            log.Analyse(tooShortFilename);

            StringAssert.Contains("Filename too short:abc.txt", mockService.LastError);
        }

    }
}