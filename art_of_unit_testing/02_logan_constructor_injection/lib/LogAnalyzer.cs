using System;

namespace lib
{
    public class LogAnalyzer
    {
        private IExtensionManager manager;

        public LogAnalyzer(IExtensionManager mgr)
        {
            manager = mgr;
        }

        public bool IsValidLogFileName(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException(
                    "filename has to be provided");
            }

            return manager.isValid(fileName);
        }
    }
}
