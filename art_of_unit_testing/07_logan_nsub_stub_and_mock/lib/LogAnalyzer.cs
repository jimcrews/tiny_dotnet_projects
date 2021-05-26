using System;

namespace lib
{
    public class LogAnalyzer
    {
        private readonly IWebService webService;
        private readonly ILogger logger;
        public int MinFileNameLength { get; set; }




        public LogAnalyzer(IWebService webService, ILogger logger)
        {
            this.webService = webService;
            this.logger = logger;
        }


        public void Analyze(string fileName)
        {
            if (fileName.Length < MinFileNameLength)
            {
                try
                {
                    logger.LogError("Filename too short: " + fileName);
                }
                catch (Exception e)
                {
                    webService.Write("Error from logger: " + e);
                }
            }
        }
    }
}
