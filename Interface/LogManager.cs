using System;

namespace Interface
{
    public class LogManager:ILogger
    {
        public ILogger _Logger;

        public LogManager(ILogger Logger)
        {
            _Logger = Logger;
        }
        public void writeLog()
        {
            _Logger.writeLog();
        }
    }
}