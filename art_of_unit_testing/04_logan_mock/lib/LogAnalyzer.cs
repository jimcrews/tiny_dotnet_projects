using System;

namespace lib
{
    public class LogAnalyzer
    {
        private IWebService webService;

        public LogAnalyzer(IWebService webService)
        {
            this.webService = webService;
        }


        public void Analyse(string fileName)
        {
            if (fileName.Length < 8)
            {
                webService.LogError("Filename too short:" + fileName);
            }

        }
    }
}
