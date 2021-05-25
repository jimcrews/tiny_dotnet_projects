using System;

namespace lib
{
    public class LogAnalyzer
    {
        private IExtensionManager manager;

        public LogAnalyzer()
        {
            manager = new FileExtensionManager();
        }

        // allows setting a dependency via a property
        public IExtensionManager ExtensionManager
        {
            get { return manager; }
            set { manager = value; }
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
